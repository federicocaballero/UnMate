namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionProductos
{
    partial class ListaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BRestaurar = new System.Windows.Forms.Button();
            this.BEliminarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BBorrarListado = new System.Windows.Forms.Button();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BGuardarModificacion = new System.Windows.Forms.Button();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.LNyA = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.GridListaClientes = new System.Windows.Forms.DataGridView();
            this.LUsuarios = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BRestaurar
            // 
            this.BRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRestaurar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BRestaurar.ForeColor = System.Drawing.Color.SteelBlue;
            this.BRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRestaurar.Location = new System.Drawing.Point(656, 33);
            this.BRestaurar.Name = "BRestaurar";
            this.BRestaurar.Size = new System.Drawing.Size(120, 45);
            this.BRestaurar.TabIndex = 148;
            this.BRestaurar.Text = "Restaurar";
            this.BRestaurar.UseVisualStyleBackColor = true;
            this.BRestaurar.Click += new System.EventHandler(this.BRestaurar_Click);
            // 
            // BEliminarCliente
            // 
            this.BEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BEliminarCliente.ForeColor = System.Drawing.Color.Maroon;
            this.BEliminarCliente.Location = new System.Drawing.Point(656, 34);
            this.BEliminarCliente.Name = "BEliminarCliente";
            this.BEliminarCliente.Size = new System.Drawing.Size(120, 44);
            this.BEliminarCliente.TabIndex = 147;
            this.BEliminarCliente.Text = "Eliminar";
            this.BEliminarCliente.UseVisualStyleBackColor = true;
            this.BEliminarCliente.Click += new System.EventHandler(this.BEliminarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 146;
            this.label3.Text = "DNI del cliente";
            // 
            // BBorrarListado
            // 
            this.BBorrarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBorrarListado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BBorrarListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BBorrarListado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBorrarListado.Location = new System.Drawing.Point(656, 154);
            this.BBorrarListado.Name = "BBorrarListado";
            this.BBorrarListado.Size = new System.Drawing.Size(120, 41);
            this.BBorrarListado.TabIndex = 145;
            this.BBorrarListado.Text = "Borrar listado";
            this.BBorrarListado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrarListado.UseVisualStyleBackColor = true;
            this.BBorrarListado.Click += new System.EventHandler(this.BBorrarListado_Click);
            // 
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BLimpiarFiltros.ForeColor = System.Drawing.Color.IndianRed;
            this.BLimpiarFiltros.Location = new System.Drawing.Point(236, 189);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(104, 22);
            this.BLimpiarFiltros.TabIndex = 143;
            this.BLimpiarFiltros.Text = "Limpiar filtros";
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBNombre.Location = new System.Drawing.Point(216, 50);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(159, 22);
            this.TBNombre.TabIndex = 142;
            this.TBNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 141;
            this.label1.Text = "Nombre:";
            // 
            // BGuardarModificacion
            // 
            this.BGuardarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarModificacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BGuardarModificacion.ForeColor = System.Drawing.Color.SteelBlue;
            this.BGuardarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("BGuardarModificacion.Image")));
            this.BGuardarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardarModificacion.Location = new System.Drawing.Point(656, 96);
            this.BGuardarModificacion.Name = "BGuardarModificacion";
            this.BGuardarModificacion.Size = new System.Drawing.Size(120, 41);
            this.BGuardarModificacion.TabIndex = 140;
            this.BGuardarModificacion.Text = "  Modificar";
            this.BGuardarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardarModificacion.UseVisualStyleBackColor = true;
            this.BGuardarModificacion.Click += new System.EventHandler(this.BGuardarModificacion_Click);
            // 
            // TBTelefono
            // 
            this.TBTelefono.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBTelefono.Location = new System.Drawing.Point(352, 129);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(160, 22);
            this.TBTelefono.TabIndex = 139;
            this.TBTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTelefono_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LTelefono.Font = new System.Drawing.Font("Consolas", 12F);
            this.LTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelefono.Location = new System.Drawing.Point(256, 132);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(90, 19);
            this.LTelefono.TabIndex = 138;
            this.LTelefono.Text = "Teléfono:";
            // 
            // TBDni
            // 
            this.TBDni.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBDni.Location = new System.Drawing.Point(455, 86);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(178, 22);
            this.TBDni.TabIndex = 137;
            this.TBDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDni_KeyPress);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.Transparent;
            this.LDni.Font = new System.Drawing.Font("Consolas", 12F);
            this.LDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDni.Location = new System.Drawing.Point(395, 83);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(45, 19);
            this.LDni.TabIndex = 136;
            this.LDni.Text = "DNI:";
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBApellido.Location = new System.Drawing.Point(216, 86);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(159, 22);
            this.TBApellido.TabIndex = 135;
            this.TBApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBApellido_KeyPress);
            // 
            // LNyA
            // 
            this.LNyA.AutoSize = true;
            this.LNyA.BackColor = System.Drawing.Color.Transparent;
            this.LNyA.Font = new System.Drawing.Font("Consolas", 12F);
            this.LNyA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNyA.Location = new System.Drawing.Point(120, 85);
            this.LNyA.Name = "LNyA";
            this.LNyA.Size = new System.Drawing.Size(90, 19);
            this.LNyA.TabIndex = 134;
            this.LNyA.Text = "Apellido:";
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBEmail.Location = new System.Drawing.Point(455, 47);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(178, 22);
            this.TBEmail.TabIndex = 133;
            this.TBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBEmail.TextChanged += new System.EventHandler(this.TBEmail_TextChanged);
            this.TBEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBEmail_KeyPress);
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.BackColor = System.Drawing.Color.Transparent;
            this.LEmail.Font = new System.Drawing.Font("Consolas", 12F);
            this.LEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmail.Location = new System.Drawing.Point(395, 50);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(63, 19);
            this.LEmail.TabIndex = 132;
            this.LEmail.Text = "Email:";
            // 
            // BBuscar
            // 
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Location = new System.Drawing.Point(1, 189);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(82, 23);
            this.BBuscar.TabIndex = 131;
            this.BBuscar.Text = "BUSCAR";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscar.Location = new System.Drawing.Point(89, 190);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(131, 23);
            this.TBBuscar.TabIndex = 130;
            this.TBBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBuscar_KeyPress);
            // 
            // GridListaClientes
            // 
            this.GridListaClientes.AllowUserToAddRows = false;
            this.GridListaClientes.AllowUserToDeleteRows = false;
            this.GridListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListaClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListaClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridListaClientes.Location = new System.Drawing.Point(-4, 217);
            this.GridListaClientes.Name = "GridListaClientes";
            this.GridListaClientes.ReadOnly = true;
            this.GridListaClientes.RowHeadersVisible = false;
            this.GridListaClientes.RowHeadersWidth = 50;
            this.GridListaClientes.RowTemplate.Height = 25;
            this.GridListaClientes.Size = new System.Drawing.Size(808, 210);
            this.GridListaClientes.TabIndex = 129;
            this.GridListaClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListaClientes_CellContentDoubleClick);
            this.GridListaClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridListaClientes_CellFormatting);
            // 
            // LUsuarios
            // 
            this.LUsuarios.AutoSize = true;
            this.LUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.LUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LUsuarios.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.LUsuarios.ForeColor = System.Drawing.Color.White;
            this.LUsuarios.Location = new System.Drawing.Point(277, 9);
            this.LUsuarios.Name = "LUsuarios";
            this.LUsuarios.Size = new System.Drawing.Size(214, 24);
            this.LUsuarios.TabIndex = 128;
            this.LUsuarios.Text = "Lista de clientes";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(803, 434);
            this.Controls.Add(this.BRestaurar);
            this.Controls.Add(this.BEliminarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BBorrarListado);
            this.Controls.Add(this.BLimpiarFiltros);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGuardarModificacion);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.LNyA);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.TBBuscar);
            this.Controls.Add(this.GridListaClientes);
            this.Controls.Add(this.LUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaClientes";
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BRestaurar;
        private System.Windows.Forms.Button BEliminarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BBorrarListado;
        private System.Windows.Forms.Button BLimpiarFiltros;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BGuardarModificacion;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Label LNyA;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.DataGridView GridListaClientes;
        private System.Windows.Forms.Label LUsuarios;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}