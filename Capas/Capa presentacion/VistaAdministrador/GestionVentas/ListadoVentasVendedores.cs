using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller.Capas.Capa_datos;
using ProyectoTaller.Capas.Capa_datos.Administrador;
using ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionVentas;
using ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionVentas
{
    public partial class ListadoVentasVendedores : Form
    {

        private ClaseListaDeVentas VentasVendedor;

        public ListadoVentasVendedores()
        {
            InitializeComponent();
            VentasVendedor = new ClaseListaDeVentas(GridListadoVendedores, LTotalRecaudado);
        }

        private void ListadoVentasVendedores_Load_1(object sender, EventArgs e)
        {
            Tfecha.ValueChanged += DateTimePicker_ValueChanged;
            THasta.ValueChanged += DateTimePicker_ValueChanged;

            // Llama a MostrarMisVentas con las fechas iniciales
            VentasVendedor.MostrarTodasLasVentas(Tfecha, THasta);
            VentasVendedor.TotalRecaudadoVendedores();
            MessageBox.Show("Debe seleccionar una fecha de busqueda", "Busqueda por fecha", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker changedDateTimePicker = (DateTimePicker)sender;
            if (Tfecha.Value > DateTime.Now || THasta.Value < Tfecha.Value)
            {
                MessageBox.Show("Formato de fecha incorrecto", "Error en fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tfecha.ValueChanged -= DateTimePicker_ValueChanged;
                THasta.ValueChanged -= DateTimePicker_ValueChanged;

                Tfecha.ResetText();
                THasta.ResetText();

                Tfecha.ValueChanged += DateTimePicker_ValueChanged;
                THasta.ValueChanged += DateTimePicker_ValueChanged;

                VentasVendedor.MostrarTodasLasVentas(Tfecha, THasta);
               
            }
            else
            {

            if (changedDateTimePicker == Tfecha || changedDateTimePicker == THasta)
            {
                VentasVendedor.MostrarTodasLasVentas(Tfecha, THasta);
                VentasVendedor.TotalRecaudadoVendedores();
            }
            }
        }


        private bool detalleCompraAbierto = false;
        private Form DetalleCompraForm = null;
        private int codigoVentaSeleccionado;

        private void GridListadoVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = GridListadoVendedores.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell is DataGridViewButtonCell && cell.Value != null && cell.Value.ToString() == "Ver Detalles")
                {
                    if (!detalleCompraAbierto)
                    {
                        int codigoVentaSeleccionado = (int)GridListadoVendedores.Rows[e.RowIndex].Cells["Cod_Venta"].Value;

                        DetalleVenta detalleForm = new DetalleVenta();
                        detalleForm.CodigoVenta = codigoVentaSeleccionado;
                        detalleForm.FormClosed += (s, args) =>
                        {
                            detalleCompraAbierto = false; // restablece a falso cuando se cierra el formulario
                        };
                        detalleCompraAbierto = true;
                        detalleForm.ShowDialog();
                    }
                }
            }
        }

    }
}
