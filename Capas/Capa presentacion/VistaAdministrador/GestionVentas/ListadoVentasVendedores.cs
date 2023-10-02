using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionVentas;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionVentas
{
    public partial class ListadoVentasVendedores : Form
    {
        public ListadoVentasVendedores()
        {
            InitializeComponent();
            BLimpiarFiltros.Visible = false;
        }

        private void ListadoVentasVendedores_Load_1(object sender, EventArgs e)
        {
            GridListadoVendedores.Rows.Add("Jose Rios", "Jose412", "65444213", "Emanuel Gomez", "Emanu211", "11231111", "14/09/2023", "90000$","Detalles");
            GridListadoVendedores.Rows.Add("Lucia Gomez", "lucian211", "322133", "Elias Cardozo", "elias211", "44321234", "10/09/2023", "98250$", "Detalles");
            GridListadoVendedores.Rows.Add("Jose Rios", "Jose412", "65444213", "Martin Guzman", "martingz", "233311121", "2/03/2023", "120000$", "Detalles");
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if(RB1.Checked == true || RB2.Checked == true)
            {
                TBFechaBuscar.Enabled = true;
                bool ventaEncontrada = false;
                if (RB1.Checked == true)
                {
                    if (TBBuscar.Text != "")
                    {
                        BLimpiarFiltros.Visible = true;
                        TBFechaBuscar.Enabled = false;
                        string contenidoDeseado = TBBuscar.Text; // Contenido que  se desea buscar en la primera columna

                        // Recorre todas las filas del DataGridView
                        foreach (DataGridViewRow fila in GridListadoVendedores.Rows)
                        {
                            // Verifica el contenido de la celda en la primera columna (índice 1)
                            if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                            {
                                // Si coincide, muestra la fila completa
                                fila.Visible = true;
                                TBFechaBuscar.Enabled = false;
                                ventaEncontrada = true;
                            }
                            else
                            {
                                // Si no coincide, oculta la fila completa
                                fila.Visible = false;

                            }
                        }
                    }
                    if (!ventaEncontrada)
                    {
                        MessageBox.Show("Vendedor no encontrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TBBuscar.Clear();
                        BLimpiarFiltros.Visible = false;
                        TBFechaBuscar.Enabled = true;
                        // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                        foreach (DataGridViewRow fila in GridListadoVendedores.Rows)
                        {
                            fila.Visible = true;
                            RB2.Checked = false;
                            RB1.Checked = false;
                        }
                    }

                }
                else if (RB2.Checked == true)
                {
                    if (TBBuscar.Text != "")
                    {
                        BLimpiarFiltros.Visible = true;
                        TBFechaBuscar.Enabled = false;
                        string contenidoDeseado = TBBuscar.Text; // Contenido que deseas buscar en la primera columna

                        // Recorre todas las filas del DataGridView
                        foreach (DataGridViewRow fila in GridListadoVendedores.Rows)
                        {
                            // Verifica el contenido de la celda en la primera columna (índice 0)
                            if (fila.Cells[2].Value != null && fila.Cells[2].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                            {
                                // Si coincide, muestra la fila completa
                                fila.Visible = true;
                                TBFechaBuscar.Enabled = false;
                                ventaEncontrada = true;
                            }
                            else
                            {
                                // Si no coincide, oculta la fila completa
                                fila.Visible = false;
                            }
                        }
                    }
                    if (!ventaEncontrada)
                    {
                        MessageBox.Show("Vendedor no encontrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TBBuscar.Clear();
                        BLimpiarFiltros.Visible = false;
                        TBFechaBuscar.Enabled = true;
                        // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                        foreach (DataGridViewRow fila in GridListadoVendedores.Rows)
                        {
                            fila.Visible = true;
                            RB2.Checked = false;
                            RB1.Checked = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un formato de busqueda", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        //Abrir el detlale de una venta
        private bool detalleCompraAbierto = false;
        private Form DetalleCompraForm = null;
        private void GridListadoVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridListadoVendedores.Columns[e.ColumnIndex].Name == "detalles" && detalleCompraAbierto == false)
            {
                
                DetalleCompraForm = new DetalleDeVenta();

                //al cerrar el formulario
                DetalleCompraForm.FormClosed += (s, args) =>
                {
                    detalleCompraAbierto = false; // Restablece a falso cuando se cierra el formulario
                };

                DetalleCompraForm.Show();
                detalleCompraAbierto = true;
            }
        }

        private void TBFechaBuscar_Validating(object sender, CancelEventArgs e)
        {
            if (TBFechaBuscar.Text != "")
            {
                TextBox textBox = (TextBox)sender;
                string fechaTexto = textBox.Text.Trim();

                // Intentar analizar la fecha en el formato deseado (por ejemplo, "dd/MM/yyyy")
                DateTime fecha;
                if (!DateTime.TryParseExact(fechaTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
                { 
                    MessageBox.Show("El formato de fecha ingresado no es válido. Use el formato dd/MM/yyyy.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBFechaBuscar.Clear();
                    textBox.Focus();
                    e.Cancel = true; // Cancelar el evento para evitar que el TextBox pierda el foco
                }
            }
        }

        private void BLimpiarFiltros_Click(object sender, EventArgs e)
        {
            BLimpiarFiltros.Visible = false;
            if (TBBuscar.Text != null || TBFechaBuscar.Text != null)
            {
                RB1.Checked = false;
                RB2.Checked = false;
                TBBuscar.Clear();
                TBFechaBuscar.Clear();
                TBFechaBuscar.Enabled = true;
                TBBuscar.Enabled = true;

                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridListadoVendedores.Rows)
                {
                    fila.Visible = true;

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(TBFechaBuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar una fecha","Error de busqueda",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string contenidoDeseado = TBFechaBuscar.Text; // Contenido que deseas buscar en la primera columna
            bool fechaEncontrada = false;
            TBBuscar.Enabled = true;
            if (TBFechaBuscar.Text != "")
            {
                BLimpiarFiltros.Visible = true;
                TBBuscar.Enabled = false;

                // Recorre todas las filas del DataGridView
                foreach (DataGridViewRow fila in GridListadoVendedores.Rows)
                {
                    // Verifica el contenido de la celda en la primera columna (índice 6)
                    if (fila.Cells[6].Value != null && fila.Cells[6].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                    {
                        // Si coincide, muestra la fila completa
                        fila.Visible = true;
                        fechaEncontrada = true;

                    }
                    else
                    {
                        // Si no coincide, oculta la fila completa
                        fila.Visible = false;


                    }
                }
            

            if (!fechaEncontrada)
            {
                MessageBox.Show("No existen compras en esa fecha", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscar.Enabled = true;
                BLimpiarFiltros.Visible = false;
                TBFechaBuscar.Clear();
                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridListadoVendedores.Rows)
                {
                    fila.Visible = true;

                }
            }

            }
        }

        private void TBFechaBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
