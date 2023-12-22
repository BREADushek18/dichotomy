namespace dichotomy
{
    partial class integral
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FuncTextBox = new System.Windows.Forms.TextBox();
            this.chartDichotomy = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.вернутьсяНазадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartDichotomy)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncTextBox
            // 
            this.FuncTextBox.Location = new System.Drawing.Point(141, 198);
            this.FuncTextBox.Name = "FuncTextBox";
            this.FuncTextBox.Size = new System.Drawing.Size(200, 20);
            this.FuncTextBox.TabIndex = 26;
            // 
            // chartDichotomy
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDichotomy.ChartAreas.Add(chartArea4);
            this.chartDichotomy.Location = new System.Drawing.Point(570, 32);
            this.chartDichotomy.Name = "chartDichotomy";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Orange;
            series4.Name = "Series1";
            series4.ShadowColor = System.Drawing.Color.White;
            this.chartDichotomy.Series.Add(series4);
            this.chartDichotomy.Size = new System.Drawing.Size(689, 424);
            this.chartDichotomy.TabIndex = 18;
            this.chartDichotomy.Text = "chart1";
            // 
            // lblFormula
            // 
            this.lblFormula.Location = new System.Drawing.Point(11, 198);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(110, 40);
            this.lblFormula.TabIndex = 19;
            this.lblFormula.Text = "Мы проводим расчет по формуле";
            // 
            // lblIntervalStart
            // 
            this.lblIntervalStart.Location = new System.Drawing.Point(11, 108);
            this.lblIntervalStart.Name = "lblIntervalStart";
            this.lblIntervalStart.Size = new System.Drawing.Size(100, 20);
            this.lblIntervalStart.TabIndex = 20;
            this.lblIntervalStart.Text = "Начало интервала";
            // 
            // txtInterval1
            // 
            this.txtInterval1.Location = new System.Drawing.Point(141, 108);
            this.txtInterval1.Name = "txtInterval1";
            this.txtInterval1.Size = new System.Drawing.Size(200, 20);
            this.txtInterval1.TabIndex = 21;
            // 
            // lblIntervalEnd
            // 
            this.lblIntervalEnd.Location = new System.Drawing.Point(11, 138);
            this.lblIntervalEnd.Name = "lblIntervalEnd";
            this.lblIntervalEnd.Size = new System.Drawing.Size(100, 20);
            this.lblIntervalEnd.TabIndex = 22;
            this.lblIntervalEnd.Text = "Конец интервала";
            // 
            // txtInterval2
            // 
            this.txtInterval2.Location = new System.Drawing.Point(141, 138);
            this.txtInterval2.Name = "txtInterval2";
            this.txtInterval2.Size = new System.Drawing.Size(200, 20);
            this.txtInterval2.TabIndex = 23;
            // 
            // lblPrecision
            // 
            this.lblPrecision.Location = new System.Drawing.Point(11, 168);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(100, 20);
            this.lblPrecision.TabIndex = 24;
            this.lblPrecision.Text = "Нужная точность";
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.Location = new System.Drawing.Point(141, 168);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.Size = new System.Drawing.Size(200, 20);
            this.txtAccuracy.TabIndex = 25;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.вернутьсяНазадToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip.TabIndex = 27;
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // вернутьсяНазадToolStripMenuItem
            // 
            this.вернутьсяНазадToolStripMenuItem.Name = "вернутьсяНазадToolStripMenuItem";
            this.вернутьсяНазадToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.вернутьсяНазадToolStripMenuItem.Text = "Вернуться назад";
            this.вернутьсяНазадToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяНазадToolStripMenuItem_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(14, 341);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(124, 19);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "метод Симпсона";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(14, 318);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(122, 19);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "метод трапеций";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(14, 295);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 19);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "метод прямоугольников";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 31;
            // 
            // labelN
            // 
            this.labelN.Location = new System.Drawing.Point(11, 238);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(125, 20);
            this.labelN.TabIndex = 32;
            this.labelN.Text = "Кол-во разбиений (N)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 238);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 33;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(340, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // integral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.FuncTextBox);
            this.Controls.Add(this.chartDichotomy);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.lblIntervalStart);
            this.Controls.Add(this.txtInterval1);
            this.Controls.Add(this.lblIntervalEnd);
            this.Controls.Add(this.txtInterval2);
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.txtAccuracy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "integral";
            this.Text = "integral";
            ((System.ComponentModel.ISupportInitialize)(this.chartDichotomy)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FuncTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDichotomy;
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
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНазадToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}