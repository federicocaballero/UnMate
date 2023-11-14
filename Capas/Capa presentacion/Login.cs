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
using System.Data.SqlClient;
using System.Net;
using ProyectoTaller.Capas.Capa_datos;

namespace ProyectoTaller
{
    public partial class Form1 : Form
    {

        ClaseLogin claseLogin = new ClaseLogin();
    

        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icono;
           
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
            
            claseLogin.SalirAplicacion();
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
                BIniciar_Click(sender, e);
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void TBUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla Enter
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }

            // Si es la tecla Enter, llamar a la función de inicio de sesión
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                // Llamar a la función de inicio de sesión
                BIniciar_Click(sender, e);
            }
        }


        private void BIniciar_Click(object sender, EventArgs e)
        {
            Empleado empleadoLogeado = claseLogin.IniciarSesion(TBDniUsuario.Text, TBContraseña.Text);
            claseLogin.ErroresMarcados(TBDniUsuario, TBContraseña, errorProvider1);
            if (empleadoLogeado != null)
            {
                int tipoPerfil = empleadoLogeado.ID_perfil;
                if (tipoPerfil == 1)
                {
                    MenuAdmin admin = new MenuAdmin();
                    admin.Show();
                    this.Hide();
                }
                else if (tipoPerfil == 2)
                {
                    MenuVendedor vendedor = new MenuVendedor();
                    vendedor.Show();
                    this.Hide();
                }
                else if (tipoPerfil == 3)
                {
                    MenuSupervisor supervisor = new MenuSupervisor();
                    supervisor.Show();
                    this.Hide();
                }
            }
          
        }


    }

}