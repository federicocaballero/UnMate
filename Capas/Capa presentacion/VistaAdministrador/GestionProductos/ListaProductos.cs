using Microsoft.VisualBasic;
using ProyectoTaller.Capas.Capa_datos.Administrador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionProductos
{
    public partial class ListaProductos : Form
    {
     
        private ClaseListaProductos miClaseProductos;
        public ListaProductos()
        {
            InitializeComponent();

            BGuardarModificacion.Enabled = false;
            BEliminarProducto.Enabled = false;
            BLimpiarFiltros.Visible = false;
            BBorrarListado.Visible = false;
            BRestaurar.Visible = false;
            BEliminarProducto.Visible = false;
           
            MoverText();
            //ajustar imagen al picture box
            PBImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            miClaseProductos = new ClaseListaProductos(TBTitulo, TBStock, TBDetalles, TBPrecio, PBImagen, BRestaurar, BImagen, CBMaterial, CBColorMate, errorProvider1, GridListaProductos, 
            BGuardarModificacion, BLimpiarFiltros, BEliminarProducto, BAñadir, BBorrarListado, TBBuscar, CBProveedor, BBorrarListado, BGuardarModificacion, GridListaProductos, BAñadir,
            BEliminarProducto, BLimpiarFiltros);
        }


        private void BGuardarModificacion_Click_1(object sender, EventArgs e)
        {
            miClaseProductos.GuardarModificacion();
        }

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            miClaseProductos.EliminarProducto();
         
        }

        private void BAñadir_Click(object sender, EventArgs e)
        {
            miClaseProductos.AñadirProducto();
        }
        private void GridListaProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            miClaseProductos.DobleClick();
          
        }

        private void BBorrarListado_Click_1(object sender, EventArgs e)
        {
            miClaseProductos.BorrarListado();
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            miClaseProductos.RestaurarProducto();
        }
        private void ListaProductos_Load_1(object sender, EventArgs e)
        {
            miClaseProductos.MostrarProductos();
            miClaseProductos.ComboProveedores();
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
            miClaseProductos.BotonImagen();
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

        private void MoverText()
        {
            TBTitulo.TabIndex = 0;
            TBDetalles.TabIndex = 1;
            CBMaterial.TabIndex = 2;
            CBColorMate.TabIndex = 3;
            TBStock.TabIndex = 4;
            TBPrecio.TabIndex = 5;
            PBImagen.TabIndex = 6;
            CBProveedor.TabIndex = 7;

        }

        private void GridListaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si se está formateando una celda en la columna 6
            if (e.ColumnIndex == 6 && e.RowIndex >= 0) // Asegúrate de que no sea la fila de encabezado
            {
                // Obtiene el valor de la celda en la columna 6
                object valorCelda = GridListaProductos.Rows[e.RowIndex].Cells[6].Value;

                // Verifica si el valor es igual a 0
                if (valorCelda != null && valorCelda.ToString() == "0")
                {
                    // Cambia el color de fondo de la fila a rojo
                    GridListaProductos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            miClaseProductos.BuscarProducto();
        }
    }
}
