namespace Lab1
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
            label = new Label();
            buttonAdd = new Button();
            textBoxInput = new TextBox();
            buttonClear = new Button();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button87 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonหาร = new Button();
            buttonคูณ = new Button();
            buttonลบ = new Button();
            buttonบวก = new Button();
            buttonenter = new Button();
            buttondot = new Button();
            button13 = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.LightGray;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(12, 16);
            label.Name = "label";
            label.Size = new Size(218, 32);
            label.TabIndex = 1;
            label.Text = "นายจิรกิตติ์ โลหะวาทิน";
            label.Click += label1_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 193);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(123, 73);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(12, 103);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(252, 62);
            textBoxInput.TabIndex = 3;
            textBoxInput.Text = "ไม่หล่อไม่รวย";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(141, 193);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(123, 73);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // button0
            // 
            button0.Location = new Point(319, 353);
            button0.Name = "button0";
            button0.Size = new Size(248, 72);
            button0.TabIndex = 5;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button1
            // 
            button1.Location = new Point(319, 277);
            button1.Name = "button1";
            button1.Size = new Size(111, 70);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(436, 277);
            button2.Name = "button2";
            button2.Size = new Size(131, 70);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(573, 277);
            button3.Name = "button3";
            button3.Size = new Size(123, 70);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(319, 201);
            button4.Name = "button4";
            button4.Size = new Size(111, 70);
            button4.TabIndex = 9;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(436, 201);
            button5.Name = "button5";
            button5.Size = new Size(131, 70);
            button5.TabIndex = 10;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(573, 201);
            button6.Name = "button6";
            button6.Size = new Size(123, 70);
            button6.TabIndex = 11;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button87
            // 
            button87.Location = new Point(319, 121);
            button87.Name = "button87";
            button87.Size = new Size(111, 74);
            button87.TabIndex = 12;
            button87.Text = "7";
            button87.UseVisualStyleBackColor = true;
            button87.Click += button87_Click;
            // 
            // button8
            // 
            button8.Location = new Point(436, 121);
            button8.Name = "button8";
            button8.Size = new Size(131, 74);
            button8.TabIndex = 13;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(573, 121);
            button9.Name = "button9";
            button9.Size = new Size(123, 74);
            button9.TabIndex = 14;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonหาร
            // 
            buttonหาร.Location = new Point(436, 36);
            buttonหาร.Name = "buttonหาร";
            buttonหาร.Size = new Size(131, 79);
            buttonหาร.TabIndex = 15;
            buttonหาร.Text = "/";
            buttonหาร.UseVisualStyleBackColor = true;
            buttonหาร.Click += buttonหาร_Click;
            // 
            // buttonคูณ
            // 
            buttonคูณ.Location = new Point(573, 36);
            buttonคูณ.Name = "buttonคูณ";
            buttonคูณ.Size = new Size(123, 79);
            buttonคูณ.TabIndex = 16;
            buttonคูณ.Text = "*";
            buttonคูณ.UseVisualStyleBackColor = true;
            buttonคูณ.Click += buttonคูณ_Click;
            // 
            // buttonลบ
            // 
            buttonลบ.Location = new Point(702, 36);
            buttonลบ.Name = "buttonลบ";
            buttonลบ.Size = new Size(86, 79);
            buttonลบ.TabIndex = 17;
            buttonลบ.Text = "-";
            buttonลบ.UseVisualStyleBackColor = true;
            buttonลบ.Click += buttonลบ_Click;
            // 
            // buttonบวก
            // 
            buttonบวก.Location = new Point(702, 121);
            buttonบวก.Name = "buttonบวก";
            buttonบวก.Size = new Size(86, 150);
            buttonบวก.TabIndex = 18;
            buttonบวก.Text = "+";
            buttonบวก.UseVisualStyleBackColor = true;
            buttonบวก.Click += buttonบวก_Click;
            // 
            // buttonenter
            // 
            buttonenter.Location = new Point(702, 277);
            buttonenter.Name = "buttonenter";
            buttonenter.Size = new Size(86, 150);
            buttonenter.TabIndex = 19;
            buttonenter.Text = "=";
            buttonenter.UseVisualStyleBackColor = true;
            buttonenter.Click += buttonenter_Click;
            // 
            // buttondot
            // 
            buttondot.Location = new Point(573, 357);
            buttondot.Name = "buttondot";
            buttondot.Size = new Size(123, 70);
            buttondot.TabIndex = 20;
            buttondot.Text = ".";
            buttondot.UseVisualStyleBackColor = true;
            buttondot.Click += buttondot_Click;
            // 
            // button13
            // 
            button13.Location = new Point(319, 36);
            button13.Name = "button13";
            button13.Size = new Size(111, 79);
            button13.TabIndex = 21;
            button13.Text = "secret";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button13);
            Controls.Add(buttondot);
            Controls.Add(buttonenter);
            Controls.Add(buttonบวก);
            Controls.Add(buttonลบ);
            Controls.Add(buttonคูณ);
            Controls.Add(buttonหาร);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button87);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(buttonClear);
            Controls.Add(textBoxInput);
            Controls.Add(buttonAdd);
            Controls.Add(label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label;
        private Button buttonAdd;
        private TextBox textBoxInput;
        private Button buttonClear;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button87;
        private Button button8;
        private Button button9;
        private Button buttonหาร;
        private Button buttonคูณ;
        private Button buttonลบ;
        private Button buttonบวก;
        private Button buttonenter;
        private Button buttondot;
        private Button button13;
    }
}
