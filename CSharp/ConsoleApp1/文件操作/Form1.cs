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
using System.Windows.Forms.VisualStyles;

namespace 文件操作
{

    public partial class Form1 : Form
    {
        string FileName = "Test.txt";
        public Form1()
        {
            InitializeComponent();
        }
        
        
        FileStream fs = new FileStream(@"C:/Test.txt", FileMode.Open, FileAccess.Read);
        BinaryReader r = new BinaryReader(fs);
        for (int i = 0; i<length; i++)
			{
                text
			}

    }
}
