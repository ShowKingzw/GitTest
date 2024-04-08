using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void labelSum_Click(object sender, EventArgs e)
        {

        }

        private void labelX_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            double X = double.Parse(textBoxX.Text);
            double Y = double.Parse(textBoxY.Text);
            textBoxTimes.Text = (X * Y).ToString();
        }

        private void buttonRest_Click(object sender, EventArgs e)
        {

        }
    }
}
