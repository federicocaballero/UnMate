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

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.admin;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //PanelHijos.Controls.Clear();
            //PerfilSupervisor Frm = new PerfilSupervisor();
            // Frm.Dock = DockStyle.Fill;
            //Frm.TopLevel = false;
            // PanelHijos.Controls.Add(Frm);
            //Frm.Show();
        }

        private void BListaProductos_Click(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            ListaProductos Frm = new ListaProductos();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            PanelHijos.Controls.Add(LSaludo);
            PanelHijos.Controls.Add(PBMate);
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

        private void BListaUsuarios_Click(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            ListaUsuarios Frm = new ListaUsuarios();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            Seguridad Frm = new Seguridad();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            PerfilAdministrador Frm = new PerfilAdministrador();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PanelHijos.Controls.Clear();
            ListadoVentasVendedores Frm = new ListadoVentasVendedores();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }
    }
}
