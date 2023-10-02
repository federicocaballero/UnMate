namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores
{
    partial class PedidoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoProveedores));
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.TBImporte = new System.Windows.Forms.TextBox();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.TFecha = new System.Windows.Forms.DateTimePicker();
            this.GridPedidos = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAñadir = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BBorrarListado = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscarProveedor = new System.Windows.Forms.TextBox();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BLimpiarProducto = new System.Windows.Forms.Button();
            this.BLimpiarProveedor = new System.Windows.Forms.Button();
            this.BBuscarProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LListaProductos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBProducto
            // 
            this.TBProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProducto.Location = new System.Drawing.Point(106, 51);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.Size = new System.Drawing.Size(144, 21);
            this.TBProducto.TabIndex = 1;
            this.TBProducto.TextChanged += new System.EventHandler(this.TBProducto_TextChanged);
            this.TBProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBProducto_KeyPress);
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(106, 76);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBDescripcion.Size = new System.Drawing.Size(221, 89);
            this.TBDescripcion.TabIndex = 2;
            this.TBDescripcion.TextChanged += new System.EventHandler(this.TBDescripcion_TextChanged);
            // 
            // TBCantidad
            // 
            this.TBCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCantidad.Location = new System.Drawing.Point(433, 64);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(110, 21);
            this.TBCantidad.TabIndex = 3;
            this.TBCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCantidad_KeyPress);
            this.TBCantidad.Leave += new System.EventHandler(this.TBUnidades_Leave);
            // 
            // TBImporte
            // 
            this.TBImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBImporte.Location = new System.Drawing.Point(433, 89);
            this.TBImporte.Name = "TBImporte";
            this.TBImporte.ReadOnly = true;
            this.TBImporte.Size = new System.Drawing.Size(110, 21);
            this.TBImporte.TabIndex = 4;
            this.TBImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBProveedor
            // 
            this.TBProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProveedor.Location = new System.Drawing.Point(433, 114);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.Size = new System.Drawing.Size(110, 21);
            this.TBProveedor.TabIndex = 5;
            this.TBProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBProveedor_KeyPress);
            // 
            // TFecha
            // 
            this.TFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TFecha.Location = new System.Drawing.Point(433, 140);
            this.TFecha.Name = "TFecha";
            this.TFecha.Size = new System.Drawing.Size(110, 20);
            this.TFecha.TabIndex = 6;
            // 
            // GridPedidos
            // 
            this.GridPedidos.AllowUserToAddRows = false;
            this.GridPedidos.AllowUserToDeleteRows = false;
            this.GridPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPedidos.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.descripcion,
            this.proveedor,
            this.fecha,
            this.cantidad,
            this.importe});
            this.GridPedidos.Location = new System.Drawing.Point(-3, 218);
            this.GridPedidos.Name = "GridPedidos";
            this.GridPedidos.ReadOnly = true;
            this.GridPedidos.RowHeadersVisible = false;
            this.GridPedidos.Size = new System.Drawing.Size(807, 225);
            this.GridPedidos.TabIndex = 7;
            this.GridPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // importe
            // 
            this.importe.HeaderText = "Cantidad";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // BAñadir
            // 
            this.BAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAñadir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BAñadir.ForeColor = System.Drawing.Color.Blue;
            this.BAñadir.Image = ((System.Drawing.Image)(resources.GetObject("BAñadir.Image")));
            this.BAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAñadir.Location = new System.Drawing.Point(648, 32);
            this.BAñadir.Name = "BAñadir";
            this.BAñadir.Size = new System.Drawing.Size(123, 53);
            this.BAñadir.TabIndex = 8;
            this.BAñadir.Text = "Guardar pedido";
            this.BAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAñadir.UseVisualStyleBackColor = true;
            this.BAñadir.Click += new System.EventHandler(this.BAñadir_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.Location = new System.Drawing.Point(648, 89);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(123, 53);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar pedido";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BBorrarListado
            // 
            this.BBorrarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBorrarListado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BBorrarListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BBorrarListado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrarListado.Location = new System.Drawing.Point(648, 148);
            this.BBorrarListado.Name = "BBorrarListado";
            this.BBorrarListado.Size = new System.Drawing.Size(123, 53);
            this.BBorrarListado.TabIndex = 10;
            this.BBorrarListado.Text = "Borrar lista";
            this.BBorrarListado.UseVisualStyleBackColor = true;
            this.BBorrarListado.Click += new System.EventHandler(this.BBorrarListado_Click);
            // 
            // BBuscar
            // 
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BBuscar.Location = new System.Drawing.Point(10, 192);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(75, 20);
            this.BBuscar.TabIndex = 11;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // TBBuscarProveedor
            // 
            this.TBBuscarProveedor.Location = new System.Drawing.Point(91, 192);
            this.TBBuscarProveedor.Name = "TBBuscarProveedor";
            this.TBBuscarProveedor.Size = new System.Drawing.Size(123, 20);
            this.TBBuscarProveedor.TabIndex = 12;
            this.TBBuscarProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBuscarProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBuscar_KeyPress);
            // 
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BLimpiarFiltros.Location = new System.Drawing.Point(220, 192);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(107, 20);
            this.BLimpiarFiltros.TabIndex = 13;
            this.BLimpiarFiltros.Text = "Limpiar filtros";
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            this.BLimpiarFiltros.Click += new System.EventHandler(this.BLimpiarFiltros_Click);
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.BBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarProducto.Image")));
            this.BBuscarProducto.Location = new System.Drawing.Point(268, 52);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(52, 20);
            this.BBuscarProducto.TabIndex = 14;
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            this.BBuscarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BLimpiarProducto
            // 
            this.BLimpiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BLimpiarProducto.Location = new System.Drawing.Point(268, 49);
            this.BLimpiarProducto.Name = "BLimpiarProducto";
            this.BLimpiarProducto.Size = new System.Drawing.Size(59, 22);
            this.BLimpiarProducto.TabIndex = 15;
            this.BLimpiarProducto.Text = "Limpiar ";
            this.BLimpiarProducto.UseVisualStyleBackColor = true;
            this.BLimpiarProducto.Click += new System.EventHandler(this.BLimpiarProducto_Click);
            // 
            // BLimpiarProveedor
            // 
            this.BLimpiarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BLimpiarProveedor.Location = new System.Drawing.Point(566, 115);
            this.BLimpiarProveedor.Name = "BLimpiarProveedor";
            this.BLimpiarProveedor.Size = new System.Drawing.Size(59, 22);
            this.BLimpiarProveedor.TabIndex = 16;
            this.BLimpiarProveedor.Text = "Limpiar ";
            this.BLimpiarProveedor.UseVisualStyleBackColor = true;
            this.BLimpiarProveedor.Click += new System.EventHandler(this.BLimpiarProveedor_Click);
            // 
            // BBuscarProveedor
            // 
            this.BBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BBuscarProveedor.Location = new System.Drawing.Point(566, 114);
            this.BBuscarProveedor.Name = "BBuscarProveedor";
            this.BBuscarProveedor.Size = new System.Drawing.Size(59, 23);
            this.BBuscarProveedor.TabIndex = 17;
            this.BBuscarProveedor.Text = "Buscar";
            this.BBuscarProveedor.UseVisualStyleBackColor = true;
            this.BBuscarProveedor.Click += new System.EventHandler(this.BBuscarProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(347, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Unidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(347, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(347, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Importe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(347, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Fecha";
            // 
            // LListaProductos
            // 
            this.LListaProductos.AutoSize = true;
            this.LListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LListaProductos.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.LListaProductos.ForeColor = System.Drawing.Color.White;
            this.LListaProductos.Location = new System.Drawing.Point(306, 9);
            this.LListaProductos.Name = "LListaProductos";
            this.LListaProductos.Size = new System.Drawing.Size(226, 24);
            this.LListaProductos.TabIndex = 48;
            this.LListaProductos.Text = "Pedido proveedores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(102, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Nombre proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(135, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 126;
            this.label8.Text = "Titulo producto";
            // 
            // PedidoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 443);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LListaProductos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BBuscarProveedor);
            this.Controls.Add(this.BLimpiarProveedor);
            this.Controls.Add(this.BLimpiarProducto);
            this.Controls.Add(this.BBuscarProducto);
            this.Controls.Add(this.BLimpiarFiltros);
            this.Controls.Add(this.TBBuscarProveedor);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BBorrarListado);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BAñadir);
            this.Controls.Add(this.GridPedidos);
            this.Controls.Add(this.TFecha);
            this.Controls.Add(this.TBProveedor);
            this.Controls.Add(this.TBImporte);
            this.Controls.Add(this.TBCantidad);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.TBProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidoProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidoProveedores";
            this.Load += new System.EventHandler(this.PedidoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBProducto;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.TextBox TBImporte;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.DateTimePicker TFecha;
        private System.Windows.Forms.DataGridView GridPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Button BAñadir;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BBorrarListado;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.TextBox TBBuscarProveedor;
        private System.Windows.Forms.Button BLimpiarFiltros;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BLimpiarProducto;
        private System.Windows.Forms.Button BLimpiarProveedor;
        private System.Windows.Forms.Button BBuscarProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LListaProductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}