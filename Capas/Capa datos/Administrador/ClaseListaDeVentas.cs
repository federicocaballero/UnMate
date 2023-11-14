using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Administrador
{
    internal class ClaseListaDeVentas
    {
        private SqlConnection TotalVentas;
        private DataGridView GridListadoVendedores;
        private Label LTotalRecaudado;

        public ClaseListaDeVentas(DataGridView GridListadoVendedores, Label LTotalRecaudado)
        {
            TotalVentas = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.GridListadoVendedores = GridListadoVendedores;
            this.LTotalRecaudado = LTotalRecaudado;
        }

        public void MostrarTodasLasVentas(DateTimePicker Tfecha, DateTimePicker THasta)
        {
            DateTime fechaDesde = Tfecha.Value;
            DateTime fechaHasta = THasta.Value;

            string consulta = "SELECT V.Cod_Venta, " +
                   "CONCAT(E.Nombre, ' ', E.Apellido) AS Empleado, E.DNI AS DNI_Empleado, " +
                   "CONCAT(C.Nombre, ' ', C.Apellido) AS Cliente, C.DNI_Cliente AS DNI_Cliente, V.Fecha, V.Total " +
                   "FROM Venta V " +
                   "INNER JOIN Cliente C ON V.Cod_Cliente = C.Cod_Cliente " +
                   "INNER JOIN Empleado E ON V.Cod_Empleado = E.Cod_Empleado " +
                   "WHERE CONVERT(date, V.Fecha) >= CONVERT(date, @FechaDesde) AND CONVERT(date, V.Fecha) <= CONVERT(date, @FechaHasta)";



            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            using (SqlDataAdapter lista = new SqlDataAdapter(consulta, conexion))
            {
                lista.SelectCommand.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                lista.SelectCommand.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                DataTable dt = new DataTable();
                lista.Fill(dt);
                GridListadoVendedores.DataSource = dt;

                // verifica si la columna "Detalles" ya existe
                if (GridListadoVendedores.Columns["Detalles"] == null)
                {
                
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.Name = "Detalles"; 
                    buttonColumn.HeaderText = "Detalles";
                    buttonColumn.Text = "Ver Detalles"; 
                    buttonColumn.UseColumnTextForButtonValue = true;

                    
                    GridListadoVendedores.Columns.Add(buttonColumn);
                }
            }
            TotalRecaudadoVendedores();

        }

        public void TotalRecaudadoVendedores()
        {
            decimal totalRecaudado = 0.0m;
            foreach (DataGridViewRow row in GridListadoVendedores.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["Total"].Value.ToString(), out decimal rowSubtotal))
                    {
                        totalRecaudado += rowSubtotal;
                    }
                }
            }

            LTotalRecaudado.Text = "Recaudo vendedores: $" + totalRecaudado.ToString("N"); // Muestra el total recaudado en formato de dólar
        }

    }
}
