using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionClientes;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Supervisor
{
    internal class ClasePedidoProveedores
    {
        private SqlConnection PedidoProveedores;
        private DataGridView GridPedidos;
        private TextBox TBProducto;
        private TextBox TBDescripcion;
        private DateTimePicker TFecha;
        private TextBox TBProveedor;
        private TextBox TBCantidad;
        private TextBox TBImporte;
        private Button BBuscarProducto;
        private Button BLimpiarProducto;
        private ErrorProvider errorProvider1;
        private Button BLimpiarProveedor;
        private Button BEliminar;
        private Button BAñadir;
        private Button BBuscarProveedor;
        private Button BBorrarListado;
        private Button BConfirmar;
        private TextBox TBBuscarProveedor;
        private Button BHistorialPedidos;
        private Label LTotal;
        private Button BBuscar;

        public ClasePedidoProveedores(DataGridView GridPedidos, TextBox TBProducto, TextBox TBDescripcion, DateTimePicker TFecha, TextBox TBProveedor, TextBox TBCantidad, TextBox TBImporte, Button BBuscarProducto, Button BLimpiarProducto, 
            ErrorProvider errorProvider1, Button BLimpiarProveedor,Button BEliminar, Button BAñadir, Button BBuscarProveedor, Button BBorrarListado, Button BConfirmar, TextBox TBBuscarProveedor, Button BHistorialPedidos, Label LTotal, Button BBuscar)
        {
            PedidoProveedores = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.GridPedidos = GridPedidos;
            this.TBProducto = TBProducto;
            this.TBDescripcion = TBDescripcion;
            this.TFecha = TFecha;
            this.TBProveedor = TBProveedor;
            this.TBCantidad = TBCantidad;
            this.TBImporte = TBImporte;
            this.BBuscarProducto = BBuscarProducto;
            this.BLimpiarProducto = BLimpiarProducto;
            this.errorProvider1 = errorProvider1;
            this.BLimpiarProveedor = BLimpiarProveedor;
            this.BEliminar = BEliminar;
            this.BAñadir = BAñadir;
            this.BBuscarProveedor = BBuscarProveedor;
            this.BBorrarListado = BBorrarListado;
            this.BConfirmar = BConfirmar;
            this.TBBuscarProveedor = TBBuscarProveedor;
            this.BHistorialPedidos = BHistorialPedidos;
            this.LTotal= LTotal;
            this.BBuscar = BBuscar;
         }

        private bool formularioHistorialPedidos = false;
        private Form PedidoForm = null;
        public void HistorialPedidos()
        {

            if(formularioHistorialPedidos == false)
            {
                PedidoForm = new Pedidos();
                PedidoForm.FormClosed += (s, args) =>
                {
                    formularioHistorialPedidos = false; 
                };
            }
            PedidoForm.Show();
            formularioHistorialPedidos = true;
        }

        public void mostrarPedidos()
        {
            quitarEspacios();
            using (SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=UnMate; Integrated Security=True;"))
            {
                conexion.Open();

                string consulta = "SELECT PP.Cod_Pedido, PP.Descripcion, P.Nombre AS Proveedor, Pr.Titulo AS Producto, PP.cantidad, PP.Total, PP.Fecha " +
                "FROM PedidoProveedor PP " + "INNER JOIN Proveedor P ON PP.Cod_Proveedor = P.Cod_Proveedor " +
                "INNER JOIN Producto Pr ON PP.Cod_Producto = Pr.Cod_Producto " + "WHERE PP.Estado = 1";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable tablaPedidos = new DataTable();
                        adapter.Fill(tablaPedidos);
                       
                        GridPedidos.DataSource = tablaPedidos;
                        quitarEspacios();
                    }
                }
            }
        }

        public void BuscarPedido()
        {
            if (string.IsNullOrWhiteSpace(TBBuscarProveedor.Text))
            {
                errorProvider1.SetError(TBBuscarProveedor, "Debe ingresar un código");
                return;
            }

            string textoBuscado = TBBuscarProveedor.Text;
            bool pedidoEncontrador = false;

            foreach (DataGridViewRow fila in GridPedidos.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == textoBuscado)
                {
                    GridPedidos.CurrentCell = fila.Cells[0];

                    TBDescripcion.Text = fila.Cells[1].Value.ToString();
                    TBProveedor.Text = fila.Cells[2].Value.ToString();
                    TBProducto.Text = fila.Cells[3].Value.ToString();
                    TBCantidad.Text = fila.Cells[4].Value.ToString();
                    TBImporte.Text = fila.Cells[5].Value.ToString();
                    TFecha.Text = fila.Cells[6].Value.ToString();


                    if (GridPedidos.CurrentRow != null)
                    {
                        DataGridViewRow selectedRow = GridPedidos.CurrentRow;
                       valorCodigoPedido = Convert.ToInt32(selectedRow.Cells["Cod_Pedido"].Value);
                    }
                    LTotal.Text = "Total"; errorProvider1.SetError(TBBuscarProveedor, "");EliminarProviders();
                    TBBuscarProveedor.Clear(); BloquearTodo(); BConfirmar.Visible = true;
                    MessageBox.Show("Pedido encontrado en la base", "Búsqueda de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBBuscarProveedor.Clear(); BloquearTodo(); BBuscarProducto.Visible = false; BBuscarProveedor.Visible = false; 
                    pedidoEncontrador = true; BAñadir.Visible = false; BEliminar.Enabled = true; BConfirmar.Visible = true;
                    break;
                }
            }

            // mostrar mensaje si no se encontró al proveedor
            if (!pedidoEncontrador)
            {
                MessageBox.Show("No se encontró al pedido en la base", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscarProveedor.Clear();
            }
        }


        decimal TotalObtenido = 0.0m;
        public void AñadirPedido ()
        {
            EliminarProviders();

            if (!String.IsNullOrWhiteSpace(TBProducto.Text) && !String.IsNullOrWhiteSpace(TBDescripcion.Text) &&
                TFecha.Value != null && TBProveedor.Text != "" && productoEncontrado == true &&
                !String.IsNullOrWhiteSpace(TBCantidad.Text) && !String.IsNullOrWhiteSpace(TBImporte.Text) && provedorEncontrado == true)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas agregar este pedido?", "Confirmar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=UnMate; Integrated Security=True;"))
                    {
                        conexion.Open();

                        string consultaCodProveedor = "SELECT Cod_Proveedor FROM Proveedor WHERE Nombre = @Nombre";
                        string consultaCodProducto = "SELECT Cod_Producto FROM Producto WHERE Titulo = @Titulo";

                        int codProveedor = -1;
                        int codProducto = -1;

                        using (SqlCommand cmdCodProveedor = new SqlCommand(consultaCodProveedor, conexion))
                        {
                            cmdCodProveedor.Parameters.AddWithValue("@Nombre", TBProveedor.Text);
                            codProveedor = Convert.ToInt32(cmdCodProveedor.ExecuteScalar());
                        }

                        using (SqlCommand cmdCodProducto = new SqlCommand(consultaCodProducto, conexion))
                        {
                            cmdCodProducto.Parameters.AddWithValue("@Titulo", TBProducto.Text);
                            codProducto = Convert.ToInt32(cmdCodProducto.ExecuteScalar());
                        }

                        decimal importe = Convert.ToDecimal(TBImporte.Text);
                        int cantidad = Convert.ToInt32(TBCantidad.Text);
                        decimal total = importe * cantidad;

                        string AñadirPedido = "INSERT INTO PedidoProveedor (Cod_Proveedor, Cod_Producto, Descripcion, Cantidad, Fecha, Total) " +
                            "VALUES (@CodProveedor, @CodProducto, @Descripcion, @Cantidad, @Fecha, @Total)";


                        using (SqlCommand cmd = new SqlCommand(AñadirPedido, conexion))
                        {
                            cmd.Parameters.AddWithValue("@CodProveedor", codProveedor);
                            cmd.Parameters.AddWithValue("@CodProducto", codProducto);
                            cmd.Parameters.AddWithValue("@Descripcion", TBDescripcion.Text);
                            cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@Fecha", TFecha.Value);
                            cmd.Parameters.AddWithValue("@Total", total);
                           
                            cmd.ExecuteNonQuery();
                            TotalObtenido = total;
                        }
         
                        mostrarPedidos();
                        LTotal.Text = "Unitario";
                        MessageBox.Show("Pedido agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EliminarProviders(); BBuscarProducto.Visible = true; BBuscarProveedor.Visible = true;
                        BorrarCampos();errorProvider1.SetError(TBDescripcion, "");errorProvider1.SetError(TBProducto, "");
                        BLimpiarProducto.Visible = false;DesbloquearTodo();BConfirmar.Visible = false;
                        BLimpiarProveedor.Visible = false;
                        quitarEspacios();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos y encontrar el producto y el proveedor antes de agregar el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErrorProviders();
            }

        }


        bool productoEncontrado = false;
        public bool BuscarProducto()
        {

            if (string.IsNullOrWhiteSpace(TBProducto.Text))
            {
                errorProvider1.SetError(TBProducto, "Debe ingresar el código de producto");
            }

            else if (!int.TryParse(TBProducto.Text, out int codProducto))
            {
                errorProvider1.SetError(TBProducto, "El código de producto debe ser un número válido");
            }
            else
            {
                string connectionString = "Server=.; Database=UnMate; Integrated Security=True;";

                string consulta = "SELECT Titulo, Precio FROM Producto WHERE Cod_Producto = @Cod_Producto AND Estado = 1";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Cod_Producto", codProducto);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string titulo = reader["Titulo"].ToString();
                            string precio = reader["Precio"].ToString();

                            TBProducto.Text = titulo; 
                            TBImporte.Text = precio;
                            quitarEspacios();
                            Console.WriteLine("Producto encontrado: " + titulo);
                            BBuscarProducto.Visible = false;
                            BLimpiarProducto.Visible = true;
                            TBProducto.Enabled = false;

                            productoEncontrado = true;
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado", "Error en la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TBProducto.Clear();
                        }
                    }
                }
            }

            return productoEncontrado;
        }


        private bool ErrorProviders()
        {
            bool PedidoLista = true;

            if (TBProducto.Text == "" || Regex.IsMatch(TBProducto.Text, @"^\d+$"))
            {
                errorProvider1.SetError(TBProducto, "Producto necesario");
                PedidoLista = false;
            }

            if (string.IsNullOrWhiteSpace(TBDescripcion.Text))
            {
                errorProvider1.SetError(TBDescripcion, "Descripcion necesaria y sin espacios en blanco");
                PedidoLista = false;
            }

            if (TBCantidad.Text == "")
            {
                errorProvider1.SetError(TBCantidad, "Cantidad necesaria");
                PedidoLista = false;
            }

            if (TBImporte.Text == "")
            {
                errorProvider1.SetError(TBImporte, "Importe necesario");
                PedidoLista = false;
            }

            if (TBProveedor.Text == "")
            {
                errorProvider1.SetError(TBProveedor, "Proveedor necesario");
                PedidoLista = false;
            }

            if (TFecha.Text == "")
            {
                errorProvider1.SetError(TFecha, "Campo necesario");
                PedidoLista = false;
            }

            if(provedorEncontrado == false)
            {
                errorProvider1.SetError(TBProveedor, "Proveedor necesario");
                PedidoLista = false;
            }

            return PedidoLista = false;
        }

        private void EliminarProviders()
        {
            errorProvider1.SetError(TBProveedor, "");
            errorProvider1.SetError(TBProducto, "");
            errorProvider1.SetError(TBImporte, "");
            errorProvider1.SetError(TBCantidad, "");
            errorProvider1.SetError(TFecha, "");
            errorProvider1.SetError(TBDescripcion, "");
            errorProvider1.SetError(TBBuscarProveedor, "");
        }

        private void quitarEspacios()
        {
            foreach (DataGridViewRow row in GridPedidos.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is string)
                    {
                        string gridSinEspacios = string.Join(" ", cell.Value.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                        cell.Value = gridSinEspacios;
                    }
                }
            }
        }


        private int valorCodigoPedido;
        public void DobleClick()
        {
            TBProducto.Text = GridPedidos.CurrentRow.Cells[3].Value.ToString();
            TBDescripcion.Text = GridPedidos.CurrentRow.Cells[1].Value.ToString();
            TBProveedor.Text = GridPedidos.CurrentRow.Cells[2].Value.ToString();

            if (GridPedidos.CurrentRow.Cells[3].Value is DateTime)
            {
                TFecha.Text = ((DateTime)GridPedidos.CurrentRow.Cells[3].Value).ToString("dd/MM/yyyy");

            }
            TBCantidad.Text = GridPedidos.CurrentRow.Cells[4].Value.ToString();
            TBImporte.Text = GridPedidos.CurrentRow.Cells[5].Value.ToString();

            DataGridViewRow selectedRow = GridPedidos.CurrentRow;
            valorCodigoPedido = Convert.ToInt32(selectedRow.Cells["Cod_Pedido"].Value);

            BloquearTodo();
            BBorrarListado.Visible = true;
            BEliminar.Enabled = true;
            BConfirmar.Visible = true;
            BBuscarProveedor.Visible = false;
            BLimpiarProveedor.Visible = false;
            quitarEspacios();
            BLimpiarProducto.Visible = false;
            BBuscarProducto.Visible = false;
            LTotal.Text = "Total";
            EliminarProviders();BHistorialPedidos.Visible = false;
            BAñadir.Enabled = false;
        }

        private void BloquearTodo()
        {
            TBImporte.ReadOnly = true;
            TBDescripcion.Enabled = false;
            TBCantidad.ReadOnly = true;
            TFecha.Enabled = false;
            TBProveedor.ReadOnly = true;
            TBProducto.Enabled = false;
            TBProveedor.Enabled = false;
            TBImporte.Enabled = false;
            TBCantidad.Enabled = false;
            TFecha.Enabled = false;
            
        }

        private void DesbloquearTodo()
        {
            TBDescripcion.Enabled = true;
            TBCantidad.ReadOnly = false;
            TBProveedor.ReadOnly = false;
            TBProducto.ReadOnly = false;
            TBProveedor.Enabled = true;
            TBImporte.Enabled = false;
            TBProducto.Enabled = true;
            TBCantidad.Enabled = true;
            TFecha.Enabled = false;
        }

        public void EliminarPedido()
        {
            DialogResult result = MessageBox.Show("Desea eliminar el pedido?", "Eliminación de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=UnMate; Integrated Security=True;"))
                {
                    conexion.Open();

                    string eliminarPedido = "UPDATE PedidoProveedor  SET Estado = @Estado WHERE Cod_Pedido = @CodPedido";

                   
                    using (SqlCommand cmd = new SqlCommand(eliminarPedido, conexion))
                    {
                        cmd.Parameters.AddWithValue("@CodPedido", valorCodigoPedido);
                        cmd.Parameters.AddWithValue("@Estado", 0);
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Pedido eliminado correctamente", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mostrarPedidos(); EliminarProviders(); errorProvider1.SetError(TBBuscarProveedor, "");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el pedido con el Cod_Pedido especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                BorrarCampos(); LTotal.Text = "Unitario";
                DesbloquearTodo(); BBorrarListado.Visible = false; BEliminar.Enabled = false;
                BLimpiarProveedor.Visible = false;
                BBuscarProveedor.Visible = false; 
                BConfirmar.Visible = false; BAñadir.Enabled = true;
                EliminarProviders();BHistorialPedidos.Visible = true;
                BAñadir.Enabled = true;
                BBuscarProducto.Visible = true;
                BBuscarProveedor.Visible = true;BAñadir.Visible = true;
                LTotal.Text = "Unitario";
            }
            else
            {
                MessageBox.Show("Eliminación  cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BorrarListado()
        {
            EliminarProviders();
            BorrarCampos();
            DesbloquearTodo(); provedorEncontrado = false;
            BBorrarListado.Visible = false;
            BEliminar.Enabled = false;
            TBProveedor.Clear();
            BAñadir.Enabled = true;
            BBuscarProducto.Visible = true;
            BBuscarProveedor.Visible = true;
            errorProvider1.SetError(TBProducto, "");
            errorProvider1.SetError(TBDescripcion, "");
            BConfirmar.Visible = false;
            BHistorialPedidos.Visible = true; LTotal.Text = "Unitario";
            errorProvider1.SetError(TBBuscarProveedor, "");
        }

        bool provedorEncontrado = false;
        public void BuscarProveedor()
        {
            quitarEspacios();
            if (TBProveedor.Text == "")
            {
                errorProvider1.SetError(TBProveedor, "Debe ingresar el un CUIL");
                provedorEncontrado = false;
            }
            else
            {
                string connectionString = "Server=.; Database=UnMate; Integrated Security=True;";
                quitarEspacios();
               
                string consulta = "SELECT Nombre FROM Proveedor WHERE CUIT = @CodProveedor AND Estado = 1";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@CodProveedor", TBProveedor.Text);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            quitarEspacios();
                            
                            // el registro fue encontrado
                            string nombreProveedor = resultado.ToString();
                            TBProveedor.Text = nombreProveedor;
                            Console.WriteLine("Proveedor encontrado: " + nombreProveedor);
                            BBuscarProveedor.Visible = false;
                            BLimpiarProveedor.Visible = true;TBProveedor.Enabled = false;
                            provedorEncontrado = true;
                            
                        }
                        else
                        {
                            // el registro no fue encontrado
                            MessageBox.Show("Proveedor no encontrado en la base", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TBProveedor.Clear();
                            provedorEncontrado = false;
                        }
                    }
                }
            }
          
        }

        public void LimpiarProducto()
        {
            TBProducto.Clear();
            BLimpiarProducto.Visible = false;
            TBProducto.ReadOnly = false;
            BBuscarProducto.Visible = true;
            BHistorialPedidos.Visible = true; TBProducto.Enabled = true;
            errorProvider1.SetError(TBBuscarProveedor, "");
            TBImporte.Clear();
        }

        public void LimpiarProveedor()
        {
            TBProveedor.Clear();
            BLimpiarProveedor.Visible = false;
            TBProveedor.ReadOnly = false;
            BBuscarProveedor.Visible = true;
            TBProveedor.Enabled = true; provedorEncontrado = false;
        }


        public void ConfirmarPedido()
        {
            DialogResult result = MessageBox.Show("Desea confirmar el pedido?", "Confirmación de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=UnMate; Integrated Security=True;"))
                {
                    conexion.Open();

                    // obtener el Cod_Pedido, Cantidad y Nombre del Producto
                    int CodigoPedido = valorCodigoPedido;
                    int cantidadPedido = 0;
                    string nombreProducto = "";

                    string consultaPedido = "SELECT Cod_Producto, cantidad FROM PedidoProveedor WHERE Cod_Pedido = @CodPedido";
                    using (SqlCommand cmdPedido = new SqlCommand(consultaPedido, conexion))
                    {
                        cmdPedido.Parameters.AddWithValue("@CodPedido", valorCodigoPedido);
                        SqlDataReader reader = cmdPedido.ExecuteReader();
                        if (reader.Read())
                        {
                            nombreProducto = reader["Cod_Producto"].ToString();
                            cantidadPedido = Convert.ToInt32(reader["cantidad"]);
                        }
                        reader.Close();
                    }

                    // actualizar el stock del producto
                    string actualizarStock = "UPDATE Producto SET Stock = Stock + @Cantidad WHERE Cod_producto = @CodProducto";
                    using (SqlCommand cmdStock = new SqlCommand(actualizarStock, conexion))
                    {
                        cmdStock.Parameters.AddWithValue("@Cantidad", cantidadPedido);
                        cmdStock.Parameters.AddWithValue("@CodProducto", nombreProducto);
                        cmdStock.ExecuteNonQuery();
                    }

                    //cambiar estado
                    string ConfirmarPedido = "UPDATE PedidoProveedor  SET Estado = @Estado WHERE Cod_Pedido = @CodPedido";
                    using (SqlCommand cmd = new SqlCommand(ConfirmarPedido, conexion))
                    {
                        cmd.Parameters.AddWithValue("@CodPedido", CodigoPedido);
                        cmd.Parameters.AddWithValue("@Estado", 2);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Pedido confirmado correctamente y stock actualizado", "Confirmacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mostrarPedidos(); BBuscarProducto.Visible = true; BBuscarProveedor.Visible = true;
                            BorrarCampos(); BAñadir.Visible = true; errorProvider1.SetError(TBBuscarProveedor, "");
                            EliminarProviders();BEliminar.Enabled = false; LTotal.Text = "Unitario";
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el pedido con el Cod_Pedido especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    
                }
                BHistorialPedidos.Visible = true;

                BorrarCampos();
                DesbloquearTodo();
                BConfirmar.Visible = false; BAñadir.Enabled= true;

            }
            else
            {
                MessageBox.Show("Eliminación cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BorrarCampos()
        {
            TBImporte.Clear();
            TBDescripcion.Clear();
            TBCantidad.Clear();
            TFecha.ResetText();
            TFecha.Enabled = false;
            TBProveedor.Clear();
            TBProducto.Clear();provedorEncontrado = false;
        }
    }
}
