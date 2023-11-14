using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Vendedor
{
    internal class ClaseClientes
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
        private Button BAñadirC;
        private Button BRestaurar;
        private Button BEliminarCliente;
        private TextBox TBBuscar;
        private Button BLimpiarFiltros;
        private DateTimePicker DTPAltaUsuario;


        public ClaseClientes(TextBox TBApellido, TextBox TBTelefono, TextBox TBNombre, TextBox TBEmail, TextBox TBDni,ErrorProvider errorProvider1, DataGridView GridListaUsuarios, Button BGuardarModificacion,
            Button BBorrarListado, Button BAñadirC, Button BRestaurar, Button BEliminarCliente, TextBox TBBuscar,Button BLimpiarFiltros, DateTimePicker DTPAltaUsuario)
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
            this.BAñadirC = BAñadirC;
            this.BRestaurar = BRestaurar;
            this.BEliminarCliente = BEliminarCliente;
            this.errorProvider1 = errorProvider1;
            this.BLimpiarFiltros = BLimpiarFiltros;
            this.DTPAltaUsuario = DTPAltaUsuario;
            this.TBBuscar = TBBuscar;
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
            BAñadirC.Enabled = true;
            BGuardarModificacion.Enabled = false; BBorrarListado.Visible = false; BEliminarCliente.Visible = false; BRestaurar.Visible = false;
            BGuardarModificacion.Visible = true;

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

        public  bool EsDireccionDeCorreoValida(string direccionCorreo)
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
            // abre la conexión a la base de datos
            Clientes.Open();

            string consulta = "Select Cod_Cliente, DNI_Cliente,Nombre,Apellido,Email,Telefono,Estado,Alta from Cliente";
            SqlDataAdapter lista = new SqlDataAdapter(consulta, Clientes);
            DataTable dt = new DataTable();
            lista.Fill(dt);
            GridListaUsuarios.DataSource = dt;

            // cierra la conexión a la base de datos
            Clientes.Close();
        }

        public void AñadirCliente()
        {
            QuitarErrores();
            string direccionCorreo = TBEmail.Text;
            bool dniExiste = DniExistente(TBDni.Text, valorCodigoCliente);
            bool telefonoExiste = TelefonoExistente(TBDni.Text, valorCodigoCliente);
            bool emailExiste= EmailExistente(TBEmail.Text, valorCodigoCliente);

            // campos distintos de vacío
            if (TBDni.Text != "" && TBEmail.Text != "" && TBApellido.Text != "" && TBNombre.Text != "" && ErroresProviders() && EsDireccionDeCorreoValida(direccionCorreo))
            {
                if (!DniExistente(TBDni.Text,valorCodigoCliente) && !TelefonoExistente(TBTelefono.Text, valorCodigoCliente) && !EmailExistente(TBEmail.Text,valorCodigoCliente))
                {
                    DialogResult result = MessageBox.Show("¿Desea añadir un cliente?", "Añadir un cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                            // abre la conexión a la base de datos
                            Clientes.Open();

                            // consulta SQL con parámetros
                            string query = "INSERT INTO Cliente (DNI_Cliente, Nombre, Apellido, Email, Telefono, Estado, Alta) VALUES (@DNI, @Nombre, @Apellido, @Email, @Telefono, 1, @Alta)";

                            DateTime fechaSeleccionada = DTPAltaUsuario.Value;
                            int fechaEntera = 0;

                            if (fechaSeleccionada != DateTime.MinValue)
                            {
                                fechaEntera = int.Parse(fechaSeleccionada.ToString("yyyyMMdd"));
                            }

                            SqlCommand cmd = new SqlCommand(query, Clientes);

                            cmd.Parameters.AddWithValue("@DNI", TBDni.Text);
                            cmd.Parameters.AddWithValue("@Nombre", TBNombre.Text);
                            cmd.Parameters.AddWithValue("@Apellido", TBApellido.Text);
                            cmd.Parameters.AddWithValue("@Email", TBEmail.Text);
                            cmd.Parameters.AddWithValue("@Telefono", TBTelefono.Text);
                            cmd.Parameters.AddWithValue("@Alta", fechaEntera);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            Clientes.Close();

                            MostrarClientes();

                            MessageBox.Show("Cliente agregado con éxito", "Añadir un cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BorrarFilas();
                            QuitarErrores();
                            QuitarEspacios();
                    }
                    else
                    {
                        MessageBox.Show("Inserción cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El DNI, teléfono o correo electrónico ya existe en la base de datos. Verifique integridad de los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Verifique integridad de los campos marcados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
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

            if (TBDni.Text != "" && TBEmail.Text != "" && TBApellido.Text != "" &&
                TBNombre.Text != "" && ErroresProviders() && EsDireccionDeCorreoValida(direccionCorreo))
            {
                if((!DniExistente(TBDni.Text, valorCodigoCliente)  ) &&
                    (!TelefonoExistente(TBTelefono.Text, valorCodigoCliente)) &&
                    (!EmailExistente(TBEmail.Text, valorCodigoCliente) && EmailActual == TBEmail.Text))
                {
                    DialogResult result = MessageBox.Show("¿Desea modificar al cliente?", "Modificacion de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Clientes.Open();

                        string query = "UPDATE Cliente " +"SET Nombre = @NuevoNombre, " +"Apellido = @NuevoApellido, " +
                            "Email = @NuevoEmail, " + "DNI_Cliente = @NuevoDni, " +"Telefono = @NuevoTelefono " +"WHERE Cod_Cliente = @Cod_Cliente";

                
                        SqlCommand cmd = new SqlCommand(query, Clientes);

                        // agrega parámetros con sus valores
                        cmd.Parameters.AddWithValue("@NuevoNombre", TBNombre.Text);
                        cmd.Parameters.AddWithValue("@NuevoApellido", TBApellido.Text);
                        cmd.Parameters.AddWithValue("@NuevoEmail", TBEmail.Text);
                        cmd.Parameters.AddWithValue("@NuevoTelefono", TBTelefono.Text);
                        cmd.Parameters.AddWithValue("@Cod_Cliente", valorCodigoCliente);
                        cmd.Parameters.AddWithValue("@NuevoDni", TBDni.Text);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        Clientes.Close();

                        MostrarClientes();
                        BorrarFilas();
                        MessageBox.Show("Cliente modificado exitosamente", "Modificacion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Modificación cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay un dato que ya existe en la base, verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Verifique integridad de los campos marcados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }


        public void EliminarCliente()
        {

            DialogResult result = MessageBox.Show("Desea eliminar al cliente?", "Modificacion de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Clientes.Open();

                string eliminar = "UPDATE Cliente SET Estado = @Estado WHERE Cod_Cliente = @Cod_Cliente";

                SqlCommand cmd = new SqlCommand(eliminar, Clientes);

                cmd.Parameters.AddWithValue("@Estado", 0);
                cmd.Parameters.AddWithValue("@Cod_Cliente", valorCodigoCliente);

                int filasAfectadas = cmd.ExecuteNonQuery();

                Clientes.Close();


                // Verifica si la operación fue exitosa
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Cliente eliminado exitosamente", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BEliminarCliente.Visible = false; BBorrarListado.Visible = false; BAñadirC.Visible = true; BGuardarModificacion.Enabled = false;

                    // Actualiza el grid
                    MostrarClientes();
                    BorrarFilas();
                    QuitarErrores();
                    QuitarEspacios();
                }
                else
                {
                    MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        public void RestaurarCliente()
        {
            Clientes.Open();

            string eliminar = "UPDATE Cliente SET Estado = @Estado WHERE Cod_Cliente = @Cod_Cliente";

            SqlCommand cmd = new SqlCommand(eliminar, Clientes);

            cmd.Parameters.AddWithValue("@Estado", 1);
            cmd.Parameters.AddWithValue("@Cod_Cliente", valorCodigoCliente);
            int filasAfectadas = cmd.ExecuteNonQuery();

            Clientes.Close();


            // Verifica si la operación fue exitosa
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Cliente restaurado exitosamente", "Resturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BRestaurar.Visible = false;
                BBorrarListado.Visible = false;
                BEliminarCliente.Visible = false; BBorrarListado.Visible = false; BAñadirC.Visible = true; BGuardarModificacion.Enabled = false;
                BAñadirC.Enabled = true; BGuardarModificacion.Visible = true;
                TextoDesbloqueado();
                
                MostrarClientes();
                BorrarFilas();
                QuitarErrores();
                QuitarEspacios();
            }
            else
            {
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            BAñadirC.Enabled = false;
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
                }
                else
                {
                    BRestaurar.Visible = true;
                    BEliminarCliente.Visible = false; BGuardarModificacion.Visible = false;
                    TextoBloqueado( );
                }
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
                            BBorrarListado.Visible = true;
                            TextoDesbloqueado();
                        }
                        else
                        {
                            TextoBloqueado();
                            BRestaurar.Visible = true;
                            BEliminarCliente.Visible = false;
                            BBorrarListado.Visible = true;
                            BGuardarModificacion.Visible = false;
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
            }

        }
    }
    }

