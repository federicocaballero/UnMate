using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaAdministrador
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.PanelHijos = new System.Windows.Forms.Panel();
            this.PBMate = new System.Windows.Forms.PictureBox();
            this.LSaludo = new System.Windows.Forms.Label();
            this.BCerrarSesion = new System.Windows.Forms.Button();
            this.BListaProductos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BMinimizar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BListaUsuarios = new System.Windows.Forms.Button();
            this.PanelHijos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHijos
            // 
            this.PanelHijos.AllowDrop = true;
            this.PanelHijos.BackColor = System.Drawing.Color.Black;
            this.PanelHijos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHijos.Controls.Add(this.PBMate);
            this.PanelHijos.Controls.Add(this.LSaludo);
            this.PanelHijos.Location = new System.Drawing.Point(0, 74);
            this.PanelHijos.Name = "PanelHijos";
            this.PanelHijos.Size = new System.Drawing.Size(799, 426);
            this.PanelHijos.TabIndex = 1;
            // 
            // PBMate
            // 
            this.PBMate.BackColor = System.Drawing.Color.Transparent;
            this.PBMate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBMate.BackgroundImage")));
            this.PBMate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBMate.Location = new System.Drawing.Point(244, 89);
            this.PBMate.Name = "PBMate";
            this.PBMate.Size = new System.Drawing.Size(320, 237);
            this.PBMate.TabIndex = 1;
            this.PBMate.TabStop = false;
            // 
            // LSaludo
            // 
            this.LSaludo.AutoEllipsis = true;
            this.LSaludo.AutoSize = true;
            this.LSaludo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LSaludo.Font = new System.Drawing.Font("Consolas", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSaludo.ForeColor = System.Drawing.SystemColors.Control;
            this.LSaludo.Location = new System.Drawing.Point(126, 39);
            this.LSaludo.Name = "LSaludo";
            this.LSaludo.Size = new System.Drawing.Size(548, 47);
            this.LSaludo.TabIndex = 0;
            this.LSaludo.Text = "Bienvenido administrador";
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BCerrarSesion.BackgroundImage")));
            this.BCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCerrarSesion.Location = new System.Drawing.Point(726, 1);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(27, 18);
            this.BCerrarSesion.TabIndex = 10;
            this.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCerrarSesion.UseVisualStyleBackColor = true;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click_1);
            // 
            // BListaProductos
            // 
            this.BListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BListaProductos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BListaProductos.ForeColor = System.Drawing.Color.DarkOrange;
            this.BListaProductos.Image = ((System.Drawing.Image)(resources.GetObject("BListaProductos.Image")));
            this.BListaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BListaProductos.Location = new System.Drawing.Point(143, 26);
            this.BListaProductos.Name = "BListaProductos";
            this.BListaProductos.Size = new System.Drawing.Size(111, 34);
            this.BListaProductos.TabIndex = 3;
            this.BListaProductos.Text = "Productos";
            this.BListaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BListaProductos.UseVisualStyleBackColor = true;
            this.BListaProductos.Click += new System.EventHandler(this.BListaProductos_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(378, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 47);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BListaProductos);
            this.panel1.Controls.Add(this.BListaUsuarios);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 73);
            this.panel1.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.DarkOrange;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(260, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 34);
            this.button5.TabIndex = 18;
            this.button5.Text = "Clientes";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(653, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 34);
            this.button4.TabIndex = 17;
            this.button4.Text = "Listado ventas";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(563, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "Perfil";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(454, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Seguridad";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BMinimizar);
            this.panel2.Controls.Add(this.BCerrarSesion);
            this.panel2.Controls.Add(this.BSalir);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 21);
            this.panel2.TabIndex = 14;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario: Administrador";
            // 
            // BMinimizar
            // 
            this.BMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BMinimizar.Image")));
            this.BMinimizar.Location = new System.Drawing.Point(751, 1);
            this.BMinimizar.Name = "BMinimizar";
            this.BMinimizar.Size = new System.Drawing.Size(27, 16);
            this.BMinimizar.TabIndex = 10;
            this.BMinimizar.UseVisualStyleBackColor = false;
            this.BMinimizar.Click += new System.EventHandler(this.BMinimizar_Click_1);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Transparent;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.ForeColor = System.Drawing.Color.Transparent;
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.Location = new System.Drawing.Point(780, -2);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(19, 22);
            this.BSalir.TabIndex = 9;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click_1);
            // 
            // BListaUsuarios
            // 
            this.BListaUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BListaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BListaUsuarios.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BListaUsuarios.ForeColor = System.Drawing.Color.DarkOrange;
            this.BListaUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("BListaUsuarios.Image")));
            this.BListaUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BListaUsuarios.Location = new System.Drawing.Point(25, 26);
            this.BListaUsuarios.Name = "BListaUsuarios";
            this.BListaUsuarios.Size = new System.Drawing.Size(112, 34);
            this.BListaUsuarios.TabIndex = 2;
            this.BListaUsuarios.Text = "Empleados";
            this.BListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BListaUsuarios.UseVisualStyleBackColor = true;
            this.BListaUsuarios.Click += new System.EventHandler(this.BListaUsuarios_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelHijos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.PanelHijos.ResumeLayout(false);
            this.PanelHijos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel PanelHijos;
        private Button BListaProductos;
        private Button button1;
        private Button button2;
        private Button BCerrarSesion;
        private Label LSaludo;
        private Panel panel1;
        private Panel panel2;
        private Button BMinimizar;
        private Button BSalir;
        private PictureBox PBMate;
        private Button BListaUsuarios;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
    }
}