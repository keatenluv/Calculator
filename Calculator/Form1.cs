namespace Calculator
{
    public partial class Form1 : Form
    {

        bool calculated = false;

        public Form1()
        {
            InitializeComponent();
            result.Text = "";
            this.KeyPreview = true;
            result.ForeColor = Color.Black;
        }

        // When user clicks a operator
        private void inputOperator(object sender, EventArgs e)
        {
            // Cast sender to button to extract the operator
            if (!calculated)
            {
                Button button = sender as Button;
                string op = button?.Text;

                string[] inputs = result.Text.Split(' ');
                if (inputs[0].Length == 0) {; }
                else if (inputs.Length < 2) { result.Text += $" {op} "; }
                else { result.Text = result.Text.Replace($" {inputs[1]} ", $" {op} "); }
            }
        }

        // When user clicks a number
        private void inputNumber(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string num = button?.Text;
            

            if (!calculated)
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
            } else
            {
                result.Text = num;
                calculated = false;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string[] inputs = result.Text.Split(' ');
            if (inputs.Length == 3 && !inputs[2].Equals(""))
            {
                int leftOperand = int.Parse(inputs[0]);
                int rightOperand = int.Parse(inputs[2]);
                string op = inputs[1];
                calculated = true;
                switch (op)
                {
                    case "/":
                        result.Text = (leftOperand / rightOperand).ToString();
                        break;
                    case "*":
                        result.Text = (leftOperand * rightOperand).ToString();
                        break;
                    case "-":
                        result.Text = (leftOperand - rightOperand).ToString();
                        break;
                    case "+":
                        result.Text = (leftOperand + rightOperand).ToString();
                        break;
                    case "%":
                        result.Text = (leftOperand % rightOperand).ToString();
                        break;
                }
            } else
            {
                MessageBox.Show("Incomplete Expression");
            }


        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string[] inputs = result.Text.Split(' ');
            if (result.Text.Length > 0 && inputs.Length < 2)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1);
            }
            else if (inputs.Length > 2 && inputs[2].Length > 0)
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

        // Handles keyboard inputs
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            // If user wants to change theme
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