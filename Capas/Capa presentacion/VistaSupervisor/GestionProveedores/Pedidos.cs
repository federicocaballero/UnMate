using ProyectoTaller.Capas.Capa_datos.Supervisor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores
{
    public partial class Pedidos : Form
    {
        private ClasePedidoProveedores PedidosGenerados;
        SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=UnMate; Integrated Security=True;");
        public Pedidos()
        {
            InitializeComponent();
           
        }

        private void PedidosConfirmados_Load(object sender, EventArgs e)
        {

            quitarEspacios();
            using (SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=UnMate; Integrated Security=True;"))
            {
                conexion.Open();

                string consulta = "SELECT PP.Cod_Pedido, PP.Descripcion, P.Nombre AS Proveedor, Pr.Titulo AS Producto, PP.Cantidad, PP.Total, PP.Fecha, " +
                 "CASE " +
                 "WHEN PP.Estado = 0 THEN 'Cancelado' " +
                 "WHEN PP.Estado = 2 THEN 'Entregado' " +
                 " ELSE 'Otro Estado' " +  "END AS Estado " +
                 "FROM PedidoProveedor PP " +
                 "INNER JOIN Proveedor P ON PP.Cod_Proveedor = P.Cod_Proveedor " +
                 "INNER JOIN Producto Pr ON PP.Cod_Producto = Pr.Cod_Producto " +
                 "WHERE PP.Estado = 2 OR PP.Estado = 0";


                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable tablaPedidos = new DataTable();
                        adapter.Fill(tablaPedidos);

                        // enlaza los datos a un control DataGridView
                        GridPedidos.DataSource = tablaPedidos;
                        quitarEspacios();
                    }
                }
            }
        }

        private void quitarEspacios()
        {
            foreach (DataGridViewRow row in GridPedidos.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is string)
                    {
                        // Elimina los espacios en blanco adicionales en la cadena de la celda
                        string gridSinEspacios = string.Join(" ", cell.Value.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                        // Actualiza el valor de la celda
                        cell.Value = gridSinEspacios;
                    }
                }
            }
        }

        private void GridPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.ColumnIndex == 7 && e.RowIndex >= 0) 
            {
                
                object valorCelda = GridPedidos.Rows[e.RowIndex].Cells[7].Value;

             
                if (valorCelda != null && valorCelda.ToString() == "Cancelado")
                {
                    // cambia el color de fondo de la fila a rojo
                    GridPedidos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    GridPedidos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
    }
}
