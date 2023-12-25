using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MathNet.Numerics;
using org.matheval;
using org.matheval.Functions;
using MathNet;
using org;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace dichotomy
{
    public partial class integral : Form
    {
        DichotomyForm mainForm;

        public integral(DichotomyForm form)
        {
            InitializeComponent();
            mainForm = form;
            //MaximizeBox = false;
            //FormBorderStyle = FormBorderStyle.Fixed3D;

            timer1.Interval = 5400; // Интервал в миллисекундах (5 секунд = 5000 мс)
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        private void вернутьсяНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtInterval1.Clear();
            txtInterval2.Clear();
            txtAccuracy.Clear();
            FuncTextBox.Clear();
            textBox5.Clear();
            chartDichotomy.Series[0].Points.Clear();

        }
        private void chartDichotomy_Click(object sender, EventArgs e)
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer1.Stop(); // остановить таймер после 5 секунд

        }

        private void запуститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"E:\chipi.gif");
            this.Controls.Add(pictureBox1);

            try
            {

                label2.Text = "";
                string func = FuncTextBox.Text;
                double start = Convert.ToDouble(txtInterval1.Text);
                double end = Convert.ToDouble(txtInterval2.Text);
                double presision = Convert.ToDouble(txtAccuracy.Text);
                double N = 0;
                if (textBox5.Text != "") N = Convert.ToDouble(textBox5.Text);
                if ((start >= end) || ((end - start) < presision) || (presision <= 0) || (N < 0))
                {
                    Mistake();
                }
                else
                {
                    chartDichotomy_Click(sender, e);
                    if (N != 0)
                    {
                        if (checkBox1.Checked) label2.Text += "\nметод прямоугольников: " + Convert.ToString(Rectangle(func, start, end, N, presision));
                        if (checkBox2.Checked) label2.Text += "\nметод трапеций: " + Convert.ToString(Trapeze(func, start, end, N, presision));
                        if (checkBox3.Checked) label2.Text += "\nметод Симпсона: " + Convert.ToString(Simpson(func, start, end, N, presision));
                    }
                    else
                    {
                        double myN = 2;
                        double myRec = Rectangle(func, start, end, myN, presision);
                        double myTra = Trapeze(func, start, end, myN, presision);
                        double mySim = Simpson(func, start, end, myN, presision);
                        while ((Math.Abs(myRec - mySim) > presision) || (Math.Abs(myTra - mySim) > presision))
                        {
                            myN += 1;
                            myRec = Rectangle(func, start, end, myN, presision);
                            myTra = Trapeze(func, start, end, myN, presision);
                            mySim = Simpson(func, start, end, myN, presision);
                        }
                        if (checkBox1.Checked) label2.Text += "\nметод прямоугольников: " + Convert.ToString(Rectangle(func, start, end, myN, presision));
                        if (checkBox2.Checked) label2.Text += "\nметод трапеций: " + Convert.ToString(Trapeze(func, start, end, myN, presision));
                        if (checkBox3.Checked) label2.Text += "\nметод Симпсона: " + Convert.ToString(Simpson(func, start, end, myN, presision));
                        label2.Text += "\nОптимально N: " + Convert.ToString(myN);
                    }
                    pictureBox1.Visible = true; // показать GIF
                    timer1.Start(); // запустить таймер
                }
            }
            catch
            {
                Mistake();
            }
        }
        void Mistake()
        {
            MessageBox.Show("Некорректный ввод");
        }

        double Func(double x)
        {
            Expression func = new Expression(FuncTextBox.Text.ToLower());
            func.Bind("x", x);
            double result = func.Eval<double>();
            return Convert.ToDouble(result);
        }
        
        double Rectangle(string func, double start, double end, double N, double presision)
        {
            double answer = 0;
            double step = (end - start) / N;
            while (start < end)
            {
                answer += step * Func(start + step / 2);
                start += step;
                if (start + step > end) step = (end - start) / 2;
            }
            return Math.Round(answer, presision.ToString().Length - 2);
        }
        double Trapeze(string func, double start, double end, double N, double presision)
        {
            double answer = 0;
            double step = (end - start) / N;
            while (start < end)
            {
                answer += (Func(start) + Func(start + step)) / 2 * step;
                start += step;
                if (start + step > end) step = (end - start) / 2;
            }
            return Math.Round(answer, presision.ToString().Length - 2);
        }
        double Simpson(string func, double start, double end, double N, double presision)
        {
            double answer = (2 * Trapeze(func, start, end, N, presision) + Rectangle(func, start, end, N, presision)) / 3;
            return Math.Round(answer, presision.ToString().Length - 2);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
