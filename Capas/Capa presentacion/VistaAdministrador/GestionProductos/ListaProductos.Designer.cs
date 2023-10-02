using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionProductos
{
    partial class ListaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProductos));
            this.GridListaProductos = new System.Windows.Forms.DataGridView();
            this.ColumnaTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LListaProductos = new System.Windows.Forms.Label();
            this.PanelListaProductos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BBorrarListado = new System.Windows.Forms.Button();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.CBColorMate = new System.Windows.Forms.ComboBox();
            this.BAñadir = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.LCategoria = new System.Windows.Forms.Label();
            this.CBMaterial = new System.Windows.Forms.ComboBox();
            this.BEliminarProducto = new System.Windows.Forms.Button();
            this.BGuardarModificacion = new System.Windows.Forms.Button();
            this.LColor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.TBDetalles = new System.Windows.Forms.TextBox();
            this.LDetalles = new System.Windows.Forms.Label();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.TBTitulo = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LContraseña = new System.Windows.Forms.Label();
            this.LPrecio = new System.Windows.Forms.Label();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaProductos)).BeginInit();
            this.PanelListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridListaProductos
            // 
            this.GridListaProductos.AllowUserToAddRows = false;
            this.GridListaProductos.AllowUserToDeleteRows = false;
            this.GridListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListaProductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaTitulo,
            this.ColumnaDetalles,
            this.ColumnaColor,
            this.ColumnaPrecio,
            this.ColumnaStock,
            this.imagen,
            this.categoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridListaProductos.Location = new System.Drawing.Point(0, 221);
            this.GridListaProductos.Name = "GridListaProductos";
            this.GridListaProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridListaProductos.RowHeadersVisible = false;
            this.GridListaProductos.RowTemplate.Height = 25;
            this.GridListaProductos.Size = new System.Drawing.Size(807, 225);
            this.GridListaProductos.TabIndex = 38;
            this.GridListaProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListaProductos_CellContentDoubleClick);
            // 
            // ColumnaTitulo
            // 
            this.ColumnaTitulo.FillWeight = 155.8286F;
            this.ColumnaTitulo.HeaderText = "Titulo";
            this.ColumnaTitulo.Name = "ColumnaTitulo";
            this.ColumnaTitulo.ReadOnly = true;
            // 
            // ColumnaDetalles
            // 
            this.ColumnaDetalles.FillWeight = 204.1131F;
            this.ColumnaDetalles.HeaderText = "Detalles";
            this.ColumnaDetalles.Name = "ColumnaDetalles";
            this.ColumnaDetalles.ReadOnly = true;
            // 
            // ColumnaColor
            // 
            this.ColumnaColor.FillWeight = 82.30282F;
            this.ColumnaColor.HeaderText = "Color";
            this.ColumnaColor.Name = "ColumnaColor";
            this.ColumnaColor.ReadOnly = true;
            this.ColumnaColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnaColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaPrecio
            // 
            this.ColumnaPrecio.FillWeight = 62.64982F;
            this.ColumnaPrecio.HeaderText = "Precio";
            this.ColumnaPrecio.Name = "ColumnaPrecio";
            this.ColumnaPrecio.ReadOnly = true;
            this.ColumnaPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnaPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnaStock
            // 
            this.ColumnaStock.FillWeight = 57.49051F;
            this.ColumnaStock.HeaderText = "Stock";
            this.ColumnaStock.Name = "ColumnaStock";
            this.ColumnaStock.ReadOnly = true;
            this.ColumnaStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnaStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "Imagen";
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // LListaProductos
            // 
            this.LListaProductos.AutoSize = true;
            this.LListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LListaProductos.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.LListaProductos.ForeColor = System.Drawing.Color.White;
            this.LListaProductos.Location = new System.Drawing.Point(296, 11);
            this.LListaProductos.Name = "LListaProductos";
            this.LListaProductos.Size = new System.Drawing.Size(226, 24);
            this.LListaProductos.TabIndex = 39;
            this.LListaProductos.Text = "Lista de productos";
            // 
            // PanelListaProductos
            // 
            this.PanelListaProductos.BackColor = System.Drawing.SystemColors.InfoText;
            this.PanelListaProductos.Controls.Add(this.label3);
            this.PanelListaProductos.Controls.Add(this.BBorrarListado);
            this.PanelListaProductos.Controls.Add(this.BLimpiarFiltros);
            this.PanelListaProductos.Controls.Add(this.CBColorMate);
            this.PanelListaProductos.Controls.Add(this.BAñadir);
            this.PanelListaProductos.Controls.Add(this.BBuscar);
            this.PanelListaProductos.Controls.Add(this.TBBuscar);
            this.PanelListaProductos.Controls.Add(this.LCategoria);
            this.PanelListaProductos.Controls.Add(this.CBMaterial);
            this.PanelListaProductos.Controls.Add(this.BEliminarProducto);
            this.PanelListaProductos.Controls.Add(this.BGuardarModificacion);
            this.PanelListaProductos.Controls.Add(this.LColor);
            this.PanelListaProductos.Controls.Add(this.button1);
            this.PanelListaProductos.Controls.Add(this.PBImagen);
            this.PanelListaProductos.Controls.Add(this.TBDetalles);
            this.PanelListaProductos.Controls.Add(this.LDetalles);
            this.PanelListaProductos.Controls.Add(this.TBStock);
            this.PanelListaProductos.Controls.Add(this.TBPrecio);
            this.PanelListaProductos.Controls.Add(this.TBTitulo);
            this.PanelListaProductos.Controls.Add(this.LTelefono);
            this.PanelListaProductos.Controls.Add(this.LContraseña);
            this.PanelListaProductos.Controls.Add(this.LPrecio);
            this.PanelListaProductos.Controls.Add(this.LNombreProducto);
            this.PanelListaProductos.Controls.Add(this.LListaProductos);
            this.PanelListaProductos.Controls.Add(this.GridListaProductos);
            this.PanelListaProductos.Location = new System.Drawing.Point(-1, -2);
            this.PanelListaProductos.Name = "PanelListaProductos";
            this.PanelListaProductos.Size = new System.Drawing.Size(806, 461);
            this.PanelListaProductos.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(139, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 125;
            this.label3.Text = "Titulo producto";
            // 
            // BBorrarListado
            // 
            this.BBorrarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBorrarListado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BBorrarListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BBorrarListado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBorrarListado.Location = new System.Drawing.Point(672, 27);
            this.BBorrarListado.Name = "BBorrarListado";
            this.BBorrarListado.Size = new System.Drawing.Size(121, 44);
            this.BBorrarListado.TabIndex = 122;
            this.BBorrarListado.Text = "Borrar listado";
            this.BBorrarListado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrarListado.UseVisualStyleBackColor = true;
            this.BBorrarListado.Click += new System.EventHandler(this.BBorrarListado_Click_1);
            // 
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BLimpiarFiltros.ForeColor = System.Drawing.Color.IndianRed;
            this.BLimpiarFiltros.Location = new System.Drawing.Point(9, 191);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(104, 25);
            this.BLimpiarFiltros.TabIndex = 96;
            this.BLimpiarFiltros.Text = "Limpiar filtros";
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            this.BLimpiarFiltros.Click += new System.EventHandler(this.BLimpiarFiltros_Click_1);
            // 
            // CBColorMate
            // 
            this.CBColorMate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBColorMate.FormattingEnabled = true;
            this.CBColorMate.Items.AddRange(new object[] {
            "Marron",
            "Negro",
            "Blanco",
            "Verde",
            "Gris"});
            this.CBColorMate.Location = new System.Drawing.Point(314, 61);
            this.CBColorMate.Name = "CBColorMate";
            this.CBColorMate.Size = new System.Drawing.Size(104, 21);
            this.CBColorMate.TabIndex = 95;
            // 
            // BAñadir
            // 
            this.BAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAñadir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BAñadir.Image = ((System.Drawing.Image)(resources.GetObject("BAñadir.Image")));
            this.BAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAñadir.Location = new System.Drawing.Point(672, 27);
            this.BAñadir.Name = "BAñadir";
            this.BAñadir.Size = new System.Drawing.Size(121, 44);
            this.BAñadir.TabIndex = 93;
            this.BAñadir.Text = "Añadir";
            this.BAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAñadir.UseVisualStyleBackColor = true;
            this.BAñadir.Click += new System.EventHandler(this.BAñadir_Click);
            // 
            // BBuscar
            // 
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Location = new System.Drawing.Point(17, 192);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(96, 23);
            this.BBuscar.TabIndex = 69;
            this.BBuscar.Text = "BUSCAR";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(119, 192);
            this.TBBuscar.Multiline = true;
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(121, 23);
            this.TBBuscar.TabIndex = 68;
            this.TBBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBuscar.Click += new System.EventHandler(this.TBBuscar_Click);
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.BackColor = System.Drawing.Color.Transparent;
            this.LCategoria.Font = new System.Drawing.Font("Consolas", 12F);
            this.LCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCategoria.Location = new System.Drawing.Point(20, 143);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(99, 19);
            this.LCategoria.TabIndex = 67;
            this.LCategoria.Text = "Categorìa:";
            // 
            // CBMaterial
            // 
            this.CBMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMaterial.FormattingEnabled = true;
            this.CBMaterial.Items.AddRange(new object[] {
            "Madera",
            "Calabaza",
            "Caña",
            "Cuero"});
            this.CBMaterial.Location = new System.Drawing.Point(152, 144);
            this.CBMaterial.Name = "CBMaterial";
            this.CBMaterial.Size = new System.Drawing.Size(104, 21);
            this.CBMaterial.TabIndex = 66;
            // 
            // BEliminarProducto
            // 
            this.BEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BEliminarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BEliminarProducto.Image")));
            this.BEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminarProducto.Location = new System.Drawing.Point(672, 128);
            this.BEliminarProducto.Name = "BEliminarProducto";
            this.BEliminarProducto.Size = new System.Drawing.Size(121, 42);
            this.BEliminarProducto.TabIndex = 64;
            this.BEliminarProducto.Text = "Eliminar";
            this.BEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminarProducto.UseVisualStyleBackColor = true;
            this.BEliminarProducto.Click += new System.EventHandler(this.BEliminarProducto_Click);
            // 
            // BGuardarModificacion
            // 
            this.BGuardarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarModificacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BGuardarModificacion.ForeColor = System.Drawing.Color.Blue;
            this.BGuardarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("BGuardarModificacion.Image")));
            this.BGuardarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardarModificacion.Location = new System.Drawing.Point(672, 78);
            this.BGuardarModificacion.Name = "BGuardarModificacion";
            this.BGuardarModificacion.Size = new System.Drawing.Size(121, 44);
            this.BGuardarModificacion.TabIndex = 62;
            this.BGuardarModificacion.Text = "Modificar";
            this.BGuardarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardarModificacion.UseVisualStyleBackColor = true;
            this.BGuardarModificacion.Click += new System.EventHandler(this.BGuardarModificacion_Click_1);
            // 
            // LColor
            // 
            this.LColor.AutoSize = true;
            this.LColor.BackColor = System.Drawing.Color.Transparent;
            this.LColor.Font = new System.Drawing.Font("Consolas", 12F);
            this.LColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LColor.Location = new System.Drawing.Point(340, 40);
            this.LColor.Name = "LColor";
            this.LColor.Size = new System.Drawing.Size(63, 19);
            this.LColor.TabIndex = 60;
            this.LColor.Text = "Color:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(445, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 36);
            this.button1.TabIndex = 59;
            this.button1.Text = " Imagen del producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PBImagen
            // 
            this.PBImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.PBImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBImagen.Location = new System.Drawing.Point(445, 40);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(182, 83);
            this.PBImagen.TabIndex = 58;
            this.PBImagen.TabStop = false;
            // 
            // TBDetalles
            // 
            this.TBDetalles.Location = new System.Drawing.Point(119, 84);
            this.TBDetalles.Multiline = true;
            this.TBDetalles.Name = "TBDetalles";
            this.TBDetalles.Size = new System.Drawing.Size(169, 57);
            this.TBDetalles.TabIndex = 56;
            this.TBDetalles.TextChanged += new System.EventHandler(this.TBDetalles_TextChanged_1);
            this.TBDetalles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDetalles_KeyPress_1);
            // 
            // LDetalles
            // 
            this.LDetalles.AutoSize = true;
            this.LDetalles.BackColor = System.Drawing.Color.Transparent;
            this.LDetalles.Font = new System.Drawing.Font("Consolas", 12F);
            this.LDetalles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDetalles.Location = new System.Drawing.Point(20, 106);
            this.LDetalles.Name = "LDetalles";
            this.LDetalles.Size = new System.Drawing.Size(90, 19);
            this.LDetalles.TabIndex = 55;
            this.LDetalles.Text = "Detalles:";
            // 
            // TBStock
            // 
            this.TBStock.Location = new System.Drawing.Point(314, 106);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(102, 20);
            this.TBStock.TabIndex = 50;
            this.TBStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBStock_KeyPress_1);
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(314, 147);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(104, 20);
            this.TBPrecio.TabIndex = 49;
            this.TBPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrecio_KeyPress_1);
            // 
            // TBTitulo
            // 
            this.TBTitulo.BackColor = System.Drawing.Color.White;
            this.TBTitulo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TBTitulo.Location = new System.Drawing.Point(119, 62);
            this.TBTitulo.Name = "TBTitulo";
            this.TBTitulo.Size = new System.Drawing.Size(168, 20);
            this.TBTitulo.TabIndex = 48;
            this.TBTitulo.TextChanged += new System.EventHandler(this.TBTitulo_TextChanged_1);
            this.TBTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTitulo_KeyPress_1);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LTelefono.Font = new System.Drawing.Font("Consolas", 12F);
            this.LTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelefono.Location = new System.Drawing.Point(340, 86);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(63, 19);
            this.LTelefono.TabIndex = 47;
            this.LTelefono.Text = "Stock:";
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.BackColor = System.Drawing.Color.Transparent;
            this.LContraseña.Font = new System.Drawing.Font("Consolas", 12F);
            this.LContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LContraseña.Location = new System.Drawing.Point(7, 172);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(0, 19);
            this.LContraseña.TabIndex = 46;
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.BackColor = System.Drawing.Color.Transparent;
            this.LPrecio.Font = new System.Drawing.Font("Consolas", 12F);
            this.LPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPrecio.Location = new System.Drawing.Point(331, 129);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(72, 19);
            this.LPrecio.TabIndex = 44;
            this.LPrecio.Text = "Precio:";
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.LNombreProducto.Font = new System.Drawing.Font("Consolas", 12F);
            this.LNombreProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreProducto.Location = new System.Drawing.Point(22, 61);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(72, 19);
            this.LNombreProducto.TabIndex = 43;
            this.LNombreProducto.Text = "Título:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(804, 433);
            this.Controls.Add(this.PanelListaProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaProductos";
            this.Load += new System.EventHandler(this.ListaProductos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaProductos)).EndInit();
            this.PanelListaProductos.ResumeLayout(false);
            this.PanelListaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridListaProductos;
        private Label LListaProductos;
        private Panel PanelListaProductos;
        private TextBox TBDetalles;
        private Label LDetalles;
        private TextBox TBStock;
        private TextBox TBPrecio;
        private TextBox TBTitulo;
        private Label LTelefono;
        private Label LContraseña;
        private Label LPrecio;
        private Label LNombreProducto;
        private Button button1;
        private PictureBox PBImagen;
        private Label LColor;
        private Button BGuardarModificacion;
        private Button BEliminarProducto;
        private Label LCategoria;
        private ComboBox CBMaterial;
        private Button BBuscar;
        private TextBox TBBuscar;
        private Button BAñadir;
        private ComboBox CBColor;
        private ComboBox CBColorMate;
        private DataGridViewTextBoxColumn ColumnaTitulo;
        private DataGridViewTextBoxColumn ColumnaDetalles;
        private DataGridViewTextBoxColumn ColumnaColor;
        private DataGridViewTextBoxColumn ColumnaPrecio;
        private DataGridViewTextBoxColumn ColumnaStock;
        private DataGridViewImageColumn imagen;
        private DataGridViewTextBoxColumn categoria;
        private Button BLimpiarFiltros;
        private ErrorProvider errorProvider1;
        private Button BBorrarListado;
        private Label label3;
    }
}