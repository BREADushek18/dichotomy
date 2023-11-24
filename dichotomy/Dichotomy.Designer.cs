using System;
using System.Drawing;
using System.Windows.Forms;

namespace dichotomy
{
    partial class DichotomyForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.золотоеСечениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ньютонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.олимпиадныеСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пузырьковаяСортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаВставкамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шейкернаяСортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.быстраяСортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаBOGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покоординатныйСпускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultRoot = new System.Windows.Forms.TextBox();
            this.ResultMin = new System.Windows.Forms.TextBox();
            this.ResultMax = new System.Windows.Forms.TextBox();
            this.ResultTime = new System.Windows.Forms.TextBox();
            this.FuncTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartDichotomy)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartDichotomy
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDichotomy.ChartAreas.Add(chartArea3);
            this.chartDichotomy.Location = new System.Drawing.Point(464, 24);
            this.chartDichotomy.Name = "chartDichotomy";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Orange;
            series3.Name = "Series1";
            series3.ShadowColor = System.Drawing.Color.White;
            this.chartDichotomy.Series.Add(series3);
            this.chartDichotomy.Size = new System.Drawing.Size(689, 424);
            this.chartDichotomy.TabIndex = 0;
            this.chartDichotomy.Text = "chart1";
            this.chartDichotomy.Click += new System.EventHandler(this.chartDichotomy_Click);
            // 
            // lblFormula
            // 
            this.lblFormula.Location = new System.Drawing.Point(20, 190);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(110, 40);
            this.lblFormula.TabIndex = 1;
            this.lblFormula.Text = "Мы проводим расчет по формуле";
            // 
            // lblIntervalStart
            // 
            this.lblIntervalStart.Location = new System.Drawing.Point(20, 100);
            this.lblIntervalStart.Name = "lblIntervalStart";
            this.lblIntervalStart.Size = new System.Drawing.Size(100, 20);
            this.lblIntervalStart.TabIndex = 2;
            this.lblIntervalStart.Text = "Начало интервала";
            // 
            // txtInterval1
            // 
            this.txtInterval1.Location = new System.Drawing.Point(150, 100);
            this.txtInterval1.Name = "txtInterval1";
            this.txtInterval1.Size = new System.Drawing.Size(200, 20);
            this.txtInterval1.TabIndex = 3;
            // 
            // lblIntervalEnd
            // 
            this.lblIntervalEnd.Location = new System.Drawing.Point(20, 130);
            this.lblIntervalEnd.Name = "lblIntervalEnd";
            this.lblIntervalEnd.Size = new System.Drawing.Size(100, 20);
            this.lblIntervalEnd.TabIndex = 4;
            this.lblIntervalEnd.Text = "Конец интервала";
            // 
            // txtInterval2
            // 
            this.txtInterval2.Location = new System.Drawing.Point(150, 130);
            this.txtInterval2.Name = "txtInterval2";
            this.txtInterval2.Size = new System.Drawing.Size(200, 20);
            this.txtInterval2.TabIndex = 5;
            // 
            // lblPrecision
            // 
            this.lblPrecision.Location = new System.Drawing.Point(20, 160);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(100, 20);
            this.lblPrecision.TabIndex = 6;
            this.lblPrecision.Text = "Нужная точность";
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.Location = new System.Drawing.Point(150, 160);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.Size = new System.Drawing.Size(200, 20);
            this.txtAccuracy.TabIndex = 7;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 8;
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.золотоеСечениеToolStripMenuItem,
            this.ньютонToolStripMenuItem,
            this.олимпиадныеСортировкиToolStripMenuItem,
            this.покоординатныйСпускToolStripMenuItem});
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItem1.Text = "Дихотомия";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.дихотомияToolStripMenuItem1_Click);
            // 
            // золотоеСечениеToolStripMenuItem
            // 
            this.золотоеСечениеToolStripMenuItem.Name = "золотоеСечениеToolStripMenuItem";
            this.золотоеСечениеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.золотоеСечениеToolStripMenuItem.Text = "Золотое сечение";
            this.золотоеСечениеToolStripMenuItem.Click += new System.EventHandler(this.золотоеСечениеToolStripMenuItem_Click);
            // 
            // ньютонToolStripMenuItem
            // 
            this.ньютонToolStripMenuItem.Name = "ньютонToolStripMenuItem";
            this.ньютонToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.ньютонToolStripMenuItem.Text = "Ньютон";
            this.ньютонToolStripMenuItem.Click += new System.EventHandler(this.ньютонToolStripMenuItem_Click);
            // 
            // олимпиадныеСортировкиToolStripMenuItem
            // 
            this.олимпиадныеСортировкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пузырьковаяСортировкаToolStripMenuItem,
            this.сортировкаВставкамиToolStripMenuItem,
            this.шейкернаяСортировкаToolStripMenuItem,
            this.быстраяСортировкаToolStripMenuItem,
            this.сортировкаBOGOToolStripMenuItem});
            this.олимпиадныеСортировкиToolStripMenuItem.Name = "олимпиадныеСортировкиToolStripMenuItem";
            this.олимпиадныеСортировкиToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.олимпиадныеСортировкиToolStripMenuItem.Text = "Олимпиадные сортировки";
            // 
            // пузырьковаяСортировкаToolStripMenuItem
            // 
            this.пузырьковаяСортировкаToolStripMenuItem.Name = "пузырьковаяСортировкаToolStripMenuItem";
            this.пузырьковаяСортировкаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.пузырьковаяСортировкаToolStripMenuItem.Text = "Пузырьковая сортировка";
            // 
            // сортировкаВставкамиToolStripMenuItem
            // 
            this.сортировкаВставкамиToolStripMenuItem.Name = "сортировкаВставкамиToolStripMenuItem";
            this.сортировкаВставкамиToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.сортировкаВставкамиToolStripMenuItem.Text = "Сортировка вставками";
            // 
            // шейкернаяСортировкаToolStripMenuItem
            // 
            this.шейкернаяСортировкаToolStripMenuItem.Name = "шейкернаяСортировкаToolStripMenuItem";
            this.шейкернаяСортировкаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.шейкернаяСортировкаToolStripMenuItem.Text = "Шейкерная сортировка";
            // 
            // быстраяСортировкаToolStripMenuItem
            // 
            this.быстраяСортировкаToolStripMenuItem.Name = "быстраяСортировкаToolStripMenuItem";
            this.быстраяСортировкаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.быстраяСортировкаToolStripMenuItem.Text = "Быстрая сортировка";
            // 
            // сортировкаBOGOToolStripMenuItem
            // 
            this.сортировкаBOGOToolStripMenuItem.Name = "сортировкаBOGOToolStripMenuItem";
            this.сортировкаBOGOToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.сортировкаBOGOToolStripMenuItem.Text = "Сортировка BOGO";
            // 
            // покоординатныйСпускToolStripMenuItem
            // 
            this.покоординатныйСпускToolStripMenuItem.Name = "покоординатныйСпускToolStripMenuItem";
            this.покоординатныйСпускToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.покоординатныйСпускToolStripMenuItem.Text = "Покоординатный спуск";
            this.покоординатныйСпускToolStripMenuItem.Click += new System.EventHandler(this.покоординатныйСпускToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(20, 360);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 9;
            this.Result.Text = "Ноль функции";
            this.Result.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Min функции";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Max функции";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Время (наносекунды)";
            // 
            // ResultRoot
            // 
            this.ResultRoot.Location = new System.Drawing.Point(150, 360);
            this.ResultRoot.Name = "ResultRoot";
            this.ResultRoot.Size = new System.Drawing.Size(300, 20);
            this.ResultRoot.TabIndex = 13;
            // 
            // ResultMin
            // 
            this.ResultMin.Location = new System.Drawing.Point(150, 390);
            this.ResultMin.Name = "ResultMin";
            this.ResultMin.Size = new System.Drawing.Size(300, 20);
            this.ResultMin.TabIndex = 14;
            // 
            // ResultMax
            // 
            this.ResultMax.Location = new System.Drawing.Point(150, 420);
            this.ResultMax.Name = "ResultMax";
            this.ResultMax.Size = new System.Drawing.Size(300, 20);
            this.ResultMax.TabIndex = 15;
            // 
            // ResultTime
            // 
            this.ResultTime.Location = new System.Drawing.Point(150, 450);
            this.ResultTime.Name = "ResultTime";
            this.ResultTime.Size = new System.Drawing.Size(300, 20);
            this.ResultTime.TabIndex = 16;
            this.ResultTime.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // FuncTextBox
            // 
            this.FuncTextBox.Location = new System.Drawing.Point(150, 190);
            this.FuncTextBox.Name = "FuncTextBox";
            this.FuncTextBox.Size = new System.Drawing.Size(200, 20);
            this.FuncTextBox.TabIndex = 17;
            this.FuncTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // DichotomyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.FuncTextBox);
            this.Controls.Add(this.ResultTime);
            this.Controls.Add(this.ResultMax);
            this.Controls.Add(this.ResultMin);
            this.Controls.Add(this.ResultRoot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.chartDichotomy);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.lblIntervalStart);
            this.Controls.Add(this.txtInterval1);
            this.Controls.Add(this.lblIntervalEnd);
            this.Controls.Add(this.txtInterval2);
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.txtAccuracy);
            this.Controls.Add(this.menuStrip);
            this.Name = "DichotomyForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartDichotomy)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDichotomy;

        private readonly double golden = (1 + Math.Sqrt(5)) / 2; // Золотое сечение
        private Label lblFormula;
        private Label lblIntervalStart;
        private Label lblIntervalEnd;
        private Label lblPrecision;
        private TextBox txtInterval1;
        private TextBox txtInterval2;
        private TextBox txtAccuracy;
        private MenuStrip menuStrip;
        private ToolStripMenuItem запуститьToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem золотоеСечениеToolStripMenuItem;
        private ToolStripMenuItem ньютонToolStripMenuItem;
        private ToolStripMenuItem олимпиадныеСортировкиToolStripMenuItem;
        private ToolStripMenuItem пузырьковаяСортировкаToolStripMenuItem;
        private ToolStripMenuItem сортировкаВставкамиToolStripMenuItem;
        private ToolStripMenuItem шейкернаяСортировкаToolStripMenuItem;
        private ToolStripMenuItem быстраяСортировкаToolStripMenuItem;
        private ToolStripMenuItem сортировкаBOGOToolStripMenuItem;
        private ToolStripMenuItem покоординатныйСпускToolStripMenuItem;
        private Label Result;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ResultRoot;
        private TextBox ResultMin;
        private TextBox ResultMax;
        private TextBox ResultTime;
        private TextBox FuncTextBox;
    }
}

