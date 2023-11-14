using ProyectoTaller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionProductos;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionUsuarios;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.PerfilAdmin;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionVentas;
using ProyectoTaller.Capas.Capa_datos;
using ProyectoTaller.Capas.Capa_datos.Administrador;
using System.Data.SqlClient;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador
{
    public partial class MenuAdmin : Form
    {
        ClaseMenuAdmin ClaseMenu = new ClaseMenuAdmin();

        private Empleado empleadoLogeado;
        public MenuAdmin()
        {
            InitializeComponent();
        
            this.Icon = Properties.Resources.admin;
            MostrarDatosEmpleado();
        }

        private void BListaProductos_Click(object sender, EventArgs e)
        {
            ClaseMenu.ListadoProductos(PanelHijos);
        }

        private void BListaUsuarios_Click(object sender, EventArgs e)
        {
            ClaseMenu.ListaEmpleados(PanelHijos);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClaseMenu.Seguridad(PanelHijos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaseMenu.PerfilAdmin(PanelHijos);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ClaseMenu.ListaVendedores(PanelHijos);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            PanelHijos.Controls.Add(LSaludo);
            PanelHijos.Controls.Add(PBMate);
        }

        private void BCerrarSesion_Click_1(object sender, EventArgs e)
        {
           if( ClaseMenu.CerrarSesion() == true)
            {
                this.Hide();
            }  
        }

        private void BMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir de la aplicación? ", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClaseMenu.ListaClientes(PanelHijos);
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            if (DatosSesion.EmpleadoLogeado != null)
            {
                MostrarDatosEmpleado();
            }
            else
            {
                MessageBox.Show("No se han cargado los datos del empleado.\nPorfavor Inicie sesion, sino todas las funciones no estaran disponibles", "No se ha iniciado sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarDatosEmpleado()
        {
            if (DatosSesion.EmpleadoLogeado != null)
            {
                // Accede a los datos del Empleado logeado
                Empleado empleado = DatosSesion.EmpleadoLogeado;
                label1.Text = "Empleado: " + empleado.Nombre + "  " + empleado.Apellido;
                LSaludo.Text = "Bienvenido: " + empleado.Nombre + " " + empleado.Apellido;
            }
        }
    }
}
