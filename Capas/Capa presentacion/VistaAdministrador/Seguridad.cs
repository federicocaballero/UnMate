using ProyectoTaller.Capas.Capa_datos.Administrador;
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

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador
{
    public partial class Seguridad : Form
    {
        private ClaseSeguridad BaseDeDatos;
        public Seguridad()
        {
            InitializeComponent();
            BaseDeDatos = new ClaseSeguridad(BCargarCopia, BSubirCopia, BCargarCopia,txtSubir);
        }

        private void BCopia_Click(object sender, EventArgs e)
        {
            BaseDeDatos.crearCopiar();
        }

        private void BCargarCopia_Click_1(object sender, EventArgs e)
        {
            BaseDeDatos.cargarCopia();
            BSubirCopia.Enabled = true;
        }

        private void BSubirCopia_Click_1(object sender, EventArgs e)
        {
            BaseDeDatos.establecerCopiar();
        }
    }
}
