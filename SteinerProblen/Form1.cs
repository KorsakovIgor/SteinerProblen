using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace SteinerProblen
{
    public partial class Form1 : Form
    {
        List<Point> points = new List<Point>();
        Point res = new Point(0.0, 0.0);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                points.Add(new Point(Convert.ToDouble(CoordX.Text.ToString()), Convert.ToDouble(CoordY.Text.ToString())));
                listBox1.Items.Add(points.Count + ") (" + CoordX.Text.ToString() + "; " + CoordY.Text.ToString() + ")");
            }
            catch(FormatException)
            {
                MessageBox.Show("Ошибка входных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            points.Clear();
            listBox1.Items.Clear();
        }

        double Circ(double x)
        {
            x = x * 100;
            x = (int)x;
            x = x / 100;
            return x;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Maximum = Convert.ToInt32(MaxIterNumeric.Value);
                progressBar1.Minimum = 0;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                AlgorithmFFS obj = new AlgorithmFFS(Convert.ToInt32(MaxIterNumeric.Value), Convert.ToDouble(vIndMax.Text), Convert.ToDouble(vVolMax.Text), Convert.ToInt32(MaxWetghtNumeric.Value), Convert.ToInt32(populationCountNumeric.Value));
                obj.progress = progressBar1;
                this.res = obj.FFS(points);
                Answer.Text = "Точка ферма: (" + Circ(res.x).ToString() + "; " + Circ(res.y).ToString() + ")" + Environment.NewLine;
                Answer.Text += "Сумма длин до всех точек: " + Circ(obj.graph.fitnessFunction(res)).ToString();
                DrawGraph(obj.graph.xmin, obj.graph.xmax, obj.graph.ymin, obj.graph.ymax);
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка входных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Maximum = Convert.ToInt32(MaxIterNumeric.Value);
                progressBar1.Minimum = 0;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                FAlgorithm obj = new FAlgorithm(Convert.ToInt32(MaxIterFNumeric.Value), Convert.ToDouble(Beta0.Text), Convert.ToDouble(Gamma.Text), Convert.ToDouble(Alpha.Text), Convert.ToInt32(FpopulNumeric.Value));
                obj.progress = progressBar1;
                this.res = obj.Calculate(points);
                AnswerF.Text = "Точка ферма: (" + Circ(res.x).ToString() + "; " + Circ(res.y).ToString() + ")" + Environment.NewLine;
                AnswerF.Text += "Сумма длин до всех точек: " + Circ(obj.graph.fitnessFunction(res)).ToString();
                DrawGraph(obj.graph.xmin, obj.graph.xmax, obj.graph.ymin, obj.graph.ymax);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DrawGraph(double Xmin, double Xmax, double Ymin, double Ymax)
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl1.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();
            PointPairList list1 = new PointPairList();

            // Интервал, в котором будут лежать точки
            int xmin = (int)Xmin - 3;
            int xmax = (int)Xmax + 3;

            int ymin = (int)Ymin - 3;
            int ymax = (int)Ymax + 3;



            // Заполняем список точек
            for (int i = 0; i < points.Count; i++)
            {
                list.Add(points[i].x, points[i].y);
            }
            list1.Add(res.x, res.y);
            
            // !!!
            // Создадим кривую с названием "Scatter".
            // Обводка ромбиков будут рисоваться голубым цветом (Color.Blue),
            // Опорные точки - ромбики (SymbolType.Diamond)
            LineItem myCurve = pane.AddCurve("Набор точек", list, Color.Blue, SymbolType.Square);
            LineItem myCurve1 = pane.AddCurve("Точка Ферма", list1, Color.Red, SymbolType.Square);
            // !!!
            // У кривой линия будет невидимой
            myCurve.Line.IsVisible = false;
            myCurve1.Line.IsVisible = false;

            // !!!
            // Цвет заполнения отметок (ромбиков) - голубой
            myCurve.Symbol.Fill.Color = Color.Blue;
            myCurve1.Symbol.Fill.Color = Color.Red;
            // !!!
            // Тип заполнения - сплошная заливка
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve1.Symbol.Fill.Type = FillType.Solid;

            // !!!
            // Размер ромбиков
            myCurve.Symbol.Size = 7;
            myCurve1.Symbol.Size = 7;

            for(int i=0; i<points.Count; i++)
            {
                list1.Add(points[i].x, points[i].y);
                pane.AddCurve("", list1, Color.Black);
                list1.RemoveAt(1);
            }

            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Min = xmin;
            pane.XAxis.Max = xmax;
            pane.XAxis.Title = "x";

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Min = ymin;
            pane.YAxis.Max = ymax;
            pane.YAxis.Title = "У";

            pane.Title = "Минимальное дерево";

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl1.AxisChange();

            // Обновляем график
            zedGraphControl1.Invalidate();
        }

        
    }
}
