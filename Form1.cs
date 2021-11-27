using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;
using MathNet.Symbolics;
using Express = MathNet.Symbolics.SymbolicExpression;


namespace integrall
{
    public partial class Form1 : Form
    {
        private delegate void UpdateLabelCallback(double S);
        private delegate void UpdatePanelCallback(int[] array);
        public Form1()
        {
            InitializeComponent();
            DrawGraph();
        }
        double s;

        private void verh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back != (e.KeyChar == ',') != (e.KeyChar == '-'))
                {
                    e.Handled = true;
                }
            }
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            
            //result.ReadOnly = true;
            
        }

        
            
        
        private void DrawGraph()
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            pane.YAxis.Title.Text = "Ось Y";
            pane.XAxis.Title.Text = "Ось X";
            pane.Title.Text = "Построение графика функции";
            pane.XAxis.Cross = 0.0;
            pane.YAxis.Cross = 0.0;
            pane.XAxis.Scale.IsSkipFirstLabel = true;
            pane.XAxis.Scale.IsSkipLastLabel = true;
            pane.XAxis.Scale.IsSkipCrossLabel = true;
            pane.YAxis.Scale.IsSkipFirstLabel = true;
            pane.YAxis.Scale.IsSkipLastLabel = true;
            pane.YAxis.Scale.IsSkipCrossLabel = true;
            pane.IsFontsScaled = false;
            pane.IsBoundedRanges = true;
            

            zedGraph.AxisChange();

        }

        private void прямоугльникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(pr));
            readThread.Start();
        }

        public void pr()
        {
            try
            {
                long ellapledTicks = DateTime.Now.Ticks;
                var expr = Express.Parse(function.Text);
                Func<double, double> f = expr.Compile("x");

                double a = Convert.ToDouble(niz.Text);
                double b = Convert.ToDouble(verh.Text);
                double eps = Convert.ToDouble(epsil.Text);
                if (b > a && eps > 0)
                {

                    int n = 10;
                    double sum, sum2 = 0;
                    do
                    {
                        sum = sum2;
                        sum2 = 0;
                        double h = (b - a) / n;
                        double x = a + h;

                        while (x <= b)
                        {
                            sum2 += (f(x) + f(x + h)) * h / 2;
                            x += h;
                        }



                        n *= 2;
                    } while (Math.Abs(sum - sum2) > eps);
                    double S = sum2;
                    label3.Invoke(new UpdateLabelCallback(UpdateLabel3), S);
                    s = n;

                }
                else
                {
                    MessageBox.Show("Проверьте правильность ввода данных!", "Ошибка!");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!", "Ошибка!");
            }
        }

        private void трапецияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(tr));
            readThread.Start();

        }

        public void tr()
        {
            try
            {

                var expr = Express.Parse(function.Text);
                Func<double, double> f = expr.Compile("x");

                double a = Convert.ToDouble(niz.Text);
                double b = Convert.ToDouble(verh.Text);
                double eps = Convert.ToDouble(epsil.Text);
                if (b > a && eps > 0)
                {


                    int n = 10;
                    double sum, sum2 = 0;
                    do
                    {
                        sum = sum2;
                        sum2 = 0;
                        double h = (b - a) / n;
                        double x = a + h;


                        while (x <= b)
                        {
                            sum2 += (f(x) + f(x + h)) * h / 2;
                            x += h;
                        }


                        n *= 2;
                    } while (Math.Abs(sum - sum2) > eps);
                    double S = sum2;
                    label3.Invoke(new UpdateLabelCallback(UpdateLabel3), S);
                    s = n;
                }
                else
                {
                    MessageBox.Show("Проверьте правильность ввода данных!", "Ошибка!");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!", "Ошибка!");
            }
        }

        private void симпсонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(simpson));
            readThread.Start();

        }

        public void simpson ()
        {
            try
            {

                var expr = Express.Parse(function.Text);
                Func<double, double> f = expr.Compile("x");

                double a = Convert.ToDouble(niz.Text);
                double b = Convert.ToDouble(verh.Text);
                double eps = Convert.ToDouble(epsil.Text);
                if (b > a && eps > 0)
                {

                    int n = 10;

                    var h = (b - a) / n;

                    var sum1 = 0d;
                    var sum2 = 0d;

                    for (var k = 1; k <= n; k++)
                    {
                        var xk = a + k * h;
                        if (k <= n - 1)
                        {
                            sum1 += f(xk);
                        }

                        var xk_1 = a + (k - 1) * h;
                        sum2 += f((xk + xk_1) / 2);
                    }

                    double S = h / 3d * (1d / 2d * f(a) + sum1 + 2 * sum2 + 1d / 2d * f(b));
                    n *= 2;

                    label3.Invoke(new UpdateLabelCallback(UpdateLabel3), S);
                    //result.Text = "Ответ: " + resul.ToString();
                    s = n;
                }
                else
                {
                    MessageBox.Show("Проверьте правильность ввода данных!", "Ошибка!");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!", "Ошибка!");
            }
        }

        private void UpdateLabel3(double S)
        {
            label3.Text = Convert.ToString(S);

        }
        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(UpdatePanel));
            readThread.Start();
        }

        private void UpdatePanel()
        {
            try
            {
                if (s != 0)
                {
                    var expr = Express.Parse(function.Text);
                    Func<double, double> f = expr.Compile("x");
                    GraphPane pane = zedGraph.GraphPane;
                    pane.CurveList.Clear();
                    PointPairList list = new PointPairList();
                    LineItem myCurve = pane.AddCurve("Sinc", list, Color.Red, SymbolType.None);

                    double a = Convert.ToDouble(niz.Text);
                    double b = Convert.ToDouble(verh.Text);
                    double h = (b - a) / s;

                    for (double x = a; x <= b; x += h)
                    {
                        list.Add(x, f(x));
                    }

                    int lenght = 1;

                    for (double x = a; x <= b; x += h)
                    {
                        ++lenght;
                    }

                    // Высота столбиков
                    double[] values = new double[lenght];

                    double[] val2 = new double[lenght];
                    int i = 0;
                    for (double x = a; x <= b; x += h, ++i)
                    {
                        values[i] = f(x);
                        val2[i] = x;

                        System.Threading.Thread.Sleep(1000);
                        BarItem curve = pane.AddBar("", val2, values, Color.Pink);

                        zedGraph.AxisChange();
                        zedGraph.Invalidate();
                    }

                    /*double[] val2 = new double[lenght];

                    i = 0;
                    for (double x = a; x <= b; x += h, ++i)
                    {
                        val2[i] = x;
                        
                    }*/

                    
                }
                else
                {
                    MessageBox.Show("Необходимо решить интеграл", "Ошибка!");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!", "Ошибка!");
            }

        }
    }
}


