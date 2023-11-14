using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    partial class RegistrarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.TBBuscarUnProducto = new System.Windows.Forms.TextBox();
            this.TBIDVenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BCancelarCompra = new System.Windows.Forms.Button();
            this.TBTotalPago = new System.Windows.Forms.TextBox();
            this.TBVendedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.BBuscar = new System.Windows.Forms.Button();
            this.BtnCompra = new System.Windows.Forms.Button();
            this.TBNombreVendedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.TBCliente = new System.Windows.Forms.TextBox();
            this.BVaciarCarrito = new System.Windows.Forms.Button();
            this.LVCompra = new System.Windows.Forms.ListView();
            this.producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preciounitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GridProductosParaVenta = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.BCarrito = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.CBPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductosParaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.LTitulo.Location = new System.Drawing.Point(275, 1);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(146, 25);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Registrar venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.BBuscarProducto);
            this.groupBox1.Controls.Add(this.TBBuscarUnProducto);
            this.groupBox1.Controls.Add(this.TBIDVenta);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BCancelarCompra);
            this.groupBox1.Controls.Add(this.TBTotalPago);
            this.groupBox1.Controls.Add(this.TBVendedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TBDescripcion);
            this.groupBox1.Controls.Add(this.BLimpiar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TBPrecio);
            this.groupBox1.Controls.Add(this.BBuscar);
            this.groupBox1.Controls.Add(this.BtnCompra);
            this.groupBox1.Controls.Add(this.TBNombreVendedor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TBProducto);
            this.groupBox1.Controls.Add(this.TBCliente);
            this.groupBox1.Controls.Add(this.BVaciarCarrito);
            this.groupBox1.Controls.Add(this.LVCompra);
            this.groupBox1.Controls.Add(this.GridProductosParaVenta);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BCarrito);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TBCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LUsuario);
            this.groupBox1.Controls.Add(this.CBPago);
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 405);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(504, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Cod producto";
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.ForeColor = System.Drawing.Color.IndianRed;
            this.BBuscarProducto.Location = new System.Drawing.Point(378, 12);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(120, 22);
            this.BBuscarProducto.TabIndex = 28;
            this.BBuscarProducto.Text = "Buscar producto";
            this.BBuscarProducto.UseVisualStyleBackColor = false;
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // TBBuscarUnProducto
            // 
            this.TBBuscarUnProducto.Location = new System.Drawing.Point(504, 14);
            this.TBBuscarUnProducto.Name = "TBBuscarUnProducto";
            this.TBBuscarUnProducto.Size = new System.Drawing.Size(85, 20);
            this.TBBuscarUnProducto.TabIndex = 27;
            this.TBBuscarUnProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBuscarUnProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBuscarUnProducto_KeyPress);
            // 
            // TBIDVenta
            // 
            this.TBIDVenta.Enabled = false;
            this.TBIDVenta.Location = new System.Drawing.Point(294, 12);
            this.TBIDVenta.Name = "TBIDVenta";
            this.TBIDVenta.ReadOnly = true;
            this.TBIDVenta.Size = new System.Drawing.Size(65, 20);
            this.TBIDVenta.TabIndex = 24;
            this.TBIDVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(229, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "ID Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(591, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "TOTAL A PAGAR";
            // 
            // BCancelarCompra
            // 
            this.BCancelarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCancelarCompra.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BCancelarCompra.Image = ((System.Drawing.Image)(resources.GetObject("BCancelarCompra.Image")));
            this.BCancelarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelarCompra.Location = new System.Drawing.Point(17, 353);
            this.BCancelarCompra.Name = "BCancelarCompra";
            this.BCancelarCompra.Size = new System.Drawing.Size(103, 37);
            this.BCancelarCompra.TabIndex = 26;
            this.BCancelarCompra.Text = "Cancelar";
            this.BCancelarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelarCompra.UseVisualStyleBackColor = false;
            this.BCancelarCompra.Click += new System.EventHandler(this.BCancelarCompra_Click_1);
            // 
            // TBTotalPago
            // 
            this.TBTotalPago.Location = new System.Drawing.Point(599, 369);
            this.TBTotalPago.Name = "TBTotalPago";
            this.TBTotalPago.ReadOnly = true;
            this.TBTotalPago.Size = new System.Drawing.Size(92, 20);
            this.TBTotalPago.TabIndex = 16;
            this.TBTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBVendedor
            // 
            this.TBVendedor.Enabled = false;
            this.TBVendedor.Location = new System.Drawing.Point(111, 12);
            this.TBVendedor.Name = "TBVendedor";
            this.TBVendedor.ReadOnly = true;
            this.TBVendedor.Size = new System.Drawing.Size(64, 20);
            this.TBVendedor.TabIndex = 20;
            this.TBVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(16, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID vendedor:";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(17, 189);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.ReadOnly = true;
            this.TBDescripcion.Size = new System.Drawing.Size(343, 36);
            this.TBDescripcion.TabIndex = 21;
            this.TBDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BLimpiar
            // 
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Segoe UI", 6.75F);
            this.BLimpiar.ForeColor = System.Drawing.Color.IndianRed;
            this.BLimpiar.Location = new System.Drawing.Point(167, 102);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(45, 21);
            this.BLimpiar.TabIndex = 25;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = true;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(254, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Precio unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(158, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Descripcion";
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(231, 148);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.ReadOnly = true;
            this.TBPrecio.Size = new System.Drawing.Size(128, 20);
            this.TBPrecio.TabIndex = 23;
            this.TBPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BBuscar
            // 
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BBuscar.Image")));
            this.BBuscar.Location = new System.Drawing.Point(167, 103);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(45, 21);
            this.BBuscar.TabIndex = 22;
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click_1);
            // 
            // BtnCompra
            // 
            this.BtnCompra.BackColor = System.Drawing.Color.Wheat;
            this.BtnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCompra.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompra.Image = ((System.Drawing.Image)(resources.GetObject("BtnCompra.Image")));
            this.BtnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompra.Location = new System.Drawing.Point(313, 354);
            this.BtnCompra.Name = "BtnCompra";
            this.BtnCompra.Size = new System.Drawing.Size(158, 36);
            this.BtnCompra.TabIndex = 15;
            this.BtnCompra.Text = "Registrar venta";
            this.BtnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCompra.UseVisualStyleBackColor = false;
            this.BtnCompra.Click += new System.EventHandler(this.BtnCompra_Click_1);
            // 
            // TBNombreVendedor
            // 
            this.TBNombreVendedor.Enabled = false;
            this.TBNombreVendedor.Location = new System.Drawing.Point(9, 55);
            this.TBNombreVendedor.Name = "TBNombreVendedor";
            this.TBNombreVendedor.ReadOnly = true;
            this.TBNombreVendedor.Size = new System.Drawing.Size(137, 20);
            this.TBNombreVendedor.TabIndex = 21;
            this.TBNombreVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(46, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Vendedor";
            // 
            // TBProducto
            // 
            this.TBProducto.Location = new System.Drawing.Point(233, 55);
            this.TBProducto.Multiline = true;
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.ReadOnly = true;
            this.TBProducto.Size = new System.Drawing.Size(128, 20);
            this.TBProducto.TabIndex = 19;
            this.TBProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBCliente
            // 
            this.TBCliente.Location = new System.Drawing.Point(9, 104);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.Size = new System.Drawing.Size(137, 20);
            this.TBCliente.TabIndex = 18;
            this.TBCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBUsuario_KeyPress_1);
            // 
            // BVaciarCarrito
            // 
            this.BVaciarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BVaciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BVaciarCarrito.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVaciarCarrito.Image = ((System.Drawing.Image)(resources.GetObject("BVaciarCarrito.Image")));
            this.BVaciarCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVaciarCarrito.Location = new System.Drawing.Point(146, 353);
            this.BVaciarCarrito.Name = "BVaciarCarrito";
            this.BVaciarCarrito.Size = new System.Drawing.Size(144, 37);
            this.BVaciarCarrito.TabIndex = 18;
            this.BVaciarCarrito.Text = "Vaciar carrito";
            this.BVaciarCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVaciarCarrito.UseVisualStyleBackColor = false;
            this.BVaciarCarrito.Click += new System.EventHandler(this.BVaciarCarrito_Click_1);
            // 
            // LVCompra
            // 
            this.LVCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.producto,
            this.descripcion,
            this.cantidad,
            this.preciounitario,
            this.subtotal});
            this.LVCompra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVCompra.ForeColor = System.Drawing.Color.Black;
            this.LVCompra.GridLines = true;
            this.LVCompra.HideSelection = false;
            this.LVCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LVCompra.Location = new System.Drawing.Point(17, 230);
            this.LVCompra.Name = "LVCompra";
            this.LVCompra.Size = new System.Drawing.Size(675, 118);
            this.LVCompra.TabIndex = 15;
            this.LVCompra.UseCompatibleStateImageBehavior = false;
            this.LVCompra.View = System.Windows.Forms.View.Details;
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            this.producto.Width = 200;
            // 
            // descripcion
            // 
            this.descripcion.Text = "Descripcion";
            this.descripcion.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.Width = 100;
            // 
            // preciounitario
            // 
            this.preciounitario.Text = "Unitario";
            this.preciounitario.Width = 80;
            // 
            // subtotal
            // 
            this.subtotal.Text = "Subtotal";
            this.subtotal.Width = 80;
            // 
            // GridProductosParaVenta
            // 
            this.GridProductosParaVenta.AllowUserToAddRows = false;
            this.GridProductosParaVenta.AllowUserToDeleteRows = false;
            this.GridProductosParaVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProductosParaVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProductosParaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProductosParaVenta.Location = new System.Drawing.Point(372, 35);
            this.GridProductosParaVenta.Name = "GridProductosParaVenta";
            this.GridProductosParaVenta.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProductosParaVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridProductosParaVenta.RowHeadersVisible = false;
            this.GridProductosParaVenta.RowTemplate.Height = 25;
            this.GridProductosParaVenta.Size = new System.Drawing.Size(325, 154);
            this.GridProductosParaVenta.TabIndex = 17;
            this.GridProductosParaVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProductosParaVenta_CellDoubleClick_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(231, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 19);
            this.button2.TabIndex = 16;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BCarrito
            // 
            this.BCarrito.BackColor = System.Drawing.Color.Indigo;
            this.BCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCarrito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BCarrito.ForeColor = System.Drawing.Color.Black;
            this.BCarrito.Image = ((System.Drawing.Image)(resources.GetObject("BCarrito.Image")));
            this.BCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCarrito.Location = new System.Drawing.Point(462, 192);
            this.BCarrito.Name = "BCarrito";
            this.BCarrito.Size = new System.Drawing.Size(142, 33);
            this.BCarrito.TabIndex = 14;
            this.BCarrito.Text = "Añadir al carrito";
            this.BCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCarrito.UseVisualStyleBackColor = false;
            this.BCarrito.Click += new System.EventHandler(this.BCarrito_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(335, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 19);
            this.button3.TabIndex = 15;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(269, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(232, 102);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.ReadOnly = true;
            this.TBCantidad.Size = new System.Drawing.Size(128, 20);
            this.TBCantidad.TabIndex = 7;
            this.TBCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCantidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(274, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Método pago";
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LUsuario.Location = new System.Drawing.Point(36, 87);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(85, 17);
            this.LUsuario.TabIndex = 2;
            this.LUsuario.Text = "Cliente (dni)";
            // 
            // CBPago
            // 
            this.CBPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPago.FormattingEnabled = true;
            this.CBPago.Location = new System.Drawing.Point(9, 147);
            this.CBPago.Name = "CBPago";
            this.CBPago.Size = new System.Drawing.Size(136, 21);
            this.CBPago.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(533, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha actual";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(623, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(707, 432);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarVenta";
            this.Load += new System.EventHandler(this.RegistrarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductosParaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LTitulo;
        private GroupBox groupBox1;
        private TextBox TBCantidad;
        private Label label2;
        private Label label1;
        private Label LUsuario;
        private ComboBox CBPago;
        private Label label3;
        private Label label4;
        private Button BCarrito;
        private ListView LVCompra;
        private ColumnHeader producto;
        private ColumnHeader cantidad;
        private ColumnHeader preciounitario;
        private ColumnHeader subtotal;
        private Button BtnCompra;
        private Button button2;
        private Button button3;
        private TextBox TBTotalPago;
        private Label label6;
        private Button BVaciarCarrito;
        private DataGridView GridProductosParaVenta;
        private TextBox TBCliente;
        private Label label5;
        private TextBox TBProducto;
        private TextBox TBDescripcion;
        private Label label7;
        private TextBox TBVendedor;
        private TextBox TBNombreVendedor;
        private Label label8;
        private ColumnHeader descripcion;
        private Button BBuscar;
        private Label label9;
        private TextBox TBPrecio;
        private Button BLimpiar;
        private DateTimePicker dateTimePicker1;
        private Button BCancelarCompra;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private TextBox TBIDVenta;
        private Label label10;
        private Button BBuscarProducto;
        private TextBox TBBuscarUnProducto;
        private Label label11;
    }
}