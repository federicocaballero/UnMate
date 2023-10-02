using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    partial class ListadoVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridListadoVentas = new System.Windows.Forms.DataGridView();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.Ltitulo = new System.Windows.Forms.Label();
            this.TBTotalRecaudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBFechaBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridListadoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridListadoVentas
            // 
            this.GridListadoVentas.AllowUserToAddRows = false;
            this.GridListadoVentas.AllowUserToDeleteRows = false;
            this.GridListadoVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListadoVentas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridListadoVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListadoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListadoVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factura,
            this.usuario,
            this.DNI,
            this.descripcion,
            this.fecha,
            this.total,
            this.pago,
            this.detalles});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListadoVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridListadoVentas.Location = new System.Drawing.Point(-2, 114);
            this.GridListadoVentas.Name = "GridListadoVentas";
            this.GridListadoVentas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListadoVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridListadoVentas.RowHeadersVisible = false;
            this.GridListadoVentas.RowTemplate.Height = 25;
            this.GridListadoVentas.Size = new System.Drawing.Size(806, 320);
            this.GridListadoVentas.TabIndex = 0;
            this.GridListadoVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListadoVentas_CellContentClick_1);
            // 
            // BBuscar
            // 
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Location = new System.Drawing.Point(6, 84);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(86, 22);
            this.BBuscar.TabIndex = 20;
            this.BBuscar.Text = "Busqueda";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click_1);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscar.Location = new System.Drawing.Point(98, 83);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(114, 23);
            this.TBBuscar.TabIndex = 19;
            this.TBBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RB1.ForeColor = System.Drawing.Color.White;
            this.RB1.Location = new System.Drawing.Point(89, 64);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(36, 17);
            this.RB1.TabIndex = 21;
            this.RB1.TabStop = true;
            this.RB1.Text = "ID";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RB2.ForeColor = System.Drawing.Color.White;
            this.RB2.Location = new System.Drawing.Point(125, 64);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(65, 17);
            this.RB2.TabIndex = 22;
            this.RB2.TabStop = true;
            this.RB2.Text = "Usuario";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RB3.ForeColor = System.Drawing.Color.White;
            this.RB3.Location = new System.Drawing.Point(186, 64);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(44, 17);
            this.RB3.TabIndex = 23;
            this.RB3.TabStop = true;
            this.RB3.Text = "DNI";
            this.RB3.UseVisualStyleBackColor = true;
            // 
            // Ltitulo
            // 
            this.Ltitulo.AutoSize = true;
            this.Ltitulo.BackColor = System.Drawing.Color.Transparent;
            this.Ltitulo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.Ltitulo.ForeColor = System.Drawing.Color.White;
            this.Ltitulo.Location = new System.Drawing.Point(296, 17);
            this.Ltitulo.Name = "Ltitulo";
            this.Ltitulo.Size = new System.Drawing.Size(210, 22);
            this.Ltitulo.TabIndex = 25;
            this.Ltitulo.Text = "Mis ventas ralizadas";
            // 
            // TBTotalRecaudo
            // 
            this.TBTotalRecaudo.Location = new System.Drawing.Point(650, 35);
            this.TBTotalRecaudo.Name = "TBTotalRecaudo";
            this.TBTotalRecaudo.ReadOnly = true;
            this.TBTotalRecaudo.Size = new System.Drawing.Size(141, 20);
            this.TBTotalRecaudo.TabIndex = 26;
            this.TBTotalRecaudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(671, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Total recaudado";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(236, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Busqueda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBFechaBuscar
            // 
            this.TBFechaBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TBFechaBuscar.Location = new System.Drawing.Point(323, 83);
            this.TBFechaBuscar.Name = "TBFechaBuscar";
            this.TBFechaBuscar.Size = new System.Drawing.Size(98, 23);
            this.TBFechaBuscar.TabIndex = 33;
            this.TBFechaBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFechaBuscar_KeyPress_1);
            this.TBFechaBuscar.Validating += new System.ComponentModel.CancelEventHandler(this.TBFechaBuscar_Validating_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha de venta";
            // 
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BLimpiarFiltros.ForeColor = System.Drawing.Color.IndianRed;
            this.BLimpiarFiltros.Location = new System.Drawing.Point(471, 82);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(125, 23);
            this.BLimpiarFiltros.TabIndex = 38;
            this.BLimpiarFiltros.Text = "Limpiar filtros";
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            this.BLimpiarFiltros.Click += new System.EventHandler(this.BLimpiarFiltros_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(650, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 34);
            this.button2.TabIndex = 24;
            this.button2.Text = "Registrar venta";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // factura
            // 
            this.factura.FillWeight = 49.60587F;
            this.factura.HeaderText = "ID ";
            this.factura.Name = "factura";
            this.factura.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.FillWeight = 96.55159F;
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.FillWeight = 81.35124F;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 201.4667F;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.FillWeight = 99.75931F;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // total
            // 
            this.total.FillWeight = 73.70408F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // pago
            // 
            this.pago.FillWeight = 108.3253F;
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            // 
            // detalles
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.detalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.detalles.FillWeight = 75.33926F;
            this.detalles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.detalles.HeaderText = "Detalles";
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            // 
            // ListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(803, 436);
            this.Controls.Add(this.BLimpiarFiltros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBFechaBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBTotalRecaudo);
            this.Controls.Add(this.Ltitulo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RB3);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.RB1);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.TBBuscar);
            this.Controls.Add(this.GridListadoVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoVentas";
            this.Text = "ListadoVentas";
            this.Load += new System.EventHandler(this.ListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListadoVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridListadoVentas;
        private Button BBuscar;
        private TextBox TBBuscar;
        private RadioButton RB1;
        private RadioButton RB2;
        private RadioButton RB3;
        private Button button2;
        private Label Ltitulo;
        private TextBox TBTotalRecaudo;
        private Label label1;
        private Button button1;
        private TextBox TBFechaBuscar;
        private Label label2;
        private Button BLimpiarFiltros;
        private DataGridViewTextBoxColumn factura;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn pago;
        private DataGridViewButtonColumn detalles;
    }
}