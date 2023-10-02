using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.Administración
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
            BEliminar.Visible = false;
            BModificar.Visible = false;
        }

        private void BAñadir_Click(object sender, EventArgs e)
        {

            BorrarErrores();

            if (CBMotivo.SelectedItem != null && !String.IsNullOrWhiteSpace(TBDescripcion.Text) && TFecha.Value != null &&
                RB1.Checked == true || RB2.Checked == true || RB3.Checked == true && ErroresProviders())
            {
                DialogResult result = MessageBox.Show("Estas a punto de agregar una nota ", "Agregar nota a la lista", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Nota ingresada a la lista", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string buton = RB1.Checked ? "Baja" : (RB2.Checked ? "Media" : "Alta");

                    //BAJA
                    if (RB1.Checked == true)
                    {
                        int filas = GridNotas.Rows.Add(CBMotivo.Text, TBDescripcion.Text, TFecha.Text, buton);
                        GridNotas.Rows[filas].DefaultCellStyle.BackColor = Color.Green;

                        //MEDIA
                    }
                    else if (RB2.Checked == true)
                    {
                        int filas = GridNotas.Rows.Add(CBMotivo.Text, TBDescripcion.Text, TFecha.Text, buton);
                        GridNotas.Rows[filas].DefaultCellStyle.BackColor = Color.Yellow;

                        //ALTA
                    }
                    else if (RB3.Checked == true)
                    {
                        int filas = GridNotas.Rows.Add(CBMotivo.Text, TBDescripcion.Text, TFecha.Text, buton);
                        GridNotas.Rows[filas].DefaultCellStyle.BackColor = Color.Red;
                    }
                    quitarEspacios();
                    BorrarCampos();
                    BorrarErrores();
                }
                else
                {
                    MessageBox.Show("Inserción cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }

        }

        private void BorrarCampos()
        {
            CBMotivo.SelectedItem = null;
            TBDescripcion.Clear();
            TFecha.ResetText();
            RB1.Checked = false;
            RB2.Checked = false;
            RB3.Checked = false;
        }

        private void GridNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CBMotivo.Text = GridNotas.CurrentRow.Cells[0].Value.ToString();
            TBDescripcion.Text = GridNotas.CurrentRow.Cells[1].Value.ToString();
            if (GridNotas.CurrentRow.Cells[2].Value is DateTime)
            {
                TFecha.Text = ((DateTime)GridNotas.CurrentRow.Cells[2].Value).ToString("dd/MM/yyyy");
            }

            string importancia = GridNotas.CurrentRow.Cells[3].Value.ToString();
            if (importancia == "Baja")
            {
                RB1.Checked = true;
            }
            else if (importancia == "Media")
            {
                RB2.Checked = true;
            }
            else if (importancia == "Alta")
            {
                RB3.Checked = true;
            }

            BEliminar.Visible = true;
            BModificar.Visible = true;
            BorrarErrores();
            BAñadir.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BorrarErrores();
            if (CBMotivo.SelectedItem != null && !String.IsNullOrWhiteSpace(TBDescripcion.Text) && TFecha.Value != null &&
                RB1.Checked == true || RB2.Checked == true || RB3.Checked == true && ErroresProviders())
            {
                DialogResult result = MessageBox.Show("Desea eliminar la nota?", "Eliminación de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    GridNotas.Rows.Remove(GridNotas.CurrentRow);
                    MessageBox.Show("Eliminación  realizada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BorrarCampos();
                    BEliminar.Visible = false;
                    BModificar.Visible = false;
                    BorrarErrores();
                    BAñadir.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Eliminación de nota cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una nota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrarErrores();
            if (CBMotivo.Text != "" && !String.IsNullOrWhiteSpace(TBDescripcion.Text) && TFecha.Value != null &&
                RB1.Checked == true || RB2.Checked == true || RB3.Checked == true && ErroresProviders())
            {

                DialogResult result = MessageBox.Show("Desea modificar la nota?", "Modificacion de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    GridNotas.CurrentRow.Cells[0].Value = CBMotivo.Text;
                    GridNotas.CurrentRow.Cells[1].Value = TBDescripcion.Text;
                    GridNotas.CurrentRow.Cells[2].Value = TFecha.Text;

                    if (RB1.Checked == true)
                    {
                        GridNotas.CurrentRow.Cells[3].Value = "Baja";
                        GridNotas.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (RB2.Checked == true)
                    {
                        GridNotas.CurrentRow.Cells[3].Value = "Media";
                        GridNotas.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (RB3.Checked == true)
                    {
                        GridNotas.CurrentRow.Cells[3].Value = "Alta";
                        GridNotas.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                    }

                    MessageBox.Show("Modificación realizada", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BorrarCampos();
                    BorrarErrores();
                    BEliminar.Visible = false;
                    BModificar.Visible = false;

                }
                else
                {
                    MessageBox.Show("Modificación de nota cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Existe uno o varios campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void Notas_Load(object sender, EventArgs e)
        {

        }

        private bool ErroresProviders()
        {
            bool notaCorrecta = true;

            if (CBMotivo.SelectedItem == null)
            {
                errorProvider1.SetError(CBMotivo, "Motivo de nota necesario");
                notaCorrecta = false;
            }

            if (RB1.Checked == false && RB2.Checked == false && RB3.Checked == false)
            {
                errorProvider1.SetError(RB1, "Importancia necesaria");
                errorProvider1.SetError(RB2, "Importancia necesaria");
                errorProvider1.SetError(RB3, "Importancia necesaria");
                notaCorrecta = true;
            }

            if (string.IsNullOrWhiteSpace(TBDescripcion.Text))
            {
                errorProvider1.SetError(TBDescripcion, "Descripcion necesaria sin espacios en blanco");
                notaCorrecta = false;
            }

            return notaCorrecta;
        }

        private void BorrarErrores()
        {
            errorProvider1.SetError(CBMotivo, "");
            errorProvider1.SetError(RB1, "");
            errorProvider1.SetError(RB2, "");
            errorProvider1.SetError(RB3, "");
            errorProvider1.SetError(TBDescripcion, "");
        }

        private void TBDescripcion_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TBDescripcion.Text)) {
                errorProvider1.SetError(TBDescripcion, "No se permiten espacios en blanco");
            }
            else
            {
                errorProvider1.SetError(TBDescripcion, "");
            }
        }

        //quitar los espacios en blanco de la tabla 
        private void quitarEspacios()
        {
            foreach (DataGridViewRow row in GridNotas.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value is string)
                    {
                        // Elimina los espacios en blanco adicionales en la cadena de la celda
                        string gridSinEspacios = string.Join(" ", cell.Value.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                        // Actualiza el valor de la celda
                        cell.Value = gridSinEspacios;
                    }
                }
            }
        }

        private void BAñadir_Click_1(object sender, EventArgs e)
        {
            BorrarErrores();

            if (CBMotivo.SelectedItem != null && !String.IsNullOrWhiteSpace(TBDescripcion.Text) && TFecha.Value != null &&
                RB1.Checked == true || RB2.Checked == true || RB3.Checked == true && ErroresProviders())
            {
                DialogResult result = MessageBox.Show("Estas a punto de agregar una nota ", "Agregar nota a la lista", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Nota ingresada a la lista", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string buton = RB1.Checked ? "Baja" : (RB2.Checked ? "Media" : "Alta");

                    //BAJA
                    if (RB1.Checked == true)
                    {
                        int filas = GridNotas.Rows.Add(CBMotivo.Text, TBDescripcion.Text, TFecha.Text, buton);
                        GridNotas.Rows[filas].DefaultCellStyle.BackColor = Color.Green;

                        //MEDIA
                    }
                    else if (RB2.Checked == true)
                    {
                        int filas = GridNotas.Rows.Add(CBMotivo.Text, TBDescripcion.Text, TFecha.Text, buton);
                        GridNotas.Rows[filas].DefaultCellStyle.BackColor = Color.Yellow;

                        //ALTA
                    }
                    else if (RB3.Checked == true)
                    {
                        int filas = GridNotas.Rows.Add(CBMotivo.Text, TBDescripcion.Text, TFecha.Text, buton);
                        GridNotas.Rows[filas].DefaultCellStyle.BackColor = Color.Red;
                    }
                    quitarEspacios();
                    BorrarCampos();
                    BorrarErrores();
                }
                else
                {
                    MessageBox.Show("Inserción cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void GridNotas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CBMotivo.Text = GridNotas.CurrentRow.Cells[0].Value.ToString();
            TBDescripcion.Text = GridNotas.CurrentRow.Cells[1].Value.ToString();
            if (GridNotas.CurrentRow.Cells[2].Value is DateTime)
            {
                TFecha.Text = ((DateTime)GridNotas.CurrentRow.Cells[2].Value).ToString("dd/MM/yyyy");
            }

            string importancia = GridNotas.CurrentRow.Cells[3].Value.ToString();
            if (importancia == "Baja")
            {
                RB1.Checked = true;
            }
            else if (importancia == "Media")
            {
                RB2.Checked = true;
            }
            else if (importancia == "Alta")
            {
                RB3.Checked = true;
            }

            BEliminar.Visible = true;
            BModificar.Visible = true;
            BorrarErrores();
            BAñadir.Enabled = false;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            BorrarErrores();
            if (CBMotivo.SelectedItem != null && !String.IsNullOrWhiteSpace(TBDescripcion.Text) && TFecha.Value != null &&
                RB1.Checked == true || RB2.Checked == true || RB3.Checked == true && ErroresProviders())
            {
                DialogResult result = MessageBox.Show("Desea eliminar la nota?", "Eliminación de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    GridNotas.Rows.Remove(GridNotas.CurrentRow);
                    MessageBox.Show("Eliminación  realizada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BorrarCampos();
                    BEliminar.Visible = false;
                    BModificar.Visible = false;
                    BorrarErrores();
                    BAñadir.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Eliminación de nota cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una nota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            BorrarErrores();
            if (CBMotivo.Text != "" && !String.IsNullOrWhiteSpace(TBDescripcion.Text) && TFecha.Value != null &&
                RB1.Checked == true || RB2.Checked == true || RB3.Checked == true && ErroresProviders())
            {

                DialogResult result = MessageBox.Show("Desea modificar la nota?", "Modificacion de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    GridNotas.CurrentRow.Cells[0].Value = CBMotivo.Text;
                    GridNotas.CurrentRow.Cells[1].Value = TBDescripcion.Text;
                    GridNotas.CurrentRow.Cells[2].Value = TFecha.Text;

                    if (RB1.Checked == true)
                    {
                        GridNotas.CurrentRow.Cells[3].Value = "Baja";
                        GridNotas.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (RB2.Checked == true)
                    {
                        GridNotas.CurrentRow.Cells[3].Value = "Media";
                        GridNotas.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (RB3.Checked == true)
                    {
                        GridNotas.CurrentRow.Cells[3].Value = "Alta";
                        GridNotas.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                    }

                    MessageBox.Show("Modificación realizada", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BorrarCampos();
                    BorrarErrores();
                    BEliminar.Visible = false;
                    BModificar.Visible = false;

                }
                else
                {
                    MessageBox.Show("Modificación de nota cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Existe uno o varios campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErroresProviders();
            }
        }

        private void TBDescripcion_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDescripcion.Text))
            {
                errorProvider1.SetError(TBDescripcion, "No se permiten espacios en blanco");
            }
            else
            {
                errorProvider1.SetError(TBDescripcion, "");
            }
        }
    }
}
