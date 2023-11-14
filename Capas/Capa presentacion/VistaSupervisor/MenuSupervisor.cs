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
using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores;
using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.Estadisticas;
using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.PerfilSuperv;
using ProyectoTaller.Capas.Capa_datos.Supervisor;
using ProyectoTaller.Capas.Capa_datos;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor
{
    public partial class MenuSupervisor : Form
    {
        public MenuSupervisor()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.supervisor;
        }

        ClaseMenuSupervisor ClaseMenuSupervisor = new ClaseMenuSupervisor();

        private void BCerrarSesion_Click_1(object sender, EventArgs e)
        {
            if (ClaseMenuSupervisor.CerrarSesion()) {
                this.Hide();
            }
        }

        private void BMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            ClaseMenuSupervisor.SalirAplicacion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaseMenuSupervisor.IrInicio( PanelHijos, LSaludo, PBMate);
        }

        private void BGestionProveedores_Click(object sender, EventArgs e)
        {
            ClaseMenuSupervisor.GestionProveedor(PanelHijos);
        }

        private void BPedidos_Click_1(object sender, EventArgs e)
        {
            ClaseMenuSupervisor.GestionPedidos(PanelHijos);
        }

        private void BEstadisticas_Click_1(object sender, EventArgs e)
        {
          ClaseMenuSupervisor.Estadisticas(PanelHijos);
        }

        private void BPerfil_Click(object sender, EventArgs e)
        {
           ClaseMenuSupervisor.MiPerfil(PanelHijos);
        }

        private void MenuSupervisor_Load(object sender, EventArgs e)
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
