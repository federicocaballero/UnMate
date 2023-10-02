using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    public partial class RegistrarVenta : Form
    {

        //double precio = 0;
        public RegistrarVenta()
        {

            InitializeComponent();
            BLimpiar.Visible = false;
            BVaciarCarrito.Enabled = false;
            BLimpiarFiltroGrid.Visible = false;
            TBUsuario.Enabled = true;

        }

      
        private void BorrarCamposRegistrados()
        {
            TBProducto.Clear();
            TBDescripcion.Clear();
            TBPrecio.Clear();
            TBCantidad.Text = " ";
            TBCantidad.ReadOnly = true;

        }

        private void BorrarTodo()
        {
            CBPago.SelectedItem = null;
            TBCantidad.Clear();
            TBTotalPago.Clear();
            LVCompra.Items.Clear();
            TBCantidad.Clear();
            TBUsuario.Clear();
            TBUsuario.Enabled = true;

        }

        private bool ErrorProviders()
        {
            bool nuevaVenta = true;

            if (TBUsuario.Text == "")
            {
                errorProvider1.SetError(TBUsuario, "Usuario necesario");
                nuevaVenta = false;
            }

            if (CBPago.SelectedItem == null)
            {
                errorProvider1.SetError(CBPago, "Metodo de pago necesario");
                nuevaVenta = false;
            }

            return nuevaVenta;
        }

        private void QuitarErrores()
        {
            errorProvider1.SetError(TBUsuario, "");
            errorProvider1.SetError(CBPago, "");
        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {
            GridProductosParaVenta.Rows.Add("Mate de madera", "Bueno para tomar mates", "33", "800");
            GridProductosParaVenta.Rows.Add("Mate de metal", "Malo para los mates", "7", "1200");
        }

        private void BCarrito_Click(object sender, EventArgs e)
        {
            //verificamos que no esten vacios
            if (TBProducto.Text != "" && TBPrecio.Text != "")
            {
                //creamos variables locales y convertimos los datos en enteros
                string producto = TBProducto.Text;
                int cant = Convert.ToInt32(TBCantidad.Text);
                int precio = Convert.ToInt32(TBPrecio.Text);

                //comprobar que la cantidad requerida del producto es menor al de producto en stock del grid
                if (int.TryParse(TBCantidad.Text, out int cantidadRequerida) && cantidadRequerida <= Convert.ToInt32(GridProductosParaVenta.CurrentRow.Cells[2].Value))
                {

                    //convertimos a la celda en la que se encuentra el stock del producto en entero y luego descontamos de la cantidad que se registro
                    int.TryParse(GridProductosParaVenta.CurrentRow.Cells[2].Value.ToString(), out int valorCelda);
                    GridProductosParaVenta.CurrentRow.Cells[2].Value = valorCelda - cant;

                    //subtotal de una fila
                    double subtotal = cant * precio;

                    //agrega los datos a la lista
                    ListViewItem fila = new ListViewItem(producto);
                    fila.SubItems.Add(TBDescripcion.Text.ToString());
                    fila.SubItems.Add(cant.ToString());
                    fila.SubItems.Add(precio.ToString() + "$");
                    fila.SubItems.Add(subtotal.ToString() + "$");
                    LVCompra.Items.Add(fila);
                    BVaciarCarrito.Enabled = true;
                    BorrarCamposRegistrados();


                    //CALCULAR EL TOTAL DE LA COMPRA
                    decimal totalpago = 0.0m;
                    foreach (ListViewItem item in LVCompra.Items)
                    {
                        //el precio total se encuentra en la posicion 3
                        if (item.SubItems.Count > 3)
                        {
                            if (decimal.TryParse(item.SubItems[4].Text.TrimEnd('$'), out decimal precioLV))
                            {
                                totalpago += precioLV; // Suma el precio

                            }
                        }
                    }

                    //COLOCA EL TOTAL EL EL TEXT BOX
                    TBTotalPago.Text = totalpago.ToString() + "$";
                }
                else
                {
                    MessageBox.Show("No puede ser mayor al stock actual", "Error en carrito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Falta completar algun dato", "Error en carrito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button3_Click_1(object sender, EventArgs e)
        {

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
            //verificar que existan elementos
            if (LVCompra.Items.Count == 0)
            {
                MessageBox.Show("El carrito se encuentra vacio", "Error de compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QuitarErrores();
                if (TBUsuario.Text != "" && CBPago.Text != "" && ErrorProviders())
                {
                    DialogResult result = MessageBox.Show("Estas seguro que desea realizar la compra", "Registrar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Venta realizada correctamente :)", "Compra correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BLimpiar.Visible = false;
                        TBUsuario.Enabled = true;
                        BorrarTodo();
                        QuitarErrores();
                        TBBuscarProductoGrid.Clear();
                        BVaciarCarrito.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Venta cancelada", "Error al realizar la venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Falta completar algun dato de compra \nPor favor revisar los datos", "Error de venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorProviders();
                }
            }
        }

        private void BVaciarCarrito_Click_1(object sender, EventArgs e)
        {
            if (LVCompra.Items.Count != 0)
            {
                DialogResult result = MessageBox.Show("Estas seguro que desea vaciar el carrito", "Vaciar carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    LVCompra.Items.Clear();
                    TBTotalPago.Clear();
                    BLimpiar.Visible = false;
                    MessageBox.Show("Productos eliminados del carrito", "Vaciar carrito", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    BVaciarCarrito.Enabled = false;
                }
                else
                { }

            }
            else
            {
                MessageBox.Show("El carrito se encuentra vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BBuscar_Click_1(object sender, EventArgs e)
        {
            EncontrarUsuario();
        }
        private void EncontrarUsuario()
        {

            string dniUsuario = TBUsuario.Text;
            if (TBUsuario.Text != "")
            {
                switch (dniUsuario)
                {
                    case "12345678":
                        TBUsuario.Text = "Colman Alexis";
                        TBUsuario.ReadOnly = true;
                        BLimpiar.Visible = true;

                        MessageBox.Show("Usuario encontrado con exito", "Busqueda realizada correcamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "87654321":
                        TBUsuario.Text = "Caballero Federico";
                        TBUsuario.ReadOnly = true;
                        BLimpiar.Visible = true;

                        MessageBox.Show("Usuario encontrado con exito", "Busqueda realizada correcamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TBUsuario.Clear();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Complete el DNI de busqueda", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridProductosParaVenta_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TBCantidad.Text = "1";
            TBProducto.Text = GridProductosParaVenta.CurrentRow.Cells[0].Value.ToString();
            TBDescripcion.Text = GridProductosParaVenta.CurrentRow.Cells[1].Value.ToString();
            TBPrecio.Text = GridProductosParaVenta.CurrentRow.Cells[3].Value.ToString();
            TBCantidad.ReadOnly = false;
        }

        private void TBUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BLimpiar_Click_1(object sender, EventArgs e)
        {
            TBUsuario.Clear();
            BLimpiar.Visible = false;
            TBUsuario.ReadOnly = false;
        }

        private void BCancelarCompra_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBuscarProductoGrid_Click_1(object sender, EventArgs e)
        {
            bool encontrarProducto = false;
            if (TBBuscarProductoGrid.Text != "")
            {

                BLimpiarFiltroGrid.Visible = true;
                BBuscarProductoGrid.Enabled = false;
                string productoBuscado = TBBuscarProductoGrid.Text;

                foreach (DataGridViewRow fila in GridProductosParaVenta.Rows)
                {
                    // Verifica el contenido de la celda en la primera columna (índice 0)
                    if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString().Equals(productoBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        // Si coincide, muestra la fila completa
                        fila.Visible = true;
                        encontrarProducto = true;

                    }
                    else
                    {
                        // Si no coincide, oculta la fila completa
                        fila.Visible = false;

                    }
                }
            }

            if (!encontrarProducto)
            {
                MessageBox.Show("Producto no encontrado en la lista", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscarProductoGrid.Clear();
                BLimpiarFiltroGrid.Visible=false;
                BBuscarProductoGrid.Enabled = true;
                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridProductosParaVenta.Rows)
                {
                    fila.Visible = true;


                }
            }
           
        }

        private void BLimpiarFiltroGrid_Click_1(object sender, EventArgs e)
        {
            BBuscarProductoGrid.Enabled = true;
            BLimpiarFiltroGrid.Visible = false;
            TBBuscarProductoGrid.Clear();
            BBuscarProductoGrid.PerformClick();
        }
    }
}
