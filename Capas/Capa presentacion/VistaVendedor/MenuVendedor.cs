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
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.Administración;
namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor
{
    public partial class MenuVendedor : Form
    {
        public MenuVendedor()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.vendedor;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir de la aplicación? ", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            PanelHijos.Controls.Add(LSaludo);
            PanelHijos.Controls.Add(PBMate);
        }

        private void BMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Form cerrarSesion = new Form1();
                cerrarSesion.Show();
                this.Hide();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BGestionClientes_Click(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            GestionCliente Frm = new GestionCliente();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        private void BPerfil_Click(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            PerfilVendedores Frm = new PerfilVendedores();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        private void BListaProductos_Click(object sender, EventArgs e)
        {

            PanelHijos.Controls.Clear();
            ListadoProducto Frm = new ListadoProducto();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        private void BDetalles_Click_1(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            ListadoVentas Frm = new ListadoVentas();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        private void BNotas_Click(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            Notas Frm = new Notas();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }
    }
    
}
