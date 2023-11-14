using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    partial class ListadoVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoVentas));
            this.GridListadoVentas = new System.Windows.Forms.DataGridView();
            this.Ltitulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.LEmpleado = new System.Windows.Forms.Label();
            this.Tfecha = new System.Windows.Forms.DateTimePicker();
            this.THasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridListadoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridListadoVentas
            // 
            this.GridListadoVentas.AllowUserToAddRows = false;
            this.GridListadoVentas.AllowUserToDeleteRows = false;
            this.GridListadoVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListadoVentas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridListadoVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListadoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListadoVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridListadoVentas.Location = new System.Drawing.Point(-2, 114);
            this.GridListadoVentas.Name = "GridListadoVentas";
            this.GridListadoVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListadoVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridListadoVentas.RowHeadersVisible = false;
            this.GridListadoVentas.RowTemplate.Height = 25;
            this.GridListadoVentas.Size = new System.Drawing.Size(806, 320);
            this.GridListadoVentas.TabIndex = 0;
            this.GridListadoVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListadoVentas_CellContentClick_1);
            // 
            // Ltitulo
            // 
            this.Ltitulo.AutoSize = true;
            this.Ltitulo.BackColor = System.Drawing.Color.Transparent;
            this.Ltitulo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.Ltitulo.ForeColor = System.Drawing.Color.White;
            this.Ltitulo.Location = new System.Drawing.Point(283, 9);
            this.Ltitulo.Name = "Ltitulo";
            this.Ltitulo.Size = new System.Drawing.Size(230, 22);
            this.Ltitulo.TabIndex = 25;
            this.Ltitulo.Text = "Mis ventas ralizadas: ";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(634, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 36);
            this.button2.TabIndex = 24;
            this.button2.Text = "Realizar una venta";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // LEmpleado
            // 
            this.LEmpleado.AutoSize = true;
            this.LEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.LEmpleado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmpleado.ForeColor = System.Drawing.Color.White;
            this.LEmpleado.Location = new System.Drawing.Point(12, 87);
            this.LEmpleado.Name = "LEmpleado";
            this.LEmpleado.Size = new System.Drawing.Size(0, 18);
            this.LEmpleado.TabIndex = 31;
            // 
            // Tfecha
            // 
            this.Tfecha.Location = new System.Drawing.Point(196, 54);
            this.Tfecha.Name = "Tfecha";
            this.Tfecha.Size = new System.Drawing.Size(196, 20);
            this.Tfecha.TabIndex = 32;
            this.Tfecha.ValueChanged += new System.EventHandler(this.Tfecha_ValueChanged);
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(412, 54);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(195, 20);
            this.THasta.TabIndex = 33;
            this.THasta.ValueChanged += new System.EventHandler(this.THasta_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Fecha desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(480, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha hasta";
            // 
            // ListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(803, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.Tfecha);
            this.Controls.Add(this.LEmpleado);
            this.Controls.Add(this.Ltitulo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridListadoVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoVentas";
            this.Text = "ListadoVentas";
            this.Load += new System.EventHandler(this.ListadoVentas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GridListadoVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridListadoVentas;
        private Button button2;
        private Label Ltitulo;
        private Label LEmpleado;
        private DateTimePicker Tfecha;
        private DateTimePicker THasta;
        private Label label2;
        private Label label3;
    }
}