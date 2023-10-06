using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dichotomy
{
    public partial class Form1 : Form
    {
        private readonly double golden = (1 + Math.Sqrt(5)) / 2; // Золотое сечение
        private Label lblFormula;
        private Label lblIntervalStart;
        private Label lblIntervalEnd;
        private Label lblPrecision;
        private TextBox txtInterval1;
        private TextBox txtInterval2;
        private TextBox txtAccuracy;
        public Form1()
        {
            InitializeComponent();

            // Создание и настройка элементов управления
            lblFormula = new Label();
            lblFormula.Location = new Point(50, 50);
            lblFormula.Size = new Size(200, 40);
            lblFormula.Text = "Мы проводим расчет по формуле:\n y = (27 - 18x + 2x^2) * e^(-x/3)";
            this.Controls.Add(lblFormula);

            lblIntervalStart = new Label();
            lblIntervalStart.Location = new Point(20, 100);
            lblIntervalStart.Size = new Size(100, 20);
            lblIntervalStart.Text = "Начало интервала";
            this.Controls.Add(lblIntervalStart);

            txtInterval1 = new TextBox();
            txtInterval1.Location = new Point(150, 100);
            txtInterval1.Size = new Size(200, 20);
            txtInterval1.KeyPress += NumericTextBox_KeyPress;
            this.Controls.Add(txtInterval1);


            lblIntervalEnd = new Label();
            lblIntervalEnd.Location = new Point(20, 130);
            lblIntervalEnd.Size = new Size(100, 20);
            lblIntervalEnd.Text = "Конец интервала";
            this.Controls.Add(lblIntervalEnd);

            txtInterval2 = new TextBox();
            txtInterval2.Location = new Point(150, 130);
            txtInterval2.Size = new Size(200, 20);
            txtInterval2.KeyPress += NumericTextBox_KeyPress;
            this.Controls.Add(txtInterval2);

            lblPrecision = new Label();
            lblPrecision.Location = new Point(20, 160);
            lblPrecision.Size = new Size(100, 20);
            lblPrecision.Text = "Нужная точность";
            this.Controls.Add(lblPrecision);

            txtAccuracy = new TextBox();
            txtAccuracy.Location = new Point(150, 160);
            txtAccuracy.Size = new Size(200, 20);
            txtAccuracy.KeyPress += NumericTextBox_KeyPress;
            this.Controls.Add(txtAccuracy);

            // Добавляем MenuStrip на форму
            MenuStrip menuStrip = new MenuStrip();
            this.Controls.Add(menuStrip);

            // Добавляем пункты меню
            ToolStripMenuItem запуститьToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem очиститьToolStripMenuItem = new ToolStripMenuItem();

            // Настраиваем пункты меню
            запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            запуститьToolStripMenuItem.Text = "Запустить";
            запуститьToolStripMenuItem.Click += new EventHandler(запуститьToolStripMenuItem_Click);

            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Text = "Очистить";
            очиститьToolStripMenuItem.Click += new EventHandler(очиститьToolStripMenuItem_Click);

            // Добавляем пункты меню в MenuStrip
            menuStrip.Items.AddRange(new ToolStripItem[] { запуститьToolStripMenuItem, очиститьToolStripMenuItem });
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs eventArgs)
        {
            // Проверка правильности ввода чисел
            if (!char.IsControl(eventArgs.KeyChar) && !char.IsDigit(eventArgs.KeyChar) && eventArgs.KeyChar != ',' && eventArgs.KeyChar != '-')
            {
                eventArgs.Handled = true;
            }
        }

        // Обработчики событий для пунктов меню
        private void запуститьToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            double interval1, interval2;
            int accuracy;

            // Проверка правильности ввода и получение значений из TextBox
            if (!double.TryParse(txtInterval1.Text, out interval1) || !double.TryParse(txtInterval2.Text, out interval2)
                || !int.TryParse(txtAccuracy.Text, out accuracy) || interval1 >= interval2)
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для интервала и точности.");
                return;
            }

            // Решение задачи методом дихотомии
            double resultDichotomy = Dichotomy(interval1, interval2, accuracy);
            // Решение задачи с помощью золотого сечения
            double resultMin = GoldenSection(interval1, interval2, accuracy);
            double resultMax = AntiGoldenSection(interval1, interval2, accuracy);
            MessageBox.Show($"Ноль функции: {resultDichotomy}\n" + $"Точка минимума: {resultMin}\n" + $"Точка максимума: {resultMax}");


        }

        private double Func(double x)
        {
            return (27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3);
        }
        private double AntiFunc(double x)
        {
            return -((27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3));
        }
        private double GoldenSection(double interval1, double interval2, int accuracy)
        {
            double a = interval1, b = interval2;
            double x1 = b - (b - a) / golden;
            double x2 = a + (b - a) / golden;
            while (Math.Abs(b - a) > Math.Pow(10, -accuracy))
            {
                if (Func(x1) < Func(x2))
                {
                    b = x2;
                }
                else
                {
                    a = x1;
                }

                x1 = b - (b - a) / golden;
                x2 = a + (b - a) / golden;
            }

            return Math.Round((a + b) / 2, accuracy);
        }
        private double AntiGoldenSection(double interval1, double interval2, int accuracy)
        {
            double a = interval1, b = interval2;
            double x1 = b - (b - a) / golden;
            double x2 = a + (b - a) / golden;
            while (Math.Abs(b - a) > Math.Pow(10, -accuracy))
            {
                if (AntiFunc(x1) < AntiFunc(x2))
                {
                    b = x2;
                }
                else
                {
                    a = x1;
                }

                x1 = b - (b - a) / golden;
                x2 = a + (b - a) / golden;
            }

            return Math.Round((a + b) / 2, accuracy);
        }
        private double Dichotomy(double interval1, double interval2, int accuracy)
        {
            double x1 = interval1; 
            double x2 = interval2;
            double x3 = (x1 + x2) / 2;
            while (Math.Abs(x2 - x1) > Math.Pow(10, -accuracy))
            {
                double y1 = Func(x1), y2 = Func(x2), y3 = Func(x3);
                if (y1 * y3 < 0)
                {
                    x2 = x3;
                }
                else if (y2 * y3 < 0)
                {
                    x1 = x3;
                }
                else
                {
                    break;
                }
                x3 = (x1 + x2) / 2;
            }

            return Math.Round(x3, accuracy);
        }


        private void очиститьToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            // Очистка всех полей ввода
            txtInterval1.Clear();
            txtInterval2.Clear();
            txtAccuracy.Clear();
        }

    }
}
