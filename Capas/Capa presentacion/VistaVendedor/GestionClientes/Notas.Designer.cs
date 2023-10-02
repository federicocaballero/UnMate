using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.Administración
{
    partial class Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas));
            this.GridNotas = new System.Windows.Forms.DataGridView();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LMotivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.CBMotivo = new System.Windows.Forms.ComboBox();
            this.TFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BAñadir = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridNotas
            // 
            this.GridNotas.AllowUserToAddRows = false;
            this.GridNotas.AllowUserToDeleteRows = false;
            this.GridNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridNotas.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Motivo,
            this.descripcion,
            this.fecha,
            this.importancia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridNotas.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridNotas.Location = new System.Drawing.Point(0, 193);
            this.GridNotas.Name = "GridNotas";
            this.GridNotas.ReadOnly = true;
            this.GridNotas.RowHeadersVisible = false;
            this.GridNotas.RowTemplate.Height = 25;
            this.GridNotas.Size = new System.Drawing.Size(801, 247);
            this.GridNotas.TabIndex = 0;
            this.GridNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridNotas_CellContentClick_1);
            // 
            // Motivo
            // 
            this.Motivo.FillWeight = 81.21828F;
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 154.9971F;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.FillWeight = 96.19874F;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // importancia
            // 
            this.importancia.FillWeight = 67.58594F;
            this.importancia.HeaderText = "Importancia";
            this.importancia.Name = "importancia";
            this.importancia.ReadOnly = true;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.LTitulo.Location = new System.Drawing.Point(308, 4);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(187, 25);
            this.LTitulo.TabIndex = 91;
            this.LTitulo.Text = "Notas del vendedor";
            // 
            // LMotivo
            // 
            this.LMotivo.AutoSize = true;
            this.LMotivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LMotivo.Location = new System.Drawing.Point(33, 47);
            this.LMotivo.Name = "LMotivo";
            this.LMotivo.Size = new System.Drawing.Size(56, 17);
            this.LMotivo.TabIndex = 92;
            this.LMotivo.Text = "Motivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(415, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Descripción";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TBDescripcion.Location = new System.Drawing.Point(345, 59);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(227, 98);
            this.TBDescripcion.TabIndex = 94;
            this.TBDescripcion.TextChanged += new System.EventHandler(this.TBDescripcion_TextChanged_1);
            // 
            // CBMotivo
            // 
            this.CBMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMotivo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CBMotivo.FormattingEnabled = true;
            this.CBMotivo.Items.AddRange(new object[] {
            "Reunión",
            "Proveedores",
            "Administrador",
            "Consultas generales",
            "Otros"});
            this.CBMotivo.Location = new System.Drawing.Point(86, 43);
            this.CBMotivo.Name = "CBMotivo";
            this.CBMotivo.Size = new System.Drawing.Size(150, 25);
            this.CBMotivo.TabIndex = 95;
            // 
            // TFecha
            // 
            this.TFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TFecha.Location = new System.Drawing.Point(105, 76);
            this.TFecha.Name = "TFecha";
            this.TFecha.Size = new System.Drawing.Size(111, 20);
            this.TFecha.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 98;
            this.label3.Text = "Importancia:";
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB1.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RB1.Location = new System.Drawing.Point(114, 115);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(52, 19);
            this.RB1.TabIndex = 99;
            this.RB1.TabStop = true;
            this.RB1.Text = "BAJA";
            this.RB1.UseVisualStyleBackColor = false;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.BackColor = System.Drawing.Color.Yellow;
            this.RB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB2.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RB2.Location = new System.Drawing.Point(191, 113);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(59, 19);
            this.RB2.TabIndex = 100;
            this.RB2.TabStop = true;
            this.RB2.Text = "MEDIA";
            this.RB2.UseVisualStyleBackColor = false;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.BackColor = System.Drawing.Color.Maroon;
            this.RB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB3.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RB3.Location = new System.Drawing.Point(270, 113);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(52, 19);
            this.RB3.TabIndex = 101;
            this.RB3.TabStop = true;
            this.RB3.Text = "ALTA";
            this.RB3.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BAñadir
            // 
            this.BAñadir.BackColor = System.Drawing.Color.Black;
            this.BAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAñadir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BAñadir.ForeColor = System.Drawing.Color.Blue;
            this.BAñadir.Image = ((System.Drawing.Image)(resources.GetObject("BAñadir.Image")));
            this.BAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAñadir.Location = new System.Drawing.Point(626, 12);
            this.BAñadir.Name = "BAñadir";
            this.BAñadir.Size = new System.Drawing.Size(129, 38);
            this.BAñadir.TabIndex = 90;
            this.BAñadir.Text = "Guardar";
            this.BAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAñadir.UseVisualStyleBackColor = false;
            this.BAñadir.Click += new System.EventHandler(this.BAñadir_Click_1);
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.SystemColors.InfoText;
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BEliminar.ForeColor = System.Drawing.Color.Red;
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(626, 107);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(129, 40);
            this.BEliminar.TabIndex = 89;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = false;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BModificar
            // 
            this.BModificar.BackColor = System.Drawing.Color.Black;
            this.BModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModificar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BModificar.ForeColor = System.Drawing.Color.SteelBlue;
            this.BModificar.Image = ((System.Drawing.Image)(resources.GetObject("BModificar.Image")));
            this.BModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BModificar.Location = new System.Drawing.Point(626, 59);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(129, 41);
            this.BModificar.TabIndex = 88;
            this.BModificar.Text = "  Modificar";
            this.BModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BModificar.UseVisualStyleBackColor = false;
            this.BModificar.Click += new System.EventHandler(this.BModificar_Click);
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 437);
            this.Controls.Add(this.RB3);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.RB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TFecha);
            this.Controls.Add(this.CBMotivo);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LMotivo);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.BAñadir);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BModificar);
            this.Controls.Add(this.GridNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notas";
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.GridNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridNotas;
        private Button BEliminar;
        private Button BModificar;
        private Button BAñadir;
        private Label LTitulo;
        private Label LMotivo;
        private Label label1;
        private TextBox TBDescripcion;
        private ComboBox CBMotivo;
        private DateTimePicker TFecha;
        private Label label2;
        private Label label3;
        private RadioButton RB1;
        private RadioButton RB2;
        private RadioButton RB3;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn importancia;
        private ErrorProvider errorProvider1;
    }
}