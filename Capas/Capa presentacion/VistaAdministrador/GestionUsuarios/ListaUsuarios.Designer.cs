using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionUsuarios
{
    partial class ListaUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuarios));
            this.LUsuarios = new System.Windows.Forms.Label();
            this.GridListaUsuarios = new System.Windows.Forms.DataGridView();
            this.ColumnaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaContraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelListaUsuarios = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BBorrarListado = new System.Windows.Forms.Button();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.TBContraseña2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BAñadir = new System.Windows.Forms.Button();
            this.LCategoria = new System.Windows.Forms.Label();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BEliminarProducto = new System.Windows.Forms.Button();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BGuardarModificacion = new System.Windows.Forms.Button();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaUsuarios)).BeginInit();
            this.PanelListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LUsuarios
            // 
            this.LUsuarios.AutoSize = true;
            this.LUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.LUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LUsuarios.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.LUsuarios.ForeColor = System.Drawing.Color.White;
            this.LUsuarios.Location = new System.Drawing.Point(294, 0);
            this.LUsuarios.Name = "LUsuarios";
            this.LUsuarios.Size = new System.Drawing.Size(214, 24);
            this.LUsuarios.TabIndex = 0;
            this.LUsuarios.Text = "Lista de usuarios";
            // 
            // GridListaUsuarios
            // 
            this.GridListaUsuarios.AllowUserToAddRows = false;
            this.GridListaUsuarios.AllowUserToDeleteRows = false;
            this.GridListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListaUsuarios.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GridListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaUsuario,
            this.ColumnaNombre,
            this.ColumnaApellido,
            this.ColumnaEmail,
            this.ColumnaDNI,
            this.ColumnaTelefono,
            this.ColumnaContraseña,
            this.imagen,
            this.categoria});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListaUsuarios.DefaultCellStyle = dataGridViewCellStyle15;
            this.GridListaUsuarios.Location = new System.Drawing.Point(-2, 207);
            this.GridListaUsuarios.Name = "GridListaUsuarios";
            this.GridListaUsuarios.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.GridListaUsuarios.RowHeadersVisible = false;
            this.GridListaUsuarios.RowHeadersWidth = 50;
            this.GridListaUsuarios.RowTemplate.Height = 25;
            this.GridListaUsuarios.Size = new System.Drawing.Size(806, 240);
            this.GridListaUsuarios.TabIndex = 1;
            this.GridListaUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListaUsuarios_CellContentDoubleClick);
            // 
            // ColumnaUsuario
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnaUsuario.DefaultCellStyle = dataGridViewCellStyle14;
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
            // categoria
            // 
            this.categoria.HeaderText = "categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // PanelListaUsuarios
            // 
            this.PanelListaUsuarios.BackColor = System.Drawing.SystemColors.InfoText;
            this.PanelListaUsuarios.Controls.Add(this.label3);
            this.PanelListaUsuarios.Controls.Add(this.BBorrarListado);
            this.PanelListaUsuarios.Controls.Add(this.BLimpiarFiltros);
            this.PanelListaUsuarios.Controls.Add(this.TBContraseña2);
            this.PanelListaUsuarios.Controls.Add(this.label2);
            this.PanelListaUsuarios.Controls.Add(this.BAñadir);
            this.PanelListaUsuarios.Controls.Add(this.LCategoria);
            this.PanelListaUsuarios.Controls.Add(this.CBCategoria);
            this.PanelListaUsuarios.Controls.Add(this.button3);
            this.PanelListaUsuarios.Controls.Add(this.pictureBox1);
            this.PanelListaUsuarios.Controls.Add(this.BEliminarProducto);
            this.PanelListaUsuarios.Controls.Add(this.TBNombre);
            this.PanelListaUsuarios.Controls.Add(this.label1);
            this.PanelListaUsuarios.Controls.Add(this.BGuardarModificacion);
            this.PanelListaUsuarios.Controls.Add(this.TBTelefono);
            this.PanelListaUsuarios.Controls.Add(this.LTelefono);
            this.PanelListaUsuarios.Controls.Add(this.TBDni);
            this.PanelListaUsuarios.Controls.Add(this.LDni);
            this.PanelListaUsuarios.Controls.Add(this.TBApellido);
            this.PanelListaUsuarios.Controls.Add(this.LNyA);
            this.PanelListaUsuarios.Controls.Add(this.TBContraseña);
            this.PanelListaUsuarios.Controls.Add(this.TBEmail);
            this.PanelListaUsuarios.Controls.Add(this.TBUsuario);
            this.PanelListaUsuarios.Controls.Add(this.zds);
            this.PanelListaUsuarios.Controls.Add(this.LEmail);
            this.PanelListaUsuarios.Controls.Add(this.LNombre);
            this.PanelListaUsuarios.Controls.Add(this.BBuscar);
            this.PanelListaUsuarios.Controls.Add(this.TBBuscar);
            this.PanelListaUsuarios.Controls.Add(this.GridListaUsuarios);
            this.PanelListaUsuarios.Controls.Add(this.LUsuarios);
            this.PanelListaUsuarios.ForeColor = System.Drawing.Color.Black;
            this.PanelListaUsuarios.Location = new System.Drawing.Point(1, 1);
            this.PanelListaUsuarios.Name = "PanelListaUsuarios";
            this.PanelListaUsuarios.Size = new System.Drawing.Size(804, 453);
            this.PanelListaUsuarios.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "DNI del usuario";
            // 
            // BBorrarListado
            // 
            this.BBorrarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBorrarListado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BBorrarListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BBorrarListado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBorrarListado.Location = new System.Drawing.Point(659, 22);
            this.BBorrarListado.Name = "BBorrarListado";
            this.BBorrarListado.Size = new System.Drawing.Size(125, 41);
            this.BBorrarListado.TabIndex = 123;
            this.BBorrarListado.Text = "Borrar listado";
            this.BBorrarListado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBorrarListado.UseVisualStyleBackColor = true;
            this.BBorrarListado.Click += new System.EventHandler(this.BBorrarListado_Click_1);
            // 
            // BLimpiarFiltros
            // 
            this.BLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarFiltros.ForeColor = System.Drawing.Color.IndianRed;
            this.BLimpiarFiltros.Location = new System.Drawing.Point(222, 181);
            this.BLimpiarFiltros.Name = "BLimpiarFiltros";
            this.BLimpiarFiltros.Size = new System.Drawing.Size(88, 20);
            this.BLimpiarFiltros.TabIndex = 95;
            this.BLimpiarFiltros.Text = "Limpiar filtros";
            this.BLimpiarFiltros.UseVisualStyleBackColor = true;
            this.BLimpiarFiltros.Click += new System.EventHandler(this.BLimpiarFiltros_Click);
            // 
            // TBContraseña2
            // 
            this.TBContraseña2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBContraseña2.Location = new System.Drawing.Point(426, 109);
            this.TBContraseña2.Name = "TBContraseña2";
            this.TBContraseña2.Size = new System.Drawing.Size(136, 22);
            this.TBContraseña2.TabIndex = 94;
            this.TBContraseña2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBContraseña2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBContraseña2_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(312, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 93;
            this.label2.Text = "Repetir:";
            // 
            // BAñadir
            // 
            this.BAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAñadir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BAñadir.Image = ((System.Drawing.Image)(resources.GetObject("BAñadir.Image")));
            this.BAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAñadir.Location = new System.Drawing.Point(659, 22);
            this.BAñadir.Name = "BAñadir";
            this.BAñadir.Size = new System.Drawing.Size(125, 41);
            this.BAñadir.TabIndex = 92;
            this.BAñadir.Text = "Añadir";
            this.BAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAñadir.UseVisualStyleBackColor = true;
            this.BAñadir.Click += new System.EventHandler(this.BAñadir_Click);
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.BackColor = System.Drawing.Color.Transparent;
            this.LCategoria.Font = new System.Drawing.Font("Consolas", 12F);
            this.LCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCategoria.Location = new System.Drawing.Point(312, 36);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(99, 19);
            this.LCategoria.TabIndex = 91;
            this.LCategoria.Text = "Categorìa:";
            // 
            // CBCategoria
            // 
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Supervisor",
            "Cliente"});
            this.CBCategoria.Location = new System.Drawing.Point(426, 34);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(136, 21);
            this.CBCategoria.TabIndex = 90;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.SteelBlue;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(471, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 36);
            this.button3.TabIndex = 89;
            this.button3.Text = "Imagen";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(316, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 64);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // BEliminarProducto
            // 
            this.BEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BEliminarProducto.ForeColor = System.Drawing.Color.Red;
            this.BEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BEliminarProducto.Image")));
            this.BEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminarProducto.Location = new System.Drawing.Point(659, 141);
            this.BEliminarProducto.Name = "BEliminarProducto";
            this.BEliminarProducto.Size = new System.Drawing.Size(125, 40);
            this.BEliminarProducto.TabIndex = 87;
            this.BEliminarProducto.Text = "Eliminar";
            this.BEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminarProducto.UseVisualStyleBackColor = true;
            this.BEliminarProducto.Click += new System.EventHandler(this.BEliminarProducto_Click);
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBNombre.Location = new System.Drawing.Point(135, 59);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(132, 22);
            this.TBNombre.TabIndex = 86;
            this.TBNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombre_KeyPress_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "Nombre:";
            // 
            // BGuardarModificacion
            // 
            this.BGuardarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarModificacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BGuardarModificacion.ForeColor = System.Drawing.Color.SteelBlue;
            this.BGuardarModificacion.Image = ((System.Drawing.Image)(resources.GetObject("BGuardarModificacion.Image")));
            this.BGuardarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardarModificacion.Location = new System.Drawing.Point(659, 81);
            this.BGuardarModificacion.Name = "BGuardarModificacion";
            this.BGuardarModificacion.Size = new System.Drawing.Size(125, 41);
            this.BGuardarModificacion.TabIndex = 83;
            this.BGuardarModificacion.Text = "  Modificar";
            this.BGuardarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardarModificacion.UseVisualStyleBackColor = true;
            this.BGuardarModificacion.Click += new System.EventHandler(this.BGuardarModificacion_Click);
            // 
            // TBTelefono
            // 
            this.TBTelefono.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBTelefono.Location = new System.Drawing.Point(426, 59);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(136, 22);
            this.TBTelefono.TabIndex = 82;
            this.TBTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTelefono_KeyPress_1);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LTelefono.Font = new System.Drawing.Font("Consolas", 12F);
            this.LTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTelefono.Location = new System.Drawing.Point(312, 58);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(90, 19);
            this.LTelefono.TabIndex = 81;
            this.LTelefono.Text = "Teléfono:";
            // 
            // TBDni
            // 
            this.TBDni.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBDni.Location = new System.Drawing.Point(135, 134);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(132, 22);
            this.TBDni.TabIndex = 80;
            this.TBDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDni_KeyPress_1);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.Transparent;
            this.LDni.Font = new System.Drawing.Font("Consolas", 12F);
            this.LDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDni.Location = new System.Drawing.Point(45, 134);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(45, 19);
            this.LDni.TabIndex = 79;
            this.LDni.Text = "DNI:";
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBApellido.Location = new System.Drawing.Point(135, 84);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(132, 22);
            this.TBApellido.TabIndex = 78;
            this.TBApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBApellido_KeyPress);
            // 
            // LNyA
            // 
            this.LNyA.AutoSize = true;
            this.LNyA.BackColor = System.Drawing.Color.Transparent;
            this.LNyA.Font = new System.Drawing.Font("Consolas", 12F);
            this.LNyA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNyA.Location = new System.Drawing.Point(45, 83);
            this.LNyA.Name = "LNyA";
            this.LNyA.Size = new System.Drawing.Size(90, 19);
            this.LNyA.TabIndex = 77;
            this.LNyA.Text = "Apellido:";
            // 
            // TBContraseña
            // 
            this.TBContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBContraseña.Location = new System.Drawing.Point(426, 84);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(136, 22);
            this.TBContraseña.TabIndex = 76;
            this.TBContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBContraseña_KeyPress_1);
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBEmail.Location = new System.Drawing.Point(135, 109);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(132, 22);
            this.TBEmail.TabIndex = 75;
            this.TBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBEmail_KeyPress_1);
            // 
            // TBUsuario
            // 
            this.TBUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBUsuario.Location = new System.Drawing.Point(135, 34);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(132, 22);
            this.TBUsuario.TabIndex = 74;
            this.TBUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBUsuario_KeyPress_1);
            // 
            // zds
            // 
            this.zds.AutoSize = true;
            this.zds.BackColor = System.Drawing.Color.Transparent;
            this.zds.Font = new System.Drawing.Font("Consolas", 12F);
            this.zds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zds.Location = new System.Drawing.Point(312, 83);
            this.zds.Name = "zds";
            this.zds.Size = new System.Drawing.Size(108, 19);
            this.zds.TabIndex = 73;
            this.zds.Text = "Contraseña:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.BackColor = System.Drawing.Color.Transparent;
            this.LEmail.Font = new System.Drawing.Font("Consolas", 12F);
            this.LEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmail.Location = new System.Drawing.Point(45, 111);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(63, 19);
            this.LEmail.TabIndex = 72;
            this.LEmail.Text = "Email:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.Transparent;
            this.LNombre.Font = new System.Drawing.Font("Consolas", 12F);
            this.LNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombre.Location = new System.Drawing.Point(45, 33);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(81, 19);
            this.LNombre.TabIndex = 71;
            this.LNombre.Text = "Usuario:";
            // 
            // BBuscar
            // 
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Location = new System.Drawing.Point(11, 181);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(82, 20);
            this.BBuscar.TabIndex = 7;
            this.BBuscar.Text = "BUSCAR";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(99, 181);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(106, 20);
            this.TBBuscar.TabIndex = 6;
            this.TBBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBuscar.Click += new System.EventHandler(this.TBBuscar_Click);
            this.TBBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBuscar_KeyPress_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(797, 460);
            this.Controls.Add(this.PanelListaUsuarios);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaUsuarios";
            this.Text = "ListaUsuarios";
            this.Load += new System.EventHandler(this.ListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaUsuarios)).EndInit();
            this.PanelListaUsuarios.ResumeLayout(false);
            this.PanelListaUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label LUsuarios;
        private DataGridView GridListaUsuarios;
        private Panel PanelListaUsuarios;
        private Button BBuscar;
        private TextBox TBBuscar;
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
        private Button BGuardarModificacion;
        private TextBox TBNombre;
        private Label label1;
        private Button BEliminarProducto;
        private PictureBox pictureBox1;
        private Button button3;
        private Label LCategoria;
        private ComboBox CBCategoria;
        private Button BAñadir;
        private TextBox TBContraseña2;
        private Label label2;
        private Button BLimpiarFiltros;
        private DataGridViewTextBoxColumn ColumnaUsuario;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn ColumnaEmail;
        private DataGridViewTextBoxColumn ColumnaDNI;
        private DataGridViewTextBoxColumn ColumnaTelefono;
        private DataGridViewTextBoxColumn ColumnaContraseña;
        private DataGridViewImageColumn imagen;
        private DataGridViewTextBoxColumn categoria;
        private ErrorProvider errorProvider1;
        private Button BBorrarListado;
        private Label label3;
    }
}