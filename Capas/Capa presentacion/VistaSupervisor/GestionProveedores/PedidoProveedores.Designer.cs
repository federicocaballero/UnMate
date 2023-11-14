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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoProveedores));
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.TBImporte = new System.Windows.Forms.TextBox();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.TFecha = new System.Windows.Forms.DateTimePicker();
            this.GridPedidos = new System.Windows.Forms.DataGridView();
            this.BAñadir = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BBorrarListado = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscarProveedor = new System.Windows.Forms.TextBox();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BLimpiarProducto = new System.Windows.Forms.Button();
            this.BLimpiarProveedor = new System.Windows.Forms.Button();
            this.BBuscarProveedor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LListaProductos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BConfirmar = new System.Windows.Forms.Button();
            this.BHistorialPedidos = new System.Windows.Forms.Button();
            this.BCatalogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBProducto
            // 
            this.TBProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProducto.Location = new System.Drawing.Point(106, 51);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.Size = new System.Drawing.Size(221, 21);
            this.TBProducto.TabIndex = 1;
            this.TBProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.TBCantidad.Location = new System.Drawing.Point(446, 49);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(137, 21);
            this.TBCantidad.TabIndex = 3;
            this.TBCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCantidad_KeyPress);
            // 
            // TBImporte
            // 
            this.TBImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBImporte.Location = new System.Drawing.Point(446, 76);
            this.TBImporte.Name = "TBImporte";
            this.TBImporte.ReadOnly = true;
            this.TBImporte.Size = new System.Drawing.Size(137, 21);
            this.TBImporte.TabIndex = 4;
            this.TBImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBProveedor
            // 
            this.TBProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProveedor.Location = new System.Drawing.Point(363, 153);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.Size = new System.Drawing.Size(193, 21);
            this.TBProveedor.TabIndex = 5;
            this.TBProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBProveedor_KeyPress);
            // 
            // TFecha
            // 
            this.TFecha.Enabled = false;
            this.TFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TFecha.Location = new System.Drawing.Point(446, 103);
            this.TFecha.Name = "TFecha";
            this.TFecha.Size = new System.Drawing.Size(137, 20);
            this.TFecha.TabIndex = 6;
            // 
            // GridPedidos
            // 
            this.GridPedidos.AllowUserToAddRows = false;
            this.GridPedidos.AllowUserToDeleteRows = false;
            this.GridPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPedidos.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPedidos.Location = new System.Drawing.Point(-3, 218);
            this.GridPedidos.Name = "GridPedidos";
            this.GridPedidos.ReadOnly = true;
            this.GridPedidos.RowHeadersVisible = false;
            this.GridPedidos.Size = new System.Drawing.Size(807, 225);
            this.GridPedidos.TabIndex = 7;
            this.GridPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BAñadir
            // 
            this.BAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAñadir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BAñadir.ForeColor = System.Drawing.Color.Blue;
            this.BAñadir.Image = ((System.Drawing.Image)(resources.GetObject("BAñadir.Image")));
            this.BAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAñadir.Location = new System.Drawing.Point(658, 12);
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
            this.BEliminar.Location = new System.Drawing.Point(658, 74);
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
            this.BBorrarListado.Location = new System.Drawing.Point(658, 141);
            this.BBorrarListado.Name = "BBorrarListado";
            this.BBorrarListado.Size = new System.Drawing.Size(123, 53);
            this.BBorrarListado.TabIndex = 10;
            this.BBorrarListado.Text = "Borrar listado";
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
            // BBuscarProducto
            // 
            this.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.BBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarProducto.Image")));
            this.BBuscarProducto.Location = new System.Drawing.Point(66, 50);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(37, 20);
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
            this.BLimpiarProducto.Location = new System.Drawing.Point(57, 51);
            this.BLimpiarProducto.Name = "BLimpiarProducto";
            this.BLimpiarProducto.Size = new System.Drawing.Size(46, 22);
            this.BLimpiarProducto.TabIndex = 15;
            this.BLimpiarProducto.Text = "Borrar";
            this.BLimpiarProducto.UseVisualStyleBackColor = true;
            this.BLimpiarProducto.Click += new System.EventHandler(this.BLimpiarProducto_Click);
            // 
            // BLimpiarProveedor
            // 
            this.BLimpiarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BLimpiarProveedor.Location = new System.Drawing.Point(582, 154);
            this.BLimpiarProveedor.Name = "BLimpiarProveedor";
            this.BLimpiarProveedor.Size = new System.Drawing.Size(59, 20);
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
            this.BBuscarProveedor.Location = new System.Drawing.Point(582, 153);
            this.BBuscarProveedor.Name = "BBuscarProveedor";
            this.BBuscarProveedor.Size = new System.Drawing.Size(59, 21);
            this.BBuscarProveedor.TabIndex = 17;
            this.BBuscarProveedor.Text = "Buscar";
            this.BBuscarProveedor.UseVisualStyleBackColor = true;
            this.BBuscarProveedor.Click += new System.EventHandler(this.BBuscarProveedor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 43;
            this.label2.Text = "Detalles \r\nde pedido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(360, 52);
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
            this.label4.Location = new System.Drawing.Point(408, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Proveedor (cuit)";
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.ForeColor = System.Drawing.Color.White;
            this.LTotal.Location = new System.Drawing.Point(360, 79);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(61, 16);
            this.LTotal.TabIndex = 46;
            this.LTotal.Text = "Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(360, 105);
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
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Codigo de pedido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(161, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 126;
            this.label8.Text = "Codigo del producto";
            // 
            // BConfirmar
            // 
            this.BConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BConfirmar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BConfirmar.ForeColor = System.Drawing.Color.Blue;
            this.BConfirmar.Location = new System.Drawing.Point(658, 11);
            this.BConfirmar.Name = "BConfirmar";
            this.BConfirmar.Size = new System.Drawing.Size(123, 53);
            this.BConfirmar.TabIndex = 127;
            this.BConfirmar.Text = "Confirmar entrega";
            this.BConfirmar.UseVisualStyleBackColor = true;
            this.BConfirmar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BHistorialPedidos
            // 
            this.BHistorialPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BHistorialPedidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BHistorialPedidos.ForeColor = System.Drawing.Color.BurlyWood;
            this.BHistorialPedidos.Location = new System.Drawing.Point(658, 136);
            this.BHistorialPedidos.Name = "BHistorialPedidos";
            this.BHistorialPedidos.Size = new System.Drawing.Size(123, 58);
            this.BHistorialPedidos.TabIndex = 128;
            this.BHistorialPedidos.Text = "Historial de pedidos";
            this.BHistorialPedidos.UseVisualStyleBackColor = true;
            this.BHistorialPedidos.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // BCatalogo
            // 
            this.BCatalogo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BCatalogo.BackgroundImage = global::ProyectoTaller.Properties.Resources.mate_acero;
            this.BCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BCatalogo.Location = new System.Drawing.Point(22, 50);
            this.BCatalogo.Name = "BCatalogo";
            this.BCatalogo.Size = new System.Drawing.Size(29, 23);
            this.BCatalogo.TabIndex = 129;
            this.BCatalogo.UseVisualStyleBackColor = false;
            this.BCatalogo.Click += new System.EventHandler(this.BCatalogo_Click);
            // 
            // PedidoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 443);
            this.Controls.Add(this.BCatalogo);
            this.Controls.Add(this.BHistorialPedidos);
            this.Controls.Add(this.BConfirmar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LListaProductos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BBuscarProveedor);
            this.Controls.Add(this.BLimpiarProveedor);
            this.Controls.Add(this.BLimpiarProducto);
            this.Controls.Add(this.BBuscarProducto);
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
        private System.Windows.Forms.Button BAñadir;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BBorrarListado;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.TextBox TBBuscarProveedor;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BLimpiarProducto;
        private System.Windows.Forms.Button BLimpiarProveedor;
        private System.Windows.Forms.Button BBuscarProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label LListaProductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BConfirmar;
        private System.Windows.Forms.Button BHistorialPedidos;
        private System.Windows.Forms.Button BCatalogo;
    }
}