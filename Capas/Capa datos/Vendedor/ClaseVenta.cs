using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Vendedor
{
    internal class ClaseVenta
    {
        private SqlConnection Venta;
        private ComboBox CBPago;
        private DataGridView GridProductosParaVenta;
        private ErrorProvider errorProvider1;
        private TextBox TBCliente;
        private ListView LVCompra;
        private Button BLimpiar;
        private TextBox TBCantidad;
        private TextBox TBProducto;
        private TextBox TBDescripcion;
        private TextBox TBPrecio;
        private TextBox TBTotalPago;
        private Button BVaciarCarrito;
        private TextBox TBVendedor;
        private Button BBuscar;
        private Button BCancelarCompra;
        private TextBox TBIDVenta;
        private TextBox TBBuscarUnProducto;
        private Button BBuscarProducto;

        public ClaseVenta(ComboBox CBPago, DataGridView GridProductosParaVenta, ErrorProvider errorProvider1, TextBox TBCliente, ListView LVCompra, Button BLimpiar, TextBox TBCantidad, TextBox TBProducto, TextBox TBDescripcion, TextBox TBPrecio
, TextBox TBTotalPago, Button BVaciarCarrito, TextBox TBVendedor, Button BBuscar, Button BCancelarCompra, TextBox TBIDVenta, TextBox TBBuscarUnProducto, Button BBuscarProducto)
        {
            Venta = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.CBPago = CBPago;
            this.GridProductosParaVenta = GridProductosParaVenta;
            this.errorProvider1 = errorProvider1;
            this.TBCliente = TBCliente;
            this.LVCompra = LVCompra;
            this.BLimpiar = BLimpiar;
            this.TBCantidad = TBCantidad;
            this.TBProducto = TBProducto;
            this.TBDescripcion = TBDescripcion;
            this.TBPrecio = TBPrecio;
            this.TBTotalPago = TBTotalPago;
            this.BVaciarCarrito = BVaciarCarrito;
            this.TBVendedor = TBVendedor;
            this.BBuscar = BBuscar;
            this.BCancelarCompra = BCancelarCompra;
            this.TBIDVenta = TBIDVenta;
            this.TBBuscarUnProducto = TBBuscarUnProducto;
            this.BBuscarProducto = BBuscarProducto;
        }


        public bool ErrorProviders()
        {
            bool nuevaVenta = true;

            if (TBCliente.Text == "")
            {
                errorProvider1.SetError(TBCliente, "Cliente necesario");
                nuevaVenta = false;
            }

            if (CBPago.SelectedItem == null)
            {
                errorProvider1.SetError(CBPago, "Metodo de pago necesario");
                nuevaVenta = false;
            }

            if(TBVendedor.Text == "")
            {
                errorProvider1.SetError(TBVendedor, "No se inicio sesion");
                nuevaVenta = false;
            }

            return nuevaVenta;
        }

        public void QuitarErrores()
        {
            errorProvider1.SetError(TBCliente, "");
            errorProvider1.SetError(CBPago, "");
            errorProvider1.SetError(TBVendedor, "");
        }

        public void CodDeVenta()
        {
            string connectionString = "Server=.; Database=UnMate; Integrated Security=True;"; 
            string consultaCodigo = "SELECT TOP 1 Cod_Venta FROM Venta";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consultaCodigo, conexion))
                {
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        int codVenta = (int)resultado;
                        int nuevoCodVenta = codVenta + 1;
                        TBIDVenta.Text = nuevoCodVenta.ToString();
                    }
                    else
                    {
                        
                        TBIDVenta.Text = "1";
                    }
                }
            }
        }

        public void VaciarCarrito()
        {
            if (LVCompra.Items.Count != 0)
            {
                DialogResult result = MessageBox.Show("Estas seguro que desea vaciar el carrito", "Vaciar carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CancelarDescuento();
                    LVCompra.Items.Clear();
                    TBTotalPago.Clear();
                    MessageBox.Show("Productos eliminados del carrito", "Vaciar carrito", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    BVaciarCarrito.Enabled = false;
                }
                else
                { }

            }
            else
            {
                MessageBox.Show("El carrito se encuentra vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CancelarDescuento()
        {
            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            {
                conexion.Open();

                foreach (ListViewItem item in LVCompra.Items)
                {
                    string producto = item.SubItems[0].Text;
                    int cantidad = int.Parse(item.SubItems[2].Text);

                    string consulta = "UPDATE Producto SET Stock = Stock + @Cantidad WHERE Titulo = @Titulo";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Cantidad", cantidad);
                        comando.Parameters.AddWithValue("@Titulo", producto);

                        comando.ExecuteNonQuery();
                    }
                }
            }

            // limpia el carrito
            LVCompra.Items.Clear();
            TBTotalPago.Clear();
            BVaciarCarrito.Enabled = false;

            // muestra los productos nuevamente
            MostrarProductos();
        }


        public int ObtenerCodigoProducto(string tituloProducto)
        {
            int codigoProducto = -1; // valor por defecto en caso de que no se encuentre un producto

            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            {
                conexion.Open();

                string consulta = "SELECT Cod_Producto FROM Producto WHERE Titulo = @Titulo";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Titulo", tituloProducto);

                 
                    var resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        codigoProducto = (int)resultado;
                    }
                }
            }

            return codigoProducto;
        }

        public int ObtenerCodigoCliente()
        {
            int codigoCliente = -1; 

            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            {
                conexion.Open();

                string nombreApellidoCliente = TBCliente.Text;
                string[] partesNombreApellido = nombreApellidoCliente.Split(' ');

                if (partesNombreApellido.Length >= 2)
                {
                    string nombre = partesNombreApellido[0];
                    string apellido = partesNombreApellido[1];
                    string consulta = "SELECT Cod_Cliente FROM Cliente WHERE Nombre = @Nombre AND Apellido = @Apellido";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Apellido", apellido);

                        var resultado = comando.ExecuteScalar();

                        if (resultado != null)
                        {
                            codigoCliente = (int)resultado;
                        }
                    }
                }
            }

            return codigoCliente;
        }


        public void ComboPago()
        {

            string connectionString = "Server=.; Database=UnMate; Integrated Security=True;"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string consulta = "SELECT Descripcion FROM TipoPago";
                SqlCommand cmd = new SqlCommand(consulta, connection); 

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreProveedor = reader["Descripcion"].ToString();
                        CBPago.Items.Add(nombreProveedor);
                    }
                }
            }
        }


        public void MostrarProductos()
        {
            string consulta = "SELECT Cod_Producto AS Codigo, Titulo, Descripcion, Stock, Precio FROM Producto where Estado = 1 AND Stock  > 0";

            SqlDataAdapter lista = new SqlDataAdapter(consulta, Venta);
            DataTable dt = new DataTable();
            lista.Fill(dt);
            GridProductosParaVenta.DataSource = dt;
        }

        bool clienteEncontrado = false;
        public bool BuscarCliente()
        {
         
            if (TBCliente.Text == " ")
            {
                errorProvider1.SetError(TBCliente, "Debe ingresar un DNI");
                return false;

            }
            else
            {
                string connectionString = "Server=.; Database=UnMate; Integrated Security=True;";

                // consulta SQL para obtener el nombre y el apellido del cliente
                string consulta = "SELECT Nombre, Apellido FROM Cliente WHERE DNI_Cliente = @CodCliente AND Estado = 1";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@CodCliente", TBCliente.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // cliente encontrado
                            string nombreCliente = reader["Nombre"].ToString();
                            string apellidoCliente = reader["Apellido"].ToString();
                            TBCliente.Text = nombreCliente + " " + apellidoCliente;
                            Console.WriteLine("Cliente encontrado: " + nombreCliente + " " + apellidoCliente);
                            reader.Close();
                            BBuscar.Visible = false; BLimpiar.Visible = true; TBCliente.Enabled = false;
                            clienteEncontrado = true;errorProvider1.SetError(TBCliente, "");
                        }
                        else
                        {
                            // cliente no Encontrado
                            MessageBox.Show("Cliente no encontrado en la base", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TBCliente.Clear();
                            reader.Close();
                            clienteEncontrado = false;
                        }
                    }
                }
            }
            return clienteEncontrado;
        }

        public void LimpiarCliente()
        {
            TBCliente.Clear();
            BLimpiar.Visible = false;
            TBCliente.ReadOnly = false;
            TBCliente.Enabled = true;
            BBuscar.Visible = true;
            clienteEncontrado = false;
        }

        private int valorCodigoProducto;
        public void DobleClick()
        {
            TBCantidad.Text = "1";
            TBProducto.Text = GridProductosParaVenta.CurrentRow.Cells[1].Value.ToString();
            TBDescripcion.Text = GridProductosParaVenta.CurrentRow.Cells[2].Value.ToString();
            TBPrecio.Text = GridProductosParaVenta.CurrentRow.Cells[4].Value.ToString();
            TBCantidad.ReadOnly = false;
            if (GridProductosParaVenta.CurrentRow != null)
            {
                DataGridViewRow selectedRow = GridProductosParaVenta.CurrentRow;
                valorCodigoProducto = Convert.ToInt32(selectedRow.Cells["Codigo"].Value);
            }
        }

        private void ActualizarStockEnBaseDeDatos(string producto, int cantidadRequerida)
        {
            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            {
                conexion.Open();

                string consulta = "UPDATE Producto SET Stock = Stock - @Cantidad WHERE Titulo = @Titulo";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Cantidad", cantidadRequerida);
                    comando.Parameters.AddWithValue("@Titulo", producto);

                    comando.ExecuteNonQuery();
                }
            }

            MostrarProductos();
        }


        public void BorrarCamposRegistrados()
        {
            TBProducto.Clear();
            TBDescripcion.Clear();
            TBPrecio.Clear();
            TBCantidad.Text = " ";
            TBCantidad.ReadOnly = true;

        }

        public void BorrarTodo()
        {
            CBPago.SelectedItem = null;
            TBCantidad.Clear();
            TBTotalPago.Clear();
            LVCompra.Items.Clear();
            TBCantidad.Clear();
            TBCliente.Clear();
            TBCliente.Enabled = true;

        }

        public void RealizarCompra()
        {
            int codVenta;
            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            {
                conexion.Open();

                using (SqlCommand codVentaCmd = new SqlCommand("SELECT MAX(Cod_Venta) FROM Venta", conexion))
                {
                    object result = codVentaCmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        codVenta = (int)result + 1;
                    }
                    else
                    {
                        codVenta = 1;
                    }
                }

                int TipoPago = 0;
                if (CBPago.Text == "Mercado Pago")
                {
                    TipoPago = 1;
                }
                else
                {
                    TipoPago = 2;
                }

                // obtener el código del empleado y del cliente
                int codEmpleado = int.Parse(TBVendedor.Text);
                int codCliente = ObtenerCodigoCliente();

                using (SqlCommand comando = new SqlCommand("INSERT INTO Venta (Fecha, Total, Cod_Cliente, Cod_Empleado, Cod_TipoPago) " +
                    "VALUES (@Fecha, @Total, @CodCliente, @CodEmpleado, @Cod_TipoPago)", conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    comando.Parameters.AddWithValue("@Total", totalPago);
                    comando.Parameters.AddWithValue("@CodCliente", codCliente);
                    comando.Parameters.AddWithValue("@CodEmpleado", codEmpleado);
                    comando.Parameters.AddWithValue("@Cod_TipoPago", TipoPago);

                    comando.ExecuteNonQuery();
                }

                // insertar detalles de productos vendidos en la tabla DetalleVenta
                decimal totalVenta = 0; 

                foreach (ListViewItem item in LVCompra.Items)
                {
                    string tituloProducto = item.SubItems[0].Text;
                    int cantidadComprada = int.Parse(item.SubItems[2].Text);
                    int codProducto = ObtenerCodigoProducto(tituloProducto);
                    decimal precioProducto = ObtenerPrecioProducto(codProducto);
                    decimal totalProducto = precioProducto * cantidadComprada; 
                    totalVenta += totalProducto; // Sumar al total de la venta

                    // insertar el detalle de la venta en DetalleVenta
                    InsertarDetalleVenta(codVenta, codProducto, precioProducto, cantidadComprada);
                }

                // actualizar el total de la venta en la tabla Venta
                using (SqlCommand actualizarTotalCmd = new SqlCommand("UPDATE Venta SET Total = @Total WHERE Cod_Venta = @CodVenta", conexion))
                {
                    actualizarTotalCmd.Parameters.AddWithValue("@Total", totalVenta);
                    actualizarTotalCmd.Parameters.AddWithValue("@CodVenta", codVenta);
                    actualizarTotalCmd.ExecuteNonQuery();
                }
            
            }

            // limpia el carrito y realiza otras acciones necesarias después de la compra
            LVCompra.Items.Clear();
            TBTotalPago.Clear();
            BLimpiar.Visible = false;
            BVaciarCarrito.Enabled = false;

            // muestra los productos nuevamente
            MostrarProductos();
           
            MessageBox.Show("Venta realizada correctamente :)", "Compra correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BLimpiar.Visible = false;BCancelarCompra.PerformClick(); 
            TBCliente.Enabled = true;
            BorrarTodo();
            QuitarErrores();BBuscar.Visible = true;
            BVaciarCarrito.Enabled = false;
            TotalRecaudado = 0.0m;
        }

        decimal TotalRecaudado = 0.0m;
        private void InsertarDetalleVenta(int codVenta, int codProducto, decimal precioProducto, int cantidadComprada)
        {
            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand("INSERT INTO DetalleVenta (Cod_Producto, Cod_Venta, Precio, Cantidad, Total) " +
                    "VALUES (@CodProducto, @CodVenta, @Precio, @Cantidad, @Total)", conexion))
                {

                   
                    TotalRecaudado = precioProducto * cantidadComprada;
                    comando.Parameters.AddWithValue("@CodProducto", codProducto);
                    comando.Parameters.AddWithValue("@CodVenta", codVenta);
                    comando.Parameters.AddWithValue("@Precio", precioProducto);
                    comando.Parameters.AddWithValue("@Cantidad", cantidadComprada);
                    comando.Parameters.AddWithValue("@Total", TotalRecaudado);

                    comando.ExecuteNonQuery();
                }
            }
        }


        public decimal ObtenerPrecioProducto(int codProducto)
        {
            decimal precio = 0.0m;

            using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand("SELECT Precio FROM Producto WHERE Cod_Producto = @CodProducto", conexion))
                {
                    comando.Parameters.AddWithValue("@CodProducto", codProducto);

                    // ejecuta la consulta y obtiene el precio del producto
                    object result = comando.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        precio = (decimal)result;
                    }
                }
            }

            return precio;
        }

        public void Compra()
        {
            // verificar que existan elementos en el carrito
            if (LVCompra.Items.Count == 0)
            {
                MessageBox.Show("El carrito se encuentra vacío", "Error de compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QuitarErrores();

                if (clienteEncontrado == true && CBPago.Text != "" && ErrorProviders())
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro que deseas realizar la compra?", "Registrar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // realizar la compra
                        RealizarCompra();
                    }
                    else
                    {
                        MessageBox.Show("Venta cancelada", "Error al realizar la venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Falta completar algún dato de compra.\nPor favor revisar los datos", "Error de venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorProviders();
                }
            }
        }

        private void QuitarEspaciosEnListView(ListView LVCompra)
        {
            foreach (ListViewItem item in LVCompra.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text is string)
                    {
                        // elimina los espacios en blanco adicionales en la cadena del subítem
                        string itemSinEspacios = string.Join(" ", subItem.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                        // actualiza el valor del subítem
                        subItem.Text = itemSinEspacios;
                    }
                }
            }
        }

        public decimal totalPago = 0.0m;

        public void BorrarCarrito()
        {
            // verificamos que no estén vacíos
            if (TBProducto.Text != "" && TBPrecio.Text != "" && TBVendedor.Text != "")
            {
                // comprobamos que la cantidad no esté vacía y no sea cero
                string input = TBCantidad.Text;
                string pattern = @"^[1-9]\d*$";

                if (TBCantidad.Text == "" || !Regex.IsMatch(input, pattern))
                {
                    MessageBox.Show("Ingrese un número válido mayor que cero la próxima vez", "Error al ingresar cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBCantidad.Text = "1";
                    return; // Salimos del método si la cantidad no es válida
                }

                // creamos variables locales y convertimos los datos en enteros
                string producto = TBProducto.Text;

                if (int.TryParse(TBCantidad.Text, out int cantidadRequerida))
                {
                    // Verificar si la cantidad requerida es menor o igual al stock actual
                    if (cantidadRequerida > Convert.ToInt32(GridProductosParaVenta.CurrentRow.Cells[3].Value))
                    {
                        MessageBox.Show("La cantidad requerida no puede ser mayor al stock actual", "Error en carrito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TBCantidad.Text = "1";
                        return;
                    }



                    decimal precio = Convert.ToDecimal(TBPrecio.Text);
                    decimal subtotal = cantidadRequerida * precio;

                    // buscar si ya existe una fila con el mismo producto
                    ListViewItem existingItem = null;
                    foreach (ListViewItem item in LVCompra.Items)
                    {
                        if (item.SubItems[0].Text == producto)
                        {
                            existingItem = item;
                            break;
                        }
                    }

                    if (existingItem != null)
                    {
                        int existingCantidad = int.Parse(existingItem.SubItems[2].Text);
                        existingCantidad += cantidadRequerida;
                        existingItem.SubItems[2].Text = existingCantidad.ToString();

                        decimal existingSubtotal = decimal.Parse(existingItem.SubItems[4].Text.Trim('$'));
                        existingSubtotal += subtotal;
                        existingItem.SubItems[4].Text = existingSubtotal.ToString("C"); 
                    }
                    else
                    {
                        ListViewItem fila = new ListViewItem(producto);
                        fila.SubItems.Add(TBDescripcion.Text.ToString());
                        fila.SubItems.Add(cantidadRequerida.ToString());
                        fila.SubItems.Add(precio.ToString("C")); 
                        fila.SubItems.Add(subtotal.ToString("C")); 
                        LVCompra.Items.Add(fila);
                        QuitarEspaciosEnListView(LVCompra);
                    }

                    // actualiza el stock solo del producto actual
                    ActualizarStockEnBaseDeDatos(producto, cantidadRequerida);

                    BVaciarCarrito.Enabled = true;
                    BorrarCamposRegistrados();

                    // calcula el total del pago sumando todos los subtotales
                    totalPago = 0.0m;
                    foreach (ListViewItem item in LVCompra.Items)
                    {
                        decimal SubT = decimal.Parse(item.SubItems[4].Text.Trim('$'));
                        totalPago += SubT;
                    }

                    // Coloca el total en el TextBox
                    TBTotalPago.Text = totalPago.ToString("C"); 
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada no es válida", "Error en carrito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBCantidad.Text = "1";
                }
            }
            else
            {
                MessageBox.Show("Falta completar algún dato del producto, verificar", "Error en carrito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void buscarProducto()
        {
            if (TBBuscarUnProducto.Text == "")
            {
                errorProvider1.SetError(TBBuscarUnProducto, "Debe ingresar un código de producto");
                return;
            }

            bool productoEncontrado = false;
            string codigoProducto = TBBuscarUnProducto.Text.Trim();

                 // Buscar la fila correspondiente al producto en el DataGridView
                   DataGridViewRow filaEncontrada = null;

                     foreach (DataGridViewRow fila in GridProductosParaVenta.Rows)
                            {
                                if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == codigoProducto)
                                {
                                    GridProductosParaVenta.CurrentCell = fila.Cells[0];

                                    // Actualizar la interfaz gráfica con los detalles del producto
                                    TBCantidad.Text = "1";
                                    TBProducto.Text = fila.Cells[1].Value.ToString();
                                    TBPrecio.Text = fila.Cells[4].Value.ToString();
                                    TBDescripcion.Text = fila.Cells[2].Value.ToString();
                                    TBBuscarUnProducto.Clear();
                                    TBCantidad.ReadOnly = false;
                                    errorProvider1.SetError(TBBuscarUnProducto, "");
                                     productoEncontrado  |= true;

                                    // Seleccionar automáticamente la fila encontrada
                                    fila.Selected = true;
                                }
                                
                         }
            
            // mostrar mensaje si no se encontró al producto
            if (!productoEncontrado)
            {
                MessageBox.Show("No se encontró al producto en la base", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscarUnProducto.Clear();
            }
        }  
               


    }
}
