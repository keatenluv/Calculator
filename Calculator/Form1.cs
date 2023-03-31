namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            result.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            result.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            result.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            result.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            result.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            result.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            result.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            result.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            result.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            result.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            result.Text += "0";
        }

    }
}