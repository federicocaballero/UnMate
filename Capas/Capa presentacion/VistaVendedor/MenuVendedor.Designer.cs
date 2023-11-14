using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor
{
    partial class MenuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVendedor));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BCerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BMinimizar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.BPerfil = new System.Windows.Forms.Button();
            this.BGestionClientes = new System.Windows.Forms.Button();
            this.BListaProductos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BDetalles = new System.Windows.Forms.Button();
            this.LSaludo = new System.Windows.Forms.Label();
            this.PBMate = new System.Windows.Forms.PictureBox();
            this.PanelHijos = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMate)).BeginInit();
            this.PanelHijos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BCerrarSesion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BMinimizar);
            this.panel2.Controls.Add(this.BSalir);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 21);
            this.panel2.TabIndex = 15;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BCerrarSesion.BackgroundImage")));
            this.BCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCerrarSesion.Location = new System.Drawing.Point(729, 1);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(27, 18);
            this.BCerrarSesion.TabIndex = 13;
            this.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCerrarSesion.UseVisualStyleBackColor = true;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario: Vendedor";
            // 
            // BMinimizar
            // 
            this.BMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BMinimizar.Image")));
            this.BMinimizar.Location = new System.Drawing.Point(754, 1);
            this.BMinimizar.Name = "BMinimizar";
            this.BMinimizar.Size = new System.Drawing.Size(27, 16);
            this.BMinimizar.TabIndex = 10;
            this.BMinimizar.UseVisualStyleBackColor = false;
            this.BMinimizar.Click += new System.EventHandler(this.BMinimizar_Click);
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
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.BPerfil);
            this.panelBotones.Controls.Add(this.BGestionClientes);
            this.panelBotones.Controls.Add(this.BListaProductos);
            this.panelBotones.Controls.Add(this.button3);
            this.panelBotones.Controls.Add(this.BDetalles);
            this.panelBotones.Location = new System.Drawing.Point(-2, 20);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(803, 50);
            this.panelBotones.TabIndex = 16;
            // 
            // BPerfil
            // 
            this.BPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPerfil.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BPerfil.ForeColor = System.Drawing.Color.White;
            this.BPerfil.Image = ((System.Drawing.Image)(resources.GetObject("BPerfil.Image")));
            this.BPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BPerfil.Location = new System.Drawing.Point(647, 5);
            this.BPerfil.Name = "BPerfil";
            this.BPerfil.Size = new System.Drawing.Size(109, 35);
            this.BPerfil.TabIndex = 21;
            this.BPerfil.Text = "Mi Perfil";
            this.BPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BPerfil.UseVisualStyleBackColor = true;
            this.BPerfil.Click += new System.EventHandler(this.BPerfil_Click);
            // 
            // BGestionClientes
            // 
            this.BGestionClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGestionClientes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BGestionClientes.ForeColor = System.Drawing.Color.White;
            this.BGestionClientes.Image = ((System.Drawing.Image)(resources.GetObject("BGestionClientes.Image")));
            this.BGestionClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGestionClientes.Location = new System.Drawing.Point(478, 5);
            this.BGestionClientes.Name = "BGestionClientes";
            this.BGestionClientes.Size = new System.Drawing.Size(135, 35);
            this.BGestionClientes.TabIndex = 20;
            this.BGestionClientes.Text = "Gestion clientes";
            this.BGestionClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGestionClientes.UseVisualStyleBackColor = true;
            this.BGestionClientes.Click += new System.EventHandler(this.BGestionClientes_Click);
            // 
            // BListaProductos
            // 
            this.BListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BListaProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BListaProductos.ForeColor = System.Drawing.Color.White;
            this.BListaProductos.Image = ((System.Drawing.Image)(resources.GetObject("BListaProductos.Image")));
            this.BListaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BListaProductos.Location = new System.Drawing.Point(32, 5);
            this.BListaProductos.Name = "BListaProductos";
            this.BListaProductos.Size = new System.Drawing.Size(138, 34);
            this.BListaProductos.TabIndex = 19;
            this.BListaProductos.Text = "Lista productos";
            this.BListaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BListaProductos.UseVisualStyleBackColor = true;
            this.BListaProductos.Click += new System.EventHandler(this.BListaProductos_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(382, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 50);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BDetalles
            // 
            this.BDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDetalles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BDetalles.ForeColor = System.Drawing.Color.White;
            this.BDetalles.Image = ((System.Drawing.Image)(resources.GetObject("BDetalles.Image")));
            this.BDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDetalles.Location = new System.Drawing.Point(203, 5);
            this.BDetalles.Name = "BDetalles";
            this.BDetalles.Size = new System.Drawing.Size(132, 34);
            this.BDetalles.TabIndex = 0;
            this.BDetalles.Text = "Gestion ventas";
            this.BDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDetalles.UseVisualStyleBackColor = true;
            this.BDetalles.Click += new System.EventHandler(this.BDetalles_Click_1);
            // 
            // LSaludo
            // 
            this.LSaludo.AutoEllipsis = true;
            this.LSaludo.AutoSize = true;
            this.LSaludo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LSaludo.Font = new System.Drawing.Font("Consolas", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSaludo.ForeColor = System.Drawing.SystemColors.Control;
            this.LSaludo.Location = new System.Drawing.Point(92, 46);
            this.LSaludo.Name = "LSaludo";
            this.LSaludo.Size = new System.Drawing.Size(614, 47);
            this.LSaludo.TabIndex = 10;
            this.LSaludo.Text = "Bienvenido vendedor anonimo";
            // 
            // PBMate
            // 
            this.PBMate.BackColor = System.Drawing.Color.Transparent;
            this.PBMate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBMate.BackgroundImage")));
            this.PBMate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBMate.Location = new System.Drawing.Point(226, 108);
            this.PBMate.Name = "PBMate";
            this.PBMate.Size = new System.Drawing.Size(309, 230);
            this.PBMate.TabIndex = 11;
            this.PBMate.TabStop = false;
            // 
            // PanelHijos
            // 
            this.PanelHijos.Controls.Add(this.LSaludo);
            this.PanelHijos.Controls.Add(this.PBMate);
            this.PanelHijos.Location = new System.Drawing.Point(-2, 66);
            this.PanelHijos.Name = "PanelHijos";
            this.PanelHijos.Size = new System.Drawing.Size(801, 434);
            this.PanelHijos.TabIndex = 17;
            // 
            // MenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.PanelHijos);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuVendedor";
            this.Load += new System.EventHandler(this.MenuVendedor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBMate)).EndInit();
            this.PanelHijos.ResumeLayout(false);
            this.PanelHijos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button BMinimizar;
        private Button BSalir;
        private Panel panelBotones;
        private Button BDetalles;
        private Button button3;
        private Button BListaProductos;
        private Button BGestionClientes;
        private Button BPerfil;
        private Label label1;
        private Button BCerrarSesion;
        private Label LSaludo;
        private PictureBox PBMate;
        private Panel PanelHijos;
    }
}