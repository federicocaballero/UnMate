namespace ProyectoTaller.Capas.Capa_presentacion.VistaSupervisor.Estadisticas
{
    partial class EstadisticasObtenidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.GridCompras = new System.Windows.Forms.DataGridView();
            this.TFecha = new System.Windows.Forms.DateTimePicker();
            this.THasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.CVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BGenerarPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(295, -8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estadisticas de venta";
            // 
            // GridCompras
            // 
            this.GridCompras.AllowUserToAddRows = false;
            this.GridCompras.AllowUserToDeleteRows = false;
            this.GridCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCompras.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCompras.Location = new System.Drawing.Point(0, 339);
            this.GridCompras.Name = "GridCompras";
            this.GridCompras.ReadOnly = true;
            this.GridCompras.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridCompras.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GridCompras.Size = new System.Drawing.Size(802, 96);
            this.GridCompras.TabIndex = 5;
            // 
            // TFecha
            // 
            this.TFecha.Location = new System.Drawing.Point(89, 29);
            this.TFecha.Name = "TFecha";
            this.TFecha.Size = new System.Drawing.Size(200, 20);
            this.TFecha.TabIndex = 9;
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(478, 29);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(200, 20);
            this.THasta.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Porcentaje de ventas por vendedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Top ventas registradas";
            // 
            // CProductos
            // 
            this.CProductos.BorderlineColor = System.Drawing.Color.Transparent;
            this.CProductos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.CProductos.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.ForeColor = System.Drawing.Color.White;
            legend5.Name = "Legend1";
            this.CProductos.Legends.Add(legend5);
            this.CProductos.Location = new System.Drawing.Point(418, 83);
            this.CProductos.Name = "CProductos";
            this.CProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series5.BackSecondaryColor = System.Drawing.Color.Transparent;
            series5.BorderColor = System.Drawing.Color.Transparent;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Color = System.Drawing.Color.Transparent;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.CProductos.Series.Add(series5);
            this.CProductos.Size = new System.Drawing.Size(326, 211);
            this.CProductos.TabIndex = 13;
            this.CProductos.Tag = "Porcentaje";
            this.CProductos.Text = "Porcentaje de ventas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(458, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidades vendidas por categoria";
            // 
            // CVendedores
            // 
            this.CVendedores.BackColor = System.Drawing.Color.Transparent;
            this.CVendedores.BorderlineColor = System.Drawing.Color.Transparent;
            this.CVendedores.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.CVendedores.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.Name = "Legend1";
            this.CVendedores.Legends.Add(legend6);
            this.CVendedores.Location = new System.Drawing.Point(0, 62);
            this.CVendedores.Name = "CVendedores";
            series6.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series6.BackSecondaryColor = System.Drawing.Color.Transparent;
            series6.BorderColor = System.Drawing.Color.Transparent;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Color = System.Drawing.Color.Transparent;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.CVendedores.Series.Add(series6);
            this.CVendedores.Size = new System.Drawing.Size(416, 264);
            this.CVendedores.TabIndex = 7;
            this.CVendedores.Tag = "Porcentaje";
            this.CVendedores.Text = "Porcentaje de ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(136, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha desde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(523, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha hasta";
            // 
            // BGenerarPDF
            // 
            this.BGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGenerarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarPDF.ForeColor = System.Drawing.Color.IndianRed;
            this.BGenerarPDF.Location = new System.Drawing.Point(325, 26);
            this.BGenerarPDF.Name = "BGenerarPDF";
            this.BGenerarPDF.Size = new System.Drawing.Size(111, 30);
            this.BGenerarPDF.TabIndex = 17;
            this.BGenerarPDF.Text = "Descargar pdf";
            this.BGenerarPDF.UseVisualStyleBackColor = true;
            this.BGenerarPDF.Click += new System.EventHandler(this.button1_Click);
            // 
            // EstadisticasObtenidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 443);
            this.Controls.Add(this.BGenerarPDF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.TFecha);
            this.Controls.Add(this.CVendedores);
            this.Controls.Add(this.GridCompras);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadisticasObtenidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.EstadisticasObtenidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridCompras;
        private System.Windows.Forms.DateTimePicker TFecha;
        private System.Windows.Forms.DateTimePicker THasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart CVendedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BGenerarPDF;
    }
}