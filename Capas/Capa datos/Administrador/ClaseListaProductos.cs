using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoTaller.Capas.Capa_datos.Administrador
{
    internal class ClaseListaProductos
    {
        private SqlConnection Productos;
        private TextBox TBTitulo;
        private TextBox TBStock;
        private TextBox TBDetalles;
        private TextBox TBPrecio;
        private PictureBox PBImagen;
        private ComboBox CBMaterial;
        private ComboBox CBColorMate;
        private TextBox TBBuscar;
        private ComboBox CBProveedor;
        private ErrorProvider errorProvider1;
        private Button BBorrarListado;
        private Button BGuardarModificacion;
        private DataGridView GridListaProductos;
        private Button BAñadir;
        private Button BEliminarProducto;
        private Button BLimpiarFiltros;
        private Button BRestaurar;
        private Button BImagen;


        public ClaseListaProductos(
            TextBox TBTitulo, TextBox TBStock, TextBox TBDetalles, TextBox TBPrecio, PictureBox PBImagen, Button BRestaurar, Button BImagen,
            ComboBox CBMaterial, ComboBox CBColorMate, ErrorProvider errorProvider1, DataGridView GridListaProductos, Button BGuardarModificacion,
            Button BLimpiarFiltros, Button BEliminarProducto, Button BAñadir, Button BBorrarListado, TextBox TBBuscar, ComboBox CBProveedor, Button bBorrarListado, Button bGuardarModificacion, DataGridView gridListaProductos, Button bAñadir, Button bEliminarProducto, Button BlimpiarFiltros)
        {
            Productos = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.TBTitulo = TBTitulo;
            this.TBStock = TBStock;
            this.TBDetalles = TBDetalles;
            this.TBPrecio = TBPrecio;
            this.PBImagen = PBImagen;
            this.CBMaterial = CBMaterial;
            this.CBColorMate = CBColorMate;
            this.TBBuscar = TBBuscar;
            this.CBProveedor = CBProveedor;
            this.BBorrarListado = bBorrarListado;
            this.BGuardarModificacion = bGuardarModificacion;
            this.GridListaProductos = gridListaProductos;
            this.BAñadir = bAñadir;
            this.BEliminarProducto = bEliminarProducto;
            this.BLimpiarFiltros = BlimpiarFiltros;
            this.BRestaurar = BRestaurar;
            this.errorProvider1 = errorProvider1;
            this.BImagen = BImagen;
        }

        public void BorrarTodo()
        {
            TBTitulo.Clear();
            TBStock.Clear();
            TBDetalles.Clear();
            TBPrecio.Clear();
            PBImagen.Image = null;
            CBMaterial.SelectedItem = null;
            CBColorMate.SelectedItem = null;
            TBBuscar.Clear();
            CBProveedor.SelectedItem = null;
        }

        public void TextoBloqueado()
        {
            TBTitulo.ReadOnly = true;
            TBDetalles.ReadOnly = true;
            TBPrecio.ReadOnly = true;
            TBStock.ReadOnly = true;
            CBColorMate.Enabled = false;
            CBMaterial.Enabled = false;
            CBProveedor.Enabled = false;
            BImagen.Enabled = false;
            BEliminarProducto.Enabled = false;

        }

        public void TextoDesbloqueado()
        {
            TBTitulo.ReadOnly = false;
            TBDetalles.ReadOnly = false;
            TBPrecio.ReadOnly = false;
            TBStock.ReadOnly = false;
            CBColorMate.Enabled = true;
            CBMaterial.Enabled = true;
            CBProveedor.Enabled = true;
            BImagen.Enabled=true;
            BEliminarProducto.Enabled = true;
        }

        public void BorrarListado()
        {
            BBorrarListado.Visible = false;
            BorrarErroresProviders();
            BorrarTodo();
            errorProvider1.SetError(TBTitulo, "");
            errorProvider1.SetError(TBDetalles, "");
            BGuardarModificacion.Enabled = false;
            BEliminarProducto.Visible = false;
            BAñadir.Enabled = true;
            BAñadir.Visible = true; BRestaurar.Visible = false;
            TextoDesbloqueado();

        }


        public bool ErroresProviders()
        {
            bool productoCorrecto = true;

            if (string.IsNullOrWhiteSpace(TBDetalles.Text))
            {
                errorProvider1.SetError(TBDetalles, "Detalles obligatorios y sin espacios en blanco");
                productoCorrecto = false;
            }

            if (TBPrecio.Text == "")
            {
                errorProvider1.SetError(TBPrecio, "Precio obligatorio");
                productoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(TBTitulo.Text))
            {
                errorProvider1.SetError(TBTitulo, "Titulo obligatorio");
                productoCorrecto = false;
            }

            if (TBStock.Text == "")
            {
                errorProvider1.SetError(TBStock, "Stock necesario");
                productoCorrecto = false;
            }

            if (CBColorMate.SelectedItem == null)
            {
                errorProvider1.SetError(CBColorMate, "Categoria necesaria");
                productoCorrecto = false;
            }

            if (CBMaterial.SelectedItem == null)
            {
                errorProvider1.SetError(CBMaterial, "Categoria necesaria");
                productoCorrecto = false;
            }

            if (PBImagen.Image == null)
            {
                errorProvider1.SetError(PBImagen, "Imangen necesaria");
                productoCorrecto = false;
            }

            if (CBProveedor.SelectedItem == null)
            {
                errorProvider1.SetError(CBProveedor, "Proveedor necesario");
                productoCorrecto = false;
            }

            return productoCorrecto;
        }

        public void BuscarProducto()
        {
            BRestaurar.Visible = false;

            if (TBBuscar.Text == "")
            {
                errorProvider1.SetError(TBBuscar, "Debe ingresar un titulo");
                return;
            }
            string textoBuscado = TBBuscar.Text;
            bool productoEncontrado = false;

            //busca la fila en el DataGridView
            foreach (DataGridViewRow fila in GridListaProductos.Rows)
            {
                if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == textoBuscado)
                {

                    GridListaProductos.CurrentCell = fila.Cells[1];
                    TBTitulo.Text = fila.Cells[1].Value.ToString();
                    TBDetalles.Text = fila.Cells[2].Value.ToString();
                    TBPrecio.Text = fila.Cells[3].Value.ToString();
                    TBStock.Text = fila.Cells[4].Value.ToString();
                    CBColorMate.Text = fila.Cells[5].Value.ToString();
                    CBMaterial.Text = fila.Cells[8].Value.ToString();
                    byte[] imageBytes = (byte[])GridListaProductos.CurrentRow.Cells[7].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        PBImagen.Image = System.Drawing.Image.FromStream(ms);
                    }
                    CBProveedor.Text = fila.Cells[9].Value.ToString();
                    errorProvider1.SetError(TBBuscar, "");

                    if (GridListaProductos.CurrentRow != null)
                    {
                        DataGridViewRow selectedRow = GridListaProductos.CurrentRow;
                        int valorEstado = Convert.ToInt32(selectedRow.Cells["Estado"].Value);

                        valorCodigoProducto = Convert.ToInt32(selectedRow.Cells["Cod_producto"].Value);

                        if (valorEstado != 0)
                        {
                            BAñadir.Visible = false;
                            BEliminarProducto.Visible = true;
                            BRestaurar.Visible = false;
                            BGuardarModificacion.Enabled = true;
                            BBorrarListado.Visible = true;
                            TextoDesbloqueado();
                        }
                        else
                        {
                            TextoBloqueado();
                            BRestaurar.Visible = true;
                            BEliminarProducto.Visible = true;
                            BAñadir.Visible = false;
                            BBorrarListado.Visible = true;
                            BAñadir.Visible = false;
                            BEliminarProducto.Visible = false;
                        }
                    }
                    BorrarErroresProviders();
                    MessageBox.Show("Producto encontrado en la base", "Búsqueda de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBBuscar.Clear();
                    productoEncontrado = true;
                }
            }

            // mostrar mensaje si no se encontró al producto
            if (!productoEncontrado)
            {
                MessageBox.Show("No se encontró al producto en la base", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscar.Clear();
            }
        }

        public void BorrarErroresProviders()
        {

            errorProvider1.SetError(PBImagen, "");
            errorProvider1.SetError(TBStock, "");
            errorProvider1.SetError(TBTitulo, "");
            errorProvider1.SetError(TBDetalles, "");
            errorProvider1.SetError(CBMaterial, "");
            errorProvider1.SetError(CBColorMate, "");
            errorProvider1.SetError(TBPrecio, "");
            errorProvider1.SetError(PBImagen, "");
            errorProvider1.SetError(CBProveedor, "");
            errorProvider1.SetError(TBBuscar, "");
        }

        public void GuardarModificacion()
        {
            BorrarErroresProviders();

            try
            {
                if (!string.IsNullOrWhiteSpace(TBTitulo.Text) && !string.IsNullOrWhiteSpace(TBDetalles.Text) && CBColorMate.SelectedItem != null && !string.IsNullOrWhiteSpace(TBPrecio.Text) &&
                    !string.IsNullOrWhiteSpace(TBStock.Text) && PBImagen.Image != null && CBMaterial.SelectedItem != null)
                {
                    if (!TituloExistente(TBTitulo.Text, valorCodigoProducto))
                    {
                        DialogResult result = MessageBox.Show("Estas a punto de modificar un producto", "Modificacion producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            using (SqlConnection Productos = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
                            {
                                Productos.Open();
                                string consultaSQL = "SELECT Cod_Producto FROM Productos";

                                MemoryStream ms = new MemoryStream();
                                PBImagen.Image.Save(ms, ImageFormat.Png);
                                byte[] aByte = ms.ToArray();
                                ms.Close();

                                int valorCelda = Convert.ToInt32(GridListaProductos.Rows[0].Cells[0].Value);

                                string query = "UPDATE Producto SET " +
                                    "ID_Categoria = (SELECT ID_Categoria FROM Categoria WHERE Descripcion = @Material), " +
                                    "Cod_Proveedor = (SELECT Cod_Proveedor FROM Proveedor WHERE Nombre = @Proveedor), " +
                                    "Titulo = @nuevoTitulo, " +
                                    "Precio = @nuevoPrecio, " +
                                    "Stock = @nuevoStock, " +
                                    "Imagen= @nuevaImagen, " +
                                    "Descripcion = @nuevoDescripcion, " +
                                    "Color = @nuevoColor " +
                                    "WHERE Cod_Producto = @Cod_Producto";

                                SqlCommand cmd = new SqlCommand(query, Productos);

                                string colorMate = CBColorMate.SelectedItem as string;
                                string selectedIvaDescription = CBMaterial.SelectedItem as string;
                                string proveedor = CBProveedor.SelectedItem as string;
                                cmd.Parameters.AddWithValue("@Material", selectedIvaDescription);
                                cmd.Parameters.AddWithValue("@nuevoTitulo", TBTitulo.Text);
                                cmd.Parameters.AddWithValue("@nuevoPrecio", decimal.Parse(TBPrecio.Text));
                                cmd.Parameters.AddWithValue("@nuevoStock", int.Parse(TBStock.Text));
                                cmd.Parameters.AddWithValue("@nuevoDescripcion", TBDetalles.Text);
                                cmd.Parameters.AddWithValue("@nuevoColor", colorMate);
                                cmd.Parameters.AddWithValue("@Cod_Producto", valorCodigoProducto);
                                cmd.Parameters.AddWithValue("@Proveedor", proveedor);
                                cmd.Parameters.AddWithValue("@NuevaImagen", aByte);

                                int filasAfectadas = cmd.ExecuteNonQuery();

                                MostrarProductos();

                                MessageBox.Show("Producto modificado correctamente", "Tarea completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                quitarEspacios();
                                TextoDesbloqueado();
                                BorrarTodo();
                                BorrarListado();
                                BLimpiarFiltros.PerformClick();
                                BLimpiarFiltros.Visible = false;
                                BGuardarModificacion.Enabled = false;
                                BEliminarProducto.Visible = false;
                                BAñadir.Enabled = true;
                                BorrarErroresProviders();
                                BBorrarListado.Visible = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Modificacion  de producto cancelada!", "Error en la modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Producto ya existe en la base, verificar en la lista", "Error en la  modificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios o espacios en blanco\r\nPor favor revisar", "Error en la modificacion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    ErroresProviders();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("expects the parameter '@Proveedor', which was not supplied."))
                {
                    MessageBox.Show("Error en la modificación: El proveedor no ha sido seleccionado", "Error en la modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void EliminarProducto()
        {
                DialogResult result = MessageBox.Show("Desea eliminar el producto?", "Eliminación de produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    Productos.Open();
                    string eliminar = "UPDATE Producto SET Estado = @Estado WHERE Cod_Producto = @Cod_Producto";

                    SqlCommand cmd = new SqlCommand(eliminar, Productos);

                    cmd.Parameters.AddWithValue("@Estado", 0);
                    cmd.Parameters.AddWithValue("@Cod_Producto", valorCodigoProducto);
 
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    Productos.Close();

                    MostrarProductos();

                    TBBuscar.Text = "";
                    MessageBox.Show("Eliminación de producto realizada", "Eliminación de producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BorrarTodo();
                    BLimpiarFiltros.Visible = false;
                    BGuardarModificacion.Enabled = false;
                    BEliminarProducto.Enabled = false;
                    BAñadir.Enabled = true;
                    BorrarErroresProviders();TextoDesbloqueado();
                    BEliminarProducto.Visible = false;
                    BBorrarListado.Visible = false;BorrarListado();

                }
                else
                {
                    MessageBox.Show("Eliminación de producto cancelada!", "Error en eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          
        }


        public void RestaurarProducto()
        {

            if (!string.IsNullOrWhiteSpace(TBTitulo.Text) && !string.IsNullOrWhiteSpace(TBDetalles.Text) && CBColorMate.SelectedItem != null && !string.IsNullOrWhiteSpace(TBPrecio.Text) &&
            !string.IsNullOrWhiteSpace(TBStock.Text) && PBImagen.Image != null && CBMaterial.SelectedItem != null)
            {
              
                    Productos.Open();
                    string eliminar = "UPDATE Producto SET Estado = @Estado WHERE Cod_Producto = @Cod_Producto";

                    SqlCommand cmd = new SqlCommand(eliminar, Productos);

                    cmd.Parameters.AddWithValue("@Estado", 1);
                    cmd.Parameters.AddWithValue("@Cod_Producto", valorCodigoProducto);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    Productos.Close();

                    MostrarProductos();

                    TBBuscar.Text = "";
                    MessageBox.Show("Restauracion de producto realizada", "Restauracion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BorrarTodo();
                    BLimpiarFiltros.Visible = false;
                    BGuardarModificacion.Enabled = false;
                    BRestaurar.Visible = false;
                    BEliminarProducto.Enabled = false;
                    BAñadir.Enabled = true;
                    BorrarErroresProviders(); TextoDesbloqueado();
                    BEliminarProducto.Visible = false; BorrarListado();
                      BBorrarListado.Visible = false;

                }
            else
            {
                MessageBox.Show("Campos vacios o espacios en blanco\r\nPor favor revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }



        public void quitarEspacios()
        {
            foreach (DataGridViewRow row in GridListaProductos.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is string)
                    {
                        // elimina los espacios en blanco adicionales en la cadena de la celda
                        string gridSinEspacios = string.Join(" ", cell.Value.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                        // actualiza el valor de la celda
                        cell.Value = gridSinEspacios;
                    }
                }
            }
        }

        public void MostrarProductos()
        {
            string consulta = "SELECT P.Cod_Producto, P.Titulo, P.Descripcion, P.Precio, P.Stock, P.Color, P.Estado,Imagen, C.Descripcion AS Categoria, PR.Nombre AS Proveedor " +
                      "FROM Producto P " + "INNER JOIN Categoria C ON P.ID_Categoria = C.ID_Categoria " +
                      "INNER JOIN Proveedor PR ON P.Cod_Proveedor = PR.Cod_Proveedor";

            SqlDataAdapter lista = new SqlDataAdapter(consulta, Productos);
            DataTable dt = new DataTable();
            lista.Fill(dt);
            GridListaProductos.DataSource = dt;
            quitarEspacios();
        }

        private int valorCodigoProducto;
        public void DobleClick()
        {
            TBTitulo.Text = GridListaProductos.CurrentRow.Cells[1].Value.ToString();
            TBDetalles.Text = GridListaProductos.CurrentRow.Cells[2].Value.ToString();
            CBColorMate.Text = GridListaProductos.CurrentRow.Cells[5].Value.ToString();
            TBPrecio.Text = GridListaProductos.CurrentRow.Cells[3].Value.ToString();
            TBStock.Text = GridListaProductos.CurrentRow.Cells[4].Value.ToString();
            byte[] imageBytes = (byte[])GridListaProductos.CurrentRow.Cells[7].Value;


            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                PBImagen.Image = System.Drawing.Image.FromStream(ms);
            }

            CBMaterial.Text = GridListaProductos.CurrentRow.Cells[8].Value.ToString();
            CBProveedor.Text = GridListaProductos.CurrentRow.Cells[9].Value.ToString();
            TextoDesbloqueado();
            BGuardarModificacion.Enabled = true;
            BEliminarProducto.Enabled = true;

            BorrarErroresProviders();
            BAñadir.Enabled = false;
            BBorrarListado.Visible = true;

            if (GridListaProductos.CurrentRow != null)
            {
                DataGridViewRow selectedRow = GridListaProductos.CurrentRow;

                int valorEstado = Convert.ToInt32(selectedRow.Cells["Estado"].Value);

                valorCodigoProducto = Convert.ToInt32(selectedRow.Cells["Cod_Producto"].Value);

                if (valorEstado != 0)
                {
                    BEliminarProducto.Visible = true;
                    BRestaurar.Visible = false;
                    TextoDesbloqueado();
                }
                else
                {
                    TextoBloqueado();
                    BRestaurar.Visible = true;
                    BEliminarProducto.Visible = false;
                }
            }

        }

        private bool TituloExistente(string titulo, int codCliente)
        {
            string consulta = "SELECT Titulo From Producto WHERE Titulo = @Titulo AND Cod_Producto <> @CodProducto";
            Productos.Open();

            SqlCommand cmd = new SqlCommand(consulta, Productos);

            cmd.Parameters.AddWithValue("@Titulo", titulo);
            cmd.Parameters.AddWithValue("@CodProducto", codCliente);

            SqlDataReader reader = cmd.ExecuteReader();

            bool dniExiste = reader.HasRows;

            Productos.Close();
            reader.Close();

            return dniExiste;
        }


        public void AñadirProducto()
        {

            string titulo = TBTitulo.Text;
            BorrarErroresProviders();

            if (!string.IsNullOrWhiteSpace(TBTitulo.Text) && !string.IsNullOrWhiteSpace(TBDetalles.Text) && CBColorMate.SelectedItem != null && !string.IsNullOrWhiteSpace(TBPrecio.Text) &&
                !string.IsNullOrWhiteSpace(TBStock.Text) && CBMaterial.SelectedItem != null && ErroresProviders())
            {

                if(!TituloExistente(TBTitulo.Text, valorCodigoProducto)){
                    DialogResult result = MessageBox.Show("Estás a punto de agregar un producto", "Agregar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        MemoryStream ms = new MemoryStream();
                        PBImagen.Image.Save(ms, ImageFormat.Png);

                        byte[] aByte = ms.ToArray();
                        ms.Close();

                        Productos.Open();

                      
                        string query = "INSERT INTO Producto (Titulo, Descripcion, Stock, Precio, Color, Estado, Imagen, ID_Categoria, Cod_Proveedor) " +
                            "SELECT @Titulo, @Descripcion, @Stock, @Precio, @Color, @Estado, @Imagen, CA.ID_Categoria, P.Cod_Proveedor " +
                            "FROM Categoria CA " +
                            "INNER JOIN Proveedor P ON CA.Descripcion = @Categoria AND P.Nombre = @Proveedor";

                     
                        SqlCommand cmd = new SqlCommand(query, Productos);

                        string selectedIvaDescription = CBMaterial.SelectedItem as string;
                        string colorMate = CBColorMate.SelectedItem as string;
                        string Proveedor = CBProveedor.SelectedItem as string;

                        
                        cmd.Parameters.AddWithValue("@Titulo", TBTitulo.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", TBDetalles.Text);
                        cmd.Parameters.AddWithValue("@Stock", TBStock.Text);
                        cmd.Parameters.AddWithValue("@Precio", TBPrecio.Text);
                        cmd.Parameters.AddWithValue("@Color", colorMate);
                        cmd.Parameters.AddWithValue("@Categoria", selectedIvaDescription);
                        cmd.Parameters.AddWithValue("@Proveedor", Proveedor);
                        cmd.Parameters.AddWithValue("@Estado", 1);
                        cmd.Parameters.AddWithValue("@Imagen", aByte);

                    
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        Productos.Close();

                        MostrarProductos();
                        MessageBox.Show("Producto añadido correctamente", "Añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        quitarEspacios();
                        BorrarTodo();
                        BLimpiarFiltros.Visible = false;
                        BorrarErroresProviders();
                    }
                    else
                    {
                        MessageBox.Show("Inserción de producto cancelada!", "Erro en añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Producto ya existe en la base", "Error en la insercion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
            }
            else
            {
                MessageBox.Show("Campos vacíos o espacios en blanco\r\nPor favor revisar los iconos en rojo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }



        public void BotonImagen()
        {
            OpenFileDialog ofdSeleccionarFoto = new OpenFileDialog();
            ofdSeleccionarFoto.Filter = "Imágenes|*.png";
            ofdSeleccionarFoto.Title = "Seleccionar Foto de Producto";

            if (ofdSeleccionarFoto.ShowDialog() == DialogResult.OK)
            {
                
                PBImagen.Image = System.Drawing.Image.FromFile(ofdSeleccionarFoto.FileName);
            }
         
        }
        public void ComboProveedores()
        {

            string connectionString = "Server=.; Database=UnMate; Integrated Security=True;"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string consulta = "SELECT Nombre FROM Proveedor Where Estado = 1";
                SqlCommand cmd = new SqlCommand(consulta, connection); 

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreProveedor = reader["Nombre"].ToString();
                        CBProveedor.Items.Add(nombreProveedor);
                    }
                }
            }
        }

    }
}