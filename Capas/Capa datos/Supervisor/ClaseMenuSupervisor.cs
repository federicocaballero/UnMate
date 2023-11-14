using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.Estadisticas;
using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores;
using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.PerfilSuperv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Supervisor
{
    internal class ClaseMenuSupervisor
    {
        public Empleado EmpleadoLogeado { get; set; }
        public void SalirAplicacion()
        {
            DialogResult result = MessageBox.Show("Desea salir de la aplicación? ", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public bool CerrarSesion()
        {
            DialogResult result = MessageBox.Show("Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Form cerrarSesion = new Form1();
                cerrarSesion.Show();

                List<Form> formulariosParaCerrar = new List<Form>();

                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "Pedidos" || form.Name == "ListadoProducto")
                    {
                        formulariosParaCerrar.Add(form);
                    }
                }

                foreach (Form form in formulariosParaCerrar)
                {
                    form.Close();
                }
                return true;
               

            }
            return false;
        }




        public void IrInicio(Panel PanelHijos,Label LSaludo, PictureBox PBMate)
        {
            PanelHijos.Controls.Clear();
            PanelHijos.Controls.Add(LSaludo);
            PanelHijos.Controls.Add(PBMate);
        }

        public void GestionProveedor(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            ListaProveedores Frm = new ListaProveedores();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public void GestionPedidos(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            PedidoProveedores Frm = new PedidoProveedores();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public void Estadisticas(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            EstadisticasObtenidas Frm = new EstadisticasObtenidas();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public void MiPerfil(Panel PanelHijos)
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
