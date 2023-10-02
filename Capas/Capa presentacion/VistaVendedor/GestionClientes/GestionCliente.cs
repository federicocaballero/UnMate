using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionClientes
{
    public partial class GestionCliente : Form
    {
        public GestionCliente()
        {
            InitializeComponent();
            BGuardarModificacion.Enabled = false;
            BLimpiarFiltros.Visible = false;
            BBorrarListado.Visible = false;

            //ajustar imagen al picture box
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            TBContraseña2.Clear();
            TBBuscar.Clear();

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
        }

        private void GestionCliente_Load(object sender, EventArgs e)
        {

            System.Drawing.Image image = Properties.Resources.usuario_1;
            System.Drawing.Image image1 = Properties.Resources.usuario_2;
            System.Drawing.Image image2 = Properties.Resources.usuario_3;

            GridListaUsuarios.Rows.Add("sedcol44", "Alexis", "Colman", "prueba@gmail.com", "122311134", "1232223111", "admin123", image1, "Vendedor");
            GridListaUsuarios.Rows.Add("leo44s", "Leonel", "Perez", "prueba2@hotmail.com", "56722118", "112515231", "admin44", image2, "Vendedor");
            GridListaUsuarios.Rows.Add("alicRojas", "Alicia", "Rojas", "prueba3@gmail.com", "888555332", "12329811", "admin812", image1, "Cliente");

        }

        private void BAñadirC_Click(object sender, EventArgs e)
        {
            QuitarErrores();
            //CAMPOS DISTINTO DE VACIO
            if (TBUsuario.Text != "" && TBContraseña.Text != "" && TBDni.Text != ""
             && TBEmail.Text != "" && LTelefono.Text != "" && TBApellido.Text != ""
             && TBNombre.Text != "" && pictureBox1.Image != null && TBContraseña2.Text != ""
             && ErroresProviders())
            {

                //CONTRASEÑA IGUAL
                if (TBContraseña.Text == TBContraseña2.Text)
                {
                    DialogResult result = MessageBox.Show("Desea  añadir un usuario?", "Añadir un usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        System.Drawing.Image imagen = pictureBox1.Image;
                        GridListaUsuarios.Rows.Add(TBUsuario.Text, TBNombre.Text, TBEmail.Text, TBApellido.Text, TBDni.Text, TBTelefono.Text, TBContraseña.Text, pictureBox1.Image);
                        MessageBox.Show("Usuario agregado con exito", "Añadir un usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BorrarFilas();
                        QuitarErrores();

                    }
                    else
                    {
                        MessageBox.Show("Insercion cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }


            }
            else
            {
                MessageBox.Show("Existe uno o varios campos incompletos\nPor favor revise los campos marcados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();

            }
        }

        private void BBorrarListado_Click(object sender, EventArgs e)
        {
            BorrarFilas();
            BAñadirC.Enabled = true;
            BBorrarListado.Visible = false;
            BGuardarModificacion.Enabled = false;
            BLimpiarFiltros.PerformClick();
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

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSleccionarFoto = new OpenFileDialog();
            ofdSleccionarFoto.Filter = "Imagenes|*.jpg; *.png";
            ofdSleccionarFoto.Title = "Seleccionar Foto de Producto";


            if (ofdSleccionarFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = null;
                pictureBox1.Image = System.Drawing.Image.FromFile(ofdSleccionarFoto.FileName);

            }
        }

        private void GridListaUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TBUsuario.Text = GridListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            TBNombre.Text = GridListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            TBApellido.Text = GridListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            TBEmail.Text = GridListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            TBDni.Text = GridListaUsuarios.CurrentRow.Cells[4].Value.ToString();
            TBTelefono.Text = GridListaUsuarios.CurrentRow.Cells[5].Value.ToString();
            TBContraseña.Text = GridListaUsuarios.CurrentRow.Cells[6].Value.ToString();

            System.Drawing.Image image = GridListaUsuarios.CurrentRow.Cells[7].Value as System.Drawing.Image;

            pictureBox1.Image = image;
            TBContraseña2.Text = GridListaUsuarios.CurrentRow.Cells[6].Value.ToString();
            TextoDesbloqueado();
            QuitarErrores();
            BGuardarModificacion.Enabled = true;
            BAñadirC.Enabled = false;
            BBorrarListado.Visible = true;
        }

        private void BGuardarModificacion_Click(object sender, EventArgs e)
        {

            QuitarErrores();
            if (TBUsuario.Text != "" && TBContraseña.Text != "" && TBDni.Text != ""
               && TBEmail.Text != "" && LTelefono.Text != "" && TBApellido.Text != ""
               && TBNombre.Text != "" && ErroresProviders())
            {

                if (TBContraseña.Text == TBContraseña2.Text)
                {
                    DialogResult result = MessageBox.Show("Desea modificar al usuario?", "Modificacion de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        GridListaUsuarios.CurrentRow.Cells[0].Value = TBUsuario.Text;
                        GridListaUsuarios.CurrentRow.Cells[1].Value = TBNombre.Text;
                        GridListaUsuarios.CurrentRow.Cells[2].Value = TBApellido.Text;
                        GridListaUsuarios.CurrentRow.Cells[3].Value = TBEmail.Text;
                        GridListaUsuarios.CurrentRow.Cells[4].Value = TBDni.Text;
                        GridListaUsuarios.CurrentRow.Cells[5].Value = TBTelefono.Text;
                        GridListaUsuarios.CurrentRow.Cells[6].Value = TBContraseña.Text;
                        GridListaUsuarios.CurrentRow.Cells[7].Value = pictureBox1.Image;
                        System.Drawing.Image image = GridListaUsuarios.CurrentRow.Cells[7].Value as System.Drawing.Image;

                        pictureBox1.Image = image;
                        GridListaUsuarios.CurrentRow.Cells[6].Value = TBContraseña2.Text;

                        pictureBox1.Image = null;
                        MessageBox.Show("Modificación de usuario realizada", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BLimpiarFiltros.PerformClick(); BLimpiarFiltros.Visible = false;
                        BorrarFilas();
                        BAñadirC.Enabled = true;
                        BGuardarModificacion.Enabled = false;
                        QuitarErrores();
                    }
                    else
                    {
                        MessageBox.Show("Modificación cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Existe uno o varios campos incompletos\nPor favor revise los campos marcados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if(TBBuscar.Text == "")
            {
                errorProvider1.SetError(TBBuscar, "Debe ingresar un dni");
            }

            bool encontrarCliente = false;
            if (TBBuscar.Text != "")
            {
                string contenidoDeseado = TBBuscar.Text; // Contenido que sea desea buscar en la primera columna
                BLimpiarFiltros.Visible = true;

                // Recorre todas las filas del DataGridView
                foreach (DataGridViewRow fila in GridListaUsuarios.Rows)
                {

                    // Verifica el contenido de la celda en la primera columna (índice 4)
                    if (fila.Cells[4].Value != null && fila.Cells[4].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                    {
                        // Si coincide, muestra la fila completa
                        fila.Visible = true;
                        encontrarCliente = true;
                        errorProvider1.SetError(TBBuscar, "");
                    }
                    else
                    {
                        // Si no coincide, oculta la fila completa
                        fila.Visible = false;
                        errorProvider1.SetError(TBBuscar, "");
                    }
                }
           
            if (!encontrarCliente)
            {
                MessageBox.Show("Cliente no encontrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscar.Clear();
                BLimpiarFiltros.Visible = false;
                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridListaUsuarios.Rows)
                {
                    BLimpiarFiltros.Visible = false;
                    fila.Visible = true;


                }
                }
            }
        }

        private void TBUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
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

        private void TBApellido_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void TBContraseña2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
