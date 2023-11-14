using ProyectoTaller.Capas.Capa_datos.Administrador;
using ProyectoTaller.Capas.Capa_datos.Supervisor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas;
using ProyectoTaller.Capas.Capa_datos;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores
{
    public partial class PedidoProveedores : Form
    {
        private ClasePedidoProveedores Pedidos;

        public PedidoProveedores()
        {
            InitializeComponent();
            BBorrarListado.Visible = false;
            BEliminar.Enabled = false;
            BLimpiarProveedor.Visible = false;
            BLimpiarProducto.Visible = false;
            BConfirmar.Visible = false;
            MoverIndex(); TBImporte.Enabled = false;
            Pedidos = new ClasePedidoProveedores( GridPedidos, TBProducto,  TBDescripcion, TFecha,  TBProveedor, TBCantidad, TBImporte, BBuscarProducto,  BLimpiarProducto,  errorProvider1,BLimpiarProveedor,
            BEliminar,  BAñadir, BBuscarProveedor,  BBorrarListado,  BConfirmar,  TBBuscarProveedor, BHistorialPedidos, LTotal, BBuscar);
        }

        private void BAñadir_Click(object sender, EventArgs e)
        {
            Pedidos.AñadirPedido();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedidos.DobleClick();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            Pedidos.EliminarPedido();
        }

        private void PedidoProveedores_Load(object sender, EventArgs e)
        {
            Pedidos.mostrarPedidos();
            
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            Pedidos.BuscarPedido();
        }

        private void BBorrarListado_Click(object sender, EventArgs e)
        {
            Pedidos.BorrarListado();
        }

        private void BBuscarProveedor_Click(object sender, EventArgs e)
        {
            Pedidos.BuscarProveedor();
        }


        private void button1_Click(object sender, EventArgs e)
        {
             Pedidos.BuscarProducto();
        }

 
        private void BLimpiarProducto_Click(object sender, EventArgs e)
        {
            Pedidos.LimpiarProducto();
            
        }

        private void TBProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBProducto_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TBProducto.Text))
            {
                errorProvider1.SetError(TBProducto, "Producto necesario");
            }
            else
            {
                errorProvider1.SetError(TBProducto, "");
            }
        }

        private void TBDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDescripcion.Text))
            {
                errorProvider1.SetError(TBDescripcion, "No se permiten espacios en blanco");
            }
            else
            {
                errorProvider1.SetError(TBDescripcion, "");
            }
        }

        private void TBBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BLimpiarProveedor_Click(object sender, EventArgs e)
        {
            Pedidos.LimpiarProveedor();
        }

        private void MoverIndex()
        {
            TBProducto.TabIndex = 0;
            TBDescripcion.TabIndex = 1;
            TBCantidad.TabIndex = 2;
            TBProveedor.TabIndex = 3;
            BAñadir.TabIndex = 4;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pedidos.ConfirmarPedido();
        }

        private void TBProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Pedidos.HistorialPedidos();
        }

        private bool catalogoAbierto = false;
        private Form catalogo = null;
        private void BCatalogo_Click(object sender, EventArgs e)
        {
            if (!catalogoAbierto)
            {
                
                ListadoProducto catalogoProductos = new ListadoProducto();
                catalogoProductos.FormClosed += (s, args) =>
                {
                    catalogoAbierto = false; // restablece a falso cuando se cierra el formulario
                };
                catalogoAbierto = true;
                catalogoProductos.ShowDialog();
            }

        }
    }
}
