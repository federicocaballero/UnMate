using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Administrador
{
    internal class ClaseListaEmpleados
    {
        private SqlConnection Empleados;
        private TextBox TBApellido;
        private TextBox TBTelefono;
        private TextBox TBNombre;
        private TextBox TBEmail;
        private TextBox TBDni;
        private TextBox TBContraseña;
        private TextBox TBContraseña2;
        private ComboBox CBCategoria;
        private ErrorProvider errorProvider1;
        private DataGridView GridListaUsuarios;
        private Button BGuardarModificacion;
        private Button BBorrarListado;
        private Button BAñadir;
        private Button BRestaurar;
        private Button BEliminarEmpleado;
        private TextBox TBBuscar;

        public  ClaseListaEmpleados(TextBox TBApellido,TextBox TBTelefono,TextBox TBNombre,TextBox TBEmail,TextBox TBDni,TextBox TBContraseña,TextBox TBContraseña2,ComboBox CBCategoria,ErrorProvider errorProvider1, DataGridView GridListaUsuarios,Button BGuardarModificacion,
            Button BBorrarListado, Button BAñadir, Button BRestaurar, Button BEliminarEmpleado, TextBox TBBuscar)
        {
            Empleados = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.TBApellido = TBApellido;
            this.TBTelefono = TBTelefono;
            this.TBNombre = TBNombre;
            this.TBEmail = TBEmail;
            this.TBDni = TBDni;
            this.TBContraseña = TBContraseña;
            this.TBContraseña2 = TBContraseña2;
            this.CBCategoria = CBCategoria;
            this.GridListaUsuarios = GridListaUsuarios;
            this.BGuardarModificacion = BGuardarModificacion;
            this.BBorrarListado = BBorrarListado;
            this.BAñadir = BAñadir;
            this.BRestaurar = BRestaurar;
            this.BEliminarEmpleado = BEliminarEmpleado;
            this.errorProvider1 = errorProvider1;
            this.TBBuscar = TBBuscar;
        }
       

        public bool ErroresProviders()
        {
            bool CampoCorrecto = true;

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

            if (CBCategoria.SelectedItem == null)
            {
                errorProvider1.SetError(CBCategoria, "Categoria obligatoria");
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
            errorProvider1.SetError(TBContraseña, "");
            errorProvider1.SetError(TBContraseña2, "");
            errorProvider1.SetError(CBCategoria, "");
            errorProvider1.SetError(TBBuscar, "");
        }

        private bool DniExistente(string dni, int codEmpleado)
        {
            string consulta = "SELECT DNI FROM Empleado WHERE DNI = @DNI AND Cod_Empleado <> @CodEmpleado";

           Empleados.Open();

            SqlCommand cmd = new SqlCommand(consulta, Empleados);

            cmd.Parameters.AddWithValue("@DNI", dni);
            cmd.Parameters.AddWithValue("@CodEmpleado", codEmpleado);

            SqlDataReader reader = cmd.ExecuteReader();

            bool dniExiste = reader.HasRows;

            Empleados.Close();
            reader.Close();

            return dniExiste;
        }

        private bool TelefonoExistente(string telefono, int codEmpleado)
        {
            string consulta = "SELECT Telefono FROM Empleado WHERE Telefono = @Telefono AND Cod_Empleado <> @CodEmpleado";

            Empleados.Open();

            SqlCommand cmd = new SqlCommand(consulta, Empleados);

            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@CodEmpleado", codEmpleado);

            SqlDataReader reader = cmd.ExecuteReader();

            bool telefonoExiste = reader.HasRows;

            Empleados.Close();
            reader.Close();

            return telefonoExiste;
        }

        private bool EmailExistente(string email, int codEmpleado)
        {
            string consulta = "SELECT Email FROM Empleado WHERE Email = @Email AND Cod_Empleado <> @CodEmpleado";

            Empleados.Open();

            SqlCommand cmd = new SqlCommand(consulta, Empleados);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@CodEmpleado", codEmpleado);

            SqlDataReader reader = cmd.ExecuteReader();

            bool emailExiste = reader.HasRows;

            Empleados.Close();
            reader.Close();

            return emailExiste;
        }

        public void GuardarModificacion()
        {
            string EmailActual = TBEmail.Text;
            ErroresProviders();

            // verifica que los campos no esten vacios
            string email = TBEmail.Text;
            if (TBDni.Text != ""
                && TBEmail.Text != "" && TBTelefono.Text != "" && TBApellido.Text != ""
                && TBNombre.Text != "" && CBCategoria.SelectedItem != null && EsDireccionDeCorreoValida(email))
            {
                // verifica que las contraseñas sean iguales
                if (TBContraseña.Text == TBContraseña2.Text)
                {

                    // verifica que no se repitan datos
                    if ((!DniExistente(TBDni.Text, valorCodigoEmpleado)) &&
               (!TelefonoExistente(TBTelefono.Text, valorCodigoEmpleado) &&
               (!EmailExistente(TBEmail.Text, valorCodigoEmpleado) && EmailActual == TBEmail.Text)))
                    {
                        DialogResult result = MessageBox.Show("Desea modificar al empleado?", "Modificacion de empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            //caso en que la categoria cambia a cliente
                            string categoriaEmpleado = CBCategoria.SelectedItem as string;

                                using (SqlConnection conexion = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;"))
                                {
                                    conexion.Open();
                                    string nuevaCategoria = CBCategoria.SelectedItem.ToString();
                                    string consulta = "UPDATE Empleado SET  " +
                                        " ID_Perfil = (SELECT ID_perfil FROM Perfil WHERE Descripcion = @Descripcion)," +
                                        "DNI = @DNI, " + "Nombre = @Nombre, " + "Apellido = @Apellido, " +
                                        "Email = @Email, " + "Telefono = @Telefono ";

                                    string contraseña = TBContraseña.Text;
                                    string hashContraseña = BCrypt.Net.BCrypt.HashPassword(contraseña);

                                    if (!string.IsNullOrEmpty(TBContraseña.Text))
                                    {
                                        consulta += ", Contraseña = @Contraseña ";
                                    }

                                    consulta += "WHERE Cod_Empleado = @Cod_Empleado";

                                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                                    {
                                        cmd.Parameters.AddWithValue("@Nombre", TBNombre.Text);
                                        cmd.Parameters.AddWithValue("@Apellido", TBApellido.Text);
                                        cmd.Parameters.AddWithValue("@Email", TBEmail.Text);
                                        cmd.Parameters.AddWithValue("@Telefono", TBTelefono.Text);
                                        cmd.Parameters.AddWithValue("@DNI", TBDni.Text);
                                        cmd.Parameters.AddWithValue("@Cod_Empleado", valorCodigoEmpleado);
                                        cmd.Parameters.AddWithValue("@Descripcion", categoriaEmpleado);

                                        if (!string.IsNullOrEmpty(TBContraseña.Text))
                                        {
                                            cmd.Parameters.AddWithValue("@Contraseña", hashContraseña);
                                        }

                                        int filasAfectadas = cmd.ExecuteNonQuery();
                                    }
                                

                                MessageBox.Show("Modificación de empleado realizada", "Modificación de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            MostrarEmpleados();

                            BorrarFilas();BorrarListado();
                            BGuardarModificacion.Enabled = false;
                            BEliminarEmpleado.Visible = false;
                            BBorrarListado.Visible = false;
                            QuitarErrores();

                            BAñadir.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Modificación de empleado cancelada!", "Error en la modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay un dato que ya existe en la base, verificar en el lsitado", "Error en modificacion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                    {
                        MessageBox.Show("Las contraseñas no coinciden\nVerificar contraseñas ingresadas", "Error en modificacion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                
                
            }
            else
            {
                MessageBox.Show("Verifique integridad de los campos marcados", "Error en modificar empleado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        public void MostrarEmpleados()
        {
            Empleados.Open();

            string consulta = "SELECT E.Cod_Empleado,E.DNI,E.Nombre, E.Apellido,E.Email,E.Telefono,E.Estado, P.Descripcion AS Perfil " +
            "FROM Empleado E " + "INNER JOIN Perfil P on E.ID_perfil = P.ID_perfil";

            SqlDataAdapter lista = new SqlDataAdapter(consulta, Empleados);
            DataTable dt = new DataTable();
            lista.Fill(dt);
            GridListaUsuarios.DataSource = dt;

            Empleados.Close();

        }

        private int valorCodigoEmpleado;
        public void ConocerEmpleado()
        {
            TBDni.Text = GridListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            TBNombre.Text = GridListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            TBApellido.Text = GridListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            TBEmail.Text = GridListaUsuarios.CurrentRow.Cells[4].Value.ToString();
            TBTelefono.Text = GridListaUsuarios.CurrentRow.Cells[5].Value.ToString();
          
            CBCategoria.Text = GridListaUsuarios.CurrentRow.Cells[7].Value.ToString();
           
            BGuardarModificacion.Enabled = true; BEliminarEmpleado.Enabled = true;
            QuitarErrores();
            BAñadir.Enabled = false; BBorrarListado.Visible = true;
            TextoDesbloqueado();


            if (GridListaUsuarios.CurrentRow != null)
            {
                DataGridViewRow selectedRow = GridListaUsuarios.CurrentRow;
                int valorEstado = Convert.ToInt32(selectedRow.Cells["Estado"].Value);

                valorCodigoEmpleado = Convert.ToInt32(selectedRow.Cells["Cod_Empleado"].Value);

                if (valorEstado != 0)
                {
                    BEliminarEmpleado.Visible = true;
                    BRestaurar.Visible = false;
                    TextoDesbloqueado();
                }
                else
                {
                    TextoBloqueado();
                    BRestaurar.Visible = true;
                    BEliminarEmpleado.Visible = false;
                }
            }
        }


        public void TextoDesbloqueado()
        {
            TBNombre.ReadOnly = false;
            TBApellido.ReadOnly = false;
            TBTelefono.ReadOnly = false;
            TBEmail.ReadOnly = false;
            TBDni.ReadOnly = false;
            TBContraseña.ReadOnly = false;
            TBContraseña2.ReadOnly = false;
            CBCategoria.Enabled = true;
        }

        public void TextoBloqueado()
        {
            TBNombre.ReadOnly = true;
            TBApellido.ReadOnly = true;
            TBTelefono.ReadOnly = true;
            TBEmail.ReadOnly = true;
            TBDni.ReadOnly = true;
            TBContraseña.ReadOnly = true;
            TBContraseña2.ReadOnly = true;
            CBCategoria.Enabled = false;
        }

        public void BorrarFilas()
        {
            TBTelefono.Clear();
            TBEmail.Clear();
            TBContraseña.Clear();
            TBDni.Clear();
            TBApellido.Clear();
            TBNombre.Clear();
            CBCategoria.SelectedItem = null;
            TBContraseña2.Clear();
            BEliminarEmpleado.Visible = false;

        }

        public void RestaurarEmpleado()
        {
            Empleados.Open();

            string restaurar = "UPDATE Empleado SET Estado = @Estado WHERE Cod_Empleado = @Cod_Empleado";

            SqlCommand cmd = new SqlCommand(restaurar, Empleados);

            cmd.Parameters.AddWithValue("@Estado", 1);
            cmd.Parameters.AddWithValue("@Cod_Empleado", valorCodigoEmpleado);

            int filasAfectadas = cmd.ExecuteNonQuery();

            Empleados.Close();


             MessageBox.Show("Empleado restaurado exitosamente", "Restauracion de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BEliminarEmpleado.Visible = false; BorrarFilas(); BBorrarListado.Visible = false;
                QuitarErrores(); BAñadir.Visible = true; 

                MostrarEmpleados();
                BAñadir.Enabled = true;
                BRestaurar.Visible = false; BGuardarModificacion.Enabled = false; BGuardarModificacion.Visible = true;
                BorrarFilas(); ; TextoDesbloqueado();

        }

        public void EliminarEmpleado()
        {

            DialogResult result = MessageBox.Show("Desea eliminar al empleado?", "Eliminación de produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Empleados.Open();

            string eliminar = "UPDATE Empleado SET Estado = @Estado WHERE Cod_Empleado = @Cod_Empleado";

            SqlCommand cmd = new SqlCommand(eliminar, Empleados);

            cmd.Parameters.AddWithValue("@Estado", 0);
            cmd.Parameters.AddWithValue("@Cod_Empleado", valorCodigoEmpleado);

            int filasAfectadas = cmd.ExecuteNonQuery();

            Empleados.Close();


            
                MessageBox.Show("Empleado eliminado exitosamente", "Eliminación de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BEliminarEmpleado.Visible = false; BorrarFilas(); BBorrarListado.Visible = false;
                QuitarErrores();
                
                // Actualiza el grid
                MostrarEmpleados();TextoDesbloqueado();
                BAñadir.Enabled = true; BAñadir.Visible = true;
                BEliminarEmpleado.Visible = false;
                BGuardarModificacion.Enabled = false;
                BorrarFilas();

            }
            else
            {

                    MessageBox.Show("Eliminacion de empleado rechazada", "Error en eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Hand); 
            }

          
        }

        public void AñadirEmpleado()
        {
            string DniActual = TBDni.Text;
            string TelefonoActual =TBTelefono.Text;
            string EmailActual = TBEmail.Text;
            
            if(TBContraseña.Text == "")
            {
                errorProvider1.SetError(TBContraseña, "Debe registrar una contraseña");
            }
            else
            {
                errorProvider1.SetError(TBContraseña, "");
            }

            if (TBContraseña2.Text == "")
            {
                errorProvider1.SetError(TBContraseña2, "Debe registrar una contraseña");
            }
            else
            {
                errorProvider1.SetError(TBContraseña2, "");
            }

            ErroresProviders();

            if (CBCategoria.Text == "Cliente")
            {
                MessageBox.Show("Categoria no disponible para el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBCategoria.SelectedItem = null;
            }

            string email = TBEmail.Text;

            if (TBContraseña.Text != "" && TBDni.Text != ""
              && TBEmail.Text != "" && TBApellido.Text != ""
              && TBNombre.Text != "" && CBCategoria.SelectedItem != null && EsDireccionDeCorreoValida(email))
            {

                if (TBContraseña.Text == TBContraseña2.Text)
                {

                    if ((!DniExistente(TBDni.Text, valorCodigoEmpleado))  &&
                 (!TelefonoExistente(TBTelefono.Text, valorCodigoEmpleado) &&
                 (!EmailExistente(TBEmail.Text, valorCodigoEmpleado) && EmailActual == TBEmail.Text)))
                    {
                        DialogResult result = MessageBox.Show("Estas a punto de agregar un Empleado ", "Agregar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Empleado agregado con exito", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Abrimos conexion
                            Empleados.Open();
                            string nuevaCategoria = CBCategoria.SelectedItem.ToString();


                            string agregar = "INSERT INTO Empleado (DNI, Nombre, Apellido, Email, Contraseña, Estado, Telefono, ID_perfil) " +
                                    "SELECT @DNI, @Nombre, @Apellido, @Email, @Contraseña, 1, @Telefono, CA.ID_perfil " +
                                    "FROM Perfil CA " +
                                    "WHERE CA.Descripcion = @Categoria";

                            SqlCommand cmd = new SqlCommand(agregar, Empleados);

                            string selectedIvaDescription = CBCategoria.SelectedItem as string;

                            string contraseña = TBContraseña.Text;
                            string hashContraseña = BCrypt.Net.BCrypt.HashPassword(contraseña);

                            cmd.Parameters.AddWithValue("@Nombre", TBNombre.Text);
                            cmd.Parameters.AddWithValue("@Apellido", TBApellido.Text);
                            cmd.Parameters.AddWithValue("@Email", TBEmail.Text);
                            cmd.Parameters.AddWithValue("@Contraseña", hashContraseña);
                            cmd.Parameters.AddWithValue("@Telefono", TBTelefono.Text);
                            cmd.Parameters.AddWithValue("@Categoria", selectedIvaDescription);
                            cmd.Parameters.AddWithValue("@DNI", TBDni.Text);
                          

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            Empleados.Close();
                            BEliminarEmpleado.Visible = false;
                            BGuardarModificacion.Enabled = false;
                            MostrarEmpleados(); errorProvider1.SetError(TBContraseña2, ""); errorProvider1.SetError(TBContraseña, "");
                            BorrarFilas();
                            QuitarErrores();

                        }
                        else
                        {
                            MessageBox.Show("Inserción de empelado cancelada!", "Error en insercion de empleado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay un dato que ya existe en la base, verificar en la lista", "Error en insercion de empleado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden\nVerificar contraseñas", "Error en insercion de empleado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Verifique integridad de los campos marcados", "Error en insercion de empleado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders(); 
            }
        }

        public void BorrarListado()
        {
            BBorrarListado.Visible = false;
            BGuardarModificacion.Enabled = false;
            BAñadir.Enabled = true; BRestaurar.Visible = false; ; BEliminarEmpleado.Visible = false;
            TextoDesbloqueado(); BAñadir.Visible = true;

            BGuardarModificacion.Visible = true;
            QuitarErrores();
            BorrarFilas(); errorProvider1.SetError(TBEmail, "");
        }

        public void BuscarEmpleado()
        {
            BRestaurar.Visible = false;

            if (string.IsNullOrWhiteSpace(TBBuscar.Text))
            {
                errorProvider1.SetError(TBBuscar, "Debe ingresar un DNI");
                return;
            }

            string textoBuscado = TBBuscar.Text.Trim();
            bool empleadoEncontrado = false; 

            // busca la fila en el DataGridView
            foreach (DataGridViewRow fila in GridListaUsuarios.Rows)
            {
                if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == textoBuscado)
                {
                    GridListaUsuarios.CurrentCell = fila.Cells[1];

                    // actualiza los campos con los datos de la fila seleccionada
                    TBNombre.Text = fila.Cells[2].Value.ToString();
                    TBApellido.Text = fila.Cells[3].Value.ToString();
                    TBEmail.Text = fila.Cells[4].Value.ToString();
                    TBDni.Text = fila.Cells[1].Value.ToString();
                    TBTelefono.Text = fila.Cells[5].Value.ToString();
                    CBCategoria.Text = fila.Cells[7].Value.ToString();
                    errorProvider1.SetError(TBBuscar, "");
                    if (GridListaUsuarios.CurrentRow != null)
                    {
                        DataGridViewRow selectedRow = GridListaUsuarios.CurrentRow;
                        int valorEstado = Convert.ToInt32(selectedRow.Cells["Estado"].Value);

                        valorCodigoEmpleado = Convert.ToInt32(selectedRow.Cells["Cod_Empleado"].Value);

                        if (valorEstado != 0)
                        {
                            BAñadir.Visible = false;
                            BEliminarEmpleado.Visible = true;
                            BRestaurar.Visible = false;
                            BGuardarModificacion.Enabled = true;
                            BBorrarListado.Visible = true;
                            TextoDesbloqueado();
                        }
                        else
                        {
                            TextoBloqueado();
                            BRestaurar.Visible = true;
                            BEliminarEmpleado.Visible = false;
                            BAñadir.Visible = false;
                            BBorrarListado.Visible = true;
                            BAñadir.Visible = false;
                        }
                    }
                    QuitarErrores();
                    MessageBox.Show("Empleado encontrado en la base", "Búsqueda de empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBBuscar.Clear();
                    empleadoEncontrado = true; // Se encontró al empleado
                    break;
                }
            }

            // mostrar mensaje si no se encontró al empleado
            if (!empleadoEncontrado)
            {
                MessageBox.Show("No se encontró al empleado en la base", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscar.Clear();
            }
        }


    }

}
