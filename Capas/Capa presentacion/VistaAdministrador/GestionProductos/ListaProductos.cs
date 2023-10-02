using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionProductos
{
    public partial class ListaProductos : Form
    {
        public ListaProductos()
        {
            InitializeComponent();

            BGuardarModificacion.Enabled = false;
            BEliminarProducto.Enabled = false;
            BLimpiarFiltros.Visible = false;
            BBorrarListado.Visible = false;

            //ajustar imagen al picture box
            PBImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BorrarTodo()
        {
            TBTitulo.Clear();
            TBStock.Clear();
            TBDetalles.Clear();
            TBPrecio.Clear();
            PBImagen.Image = null;
            CBMaterial.SelectedItem = null;
            CBColorMate.SelectedItem = null;
            TBBuscar.Clear();
        }



        private void TextoDesbloqueado()
        {
            TBTitulo.ReadOnly = false;
            TBDetalles.ReadOnly = false;
            TBPrecio.ReadOnly = false;
            TBStock.ReadOnly = false;
        }

        //TODO LO QUE SIGUE ES PARA LOS ERRORES PROVIDERS
        //TODO LO QUE SIGUE ES PARA LOS ERRORES PROVIDERS
        //TODO LO QUE SIGUE ES PARA LOS ERRORES PROVIDERS
        private bool ErroresProviders()
        {
            bool productoCorrecto = true;

            if (string.IsNullOrWhiteSpace(TBDetalles.Text))
            {
                errorProvider1.SetError(TBDetalles, "Detalles obligatorios y sin espacios en blanco");
                productoCorrecto = false;
            }

            if (TBPrecio.Text == "")
            {
                errorProvider1.SetError(TBPrecio, "Precio obligatorio");
                productoCorrecto = false;
            }

            if (string.IsNullOrWhiteSpace(TBTitulo.Text))
            {
                errorProvider1.SetError(TBTitulo, "Titulo obligatorio");
                productoCorrecto = false;
            }

            if (TBStock.Text == "")
            {
                errorProvider1.SetError(TBStock, "Stock necesario");
                productoCorrecto = false;
            }

            if (CBColorMate.SelectedItem == null)
            {
                errorProvider1.SetError(CBColorMate, "Categoria necesaria");
                productoCorrecto = false;
            }

            if (CBMaterial.SelectedItem == null)
            {
                errorProvider1.SetError(CBMaterial, "Categoria necesaria");
                productoCorrecto = false;
            }

            if (PBImagen.Image == null)
            {
                errorProvider1.SetError(PBImagen, "Imangen necesaria");
                productoCorrecto = false;
            }


            return productoCorrecto;
        }

        private void BorrarErroresProviders()
        {
            errorProvider1.SetError(PBImagen, "");
            errorProvider1.SetError(TBStock, "");
            errorProvider1.SetError(TBTitulo, "");
            errorProvider1.SetError(TBDetalles, "");
            errorProvider1.SetError(CBMaterial, "");
            errorProvider1.SetError(CBColorMate, "");
            errorProvider1.SetError(TBPrecio, "");
            errorProvider1.SetError(PBImagen, "");
        }

        //quitar los espacios en blanco de la tabla 
        private void quitarEspacios()
        {
            foreach (DataGridViewRow row in GridListaProductos.Rows)
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

        private void BBorrarListado_Click(object sender, EventArgs e)
        {
            BBorrarListado.Visible = false;
            BorrarErroresProviders();
            BorrarTodo();
            errorProvider1.SetError(TBTitulo, "");
            errorProvider1.SetError(TBDetalles, "");
            BGuardarModificacion.Enabled = false;
            BEliminarProducto.Enabled = false;
            BAñadir.Enabled = true;
        }

        private void BGuardarModificacion_Click_1(object sender, EventArgs e)
        {
            BorrarErroresProviders();
            if (!string.IsNullOrWhiteSpace(TBTitulo.Text) && !string.IsNullOrWhiteSpace(TBDetalles.Text) && CBColorMate.SelectedItem != null && !string.IsNullOrWhiteSpace(TBPrecio.Text) &&
            !string.IsNullOrWhiteSpace(TBStock.Text) && PBImagen.Image != null && CBMaterial.SelectedItem != null)

            {
                DialogResult result = MessageBox.Show("Estas a punto de modificar un producto", "Modificar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Producto modificado", "Tarea completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridListaProductos.CurrentRow.Cells[0].Value = TBTitulo.Text;
                    GridListaProductos.CurrentRow.Cells[1].Value = TBDetalles.Text;
                    GridListaProductos.CurrentRow.Cells[2].Value = CBColorMate.Text;
                    GridListaProductos.CurrentRow.Cells[3].Value = TBPrecio.Text;
                    GridListaProductos.CurrentRow.Cells[4].Value = TBStock.Text;

                    GridListaProductos.CurrentRow.Cells[5].Value = PBImagen.Image;
                    System.Drawing.Image imagen = GridListaProductos.CurrentRow.Cells[5].Value as System.Drawing.Image;
                    PBImagen.Image = imagen;
                    GridListaProductos.CurrentRow.Cells[6].Value = CBMaterial.Text;

                    quitarEspacios();
                    BorrarTodo(); BLimpiarFiltros.PerformClick(); BLimpiarFiltros.Visible = false;
                    BGuardarModificacion.Enabled = false;
                    BEliminarProducto.Enabled = false;

                    BAñadir.Enabled = true;
                    BorrarErroresProviders();
                    BBorrarListado.Visible = false;
                }
                else
                {
                    MessageBox.Show("Modificacion  de producto cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos vacios o espacios en blanco\r\nPor favor revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            BorrarErroresProviders();

            if (!string.IsNullOrWhiteSpace(TBTitulo.Text) && !string.IsNullOrWhiteSpace(TBDetalles.Text) && CBColorMate.SelectedItem != null && !string.IsNullOrWhiteSpace(TBPrecio.Text) &&
            !string.IsNullOrWhiteSpace(TBStock.Text) && PBImagen.Image != null && CBMaterial.SelectedItem != null && ErroresProviders())
            {
                DialogResult result = MessageBox.Show("Desea eliminar el producto?", "Eliminación de usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    GridListaProductos.Rows.Remove(GridListaProductos.CurrentRow);
                    TBBuscar.Text = "";
                    MessageBox.Show("Eliminación de producto realizada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BorrarTodo(); BLimpiarFiltros.Visible = false;
                    BGuardarModificacion.Enabled = false;
                    BEliminarProducto.Enabled = false;
                    BAñadir.Enabled = true;
                    BorrarErroresProviders();
                    BBorrarListado.Visible = false;

                }
                else
                {
                    MessageBox.Show("Eliminación  cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos vacios o espacios en blanco\r\nPor favor revisar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void BAñadir_Click(object sender, EventArgs e)
        {
            BorrarErroresProviders();

            if (!string.IsNullOrWhiteSpace(TBTitulo.Text) && !string.IsNullOrWhiteSpace(TBDetalles.Text) && CBColorMate.SelectedItem != null && !string.IsNullOrWhiteSpace(TBPrecio.Text) &&
            !string.IsNullOrWhiteSpace(TBStock.Text) && PBImagen.Image != null && CBMaterial.SelectedItem != null && ErroresProviders())
            {

                DialogResult result = MessageBox.Show("Estas a punto de agregar un producto", "Agregar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Producto añadido correcamente", "Añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Image imagen = PBImagen.Image;
                    GridListaProductos.Rows.Add(TBTitulo.Text, TBDetalles.Text, CBColorMate.Text, TBPrecio.Text + "$", TBStock.Text, imagen, CBMaterial.Text);
                    quitarEspacios();

                    BorrarTodo(); BLimpiarFiltros.Visible = false;
                    BorrarErroresProviders();
                }
                else
                {
                    MessageBox.Show("Inserción de producto cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campos vacios o espacios en blanco\r\nPor favor revisar los iconos en rojo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void TBTitulo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBDetalles_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBStock_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofdSleccionarFoto = new OpenFileDialog();
            ofdSleccionarFoto.Filter = "Imagenes|*.jpg; *.png; *.jpeg; *.gif";
            ofdSleccionarFoto.Title = "Seleccionar Foto de Producto";

            if (ofdSleccionarFoto.ShowDialog() == DialogResult.OK)
            {
                PBImagen.BackgroundImage = null;
                PBImagen.Image = Image.FromFile(ofdSleccionarFoto.FileName);

            }
        }

        private void TBTitulo_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBTitulo.Text))
            {
                errorProvider1.SetError(TBTitulo, "No se permiten espacios en blanco");
            }
            else
            {
                errorProvider1.SetError(TBTitulo, "");
            }
        }

        private void TBDetalles_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDetalles.Text))
            {
                errorProvider1.SetError(TBDetalles, "No se permiten espacios en blanco");
            }
            else
            {
                errorProvider1.SetError(TBDetalles, "");
            }
        }

        private void ListaProductos_Load_1(object sender, EventArgs e)
        {
            // Obtener la imagen desde los recursos del proyecto
            Image image = Properties.Resources.mate_imperial;
            Image image1 = Properties.Resources.mate_acero;
            Image image2 = Properties.Resources.mate_negro;
  

            GridListaProductos.Rows.Add("Mate alpaca", "Fabricado en corrientes", "Marron", "300$", "55", image, "Madera");
            GridListaProductos.Rows.Add("Mate de madera", "Fabricado en corrientes", "Negro", "100$", "55", image1, "Calabaza");
            GridListaProductos.Rows.Add("Mate correntino", "Fabricado en corrientes", "Negro", "300$", "55", image2, "Cuero");
            GridListaProductos.Rows.Add("Mate misionero", "Fabricado en corrientes", "Gris", "100$", "55", image1, "Madera");
            GridListaProductos.Rows.Add("Mate de metal", "Fabricado en corrientes", "Marron", "300$", "55", image, "Caña");
            GridListaProductos.Rows.Add("Mate alpaca y metal", "Fabricado en corrientes", "Negro", "300$", "55", image2, "Madera");
        }

        private void BLimpiarFiltros_Click_1(object sender, EventArgs e)
        {
            BLimpiarFiltros.Visible = false;
            if (TBBuscar.Text != null)
            {

                TBBuscar.Clear();
                TBBuscar.Enabled = true;
                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridListaProductos.Rows)
                {
                    fila.Visible = true;

                }
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if(TBBuscar.Text == "")
            {
                errorProvider1.SetError(TBBuscar, "Debe ingresar el nombre del producto")
;            }

            string contenidoDeseado = TBBuscar.Text; // Contenido que deseas buscar en la primera columna
            bool productoEncontrado = false;

            //verifica que no este vacio
            if (TBBuscar.Text != "")
            {
                BLimpiarFiltros.Visible = true;
                // Recorre todas las filas del GridListaUsuarios
                foreach (DataGridViewRow fila in GridListaProductos.Rows)
                {
                    // Verifica el contenido de la celda en la primera columna (índice 4)
                    if (string.IsNullOrEmpty(contenidoDeseado) ||
                        (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase)))
                    {
                        // Si coincide con el texto de búsqueda o no hay texto de búsqueda, muestra la fila completa
                        fila.Visible = true;
                        productoEncontrado = true;
                        errorProvider1.SetError(TBBuscar, "");
                    }
                    else
                    {

                        // Si no coincide, oculta la fila completa
                        fila.Visible = false;
                        errorProvider1.SetError(TBBuscar, "");

                    }
                }

                if (!productoEncontrado)
                {
                    MessageBox.Show("Producto no encontrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBBuscar.Clear();
                    BLimpiarFiltros.Visible = false;
                    //mostrar todas las filas
                    foreach (DataGridViewRow fila in GridListaProductos.Rows)
                    {
                        fila.Visible = true;

                    }
                }
            }
        }

        private void GridListaProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TBTitulo.Text = GridListaProductos.CurrentRow.Cells[0].Value.ToString();
            TBDetalles.Text = GridListaProductos.CurrentRow.Cells[1].Value.ToString();
            CBColorMate.Text = GridListaProductos.CurrentRow.Cells[2].Value.ToString();
            TBPrecio.Text = GridListaProductos.CurrentRow.Cells[3].Value.ToString();
            TBStock.Text = GridListaProductos.CurrentRow.Cells[4].Value.ToString();
            System.Drawing.Image image = GridListaProductos.CurrentRow.Cells[5].Value as System.Drawing.Image;
            PBImagen.Image = image;
            CBMaterial.Text = GridListaProductos.CurrentRow.Cells[6].Value.ToString();
            TextoDesbloqueado();
            BGuardarModificacion.Enabled = true;
            BEliminarProducto.Enabled = true;
            BorrarErroresProviders();
            BAñadir.Enabled = false;
            BBorrarListado.Visible = true;
        }

        private void BBorrarListado_Click_1(object sender, EventArgs e)
        {
            BBorrarListado.Visible = false;
            BorrarErroresProviders();
            BorrarTodo();
            errorProvider1.SetError(TBTitulo, "");
            errorProvider1.SetError(TBDetalles, "");
            BGuardarModificacion.Enabled = false;
            BEliminarProducto.Enabled = false;
            BAñadir.Enabled = true;
        }

        private void TBBuscar_Click(object sender, EventArgs e)
        {
       
        }
    }
}
