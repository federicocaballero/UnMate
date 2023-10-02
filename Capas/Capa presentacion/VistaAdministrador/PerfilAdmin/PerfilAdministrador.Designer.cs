﻿using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador.PerfilAdmin
{
    partial class PerfilAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilAdministrador));
            this.panel2 = new System.Windows.Forms.Panel();
            this.TCategoria = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TPiso = new System.Windows.Forms.TextBox();
            this.TDepto = new System.Windows.Forms.TextBox();
            this.TCalle = new System.Windows.Forms.TextBox();
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.TLocalidad = new System.Windows.Forms.TextBox();
            this.TProvincia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.TNomyApe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.TCategoria);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.TPiso);
            this.panel2.Controls.Add(this.TDepto);
            this.panel2.Controls.Add(this.TCalle);
            this.panel2.Controls.Add(this.TCodigo);
            this.panel2.Controls.Add(this.TLocalidad);
            this.panel2.Controls.Add(this.TProvincia);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-2, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 247);
            this.panel2.TabIndex = 7;
            // 
            // TCategoria
            // 
            this.TCategoria.Enabled = false;
            this.TCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TCategoria.Location = new System.Drawing.Point(395, 152);
            this.TCategoria.Name = "TCategoria";
            this.TCategoria.Size = new System.Drawing.Size(147, 23);
            this.TCategoria.TabIndex = 14;
            this.TCategoria.Text = "ADMINISTRADOR";
            this.TCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(233, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Tipo de usuario:";
            // 
            // TPiso
            // 
            this.TPiso.Enabled = false;
            this.TPiso.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TPiso.Location = new System.Drawing.Point(583, 90);
            this.TPiso.Name = "TPiso";
            this.TPiso.Size = new System.Drawing.Size(147, 25);
            this.TPiso.TabIndex = 12;
            this.TPiso.Text = "2";
            this.TPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TDepto
            // 
            this.TDepto.Enabled = false;
            this.TDepto.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TDepto.Location = new System.Drawing.Point(583, 64);
            this.TDepto.Name = "TDepto";
            this.TDepto.Size = new System.Drawing.Size(147, 25);
            this.TDepto.TabIndex = 11;
            this.TDepto.Text = "16";
            this.TDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TCalle
            // 
            this.TCalle.Enabled = false;
            this.TCalle.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TCalle.Location = new System.Drawing.Point(583, 38);
            this.TCalle.Name = "TCalle";
            this.TCalle.Size = new System.Drawing.Size(147, 25);
            this.TCalle.TabIndex = 10;
            this.TCalle.Text = "Palmar Grande 2000";
            // 
            // TCodigo
            // 
            this.TCodigo.Enabled = false;
            this.TCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TCodigo.Location = new System.Drawing.Point(242, 90);
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(144, 25);
            this.TCodigo.TabIndex = 9;
            this.TCodigo.Text = "3400";
            this.TCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TLocalidad
            // 
            this.TLocalidad.Enabled = false;
            this.TLocalidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TLocalidad.Location = new System.Drawing.Point(242, 63);
            this.TLocalidad.Name = "TLocalidad";
            this.TLocalidad.Size = new System.Drawing.Size(144, 25);
            this.TLocalidad.TabIndex = 8;
            this.TLocalidad.Text = "Corrientes";
            this.TLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TProvincia
            // 
            this.TProvincia.Enabled = false;
            this.TProvincia.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TProvincia.Location = new System.Drawing.Point(242, 36);
            this.TProvincia.Name = "TProvincia";
            this.TProvincia.Size = new System.Drawing.Size(144, 25);
            this.TProvincia.TabIndex = 7;
            this.TProvincia.Text = "Corrientes";
            this.TProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(479, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Dpto/Casa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(479, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Piso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(479, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Calle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(71, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Codigo Postal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(71, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ciudad/Localidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(71, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Provincia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(339, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Domicilio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.TBusuario);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.TEmail);
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.TNomyApe);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(240, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 191);
            this.panel1.TabIndex = 8;
            // 
            // TBusuario
            // 
            this.TBusuario.Enabled = false;
            this.TBusuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TBusuario.Location = new System.Drawing.Point(294, 33);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(142, 25);
            this.TBusuario.TabIndex = 17;
            this.TBusuario.Text = "Fede21Cab";
            this.TBusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(77, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 19);
            this.label13.TabIndex = 16;
            this.label13.Text = "Nombre de usuario:";
            // 
            // TDni
            // 
            this.TDni.Enabled = false;
            this.TDni.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TDni.Location = new System.Drawing.Point(294, 149);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(142, 25);
            this.TDni.TabIndex = 14;
            this.TDni.Text = "41323456";
            this.TDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TEmail
            // 
            this.TEmail.Enabled = false;
            this.TEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TEmail.Location = new System.Drawing.Point(294, 124);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(142, 25);
            this.TEmail.TabIndex = 13;
            this.TEmail.Text = "ejemplo@gmail.com";
            this.TEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TTelefono
            // 
            this.TTelefono.Enabled = false;
            this.TTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TTelefono.Location = new System.Drawing.Point(294, 92);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(142, 25);
            this.TTelefono.TabIndex = 12;
            this.TTelefono.Text = "3704556928";
            this.TTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TNomyApe
            // 
            this.TNomyApe.Enabled = false;
            this.TNomyApe.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TNomyApe.Location = new System.Drawing.Point(294, 59);
            this.TNomyApe.Name = "TNomyApe";
            this.TNomyApe.Size = new System.Drawing.Size(142, 25);
            this.TNomyApe.TabIndex = 11;
            this.TNomyApe.Text = "Federico Caballero";
            this.TNomyApe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(151, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datos Personales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre y apellido:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 189);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PerfilAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilAdministrador";
            this.Text = "PerfilAdmin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private TextBox TCategoria;
        private Label label14;
        private TextBox TPiso;
        private TextBox TDepto;
        private TextBox TCalle;
        private TextBox TCodigo;
        private TextBox TLocalidad;
        private TextBox TProvincia;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private TextBox TBusuario;
        private Label label13;
        private TextBox TDni;
        private TextBox TEmail;
        private TextBox TTelefono;
        private TextBox TNomyApe;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}