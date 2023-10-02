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

namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor
{
    public partial class MenuSupervisor : Form
    {
        public MenuSupervisor()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.supervisor;
        }

        private void BCerrarSesion_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Form cerrarSesion = new Form1();
                cerrarSesion.Show();
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

        private void BGestionProveedores_Click(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            ListaProveedores Frm = new ListaProveedores();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        private void BPedidos_Click_1(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            PedidoProveedores Frm = new PedidoProveedores();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        private void BEstadisticas_Click_1(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            EstadisticasObtenidas Frm = new EstadisticasObtenidas();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
           Frm.Show();
        }

        private void BPerfil_Click(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            PerfilSupervisor Frm = new PerfilSupervisor();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }
    }
}
