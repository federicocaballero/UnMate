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


namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    public partial class ListadoVentas : Form
    {
        public ListadoVentas()
        {
            InitializeComponent();
            BLimpiarFiltros.Visible = false;

        }

        public void TotalRecaudadoVendedor()
        {
            decimal suma = 0.0m;
            foreach (DataGridViewRow row in GridListadoVentas.Rows)
            {
                suma += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            TBTotalRecaudo.Text = suma.ToString() + "$";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TBBuscar.Enabled = true;
            bool buscarVenta = false;
            string contenidoDeseado = TBFechaBuscar.Text; // Contenido que deseas buscar en la primera columna
            if (TBFechaBuscar.Text != "")
            {
                BLimpiarFiltros.Visible = true;
                TBBuscar.Enabled = false;
                // Recorre todas las filas del DataGridView
                foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                {
                    // Verifica el contenido de la celda en la primera columna (índice 0)
                    if (fila.Cells[4].Value != null && fila.Cells[4].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                    {
                        // Si coincide, muestra la fila completa
                        fila.Visible = true;
                        buscarVenta = true;
                    }
                    else
                    {
                        // Si no coincide, oculta la fila completa
                        fila.Visible = false;

                    }
                }
            }
            if (!buscarVenta)
            {
                MessageBox.Show("No existen ventas en la fecha solicitada", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBFechaBuscar.Clear();
                BLimpiarFiltros.Visible = false;
                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                {
                    fila.Visible = true;

                }
            }

        }

        private void ListadoVentas_Load(object sender, EventArgs e)
        {
            GridListadoVentas.Rows.Add("1", "sedcol", "42986296", "Mate de acero x2 \r\nMate de cuero formoseño x2\r\nMate de acero x2 \r\nMate de cuero formoseño x2\r\n", "15/09/2023", "5400", "Transferencia","Detalles");
            GridListadoVentas.Rows.Add("2", "fedr2", "31245212", "Mate de acero x82 \r\nMate de cuero formoseño x1", "9/09/2023", "5400,64", "Mercado Pago", "Detalles");
            GridListadoVentas.Rows.Add("3", "lucia2111", "21332156", "Mate de caña negro", "1/06/2023", "5800,22", "Mercado Pago", "Detalles");
            GridListadoVentas.Rows.Add("4", "mati311", "21332156", "Mate de caña negro", "1/12/2023", "5200,21", "Mercado Pago", "Detalles");
            TotalRecaudadoVendedor();
        }

        private void BBuscar_Click_1(object sender, EventArgs e)
        {
            bool buscarVenta = false;
            TBFechaBuscar.Enabled = true;
            if (RB1.Checked == true)
            {
                if (TBBuscar.Text != "")
                {
                    TBFechaBuscar.Enabled = false;
                    BLimpiarFiltros.Visible = true;
                    string contenidoDeseado = TBBuscar.Text; // Contenido que deseas buscar en la primera columna

                    // Recorre todas las filas del DataGridView
                    foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                    {
                        // Verifica el contenido de la celda en la primera columna (índice 0)
                        if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                        {
                            // Si coincide, muestra la fila completa
                            fila.Visible = true;
                            buscarVenta = true;
                        }
                        else
                        {
                            // Si no coincide, oculta la fila completa
                            fila.Visible = false;


                        }
                    }
                }

                if (!buscarVenta)
                {
                    TBBuscar.Clear();
                    BLimpiarFiltros.Visible = false;
                    MessageBox.Show("Venta no encontrada", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                    foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                    {
                        fila.Visible = true;
                        RB1.Checked = false;
                        RB2.Checked = false;
                        RB3.Checked = false;

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
                    foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                    {
                        // Verifica el contenido de la celda en la primera columna (índice 0)
                        if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                        {
                            // Si coincide, muestra la fila completa
                            fila.Visible = true;
                            buscarVenta = true;
                        }
                        else
                        {
                            // Si no coincide, oculta la fila completa
                            fila.Visible = false;
                        }
                    }
                }
                if (!buscarVenta)
                {
                    TBBuscar.Clear();
                    BLimpiarFiltros.Visible = false;
                    MessageBox.Show("Venta no encontrada", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                    foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                    {
                        fila.Visible = true;
                        RB1.Checked = false;
                        RB2.Checked = false;
                        RB3.Checked = false;

                    }
                }

            }
            else if (RB3.Checked == true)
            {
                if (TBBuscar.Text != "")
                {
                    BLimpiarFiltros.Visible = true;
                    TBFechaBuscar.Enabled = false;
                    string contenidoDeseado = TBBuscar.Text; // Contenido que deseas buscar en la primera columna

                    // Recorre todas las filas del DataGridView
                    foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                    {
                        // Verifica el contenido de la celda en la primera columna (índice 0)
                        if (fila.Cells[2].Value != null && fila.Cells[2].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                        {
                            // Si coincide, muestra la fila completa
                            fila.Visible = true;
                            buscarVenta = true;
                        }
                        else
                        {
                            // Si no coincide, oculta la fila completa
                            fila.Visible = false;
                        }
                    }
                }
                if (!buscarVenta)
                {
                    TBBuscar.Clear();
                    BLimpiarFiltros.Visible = false;
                    MessageBox.Show("Venta no encontrada", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                    foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                    {
                        fila.Visible = true;
                        RB1.Checked = false;
                        RB2.Checked = false;
                        RB3.Checked = false;

                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TBFechaBuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar una fecha", "Error en la busqueda",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            TBBuscar.Enabled = true;
            bool buscarVenta = false;
            string contenidoDeseado = TBFechaBuscar.Text; // Contenido que deseas buscar en la primera columna
            if (TBFechaBuscar.Text != "")
            {
                BLimpiarFiltros.Visible = true;
                TBBuscar.Enabled = false;
                // Recorre todas las filas del DataGridView
                foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                {
                    // Verifica el contenido de la celda en la primera columna (índice 0)
                    if (fila.Cells[4].Value != null && fila.Cells[4].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                    {
                        // Si coincide, muestra la fila completa
                        fila.Visible = true;
                        buscarVenta = true;
                    }
                    else
                    {
                        // Si no coincide, oculta la fila completa
                        fila.Visible = false;

                    }
                }
           
            if (!buscarVenta)
            {
                MessageBox.Show("No existen ventas en la fecha solicitada", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBBuscar.Enabled = true;
                TBFechaBuscar.Clear();
                BLimpiarFiltros.Visible = false;
                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                {
                    fila.Visible = true;

                }
                }
            }
        }

        private void TBFechaBuscar_Validating_1(object sender, CancelEventArgs e)
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
                    textBox.Focus();
                    TBFechaBuscar.Clear();
                    e.Cancel = true; // Cancelar el evento para evitar que el TextBox pierda el foco
                }
            }
        }

        private void BLimpiarFiltros_Click_1(object sender, EventArgs e)
        {
            BLimpiarFiltros.Visible = false;

            if (TBBuscar.Text != null || TBFechaBuscar.Text != null)
            {
                RB1.Checked = false;
                RB2.Checked = false;
                RB3.Checked = false;
                TBBuscar.Clear();
                TBFechaBuscar.Clear();
                TBFechaBuscar.Enabled = true;
                TBBuscar.Enabled = true;

                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridListadoVentas.Rows)
                {
                    fila.Visible = true;

                }
            }
        }

        private void TBFechaBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private bool detalleCompraAbierto = false;
        private Form DetalleCompraForm = null;
        
            private void GridListadoVentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (GridListadoVentas.Columns[e.ColumnIndex].Name == "detalles" && detalleCompraAbierto == false)
            {
                DetalleCompraForm = new DetalleCompra();
                DetalleCompraForm = new DetalleCompra();

                //al cerrar el formulario
                DetalleCompraForm.FormClosed += (s, args) =>
                {
                    detalleCompraAbierto = false; // Restablece a falso cuando se cierra el formulario
                };

                DetalleCompraForm.Show();
                detalleCompraAbierto = true;
            }
        }

        //Abir el formulario de registrar una venta
        private bool formularioRegistraVenta = false;
        private Form registrarVentaForm = null;
        private void button2_Click(object sender, EventArgs e)
        {
            if (formularioRegistraVenta == false)
            {
                registrarVentaForm = new RegistrarVenta();

                //al cerrar el formulario
                registrarVentaForm.FormClosed += (s, args) =>
                {
                    formularioRegistraVenta = false; // Restablece a falso cuando se cierra el formulario
                };

                registrarVentaForm.Show();
                formularioRegistraVenta = true;
            }
        }
    }

}

