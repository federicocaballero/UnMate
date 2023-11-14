using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller.Capas.Capa_datos.Supervisor
{
    internal class ClaseEstadisticas
    {

        private SqlConnection EstadisticasGeneradas;
        private DataGridView GridCompras;
        private Chart CVendedores;
        private Chart CProductos;

        public ClaseEstadisticas(DataGridView GridCompras, Chart CVendedores, Chart CProductos)
        {
            EstadisticasGeneradas = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.GridCompras = GridCompras;
            this.CVendedores = CVendedores;
            this.CProductos = CProductos;
        }

        public void TopCompras()
        {
            string consulta = "SELECT TOP 3 V.Cod_Venta, " +
                "CONCAT(C.Nombre, ' ', C.Apellido) AS Cliente, C.DNI_Cliente AS DNI, " +
                "CONCAT(E.Nombre, ' ', E.Apellido) AS Empleado, E.DNI, " +
                "V.Total, V.Fecha " + "FROM Venta V " +
                "INNER JOIN Cliente C ON V.Cod_Cliente = C.Cod_Cliente " +
                "INNER JOIN Empleado E ON V.Cod_Empleado = E.Cod_Empleado " +
                "ORDER BY V.Total DESC";

            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            using (SqlDataAdapter lista = new SqlDataAdapter(consulta, conexion))
            {
                DataTable dt = new DataTable();
                lista.Fill(dt);
                GridCompras.DataSource = dt;
            }

            GridCompras.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex < 0 || e.RowIndex >= GridCompras.Rows.Count)
                    return;

                // alternar colores de fondo para las filas
                if (e.RowIndex % 2 == 0)
                {
                    e.CellStyle.BackColor = Color.LightBlue;
                }
                else
                {
                    e.CellStyle.BackColor = Color.LightCyan;
                }

            };
        }


        public void MostrarTopVendedores(DateTimePicker TFecha, DateTimePicker THasta)
        {
            DateTime fechaDesde = TFecha.Value;
            DateTime fechaHasta = THasta.Value;

            string consulta = "SELECT E.Nombre + ' ' + E.Apellido AS NombreVendedor, " +
                "COUNT(V.Cod_Venta) AS CantidadVentas " + "FROM Venta V " +
                "INNER JOIN Empleado E ON V.Cod_Empleado = E.Cod_Empleado " +
                "WHERE CONVERT(date, V.Fecha) >= CONVERT(date, @FechaDesde) AND CONVERT(date, V.Fecha) <= CONVERT(date, @FechaHasta) " +
                "GROUP BY E.Nombre, E.Apellido " +
                "ORDER BY CantidadVentas DESC";

            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            using (SqlDataAdapter lista = new SqlDataAdapter(consulta, conexion))
            {
                lista.SelectCommand.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                lista.SelectCommand.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                DataTable dt = new DataTable();
                lista.Fill(dt);

                // elimina las áreas y series anteriores si las hubiera
                CVendedores.ChartAreas.Clear();
                CVendedores.Series.Clear();

                // agrega una nueva área
                ChartArea chartArea = new ChartArea("Vendedores");
                chartArea.BackHatchStyle = ChartHatchStyle.None;
                chartArea.BackColor = Color.Transparent;
                CVendedores.ChartAreas.Add(chartArea);

                // crea la serie de tipo pastel solo si hay datos
                if (dt.Rows.Count > 0)
                {
                    Series series = new Series
                    {
                        Name = "Ventas",
                        ChartType = SeriesChartType.Doughnut,
                        IsVisibleInLegend = true,
                    };

                    double totalVentas = Convert.ToDouble(dt.Compute("SUM(CantidadVentas)", ""));

                    foreach (DataRow row in dt.Rows)
                    {
                        string nombreVendedor = row["NombreVendedor"].ToString();
                        int cantidadVentas = Convert.ToInt32(row["CantidadVentas"]);
                        double porcentaje = (cantidadVentas / totalVentas) * 100;

                        DataPoint dataPoint = new DataPoint
                        {
                            // solo muestra el porcentaje en las porciones del gráfico
                            Label = $"{porcentaje:F1}%",
                            YValues = new double[] { cantidadVentas }
                        };
                        series.Points.Add(dataPoint);

                        // agrega el nombre y porcentaje a la leyenda
                        series.Points[series.Points.Count - 1].LegendText = $"{nombreVendedor}";

                
                    }

                    // agrega la serie al gráfico
                    CVendedores.Series.Add(series);
                }

                else
                {
                    // si no hay datos, crea una serie vacía y agrega un punto de datos ficticio
                    Series emptySeries = new Series
                    {
                        Name = "Ventas",
                        ChartType = SeriesChartType.Doughnut,
                        IsVisibleInLegend = true,
                    };

                    DataPoint chartVacio = new DataPoint
                    {
                        YValues = new double[] { 100 },
                        Label = "Sin datos"
                    };
                    emptySeries.Points.Add(chartVacio);

                    CVendedores.Series.Add(emptySeries);
                }
            }
        }

        public void MostrarCategoriasMasVendidas(DateTimePicker TFecha, DateTimePicker THasta)
        {
            DateTime fechaDesde = TFecha.Value;
            DateTime fechaHasta = THasta.Value;

            string consulta = "SELECT  C.Descripcion AS NombreCategoria, SUM(DV.Cantidad) AS CantidadVendida " +
                "FROM DetalleVenta DV " +
                "INNER JOIN Producto P ON DV.Cod_Producto = P.Cod_producto " +
                "INNER JOIN Categoria C ON P.ID_Categoria = C.ID_Categoria " +
                "INNER JOIN Venta V ON DV.Cod_Venta = V.Cod_Venta " +
                "WHERE CONVERT(date, V.Fecha) >= CONVERT(date, @FechaDesde) AND CONVERT(date, V.Fecha) <= CONVERT(date, @FechaHasta) " +
                "GROUP BY C.Descripcion " + "ORDER BY CantidadVendida DESC";

            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            using (SqlCommand comando = new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                comando.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                DataTable dt = new DataTable();

                conexion.Open();

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    dt.Load(reader);
                }

                conexion.Close();

                CProductos.Series.Clear();
                CProductos.ChartAreas.Clear();

                ChartArea chartArea = new ChartArea("CategoriasMasVendidas");
                chartArea.AxisX.Title = "Categorías";
                chartArea.AxisY.Title = "Cantidad Vendida";
                chartArea.AxisX.TitleFont = new System.Drawing.Font("Arial", 12);
                chartArea.AxisY.TitleFont = new System.Drawing.Font("Arial", 12);
                chartArea.BackColor = Color.White;
                CProductos.ChartAreas.Add(chartArea);

                if (dt.Rows.Count > 0)
                {
                    Series series = new Series
                    {
                        ChartType = SeriesChartType.Column
                    };

                    series.IsVisibleInLegend = false;

                    // aumentar el espacio entre columnas
                    series["PointWidth"] = "0.8";

                    // colores personalizados para cada categoría
                    string[] colores = { "Red", "Green", "Blue" };
                    int colorIndex = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        string nombreCategoria = row["NombreCategoria"].ToString();
                        int cantidadVendida = Convert.ToInt32(row["CantidadVendida"]);
                        DataPoint dataPoint = new DataPoint();
                        dataPoint.YValues = new double[] { cantidadVendida };
                        dataPoint.Label = $"{nombreCategoria}: {cantidadVendida}";
                        dataPoint.Color = System.Drawing.Color.FromName(colores[colorIndex % colores.Length]);
                        series.Points.Add(dataPoint);

                        colorIndex++;
                    }

                    CProductos.Series.Add(series);
                    CProductos.Series[0]["LabelStyle"] = "Top";
                    CProductos.Series[0].IsValueShownAsLabel = true;
                }
                else
                {
                    // si no hay datos, crea una serie vacía y agrega un punto de datos ficticio
                    Series emptySeries = new Series
                    {
                       
                        ChartType = SeriesChartType.Column,
                        IsVisibleInLegend = false
                    };

                    DataPoint chartVacio = new DataPoint();
                    chartVacio.YValues = new double[] { 100 };
                    chartVacio.Label = "Sin datos";
                    chartVacio.Color = System.Drawing.Color.Red;
                    emptySeries.Points.Add(chartVacio);

                    CProductos.Series.Add(emptySeries);
                    CProductos.Series[0]["LabelStyle"] = "Top";
                    CProductos.Series[0].IsValueShownAsLabel = true;
                }

                // ajustar el tamaño del control Chart
                CProductos.Size = new System.Drawing.Size(400, 235);
            }
        }


        public void pdfEstadistica()
        {
            // crear un nuevo documento PDF
            Document doc = new Document();

            // definir una ubicación y nombre de archivo para el PDF
            string pdfFileName = "EstadisticaGenerada.pdf";
            try
            {

                //crear un archivo PDF en la ubicación deseada
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfFileName, FileMode.Create));

                // abrir el documento para editar
                doc.Open();

                // agregar la imagen en la esquina superior derecha
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnMateLogo.png");
                if (File.Exists(imagePath))
                {
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath);

                    img.ScaleToFit(150, 150);
                    img.SetAbsolutePosition(doc.PageSize.Width - 120, doc.PageSize.Height - 160);

                    doc.Add(img);
                }

             
                Paragraph fecha = new Paragraph("Fecha de archivo: " + DateTime.Now);
                fecha.Alignment = Element.ALIGN_LEFT;
                doc.Add(fecha); doc.Add(new Paragraph("\n"));
                Paragraph empresaInfo = new Paragraph();
                empresaInfo.Alignment = Element.ALIGN_LEFT;
                empresaInfo.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f); // Cambiar el tipo de letra
                empresaInfo.Add("Nombre de empresa: UnMate S.A.\n");
                empresaInfo.Add("Dirección: Av. San Martin 220, Corrientes\n");
                empresaInfo.Add("Teléfono: (3794) 456-7890\n");
                doc.Add(empresaInfo); doc.Add(new Paragraph("\n"));

                Paragraph tituloInfoEmpresa = new Paragraph("Estadísticas obtenidas");
                tituloInfoEmpresa.Alignment = Element.ALIGN_CENTER;
                tituloInfoEmpresa.Font.Size = 20f;
                tituloInfoEmpresa.Font.Color = BaseColor.BLACK;

                // añadir espacio después del título
                tituloInfoEmpresa.SpacingAfter = 10f;

                doc.Add(tituloInfoEmpresa);
                doc.Add(new Paragraph("\n"));



                // crear un párrafo para centrar los gráficos y la tabla
                Paragraph centerParagraph = new Paragraph();
                centerParagraph.Alignment = Element.ALIGN_CENTER;

                // agregar el primer gráfico al párrafo
                MemoryStream chart1Stream = new MemoryStream();
                CVendedores.SaveImage(chart1Stream, ChartImageFormat.Png);
                iTextSharp.text.Image chart1Image = iTextSharp.text.Image.GetInstance(chart1Stream.GetBuffer());
                chart1Image.ScalePercent(75f);
                centerParagraph.Add(new Chunk(chart1Image, 0, 0, true));

                // agregar espacio entre los gráficos
                centerParagraph.Add(new Chunk("     "));

                // agregar el segundo gráfico al párrafo
                MemoryStream chart2Stream = new MemoryStream();
                CProductos.SaveImage(chart2Stream, ChartImageFormat.Png);
                iTextSharp.text.Image chart2Image = iTextSharp.text.Image.GetInstance(chart2Stream.GetBuffer());
                chart2Image.ScalePercent(75f);
                centerParagraph.Add(new Chunk(chart2Image, 0, 0, true));

                // agregar el párrafo al documento
                doc.Add(centerParagraph);

                // agregar espacio entre los gráficos y la tabla
                doc.Add(new Paragraph("\n"));


                PdfPTable table = new PdfPTable(GridCompras.Columns.Count);
                table.WidthPercentage = 90;
                table.HorizontalAlignment = Element.ALIGN_CENTER;

                // ajusta el tamaño de fuente de la tabla
                float fontSize = 9;

                PdfPCell cell = new PdfPCell(new Phrase("TOP ventas realizadas"));
                cell.Colspan = GridCompras.Columns.Count;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Phrase.Font.Size = fontSize;
                table.AddCell(cell);

                for (int i = 0; i < GridCompras.Columns.Count; i++)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(GridCompras.Columns[i].HeaderText));
                    headerCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    headerCell.Phrase.Font.Size = fontSize;
                    table.AddCell(headerCell);
                }

                for (int i = 0; i < GridCompras.Rows.Count; i++)
                {
                    for (int j = 0; j < GridCompras.Columns.Count; j++)
                    {
                        if (GridCompras[j, i].Value != null)
                        {
                            PdfPCell dataCell = new PdfPCell(new Phrase(GridCompras[j, i].Value.ToString()));
                            dataCell.Phrase.Font.Size = fontSize;
                            table.AddCell(dataCell);
                        }
                    }
                }

                // aumenta el espacio entre las columnas
                table.SpacingAfter = 10f;

                doc.Add(table);

                // cerrar el documento
                doc.Close();

                // abrir el archivo PDF en el visor de PDF predeterminado
                System.Diagnostics.Process.Start(pdfFileName);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar y descargar el PDF: " + ex.Message);
            }
        }


    }
}




    

