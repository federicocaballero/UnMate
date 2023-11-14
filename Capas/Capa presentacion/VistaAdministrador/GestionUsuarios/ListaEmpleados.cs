using ProyectoTaller.Capas.Capa_datos;
using ProyectoTaller.Capas.Capa_datos.Administrador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionUsuarios
{
    public partial class ListaEmpleados : Form
    {
        
        private ClaseListaEmpleados miClaseEmpleados;
        public ListaEmpleados()
        {
            InitializeComponent();

            BLimpiarFiltros.Visible = false;
            BGuardarModificacion.Enabled = false;
            BEliminarEmpleado.Visible = false;
            BRestaurar.Visible = false;
            BBorrarListado.Visible = false;
            TabIndex();

            miClaseEmpleados = new ClaseListaEmpleados(TBApellido, TBTelefono, TBNombre, TBEmail, TBDni, TBContraseña, TBContraseña2, CBCategoria, errorProvider1, GridListaUsuarios, BGuardarModificacion, 
            BBorrarListado, BAñadir, BRestaurar, BEliminarEmpleado, TBBuscar);
  
        }


        private void BBorrarListado_Click_1(object sender, EventArgs e)
        {

            miClaseEmpleados.BorrarListado();

        }

        private void BGuardarModificacion_Click(object sender, EventArgs e)
        {

            miClaseEmpleados.GuardarModificacion();
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            miClaseEmpleados.RestaurarEmpleado();
        }

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            miClaseEmpleados.EliminarEmpleado();
        }

        private void BAñadir_Click(object sender, EventArgs e)
        {
            miClaseEmpleados.AñadirEmpleado();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            miClaseEmpleados.BuscarEmpleado();
        }

        private void GridListaUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            miClaseEmpleados.ConocerEmpleado();

        }

        private void BLimpiarFiltros_Click(object sender, EventArgs e)
        {
            BLimpiarFiltros.Visible = false;
            if (TBBuscar.Text != null)
            {

                // si no hay texto en el cuadro de búsqueda, muestra todas las filas
                foreach (DataGridViewRow fila in GridListaUsuarios.Rows)
                {
                    fila.Visible = true;
                    TBBuscar.Clear();
                    TBBuscar.Enabled = true;
                }
            }
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            miClaseEmpleados.MostrarEmpleados();
        }

        private void TBNombre_KeyPress_2(object sender, KeyPressEventArgs e)
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

        private void TBEmail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBDni_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBContraseña2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBBuscar_Click(object sender, EventArgs e)
        {
            TBBuscar.Clear();
        }

        private void TabIndex()
        {
            TBNombre.TabIndex = 0;
            TBApellido.TabIndex = 1;
            TBEmail.TabIndex = 2;
            TBDni.TabIndex = 3;
            CBCategoria.TabIndex = 4;
            TBTelefono.TabIndex = 5;
            TBContraseña.TabIndex = 6;
            TBContraseña2.TabIndex = 7;
        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if  (miClaseEmpleados.EsDireccionDeCorreoValida(TBEmail.Text) == false)
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
            // verifica si se está formateando una celda en la columna 6
            if (e.ColumnIndex == 6 && e.RowIndex >= 0) // Asegúrate de que no sea la fila de encabezado
            {
                // obtiene el valor de la celda en la columna6
                object valorCelda = GridListaUsuarios.Rows[e.RowIndex].Cells[6].Value;

                // verifica si el valor es igual a 0
                if (valorCelda != null && valorCelda.ToString() == "0")
                {
                    // cambia el color de fondo de la fila a rojo
                    GridListaUsuarios.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
