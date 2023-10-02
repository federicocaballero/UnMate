using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    partial class ListadoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LTexto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BEliminarFiltro = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.BBuscarFiltro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TBCategoria = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.TBDisponible = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.LDisponibilidad = new System.Windows.Forms.Label();
            this.LPrecio = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.DGCatalogo = new System.Windows.Forms.DataGridView();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LTexto
            // 
            this.LTexto.AutoSize = true;
            this.LTexto.BackColor = System.Drawing.Color.Transparent;
            this.LTexto.Enabled = false;
            this.LTexto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.LTexto.ForeColor = System.Drawing.Color.White;
            this.LTexto.Location = new System.Drawing.Point(28, 83);
            this.LTexto.Name = "LTexto";
            this.LTexto.Size = new System.Drawing.Size(180, 19);
            this.LTexto.TabIndex = 11;
            this.LTexto.Text = "Imagen del producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 180);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BEliminarFiltro);
            this.panel1.Controls.Add(this.TBBuscar);
            this.panel1.Controls.Add(this.BBuscarFiltro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBCategoria);
            this.panel1.Controls.Add(this.LCantidad);
            this.panel1.Controls.Add(this.TBCantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBPrecio);
            this.panel1.Controls.Add(this.TBDisponible);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LDisponibilidad);
            this.panel1.Controls.Add(this.LPrecio);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Location = new System.Drawing.Point(215, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 184);
            this.panel1.TabIndex = 10;
            // 
            // BEliminarFiltro
            // 
            this.BEliminarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.BEliminarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BEliminarFiltro.ForeColor = System.Drawing.Color.IndianRed;
            this.BEliminarFiltro.Location = new System.Drawing.Point(268, 151);
            this.BEliminarFiltro.Name = "BEliminarFiltro";
            this.BEliminarFiltro.Size = new System.Drawing.Size(64, 23);
            this.BEliminarFiltro.TabIndex = 20;
            this.BEliminarFiltro.Text = "Limpiar";
            this.BEliminarFiltro.UseVisualStyleBackColor = false;
            this.BEliminarFiltro.Click += new System.EventHandler(this.BEliminarFiltro_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TBBuscar.Location = new System.Drawing.Point(338, 151);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(145, 23);
            this.TBBuscar.TabIndex = 19;
            this.TBBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBuscar_KeyPress_1);
            // 
            // BBuscarFiltro
            // 
            this.BBuscarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.BBuscarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BBuscarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BBuscarFiltro.Location = new System.Drawing.Point(268, 151);
            this.BBuscarFiltro.Name = "BBuscarFiltro";
            this.BBuscarFiltro.Size = new System.Drawing.Size(64, 23);
            this.BBuscarFiltro.TabIndex = 18;
            this.BBuscarFiltro.Text = "Buscar";
            this.BBuscarFiltro.UseVisualStyleBackColor = false;
            this.BBuscarFiltro.Click += new System.EventHandler(this.BBuscarFiltro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(289, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Material:";
            // 
            // TBCategoria
            // 
            this.TBCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBCategoria.Location = new System.Drawing.Point(406, 49);
            this.TBCategoria.Name = "TBCategoria";
            this.TBCategoria.ReadOnly = true;
            this.TBCategoria.Size = new System.Drawing.Size(77, 23);
            this.TBCategoria.TabIndex = 16;
            this.TBCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.BackColor = System.Drawing.Color.Transparent;
            this.LCantidad.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.LCantidad.ForeColor = System.Drawing.Color.White;
            this.LCantidad.Location = new System.Drawing.Point(289, 94);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(56, 18);
            this.LCantidad.TabIndex = 14;
            this.LCantidad.Text = "Stock:";
            // 
            // TBCantidad
            // 
            this.TBCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBCantidad.Location = new System.Drawing.Point(406, 94);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.ReadOnly = true;
            this.TBCantidad.Size = new System.Drawing.Size(77, 23);
            this.TBCantidad.TabIndex = 13;
            this.TBCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Detalles:";
            // 
            // TBPrecio
            // 
            this.TBPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBPrecio.Location = new System.Drawing.Point(80, 41);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.ReadOnly = true;
            this.TBPrecio.Size = new System.Drawing.Size(120, 23);
            this.TBPrecio.TabIndex = 9;
            this.TBPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBDisponible
            // 
            this.TBDisponible.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBDisponible.Location = new System.Drawing.Point(406, 8);
            this.TBDisponible.Name = "TBDisponible";
            this.TBDisponible.ReadOnly = true;
            this.TBDisponible.Size = new System.Drawing.Size(77, 23);
            this.TBDisponible.TabIndex = 8;
            this.TBDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBNombre.Location = new System.Drawing.Point(80, 7);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.ReadOnly = true;
            this.TBNombre.Size = new System.Drawing.Size(120, 23);
            this.TBNombre.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.TBDescripcion);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 90);
            this.panel2.TabIndex = 6;
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDescripcion.Location = new System.Drawing.Point(3, 2);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.ReadOnly = true;
            this.TBDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBDescripcion.Size = new System.Drawing.Size(233, 87);
            this.TBDescripcion.TabIndex = 8;
            // 
            // LDisponibilidad
            // 
            this.LDisponibilidad.AutoSize = true;
            this.LDisponibilidad.BackColor = System.Drawing.Color.Transparent;
            this.LDisponibilidad.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.LDisponibilidad.ForeColor = System.Drawing.Color.White;
            this.LDisponibilidad.Location = new System.Drawing.Point(289, 8);
            this.LDisponibilidad.Name = "LDisponibilidad";
            this.LDisponibilidad.Size = new System.Drawing.Size(96, 18);
            this.LDisponibilidad.TabIndex = 3;
            this.LDisponibilidad.Text = "Disponible:";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.BackColor = System.Drawing.Color.Transparent;
            this.LPrecio.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.LPrecio.ForeColor = System.Drawing.Color.White;
            this.LPrecio.Location = new System.Drawing.Point(15, 43);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(64, 18);
            this.LPrecio.TabIndex = 1;
            this.LPrecio.Text = "Precio:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.Transparent;
            this.LNombre.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.LNombre.ForeColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(15, 6);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(64, 18);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // DGCatalogo
            // 
            this.DGCatalogo.AllowUserToAddRows = false;
            this.DGCatalogo.AllowUserToDeleteRows = false;
            this.DGCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGCatalogo.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CDescripcion,
            this.CPrecio,
            this.CDisponible,
            this.CImagen,
            this.stock,
            this.categoria});
            this.DGCatalogo.Location = new System.Drawing.Point(0, 189);
            this.DGCatalogo.Name = "DGCatalogo";
            this.DGCatalogo.ReadOnly = true;
            this.DGCatalogo.RowHeadersVisible = false;
            this.DGCatalogo.RowTemplate.Height = 25;
            this.DGCatalogo.Size = new System.Drawing.Size(801, 272);
            this.DGCatalogo.TabIndex = 8;
            this.DGCatalogo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCatalogo_CellClick_1);
            // 
            // CNombre
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CNombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.CNombre.FillWeight = 122.8372F;
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CDescripcion
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CDescripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.CDescripcion.FillWeight = 168.1651F;
            this.CDescripcion.HeaderText = "Descripcion";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            // 
            // CPrecio
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CPrecio.DefaultCellStyle = dataGridViewCellStyle4;
            this.CPrecio.FillWeight = 57.86869F;
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            // 
            // CDisponible
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CDisponible.DefaultCellStyle = dataGridViewCellStyle5;
            this.CDisponible.FillWeight = 82.5339F;
            this.CDisponible.HeaderText = "Disponible";
            this.CDisponible.Name = "CDisponible";
            this.CDisponible.ReadOnly = true;
            // 
            // CImagen
            // 
            this.CImagen.FillWeight = 106.599F;
            this.CImagen.HeaderText = "Imagen";
            this.CImagen.Name = "CImagen";
            this.CImagen.ReadOnly = true;
            // 
            // stock
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.stock.DefaultCellStyle = dataGridViewCellStyle6;
            this.stock.FillWeight = 53.60169F;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // categoria
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.categoria.DefaultCellStyle = dataGridViewCellStyle7;
            this.categoria.FillWeight = 108.3945F;
            this.categoria.HeaderText = "categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(798, 461);
            this.Controls.Add(this.LTexto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoProducto";
            this.Text = "ListadoProducto";
            this.Load += new System.EventHandler(this.ListadoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LTexto;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private TextBox TBCategoria;
        private Label LCantidad;
        private TextBox TBCantidad;
        private Label label2;
        private TextBox TBPrecio;
        private TextBox TBDisponible;
        private TextBox TBNombre;
        private Panel panel2;
        private TextBox TBDescripcion;
        private Label LDisponibilidad;
        private Label LPrecio;
        private Label LNombre;
        private DataGridView DGCatalogo;
        private TextBox TBBuscar;
        private Button BBuscarFiltro;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewTextBoxColumn CDescripcion;
        private DataGridViewTextBoxColumn CPrecio;
        private DataGridViewTextBoxColumn CDisponible;
        private DataGridViewImageColumn CImagen;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn categoria;
        private Button BEliminarFiltro;
        private ErrorProvider errorProvider1;
    }
}