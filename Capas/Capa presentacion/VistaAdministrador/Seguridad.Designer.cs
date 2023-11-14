using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador
{
    partial class Seguridad
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
            this.GBSeguridad = new System.Windows.Forms.GroupBox();
            this.BCopia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BCargarCopia = new System.Windows.Forms.Button();
            this.BSubirCopia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubir = new System.Windows.Forms.TextBox();
            this.GBSeguridad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSeguridad
            // 
            this.GBSeguridad.Controls.Add(this.BCopia);
            this.GBSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSeguridad.ForeColor = System.Drawing.Color.White;
            this.GBSeguridad.Location = new System.Drawing.Point(107, 57);
            this.GBSeguridad.Name = "GBSeguridad";
            this.GBSeguridad.Size = new System.Drawing.Size(573, 117);
            this.GBSeguridad.TabIndex = 0;
            this.GBSeguridad.TabStop = false;
            this.GBSeguridad.Text = "Crear copia de seguridad";
            // 
            // BCopia
            // 
            this.BCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCopia.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCopia.Location = new System.Drawing.Point(160, 33);
            this.BCopia.Name = "BCopia";
            this.BCopia.Size = new System.Drawing.Size(251, 50);
            this.BCopia.TabIndex = 2;
            this.BCopia.Text = "Generar copia de seguridad";
            this.BCopia.UseVisualStyleBackColor = true;
            this.BCopia.Click += new System.EventHandler(this.BCopia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BCargarCopia);
            this.groupBox1.Controls.Add(this.BSubirCopia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSubir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(107, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restaurar copia de seguridad";
            // 
            // BCargarCopia
            // 
            this.BCargarCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCargarCopia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BCargarCopia.Location = new System.Drawing.Point(129, 71);
            this.BCargarCopia.Name = "BCargarCopia";
            this.BCargarCopia.Size = new System.Drawing.Size(86, 31);
            this.BCargarCopia.TabIndex = 4;
            this.BCargarCopia.Text = "Cargar copia";
            this.BCargarCopia.UseVisualStyleBackColor = true;
            this.BCargarCopia.Click += new System.EventHandler(this.BCargarCopia_Click_1);
            // 
            // BSubirCopia
            // 
            this.BSubirCopia.Enabled = false;
            this.BSubirCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSubirCopia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BSubirCopia.ForeColor = System.Drawing.Color.Red;
            this.BSubirCopia.Location = new System.Drawing.Point(346, 71);
            this.BSubirCopia.Name = "BSubirCopia";
            this.BSubirCopia.Size = new System.Drawing.Size(86, 31);
            this.BSubirCopia.TabIndex = 2;
            this.BSubirCopia.Text = "Restore";
            this.BSubirCopia.UseVisualStyleBackColor = true;
            this.BSubirCopia.Click += new System.EventHandler(this.BSubirCopia_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicación de copia de seguridad";
            // 
            // txtSubir
            // 
            this.txtSubir.Enabled = false;
            this.txtSubir.Location = new System.Drawing.Point(129, 43);
            this.txtSubir.Name = "txtSubir";
            this.txtSubir.Size = new System.Drawing.Size(303, 22);
            this.txtSubir.TabIndex = 0;
            // 
            // Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBSeguridad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seguridad";
            this.Text = "Seguridad";
            this.GBSeguridad.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GBSeguridad;
        private Button BCopia;
        private GroupBox groupBox1;
        private Button BSubirCopia;
        private Label label2;
        private TextBox txtSubir;
        private Button BCargarCopia;
    }
}