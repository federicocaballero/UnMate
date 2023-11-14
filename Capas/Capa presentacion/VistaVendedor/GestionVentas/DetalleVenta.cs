using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    public partial class DetalleVenta : Form
    {

        private int codigoVenta;
        public int CodigoVenta
        {
            get { return codigoVenta; }
            set { codigoVenta = value; }
        }
        public DetalleVenta()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // crear un nuevo documento PDF
            Document doc = new Document();

            // definir una ubicación y nombre de archivo para el PDF
            string pdfFileName = "Factura.pdf";

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

                Paragraph idVenta = new Paragraph("ID venta: " + TBCodVenta.Text);
                idVenta.Alignment = Element.ALIGN_LEFT;

                Paragraph factura = new Paragraph("Factura de Venta");
                factura.Alignment = Element.ALIGN_CENTER;

                // agregar título de información de la empresa
                Paragraph tituloInfoEmpresa = new Paragraph("Información de la Empresa");
                tituloInfoEmpresa.Alignment = Element.ALIGN_LEFT;
                tituloInfoEmpresa.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16f, BaseColor.RED); 
                tituloInfoEmpresa.SpacingAfter = 10f; 

                // agregar información de la empresa
                Paragraph empresaInfo = new Paragraph();
                empresaInfo.Alignment = Element.ALIGN_LEFT;
                empresaInfo.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f); // Cambiar el tipo de letra
                empresaInfo.Add("Nombre de empresa: UnMate S.A.\n");
                empresaInfo.Add("Dirección: Av. San Martin 220, Corrientes\n");
                empresaInfo.Add("Teléfono: (3794) 456-7890\n");

                doc.Add(idVenta);
                doc.Add(factura);
                doc.Add(tituloInfoEmpresa);
                doc.Add(empresaInfo);
                doc.Add(new Paragraph("\n"));
                
                //crear una tabla para la información de la venta
                PdfPTable infoTable = new PdfPTable(2);
                infoTable.WidthPercentage = 96;


                Paragraph informacion = new Paragraph("Informacion de cliente");
                informacion.Alignment = Element.ALIGN_CENTER;
                // agregar celdas con la información de la venta
                doc.Add(informacion);
                doc.Add(new Paragraph("\n"));
                infoTable.AddCell(new PdfPCell(new Phrase("Fecha: " + TBFecha.Text)));
                infoTable.AddCell(new PdfPCell(new Phrase("Vendedor: " + TBNombreEmpleado.Text)));
                infoTable.AddCell(new PdfPCell(new Phrase("Cliente: " + TBNombreCliente.Text)));
                infoTable.AddCell(new PdfPCell(new Phrase("DNI cliente: " + TBDNICliente.Text)));
                infoTable.AddCell(new PdfPCell(new Phrase("Email cliente: " + TBEmailCliente.Text)));
                infoTable.AddCell(new PdfPCell(new Phrase("Forma de pago: " + TBPago.Text)));

                // Agregar la tabla al documento
                doc.Add(infoTable);

                // agregar una tabla para los detalles de la venta
                PdfPTable table = new PdfPTable(4);
                table.TotalWidth = 500f;
                table.LockedWidth = true;
                table.SpacingBefore = 10f;

                // definir las columnas de la tabla
                float[] widths = new float[] { 405f, 200f, 200f, 200f };
                table.SetWidths(widths);
                doc.Add(new Paragraph("\n"));
                Paragraph informacionCarrito = new Paragraph("Detalles de compra");
                informacionCarrito.Alignment = Element.ALIGN_CENTER;
               
                doc.Add(informacionCarrito);
                empresaInfo.Add("\n");
                // agregar encabezados de columna
                AddCellWithColorAndCenteredText(table, "Nombre del producto", BaseColor.GRAY);
                AddCellWithColorAndCenteredText(table, "Cantidad", BaseColor.GRAY);
                AddCellWithColorAndCenteredText(table, "Precio Unitario", BaseColor.GRAY);
                AddCellWithColorAndCenteredText(table, "Subtotal", BaseColor.GRAY);

                // agregar filas de datos de detalles con colores alternados y texto centrado
                for (int i = 0; i < GridDetalles.Rows.Count; i++)
                {
                    for (int j = 0; j < GridDetalles.Columns.Count; j++)
                    {
                        BaseColor backgroundColor = (i % 2 == 0) ? BaseColor.WHITE : BaseColor.WHITE;
                        AddCellWithColorAndCenteredText(table, GridDetalles[j, i].Value.ToString(), backgroundColor);
                    }
                }

                doc.Add(table);

                // calcular el total recaudado
                Paragraph total = new Paragraph("Total venta: " + TBTotal.Text);
                total.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);
              

                // agregar la segunda imagen en el centro del documento y casi al final
                string imagePath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnMateMensaje.png");
                if (File.Exists(imagePath2))
                {
                    iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(imagePath2);

                    // Ajustar el tamaño de la segunda imagen
                    img2.ScaleToFit(360, 360);

                    
                    float centerX2 = (doc.PageSize.Width - img2.ScaledWidth) / 2;
                    float centerY2 = 115; 

                    img2.SetAbsolutePosition(centerX2, centerY2);

                    doc.Add(img2);
                }

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

        private void AddCellWithColorAndCenteredText(PdfPTable table, string text, BaseColor backgroundColor)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text));
            cell.BackgroundColor = backgroundColor;
            cell.HorizontalAlignment = Element.ALIGN_CENTER; 
            table.AddCell(cell);
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            Detalles();

        }

        public bool Detalles()
        {
            string connectionString = "Server=.; Database=UnMate; Integrated Security=True;";

            string consulta = "SELECT V.Cod_Venta, V.Fecha,TP.Descripcion AS DescripcionPago, " +
                   "E.Nombre AS NombreEmpleado, E.Apellido AS ApellidoEmpleado, E.DNI, E.Telefono, " +
                   "C.Nombre AS NombreCliente, C.Apellido AS ApellidoCliente, C.DNI_Cliente AS DNI_Cliente, C.Email, " +
                   "DV.Cod_Producto, P.Titulo AS NombreProducto, DV.Cantidad, P.Precio AS PrecioUnitario, DV.Cantidad * P.Precio AS Subtotal " +
                   "FROM Venta V " +
                   "INNER JOIN Empleado E ON V.Cod_Empleado = E.Cod_Empleado " +
                   "INNER JOIN Cliente C ON V.Cod_Cliente = C.Cod_Cliente " +
                   "INNER JOIN DetalleVenta DV ON V.Cod_Venta = DV.Cod_Venta " +
                   "INNER JOIN Producto P ON DV.Cod_Producto = P.Cod_Producto " +
                   "INNER JOIN TipoPago TP ON V.Cod_TipoPago = TP.Cod_TipoPago " +
                   "WHERE V.Cod_Venta = @Cod_Venta";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Cod_Venta", codigoVenta);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string idVenta = reader["Cod_Venta"].ToString();
                        string nombreEmpleado = reader["NombreEmpleado"].ToString();
                        string ApellidoEmpleado = reader["ApellidoEmpleado"].ToString();
                        string nombreCliente = reader["NombreCliente"].ToString();
                        string ApellidoCliente = reader["ApellidoCliente"].ToString();
                        string dniCliente = reader["DNI_Cliente"].ToString();
                        string emailCliente = reader["Email"].ToString();
                        string dniEmpleado = reader["DNI"].ToString();
                        string telefonoEmpleado = reader["Telefono"].ToString();
                        string tipoPago = reader["DescripcionPago"].ToString();
                        DateTime fecha = Convert.ToDateTime(reader["Fecha"]); 

                        // formatear la fecha al formato deseado (solo día, mes y año)
                        string fechaFormateada = fecha.ToString("dd/MM/yyyy");

                        TBCodVenta.Text = idVenta;
                        TBNombreEmpleado.Text = nombreEmpleado + " " + ApellidoEmpleado;
                        TBNombreCliente.Text = nombreCliente + " " + ApellidoCliente;
                        TBDNICliente.Text = dniCliente;
                        TBEmailCliente.Text = emailCliente;
                        TBDNIEmpleado.Text = dniEmpleado;
                        TBTelefono.Text = telefonoEmpleado;
                        TBPago.Text = tipoPago;
                        TBFecha.Text = fechaFormateada; 

                        // limpiamos el DataGridView antes de agregar filas
                        GridDetalles.Rows.Clear();

                        // define DataGridView columns
                        GridDetalles.Columns.Add("NombreProducto", "Nombre del Producto");
                        GridDetalles.Columns.Add("Cantidad", "Cantidad");
                        GridDetalles.Columns.Add("PrecioUnitario", "Precio Unitario");
                        GridDetalles.Columns.Add("Subtotal", "Subtotal");

                        decimal totalRecaudado = 0.0m;

                        do
                        {
                            string nombreProducto = reader["NombreProducto"].ToString();
                            string cantidad = reader["Cantidad"].ToString();
                            string precioUnitario = reader["PrecioUnitario"].ToString();
                            string subtotal = reader["Subtotal"].ToString();

                            // agregamos una fila al DataGridView
                            GridDetalles.Rows.Add(nombreProducto, cantidad, precioUnitario, subtotal);

                            if (decimal.TryParse(subtotal, out decimal rowSubtotal))
                            {
                                totalRecaudado += rowSubtotal;
                            }

                        } while (reader.Read());

                        TBTotal.Text = totalRecaudado.ToString() + "$";

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

    }
}
