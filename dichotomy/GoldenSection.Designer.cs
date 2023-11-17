namespace dichotomy
{
    partial class GoldenSectionForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblIntervalStart = new System.Windows.Forms.Label();
            this.txtInterval1 = new System.Windows.Forms.TextBox();
            this.lblIntervalEnd = new System.Windows.Forms.Label();
            this.txtInterval2 = new System.Windows.Forms.TextBox();
            this.lblPrecision = new System.Windows.Forms.Label();
            this.txtAccuracy = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(464, 24);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Orange;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.White;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(689, 424);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // lblFormula
            // 
            this.lblFormula.Location = new System.Drawing.Point(50, 50);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(200, 40);
            this.lblFormula.TabIndex = 9;
            this.lblFormula.Text = "Мы проводим расчет по формуле:\n y = (27 - 18x + 2x^2) * e^(-x/3)";
            // 
            // lblIntervalStart
            // 
            this.lblIntervalStart.Location = new System.Drawing.Point(20, 100);
            this.lblIntervalStart.Name = "lblIntervalStart";
            this.lblIntervalStart.Size = new System.Drawing.Size(100, 20);
            this.lblIntervalStart.TabIndex = 10;
            this.lblIntervalStart.Text = "Начало интервала";
            // 
            // txtInterval1
            // 
            this.txtInterval1.Location = new System.Drawing.Point(150, 100);
            this.txtInterval1.Name = "txtInterval1";
            this.txtInterval1.Size = new System.Drawing.Size(200, 20);
            this.txtInterval1.TabIndex = 11;
            // 
            // lblIntervalEnd
            // 
            this.lblIntervalEnd.Location = new System.Drawing.Point(20, 130);
            this.lblIntervalEnd.Name = "lblIntervalEnd";
            this.lblIntervalEnd.Size = new System.Drawing.Size(100, 20);
            this.lblIntervalEnd.TabIndex = 12;
            this.lblIntervalEnd.Text = "Конец интервала";
            // 
            // txtInterval2
            // 
            this.txtInterval2.Location = new System.Drawing.Point(150, 130);
            this.txtInterval2.Name = "txtInterval2";
            this.txtInterval2.Size = new System.Drawing.Size(200, 20);
            this.txtInterval2.TabIndex = 13;
            // 
            // lblPrecision
            // 
            this.lblPrecision.Location = new System.Drawing.Point(20, 160);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(100, 20);
            this.lblPrecision.TabIndex = 14;
            this.lblPrecision.Text = "Нужная точность";
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.Location = new System.Drawing.Point(150, 160);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.Size = new System.Drawing.Size(200, 20);
            this.txtAccuracy.TabIndex = 15;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.toolStripComboBox1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 27);
            this.menuStrip.TabIndex = 16;
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // GoldenSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.lblIntervalStart);
            this.Controls.Add(this.txtInterval1);
            this.Controls.Add(this.lblIntervalEnd);
            this.Controls.Add(this.txtInterval2);
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.txtAccuracy);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.chart1);
            this.Name = "GoldenSectionForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblIntervalStart;
        private System.Windows.Forms.TextBox txtInterval1;
        private System.Windows.Forms.Label lblIntervalEnd;
        private System.Windows.Forms.TextBox txtInterval2;
        private System.Windows.Forms.Label lblPrecision;
        private System.Windows.Forms.TextBox txtAccuracy;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}