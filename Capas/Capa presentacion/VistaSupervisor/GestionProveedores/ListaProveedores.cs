using ProyectoTaller.Capas.Capa_datos.Supervisor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores
{
    public partial class ListaProveedores : Form
    {

        private ClaseProveedores ListadoProveedores;
        public ListaProveedores()
        {
            InitializeComponent();
            BEliminar.Visible = false;BRestaurar.Visible = false;
            BBorrarListado.Visible = false;
            MoverTab();
            ListadoProveedores = new ClaseProveedores(TBEmail,TBDireccion, TBCuit, TBTelefono, CBIva, TBNombre, errorProvider1, GridProveedores, BBorrarListado, BAñadir, BEliminar, BRestaurar, TBBuscar, BRestaurar);
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
            ListadoProveedores.AñadirProveedor();
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            ListadoProveedores.RestaurarProveedor();
        }


        private void BEliminar_Click(object sender, EventArgs e)
        {
            ListadoProveedores.EliminarProveedor();
        }

        private void ListaProveedores_Load(object sender, EventArgs e)
        {
            ListadoProveedores.MostrarProveedores();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            ListadoProveedores.BuscarProveedor();

        }
        
        private object valorCodigoProveedor;
        private void GridProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListadoProveedores.DobleClick();
        }

        private void BBorrarListado_Click(object sender, EventArgs e)
        {
            ListadoProveedores.BorrarListado();
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

        private void MoverTab()
        {
            TBNombre.TabIndex = 0;
            TBDireccion.TabIndex = 1;
            TBCuit.TabIndex = 2;
            TBTelefono.TabIndex = 4;
            TBEmail.TabIndex = 5;
            CBIva.TabIndex = 3;
           
        }

        private bool EsDireccionDeCorreoValida(string direccionCorreo)
        {
            // Define el patrón de una dirección de correo electrónico válida
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Compila la expresión regular
            Regex regex = new Regex(patron);

            // Verifica si la dirección de correo coincide con el patrón
            return regex.IsMatch(direccionCorreo);
        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (EsDireccionDeCorreoValida(TBEmail.Text) == false)
            {
                errorProvider1.SetError(TBEmail, "Formato de correo incorrecto");
            }
            else
            {
                errorProvider1.SetError(TBEmail, "");
            }
        }

        private void GridProveedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si se está formateando una celda en la columna 6
            if (e.ColumnIndex == 6 && e.RowIndex >= 0) // Asegúrate de que no sea la fila de encabezado
            {
                // Obtiene el valor de la celda en la columna 6
                object valorCelda = GridProveedores.Rows[e.RowIndex].Cells[6].Value;

                // Verifica si el valor es igual a 0
                if (valorCelda != null && valorCelda.ToString() == "0")
                {
                    // Cambia el color de fondo de la fila a rojo
                    GridProveedores.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void TBBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}