using ProyectoTaller.Capas.Capa_datos.Administrador;
using ProyectoTaller.Capas.Capa_datos.Supervisor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.Estadisticas
{
    public partial class EstadisticasObtenidas : Form
    {
        private ClaseEstadisticas Estadisticas;
        public EstadisticasObtenidas()
        {
            InitializeComponent();
            Estadisticas = new ClaseEstadisticas(GridCompras, CVendedores , CProductos);
            Estadisticas.TopCompras();
        }

        private void EstadisticasObtenidas_Load(object sender, EventArgs e)
        {
            TFecha.ValueChanged += DateTimePicker_ValueChanged;
            THasta.ValueChanged += DateTimePicker_ValueChanged;
            Estadisticas.MostrarTopVendedores(TFecha,THasta);
            Estadisticas.MostrarCategoriasMasVendidas(TFecha, THasta);

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker changedDateTimePicker = (DateTimePicker)sender;

            if (TFecha.Value > DateTime.Now || THasta.Value < TFecha.Value)
            {
                MessageBox.Show("Formato de fecha incorrecto", "Error en fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TFecha.ValueChanged -= DateTimePicker_ValueChanged;
                THasta.ValueChanged -= DateTimePicker_ValueChanged;

                TFecha.ResetText();
                THasta.ResetText();

                TFecha.ValueChanged += DateTimePicker_ValueChanged;
                THasta.ValueChanged += DateTimePicker_ValueChanged;
                TFecha.ResetText();
                THasta.ResetText();

                
            }
            else
            {
                if (changedDateTimePicker == TFecha || changedDateTimePicker == THasta)
                {
                    Estadisticas.MostrarTopVendedores(TFecha, THasta);
                    Estadisticas.MostrarCategoriasMasVendidas(TFecha, THasta);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estadisticas.pdfEstadistica();
        }


    }
}
