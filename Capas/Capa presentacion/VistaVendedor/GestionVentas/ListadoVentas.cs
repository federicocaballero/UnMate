using ProyectoTaller.Capas.Capa_datos;
using ProyectoTaller.Capas.Capa_datos.Vendedor;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    public partial class ListadoVentas : Form
    {
        private ClaseMisVentas MisVentas;
        public ListadoVentas()
        {
            InitializeComponent();
            MisVentas = new ClaseMisVentas(GridListadoVentas,LEmpleado, LEmpleado);
            
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker changedDateTimePicker = (DateTimePicker)sender;

            try
            {
                // desvincular eventos para evitar bucle infinito
                Tfecha.ValueChanged -= DateTimePicker_ValueChanged;
                THasta.ValueChanged -= DateTimePicker_ValueChanged;

                if (Tfecha.Value > DateTime.Now || THasta.Value < Tfecha.Value)
                {
                    MessageBox.Show("Formato de fecha incorrecto", "Error en fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // restablecer los valores
                    Tfecha.ResetText();
                    THasta.ResetText();
                }

                // volver a vincular eventos
                Tfecha.ValueChanged += DateTimePicker_ValueChanged;
                THasta.ValueChanged += DateTimePicker_ValueChanged;

                // actualizar y volver a cargar solo después de restablecer las fechas
                MisVentas.MostrarMisVentas(Tfecha, THasta);
                MisVentas.TotalRecaudadoVendedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al manejar la fecha: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool detalleCompraAbierto = false;
        private Form DetalleCompraForm = null;
        private int codigoVentaSeleccionado;

        private void GridListadoVentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = GridListadoVentas.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell is DataGridViewButtonCell && cell.Value != null && cell.Value.ToString() == "Ver Detalles")
                {
                    if (!detalleCompraAbierto)
                    {
                        int codigoVentaSeleccionado = (int)GridListadoVentas.Rows[e.RowIndex].Cells["Cod_Venta"].Value;

                        DetalleVenta detalleForm = new DetalleVenta();
                        detalleForm.CodigoVenta = codigoVentaSeleccionado;
                        detalleForm.FormClosed += (s, args) =>
                        {
                            detalleCompraAbierto = false; // Restablece a falso cuando se cierra el formulario
                        };
                        detalleCompraAbierto = true;
                        detalleForm.ShowDialog();
                    }
                }
            }
        }

        //Abir el formulario de registrar una venta
        private bool formularioRegistraVenta = false;
        private Form registrarVentaForm = null;
  
        private void button2_Click_1(object sender, EventArgs e)
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

        private void Tfecha_ValueChanged(object sender, EventArgs e)
        {
            MisVentas.TotalRecaudadoVendedor();
        }

        private void THasta_ValueChanged(object sender, EventArgs e)
        {
            MisVentas.TotalRecaudadoVendedor();
        }

        private void ListadoVentas_Load_1(object sender, EventArgs e)
        {

            // Vincular eventos
            Tfecha.ValueChanged += DateTimePicker_ValueChanged;
            THasta.ValueChanged += DateTimePicker_ValueChanged;

            // Mostrar ventas iniciales
            MisVentas.MostrarMisVentas(Tfecha, THasta);
            MisVentas.TotalRecaudadoVendedor();

            MessageBox.Show("Debe seleccionar una fecha de búsqueda", "Búsqueda por fecha", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }

}

