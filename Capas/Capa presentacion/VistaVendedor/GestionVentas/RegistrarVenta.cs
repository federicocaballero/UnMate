using ProyectoTaller.Capas.Capa_datos;
using ProyectoTaller.Capas.Capa_datos.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    public partial class RegistrarVenta : Form
    {

        private ClaseVenta miClaseVenta;

        public RegistrarVenta()
        {  
            InitializeComponent();
            BLimpiar.Visible = false;
            BVaciarCarrito.Enabled = false;
            TBCliente.Enabled = true;
            miClaseVenta = new ClaseVenta( CBPago,  GridProductosParaVenta, errorProvider1,  TBCliente,  LVCompra, BLimpiar,  TBCantidad,  TBProducto, 
            TBDescripcion, TBPrecio, TBTotalPago, BVaciarCarrito,  TBVendedor, BBuscar, BCancelarCompra, TBIDVenta, TBBuscarUnProducto ,BBuscarProducto);
            LVCompra.View = View.Details;
      
        }


        private void RegistrarVenta_Load(object sender, EventArgs e)
        {
            miClaseVenta.MostrarProductos();
            miClaseVenta.ComboPago();
            if (DatosSesion.EmpleadoLogeado != null)
            {
                Empleado empleado = DatosSesion.EmpleadoLogeado;
                TBVendedor.Text = empleado.Cod_Empleado.ToString(); 
                TBNombreVendedor.Text = empleado.Nombre .ToString() + " " + empleado.Apellido;
            }
            miClaseVenta.CodDeVenta();

        }
        private void BCarrito_Click(object sender, EventArgs e)
        {
            miClaseVenta.BorrarCarrito();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int total;
            if (int.TryParse(TBCantidad.Text, out int cantidad))
            {
                if (cantidad >= 2)
                {
                    cantidad -= 1;
                    TBCantidad.Text = cantidad.ToString();
                }
            }
        }

     
        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnCompra_Click_1(object sender, EventArgs e)
        {
            miClaseVenta.Compra();
        }

        private void BVaciarCarrito_Click_1(object sender, EventArgs e)
        {
            miClaseVenta.VaciarCarrito();
        }

        private void BBuscar_Click_1(object sender, EventArgs e)
        {
            miClaseVenta.BuscarCliente();
        }
        
        private void GridProductosParaVenta_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            miClaseVenta.DobleClick();
        }

        private void TBUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BCancelarCompra_Click_1(object sender, EventArgs e)
        {
            miClaseVenta.CancelarDescuento();
            this.Close();
            
        }

        private void BLimpiar_Click_1(object sender, EventArgs e)
        {
            miClaseVenta.LimpiarCliente();
        }

        private void TBCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total;
            if (int.TryParse(TBCantidad.Text, out int cantidad))
            {
                if (cantidad >= 1)
                {
                    cantidad += 1;
                    TBCantidad.Text = cantidad.ToString();
                }
            }
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            miClaseVenta.buscarProducto();
        }

        private void TBBuscarUnProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
