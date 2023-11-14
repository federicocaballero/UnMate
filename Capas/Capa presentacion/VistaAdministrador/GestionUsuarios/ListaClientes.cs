using ProyectoTaller.Capas.Capa_datos.Administrador;
using ProyectoTaller.Capas.Capa_datos.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionProductos
{
    public partial class ListaClientes : Form
    {
        private ClaseListaClientes ListadoClientes;
        public ListaClientes()
        {
            InitializeComponent();
            BGuardarModificacion.Visible = false;
            BLimpiarFiltros.Visible = false;
            BBorrarListado.Visible = false;
            BEliminarCliente.Visible = false;
            BRestaurar.Visible = false;
            ListadoClientes = new ClaseListaClientes(TBApellido, TBTelefono, TBNombre, TBEmail, TBDni, errorProvider1, GridListaClientes, BGuardarModificacion, BBorrarListado, BRestaurar, BEliminarCliente, TBBuscar, BLimpiarFiltros);
            TabIndex();
        }

        private void TabIndex()
        {
            TBNombre.TabIndex = 0;
            TBApellido.TabIndex = 1;
            TBEmail.TabIndex = 2; 
            TBDni.TabIndex = 3;
            TBTelefono.TabIndex = 4;
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool EsDireccionDeCorreoValida(string direccionCorreo)
        {
            // dfine el patrón de una dirección de correo electrónico válida
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // compila la expresión regular
            Regex regex = new Regex(patron);

            // verifica si la dirección de correo coincide con el patrón
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

        private void GridListaClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // verifica si se está formateando una celda en la columna 6
            if (e.ColumnIndex == 6 && e.RowIndex >= 0) // Asegúrate de que no sea la fila de encabezado
            {
                // obtiene el valor de la celda en la columna 6
                object valorCelda = GridListaClientes.Rows[e.RowIndex].Cells[6].Value;

                // verifica si el valor es igual a 0
                if (valorCelda != null && valorCelda.ToString() == "0")
                {
                    // cambia el color de fondo de la fila a rojo
                    GridListaClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            ListadoClientes.RestaurarCliente();
        }

        private void BGuardarModificacion_Click(object sender, EventArgs e)
        {
            ListadoClientes.GuardarModificacion();

        }

        private void BBorrarListado_Click(object sender, EventArgs e)
        {
            ListadoClientes.BorrarFilas();
        }

        private void BEliminarCliente_Click(object sender, EventArgs e)
        {
            ListadoClientes.EliminarCliente();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            ListadoClientes.MostrarClientes();
        }

        private void GridListaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListadoClientes.DobleClick();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            ListadoClientes.BuscarCliente();
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
