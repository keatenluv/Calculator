namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            result.Text = "";
            this.KeyPreview = true;
        }

        private void checkInput()
        {
            
        }

        private void inputOperator(string op)
        {
            string[] inputs = result.Text.Split(' ');
            if (inputs.Length < 2) { result.Text += $" {op} "; }
            else {result.Text = result.Text.Replace($" {inputs[1]} ", $" {op} ");  }
        }

        private void inputNumber(string num)
        {
            string[] inputs = result.Text.Split(' ');
            switch (inputs.Length)
            {
                case 1:
                    if (inputs[0].Length != 6) { result.Text += num; }
                    break;
                case 2:
                    result.Text += num;
                    break;
                case 3:
                    if (inputs[2].Length != 6) { result.Text += num; }
                    break;
            }
        }

        #region Number Buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            inputNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inputNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            inputNumber("3");
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
            inputNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            inputNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            inputNumber("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            inputNumber("0");
        }
        #endregion

        #region Operator Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            inputOperator("+");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            inputOperator("-");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            inputOperator("/");
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            inputOperator("*");
        }
        #endregion
       
        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string[] inputs = result.Text.Split(' ');
            if (result.Text.Length > 0 && inputs.Length < 2)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }

        private void changeButtonColor(string color)
        {
            Color update = (Color)new ColorConverter().ConvertFromString(color);
            foreach (Control control in mainPanel.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.ForeColor = update;
                }
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                mainPanel.BackgroundImage = Properties.Resources.dark_dragon;
                changeButtonColor("white");
            }
            else if (e.KeyCode == Keys.L)
            {
                mainPanel.BackgroundImage = Properties.Resources.light_dragon;
                changeButtonColor("black");

            }
        }
    }
}