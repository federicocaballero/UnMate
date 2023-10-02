using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoTaller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PBFondo = new System.Windows.Forms.PictureBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.BIniciar = new System.Windows.Forms.Button();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LContraseña = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
            this.LMate = new System.Windows.Forms.Label();
            this.LCOlvidada = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BMinimizar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBFondo
            // 
            this.PBFondo.Image = ((System.Drawing.Image)(resources.GetObject("PBFondo.Image")));
            this.PBFondo.Location = new System.Drawing.Point(-24, 1);
            this.PBFondo.Name = "PBFondo";
            this.PBFondo.Size = new System.Drawing.Size(562, 442);
            this.PBFondo.TabIndex = 0;
            this.PBFondo.TabStop = false;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LTitulo.Location = new System.Drawing.Point(537, 56);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(226, 37);
            this.LTitulo.TabIndex = 1;
            this.LTitulo.Text = "Inicie sesión aquí";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 43);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(559, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 43);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // TBUsuario
            // 
            this.TBUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.TBUsuario.Location = new System.Drawing.Point(573, 159);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(170, 20);
            this.TBUsuario.TabIndex = 4;
            this.TBUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBUsuario_KeyPress);
            // 
            // TBContraseña
            // 
            this.TBContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.TBContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBContraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.TBContraseña.Location = new System.Drawing.Point(573, 235);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(170, 20);
            this.TBContraseña.TabIndex = 5;
            this.TBContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBContraseña.UseSystemPasswordChar = true;
            this.TBContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBContraseña_KeyPress);
            // 
            // BIniciar
            // 
            this.BIniciar.BackColor = System.Drawing.Color.Black;
            this.BIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BIniciar.BackgroundImage")));
            this.BIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIniciar.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIniciar.ForeColor = System.Drawing.Color.Black;
            this.BIniciar.Location = new System.Drawing.Point(556, 294);
            this.BIniciar.Name = "BIniciar";
            this.BIniciar.Size = new System.Drawing.Size(195, 49);
            this.BIniciar.TabIndex = 6;
            this.BIniciar.UseVisualStyleBackColor = false;
            this.BIniciar.Click += new System.EventHandler(this.BIniciar_Click);
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.LUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LUsuario.Location = new System.Drawing.Point(583, 125);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(144, 19);
            this.LUsuario.TabIndex = 7;
            this.LUsuario.Text = "Nombre usuario*";
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.LContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LContraseña.Location = new System.Drawing.Point(609, 204);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(108, 19);
            this.LContraseña.TabIndex = 8;
            this.LContraseña.Text = "Contraseña*";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Transparent;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.ForeColor = System.Drawing.Color.Transparent;
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.Location = new System.Drawing.Point(767, -1);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(19, 22);
            this.BSalir.TabIndex = 9;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click_1);
            // 
            // LMate
            // 
            this.LMate.AutoSize = true;
            this.LMate.BackColor = System.Drawing.Color.Black;
            this.LMate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LMate.Font = new System.Drawing.Font("Ink Free", 59.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LMate.ForeColor = System.Drawing.Color.White;
            this.LMate.Location = new System.Drawing.Point(51, 25);
            this.LMate.Name = "LMate";
            this.LMate.Size = new System.Drawing.Size(345, 99);
            this.LMate.TabIndex = 10;
            this.LMate.Text = "Un Mate";
            // 
            // LCOlvidada
            // 
            this.LCOlvidada.AutoSize = true;
            this.LCOlvidada.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LCOlvidada.ForeColor = System.Drawing.Color.White;
            this.LCOlvidada.Location = new System.Drawing.Point(492, 322);
            this.LCOlvidada.Name = "LCOlvidada";
            this.LCOlvidada.Size = new System.Drawing.Size(0, 21);
            this.LCOlvidada.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(51, 308);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(345, 144);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BMinimizar);
            this.panel1.Controls.Add(this.BSalir);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 21);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // BMinimizar
            // 
            this.BMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.BMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BMinimizar.Image")));
            this.BMinimizar.Location = new System.Drawing.Point(740, 3);
            this.BMinimizar.Name = "BMinimizar";
            this.BMinimizar.Size = new System.Drawing.Size(27, 16);
            this.BMinimizar.TabIndex = 10;
            this.BMinimizar.UseVisualStyleBackColor = false;
            this.BMinimizar.Click += new System.EventHandler(this.BMinimizar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(787, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LCOlvidada);
            this.Controls.Add(this.LMate);
            this.Controls.Add(this.LContraseña);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.BIniciar);
            this.Controls.Add(this.TBContraseña);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.PBFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            ((System.ComponentModel.ISupportInitialize)(this.PBFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PBFondo;
        private Label LTitulo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox TBUsuario;
        private TextBox TBContraseña;
        private Button BIniciar;
        private Label LUsuario;
        private Label LContraseña;
        private Button BSalir;
        private Label LMate;
        private Label LCOlvidada;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Button BMinimizar;
        private ErrorProvider errorProvider1;
    }
}