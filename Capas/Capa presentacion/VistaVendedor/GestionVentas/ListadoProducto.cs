using ProyectoTaller.Capas.Capa_datos;
using ProyectoTaller.Capas.Capa_datos.Vendedor;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionProductos;
using ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    public partial class ListadoProducto : Form
    {
        private ClaseCatalogoProductos miClaseListaProductos;
        public ListadoProducto()
        {
            InitializeComponent();
            BEliminarFiltro.Visible = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            miClaseListaProductos = new ClaseCatalogoProductos( TBBuscar,  TBNombre,  TBCategoria, TBColor, TBCantidad,  TBDescripcion, TBPrecio,  BBuscarFiltro,  BEliminarFiltro,  
             DGCatalogo, errorProvider1);
            EsSupervisor();
            this.MaximizeBox = false;
        }

        ClaseLogin claseLogin = new ClaseLogin();
        public void EsSupervisor()
        {
            Empleado empleadoLogeado = DatosSesion.EmpleadoLogeado;

            if (empleadoLogeado != null)
            {
                if (empleadoLogeado.ID_perfil == 3 || empleadoLogeado.ID_perfil != 2)
                {
                    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                }
            }
        }

        private void ListadoProducto_Load(object sender, EventArgs e)
        {
            miClaseListaProductos.MostrarProductos();
        }

     

        private void BEliminarFiltro_Click(object sender, EventArgs e)
        {
            miClaseListaProductos.LimpiarFiltros();
        }

        private void TBBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BBuscarFiltro_Click(object sender, EventArgs e)
        {
            miClaseListaProductos.BuscarProducto();
        }
        

        private void DGCatalogo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            miClaseListaProductos.DobleClick();
        }
    }
}

