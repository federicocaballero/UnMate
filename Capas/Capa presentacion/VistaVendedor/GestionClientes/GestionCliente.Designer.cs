using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionClientes
{
    partial class GestionCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.LNyA = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.LUsuarios = new System.Windows.Forms.Label();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BBorrarListado = new System.Windows.Forms.Button();
            this.BAñadirC = new System.Windows.Forms.Button();
            this.BGuardarModificacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.BEliminarCliente = new System.Windows.Forms.Button();
            this.BRestaurar = new System.Windows.Forms.Button();
            this.GridListaUsuarios = new System.Windows.Forms.DataGridView();
            this.DTPAltaUsuario = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBNombre.Location = new System.Drawing.Point(169, 40);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(147, 22);
            this.TBNombre.TabIndex = 110;
            this.TBNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombre_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 109;
            this.label1.Text = "Nombre:";
            // 
            // TBDni
            // 
            this.TBDni.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBDni.Location = new System.Drawing.Point(407, 75);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(190, 22);
            this.TBDni.TabIndex = 105;
            this.TBDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDni_KeyPress);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.Transparent;
            this.LDni.Font = new System.Drawing.Font("Consolas", 12F);
            this.LDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDni.Location = new System.Drawing.Point(344, 76);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(45, 19);
            this.LDni.TabIndex = 104;
            this.LDni.Text = "DNI:";
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBApellido.Location = new System.Drawing.Point(169, 76);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(147, 22);
            this.TBApellido.TabIndex = 103;
            this.TBApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBApellido_KeyPress_1);
            // 
            // LNyA
            // 
            this.LNyA.AutoSize = true;
            this.LNyA.BackColor = System.Drawing.Color.Transparent;
            this.LNyA.Font = new System.Drawing.Font("Consolas", 12F);
            this.LNyA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNyA.Location = new System.Drawing.Point(79, 75);
            this.LNyA.Name = "LNyA";
            this.LNyA.Size = new System.Drawing.Size(90, 19);
            this.LNyA.TabIndex = 102;
            this.LNyA.Text = "Apellido:";
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBEmail.Location = new System.Drawing.Point(407, 38);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(190, 22);
            this.TBEmail.TabIndex = 100;
            this.TBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBEmail.TextChanged += new System.EventHandler(this.TBEmail_TextChanged);
            this.TBEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBEmail_KeyPress_1);
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.BackColor = System.Drawing.Color.Transparent;
            this.LEmail.Font = new System.Drawing.Font("Consolas", 12F);
            this.LEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmail.Location = new System.Drawing.Point(344, 40);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(63, 19);
            this.LEmail.TabIndex = 97;
            this.LEmail.Text = "Email:";
            // 
            // BBuscar
            // 
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Location = new System.Drawing.Point(8, 190);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(82, 23);
            this.BBuscar.TabIndex = 95;
            this.BBuscar.Text = "BUSCAR";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscar.Location = new System.Drawing.Point(97, 190);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(136, 23);
            this.TBBuscar.TabIndex = 94;
            this.TBBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBuscar_KeyPress);
            // 
            // LUsuarios
            // 
            this.LUsuarios.AutoSize = true;
            this.LUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.LUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LUsuarios.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.LUsuarios.ForeColor = System.Drawing.Color.White;
            this.LUsuarios.Location = new System.Drawing.Point(284, 1);
            this.LUsuarios.Name = "LUsuarios";
            this.LUsuarios.Size = new System.Drawing.Size(214, 24);
            this.LUsuarios.TabIndex = 92;
            this.LUsuarios.Text = "Lista de clientes";
            // 
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BLimpiarFiltros.ForeColor = System.Drawing.Color.IndianRed;
            this.BLimpiarFiltros.Location = new System.Drawing.Point(239, 191);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(104, 22);
            this.BLimpiarFiltros.TabIndex = 119;
            this.BLimpiarFiltros.Text = "Limpiar filtros";
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BBorrarListado
            // 
            this.BBorrarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBorrarListado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BBorrarListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BBorrarListado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBorrarListado.Location = new System.Drawing.Point(636, 150);
            this.BBorrarListado.Name = "BBorrarListado";
            this.BBorrarListado.Size = new System.Drawing.Size(120, 41);
            this.BBorrarListado.TabIndex = 121;
            this.BBorrarListado.Text = "Borrar listado";
            this.BBorrarListado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrarListado.UseVisualStyleBackColor = true;
            this.BBorrarListado.Click += new System.EventHandler(this.BBorrarListado_Click);
            // 
            // BAñadirC
            // 
            this.BAñadirC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAñadirC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BAñadirC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BAñadirC.Image = ((System.Drawing.Image)(resources.GetObject("BAñadirC.Image")));
            this.BAñadirC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAñadirC.Location = new System.Drawing.Point(636, 32);
            this.BAñadirC.Name = "BAñadirC";
            this.BAñadirC.Size = new System.Drawing.Size(120, 41);
            this.BAñadirC.TabIndex = 120;
            this.BAñadirC.Text = "Añadir";
            this.BAñadirC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAñadirC.UseVisualStyleBackColor = true;
            this.BAñadirC.Click += new System.EventHandler(this.BAñadirC_Click);
            // 
            // BGuardarModificacion
            // 
            this.BGuardarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarModificacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BGuardarModificacion.ForeColor = System.Drawing.Color.SteelBlue;
            this.BGuardarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("BGuardarModificacion.Image")));
            this.BGuardarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardarModificacion.Location = new System.Drawing.Point(636, 92);
            this.BGuardarModificacion.Name = "BGuardarModificacion";
            this.BGuardarModificacion.Size = new System.Drawing.Size(120, 41);
            this.BGuardarModificacion.TabIndex = 108;
            this.BGuardarModificacion.Text = "  Modificar";
            this.BGuardarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardarModificacion.UseVisualStyleBackColor = true;
            this.BGuardarModificacion.Click += new System.EventHandler(this.BGuardarModificacion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(117, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 122;
            this.label3.Text = "DNI del cliente";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LTelefono.Font = new System.Drawing.Font("Consolas", 12F);
            this.LTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelefono.Location = new System.Drawing.Point(79, 113);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(90, 19);
            this.LTelefono.TabIndex = 106;
            this.LTelefono.Text = "Teléfono:";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBTelefono.Location = new System.Drawing.Point(169, 114);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(147, 22);
            this.TBTelefono.TabIndex = 107;
            this.TBTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTelefono_KeyPress);
            // 
            // BEliminarCliente
            // 
            this.BEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BEliminarCliente.ForeColor = System.Drawing.Color.Maroon;
            this.BEliminarCliente.Location = new System.Drawing.Point(636, 30);
            this.BEliminarCliente.Name = "BEliminarCliente";
            this.BEliminarCliente.Size = new System.Drawing.Size(120, 44);
            this.BEliminarCliente.TabIndex = 125;
            this.BEliminarCliente.Text = "Eliminar";
            this.BEliminarCliente.UseVisualStyleBackColor = true;
            this.BEliminarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // BRestaurar
            // 
            this.BRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRestaurar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BRestaurar.ForeColor = System.Drawing.Color.SteelBlue;
            this.BRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRestaurar.Location = new System.Drawing.Point(636, 30);
            this.BRestaurar.Name = "BRestaurar";
            this.BRestaurar.Size = new System.Drawing.Size(120, 45);
            this.BRestaurar.TabIndex = 126;
            this.BRestaurar.Text = "Restaurar";
            this.BRestaurar.UseVisualStyleBackColor = true;
            this.BRestaurar.Click += new System.EventHandler(this.BRestaurar_Click);
            // 
            // GridListaUsuarios
            // 
            this.GridListaUsuarios.AllowUserToAddRows = false;
            this.GridListaUsuarios.AllowUserToDeleteRows = false;
            this.GridListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListaUsuarios.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListaUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridListaUsuarios.Location = new System.Drawing.Point(1, 219);
            this.GridListaUsuarios.Name = "GridListaUsuarios";
            this.GridListaUsuarios.ReadOnly = true;
            this.GridListaUsuarios.RowHeadersVisible = false;
            this.GridListaUsuarios.RowHeadersWidth = 50;
            this.GridListaUsuarios.RowTemplate.Height = 25;
            this.GridListaUsuarios.Size = new System.Drawing.Size(804, 215);
            this.GridListaUsuarios.TabIndex = 93;
            this.GridListaUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListaUsuarios_CellContentDoubleClick);
            this.GridListaUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridListaUsuarios_CellFormatting);
            // 
            // DTPAltaUsuario
            // 
            this.DTPAltaUsuario.Enabled = false;
            this.DTPAltaUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPAltaUsuario.Location = new System.Drawing.Point(490, 117);
            this.DTPAltaUsuario.Name = "DTPAltaUsuario";
            this.DTPAltaUsuario.Size = new System.Drawing.Size(107, 20);
            this.DTPAltaUsuario.TabIndex = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(344, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 128;
            this.label2.Text = "Fecha cliente:";
            // 
            // GestionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(799, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTPAltaUsuario);
            this.Controls.Add(this.BRestaurar);
            this.Controls.Add(this.BEliminarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BBorrarListado);
            this.Controls.Add(this.BAñadirC);
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
            this.Controls.Add(this.GridListaUsuarios);
            this.Controls.Add(this.LUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionClientes";
            this.Load += new System.EventHandler(this.GestionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TBNombre;
        private Label label1;
        private Button BGuardarModificacion;
        private TextBox TBDni;
        private Label LDni;
        private TextBox TBApellido;
        private Label LNyA;
        private TextBox TBEmail;
        private Label LEmail;
        private Button BBuscar;
        private TextBox TBBuscar;
        private Label LUsuarios;
        private Button BLimpiarFiltros;
        private ErrorProvider errorProvider1;
        private Button BAñadirC;
        private Button BBorrarListado;
        private Label label3;
        private TextBox TBTelefono;
        private Label LTelefono;
        private Button BEliminarCliente;
        private Button BRestaurar;
        private DateTimePicker DTPAltaUsuario;
        private DataGridView GridListaUsuarios;
        private Label label2;
    }
}