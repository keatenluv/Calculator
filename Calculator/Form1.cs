namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            result.Text = "";
        }

        private void checkInput()
        {

        }

        private void inputNumber(string num)
        {
            string[] inputs = result.Text.Split(' ');
            if (inputs[0].Length != 6) { result.Text += num; }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            inputNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inputNumber("2");
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            inputNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            inputNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            inputNumber("6");
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

        private void btn3_Click(object sender, EventArgs e)
        {
            result.Text += "3";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            result.Text += " + ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            result.Text += " - ";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            result.Text += " / ";
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            result.Text += " * ";
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

       
    }
}