using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 坐标正算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        public double DeltX(double edge, double a)
        {
            double deltX = edge * Math.Cos(a * Math.PI / 180);
            return deltX;
        }
        public double DeltY(double edge, double a)
        {
            double deltY = edge * Math.Sin(a * Math.PI / 180);
            return deltY;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(textBoxX1.Text);
            double y1 = double.Parse(textBoxY1.Text);
            double d = double.Parse(textBoxEdge.Text);
            double a = double.Parse(textBoxa.Text);
            double deltX = DeltX(d, a);
            double deltY = DeltY(d, a);
            textBoxX2.Text = (x1 + deltX).ToString();
            textBoxY2.Text = (y1 + deltY).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxX1.Text = string.Empty;
            textBoxY1.Text = string.Empty;
            textBoxa.Text = string.Empty;
            textBoxEdge.Text = string.Empty;
            textBoxX2.Text = string.Empty;
            textBoxY2.Text = string.Empty;
        }
    }
}
