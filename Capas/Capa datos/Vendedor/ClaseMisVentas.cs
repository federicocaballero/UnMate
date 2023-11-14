using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTaller.Capas.Capa_datos.Vendedor
{
    internal class ClaseMisVentas
    {
        private SqlConnection MiVenta;
        private DataGridView GridListadoVentas;
        private Label LEmpleado;
        private Label LTotalRecaudado;
        public ClaseMisVentas(DataGridView GridListadoVentas, Label LEmpleado, Label LTotalRecaudado)
        {
            MiVenta = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.GridListadoVentas = GridListadoVentas;
            this.LEmpleado = LEmpleado;
            this.LTotalRecaudado = LTotalRecaudado;
         
        }


        public void MostrarMisVentas(DateTimePicker Tfecha, DateTimePicker THasta)
        {
            TotalRecaudadoVendedor();
            if (DatosSesion.EmpleadoLogeado != null)
            {
                Empleado empleado = DatosSesion.EmpleadoLogeado;
                DateTime fechaDesde = Tfecha.Value;
                DateTime fechaHasta = THasta.Value;

                string consulta = "SELECT V.Cod_Venta, CONCAT(C.Nombre, ' ', C.Apellido) AS Cliente, C.DNI_Cliente, MAX(V.Fecha) AS Fecha, SUM(V.Total) AS Total FROM Venta V " +
                "INNER JOIN Cliente C ON V.Cod_Cliente = C.Cod_Cliente " +
                "INNER JOIN Empleado E ON V.Cod_Empleado = E.Cod_Empleado " +
                "WHERE V.Cod_Empleado = " + empleado.Cod_Empleado +
                " AND CONVERT(date, V.Fecha) >= CONVERT(date, @FechaDesde) AND CONVERT(date, V.Fecha) <= CONVERT(date, @FechaHasta)" +
                " GROUP BY V.Cod_Venta, CONCAT(C.Nombre, ' ', C.Apellido), C.DNI_Cliente";



                using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
                using (SqlDataAdapter lista = new SqlDataAdapter(consulta, conexion))
                {
                    lista.SelectCommand.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    lista.SelectCommand.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    DataTable dt = new DataTable();
                    lista.Fill(dt);
                    GridListadoVentas.DataSource = dt;

                    // verifica si ya existe una columna de botones
                    bool buttonColumnExists = false;
                    foreach (DataGridViewColumn column in GridListadoVentas.Columns)
                    {
                        if (column.HeaderText == "Detalles" && column is DataGridViewButtonColumn)
                        {
                            buttonColumnExists = true;
                            break;
                        }
                    }

                    // si no existe, agrega la columna de botones
                    if (!buttonColumnExists)
                    {
                        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                        buttonColumn.HeaderText = "Detalles";
                        buttonColumn.Text = "Ver Detalles";
                        buttonColumn.UseColumnTextForButtonValue = true;
                        GridListadoVentas.Columns.Add(buttonColumn);
                    }

                    LEmpleado.Text = "Vendedor: " + empleado.Nombre + " " + empleado.Apellido;
                }

                // calcula el total recaudado después de cargar los datos
                TotalRecaudadoVendedor();
            }
        }

        public void TotalRecaudadoVendedor()
        {
            decimal totalRecaudado = 0.0m;
            foreach (DataGridViewRow row in GridListadoVentas.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["Total"].Value.ToString(), out decimal rowSubtotal))
                    {
                        totalRecaudado += rowSubtotal;
                    }
                }
            }

            LTotalRecaudado.Text = "Total: $" + totalRecaudado.ToString("N"); // Muestra el total recaudado en formato de dólar
        }




    }
}
