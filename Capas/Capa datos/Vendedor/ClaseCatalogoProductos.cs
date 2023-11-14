using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_datos.Vendedor
{
    internal class ClaseCatalogoProductos
    {
        private SqlConnection Productos;
        private TextBox TBBuscar;
        private TextBox TBNombre;
        private TextBox TBCategoria;
        private TextBox TBColor;
        private TextBox TBCantidad;
        private TextBox TBDescripcion;
        private TextBox TBPrecio;
        private Button BBuscarFiltro;
        private Button BEliminarFiltro;
        private DataGridView DGCatalogo;
        private Label LTexto;
        private ErrorProvider errorProvider1;
        public ClaseCatalogoProductos(TextBox TBBuscar, TextBox TBNombre, TextBox TBCategoria, TextBox TBColor, TextBox TBCantidad, TextBox TBDescripcion, TextBox TBPrecio, Button BBuscarFiltro, Button BEliminarFiltro, DataGridView DGCatalogo, ErrorProvider errorProvider1)
        {
            Productos = new SqlConnection("Server=.; Database=UnMate; Integrated Security=True;");
            this.TBNombre = TBNombre;
            this.TBBuscar = TBBuscar;
            this.TBCantidad = TBCantidad;
            this.TBCategoria = TBCategoria;
            this.TBColor = TBColor;
            this.TBDescripcion = TBDescripcion;
            this.TBPrecio = TBPrecio;
            this.BBuscarFiltro = BBuscarFiltro;
            this.BEliminarFiltro = BEliminarFiltro;
            this.DGCatalogo = DGCatalogo;
            this.BBuscarFiltro = BBuscarFiltro;
            this.errorProvider1 = errorProvider1;
        }

        public void MostrarProductos()
        {
            string consulta = "SELECT P.Cod_producto, P.Titulo,P.Descripcion, P.Precio, P.Stock, P.Color, C.Descripcion AS Categoria " +
                 "FROM Producto P " +
                 "INNER JOIN Categoria C ON P.ID_Categoria = C.ID_Categoria " +
                 "WHERE P.Estado = 1";

            SqlDataAdapter lista = new SqlDataAdapter(consulta, Productos);
            DataTable dt = new DataTable();
            lista.Fill(dt);
            DGCatalogo.DataSource = dt;
            quitarEspacios();
        }

        public void quitarEspacios()
        {
            foreach (DataGridViewRow row in DGCatalogo.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is string)
                    {
                        // elimina los espacios en blanco adicionales en la cadena de la celda
                        string gridSinEspacios = string.Join(" ", cell.Value.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                        // actualiza el valor de la celda
                        cell.Value = gridSinEspacios;
                    }
                }
            }
        }

        public void LimpiarFiltros()
        {
            BEliminarFiltro.Visible = false;
            TBBuscar.Clear();
            TBNombre.Clear();
            TBCategoria.Clear();
            TBColor.Clear();
            TBCantidad.Clear();
            TBDescripcion.Clear();
            TBPrecio.Clear();
            BBuscarFiltro.Visible = true;
        }

        public void BuscarProducto()
        {
            if (TBBuscar.Text == "")
            {
                errorProvider1.SetError(TBBuscar, "Debe ingresar el nombre del producto");
            }
            else
            {
                string textoBuscado = TBBuscar.Text.Trim();
                bool productoEncontrado = false;

                foreach (DataGridViewRow fila in DGCatalogo.Rows)
                {
                    if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString().Contains(textoBuscado))
                    {
                        // si se encuentra el valor en la primera columna, muestra el contenido en los TextBox de resultado
                        TBNombre.Text = fila.Cells[0].Value.ToString();
                        TBDescripcion.Text = fila.Cells[1].Value.ToString();
                        TBPrecio.Text = fila.Cells[2].Value.ToString();
                        TBCantidad.Text = fila.Cells[3].Value.ToString();
                        TBCategoria.Text = fila.Cells[5].Value.ToString();
                        TBColor.Text = fila.Cells[4].Value.ToString();

                        BEliminarFiltro.Visible = true; errorProvider1.SetError(TBBuscar, "");
                        MessageBox.Show("Producto encontrado en la base", "Búsqueda de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        productoEncontrado = true;
                        break; 
                    }
                }

                if (!productoEncontrado)
                {
                    // si no se encontró el valor, puedes mostrar un mensaje
                    MessageBox.Show("Producto no encontrado en la base", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBBuscar.Clear(); errorProvider1.SetError(TBBuscar, "");
                }
            }
        }

        public void DobleClick()
        {
            
            TBNombre.Text = DGCatalogo.CurrentRow.Cells[1].Value.ToString();
            TBPrecio.Text = DGCatalogo.CurrentRow.Cells[3].Value.ToString();
            TBDescripcion.Text = DGCatalogo.CurrentRow.Cells[2].Value.ToString();
            TBCantidad.Text = DGCatalogo.CurrentRow.Cells[4].Value.ToString();
            TBColor.Text = DGCatalogo.CurrentRow.Cells[5].Value.ToString();
            TBCategoria.Text = DGCatalogo.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
