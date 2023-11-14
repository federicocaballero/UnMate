using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor
{
    partial class MenuSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSupervisor));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BMinimizar = new System.Windows.Forms.Button();
            this.BCerrarSesion = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.LSaludo = new System.Windows.Forms.Label();
            this.PanelHijos = new System.Windows.Forms.Panel();
            this.PBMate = new System.Windows.Forms.PictureBox();
            this.BPerfil = new System.Windows.Forms.Button();
            this.BPedidos = new System.Windows.Forms.Button();
            this.BEstadisticas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BGestionProveedores = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.PanelHijos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BMinimizar);
            this.panel2.Controls.Add(this.BCerrarSesion);
            this.panel2.Controls.Add(this.BSalir);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 20);
            this.panel2.TabIndex = 16;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario: Supervisor";
            // 
            // BMinimizar
            // 
            this.BMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BMinimizar.Image")));
            this.BMinimizar.Location = new System.Drawing.Point(753, 0);
            this.BMinimizar.Name = "BMinimizar";
            this.BMinimizar.Size = new System.Drawing.Size(27, 16);
            this.BMinimizar.TabIndex = 10;
            this.BMinimizar.UseVisualStyleBackColor = false;
            this.BMinimizar.Click += new System.EventHandler(this.BMinimizar_Click_1);
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BCerrarSesion.BackgroundImage")));
            this.BCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCerrarSesion.Location = new System.Drawing.Point(728, 0);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(27, 18);
            this.BCerrarSesion.TabIndex = 10;
            this.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCerrarSesion.UseVisualStyleBackColor = true;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click_1);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Transparent;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.ForeColor = System.Drawing.Color.Transparent;
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.Location = new System.Drawing.Point(782, -3);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(19, 22);
            this.BSalir.TabIndex = 9;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // LSaludo
            // 
            this.LSaludo.AutoEllipsis = true;
            this.LSaludo.AutoSize = true;
            this.LSaludo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LSaludo.Font = new System.Drawing.Font("Consolas", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSaludo.ForeColor = System.Drawing.SystemColors.Control;
            this.LSaludo.Location = new System.Drawing.Point(81, 35);
            this.LSaludo.Name = "LSaludo";
            this.LSaludo.Size = new System.Drawing.Size(658, 47);
            this.LSaludo.TabIndex = 10;
            this.LSaludo.Text = "Bienvenido supersivor anonimo";
            // 
            // PanelHijos
            // 
            this.PanelHijos.Controls.Add(this.PBMate);
            this.PanelHijos.Controls.Add(this.LSaludo);
            this.PanelHijos.Location = new System.Drawing.Point(0, 65);
            this.PanelHijos.Name = "PanelHijos";
            this.PanelHijos.Size = new System.Drawing.Size(815, 437);
            this.PanelHijos.TabIndex = 25;
            // 
            // PBMate
            // 
            this.PBMate.BackColor = System.Drawing.Color.Transparent;
            this.PBMate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBMate.BackgroundImage")));
            this.PBMate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBMate.Location = new System.Drawing.Point(258, 98);
            this.PBMate.Name = "PBMate";
            this.PBMate.Size = new System.Drawing.Size(309, 230);
            this.PBMate.TabIndex = 11;
            this.PBMate.TabStop = false;
            // 
            // BPerfil
            // 
            this.BPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPerfil.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BPerfil.ForeColor = System.Drawing.Color.Chartreuse;
            this.BPerfil.Image = ((System.Drawing.Image)(resources.GetObject("BPerfil.Image")));
            this.BPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BPerfil.Location = new System.Drawing.Point(649, 24);
            this.BPerfil.Name = "BPerfil";
            this.BPerfil.Size = new System.Drawing.Size(130, 35);
            this.BPerfil.TabIndex = 24;
            this.BPerfil.Text = "Perfil supervisor";
            this.BPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BPerfil.UseVisualStyleBackColor = true;
            this.BPerfil.Click += new System.EventHandler(this.BPerfil_Click);
            // 
            // BPedidos
            // 
            this.BPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPedidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BPedidos.ForeColor = System.Drawing.Color.Chartreuse;
            this.BPedidos.Image = ((System.Drawing.Image)(resources.GetObject("BPedidos.Image")));
            this.BPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BPedidos.Location = new System.Drawing.Point(195, 24);
            this.BPedidos.Name = "BPedidos";
            this.BPedidos.Size = new System.Drawing.Size(164, 34);
            this.BPedidos.TabIndex = 21;
            this.BPedidos.Text = "Pedido  proveedores";
            this.BPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BPedidos.UseVisualStyleBackColor = true;
            this.BPedidos.Click += new System.EventHandler(this.BPedidos_Click_1);
            // 
            // BEstadisticas
            // 
            this.BEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BEstadisticas.ForeColor = System.Drawing.Color.Chartreuse;
            this.BEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("BEstadisticas.Image")));
            this.BEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEstadisticas.Location = new System.Drawing.Point(448, 25);
            this.BEstadisticas.Name = "BEstadisticas";
            this.BEstadisticas.Size = new System.Drawing.Size(178, 34);
            this.BEstadisticas.TabIndex = 23;
            this.BEstadisticas.Text = "Estadisticas de ventas";
            this.BEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEstadisticas.UseVisualStyleBackColor = true;
            this.BEstadisticas.Click += new System.EventHandler(this.BEstadisticas_Click_1);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(375, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 43);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BGestionProveedores
            // 
            this.BGestionProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGestionProveedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BGestionProveedores.ForeColor = System.Drawing.Color.Chartreuse;
            this.BGestionProveedores.Image = ((System.Drawing.Image)(resources.GetObject("BGestionProveedores.Image")));
            this.BGestionProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGestionProveedores.Location = new System.Drawing.Point(12, 24);
            this.BGestionProveedores.Name = "BGestionProveedores";
            this.BGestionProveedores.Size = new System.Drawing.Size(159, 34);
            this.BGestionProveedores.TabIndex = 20;
            this.BGestionProveedores.Text = "Gestion proveedores";
            this.BGestionProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGestionProveedores.UseVisualStyleBackColor = true;
            this.BGestionProveedores.Click += new System.EventHandler(this.BGestionProveedores_Click);
            // 
            // MenuSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.PanelHijos);
            this.Controls.Add(this.BPerfil);
            this.Controls.Add(this.BPedidos);
            this.Controls.Add(this.BEstadisticas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BGestionProveedores);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSupervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuSupervisor";
            this.Load += new System.EventHandler(this.MenuSupervisor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelHijos.ResumeLayout(false);
            this.PanelHijos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button BMinimizar;
        private Button BCerrarSesion;
        private Button BSalir;
        private PictureBox PBMate;
        private Label LSaludo;
        private Button BGestionProveedores;
        private Button BPedidos;
        private Button button3;
        private Button BEstadisticas;
        private Button BPerfil;
        private Label label1;
        private Panel PanelHijos;
    }
}