using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionUsuarios
{
    partial class ListaEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaEmpleados));
            this.LUsuarios = new System.Windows.Forms.Label();
            this.GridListaUsuarios = new System.Windows.Forms.DataGridView();
            this.PanelListaUsuarios = new System.Windows.Forms.Panel();
            this.BRestaurar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BBorrarListado = new System.Windows.Forms.Button();
            this.BLimpiarFiltros = new System.Windows.Forms.Button();
            this.TBContraseña2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BAñadir = new System.Windows.Forms.Button();
            this.LCategoria = new System.Windows.Forms.Label();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.BEliminarEmpleado = new System.Windows.Forms.Button();
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
            this.zds = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaUsuarios)).BeginInit();
            this.PanelListaUsuarios.SuspendLayout();
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
            this.LUsuarios.Size = new System.Drawing.Size(226, 24);
            this.LUsuarios.TabIndex = 0;
            this.LUsuarios.Text = "Lista de empleados";
            // 
            // GridListaUsuarios
            // 
            this.GridListaUsuarios.AllowUserToAddRows = false;
            this.GridListaUsuarios.AllowUserToDeleteRows = false;
            this.GridListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListaUsuarios.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListaUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridListaUsuarios.Location = new System.Drawing.Point(-2, 207);
            this.GridListaUsuarios.Name = "GridListaUsuarios";
            this.GridListaUsuarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridListaUsuarios.RowHeadersVisible = false;
            this.GridListaUsuarios.RowHeadersWidth = 50;
            this.GridListaUsuarios.RowTemplate.Height = 25;
            this.GridListaUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridListaUsuarios.Size = new System.Drawing.Size(803, 226);
            this.GridListaUsuarios.TabIndex = 1;
            this.GridListaUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListaUsuarios_CellContentDoubleClick);
            this.GridListaUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridListaUsuarios_CellFormatting);
            // 
            // PanelListaUsuarios
            // 
            this.PanelListaUsuarios.BackColor = System.Drawing.SystemColors.InfoText;
            this.PanelListaUsuarios.Controls.Add(this.BRestaurar);
            this.PanelListaUsuarios.Controls.Add(this.label3);
            this.PanelListaUsuarios.Controls.Add(this.BBorrarListado);
            this.PanelListaUsuarios.Controls.Add(this.BLimpiarFiltros);
            this.PanelListaUsuarios.Controls.Add(this.TBContraseña2);
            this.PanelListaUsuarios.Controls.Add(this.label2);
            this.PanelListaUsuarios.Controls.Add(this.BAñadir);
            this.PanelListaUsuarios.Controls.Add(this.LCategoria);
            this.PanelListaUsuarios.Controls.Add(this.CBCategoria);
            this.PanelListaUsuarios.Controls.Add(this.BEliminarEmpleado);
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
            this.PanelListaUsuarios.Controls.Add(this.zds);
            this.PanelListaUsuarios.Controls.Add(this.LEmail);
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
            // BRestaurar
            // 
            this.BRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRestaurar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BRestaurar.ForeColor = System.Drawing.Color.Turquoise;
            this.BRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRestaurar.Location = new System.Drawing.Point(659, 78);
            this.BRestaurar.Name = "BRestaurar";
            this.BRestaurar.Size = new System.Drawing.Size(125, 56);
            this.BRestaurar.TabIndex = 125;
            this.BRestaurar.Text = "Restaurar empleado";
            this.BRestaurar.UseVisualStyleBackColor = true;
            this.BRestaurar.Click += new System.EventHandler(this.BRestaurar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "DNI del empleado";
            // 
            // BBorrarListado
            // 
            this.BBorrarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBorrarListado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BBorrarListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BBorrarListado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBorrarListado.Location = new System.Drawing.Point(659, 11);
            this.BBorrarListado.Name = "BBorrarListado";
            this.BBorrarListado.Size = new System.Drawing.Size(125, 56);
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
            this.TBContraseña2.Location = new System.Drawing.Point(453, 120);
            this.TBContraseña2.Name = "TBContraseña2";
            this.TBContraseña2.Size = new System.Drawing.Size(154, 22);
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
            this.label2.Location = new System.Drawing.Point(339, 119);
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
            this.BAñadir.Location = new System.Drawing.Point(659, 11);
            this.BAñadir.Name = "BAñadir";
            this.BAñadir.Size = new System.Drawing.Size(125, 56);
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
            this.LCategoria.Location = new System.Drawing.Point(339, 47);
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
            "Supervisor"});
            this.CBCategoria.Location = new System.Drawing.Point(453, 45);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(154, 21);
            this.CBCategoria.TabIndex = 90;
            // 
            // BEliminarEmpleado
            // 
            this.BEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BEliminarEmpleado.ForeColor = System.Drawing.Color.Red;
            this.BEliminarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("BEliminarEmpleado.Image")));
            this.BEliminarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminarEmpleado.Location = new System.Drawing.Point(659, 144);
            this.BEliminarEmpleado.Name = "BEliminarEmpleado";
            this.BEliminarEmpleado.Size = new System.Drawing.Size(125, 57);
            this.BEliminarEmpleado.TabIndex = 87;
            this.BEliminarEmpleado.Text = "Eliminar empleado";
            this.BEliminarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminarEmpleado.UseVisualStyleBackColor = true;
            this.BEliminarEmpleado.Click += new System.EventHandler(this.BEliminarProducto_Click);
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBNombre.Location = new System.Drawing.Point(164, 45);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(158, 22);
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
            this.label1.Location = new System.Drawing.Point(74, 44);
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
            this.BGuardarModificacion.Location = new System.Drawing.Point(659, 78);
            this.BGuardarModificacion.Name = "BGuardarModificacion";
            this.BGuardarModificacion.Size = new System.Drawing.Size(125, 56);
            this.BGuardarModificacion.TabIndex = 83;
            this.BGuardarModificacion.Text = " Modificar ";
            this.BGuardarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardarModificacion.UseVisualStyleBackColor = true;
            this.BGuardarModificacion.Click += new System.EventHandler(this.BGuardarModificacion_Click);
            // 
            // TBTelefono
            // 
            this.TBTelefono.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBTelefono.Location = new System.Drawing.Point(453, 70);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(154, 22);
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
            this.LTelefono.Location = new System.Drawing.Point(339, 69);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(90, 19);
            this.LTelefono.TabIndex = 81;
            this.LTelefono.Text = "Teléfono:";
            // 
            // TBDni
            // 
            this.TBDni.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBDni.Location = new System.Drawing.Point(164, 120);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(158, 22);
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
            this.LDni.Location = new System.Drawing.Point(74, 120);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(45, 19);
            this.LDni.TabIndex = 79;
            this.LDni.Text = "DNI:";
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBApellido.Location = new System.Drawing.Point(164, 70);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(158, 22);
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
            this.LNyA.Location = new System.Drawing.Point(74, 69);
            this.LNyA.Name = "LNyA";
            this.LNyA.Size = new System.Drawing.Size(90, 19);
            this.LNyA.TabIndex = 77;
            this.LNyA.Text = "Apellido:";
            // 
            // TBContraseña
            // 
            this.TBContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBContraseña.Location = new System.Drawing.Point(453, 95);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(154, 22);
            this.TBContraseña.TabIndex = 76;
            this.TBContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBContraseña_KeyPress_1);
            // 
            // TBEmail
            // 
            this.TBEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TBEmail.Location = new System.Drawing.Point(164, 95);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(158, 22);
            this.TBEmail.TabIndex = 75;
            this.TBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBEmail.TextChanged += new System.EventHandler(this.TBEmail_TextChanged);
            this.TBEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBEmail_KeyPress_1);
            // 
            // zds
            // 
            this.zds.AutoSize = true;
            this.zds.BackColor = System.Drawing.Color.Transparent;
            this.zds.Font = new System.Drawing.Font("Consolas", 12F);
            this.zds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zds.Location = new System.Drawing.Point(339, 94);
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
            this.LEmail.Location = new System.Drawing.Point(74, 97);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(63, 19);
            this.LEmail.TabIndex = 72;
            this.LEmail.Text = "Email:";
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
            // ListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(797, 460);
            this.Controls.Add(this.PanelListaUsuarios);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaEmpleados";
            this.Text = "ListaUsuarios";
            this.Load += new System.EventHandler(this.ListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaUsuarios)).EndInit();
            this.PanelListaUsuarios.ResumeLayout(false);
            this.PanelListaUsuarios.PerformLayout();
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
        private Label zds;
        private Label LEmail;
        private Button BGuardarModificacion;
        private TextBox TBNombre;
        private Label label1;
        private Button BEliminarEmpleado;
        private Label LCategoria;
        private ComboBox CBCategoria;
        private TextBox TBContraseña2;
        private Label label2;
        private Button BLimpiarFiltros;
        private ErrorProvider errorProvider1;
        private Button BBorrarListado;
        private Label label3;
        private Button BRestaurar;
        private Button BAñadir;
    }
}