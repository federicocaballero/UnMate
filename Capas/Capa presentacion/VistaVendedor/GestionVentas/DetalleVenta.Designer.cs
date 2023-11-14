using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Capas.Capa_presentacion.VistaVendedor.GestionVentas
{
    partial class DetalleVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleVenta));
            this.label9 = new System.Windows.Forms.Label();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBEmailCliente = new System.Windows.Forms.TextBox();
            this.TBDNICliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GridDetalles = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPago = new System.Windows.Forms.TextBox();
            this.TBNombreCliente = new System.Windows.Forms.TextBox();
            this.TBCodVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TBNombreEmpleado = new System.Windows.Forms.TextBox();
            this.TBDNIEmpleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(453, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 39;
            this.label9.Text = "Total pagado:";
            // 
            // TBTotal
            // 
            this.TBTotal.Enabled = false;
            this.TBTotal.Location = new System.Drawing.Point(574, 354);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(86, 20);
            this.TBTotal.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(405, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(190, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "DNI del cliente";
            // 
            // TBEmailCliente
            // 
            this.TBEmailCliente.BackColor = System.Drawing.Color.White;
            this.TBEmailCliente.Enabled = false;
            this.TBEmailCliente.Location = new System.Drawing.Point(317, 58);
            this.TBEmailCliente.Name = "TBEmailCliente";
            this.TBEmailCliente.ReadOnly = true;
            this.TBEmailCliente.Size = new System.Drawing.Size(196, 20);
            this.TBEmailCliente.TabIndex = 33;
            this.TBEmailCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBDNICliente
            // 
            this.TBDNICliente.BackColor = System.Drawing.Color.White;
            this.TBDNICliente.Enabled = false;
            this.TBDNICliente.Location = new System.Drawing.Point(181, 58);
            this.TBDNICliente.Name = "TBDNICliente";
            this.TBDNICliente.ReadOnly = true;
            this.TBDNICliente.Size = new System.Drawing.Size(103, 20);
            this.TBDNICliente.TabIndex = 32;
            this.TBDNICliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(491, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fecha";
            // 
            // TBFecha
            // 
            this.TBFecha.BackColor = System.Drawing.Color.White;
            this.TBFecha.Enabled = false;
            this.TBFecha.Location = new System.Drawing.Point(530, 9);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(130, 20);
            this.TBFecha.TabIndex = 30;
            this.TBFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(419, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Metodo pago";
            // 
            // GridDetalles
            // 
            this.GridDetalles.AllowUserToAddRows = false;
            this.GridDetalles.AllowUserToDeleteRows = false;
            this.GridDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridDetalles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDetalles.GridColor = System.Drawing.Color.GreenYellow;
            this.GridDetalles.Location = new System.Drawing.Point(10, 150);
            this.GridDetalles.Name = "GridDetalles";
            this.GridDetalles.ReadOnly = true;
            this.GridDetalles.RowHeadersVisible = false;
            this.GridDetalles.RowTemplate.Height = 25;
            this.GridDetalles.Size = new System.Drawing.Size(649, 185);
            this.GridDetalles.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nro de venta";
            // 
            // TBPago
            // 
            this.TBPago.BackColor = System.Drawing.Color.White;
            this.TBPago.Enabled = false;
            this.TBPago.Location = new System.Drawing.Point(398, 114);
            this.TBPago.Name = "TBPago";
            this.TBPago.ReadOnly = true;
            this.TBPago.Size = new System.Drawing.Size(115, 20);
            this.TBPago.TabIndex = 24;
            this.TBPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBNombreCliente
            // 
            this.TBNombreCliente.BackColor = System.Drawing.Color.White;
            this.TBNombreCliente.Enabled = false;
            this.TBNombreCliente.Location = new System.Drawing.Point(24, 58);
            this.TBNombreCliente.Name = "TBNombreCliente";
            this.TBNombreCliente.ReadOnly = true;
            this.TBNombreCliente.Size = new System.Drawing.Size(151, 20);
            this.TBNombreCliente.TabIndex = 23;
            this.TBNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBCodVenta
            // 
            this.TBCodVenta.Enabled = false;
            this.TBCodVenta.Location = new System.Drawing.Point(96, 9);
            this.TBCodVenta.Name = "TBCodVenta";
            this.TBCodVenta.ReadOnly = true;
            this.TBCodVenta.Size = new System.Drawing.Size(115, 20);
            this.TBCodVenta.TabIndex = 21;
            this.TBCodVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Detalles de venta";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(226, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 45);
            this.button2.TabIndex = 40;
            this.button2.Text = "Descargar comprobante";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(73, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Vendedor";
            // 
            // TBNombreEmpleado
            // 
            this.TBNombreEmpleado.BackColor = System.Drawing.Color.White;
            this.TBNombreEmpleado.Enabled = false;
            this.TBNombreEmpleado.Location = new System.Drawing.Point(24, 114);
            this.TBNombreEmpleado.Name = "TBNombreEmpleado";
            this.TBNombreEmpleado.ReadOnly = true;
            this.TBNombreEmpleado.Size = new System.Drawing.Size(151, 20);
            this.TBNombreEmpleado.TabIndex = 41;
            this.TBNombreEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBDNIEmpleado
            // 
            this.TBDNIEmpleado.BackColor = System.Drawing.Color.White;
            this.TBDNIEmpleado.Enabled = false;
            this.TBDNIEmpleado.Location = new System.Drawing.Point(181, 114);
            this.TBDNIEmpleado.Name = "TBDNIEmpleado";
            this.TBDNIEmpleado.ReadOnly = true;
            this.TBDNIEmpleado.Size = new System.Drawing.Size(102, 20);
            this.TBDNIEmpleado.TabIndex = 43;
            this.TBDNIEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(207, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "DNI";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(320, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 46;
            this.label12.Text = "Telefono";
            // 
            // TBTelefono
            // 
            this.TBTelefono.BackColor = System.Drawing.Color.White;
            this.TBTelefono.Enabled = false;
            this.TBTelefono.Location = new System.Drawing.Point(295, 114);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.ReadOnly = true;
            this.TBTelefono.Size = new System.Drawing.Size(97, 20);
            this.TBTelefono.TabIndex = 45;
            this.TBTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 394);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TBDNIEmpleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBNombreEmpleado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBEmailCliente);
            this.Controls.Add(this.TBDNICliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GridDetalles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBPago);
            this.Controls.Add(this.TBNombreCliente);
            this.Controls.Add(this.TBCodVenta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleCompra";
            this.Load += new System.EventHandler(this.DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private TextBox TBTotal;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private TextBox TBEmailCliente;
        private TextBox TBDNICliente;
        private Label label6;
        private TextBox TBFecha;
        private Label label5;
        private DataGridView GridDetalles;
        private Label label4;
        private Label label2;
        private TextBox TBPago;
        private TextBox TBNombreCliente;
        private TextBox TBCodVenta;
        private Label label1;
        private Button button2;
        private Label label10;
        private TextBox TBNombreEmpleado;
        private TextBox TBDNIEmpleado;
        private Label label11;
        private Label label12;
        private TextBox TBTelefono;
    }
}