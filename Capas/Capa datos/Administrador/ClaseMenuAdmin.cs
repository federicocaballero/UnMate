using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionProductos;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionUsuarios;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionVentas;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.PerfilAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Administrador
{
    internal class ClaseMenuAdmin
    {
        public Empleado EmpleadoLogeado { get; set; }
        public void ListadoProductos(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            ListaProductos Frm = new ListaProductos();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public void ListaEmpleados(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            ListaEmpleados Frm = new ListaEmpleados();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public void Seguridad(Panel PanelHijos) 
        {
            PanelHijos.Controls.Clear();
            Seguridad Frm = new Seguridad();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public void PerfilAdmin(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            PerfilAdministrador Frm = new PerfilAdministrador();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public void ListaVendedores(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            ListadoVentasVendedores Frm = new ListadoVentasVendedores();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public bool CerrarSesion()
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                List<Form> formulariosParaCerrar = new List<Form>();

                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "DetalleDeVenta")
                    {
                        formulariosParaCerrar.Add(form);
                    }
                }

                foreach (Form form in formulariosParaCerrar)
                {
                    form.Close();
                }

                
                Form1 form1 = new Form1();
                form1.Show();

                return true; 
            }

            return false; 
        }


        public void ListaClientes(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            ListaClientes Frm = new ListaClientes();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

    }

}
