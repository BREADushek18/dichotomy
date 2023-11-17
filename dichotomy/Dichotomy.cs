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
    public partial class DichotomyForm : Form
    {
        public DichotomyForm()
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
            // Решение задачи методом дихотомии
            double resultDichotomy = Dichotomy(interval1, interval2, accuracy);
            string dichotomyResult;
            if (resultDichotomy == interval1 || resultDichotomy == interval2)
            {
                dichotomyResult = "Точки пересечения нет на данном интервале";
            }
            else
            {
                dichotomyResult = resultDichotomy.ToString();
            }
            chartDichotomy_Click(sender, eventArgs);
            MessageBox.Show($"Ноль функции: {dichotomyResult}");
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
        private void очиститьDichotomyToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            // Очистка всех полей ввода
            txtInterval1.Clear();
            txtInterval2.Clear();
            txtAccuracy.Clear();
            this.chartDichotomy.Series[0].Points.Clear();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            // Добавляем методы в ComboBox
            toolStripComboBox1.Items.Add("Дихотомия");
            toolStripComboBox1.Items.Add("Золотое сечение");
            toolStripComboBox1.Items.Add("Ньютон");
            toolStripComboBox1.Items.Add("Метод покоординатного спуска");

            // Устанавливаем выбранный метод по умолчанию
            toolStripComboBox1.SelectedItem = "Дихотомия";
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранный метод
            string selectedMethod = toolStripComboBox1.SelectedItem.ToString();

            // Открываем форму с выбранным методом
            switch (selectedMethod)
            {
                case "Золотое сечение":
                    Form goldenSectionForm = new GoldenSectionForm();
                    goldenSectionForm.Show();
                    Close();
                    break;
                //case "Ньютон":
                //    Form newtonForm = new NewtonForm();
                //    newtonForm.Show();
                //    break;
                //case "Метод покоординатного спуска":
                //    Form coordinateDescentForm = new CoordinateDescentForm();
                //    coordinateDescentForm.Show();
                //    break;
                default:
                    // Если выбран Дихотомия, то ничего не делаем
                    break;
            }
        }
    }
}
