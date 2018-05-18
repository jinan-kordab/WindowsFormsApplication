using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxRight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxMatrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxRelaxation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxIterations_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static double[] Compute(double[,] matrix, double[] right,
        double relaxation, int iterations)
        {
            var x = right;
            double delta;

            for (int k = 0; k < iterations; ++k)
            {
                for (int i = 0; i < right.Length; ++i)
                {
                    delta = 0.0f;

                    for (int j = 0; j < i; ++j)
                        delta += matrix[i, j] * x[j];
                    for (int j = i + 1; j < right.Length; ++j)
                        delta += matrix[i, j] * x[j];

                    delta = (right[i] - delta) / matrix[i, i];
                    x[i] += relaxation * (delta - x[i]);
                }
            }

            return x;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            try
            {

                int n, i;
                n = Convert.ToInt32(textBox1.Text);
                double[][] a = new double[20][];
                int k = Convert.ToInt32(textBox4.Text);

                for (i = 0; i < n; i++)
                    a[i] = new double[n];

                double[] b = new double[15];
                double[] x = new double[15];

                for (i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        a[i][j] = Convert.ToDouble(textBox2.Text);
                    }
                }

                for (i = 0; i < n; i++)
                {
                    b[i] = Convert.ToDouble(textBox3.Text);
                }

                double[] xn = new double[15];
                double[] x_2 = new double[15];
                for (i = 0; i < n; i++)
                    x_2[i] = 0;
                double[] xp = new double[15];
                for (i = 0; i < n; i++)
                    for (i = 0; i < n; i++)
                        x[i] = b[i];
                do
                {
                    for (i = 0; i < n; i++)
                    {
                        xn[i] = 0;
                        for (int j = 0; j < n; j++)
                            xn[i] += a[i][j] * x[j];
                        xn[i] += b[i];
                        x_2[i] = x[i];
                        x[i] = xn[i];
                    }
                    k++;

                    lblZeidelInfo.Visible = true;
                    lblZeidelInfo.Text = "Answer after " + (k - 1) + " iterations";
                    for (i = 0; i < n; i++)
                        label5.Text = "x = " + x[i];
                }

                while (i == k);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Please enter all parameters !");
            }
        }

        private void btnIterations_Click(object sender, EventArgs e)
        {
            try
            {

                int n, i;
                n = Convert.ToInt32(textBox10.Text);
                double[][] a = new double[20][];

                for (i = 0; i < n; i++)
                    a[i] = new double[n];

                double[] b = new double[15];
                double[] x = new double[15];

                for (i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        a[i][j] = Convert.ToDouble(textBox9.Text);
                    }
                }

                for (i = 0; i < n; i++)
                {
                    b[i] = Convert.ToDouble(textBox8.Text);
                }
                int k = Convert.ToInt32(textBox7.Text);
                double[] xn = new double[15];
                double[] x_2 = new double[15];

                for (i = 0; i < n; i++)
                    x_2[i] = 0;
                double[] xp = new double[15];
                for (i = 0; i < n; i++)
                    for (i = 0; i < n; i++)
                        x[i] = b[i];
                do
                {
                    for (i = 0; i < n; i++)
                    {
                        xn[i] = 0;
                        for (int j = 0; j < n; j++)
                            xn[i] += a[i][j] * x[j];
                        xn[i] += b[i];
                        x_2[i] = x[i];
                        x[i] = xn[i];
                    }
                    k++;

                    lblIterationsInfo.Visible = true;
                    lblIterationsInfo.Text = "Result after " + (k - 1) + " iterations";
                    for (i = 0; i < n; i++)
                        lblIterationsSolve.Text = "x= " + x[i];

                }
                while (i == k);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Please anter all parameters!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            label14.Enabled = false;
            textBox12.Enabled = false;

            textBox5.Text = "25 15 -5";
            textBox6.Text = "15 18 0";
            textBox11.Text = "-5 0 11";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            label14.Enabled = true;
            textBox12.Enabled = true;

            textBox5.Text = "18 22 54 42";
            textBox6.Text = "22 70 86 62";
            textBox11.Text = "54 86 174 134";
            textBox12.Text = "42 62 134 106";
        }

        private void choletskyBtnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    // 3 Row matrix

                    string[] rowOne = textBox5.Text.Split(' ');
                    string[] rowTwo = textBox6.Text.Split(' ');
                    string[] rowThree = textBox11.Text.Split(' ');

                    double[,] test1 = new double[,]
                    {
{Convert.ToInt32(rowOne[0]), Convert.ToInt32(rowOne[1]), Convert.ToInt32(rowOne[2])},
{Convert.ToInt32(rowTwo[0]), Convert.ToInt32(rowTwo[1]), Convert.ToInt32(rowTwo[2])},
{Convert.ToInt32(rowThree[0]), Convert.ToInt32(rowThree[1]), Convert.ToInt32(rowThree[2])},
                    };

                    double[,] chol1 = Cholesky(test1);
                    Print(chol1);

                }
                else if (radioButton2.Checked)
                {
                    // 4 Row matrix

                    string[] rowOne = textBox5.Text.Split(' ');
                    string[] rowTwo = textBox6.Text.Split(' ');
                    string[] rowThree = textBox11.Text.Split(' ');
                    string[] rowFour = textBox12.Text.Split(' ');

                    double[,] test2 = new double[,]
                    {
{Convert.ToInt32(rowOne[0]), Convert.ToInt32(rowOne[1]), Convert.ToInt32(rowOne[2]),Convert.ToInt32(rowOne[3])},
{Convert.ToInt32(rowTwo[0]), Convert.ToInt32(rowTwo[1]), Convert.ToInt32(rowTwo[2]),Convert.ToInt32(rowTwo[3])},
{Convert.ToInt32(rowThree[0]), Convert.ToInt32(rowThree[1]), Convert.ToInt32(rowThree[2]),Convert.ToInt32(rowThree[3])},
{Convert.ToInt32(rowFour[0]), Convert.ToInt32(rowFour[1]), Convert.ToInt32(rowFour[2]),Convert.ToInt32(rowFour[3])},
                    };
                    double[,] chol2 = Cholesky(test2);
                    Print(chol2);

                }
                else
                {
                    MessageBox.Show("Please choose the size of the matrix");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Please check the input matrix. It should be Square, Symmetrical, and Positive");
            }
        }

        ///

        /// Returns the lower Cholesky Factor, L, of input matrix A./// Satisfies the equation: L*L^T = A.///


        /// Input matrix must be square, symmetric,
        /// and positive definite. This method does not check for these properties,
        /// and may produce unexpected results of those properties are not met.
        ///

        public static double[,] Cholesky(double[,] a)
        {
            int n = (int)Math.Sqrt(a.Length);

            double[,] ret = new double[n, n];
            for (int r = 0; r < n; r++)
                for (int c = 0; c <= r; c++)
                {
                    if (c == r)
                    {
                        double sum = 0;
                        for (int j = 0; j < c; j++)
                        {
                            sum += ret[c, j] * ret[c, j];
                        }
                        ret[c, c] = Math.Sqrt(a[c, c] - sum);
                    }
                    else
                    {
                        double sum = 0;
                        for (int j = 0; j < c; j++)
                            sum += ret[r, j] * ret[c, j];
                        ret[r, c] = 1.0 / ret[c, c] * (a[r, c] - sum);
                    }
                }

            return ret;
        }

        public void Print(double[,] a)
        {
            int n = (int)Math.Sqrt(a.Length);

            StringBuilder sb = new StringBuilder();
            for (int r = 0; r < n; r++)
            {
                string s = "";
                for (int c = 0; c < n; c++)
                {
                    s += a[r, c].ToString("f5").PadLeft(9) + ",";
                }
                sb.AppendLine(s);
            }

            textBox13.Text = sb.ToString();
            //Console.WriteLine(sb.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}