using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Supervisor
{
    internal class ClaseProveedores
    {

        private SqlConnection Proveedores;
        private TextBox TBEmail;
        private TextBox TBDireccion;
        private TextBox TBCuit;
        private TextBox TBTelefono;
        private ComboBox CBIva;
        private TextBox TBNombre;
        private ErrorProvider errorProvider1;
        private DataGridView GridProveedores;
        private Button BBorrarListado;
        private Button BAñadir;
        private TextBox TBBuscar;
        private Button BEliminar;
        private Button BRestaurar;


        public ClaseProveedores(TextBox TBEmail,TextBox TBDireccion, TextBox TBCuit, TextBox TBTelefono, ComboBox CBIva, TextBox TBNombre, ErrorProvider errorProvider1, DataGridView GridProveedores,
            Button BBorrarListado, Button BAñadir, Button BEliminar, Button BResturar, TextBox TBBuscar, Button BRestaurar)
        {
            Proveedores = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.TBEmail = TBEmail;
               this.TBDireccion = TBDireccion;
                this.TBCuit = TBCuit;
               this.TBTelefono = TBTelefono;
               this.CBIva   = CBIva;
               this.TBNombre = TBNombre;
               this.errorProvider1 = errorProvider1;
               this.GridProveedores = GridProveedores;
               this.BBorrarListado = BBorrarListado;
                this.BAñadir = BAñadir;
                this.BEliminar = BEliminar;
                this.BRestaurar = BRestaurar;
                this.TBBuscar = TBBuscar;
        }

        private bool DniExistente(string CUIT, int codProveedor)
        {
            string consulta = "SELECT CUIT FROM Proveedor WHERE CUIT = @CUIT AND Cod_Proveedor <> @codProveedor";

           Proveedores.Open();

            SqlCommand cmd = new SqlCommand(consulta, Proveedores);

            cmd.Parameters.AddWithValue("@CUIT", CUIT);
            cmd.Parameters.AddWithValue("@codProveedor", codProveedor);

            SqlDataReader reader = cmd.ExecuteReader();

            bool dniExiste = reader.HasRows;

            Proveedores.Close();
            reader.Close();

            return dniExiste;
        }

        private bool TelefonoExistente(string telefono, int codProveedor)
        {
            string consulta = "SELECT Telefono FROM Proveedor WHERE Telefono = @Telefono AND Cod_Proveedor <> @codProveedor";

            Proveedores.Open();

            SqlCommand cmd = new SqlCommand(consulta, Proveedores);

            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@codProveedor", codProveedor);

            SqlDataReader reader = cmd.ExecuteReader();

            bool telefonoExiste = reader.HasRows;

            Proveedores.Close();
            reader.Close();

            return telefonoExiste;
        }

        private bool EmailExistente(string email, int codProveedor)
        {
            string consulta = "SELECT Email FROM Proveedor WHERE Email = @Email AND Cod_Proveedor <> @codProveedor";

            Proveedores.Open();

            SqlCommand cmd = new SqlCommand(consulta, Proveedores);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@codProveedor", codProveedor);

            SqlDataReader reader = cmd.ExecuteReader();

            bool emailExiste = reader.HasRows;

            Proveedores.Close();
            reader.Close();

            return emailExiste;
        }



        public void AñadirProveedor()
        {
            string DniActual = TBCuit.Text;
            string TelefonoActual = TBTelefono.Text;
            string EmailActual = TBEmail.Text;

            QuitarErrores();
            string direccionCorreo = TBEmail.Text;

            if (!String.IsNullOrWhiteSpace(TBNombre.Text) && !String.IsNullOrWhiteSpace(TBDireccion.Text) && TBCuit.Text != "" && TBTelefono.Text != "" && TBEmail.Text != "" &&
                 CBIva.SelectedItem != null&& ErrorProviders() && (EsDireccionDeCorreoValida(direccionCorreo)))
            {

                if (!DniExistente(TBCuit.Text, valorCodigoProveedor) &&
                 !TelefonoExistente(TBTelefono.Text, valorCodigoProveedor) &&
                 !EmailExistente(TBEmail.Text, valorCodigoProveedor))
                {
                    DialogResult result = MessageBox.Show("Estas a punto de agregar un proveedor ", "Agregar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //abrimos conexion
                        Proveedores.Open();

                        // Consulta SQL con parámetros (trayendo la descripcion del iva que se encuentra en la tabla TipoIva)
                        string query = "INSERT INTO Proveedor (CUIT, Nombre, Direccion, Email, Telefono,IVA, Estado) " +
                                         "SELECT @CUIT, @Nombre, @Direccion, @Email, @Telefono, TI.IVA, 1 " +
                                         "FROM TipoIva TI " +
                                         "WHERE TI.Descripcion = @Descripcion";

                  
                        SqlCommand cmd = new SqlCommand(query, Proveedores);

                        // Obtener el valor seleccionado en el ComboBox
                        string selectedIvaDescription = CBIva.SelectedItem as string;

                        cmd.Parameters.AddWithValue("@CUIT", TBCuit.Text);
                        cmd.Parameters.AddWithValue("@Nombre", TBNombre.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TBDireccion.Text);
                        cmd.Parameters.AddWithValue("@Email", TBEmail.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TBTelefono.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", selectedIvaDescription);
                        
                       
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        Proveedores.Close();

                        MostrarProveedores();

                        MessageBox.Show("Proveedor agregado a la lista", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BorrarTodo();
                        quitarEspacios(); QuitarErrores();



                    }
                    else
                    {
                        MessageBox.Show("Inserción cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("Hay un dato que ya existe en la base (DNI-Telefono-Email), verificar", "Error en añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            else
            {
                MessageBox.Show("Verifique integridad de los campos marcados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErrorProviders();
            }
        }

        public void BorrarTodo()
        {
            TBNombre.Clear();
            TBDireccion.Clear();
            TBCuit.Clear();
            TBTelefono.Clear();
            TBEmail.Clear();
            CBIva.SelectedItem = null;

        }

        public void BloquearDatos()
        {
            TBNombre.ReadOnly = true;
            TBEmail.ReadOnly = true;
            TBDireccion.ReadOnly = true;
            TBCuit.ReadOnly = true;
            TBTelefono.ReadOnly = true;
            CBIva.Enabled = false;
        }

        public void DesbloquearDatos()
        {
            TBNombre.ReadOnly = false;
            TBEmail.ReadOnly = false;
            TBDireccion.ReadOnly = false;
            TBCuit.ReadOnly = false;
            TBTelefono.ReadOnly = false;
            CBIva.Enabled = true;
            CBIva.Enabled = true;
        }

        public bool ErrorProviders()
        {
            bool proveedorLista = true;

            if (TBCuit.Text == "")
            {
                errorProvider1.SetError(TBCuit, "CUIT necesario");
                proveedorLista = false;
            }

            if (string.IsNullOrWhiteSpace(TBDireccion.Text))
            {
                errorProvider1.SetError(TBDireccion, "Direccion necesaria sin espacios en blanco");
                proveedorLista = false;
            }

            if (string.IsNullOrWhiteSpace(TBNombre.Text))
            {
                errorProvider1.SetError(TBNombre, "Nombre necesario sin espacios en blanco");
                proveedorLista = false;
            }

            if (TBTelefono.Text == "")
            {
                errorProvider1.SetError(TBTelefono, "Telefono necesario");
                proveedorLista = false;
            }

            if (EsDireccionDeCorreoValida(TBEmail.Text) == false)
            {
                errorProvider1.SetError(TBEmail, "Formato de correo incorrecto");
                proveedorLista = false;
            }

            if (CBIva.SelectedItem == null)
            {
                errorProvider1.SetError(CBIva, "Campo necesario");
                proveedorLista = false;
            }

            return proveedorLista;
        }

        public void QuitarErrores()
        {
            errorProvider1.SetError(TBNombre, "");
            errorProvider1.SetError(CBIva, "");
            errorProvider1.SetError(TBTelefono, "");
            errorProvider1.SetError(TBEmail, "");
            errorProvider1.SetError(TBCuit, "");
            errorProvider1.SetError(TBDireccion, "");
            errorProvider1.SetError(TBBuscar, "");
        }

        public void quitarEspacios()
        {
            foreach (DataGridViewRow row in GridProveedores.Rows)
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

        public void MostrarProveedores()
        {
  
            Proveedores.Open();

            string consulta = "SELECT P.Cod_Proveedor,P.CUIT,P.Nombre,P.Direccion,P.Email,P.Telefono,P.Estado, I.Descripcion AS TipoIva " +
              "from Proveedor P " + "INNER JOIN TipoIva I ON P.IVA = I.IVA ";
            SqlDataAdapter lista = new SqlDataAdapter(consulta, Proveedores);
            DataTable dt = new DataTable();
            lista.Fill(dt);
            GridProveedores.DataSource = dt;
            quitarEspacios();
           
            Proveedores.Close();
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


        public void EliminarProveedor()
        {
            QuitarErrores();
            if (!String.IsNullOrWhiteSpace(TBNombre.Text) && !String.IsNullOrWhiteSpace(TBDireccion.Text) && TBCuit.Text != "" && TBTelefono.Text != "" && TBEmail.Text != "" &&
                 CBIva.SelectedItem != null &&  ErrorProviders())
            {
                DialogResult result = MessageBox.Show("Al eliminar el proveedor los productos que otorgaba necesitaran modificaciones, a no ser que el proveedor sea restaurado\nSeguro que desea eliminar al proveedor?", "Eliminación de proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    Proveedores.Open();

                    string eliminar = "UPDATE Proveedor SET Estado = @Estado WHERE Cod_Proveedor = @Cod_Proveedor";

                    
                    SqlCommand cmd = new SqlCommand(eliminar, Proveedores);


                    cmd.Parameters.AddWithValue("@Estado", 0);
                    cmd.Parameters.AddWithValue("@Cod_Proveedor", valorCodigoProveedor);

              
                    int filasAfectadas = cmd.ExecuteNonQuery();

                  
                    Proveedores.Close();


                    // Verifica si la operación fue exitosa
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Proveedor eliminado exitosamente", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BAñadir.Visible = true;
                        BEliminar.Visible = false;
                        // Actualiza el grid
                        MostrarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    BorrarTodo();
                    DesbloquearDatos(); 
                    BBorrarListado.Visible = false;
                    BAñadir.Enabled = true;
                    BorrarTodo();
                    QuitarErrores();

                }
                else
                {
                    MessageBox.Show("Eliminación  cancelada!", "Error de eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Error en eliminar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErrorProviders();
            }
        }

        private int valorCodigoProveedor;
        public void DobleClick()
        {
            BloquearDatos();
            TBCuit.Text = GridProveedores.CurrentRow.Cells[1].Value.ToString();
            TBNombre.Text = GridProveedores.CurrentRow.Cells[2].Value.ToString();
            TBDireccion.Text = GridProveedores.CurrentRow.Cells[3].Value.ToString();
            TBTelefono.Text = GridProveedores.CurrentRow.Cells[5].Value.ToString();
            TBEmail.Text = GridProveedores.CurrentRow.Cells[4].Value.ToString();
            CBIva.Text = GridProveedores.CurrentRow.Cells[7].Value.ToString();
            CBIva.Enabled = false;
            BEliminar.Enabled = true;
            BBorrarListado.Visible = true;
            QuitarErrores(); BAñadir.Visible = false;
            BAñadir.Enabled = false;

            if (GridProveedores.CurrentRow != null)
            {
                DataGridViewRow selectedRow = (GridProveedores.CurrentRow);

                // acceder a los valores de las celdas en función de los nombres de las columnas
                int valorEstado = Convert.ToInt32(selectedRow.Cells["Estado"].Value);

                valorCodigoProveedor = Convert.ToInt32(selectedRow.Cells["Cod_Proveedor"].Value);

                if (valorEstado != 0)
                {
                    BEliminar.Visible = true;
                    BRestaurar.Visible = false;
                    BloquearDatos();
                }
                else
                {
                    BloquearDatos();
                    BRestaurar.Visible = true;
                    BEliminar.Visible = false;
                }
            }
        }

        public void RestaurarProveedor()
        {
            QuitarErrores();
            if (!String.IsNullOrWhiteSpace(TBNombre.Text) && !String.IsNullOrWhiteSpace(TBDireccion.Text) && TBCuit.Text != "" && TBTelefono.Text != "" && TBEmail.Text != "" &&
                 CBIva.SelectedItem != null && ErrorProviders())
            {
                
          
                    Proveedores.Open();

                    string eliminar = "UPDATE Proveedor SET Estado = @Estado WHERE Cod_Proveedor = @Cod_Proveedor";

                    SqlCommand cmd = new SqlCommand(eliminar, Proveedores);

                    cmd.Parameters.AddWithValue("@Estado", 1);
                    cmd.Parameters.AddWithValue("@Cod_Proveedor", valorCodigoProveedor);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    Proveedores.Close();


                    // verifica si la operación fue exitosa
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Proveedor restaurado exitosamente", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BAñadir.Visible = true; BRestaurar.Visible = false;

                        // actualiza el grid
                        MostrarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    BorrarTodo();
                    DesbloquearDatos();
                    BBorrarListado.Visible = false;
                    BAñadir.Enabled = true;
                    QuitarErrores();

                } else
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Error en eliminar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErrorProviders();
            }
        }

        public void BorrarListado()
        {
            BorrarTodo();
            BEliminar.Visible = false;
            BBorrarListado.Visible = false;
            DesbloquearDatos();
            BAñadir.Enabled = true; BRestaurar.Visible = false;
            TBBuscar.Clear();
            QuitarErrores();
            BAñadir.Visible = true;
            BEliminar.Enabled = true;
        }


        public void BuscarProveedor()
        {
            BRestaurar.Visible = false;
            if (TBBuscar.Text == "")
            {
                errorProvider1.SetError(TBBuscar, "Debe ingresar un CUIT");
                return;
            }

            string textoBuscado = TBBuscar.Text;
            bool proveedorEncontrador = false;

            foreach (DataGridViewRow fila in GridProveedores.Rows)
            {
                if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == textoBuscado)
                {
                    GridProveedores.CurrentCell = fila.Cells[1];
                    
                    // actualiza los campos con los datos de la fila seleccionada
                    TBCuit.Text = fila.Cells[1].Value.ToString();
                    TBNombre.Text = fila.Cells[2].Value.ToString();
                    TBDireccion.Text = fila.Cells[3].Value.ToString();
                    TBEmail.Text = fila.Cells[4].Value.ToString();
                    TBTelefono.Text = fila.Cells[5].Value.ToString();
                    CBIva.Text = fila.Cells[7].Value.ToString();
                    if (GridProveedores.CurrentRow != null)
                    {
                        DataGridViewRow selectedRow = GridProveedores.CurrentRow;
                        int valorEstado = Convert.ToInt32(selectedRow.Cells["Estado"].Value);

                        valorCodigoProveedor = Convert.ToInt32(selectedRow.Cells["Cod_Proveedor"].Value);

                        if (valorEstado != 0)
                        {
                            BEliminar.Visible = true;
                            BRestaurar.Visible = false;
                            BBorrarListado.Visible = true;
                            BloquearDatos();
                        }
                        else
                        {
                            BRestaurar.Visible = true;
                            BEliminar.Visible = false;
                            BBorrarListado.Visible = true;
                            BloquearDatos();

                        }
                    }
                    QuitarErrores();
                    MessageBox.Show("Proveedor encontrado en la base", "Búsqueda de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBBuscar.Clear();
                    proveedorEncontrador = true; // Se encontró al proveedor
                    break;
                }
            }
            // mostrar mensaje si no se encontró al proveedor
            if (!proveedorEncontrador)
            {
                MessageBox.Show("No se encontró al proveedor en la base", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 TBBuscar.Clear();
            }
        }

    }
}
