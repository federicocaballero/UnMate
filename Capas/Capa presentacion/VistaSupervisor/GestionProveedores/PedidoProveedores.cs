using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores
{
    public partial class PedidoProveedores : Form
    {
        public PedidoProveedores()
        {
            InitializeComponent();
            BLimpiarFiltros.Visible = false;
            BBorrarListado.Visible = false;
            BEliminar.Enabled = false;
            BLimpiarProveedor.Visible = false;
            BLimpiarProducto.Visible = false;
        }

        private void TBUnidades_Leave(object sender, EventArgs e)
        {
            if (TBCantidad.Text.Length > 0)
            {
                int total;
                int numero = Convert.ToInt32(TBCantidad.Text);
                total = numero * 100;
                TBImporte.Text = total.ToString() + "$";

            }
        }

        private void TBProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BAñadir_Click(object sender, EventArgs e)
        {
            EliminarProviders();

            if (!String.IsNullOrWhiteSpace(TBProducto.Text) && !String.IsNullOrWhiteSpace(TBDescripcion.Text) && TFecha.Value != null && TBProveedor.Text != ""
                && TBCantidad.Text != "" && TBImporte.Text != "")
            {
                DialogResult result = MessageBox.Show("Estas a punto de agregar un pedido ", "Agregar pedido de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Pedido agregado a la lista", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridPedidos.Rows.Add(TBProducto.Text, TBDescripcion.Text, TBProveedor.Text, TFecha.Text, TBCantidad.Text, TBImporte.Text);
                    BorrarCampos();
                    BLimpiarProveedor.Visible = false;
                    BLimpiarProducto.Visible = false;
                    BBuscarProveedor.Visible = true;
                    BBuscarProducto.Visible = true;
                    TBProveedor.ReadOnly = false;
                    EliminarProviders();
                    quitarEspacios();
                }
                else
                {
                    MessageBox.Show("Inserción cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Debe Completar todos los campos\nVerificar campos marcados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErrorProviders();
            }
        }

        private void BorrarCampos()
        {
            TBImporte.Clear();
            TBDescripcion.Clear();
            TBCantidad.Clear();
            TFecha.ResetText();
            TBProveedor.Clear();
            TBProducto.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TBProducto.Text = GridPedidos.CurrentRow.Cells[0].Value.ToString();
            TBDescripcion.Text = GridPedidos.CurrentRow.Cells[1].Value.ToString();
            TBProveedor.Text = GridPedidos.CurrentRow.Cells[2].Value.ToString();

            if (GridPedidos.CurrentRow.Cells[3].Value is DateTime)
            {
                TFecha.Text = ((DateTime)GridPedidos.CurrentRow.Cells[3].Value).ToString("dd/MM/yyyy");

            }
            TBCantidad.Text = GridPedidos.CurrentRow.Cells[4].Value.ToString();
            TBImporte.Text = GridPedidos.CurrentRow.Cells[5].Value.ToString();
            BloquearTodo();
            BBorrarListado.Visible = true;
            BEliminar.Enabled = true;

            BBuscarProveedor.Visible = false;
            BLimpiarProveedor.Visible = false;

            BLimpiarProducto.Visible = false;
            BBuscarProducto.Visible = false;

            EliminarProviders();
            BAñadir.Enabled = false;
        }

        private void BloquearTodo()
        {
            TBImporte.ReadOnly = true;
            TBDescripcion.Enabled = false;
            TBCantidad.ReadOnly = true;
            TFecha.Enabled = false;
            TBProveedor.ReadOnly = true;
            TBProducto.ReadOnly = true;
        }

        private void DesbloquearTodo()
        {
            TBDescripcion.Enabled = true;
            TBCantidad.ReadOnly = false;
            TFecha.Enabled = true;
            TBProveedor.ReadOnly = false;
            TBProducto.ReadOnly = false;

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (TBProducto.Text != "" && TBDescripcion.Text != "" && TFecha.Text != null && TBProveedor.Text != ""
                && TBCantidad.Text != "" && TBImporte.Text != "")
            {
                DialogResult result = MessageBox.Show("Desea eliminar el pedido?", "Eliminación de pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    GridPedidos.Rows.Remove(GridPedidos.CurrentRow);
                    MessageBox.Show("Eliminación  realizada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BorrarCampos(); BLimpiarFiltros.PerformClick(); BLimpiarFiltros.Visible = false;
                    DesbloquearTodo(); BBorrarListado.Visible = false; BEliminar.Enabled = false;
                    BLimpiarProveedor.Visible = false;
                    BBuscarProveedor.Visible = false;
                    EliminarProviders();
                    BAñadir.Enabled = true;
                    BBuscarProducto.Visible = true;
                    BBuscarProveedor.Visible = true;

                }
                else
                {
                    MessageBox.Show("Eliminación  cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Debe seleccionar un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        private void PedidoProveedores_Load(object sender, EventArgs e)
        {
            GridPedidos.Rows.Add("Mate de Madera", "Necesito que esten guardados en unidades de 4 cajas", "Colman Alexis", "19/09/2023", "90", "672200$");
            GridPedidos.Rows.Add("Mate de Metal", "Necesito que esten guardados en unidades de 9 cajas", "Caballero Federico", "10/12/2023", "88", "61000$");
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if(TBBuscarProveedor.Text == "")
            {
                errorProvider1.SetError(TBBuscarProveedor, "Debe ingresar un nombre");
            }

            if (!String.IsNullOrWhiteSpace(TBBuscarProveedor.Text))
            {
                bool encontrarPedido = false;
                BLimpiarFiltros.Visible = true;
                if (String.IsNullOrWhiteSpace(TBBuscarProveedor.Text) == false)
                {
                    string contenidoDeseado = TBBuscarProveedor.Text; // Contenido que sea desea buscar en la primera columna
                    BLimpiarFiltros.Visible = true;

                    // Recorre todas las filas del DataGridView
                    foreach (DataGridViewRow fila in GridPedidos.Rows)
                    {

                        // Verifica el contenido de la celda en la primera columna (índice 2)
                        if (fila.Cells[2].Value != null && fila.Cells[2].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                        {
                            // Si coincide, muestra la fila completa
                            fila.Visible = true;
                            encontrarPedido = true;
                            errorProvider1.SetError(TBBuscarProveedor, "");
                        }
                        else
                        {
                            // Si no coincide, oculta la fila completa
                            fila.Visible = false;
                            errorProvider1.SetError(TBBuscarProveedor, "");

                        }
                    }

                if (!encontrarPedido)
                {
                    MessageBox.Show("Pedido no encontrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBBuscarProveedor.Clear();
                    foreach (DataGridViewRow fila in GridPedidos.Rows)
                    {
                        BLimpiarFiltros.Visible = false;
                        fila.Visible = true;


                    }
                }
            }
            }
        }

        private void BLimpiarFiltros_Click(object sender, EventArgs e)
        {
            BLimpiarFiltros.Visible = false;
            if (TBBuscarProveedor.Text != "")
            {
                TBBuscarProveedor.Clear();
                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridPedidos.Rows)
                {
                    fila.Visible = true;

                }
            }
        }

        private void BBorrarListado_Click(object sender, EventArgs e)
        {
            EliminarProviders();
            BorrarCampos();
            DesbloquearTodo();
            BBorrarListado.Visible = false;
            BEliminar.Enabled = false;
            TBProveedor.Clear();
            BAñadir.Enabled = true;
            BBuscarProducto.Visible = true;
            BBuscarProveedor.Visible = true;
            errorProvider1.SetError(TBProducto, "");
            errorProvider1.SetError(TBDescripcion, "");
            BLimpiarFiltros.PerformClick();
        }

        private void EncontrarProveedor()
        {
            string dniUsuario = TBProveedor.Text;
            if (TBProveedor.Text != "")
            {
                switch (dniUsuario)
                {
                    case "12345678":
                        TBProveedor.Text = "Colman Alexis";
                        TBProveedor.ReadOnly = true;
                        BLimpiarProveedor.Visible = true;
                        BBuscarProveedor.Visible = false;


                        MessageBox.Show("Proveedor encontrado con exito", "Busqueda realizada correcamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "87654321":
                        TBProveedor.Text = "Caballero Federico";
                        TBProveedor.ReadOnly = true;
                        BLimpiarProveedor.Visible = true;
                        BBuscarProveedor.Visible = false;

                        MessageBox.Show("Proveedor encontrado con exito", "Busqueda realizada correcamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        MessageBox.Show("Proveedor no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TBProveedor.Clear();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Complete el DNI de busqueda", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BBuscarProveedor_Click(object sender, EventArgs e)
        {
            EncontrarProveedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tituloProducto = TBProducto.Text;
            if (TBProducto.Text != "")
            {
                switch (tituloProducto)
                {
                    case "productoA":
                        TBProducto.Text = "Mate de Madera";
                        TBProducto.ReadOnly = true;
                        BLimpiarProducto.Visible = true;
                        BBuscarProducto.Visible = false;
                        break;

                    case "productoB":
                        TBProducto.Text = "Mate de Metal";
                        TBProducto.ReadOnly = true;
                        BLimpiarProducto.Visible = true;
                        BBuscarProducto.Visible = false;
                        break;
                    default:
                        MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TBProducto.Clear();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Complete el campo de busqueda", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void BLimpiarProducto_Click(object sender, EventArgs e)
        {
            TBProducto.Clear();
            BLimpiarProducto.Visible = false;
            TBProducto.ReadOnly = false;
            BBuscarProducto.Visible = true;
            errorProvider1.SetError(TBBuscarProveedor, "");
        }

        private void TBProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ErrorProviders()
        {
            bool PedidoLista = true;

            if (string.IsNullOrWhiteSpace(TBProducto.Text))
            {
                errorProvider1.SetError(TBProducto, "Producto necesario sin espacios en blanco");
                PedidoLista = false;
            }

            if (string.IsNullOrWhiteSpace(TBDescripcion.Text))
            {
                errorProvider1.SetError(TBDescripcion, "Descripcion necesaria y sin espacios en blanco");
                PedidoLista = false;
            }

            if (TBCantidad.Text == "")
            {
                errorProvider1.SetError(TBCantidad, "Cantidad necesaria");
                PedidoLista = false;
            }

            if (TBImporte.Text == "")
            {
                errorProvider1.SetError(TBImporte, "Importe necesario");
                PedidoLista = false;
            }

            if (TBProveedor.Text == "")
            {
                errorProvider1.SetError(TBProveedor, "Proveedor necesario");
                PedidoLista = false;
            }

            if (TFecha.Text == "")
            {
                errorProvider1.SetError(TFecha, "Campo necesario");
                PedidoLista = false;
            }

            return PedidoLista = false;
        }

        private void EliminarProviders()
        {
            errorProvider1.SetError(TBProveedor, "");
            errorProvider1.SetError(TBProducto, "");
            errorProvider1.SetError(TBImporte, "");
            errorProvider1.SetError(TBCantidad, "");
            errorProvider1.SetError(TFecha, "");
            errorProvider1.SetError(TBDescripcion, "");
        }

        private void TBProducto_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TBProducto.Text))
            {
                errorProvider1.SetError(TBProducto, "No se permiten espacios en blanco");
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

        private void quitarEspacios()
        {
            foreach (DataGridViewRow row in GridPedidos.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is string)
                    {
                        // Elimina los espacios en blanco adicionales en la cadena de la celda
                        string gridSinEspacios = string.Join(" ", cell.Value.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                        // Actualiza el valor de la celda
                        cell.Value = gridSinEspacios;
                    }
                }
            }
        }

        private void TBBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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
            TBProveedor.Clear();
            BLimpiarProveedor.Visible = false;
            TBProveedor.ReadOnly = false;
            BBuscarProveedor.Visible = true;
        }
    }
}
