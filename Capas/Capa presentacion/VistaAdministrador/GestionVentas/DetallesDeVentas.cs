using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionVentas
{
    public partial class DetallesDeVentas : Form
    {

        private int codigoVenta;
        public int CodigoVenta
        {
            get { return codigoVenta; }
            set { codigoVenta = value; }

        }

        public DetallesDeVentas(int codigoVenta)
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void DetalleDeVenta_Load(object sender, EventArgs e)
        {
            MostrarDetallesVenta(this.CodigoVenta);
        }

        private void MostrarDetallesVenta(int codigoVenta)
        {
            
        }

      
        
    }
}
