using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador
{
    public partial class Seguridad : Form
    {
        public Seguridad()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtSubir.Text = ofd.FileName;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCopia.Text))
            {
                MessageBox.Show("Funcion en construccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La copia no posee un nombre o existen espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCopia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSubir.Text))
            {
                MessageBox.Show("Funcion en construccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No existe una direccion de copia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
