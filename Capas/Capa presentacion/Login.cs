using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador;
using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor;
namespace ProyectoTaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icono;
        }

        //RESTRICCIONES DE CAMPOS
        private void TBCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                // Llamar a la función de inicio de sesión
                button1_Click(sender, e);
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void TContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                // Llamar a la función de inicio de sesión
                button1_Click(sender, e);
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        //Iniciar sesión dependendiendo del usuario a traves de un SWITCH case
        private void button1_Click(object sender, EventArgs e)
        {

            if (TBContraseña.Text == "")
            {
                // Establecer un mensaje de error para el control TBContraseña
                errorProvider1.SetError(TBContraseña, "Contraseña obligatoria");
            }
            else
            {
                //quitar el error provider
                errorProvider1.SetError(TBContraseña, "");
            }
            if (TBUsuario.Text == "")
            {
                // Establecer un mensaje de error para el control TBUsuario
                errorProvider1.SetError(TBUsuario, "Usuario obligatorio");
            }
            else
            {
                //quitar el error provider
                errorProvider1.SetError(TBUsuario, "");
            }


            if (TBUsuario.Text != "" && TBContraseña.Text != "")
            {

                string logearUusuario = TBUsuario.Text;

                switch (logearUusuario)
                {
                    case "admin":
                        if (logearUusuario == "admin" && TBContraseña.Text == "admin")
                        {
                            MessageBox.Show("INICIANDO SESION COMO ADMINISTRADOR", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Form administrador = new MenuAdmin();
                            administrador.Show();
                            this.Hide();
                        }
                        break;

                    case "vendedor":
                        if (logearUusuario == "vendedor" && TBContraseña.Text == "vendedor")
                        {
                            MessageBox.Show("INICIANDO SESION COMO VENDEDOR", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Form administrador = new MenuVendedor();
                            administrador.Show();
                            this.Hide();
                        }
                        break;

                    case "supervisor":
                        if (logearUusuario == "supervisor" && TBContraseña.Text == "supervisor")
                        {
                            MessageBox.Show("INICIANDO SESION COMO SUPERVISOR", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Form administrador = new MenuSupervisor();
                            administrador.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        MessageBox.Show("Usuario no encontrado, porfavor revise datos", "Error en iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {

               MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand); 
            }


        }

        //SALIR DE APLICACION
        private void BSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir de la aplicación? ", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void BIniciar_Click(object sender, EventArgs e)
        {
            if (TBContraseña.Text == "")
            {
                // Establecer un mensaje de error para el control TBContraseña
                errorProvider1.SetError(TBContraseña, "Contraseña obligatoria");
            }
            else
            {
                //quitar el error provider
                errorProvider1.SetError(TBContraseña, "");
            }
            if (TBUsuario.Text == "")
            {
                // Establecer un mensaje de error para el control TBUsuario
                errorProvider1.SetError(TBUsuario, "Usuario obligatorio");
            }
            else
            {
                //quitar el error provider
                errorProvider1.SetError(TBUsuario, "");
            }


            if (TBUsuario.Text != "" && TBContraseña.Text != "")
            {

                string logearUusuario = TBUsuario.Text;

                switch (logearUusuario)
                {
                    case "admin":
                        if (logearUusuario == "admin" && TBContraseña.Text == "admin")
                        {
                            MessageBox.Show("INICIANDO SESION COMO ADMINISTRADOR", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                          

                        }
                        break;

                    case "vendedor":
                        if (logearUusuario == "vendedor" && TBContraseña.Text == "vendedor")
                        {
                            MessageBox.Show("INICIANDO SESION COMO VENDEDOR", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                           
                        }
                        break;

                    case "supervisor":
                        if (logearUusuario == "supervisor" && TBContraseña.Text == "supervisor")
                        {
                            MessageBox.Show("INICIANDO SESION COMO SUPERVISOR", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       
                        }
                        break;
                    default:
                        MessageBox.Show("Usuario no encontrado, porfavor revise datos", "Error en iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {

                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


        }

        private void BMinimizar_Click(object sender, EventArgs e)
        {
          
                this.WindowState = FormWindowState.Minimized;
            
        }

        //MOVER LA APLICACION
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BSalir_Click_1(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Desea salir de la aplicación? ", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TBContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                // Llamar a la función de inicio de sesión
                button1_Click(sender, e);
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void TBUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                // Llamar a la función de inicio de sesión
                button1_Click(sender, e);
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}