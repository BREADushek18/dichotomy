using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace dichotomy
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        // Обработчики событий для пунктов меню
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
            


            // Решение задачи методом дихотомии
            double resultDichotomy = Dichotomy(interval1, interval2, accuracy);
            // Решение задачи с помощью золотого сечения
            double resultMin = GoldenSection(interval1, interval2, accuracy);
            double resultMax = AntiGoldenSection(interval1, interval2, accuracy);
            string dichotomyResult;
            string minResult;
            string maxResult;
            if (resultDichotomy == interval1 || resultDichotomy == interval2)
            {
                dichotomyResult = "Точки пересечения нет на данном интервале";
            }
            else
            {
                dichotomyResult = resultDichotomy.ToString();
            }
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
            chart1_Click(sender, eventArgs);
            MessageBox.Show($"Ноль функции: {dichotomyResult}\n" + $"Точка минимума: {minResult}\n" + $"Точка максимума: {maxResult}");


        }

        private void chart1_Click(object sender, EventArgs eventArgs)
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
            if ((27 - 18 * x3 + 2 * Math.Pow(x3, 2)) * Math.Exp(-x3 / 3) < 0 + x3 && (27 - 18 * x3 + 2 * Math.Pow(x3, 2)) * Math.Exp(-x3 / 3) > 0 - x3)
            {
                return Math.Round(x3, accuracy);
            }
            return 0;
        }


        private void очиститьToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            // Очистка всех полей ввода
            txtInterval1.Clear();
            txtInterval2.Clear();
            txtAccuracy.Clear();
            this.chart1.Series[0].Points.Clear();
        }

        
    }
}
