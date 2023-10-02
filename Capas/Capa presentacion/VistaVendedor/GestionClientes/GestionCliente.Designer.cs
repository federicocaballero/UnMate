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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCliente));
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.LNyA = new System.Windows.Forms.Label();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.zds = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.GridListaUsuarios = new System.Windows.Forms.DataGridView();
            this.ColumnaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaContraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.LUsuarios = new System.Windows.Forms.Label();
            this.TBContraseña2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BBorrarListado = new System.Windows.Forms.Button();
            this.BAñadirC = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BGuardarModificacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBNombre.Location = new System.Drawing.Point(135, 53);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(132, 22);
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
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 109;
            this.label1.Text = "Nombre:";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBTelefono.Location = new System.Drawing.Point(440, 28);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(132, 22);
            this.TBTelefono.TabIndex = 107;
            this.TBTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTelefono_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LTelefono.Font = new System.Drawing.Font("Consolas", 12F);
            this.LTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelefono.Location = new System.Drawing.Point(301, 29);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(90, 19);
            this.LTelefono.TabIndex = 106;
            this.LTelefono.Text = "Teléfono:";
            // 
            // TBDni
            // 
            this.TBDni.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBDni.Location = new System.Drawing.Point(135, 125);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(132, 22);
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
            this.LDni.Location = new System.Drawing.Point(45, 124);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(45, 19);
            this.LDni.TabIndex = 104;
            this.LDni.Text = "DNI:";
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBApellido.Location = new System.Drawing.Point(135, 77);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(132, 22);
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
            this.LNyA.Location = new System.Drawing.Point(45, 80);
            this.LNyA.Name = "LNyA";
            this.LNyA.Size = new System.Drawing.Size(90, 19);
            this.LNyA.TabIndex = 102;
            this.LNyA.Text = "Apellido:";
            // 
            // TBContraseña
            // 
            this.TBContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBContraseña.Location = new System.Drawing.Point(440, 51);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(132, 22);
            this.TBContraseña.TabIndex = 101;
            this.TBContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBContraseña_KeyPress);
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBEmail.Location = new System.Drawing.Point(135, 101);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(132, 22);
            this.TBEmail.TabIndex = 100;
            this.TBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBEmail_KeyPress_1);
            // 
            // TBUsuario
            // 
            this.TBUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBUsuario.Location = new System.Drawing.Point(135, 29);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(132, 22);
            this.TBUsuario.TabIndex = 99;
            this.TBUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBUsuario_KeyPress_1);
            // 
            // zds
            // 
            this.zds.AutoSize = true;
            this.zds.BackColor = System.Drawing.Color.Transparent;
            this.zds.Font = new System.Drawing.Font("Consolas", 12F);
            this.zds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zds.Location = new System.Drawing.Point(301, 51);
            this.zds.Name = "zds";
            this.zds.Size = new System.Drawing.Size(108, 19);
            this.zds.TabIndex = 98;
            this.zds.Text = "Contraseña:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.BackColor = System.Drawing.Color.Transparent;
            this.LEmail.Font = new System.Drawing.Font("Consolas", 12F);
            this.LEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmail.Location = new System.Drawing.Point(45, 104);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(63, 19);
            this.LEmail.TabIndex = 97;
            this.LEmail.Text = "Email:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.Transparent;
            this.LNombre.Font = new System.Drawing.Font("Consolas", 12F);
            this.LNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombre.Location = new System.Drawing.Point(45, 28);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(81, 19);
            this.LNombre.TabIndex = 96;
            this.LNombre.Text = "Usuario:";
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
            this.TBBuscar.Size = new System.Drawing.Size(106, 23);
            this.TBBuscar.TabIndex = 94;
            this.TBBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBuscar_KeyPress);
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
            this.GridListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaUsuario,
            this.ColumnaNombre,
            this.ColumnaApellido,
            this.ColumnaEmail,
            this.ColumnaDNI,
            this.ColumnaTelefono,
            this.ColumnaContraseña,
            this.imagen});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListaUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridListaUsuarios.Location = new System.Drawing.Point(1, 219);
            this.GridListaUsuarios.Name = "GridListaUsuarios";
            this.GridListaUsuarios.ReadOnly = true;
            this.GridListaUsuarios.RowHeadersVisible = false;
            this.GridListaUsuarios.RowHeadersWidth = 50;
            this.GridListaUsuarios.RowTemplate.Height = 25;
            this.GridListaUsuarios.Size = new System.Drawing.Size(800, 215);
            this.GridListaUsuarios.TabIndex = 93;
            this.GridListaUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListaUsuarios_CellDoubleClick);
            // 
            // ColumnaUsuario
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnaUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnaUsuario.FillWeight = 100.4827F;
            this.ColumnaUsuario.HeaderText = "Usuario";
            this.ColumnaUsuario.Name = "ColumnaUsuario";
            this.ColumnaUsuario.ReadOnly = true;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.FillWeight = 83.57704F;
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaApellido
            // 
            this.ColumnaApellido.FillWeight = 84.12621F;
            this.ColumnaApellido.HeaderText = "Apellido";
            this.ColumnaApellido.Name = "ColumnaApellido";
            this.ColumnaApellido.ReadOnly = true;
            // 
            // ColumnaEmail
            // 
            this.ColumnaEmail.FillWeight = 129.8694F;
            this.ColumnaEmail.HeaderText = "Email";
            this.ColumnaEmail.Name = "ColumnaEmail";
            this.ColumnaEmail.ReadOnly = true;
            // 
            // ColumnaDNI
            // 
            this.ColumnaDNI.FillWeight = 81.0991F;
            this.ColumnaDNI.HeaderText = "DNI";
            this.ColumnaDNI.Name = "ColumnaDNI";
            this.ColumnaDNI.ReadOnly = true;
            // 
            // ColumnaTelefono
            // 
            this.ColumnaTelefono.FillWeight = 95.5034F;
            this.ColumnaTelefono.HeaderText = "Telefono";
            this.ColumnaTelefono.Name = "ColumnaTelefono";
            this.ColumnaTelefono.ReadOnly = true;
            // 
            // ColumnaContraseña
            // 
            this.ColumnaContraseña.FillWeight = 127.4879F;
            this.ColumnaContraseña.HeaderText = "Contraseña";
            this.ColumnaContraseña.Name = "ColumnaContraseña";
            this.ColumnaContraseña.ReadOnly = true;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "Imagen";
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
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
            // TBContraseña2
            // 
            this.TBContraseña2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBContraseña2.Location = new System.Drawing.Point(440, 74);
            this.TBContraseña2.Name = "TBContraseña2";
            this.TBContraseña2.Size = new System.Drawing.Size(132, 22);
            this.TBContraseña2.TabIndex = 118;
            this.TBContraseña2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBContraseña2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBContraseña2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(301, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 117;
            this.label2.Text = "Repetir:";
            // 
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BLimpiarFiltros.ForeColor = System.Drawing.Color.IndianRed;
            this.BLimpiarFiltros.Location = new System.Drawing.Point(224, 190);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(104, 22);
            this.BLimpiarFiltros.TabIndex = 119;
            this.BLimpiarFiltros.Text = "Limpiar filtros";
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            this.BLimpiarFiltros.Click += new System.EventHandler(this.BLimpiarFiltros_Click);
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
            this.BAñadirC.Location = new System.Drawing.Point(636, 28);
            this.BAñadirC.Name = "BAñadirC";
            this.BAñadirC.Size = new System.Drawing.Size(120, 41);
            this.BAñadirC.TabIndex = 120;
            this.BAñadirC.Text = "Añadir";
            this.BAñadirC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAñadirC.UseVisualStyleBackColor = true;
            this.BAñadirC.Click += new System.EventHandler(this.BAñadirC_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.SteelBlue;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(452, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 36);
            this.button3.TabIndex = 113;
            this.button3.Text = "Imagen";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(305, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 86);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
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
            this.label3.Location = new System.Drawing.Point(105, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 122;
            this.label3.Text = "DNI de usuario";
            // 
            // GestionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(799, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BBorrarListado);
            this.Controls.Add(this.BAñadirC);
            this.Controls.Add(this.BLimpiarFiltros);
            this.Controls.Add(this.TBContraseña2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGuardarModificacion);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.LNyA);
            this.Controls.Add(this.TBContraseña);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.zds);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.TBBuscar);
            this.Controls.Add(this.GridListaUsuarios);
            this.Controls.Add(this.LUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionClientes";
            this.Load += new System.EventHandler(this.GestionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button3;
        private PictureBox pictureBox1;
        private TextBox TBNombre;
        private Label label1;
        private Button BGuardarModificacion;
        private TextBox TBTelefono;
        private Label LTelefono;
        private TextBox TBDni;
        private Label LDni;
        private TextBox TBApellido;
        private Label LNyA;
        private TextBox TBContraseña;
        private TextBox TBEmail;
        private TextBox TBUsuario;
        private Label zds;
        private Label LEmail;
        private Label LNombre;
        private Button BBuscar;
        private TextBox TBBuscar;
        private DataGridView GridListaUsuarios;
        private Label LUsuarios;
        private TextBox TBContraseña2;
        private Label label2;
        private DataGridViewTextBoxColumn ColumnaUsuario;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn ColumnaEmail;
        private DataGridViewTextBoxColumn ColumnaDNI;
        private DataGridViewTextBoxColumn ColumnaTelefono;
        private DataGridViewTextBoxColumn ColumnaContraseña;
        private DataGridViewImageColumn imagen;
        private Button BLimpiarFiltros;
        private ErrorProvider errorProvider1;
        private Button BAñadirC;
        private Button BBorrarListado;
        private Label label3;
    }
}