using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        double a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd= new OpenFileDialog();
            ofd.Title = "打开文件";
            ofd.Filter = "CSV文件|*.csv|TXT文件|*.txt";
            ofd.ShowDialog();

            StreamReader sr= new StreamReader(ofd.FileName);
            double a = double.Parse(sr.ReadLine());
        }
    }
}
