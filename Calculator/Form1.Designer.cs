namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.borderPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.borderPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderPanel
            // 
            this.borderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.borderPanel.Controls.Add(this.mainPanel);
            this.borderPanel.Location = new System.Drawing.Point(10, 8);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(337, 387);
            this.borderPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::Calculator.Properties.Resources.light_dragon;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.btnEquals);
            this.mainPanel.Controls.Add(this.btn0);
            this.mainPanel.Controls.Add(this.btn3);
            this.mainPanel.Controls.Add(this.btn6);
            this.mainPanel.Controls.Add(this.btn2);
            this.mainPanel.Controls.Add(this.btn5);
            this.mainPanel.Controls.Add(this.btn9);
            this.mainPanel.Controls.Add(this.btn8);
            this.mainPanel.Controls.Add(this.btnAdd);
            this.mainPanel.Controls.Add(this.btnSub);
            this.mainPanel.Controls.Add(this.btnMul);
            this.mainPanel.Controls.Add(this.btnDel);
            this.mainPanel.Controls.Add(this.btnDiv);
            this.mainPanel.Controls.Add(this.btnClear);
            this.mainPanel.Controls.Add(this.btn1);
            this.mainPanel.Controls.Add(this.btn4);
            this.mainPanel.Controls.Add(this.btn7);
            this.mainPanel.Controls.Add(this.btnPercent);
            this.mainPanel.Controls.Add(this.result);
            this.mainPanel.Location = new System.Drawing.Point(13, 18);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(312, 357);
            this.mainPanel.TabIndex = 0;
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Transparent;
            this.btnEquals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.Location = new System.Drawing.Point(234, 300);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(67, 51);
            this.btnEquals.TabIndex = 18;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(85, 300);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(67, 51);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.inputNumber);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(161, 243);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 51);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.inputNumber);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(161, 186);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 51);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.inputNumber);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(85, 243);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 51);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.inputNumber);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(85, 186);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 51);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.inputNumber);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(161, 129);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 51);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.inputNumber);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(85, 129);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 51);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.inputNumber);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(234, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 51);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.inputOperator);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Transparent;
            this.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSub.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSub.Location = new System.Drawing.Point(234, 186);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(67, 51);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.inputOperator);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.Transparent;
            this.btnMul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMul.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMul.Location = new System.Drawing.Point(234, 129);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(67, 51);
            this.btnMul.TabIndex = 8;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.inputOperator);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(161, 72);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(67, 51);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "<-";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Transparent;
            this.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(234, 72);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(67, 51);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.inputOperator);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(85, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 51);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(12, 243);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 51);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.inputNumber);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(12, 186);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 51);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.inputNumber);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(12, 129);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(67, 51);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.inputNumber);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.Transparent;
            this.btnPercent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPercent.Location = new System.Drawing.Point(12, 72);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(67, 51);
            this.btnPercent.TabIndex = 1;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.inputOperator);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.result.ForeColor = System.Drawing.Color.Black;
            this.result.Location = new System.Drawing.Point(12, 13);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(289, 35);
            this.result.TabIndex = 0;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(359, 407);
            this.Controls.Add(this.borderPanel);
            this.Name = "Form1";
            this.Text = "Best Calculator in the World!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.borderPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel borderPanel;
        private Panel mainPanel;
        private TextBox result;
        private Button btnPercent;
        private Button btn0;
        private Button btn3;
        private Button btn6;
        private Button btn2;
        private Button btn5;
        private Button btn9;
        private Button btn8;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDel;
        private Button btnDiv;
        private Button btnClear;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btnEquals;
    }
}