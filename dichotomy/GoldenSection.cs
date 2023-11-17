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
    public partial class GoldenSectionForm : Form
    {
        private const double golden = 1.618033988749895;

        public GoldenSectionForm()
        {
            InitializeComponent();
        }

        // Обработчик событий для пункта меню "Запустить"
        private void запуститьToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            double interval1, interval2;
            int accuracy;

            // Проверка правильности ввода и получение значений из TextBox
            if (!double.TryParse(txtInterval1.Text, out interval1) || !double.TryParse(txtInterval2.Text, out interval2) || interval1 >= interval2)
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для интервала.");
                return;
            }

            string accuracyString = txtAccuracy.Text.Trim();
            if (accuracyString.Contains('-'))
            {
                MessageBox.Show("Пожалуйста, введите положительное значение для точности.");
                return;
            }
            else
            {
                if (accuracyString.Contains(','))
                {
                    // Подсчет количества знаков после запятой
                    int decimalPlaces = accuracyString.Length - accuracyString.IndexOf(',') - 1;
                    accuracy = decimalPlaces;
                }
                else
                {
                    // Проверка корректности ввода для accuracy
                    if (!int.TryParse(accuracyString, out accuracy))
                    {
                        MessageBox.Show("Пожалуйста, введите корректное значение для точности.");
                        return;
                    }
                }
            }

            // Решение задачи с помощью золотого сечения
            double resultMin = GoldenSection(interval1, interval2, accuracy);
            double resultMax = AntiGoldenSection(interval1, interval2, accuracy);
            string minResult;
            string maxResult;
            if (resultMin == interval1 || resultMin == interval2)
            {
                minResult = "Точки минимума нет на данном интервале";
            }
            else
            {
                minResult = resultMin.ToString();
            }
            if (resultMax == interval1 || resultMax == interval2)
            {
                maxResult = "Точки максимума нет на данном интервале";
            }
            else
            {
                maxResult = resultMax.ToString();
            }

            MessageBox.Show($"Точка минимума: {minResult}\n" + $"Точка максимума: {maxResult}");
        }

        private void chartGoldenSection_Click(object sender, EventArgs eventArgs)
        {
            double interval1 = double.Parse(txtInterval1.Text);
            double leftBorder = interval1 - 1;
            double interval2 = double.Parse(txtInterval2.Text);
            double rightBorder = interval2 + 1;
            double CoordStep = 0.1;
            double CoordX;
            double CoordY;
            this.chart1.Series[0].Points.Clear();
            CoordX = leftBorder + CoordStep;
            while (CoordX <= rightBorder)
            {
                CoordY = Func(CoordX);
                this.chart1.Series[0].Points.AddXY(CoordX, CoordY);
                CoordX += CoordStep;
            }
        }

        // Обработчик событий для пункта меню "Очистить"
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            // Очистка всех полей ввода и графика
            txtInterval1.Clear();
            txtInterval2.Clear();
            txtAccuracy.Clear();
            this.chart1.Series[0].Points.Clear();
        }

        // Метод функции и функции с минусом
        private double Func(double x)
        {
            return (27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3);
        }
        private double AntiFunc(double x)
        {
            return -((27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3));
        }
        // Метод Золотого сечения
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

    }
}
