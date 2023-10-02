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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seguridad));
            this.GBSeguridad = new System.Windows.Forms.GroupBox();
            this.BCopia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCopia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubir = new System.Windows.Forms.TextBox();
            this.GBSeguridad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSeguridad
            // 
            this.GBSeguridad.Controls.Add(this.BCopia);
            this.GBSeguridad.Controls.Add(this.label1);
            this.GBSeguridad.Controls.Add(this.txtCopia);
            this.GBSeguridad.ForeColor = System.Drawing.Color.White;
            this.GBSeguridad.Location = new System.Drawing.Point(107, 66);
            this.GBSeguridad.Name = "GBSeguridad";
            this.GBSeguridad.Size = new System.Drawing.Size(573, 117);
            this.GBSeguridad.TabIndex = 0;
            this.GBSeguridad.TabStop = false;
            this.GBSeguridad.Text = "Crear copia de seguridad";
            // 
            // BCopia
            // 
            this.BCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCopia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BCopia.Location = new System.Drawing.Point(238, 60);
            this.BCopia.Name = "BCopia";
            this.BCopia.Size = new System.Drawing.Size(86, 31);
            this.BCopia.TabIndex = 2;
            this.BCopia.Text = "Generar copia";
            this.BCopia.UseVisualStyleBackColor = true;
            this.BCopia.Click += new System.EventHandler(this.BCopia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la copia de seguridad";
            // 
            // txtCopia
            // 
            this.txtCopia.Location = new System.Drawing.Point(183, 34);
            this.txtCopia.Name = "txtCopia";
            this.txtCopia.Size = new System.Drawing.Size(211, 20);
            this.txtCopia.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSubir);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(107, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restaurar copia de seguridad";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(399, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 20);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(238, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar copia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicación de copia de seguridad";
            // 
            // txtSubir
            // 
            this.txtSubir.Location = new System.Drawing.Point(183, 36);
            this.txtSubir.Name = "txtSubir";
            this.txtSubir.Size = new System.Drawing.Size(211, 20);
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
            this.GBSeguridad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GBSeguridad;
        private Button BCopia;
        private Label label1;
        private TextBox txtCopia;
        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private TextBox txtSubir;
        private Button button2;
    }
}