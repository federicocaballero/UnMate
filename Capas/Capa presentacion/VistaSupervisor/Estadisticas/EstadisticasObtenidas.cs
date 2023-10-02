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

namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.Estadisticas
{
    public partial class EstadisticasObtenidas : Form
    {
        public EstadisticasObtenidas()
        {
            InitializeComponent();
        }

        private void EstadisticasObtenidas_Load(object sender, EventArgs e)
        {
            CPorcentajeProductos.Series["Categorias"].Points.AddXY("Madera", 2456);
            CPorcentajeProductos.Series["Categorias"].Points.AddXY("Calabaza", 1221);
            CPorcentajeProductos.Series["Categorias"].Points.AddXY("Caña", 400);
            CPorcentajeProductos.Series["Categorias"].Points.AddXY("Cuero", 810);
            CPorcentajeProductos.Series["Categorias"].IsValueShownAsLabel = true; // Muestra los valores como etiquetas

            CVendedores.Series["Vendedores"].Points.AddXY("Vendedor1", 1500);
            CVendedores.Series["Vendedores"].Points.AddXY("Vendedor2", 900);
            CVendedores.Series["Vendedores"].Points.AddXY("Vendedor3", 600);
            CVendedores.Series["Vendedores"].IsValueShownAsLabel = true;

            GridCompras.Rows.Add("Colman Alexis", "Julian Guzman", "22/04/2023", "800000$");
            GridCompras.Rows.Add("Caballero Federico", "Julian Guzman", "12/02/2023", "1200000$");
            GridCompras.Rows.Add("Colman Alexis", "Julian Guzman", "10/04/2023", "200000$");
        }
    }
}
