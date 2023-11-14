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
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionClientes;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.PerfilVendedor;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas;
using System.Collections;
using ProyectoTaller.Capas.Capa_datos.Vendedor;
using ProyectoTaller.Capas.Capa_datos;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor
{
    public partial class MenuVendedor : Form
    {
        ClaseMenuVendedor ClaseMenuVendedor = new ClaseMenuVendedor();
        public MenuVendedor()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.vendedor;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            ClaseMenuVendedor.SalirAplicacion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaseMenuVendedor.IrInicio(PanelHijos, LSaludo, PBMate);
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            if (ClaseMenuVendedor.CerrarSesion())
            {
                this.Hide();
            }
        }
        private void BMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BGestionClientes_Click(object sender, EventArgs e)
        {
            ClaseMenuVendedor.GestionClientes(PanelHijos);
        }

        private void BPerfil_Click(object sender, EventArgs e)
        {
            ClaseMenuVendedor.PerfilVendedor(PanelHijos);
        }

        private void BListaProductos_Click(object sender, EventArgs e)
        {

            ClaseMenuVendedor.ListaDeProductos(PanelHijos);
        }

        private void BDetalles_Click_1(object sender, EventArgs e)
        {
          ClaseMenuVendedor.DetallesVentas(PanelHijos);
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MenuVendedor_Load(object sender, EventArgs e)
        {
            if (DatosSesion.EmpleadoLogeado != null)
            {
                MostrarDatosEmpleado();
            }
            else
            {
                MessageBox.Show("No se han cargado los datos del empleado.\nPorfavor Inicie sesion, sino todas las funciones no estaran disponibles","No se ha iniciado sesión",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void MostrarDatosEmpleado()
        {
            if (DatosSesion.EmpleadoLogeado != null)
            {
                // Accede a los datos del Empleado logeado
                Empleado empleado = DatosSesion.EmpleadoLogeado;
                label1.Text = "Empleado: " + empleado.Nombre + "  " + empleado.Apellido;
                LSaludo.Text = "Vendedor:" + empleado.Nombre + " " + empleado.Apellido;
            
            }
        }
    }
    
}
