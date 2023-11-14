using ProyectoTaller.Capas.Capa_datos.Administrador;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionClientes;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.PerfilVendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Vendedor
{
    internal class ClaseMenuVendedor
    {

        public void SalirAplicacion()
        {
            DialogResult result = MessageBox.Show("Desea salir de la aplicación? ", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        public void IrInicio(Panel PanelHijos, Label LSaludo, PictureBox PBMate)
        {
            PanelHijos.Controls.Clear();
            PanelHijos.Controls.Add(LSaludo);
            PanelHijos.Controls.Add(PBMate);
        }

        public bool CerrarSesion()
        {
                
                DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    // crear una lista de formularios a cerrar
                    List<Form> formulariosParaCerrar = new List<Form>();

                    // identificar los formularios a cerrar
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "DetalleCompra" || form.Name == "RegistrarVenta")
                        {
                            formulariosParaCerrar.Add(form);
                        }
                    }

                    // cerrar los formularios en la lista
                    foreach (Form form in formulariosParaCerrar)
                    {
                        form.Close();
                    }

                    // abre un nuevo formulario 
                    Form1 form1 = new Form1();
                    form1.Show();

                return true;
            }
           
                return false;
            
        }

        public void GestionClientes(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            GestionCliente Frm = new GestionCliente();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public void PerfilVendedor(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            PerfilVendedores Frm = new PerfilVendedores();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public void ListaDeProductos(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            ListadoProducto Frm = new ListadoProducto();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }

        public void DetallesVentas(Panel PanelHijos)
        {
            PanelHijos.Controls.Clear();
            ListadoVentas Frm = new ListadoVentas();
            Frm.Dock = DockStyle.Fill;
            Frm.TopLevel = false;
            PanelHijos.Controls.Add(Frm);
            Frm.Show();
        }
    }
}
