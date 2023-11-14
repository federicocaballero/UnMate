namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.GestionProveedores
{
    partial class ListaProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProveedores));
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.TBCuit = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.GridProveedores = new System.Windows.Forms.DataGridView();
            this.CBIva = new System.Windows.Forms.ComboBox();
            this.BAñadir = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.BBorrarListado = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LListaProductos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BRestaurar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(124, 45);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(178, 21);
            this.TBNombre.TabIndex = 0;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombre_KeyPress);
            // 
            // TBDireccion
            // 
            this.TBDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDireccion.Location = new System.Drawing.Point(124, 79);
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(178, 21);
            this.TBDireccion.TabIndex = 1;
            this.TBDireccion.TextChanged += new System.EventHandler(this.TBDireccion_TextChanged);
            this.TBDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDireccion_KeyPress);
            // 
            // TBCuit
            // 
            this.TBCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCuit.Location = new System.Drawing.Point(124, 113);
            this.TBCuit.Name = "TBCuit";
            this.TBCuit.Size = new System.Drawing.Size(178, 21);
            this.TBCuit.TabIndex = 2;
            this.TBCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCuit_KeyPress);
            // 
            // TBTelefono
            // 
            this.TBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefono.Location = new System.Drawing.Point(426, 79);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(171, 21);
            this.TBTelefono.TabIndex = 3;
            this.TBTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTelefono_KeyPress);
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEmail.Location = new System.Drawing.Point(400, 113);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(215, 21);
            this.TBEmail.TabIndex = 4;
            this.TBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBEmail.TextChanged += new System.EventHandler(this.TBEmail_TextChanged);
            this.TBEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBEmail_KeyPress);
            // 
            // GridProveedores
            // 
            this.GridProveedores.AllowUserToAddRows = false;
            this.GridProveedores.AllowUserToDeleteRows = false;
            this.GridProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProveedores.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProveedores.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridProveedores.Location = new System.Drawing.Point(-1, 222);
            this.GridProveedores.Name = "GridProveedores";
            this.GridProveedores.ReadOnly = true;
            this.GridProveedores.RowHeadersVisible = false;
            this.GridProveedores.Size = new System.Drawing.Size(802, 215);
            this.GridProveedores.TabIndex = 5;
            this.GridProveedores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProveedores_CellContentDoubleClick);
            this.GridProveedores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridProveedores_CellFormatting);
            // 
            // CBIva
            // 
            this.CBIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBIva.FormattingEnabled = true;
            this.CBIva.Items.AddRange(new object[] {
            "Responsable Inscripto",
            "Responsable no Inscripto",
            "Consumidor Final"});
            this.CBIva.Location = new System.Drawing.Point(426, 42);
            this.CBIva.Name = "CBIva";
            this.CBIva.Size = new System.Drawing.Size(171, 23);
            this.CBIva.TabIndex = 7;
            // 
            // BAñadir
            // 
            this.BAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAñadir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BAñadir.ForeColor = System.Drawing.Color.Blue;
            this.BAñadir.Image = ((System.Drawing.Image)(resources.GetObject("BAñadir.Image")));
            this.BAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAñadir.Location = new System.Drawing.Point(641, 35);
            this.BAñadir.Name = "BAñadir";
            this.BAñadir.Size = new System.Drawing.Size(127, 57);
            this.BAñadir.TabIndex = 9;
            this.BAñadir.Text = "Guardar proveedor";
            this.BAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAñadir.UseVisualStyleBackColor = true;
            this.BAñadir.Click += new System.EventHandler(this.BAñadir_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(641, 35);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(127, 57);
            this.BEliminar.TabIndex = 10;
            this.BEliminar.Text = "Eliminar proveedor";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BBuscar
            // 
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BBuscar.Location = new System.Drawing.Point(14, 194);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(75, 23);
            this.BBuscar.TabIndex = 11;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(95, 194);
            this.TBBuscar.Multiline = true;
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(135, 23);
            this.TBBuscar.TabIndex = 12;
            this.TBBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBuscar_KeyPress);
            // 
            // BBorrarListado
            // 
            this.BBorrarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBorrarListado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBorrarListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BBorrarListado.Location = new System.Drawing.Point(641, 123);
            this.BBorrarListado.Name = "BBorrarListado";
            this.BBorrarListado.Size = new System.Drawing.Size(127, 53);
            this.BBorrarListado.TabIndex = 16;
            this.BBorrarListado.Text = "Eliminar listado";
            this.BBorrarListado.UseVisualStyleBackColor = true;
            this.BBorrarListado.Click += new System.EventHandler(this.BBorrarListado_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LListaProductos
            // 
            this.LListaProductos.AutoSize = true;
            this.LListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LListaProductos.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.LListaProductos.ForeColor = System.Drawing.Color.White;
            this.LListaProductos.Location = new System.Drawing.Point(283, 3);
            this.LListaProductos.Name = "LListaProductos";
            this.LListaProductos.Size = new System.Drawing.Size(250, 24);
            this.LListaProductos.TabIndex = 40;
            this.LListaProductos.Text = "Lista de proveedores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "CUIT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(324, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(324, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(336, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "IVA:";
            // 
            // BRestaurar
            // 
            this.BRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRestaurar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRestaurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BRestaurar.Location = new System.Drawing.Point(641, 35);
            this.BRestaurar.Name = "BRestaurar";
            this.BRestaurar.Size = new System.Drawing.Size(127, 57);
            this.BRestaurar.TabIndex = 49;
            this.BRestaurar.Text = "Restaurar";
            this.BRestaurar.UseVisualStyleBackColor = true;
            this.BRestaurar.Click += new System.EventHandler(this.BRestaurar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(121, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 126;
            this.label6.Text = "CUIT proveedor";
            // 
            // ListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 443);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BRestaurar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LListaProductos);
            this.Controls.Add(this.BBorrarListado);
            this.Controls.Add(this.TBBuscar);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BAñadir);
            this.Controls.Add(this.CBIva);
            this.Controls.Add(this.GridProveedores);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.TBCuit);
            this.Controls.Add(this.TBDireccion);
            this.Controls.Add(this.TBNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaProveedores";
            this.Load += new System.EventHandler(this.ListaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.TextBox TBCuit;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.DataGridView GridProveedores;
        private System.Windows.Forms.ComboBox CBIva;
        private System.Windows.Forms.Button BAñadir;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Button BBorrarListado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LListaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BRestaurar;
        private System.Windows.Forms.Label label6;
    }
}