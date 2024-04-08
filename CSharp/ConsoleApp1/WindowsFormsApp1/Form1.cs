using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            // 初始化窗体基本信息
            InitializeComponent();
            this.Load += Form1_Load;
        }


        private void Form1_Load(object sender, EventArgs e)
        {   
            // 窗体第一次被初始化，窗体标题大小，是否允许最大化最小化

            // 一般把代码写在这
            this.Text = "这是由窗体load事件修改的标题";

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 关闭窗体时触发的事件，如果需要清理之类的操作，可以在这里
            // 任务管理器直接关闭时，无法触发该事件
            // 因为这里的事件只能触发内部消息，外部消息无法处理
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 关闭窗体后触发的事件
            // 任务管理器直接关闭时，无法触发该事件
            // 因为这里的事件只能触发内部消息，外部消息无法处理
        }

        private void btn_Click(object sender, EventArgs e)
        {
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            MessageBox.Show("btn1已可用");

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn1.Enabled=false;
            MessageBox.Show("btn1已禁用");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            MessageBox.Show(str);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{comboBox1.Text}");
        }
    }
}
