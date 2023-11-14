using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.GestionVentas
{
    partial class ListadoVentasVendedores
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
            this.GridListadoVendedores = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.THasta = new System.Windows.Forms.DateTimePicker();
            this.Tfecha = new System.Windows.Forms.DateTimePicker();
            this.LTotalRecaudado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridListadoVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // GridListadoVendedores
            // 
            this.GridListadoVendedores.AllowUserToAddRows = false;
            this.GridListadoVendedores.AllowUserToDeleteRows = false;
            this.GridListadoVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListadoVendedores.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListadoVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListadoVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListadoVendedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridListadoVendedores.Location = new System.Drawing.Point(-1, 107);
            this.GridListadoVendedores.Name = "GridListadoVendedores";
            this.GridListadoVendedores.ReadOnly = true;
            this.GridListadoVendedores.RowHeadersVisible = false;
            this.GridListadoVendedores.RowTemplate.Height = 25;
            this.GridListadoVendedores.Size = new System.Drawing.Size(803, 325);
            this.GridListadoVendedores.TabIndex = 0;
            this.GridListadoVendedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListadoVendedores_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(310, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Listado de ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(304, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fecha hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha desde";
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(237, 81);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(200, 20);
            this.THasta.TabIndex = 37;
            // 
            // Tfecha
            // 
            this.Tfecha.Location = new System.Drawing.Point(12, 81);
            this.Tfecha.Name = "Tfecha";
            this.Tfecha.Size = new System.Drawing.Size(200, 20);
            this.Tfecha.TabIndex = 36;
            // 
            // LTotalRecaudado
            // 
            this.LTotalRecaudado.AutoSize = true;
            this.LTotalRecaudado.BackColor = System.Drawing.Color.Transparent;
            this.LTotalRecaudado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalRecaudado.ForeColor = System.Drawing.Color.White;
            this.LTotalRecaudado.Location = new System.Drawing.Point(478, 81);
            this.LTotalRecaudado.Name = "LTotalRecaudado";
            this.LTotalRecaudado.Size = new System.Drawing.Size(0, 18);
            this.LTotalRecaudado.TabIndex = 40;
            // 
            // ListadoVentasVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.LTotalRecaudado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.Tfecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GridListadoVendedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoVentasVendedores";
            this.Text = "ListadoVentas";
            this.Load += new System.EventHandler(this.ListadoVentasVendedores_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GridListadoVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridListadoVendedores;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker THasta;
        private DateTimePicker Tfecha;
        private Label LTotalRecaudado;
    }
}