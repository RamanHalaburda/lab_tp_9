using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
            Определить понятие «Точка». Состояние объекта определяется
            следующими полями:
            координата по оси абсцисс (вещественное число);
            координата по оси ординат (вещественное число).
            Базируясь на понятии «Точка», определить понятие
            «Прямоугольник». Прямоугольник определить через точки,
            соответствующие его левому верхнему и правому нижнему
            углам. Сдвинуть правый нижний угол прямоугольника пообеим
            осям на заданное расстояние DELTA и вычислить периметр
            прямоугольника после сдвига угла.
         */
        private Rectangle rectangle;
        private Point p1;
        private Point p2;

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            listBox1.Visible = false;
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lbx = 0, lby = 0, rtx = 0, rty = 0;
            if (Double.TryParse(textBox1.Text, out lbx) &&
                Double.TryParse(textBox2.Text, out lby) &&
                Double.TryParse(textBox3.Text, out rtx) &&
                Double.TryParse(textBox4.Text, out rty))
            {
                p1 = new Point(lbx, lby);
                p2 = new Point(rtx, rty);
                rectangle = new Rectangle(p1, p2);
                groupBox1.Visible = true;
                listBox1.Visible = true;
                listBox1.Items.Clear();
                listBox1.Items.Add(String.Concat("new Rectangle: ", rectangle.ToString()));
            }
            else
                MessageBox.Show("Wrong values!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double step = 0;
            if (Double.TryParse(textBox5.Text, out step))
            {
                rectangle.moveRectangle(step);
                listBox1.Items.Add(String.Concat("move Rectangle: ", rectangle.ToString()));
            }
            else
                MessageBox.Show("Wrong value!");
        }
    }
}
