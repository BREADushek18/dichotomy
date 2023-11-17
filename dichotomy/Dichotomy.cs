using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using System.Diagnostics;

namespace dichotomy
{
    public partial class DichotomyForm : Form
    {
        double interval1, interval2;
        int accuracy;
        public DichotomyForm()
        {
            InitializeComponent();
        }

        // Обработчик событий для пункта меню "Запустить"
        private void запуститьToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            

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
            
        }

        private void chartDichotomy_Click(object sender, EventArgs eventArgs)
        {
            double interval1Value = double.Parse(txtInterval1.Text);
            double leftBorder = interval1Value - 1;
            double interval2Value = double.Parse(txtInterval2.Text);
            double rightBorder = interval2Value + 1;
            double CoordStep = 0.1;
            double CoordX;
            double CoordY;
            this.chartDichotomy.Series[0].Points.Clear();
            chartDichotomy.ChartAreas[0].AxisX.Interval = 1;
            CoordX = leftBorder + CoordStep;
            while (CoordX <= rightBorder)
            {
                CoordY = Func(CoordX);
                this.chartDichotomy.Series[0].Points.AddXY(CoordX, CoordY);
                CoordX += CoordStep;
            }
        }
        // Обработчик событий для пункта меню "Очистить"
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            // Очистка всех полей ввода
            txtInterval1.Clear();
            txtInterval2.Clear();
            txtAccuracy.Clear();
            chartDichotomy.Series[0].Points.Clear(); 
        }

        // Метод функции
        private double Func(double x)
        {
            return (27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3);
        }
        private double AntiFunc(double x)
        {
            return -((27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3));
        }
        private double Derivative(double x)
        {
            return ((4 * x - 18) * Math.Exp(-x / 3) - ((2 * Math.Pow(x, 2) - 18 * x + 27) * Math.Exp(-x / 3) / 3));
        }
        // Метод Дихотомии
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
        public double GoldenSection(double interval1, double interval2, int accuracy)
        {
            const double golden = 1.618033988749895;
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
        public double AntiGoldenSection(double interval1, double interval2, int accuracy)
        {
            const double golden = 1.618033988749895;
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
        public double Newton(double interval1, double interval2, int accuracy)
        {
            double a = interval1, b = interval2;
            double x0 = (a + b) / 2; // начальное приближение

            while (Math.Abs(Func(x0)) > Math.Pow(10, -accuracy))
            {
                double derivative = Derivative(x0);
                x0 = x0 - Func(x0) / derivative;
            }

            return Math.Round(x0, accuracy);
        }
        public double CoordinateDescent(double interval1, double interval2, int accuracy)
        {
            double a = interval1, b = interval2;
            double x = (a + b) / 2; // Инициализация начального значения x
            double delta = 1 / Math.Pow(10, accuracy); // Вычисление дельты по точности n

            while (b - a > delta) // Условие остановки
            {
                if (Func(a) > Func(b))
                    a = x; // Если значение функции в точке a больше, обновляем начальную границу
                else
                    b = x; // Иначе обновляем конечную границу

                x = (a + b) / 2; // Вычисление нового значения x
            }

            return Math.Round(x, accuracy); // Возвращаем значение x с заданной точностью n
        }
        public double AntiCoordinateDescent(double interval1, double interval2, int accuracy)
        {
            double a = interval1, b = interval2;
            double x = (a + b) / 2; // Инициализация начального значения x
            double delta = 1 / Math.Pow(10, accuracy); // Вычисление дельты по точности n

            while (b - a > delta) // Условие остановки
            {
                if (AntiFunc(a) > AntiFunc(b)) 
                    a = x; // Если значение функции в точке a больше, обновляем начальную границу
                else
                    b = x; // Иначе обновляем конечную границу

                x = (a + b) / 2; // Вычисление нового значения x
            }

            return Math.Round(x, accuracy); // Возвращаем значение x с заданной точностью n
        }
        private void очиститьDichotomyToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            // Очистка всех полей ввода
            txtInterval1.Clear();
            txtInterval2.Clear();
            txtAccuracy.Clear();
            this.chartDichotomy.Series[0].Points.Clear();
        }
        private void дихотомияToolStripMenuItem1_Click(object sender, EventArgs EventArgs)
        {
            // Решение задачи методом дихотомии
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double resultDichotomy = Dichotomy(interval1, interval2, accuracy);
            stopwatch.Stop();
            string dichotomyResult;
            if (resultDichotomy == interval1 || resultDichotomy == interval2)
            {
                dichotomyResult = "Точки пересечения нет на данном интервале";
            }
            else
            {
                dichotomyResult = resultDichotomy.ToString();
            }
            double elapsedTimeInNanoseconds = stopwatch.Elapsed.TotalMilliseconds * 1000000;
            chartDichotomy_Click(sender, EventArgs);
            MessageBox.Show($"Ноль функции: {dichotomyResult} \n Время выполнения: {elapsedTimeInNanoseconds} наносекунд");
        }
        private void золотоеСечениеToolStripMenuItem_Click(object sender, EventArgs EventArgs)
        {
            // Решение задачи с помощью золотого сечения
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double resultMin = GoldenSection(interval1, interval2, accuracy);
            double resultMax = AntiGoldenSection(interval1, interval2, accuracy);
            stopwatch.Stop();
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
            double elapsedTimeInNanoseconds = stopwatch.Elapsed.TotalMilliseconds * 1000000;
            chartDichotomy_Click(sender, EventArgs);
            MessageBox.Show($"Точка минимума: {minResult}\n" + $"Точка максимума: {maxResult} \n Время выполнения: {elapsedTimeInNanoseconds} наносекунд");
        }
        private void ньютонToolStripMenuItem_Click(object sender, EventArgs EventArgs)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double resultNewton = Newton(interval1, interval2, accuracy);
            stopwatch.Stop();
            string newtonResult;
            if (resultNewton == interval1 || resultNewton == interval2)
            {
                newtonResult = "Точки пересечения нет на данном интервале";
            }
            else
            {
                newtonResult = resultNewton.ToString();
            }
            double elapsedTimeInNanoseconds = stopwatch.Elapsed.TotalMilliseconds * 1000000;
            chartDichotomy_Click(sender, EventArgs);
            MessageBox.Show($"Ноль функции: {newtonResult} \n Время выполнения: {elapsedTimeInNanoseconds} наносекунд");
        }
        private void покоординатныйСпускToolStripMenuItem_Click(object sender, EventArgs EventArgs)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double resultMin = CoordinateDescent(interval1, interval2, accuracy);
            double resultMax = AntiCoordinateDescent(interval1, interval2, accuracy);
            stopwatch.Stop();
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
            double elapsedTimeInNanoseconds = stopwatch.Elapsed.TotalMilliseconds * 1000000;
            chartDichotomy_Click(sender, EventArgs);
            MessageBox.Show($"Точка минимума: {minResult}\n" + $"Точка максимума: {maxResult} \n Время выполнения: {elapsedTimeInNanoseconds} наносекунд");
        }
    }
}
