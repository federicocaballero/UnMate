using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionVentas
{
    partial class ListadoVentasVendedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridListadoVendedores = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBFechaBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridListadoVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // GridListadoVendedores
            // 
            this.GridListadoVendedores.AllowUserToAddRows = false;
            this.GridListadoVendedores.AllowUserToDeleteRows = false;
            this.GridListadoVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListadoVendedores.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListadoVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListadoVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListadoVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendedor,
            this.usuarioVendedor,
            this.dniVendedor,
            this.nombreCliente,
            this.usuarioCliente,
            this.dniCliente,
            this.fechaVenta,
            this.total,
            this.detalles});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListadoVendedores.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridListadoVendedores.Location = new System.Drawing.Point(-1, 107);
            this.GridListadoVendedores.Name = "GridListadoVendedores";
            this.GridListadoVendedores.ReadOnly = true;
            this.GridListadoVendedores.RowHeadersVisible = false;
            this.GridListadoVendedores.RowTemplate.Height = 25;
            this.GridListadoVendedores.Size = new System.Drawing.Size(803, 344);
            this.GridListadoVendedores.TabIndex = 0;
            this.GridListadoVendedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListadoVendedores_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(310, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Listado de ventas";
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RB2.ForeColor = System.Drawing.Color.White;
            this.RB2.Location = new System.Drawing.Point(279, 79);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(44, 17);
            this.RB2.TabIndex = 28;
            this.RB2.TabStop = true;
            this.RB2.Text = "DNI";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RB1.ForeColor = System.Drawing.Color.White;
            this.RB1.Location = new System.Drawing.Point(218, 79);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(65, 17);
            this.RB1.TabIndex = 27;
            this.RB1.TabStop = true;
            this.RB1.Text = "Usuario";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // BBuscar
            // 
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Location = new System.Drawing.Point(7, 74);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(81, 25);
            this.BBuscar.TabIndex = 25;
            this.BBuscar.Text = "Busqueda";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscar.Location = new System.Drawing.Point(94, 76);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(114, 23);
            this.TBBuscar.TabIndex = 24;
            this.TBBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Información del vendedor ";
            // 
            // TBFechaBuscar
            // 
            this.TBFechaBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TBFechaBuscar.Location = new System.Drawing.Point(460, 77);
            this.TBFechaBuscar.Name = "TBFechaBuscar";
            this.TBFechaBuscar.Size = new System.Drawing.Size(91, 23);
            this.TBFechaBuscar.TabIndex = 35;
            this.TBFechaBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFechaBuscar_KeyPress);
            this.TBFechaBuscar.Validating += new System.ComponentModel.CancelEventHandler(this.TBFechaBuscar_Validating);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(373, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Busqueda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(460, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha de venta";
            // 
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarFiltros.ForeColor = System.Drawing.Color.IndianRed;
            this.BLimpiarFiltros.Location = new System.Drawing.Point(583, 76);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(92, 24);
            this.BLimpiarFiltros.TabIndex = 39;
            this.BLimpiarFiltros.Text = "Limpiar filtros";
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            this.BLimpiarFiltros.Click += new System.EventHandler(this.BLimpiarFiltros_Click);
            // 
            // vendedor
            // 
            this.vendedor.FillWeight = 103.8434F;
            this.vendedor.HeaderText = "Nombre vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            // 
            // usuarioVendedor
            // 
            this.usuarioVendedor.FillWeight = 103.8434F;
            this.usuarioVendedor.HeaderText = "Usuario";
            this.usuarioVendedor.Name = "usuarioVendedor";
            this.usuarioVendedor.ReadOnly = true;
            // 
            // dniVendedor
            // 
            this.dniVendedor.FillWeight = 103.8434F;
            this.dniVendedor.HeaderText = "DNI";
            this.dniVendedor.Name = "dniVendedor";
            this.dniVendedor.ReadOnly = true;
            // 
            // nombreCliente
            // 
            this.nombreCliente.FillWeight = 103.8434F;
            this.nombreCliente.HeaderText = "Nombre cliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            // 
            // usuarioCliente
            // 
            this.usuarioCliente.HeaderText = "Usuario cliente";
            this.usuarioCliente.Name = "usuarioCliente";
            this.usuarioCliente.ReadOnly = true;
            // 
            // dniCliente
            // 
            this.dniCliente.FillWeight = 103.8434F;
            this.dniCliente.HeaderText = "DNI cliente";
            this.dniCliente.Name = "dniCliente";
            this.dniCliente.ReadOnly = true;
            // 
            // fechaVenta
            // 
            this.fechaVenta.FillWeight = 103.8434F;
            this.fechaVenta.HeaderText = "Fecha venta";
            this.fechaVenta.Name = "fechaVenta";
            this.fechaVenta.ReadOnly = true;
            // 
            // total
            // 
            this.total.FillWeight = 103.8434F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // detalles
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.detalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.detalles.FillWeight = 73.09644F;
            this.detalles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.detalles.HeaderText = "Detalles";
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            this.detalles.Text = "VER DETALLES";
            // 
            // ListadoVentasVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.BLimpiarFiltros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBFechaBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.RB1);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.TBBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GridListadoVendedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoVentasVendedores";
            this.Text = "ListadoVentas";
            this.Load += new System.EventHandler(this.ListadoVentasVendedores_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GridListadoVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridListadoVendedores;
        private Label label4;
        private RadioButton RB1;
        private RadioButton RB2;
        private Button BBuscar;
        private TextBox TBBuscar;
        private Label label1;
        private TextBox TBFechaBuscar;
        private Button button1;
        private Label label2;
        private Button BLimpiarFiltros;
        private DataGridViewTextBoxColumn vendedor;
        private DataGridViewTextBoxColumn usuarioVendedor;
        private DataGridViewTextBoxColumn dniVendedor;
        private DataGridViewTextBoxColumn nombreCliente;
        private DataGridViewTextBoxColumn usuarioCliente;
        private DataGridViewTextBoxColumn dniCliente;
        private DataGridViewTextBoxColumn fechaVenta;
        private DataGridViewTextBoxColumn total;
        private DataGridViewButtonColumn detalles;
    }
}