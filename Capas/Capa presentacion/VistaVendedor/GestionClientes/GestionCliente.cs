using ProyectoTaller.Capas.Capa_datos.Administrador;
using ProyectoTaller.Capas.Capa_datos.Vendedor;
using System;
using System.Collections;
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
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionClientes
{

    public partial class GestionCliente : Form
    {
        private ClaseClientes miClaseListaClientes;

        public GestionCliente()
        {
            InitializeComponent();
            BGuardarModificacion.Enabled = false;
            BLimpiarFiltros.Visible = false;
            BBorrarListado.Visible = false;
            TabMover();
            BEliminarCliente.Visible = false;
            BRestaurar.Visible = false;
            miClaseListaClientes = new ClaseClientes(TBApellido, TBTelefono, TBNombre, TBEmail, TBDni, errorProvider1, GridListaUsuarios, BGuardarModificacion, BBorrarListado, BAñadirC, BRestaurar, BEliminarCliente, TBBuscar,BLimpiarFiltros, DTPAltaUsuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miClaseListaClientes.EliminarCliente();
        }

        private void GestionCliente_Load(object sender, EventArgs e)
        {
            miClaseListaClientes.MostrarClientes();
          
        }

        private void BAñadirC_Click(object sender, EventArgs e)
            {
                miClaseListaClientes.AñadirCliente();
            }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            miClaseListaClientes.RestaurarCliente();
        }

        private void GridListaUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            miClaseListaClientes.DobleClick();
        }

        private void BGuardarModificacion_Click(object sender, EventArgs e)
        {
            miClaseListaClientes.GuardarModificacion();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            miClaseListaClientes.BuscarCliente();
        }

        private void TBNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBEmail_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TabMover()
        {
            TBNombre.TabIndex = 0;
            TBApellido.TabIndex = 1;
            TBTelefono.TabIndex = 2;
            TBEmail.TabIndex = 3;
            TBDni.TabIndex = 4;
            BAñadirC.TabIndex = 5;
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


        private void GridListaUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si se está formateando una celda en la columna 6
            if (e.ColumnIndex == 6 && e.RowIndex >= 0) // Asegúrate de que no sea la fila de encabezado
            {
                // Obtiene el valor de la celda en la columna 6
                object valorCelda = GridListaUsuarios.Rows[e.RowIndex].Cells[6].Value;

                // Verifica si el valor es igual a 0
                if (valorCelda != null && valorCelda.ToString() == "0")
                {
                    // Cambia el color de fondo de la fila a rojo
                    GridListaUsuarios.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void BBorrarListado_Click(object sender, EventArgs e)
        {
            miClaseListaClientes.BorrarFilas(); 
        }
    }
}
