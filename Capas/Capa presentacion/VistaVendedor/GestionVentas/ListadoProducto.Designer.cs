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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TBColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BEliminarFiltro = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.BBuscarFiltro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TBCategoria = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.LPrecio = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.DGCatalogo = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TBColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BEliminarFiltro);
            this.panel1.Controls.Add(this.TBBuscar);
            this.panel1.Controls.Add(this.BBuscarFiltro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBCategoria);
            this.panel1.Controls.Add(this.LCantidad);
            this.panel1.Controls.Add(this.TBCantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBPrecio);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LPrecio);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Location = new System.Drawing.Point(215, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 184);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(397, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cod de producto";
            // 
            // TBColor
            // 
            this.TBColor.Enabled = false;
            this.TBColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBColor.Location = new System.Drawing.Point(437, 43);
            this.TBColor.Name = "TBColor";
            this.TBColor.ReadOnly = true;
            this.TBColor.Size = new System.Drawing.Size(106, 23);
            this.TBColor.TabIndex = 22;
            this.TBColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Color:";
            // 
            // BEliminarFiltro
            // 
            this.BEliminarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.BEliminarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BEliminarFiltro.ForeColor = System.Drawing.Color.IndianRed;
            this.BEliminarFiltro.Location = new System.Drawing.Point(319, 148);
            this.BEliminarFiltro.Name = "BEliminarFiltro";
            this.BEliminarFiltro.Size = new System.Drawing.Size(64, 24);
            this.BEliminarFiltro.TabIndex = 20;
            this.BEliminarFiltro.Text = "Limpiar";
            this.BEliminarFiltro.UseVisualStyleBackColor = false;
            this.BEliminarFiltro.Click += new System.EventHandler(this.BEliminarFiltro_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TBBuscar.Location = new System.Drawing.Point(389, 149);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(145, 23);
            this.TBBuscar.TabIndex = 19;
            this.TBBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBuscar_KeyPress_1);
            // 
            // BBuscarFiltro
            // 
            this.BBuscarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.BBuscarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BBuscarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BBuscarFiltro.Location = new System.Drawing.Point(319, 149);
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
            this.label3.Location = new System.Drawing.Point(336, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Material:";
            // 
            // TBCategoria
            // 
            this.TBCategoria.Enabled = false;
            this.TBCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBCategoria.Location = new System.Drawing.Point(437, 7);
            this.TBCategoria.Name = "TBCategoria";
            this.TBCategoria.ReadOnly = true;
            this.TBCategoria.Size = new System.Drawing.Size(106, 23);
            this.TBCategoria.TabIndex = 16;
            this.TBCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.BackColor = System.Drawing.Color.Transparent;
            this.LCantidad.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.LCantidad.ForeColor = System.Drawing.Color.White;
            this.LCantidad.Location = new System.Drawing.Point(336, 81);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(56, 18);
            this.LCantidad.TabIndex = 14;
            this.LCantidad.Text = "Stock:";
            // 
            // TBCantidad
            // 
            this.TBCantidad.Enabled = false;
            this.TBCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBCantidad.Location = new System.Drawing.Point(437, 80);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.ReadOnly = true;
            this.TBCantidad.Size = new System.Drawing.Size(106, 23);
            this.TBCantidad.TabIndex = 13;
            this.TBCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Detalles:";
            // 
            // TBPrecio
            // 
            this.TBPrecio.Enabled = false;
            this.TBPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBPrecio.Location = new System.Drawing.Point(80, 37);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.ReadOnly = true;
            this.TBPrecio.Size = new System.Drawing.Size(120, 23);
            this.TBPrecio.TabIndex = 9;
            this.TBPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBNombre
            // 
            this.TBNombre.Enabled = false;
            this.TBNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBNombre.Location = new System.Drawing.Point(80, 7);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.ReadOnly = true;
            this.TBNombre.Size = new System.Drawing.Size(234, 23);
            this.TBNombre.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.TBDescripcion);
            this.panel2.Enabled = false;
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
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.BackColor = System.Drawing.Color.Transparent;
            this.LPrecio.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.LPrecio.ForeColor = System.Drawing.Color.White;
            this.LPrecio.Location = new System.Drawing.Point(15, 39);
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
            this.LNombre.Location = new System.Drawing.Point(15, 8);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCatalogo.Location = new System.Drawing.Point(0, 189);
            this.DGCatalogo.Name = "DGCatalogo";
            this.DGCatalogo.ReadOnly = true;
            this.DGCatalogo.RowHeadersVisible = false;
            this.DGCatalogo.RowTemplate.Height = 25;
            this.DGCatalogo.Size = new System.Drawing.Size(801, 272);
            this.DGCatalogo.TabIndex = 8;
            this.DGCatalogo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCatalogo_CellContentDoubleClick);
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

        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private TextBox TBCategoria;
        private Label LCantidad;
        private TextBox TBCantidad;
        private Label label2;
        private TextBox TBPrecio;
        private TextBox TBNombre;
        private Panel panel2;
        private TextBox TBDescripcion;
        private Label LPrecio;
        private Label LNombre;
        private DataGridView DGCatalogo;
        private TextBox TBBuscar;
        private Button BBuscarFiltro;
        private Button BEliminarFiltro;
        private ErrorProvider errorProvider1;
        private TextBox TBColor;
        private Label label1;
        private Label label4;
    }
}