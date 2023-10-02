using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    public partial class ListadoProducto : Form
    {
        public ListadoProducto()
        {
            InitializeComponent();
            BEliminarFiltro.Visible = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    
        private void ListadoProducto_Load(object sender, EventArgs e)
        {
            System.Drawing.Image image = Properties.Resources.mate_imperial;
            System.Drawing.Image image2 = Properties.Resources.mate_negro;
            System.Drawing.Image image3 = Properties.Resources.mate_acero;

            DGCatalogo.Rows.Add("mate imperial", "bombilla de alta calidad y diseño, pico de loro.\r\n\r\n*cuero 100% vacuno excelentes terminaciones.\r\n\r\n*base de 4 patas firmes.\r\n\r\n*virola de alpaca labrada.", "15000", "SI", image, "22", "madera");
            DGCatalogo.Rows.Add("mate imperial", "bombilla de alta calidad y diseño, pico de loro.\r\n\r\n*cuero 100% vacuno excelentes terminaciones.\r\n\r\n*base de 4 patas firmes.\r\n\r\n*virola de alpaca labrada.", "15000", "SI", image, "11", "calabaza");
            DGCatalogo.Rows.Add("mate torpedo", "calabaza brasileña de selección especial\r\n- virola de aluminio pulida espejo\r\n- forrado en cuero vacuno legítimo natural\r\n- producto 100% artesanal\r\n- costura fina con técnicas especiales\r\n- base reforzada de 4 patas firme", "5000", "SI", image2, "2", "caña");
            DGCatalogo.Rows.Add("mate camionero", "nuestro mate de calabaza insignia. hermoso, desde la base a la virola.\r\n\r\n·la máxima expresión del amor aplicado al trabajo artesanal del mate.\r\n·el mate camionero recibe su denominación, por ser un mate muy utilizado por los conductores ya que es ideal para distintos terrenos.", "8000", "SI", image2, "33", "cuero");
            DGCatalogo.Rows.Add("mate de acero", "• capacidad 236 ml\r\n• apto frio calor\r\n• ideal para terere y mate\r\n• libre de bpa\r\n• autorizado por el inal\r\n• boca ancha\r\n• cuenta con una cámara de aire de acero inoxidable 304 ss que mantiene la\r\ntemperatura dentro del recipiente en perfecto estado.", "4000", "SI", image3, "4", "madera");
            DGCatalogo.Rows.Add("mate torpedo", "calabaza brasileña de selección especial\r\n- virola de aluminio pulida espejo\r\n- forrado en cuero vacuno legítimo natural\r\n- producto 100% artesanal\r\n- costura fina con técnicas especiales\r\n- base reforzada de 4 patas firme", "5000", "SI", image2, "7", "calabaza");
            DGCatalogo.Rows.Add("mate camionero", "nuestro mate de calabaza insignia. hermoso, desde la base a la virola.\r\n\r\n·la máxima expresión del amor aplicado al trabajo artesanal del mate.\r\n·el mate camionero recibe su denominación, por ser un mate muy utilizado por los conductores ya que es ideal para distintos terrenos.", "8000", "SI", image2, "3", "madera");
            DGCatalogo.Rows.Add("mate de acero", "• capacidad 236 ml\r\n• apto frio calor\r\n• ideal para terere y mate\r\n• libre de bpa\r\n• autorizado por el inal\r\n• boca ancha\r\n• cuenta con una cámara de aire de acero inoxidable 304 ss que mantiene la\r\ntemperatura dentro del recipiente en perfecto estado.", "4000", "SI", image3, "21", "cuero");
        }

        private void BEliminarFiltro_Click(object sender, EventArgs e)
        {
   
            BEliminarFiltro.Visible = false;
            TBBuscar.Clear();
            BBuscarFiltro.Visible = true;
     
        }

        private void TBBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BBuscarFiltro_Click(object sender, EventArgs e)
        {

            if(TBBuscar.Text == "")
            {
                errorProvider1.SetError(TBBuscar, "Debe ingresar el nombre del producto");
            }

            bool productoEncontrado = false;
            if ( !string.IsNullOrWhiteSpace(TBBuscar.Text))
            {
                BBuscarFiltro.Visible = false;
                BEliminarFiltro.Visible = true;
                string contenidoDeseado = TBBuscar.Text; // Contenido que deseas buscar 

                // Recorre todas las filas del DataGridView
                foreach (DataGridViewRow fila in DGCatalogo.Rows)
                {
                    // Verifica el contenido de la celda en la primera columna (índice 0)
                    if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                    {
                        // Si coincide, muestra la fila completa
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
                BEliminarFiltro.Visible = false;
                BBuscarFiltro.Visible = true;
                MessageBox.Show("Producto no encontrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscar.Clear();
                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in DGCatalogo.Rows)
                {
                    fila.Visible = true;

                }
               }
            }
        }

        private void DGCatalogo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
              //Obtengo la imagen de la celda
            System.Drawing.Image image = DGCatalogo.CurrentRow.Cells[4].Value as System.Drawing.Image;
            pictureBox1.Image = image;
            LTexto.Text = string.Empty;
            TBNombre.Text = DGCatalogo.CurrentRow.Cells[0].Value.ToString();
            TBPrecio.Text = DGCatalogo.CurrentRow.Cells[2].Value.ToString();
            TBDescripcion.Text = DGCatalogo.CurrentRow.Cells[1].Value.ToString();
            TBDisponible.Text = DGCatalogo.CurrentRow.Cells[3].Value.ToString();
            TBCantidad.Text = DGCatalogo.CurrentRow.Cells[5].Value.ToString();
            TBCategoria.Text = DGCatalogo.CurrentRow.Cells[6].Value.ToString();
        }
    }
}

