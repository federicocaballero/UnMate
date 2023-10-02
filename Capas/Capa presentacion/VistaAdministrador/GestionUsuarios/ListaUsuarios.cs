using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionUsuarios
{
    public partial class ListaUsuarios : Form
    {

        public ListaUsuarios()
        {
            InitializeComponent();

            BLimpiarFiltros.Visible = false;
            BGuardarModificacion.Enabled = false;
            BEliminarProducto.Enabled = false;
            BBorrarListado.Visible = false;
            //ajustar imagen al picture box
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void TBBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BorrarFilas()
        {
            TBUsuario.Clear();
            TBTelefono.Clear();
            TBEmail.Clear();
            TBContraseña.Clear();
            TBDni.Clear();
            TBApellido.Clear();
            TBNombre.Clear();
            pictureBox1.Image = null;
            CBCategoria.SelectedItem = null;
            TBContraseña2.Clear();
           
        }

        private void BCamcelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TBUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextoBloqueado()
        {
            TBUsuario.ReadOnly = true;
            TBNombre.ReadOnly = true;
            TBApellido.ReadOnly = true;
            TBTelefono.ReadOnly = true;
            TBEmail.ReadOnly = true;
            TBDni.ReadOnly = true;
            TBContraseña.ReadOnly = true;
            CBCategoria.SelectedItem = null;
        }
        private void TextoDesbloqueado()
        {
            TBUsuario.ReadOnly = false;
            TBNombre.ReadOnly = false;
            TBApellido.ReadOnly = false;
            TBTelefono.ReadOnly = false;
            TBEmail.ReadOnly = false;
            TBDni.ReadOnly = false;
            TBContraseña.ReadOnly = false;

        }

        private void TBContraseña2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //TODO LO QUE SIGUE ES PARA LOS ERRORES PROVIDERS
        //TODO LO QUE SIGUE ES PARA LOS ERRORES PROVIDERS
        //TODO LO QUE SIGUE ES PARA LOS ERRORES PROVIDERS

        //LA SIGUIENTE FUNCION PUEDE DAÑAR LOS OJOS
        private bool ErroresProviders()
        {
            bool CampoCorrecto = true;

            if (TBUsuario.Text == "")
            {
                errorProvider1.SetError(TBUsuario, "Usuario obligatorio");
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

            if (TBEmail.Text == "")
            {
                errorProvider1.SetError(TBEmail, "Email obligatorio");
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


            if (TBContraseña.Text == "")
            {
                errorProvider1.SetError(TBContraseña, "Contraseña obligatoria");
                CampoCorrecto = false;
            }

            if (TBContraseña2.Text == "")
            {
                errorProvider1.SetError(TBContraseña2, "Contraseña obligatoria");
                CampoCorrecto = false;
            }


            if (pictureBox1.Image == null)
            {
                errorProvider1.SetError(pictureBox1, "Imagen obligatoria");
                CampoCorrecto = false;
            }

            if (CBCategoria.SelectedItem == null)
            {
                errorProvider1.SetError(CBCategoria, "Categoria obligatoria");
                CampoCorrecto = false;
            }

            return CampoCorrecto;

        }

        //quitar los errores providers
        private void QuitarErrores()
        {
            errorProvider1.SetError(TBUsuario, "");
            errorProvider1.SetError(TBNombre, "");
            errorProvider1.SetError(TBApellido, "");
            errorProvider1.SetError(TBTelefono, "");
            errorProvider1.SetError(TBEmail, "");
            errorProvider1.SetError(TBDni, "");
            errorProvider1.SetError(TBContraseña, "");
            errorProvider1.SetError(TBContraseña2, "");
            errorProvider1.SetError(pictureBox1, "");
            errorProvider1.SetError(CBCategoria, "");
        }

        private void BBorrarListado_Click_1(object sender, EventArgs e)
        {
            BorrarFilas();
            BBorrarListado.Visible = false;
            BGuardarModificacion.Enabled = false;
            BEliminarProducto.Enabled = false;
            BAñadir.Enabled = true;
            QuitarErrores();
        }

        private void BGuardarModificacion_Click(object sender, EventArgs e)
        {
            QuitarErrores();

            if (TBUsuario.Text != "" && TBContraseña.Text != "" & TBDni.Text != ""
               && TBEmail.Text != "" && TBTelefono.Text != "" && TBApellido.Text != ""
               && TBNombre.Text != "" && CBCategoria.SelectedItem != null && pictureBox1.Image != null)
            {

                if (TBContraseña.Text == TBContraseña2.Text)
                {
                    DialogResult result = MessageBox.Show("Desea modificar al usuario?", "Modificacion de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        MessageBox.Show("Modificación de usuario realizada", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridListaUsuarios.CurrentRow.Cells[0].Value = TBUsuario.Text;
                        GridListaUsuarios.CurrentRow.Cells[1].Value = TBNombre.Text;
                        GridListaUsuarios.CurrentRow.Cells[2].Value = TBApellido.Text;
                        GridListaUsuarios.CurrentRow.Cells[3].Value = TBEmail.Text;
                        GridListaUsuarios.CurrentRow.Cells[4].Value = TBDni.Text;
                        GridListaUsuarios.CurrentRow.Cells[5].Value = TBTelefono.Text;
                        GridListaUsuarios.CurrentRow.Cells[6].Value = TBContraseña.Text;
                        GridListaUsuarios.CurrentRow.Cells[7].Value = pictureBox1.Image;
                        System.Drawing.Image imagen = GridListaUsuarios.CurrentRow.Cells[7].Value as System.Drawing.Image;
                        pictureBox1.Image = imagen;
                        GridListaUsuarios.CurrentRow.Cells[8].Value = CBCategoria.Text;

                        BorrarFilas(); BLimpiarFiltros.PerformClick(); BLimpiarFiltros.Visible = false;
                        BGuardarModificacion.Enabled = false;
                        BEliminarProducto.Enabled = false;
                        BBorrarListado.Visible = false;
                        QuitarErrores();
                        BAñadir.Enabled = true;


                    }
                    else
                    {
                        MessageBox.Show("Modificación de usuario cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden\nVerificar contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            else
            {
                MessageBox.Show("Existe uno o varios campos incompletos\nVerifique campos marcados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if(TBBuscar.Text == "")
            {                errorProvider1.SetError(TBBuscar, "Debe ingresar un dni");
            }

            string contenidoDeseado = TBBuscar.Text; // Contenido que deseas buscar en la primera columna
            bool usuarioEncontrado = false;

            //verifica que no este vacio
            if (TBBuscar.Text != "")
            {
                BLimpiarFiltros.Visible = true;

                // Recorre todas las filas del GridListaUsuarios
                foreach (DataGridViewRow fila in GridListaUsuarios.Rows)
                {
                    // Verifica el contenido de la celda en la primera columna (índice 4)
                    if (string.IsNullOrEmpty(contenidoDeseado) ||
                        (fila.Cells[4].Value != null && fila.Cells[4].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase)))
                    {
                        // Si coincide con el texto de búsqueda o no hay texto de búsqueda, muestra la fila completa
                        fila.Visible = true;
                        usuarioEncontrado = true;
                        errorProvider1.SetError(TBBuscar, "");
                    }
                    else
                    {

                        // Si no coincide, oculta la fila completa
                        fila.Visible = false;

                    }
                }
                if (!usuarioEncontrado)
                {
                    MessageBox.Show("Usuario no encontrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(TBBuscar, "");
                    TBBuscar.Clear();
                    BLimpiarFiltros.Visible = false;
                    //mostrar todas las filas
                    foreach (DataGridViewRow fila in GridListaUsuarios.Rows)
                    {
                        fila.Visible = true;

                    }
                }

            }
        }

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            QuitarErrores();

            if (TBUsuario.Text != "" && TBContraseña.Text != "" && TBDni.Text != ""
              && TBEmail.Text != "" && LTelefono.Text != "" && TBApellido.Text != ""
              && TBNombre.Text != "")
            {

                DialogResult result = MessageBox.Show("Desea eliminar el usuario?", "Eliminación de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    GridListaUsuarios.Rows.Remove(GridListaUsuarios.CurrentRow);
                    MessageBox.Show("Eliminación de usuario realizada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BorrarFilas();
                    BLimpiarFiltros.PerformClick(); BLimpiarFiltros.Visible = false;
                    BGuardarModificacion.Enabled = false;
                    BEliminarProducto.Enabled = false;
                    QuitarErrores();
                    BAñadir.Enabled = true;
                    BBorrarListado.Visible = false;
                }
                else
                {
                    MessageBox.Show("Eliminación de usuario cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Existe uno o varios campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void GridListaUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            TBUsuario.Text = GridListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            TBNombre.Text = GridListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            TBApellido.Text = GridListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            TBEmail.Text = GridListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            TBDni.Text = GridListaUsuarios.CurrentRow.Cells[4].Value.ToString();
            TBTelefono.Text = GridListaUsuarios.CurrentRow.Cells[5].Value.ToString();
            TBContraseña.Text = GridListaUsuarios.CurrentRow.Cells[6].Value.ToString();
            TBContraseña2.Text = GridListaUsuarios.CurrentRow.Cells[6].Value.ToString();
            System.Drawing.Image image = GridListaUsuarios.CurrentRow.Cells[7].Value as System.Drawing.Image;
            pictureBox1.Image = image;
            CBCategoria.Text = GridListaUsuarios.CurrentRow.Cells[8].Value.ToString();
            TextoDesbloqueado();
            BGuardarModificacion.Enabled = true;
            BEliminarProducto.Enabled = true;
            QuitarErrores();
            BAñadir.Enabled = false;
            BBorrarListado.Visible = true;
        }

        private void BLimpiarFiltros_Click(object sender, EventArgs e)
        {
            BLimpiarFiltros.Visible = false;
            if (TBBuscar.Text != null)
            {

                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridListaUsuarios.Rows)
                {
                    fila.Visible = true;
                    TBBuscar.Clear();
                    TBBuscar.Enabled = true;
                }
            }
        }

        private void BAñadir_Click(object sender, EventArgs e)
        {
            QuitarErrores();

            if (CBCategoria.Text == "Cliente")
            {
                MessageBox.Show("Categoria no disponible para el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBCategoria.SelectedItem = null;
            }

            if (TBUsuario.Text != "" && TBContraseña.Text != "" && TBDni.Text != ""
              && TBEmail.Text != "" && LTelefono.Text != "" && TBApellido.Text != "" && pictureBox1 != null && pictureBox1.Image != null
              && TBNombre.Text != "" && CBCategoria.SelectedItem != null)
            {

                if (TBContraseña.Text == TBContraseña2.Text)
                {
                    Image imagen = pictureBox1.Image;
                    DialogResult result = MessageBox.Show("Estas a punto de agregar al usuario: " + TBUsuario.Text, "Agregar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Usuario agregado con exito", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridListaUsuarios.Rows.Add(TBUsuario.Text, TBNombre.Text, TBApellido.Text, TBEmail.Text, TBDni.Text, TBTelefono.Text, TBContraseña.Text, pictureBox1.Image, CBCategoria.Text);
                        BorrarFilas();
                        QuitarErrores();
                    }
                    else
                    {
                        MessageBox.Show("Inserción cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden\nVerificar contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos\nVerifique campos marcados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog ofdSleccionarFoto = new OpenFileDialog();
                ofdSleccionarFoto.Filter = "Imagenes|*.jpg; *.png; *.jpeg; *.gif";
                ofdSleccionarFoto.Title = "Seleccionar Foto de Producto";


                if (ofdSleccionarFoto.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackgroundImage = null;
                    pictureBox1.Image = Image.FromFile(ofdSleccionarFoto.FileName);

                }
            }
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            Image image = Properties.Resources.usuario_1;
            Image image1 = Properties.Resources.usuario_2;
            Image image2 = Properties.Resources.usuario_3;

            GridListaUsuarios.Rows.Add("sedcol44", "Alexis", "Colman", "prueba@gmail.com", "12345678", "1232223111", "admin123", image1, "Vendedor");
            GridListaUsuarios.Rows.Add("sedcol41", "Leonel", "Perez", "prueba2@hotmail.com", "11111111", "112515231", "admin44", image2, "Cliente");
            GridListaUsuarios.Rows.Add("sedcol44", "Alicia", "Rojas", "prueba3@gmail.com", "22222222", "12329811", "admin812", image1, "Supervisor");
            GridListaUsuarios.Rows.Add("sedcol44", "Jorge", "Villa", "prueba223@gmail.com", "33333333", "22129811", "admin812", image, "Cliente");
            GridListaUsuarios.Rows.Add("sedcol44", "Gonzalo", "Villa", "prueba223@gmail.com", "44444444", "22129811", "admin812", image, "Administrador");
        }

        private void TBUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBNombre_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBEmail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBDni_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBContraseña2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBBuscar_Click(object sender, EventArgs e)
        {
            TBBuscar.Clear();
        }
    }
}
