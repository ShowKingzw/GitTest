namespace WinFormsApp1
{
    public partial class WinForm1 : Form
    {
        public WinForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("ÔÝÎ´¿ª·¢");
            //textBoxX.Clear();
            //textBoxY.Clear();
            textBoxSum.Text = string.Empty;
            textBoxX.Text = string.Empty;
            textBoxY.Text = string.Empty;   
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Run(new Form2());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            double X = double.Parse(textBoxX.Text);
            double Y = double.Parse(textBoxY.Text);
            textBoxSum.Text = (X+Y).ToString();
        }
    }
}