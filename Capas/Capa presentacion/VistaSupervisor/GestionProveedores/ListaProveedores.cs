using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores
{
    public partial class ListaProveedores : Form
    {
        public ListaProveedores()
        {
            InitializeComponent();
            BLimpiarFiltros.Visible = false; //ocultar el boton 
            BEliminar.Enabled = false;
            BBorrarListado.Visible = false;
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBNotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BAñadir_Click(object sender, EventArgs e)
        {
            QuitarErrores();

            if (!String.IsNullOrWhiteSpace(TBNombre.Text) && !String.IsNullOrWhiteSpace(TBDireccion.Text) && TBCuit.Text != "" && TBTelefono.Text != "" && TBEmail.Text != "" &&
                CBServ.SelectedItem != null && CBIva.SelectedItem != null && !String.IsNullOrWhiteSpace(TBNotas.Text) && ErrorProviders())
            {
                DialogResult result = MessageBox.Show("Estas a punto de agregar un proveedor ", "Agregar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Proveedor agregado a la lista", "Campos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridProveedores.Rows.Add(TBNombre.Text, TBDireccion.Text, TBCuit.Text, TBTelefono.Text, TBEmail.Text, CBServ.Text, CBIva.Text, TBNotas.Text);
                    BLimpiarFiltros.PerformClick(); BLimpiarFiltros.Visible = false;
                    BorrarTodo();
                    quitarEspacios();
                    QuitarErrores();


                }
                else
                {
                    MessageBox.Show("Inserción cancelada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Campos vacios o espacios en blanco\r\nPor favor revisar campos marcados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErrorProviders();
            }
        }

        private void BorrarTodo()
        {
            TBNombre.Clear();
            TBDireccion.Clear();
            TBCuit.Clear();
            TBTelefono.Clear();
            TBEmail.Clear();
            CBServ.SelectedItem = null;
            CBIva.SelectedItem = null;
            TBNotas.Clear();
            RB1.Checked = false;
            RB2.Checked = false;
        }

        private void BloquearDatos()
        {
            TBNombre.ReadOnly = true;
            TBEmail.ReadOnly = true;
            TBDireccion.ReadOnly = true;
            TBCuit.ReadOnly = true;
            TBNotas.ReadOnly = true;
            TBTelefono.ReadOnly = true;
        }

        private void DesbloquearDatos()
        {
            TBNombre.ReadOnly = false;
            TBEmail.ReadOnly = false;
            TBDireccion.ReadOnly = false;
            TBCuit.ReadOnly = false;
            TBNotas.ReadOnly = false;
            TBTelefono.ReadOnly = false;
            CBIva.Enabled = true;
            CBServ.Enabled = true;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            QuitarErrores();
            if (!String.IsNullOrWhiteSpace(TBNombre.Text) && !String.IsNullOrWhiteSpace(TBDireccion.Text) && TBCuit.Text != "" && TBTelefono.Text != "" && TBEmail.Text != "" &&
                CBServ.SelectedItem != null && CBIva.SelectedItem != null && !String.IsNullOrWhiteSpace(TBNotas.Text) && ErrorProviders())
            {
                DialogResult result = MessageBox.Show("Desea eliminar al proveedor?", "Eliminación de proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    GridProveedores.Rows.Remove(GridProveedores.CurrentRow);
                    MessageBox.Show("Eliminación de proveedor realizada", "Eliminación de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BorrarTodo(); BLimpiarFiltros.PerformClick(); BLimpiarFiltros.Visible = false;
                    DesbloquearDatos(); BEliminar.Enabled = false;
                    BBorrarListado.Visible = false;
                    BAñadir.Enabled = true;
                    QuitarErrores();

                }
                else
                {
                    MessageBox.Show("Eliminación  cancelada!", "Error de eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Error en eliminar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ErrorProviders();
            }
        }

        private void ListaProveedores_Load(object sender, EventArgs e)
        {
            GridProveedores.Rows.Add("MatesCorrientes", "San Martin 3500", "2034512234220", "09876554321", "MatCorr22@gmail.com", "Productos", "Responsable Inscripto", "Tiene buenas referencias");
            GridProveedores.Rows.Add("Mates Chaco", "Belgrano 400", "21323112454110", "3654116523", "MateChaqueño@empresa.com", "Productos", "Responsable no Inscripto", "Posee mucha demanda");
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            bool proveedorEncontrado = false;
            if(RB1.Checked == true || RB2.Checked == true)
            {
                if (RB1.Checked == true)
                {
                    if (String.IsNullOrWhiteSpace(TBBuscar.Text) == false)
                    {
                        string contenidoDeseado = TBBuscar.Text; // Contenido que sea desea buscar en la primera columna
                        BLimpiarFiltros.Visible = true;

                        // Recorre todas las filas del DataGridView
                        foreach (DataGridViewRow fila in GridProveedores.Rows)
                        {

                            // Verifica el contenido de la celda en la primera columna (índice 2)
                            if (fila.Cells[2].Value != null && fila.Cells[2].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                            {
                                // Si coincide, muestra la fila completa
                                fila.Visible = true;
                                proveedorEncontrado = true;

                            }
                            else
                            {
                                // Si no coincide, oculta la fila completa
                                fila.Visible = false;

                            }
                        }
                    }

                    if (!proveedorEncontrado)
                    {
                        MessageBox.Show("Proveedor no encontrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TBBuscar.Clear();
                        // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                        foreach (DataGridViewRow fila in GridProveedores.Rows)
                        {
                            BLimpiarFiltros.Visible = false;
                            fila.Visible = true;
                            RB2.Checked = false;
                            RB1.Checked = false;

                        }
                    }

                }
                else if (RB2.Checked == true)
                {
                    if (String.IsNullOrWhiteSpace(TBBuscar.Text) == false)
                    {
                        BLimpiarFiltros.Visible = true;
                        string contenidoDeseado = TBBuscar.Text; // Contenido que sea desea buscar en la primera columna


                        // Recorre todas las filas del DataGridView
                        foreach (DataGridViewRow fila in GridProveedores.Rows)
                        {
                            // Verifica el contenido de la celda en la primera columna (índice 0)
                            if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString().Equals(contenidoDeseado, StringComparison.OrdinalIgnoreCase))
                            {
                                // Si coincide, muestra la fila completa
                                fila.Visible = true;
                                proveedorEncontrado = true;

                            }
                            else
                            {
                                // Si no coincide, oculta la fila completa
                                fila.Visible = false;

                            }
                        }
                    }
                    if (!proveedorEncontrado)
                    {
                        MessageBox.Show("Proveedor no encontrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TBBuscar.Clear();
                        // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                        foreach (DataGridViewRow fila in GridProveedores.Rows)
                        {
                            BLimpiarFiltros.Visible = false;
                            fila.Visible = true;
                            RB2.Checked = false;
                            RB1.Checked = false;

                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un formato de busqueda","Error en la busqueda", MessageBoxButtons.OK,MessageBoxIcon.Error);
                TBBuscar.Clear();
            }
           
        }

        private void GridProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BloquearDatos();
            TBNombre.Text = GridProveedores.CurrentRow.Cells[0].Value.ToString();
            TBDireccion.Text = GridProveedores.CurrentRow.Cells[1].Value.ToString();
            TBCuit.Text = GridProveedores.CurrentRow.Cells[2].Value.ToString();
            TBTelefono.Text = GridProveedores.CurrentRow.Cells[3].Value.ToString();
            TBEmail.Text = GridProveedores.CurrentRow.Cells[4].Value.ToString();
            CBServ.Text = GridProveedores.CurrentRow.Cells[5].Value.ToString();
            CBIva.Text = GridProveedores.CurrentRow.Cells[6].Value.ToString();
            TBNotas.Text = GridProveedores.CurrentRow.Cells[7].Value.ToString();
            CBServ.Enabled = false;
            CBIva.Enabled = false;
            BEliminar.Enabled = true;
            BBorrarListado.Visible = true;
            QuitarErrores();
            BAñadir.Enabled = false;
        }

        private void BLimpiarFiltros_Click(object sender, EventArgs e)
        {
            // Oculta el botón BLimpiarFiltros
            BLimpiarFiltros.Visible = false;


            if (String.IsNullOrWhiteSpace(TBBuscar.Text) == false)
            {
                RB1.Checked = false;
                RB2.Checked = false;
                TBBuscar.Clear();
                TBBuscar.Enabled = true;
                BLimpiarFiltros.Visible = false;

                // Si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridProveedores.Rows)
                {
                    fila.Visible = true;

                }

            }
        }

        private void BBorrarListado_Click(object sender, EventArgs e)
        {
            BorrarTodo();
            quitarEspacios();
            BEliminar.Enabled = false;
            BBorrarListado.Visible = false;
            DesbloquearDatos();
            BAñadir.Enabled = true;
            errorProvider1.SetError(TBNombre, "");
            errorProvider1.SetError(TBDireccion, "");
            errorProvider1.SetError(TBNotas, "");
            TBBuscar.Clear();
            BLimpiarFiltros.PerformClick();
        }

        private bool ErrorProviders()
        {
            bool proveedorLista = true;

            if (TBCuit.Text == "")
            {
                errorProvider1.SetError(TBCuit, "CUIT necesario");
                proveedorLista = false;
            }

            if (string.IsNullOrWhiteSpace(TBDireccion.Text))
            {
                errorProvider1.SetError(TBDireccion, "Direccion necesaria sin espacios en blanco");
                proveedorLista = false;
            }

            if (string.IsNullOrWhiteSpace(TBNombre.Text))
            {
                errorProvider1.SetError(TBNombre, "Nombre necesario sin espacios en blanco");
                proveedorLista = false;
            }

            if (TBTelefono.Text == "")
            {
                errorProvider1.SetError(TBTelefono, "Telefono necesario");
                proveedorLista = false;
            }

            if (TBEmail.Text == "")
            {
                errorProvider1.SetError(TBEmail, "Email necesario");
                proveedorLista = false;
            }

            if (CBServ.SelectedItem == null)
            {
                errorProvider1.SetError(CBServ, "Campo necesario");
                proveedorLista = false;
            }

            if (CBIva.SelectedItem == null)
            {
                errorProvider1.SetError(CBIva, "Campo necesario");
                proveedorLista = false;
            }

            if (string.IsNullOrWhiteSpace(TBNotas.Text))
            {
                errorProvider1.SetError(TBNotas, "Campo necesario sin espacios en blanco");
                proveedorLista = false;
            }

            return proveedorLista;
        }

        private void QuitarErrores()
        {
            errorProvider1.SetError(CBServ, "");
            errorProvider1.SetError(TBNombre, "");
            errorProvider1.SetError(CBIva, "");
            errorProvider1.SetError(TBTelefono, "");
            errorProvider1.SetError(TBEmail, "");
            errorProvider1.SetError(TBCuit, "");
            errorProvider1.SetError(TBDireccion, "");
            errorProvider1.SetError(TBNotas, "");
        }

        private void TBNotas_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBNotas.Text))
            {
                errorProvider1.SetError(TBNotas, "No se permiten espacios en blanco");
            }
            else
            {
                errorProvider1.SetError(TBNotas, "");
            }
        }
    

    private void quitarEspacios()
    {
        foreach (DataGridViewRow row in GridProveedores.Rows)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value is string)
                {
                    // Elimina los espacios en blanco adicionales en la cadena de la celda
                    string gridSinEspacios = string.Join(" ", cell.Value.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                    // Actualiza el valor de la celda
                    cell.Value = gridSinEspacios;
                }
            }
        }
    }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBNombre.Text))
            {
                errorProvider1.SetError(TBNombre, "No se permiten espacios en blanco");
            }
            else
            {
                errorProvider1.SetError(TBNombre, "");
            }
        }

        private void TBDireccion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDireccion.Text))
            {
                errorProvider1.SetError(TBDireccion, "No se permiten espacios en blanco");
            }
            else
            {
                errorProvider1.SetError(TBDireccion, "");
            }
        }
    }
}