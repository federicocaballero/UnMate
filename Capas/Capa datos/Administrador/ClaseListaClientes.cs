using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Administrador
{
    internal class ClaseListaClientes
    {
        private SqlConnection Clientes;
        private TextBox TBApellido;
        private TextBox TBTelefono;
        private TextBox TBNombre;
        private TextBox TBEmail;
        private TextBox TBDni;
        private ErrorProvider errorProvider1;
        private DataGridView GridListaUsuarios;
        private Button BGuardarModificacion;
        private Button BBorrarListado;
        private Button BRestaurar;
        private Button BEliminarCliente;
        private TextBox TBBuscar;
        private Button BLimpiarFiltros;


        public ClaseListaClientes(TextBox TBApellido, TextBox TBTelefono, TextBox TBNombre, TextBox TBEmail, TextBox TBDni, ErrorProvider errorProvider1, DataGridView GridListaUsuarios, Button BGuardarModificacion,
            Button BBorrarListado, Button BRestaurar, Button BEliminarCliente, TextBox TBBuscar, Button BLimpiarFiltros)
        {
            Clientes = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.TBApellido = TBApellido;
            this.TBTelefono = TBTelefono;
            this.TBNombre = TBNombre;
            this.TBEmail = TBEmail;
            this.TBDni = TBDni;
            this.GridListaUsuarios = GridListaUsuarios;
            this.BGuardarModificacion = BGuardarModificacion;
            this.BBorrarListado = BBorrarListado;
            this.BRestaurar = BRestaurar;
            this.BEliminarCliente = BEliminarCliente;
            this.errorProvider1 = errorProvider1;
            this.BLimpiarFiltros = BLimpiarFiltros;
            this.TBBuscar = TBBuscar;
        }

        public void TextoDesbloqueado()
        {
            TBNombre.ReadOnly = false;
            TBApellido.ReadOnly = false;
            TBTelefono.ReadOnly = false;
            TBEmail.ReadOnly = false;
            TBDni.ReadOnly = false;

        }

        public void TextoBloqueado()
        {
            TBNombre.ReadOnly = true;
            TBApellido.ReadOnly = true;
            TBTelefono.ReadOnly = true;
            TBEmail.ReadOnly = true;
            TBDni.ReadOnly = true;

        }

        private int valorCodigoCliente;
        public void DobleClick()
        {
            TBDni.Text = GridListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            TBNombre.Text = GridListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            TBApellido.Text = GridListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            TBEmail.Text = GridListaUsuarios.CurrentRow.Cells[4].Value.ToString();
            TBTelefono.Text = GridListaUsuarios.CurrentRow.Cells[5].Value.ToString();
            QuitarErrores();
            BGuardarModificacion.Enabled = true;
            BBorrarListado.Visible = true;

            if (GridListaUsuarios.CurrentRow != null)
            {
                DataGridViewRow selectedRow = GridListaUsuarios.CurrentRow;
                int valorEstado = Convert.ToInt32(selectedRow.Cells["Estado"].Value);

                valorCodigoCliente = Convert.ToInt32(selectedRow.Cells["Cod_Cliente"].Value);

                if (valorEstado != 0)
                {
                    BEliminarCliente.Visible = true;
                    BRestaurar.Visible = false;
                    BGuardarModificacion.Visible = true;
                    TextoDesbloqueado();
                }
                else
                {
                    BRestaurar.Visible = true;
                    BEliminarCliente.Visible = false; BGuardarModificacion.Visible = false;
                    TextoBloqueado();
                }
            }
        }

        public void BorrarFilas()
        {
            TBTelefono.Clear();
            TBEmail.Clear();
            TBDni.Clear();
            TBApellido.Clear();
            TBNombre.Clear();
            TBBuscar.Clear();
            QuitarErrores();
            BBorrarListado.Visible = false; BEliminarCliente.Visible = false; BRestaurar.Visible = false;
            BGuardarModificacion.Visible = false;
            TextoBloqueado();

        }

        public bool ErroresProviders()
        {
            bool CampoCorrecto = true;

            if (TBApellido.Text == "")
            {
                errorProvider1.SetError(TBApellido, "Apellido obligatorio");
                CampoCorrecto = false;
            }

            if (TBApellido.Text == "")
            {
                errorProvider1.SetError(TBApellido, "Apellido obligatorio");
                CampoCorrecto = false;
            }


            if (TBTelefono.Text == "")
            {
                errorProvider1.SetError(TBTelefono, "Telefono obligatorio");
                CampoCorrecto = false;
            }

            if (TBNombre.Text == "")
            {
                errorProvider1.SetError(TBNombre, "Nombre obligatorio");
                CampoCorrecto = false;
            }

            if (EsDireccionDeCorreoValida(TBEmail.Text) == false)
            {
                errorProvider1.SetError(TBEmail, "Formato de correo incorrecto");
                CampoCorrecto = false;
            }

            if (TBDni.Text == "")
            {
                errorProvider1.SetError(TBDni, "DNI obligatorio");
                CampoCorrecto = false;
            }


            if (TBTelefono.Text == "")
            {
                errorProvider1.SetError(TBTelefono, "Telefono obligatorio");
                CampoCorrecto = false;
            }

            return CampoCorrecto;
        }

        public bool EsDireccionDeCorreoValida(string direccionCorreo)
        {
            // define el patrón de una dirección de correo electrónico válida
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // compila la expresión regular
            Regex regex = new Regex(patron);

            // verifica si la dirección de correo coincide con el patrón
            return regex.IsMatch(direccionCorreo);
        }

        public void QuitarErrores()
        {
            errorProvider1.SetError(TBNombre, "");
            errorProvider1.SetError(TBApellido, "");
            errorProvider1.SetError(TBTelefono, "");
            errorProvider1.SetError(TBEmail, "");
            errorProvider1.SetError(TBDni, "");
            errorProvider1.SetError(TBBuscar, "");
        }

        public void MostrarClientes()
        {
            TextoBloqueado();
            
            // abre la conexión a la base de datos
            Clientes.Open();

            string consulta = "Select Cod_Cliente, DNI_Cliente, Nombre, Apellido, Email, Telefono, Estado, Alta from Cliente";
            SqlDataAdapter lista = new SqlDataAdapter(consulta, Clientes);
            DataTable dt = new DataTable();
            lista.Fill(dt);

            // cierra la conexión a la base de datos
            Clientes.Close();

            GridListaUsuarios.DataSource = dt;

   
        }

        public void EliminarCliente()
        {

            DialogResult result = MessageBox.Show("Desea eliminar al cliente?", "Eliminacion de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // abre la conexión a la base de datos
                Clientes.Open();

                string eliminar = "UPDATE Cliente SET Estado = @Estado WHERE Cod_Cliente = @Cod_Cliente";

                // crea un objeto SqlCommand
                SqlCommand cmd = new SqlCommand(eliminar, Clientes);

                // agrega los parámetros con sus valores
                cmd.Parameters.AddWithValue("@Estado", 0);
                cmd.Parameters.AddWithValue("@Cod_Cliente", valorCodigoCliente);


                int filasAfectadas = cmd.ExecuteNonQuery();

                // cierra la conexión a la base de datos
                Clientes.Close();


              
                    MessageBox.Show("Cliente eliminado exitosamente", "Eliminación de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BEliminarCliente.Visible = false; BBorrarListado.Visible = false;BGuardarModificacion.Enabled = false;

                    // Actualiza el grid
                    MostrarClientes();
                    BorrarFilas();
                    QuitarErrores();
                    QuitarEspacios();
                }
                else
                {
                    MessageBox.Show("Eliminacion de cliente cancelada", "Error en la eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
           
        }

        public void RestaurarCliente()
        {
            // abre la conexión a la base de datos
            Clientes.Open();

            string eliminar = "UPDATE Cliente SET Estado = @Estado WHERE Cod_Cliente = @Cod_Cliente";

            // crea un objeto SqlCommand
            SqlCommand cmd = new SqlCommand(eliminar, Clientes);

            // Agrega los parámetros con sus valores
            cmd.Parameters.AddWithValue("@Estado", 1);
            cmd.Parameters.AddWithValue("@Cod_Cliente", valorCodigoCliente);


            int filasAfectadas = cmd.ExecuteNonQuery();

            // cierra la conexión a la base de datos
            Clientes.Close();


            MessageBox.Show("Cliente restaurado exitosamente.", "Restauración de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BRestaurar.Visible = false;
                        BBorrarListado.Visible = false;
                        BEliminarCliente.Visible = false;
                        BBorrarListado.Visible = false;
                        BGuardarModificacion.Enabled = false;
                        BGuardarModificacion.Visible = true;
                        TextoDesbloqueado();
                        MostrarClientes();
                        BorrarFilas();
                        QuitarErrores();
                        QuitarEspacios();
        }

        public void QuitarEspacios()
        {
            foreach (DataGridViewRow row in GridListaUsuarios.Rows)
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

        private bool DniExistente(string dni, int codCliente)
        {
            string consulta = "SELECT DNI_Cliente FROM Cliente WHERE DNI_Cliente = @DNI AND Cod_Cliente <> @CodCliente";

            Clientes.Open();

            SqlCommand cmd = new SqlCommand(consulta, Clientes);

            cmd.Parameters.AddWithValue("@DNI", dni);
            cmd.Parameters.AddWithValue("@CodCliente", codCliente);

            SqlDataReader reader = cmd.ExecuteReader();

            bool dniExiste = reader.HasRows;

            Clientes.Close();
            reader.Close();

            return dniExiste;
        }

        private bool TelefonoExistente(string telefono, int codCliente)
        {
            string consulta = "SELECT Telefono FROM Cliente WHERE Telefono = @Telefono AND Cod_Cliente <> @CodCliente";

            Clientes.Open();

            SqlCommand cmd = new SqlCommand(consulta, Clientes);

            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@CodCliente", codCliente);

            SqlDataReader reader = cmd.ExecuteReader();

            bool telefonoExiste = reader.HasRows;

            Clientes.Close();
            reader.Close();

            return telefonoExiste;
        }

        private bool EmailExistente(string email, int codCliente)
        {
            string consulta = "SELECT Email FROM Cliente WHERE Email = @Email AND Cod_Cliente <> @CodCliente";

            Clientes.Open();

            SqlCommand cmd = new SqlCommand(consulta, Clientes);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@CodCliente", codCliente);

            SqlDataReader reader = cmd.ExecuteReader();

            bool emailExiste = reader.HasRows;

            Clientes.Close();
            reader.Close();

            return emailExiste;
        }


        public void GuardarModificacion()
        {
            string direccionCorreo = TBEmail.Text;
            string EmailActual = TBEmail.Text;
            
            QuitarErrores();
            
            // verifica que los campos no esten vacios y una direccion de correo valida
            if (TBDni.Text != "" && TBEmail.Text != "" && TBApellido.Text != ""
               && TBNombre.Text != "" && ErroresProviders() && (EsDireccionDeCorreoValida(direccionCorreo)))
            {
                // verifica que no se repitan datos
                if ((!DniExistente(TBDni.Text, valorCodigoCliente)) &&
               (!TelefonoExistente(TBTelefono.Text, valorCodigoCliente) &&
               (!EmailExistente(TBEmail.Text, valorCodigoCliente) && EmailActual == TBEmail.Text)))
                {
                    DialogResult result = MessageBox.Show("Desea modificar al cliente?", "Modificacion de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                        Clientes.Open();

                        string query = "UPDATE Cliente " + "SET DNI_Cliente = @DNI, " + "Nombre = @NuevoNombre, " + "Apellido = @NuevoApellido, " + "Email = @NuevoEmail, " +
                                        "Telefono = @NuevoTelefono " +
                                        "WHERE Cod_Cliente = @Cod_Cliente";

                        
                        SqlCommand cmd = new SqlCommand(query, Clientes);

                        // Agrega un parámetro con su valor
                        cmd.Parameters.AddWithValue("@NuevoNombre", TBNombre.Text);
                        cmd.Parameters.AddWithValue("@NuevoApellido", TBApellido.Text);
                        cmd.Parameters.AddWithValue("@NuevoEmail", TBEmail.Text);
                        cmd.Parameters.AddWithValue("@NuevoTelefono", TBTelefono.Text);
                        cmd.Parameters.AddWithValue("@DNI", TBDni.Text);
                        cmd.Parameters.AddWithValue("@Cod_Cliente", valorCodigoCliente);
                       
                    
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        //cerramos la base
                        Clientes.Close();

                        // actualiza el grid
                        MostrarClientes();

                        MessageBox.Show("Modificación de cliente realizada", "Modificación de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BLimpiarFiltros.PerformClick(); BLimpiarFiltros.Visible = false; BBorrarListado.Visible = false;
                        BRestaurar.Visible = false; BEliminarCliente.Visible = false;
                        BGuardarModificacion.Enabled = false;
                        BorrarFilas();
                        QuitarErrores();
                        QuitarEspacios();
                    }

                
                else
                {
                    MessageBox.Show("Modificación de cliente cancelada!", "Error en la modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                }
                else
                {
                    MessageBox.Show("Hay un dato que ya existe en la base, verificar en la lista", "Error en modificar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Verifique integridad de los campos marcados", "Error en modificar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        public void BuscarCliente()
        {
            BRestaurar.Visible = false;
            if (TBBuscar.Text == "")
            {
                errorProvider1.SetError(TBBuscar, "Debe ingresar un DNI");
                return;
            }

            string textoBuscado = TBBuscar.Text.Trim();
            bool clienteEncontrado = false;


            foreach (DataGridViewRow fila in GridListaUsuarios.Rows)
            {
                if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == textoBuscado)
                {
                    GridListaUsuarios.CurrentCell = fila.Cells[1];

                    // actualiza los campos con los datos de la fila seleccionada
                    TBDni.Text = fila.Cells[1].Value.ToString();
                    TBNombre.Text = fila.Cells[2].Value.ToString();
                    TBApellido.Text = fila.Cells[3].Value.ToString();
                    TBEmail.Text = fila.Cells[4].Value.ToString();
                    TBTelefono.Text = fila.Cells[5].Value.ToString();

                    errorProvider1.SetError(TBBuscar, "");
                    if (GridListaUsuarios.CurrentRow != null)
                    {
                        DataGridViewRow selectedRow = GridListaUsuarios.CurrentRow;
                        int valorEstado = Convert.ToInt32(selectedRow.Cells["Estado"].Value);

                        valorCodigoCliente = Convert.ToInt32(selectedRow.Cells["Cod_Cliente"].Value);

                        if (valorEstado != 0)
                        {
                            BEliminarCliente.Visible = true;
                            BRestaurar.Visible = false;
                            BGuardarModificacion.Enabled = true;
                            BGuardarModificacion.Visible = true;
                            BBorrarListado.Visible = true;
                            TextoDesbloqueado();
                        }
                        else
                        {
                            TextoBloqueado();
                            BRestaurar.Visible = true;
                            BEliminarCliente.Visible = false;
                            BBorrarListado.Visible = true;
                           
                        }
                    }
                    QuitarErrores();
                    MessageBox.Show("Cliente encontrado en la base", "Búsqueda de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBBuscar.Clear();
                    clienteEncontrado = true; 
                    break;
                }
            }
            // mostrar mensaje si no se encontró al cliente
            if (!clienteEncontrado)
            {
                MessageBox.Show("No se encontró al cliente en la base", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscar.Clear();
            }

        }
    }
}
