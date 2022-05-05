using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using System.Windows.Forms.DataVisualization.Charting;
namespace _6._1_mine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double x1 = Convert.ToInt32(textBox1.Text);
            double xn = Convert.ToDouble(textBox2.Text);
            double step = Convert.ToDouble(textBox3.Text);
            int c = Convert.ToInt32((xn - x1) / step);
            double[] y = new double[c];
            for (int i = 0; i < c; i++)
            {
                y[i] = Pow(x1,2) - 2;
                chart1.Series[0].Points.AddXY(x1, y[i]);
                x1 += step;
            }

        }
    }
}
