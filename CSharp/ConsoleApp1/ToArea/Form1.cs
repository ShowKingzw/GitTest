using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToArea
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            rTextBox.Text = string.Empty;
            areaTextBox.Text = string.Empty;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double r = double.Parse(rTextBox.Text);
            //double area = double.Parse(areaTextBox.Text);
            double area = Math.PI * r * r;
            areaTextBox.Text = area.ToString();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
