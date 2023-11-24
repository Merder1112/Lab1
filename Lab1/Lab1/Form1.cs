namespace Lab1
{
    public partial class Form1 : Form
    {
        private string userinput;

        public Form1()
        {
            InitializeComponent();
        }
        string number1 = string.Empty;
        string operation ;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "ก็ผมไม่ไดไปดูพี่เบิร์ดอ่ะ";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "6";
        }

        private void button87_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "9";
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + ".";
        }

        private void buttonบวก_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
             operation = "+";
        }

        private void buttonลบ_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
             operation = "-";
        }

        private void buttonคูณ_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
             operation = "*";
        }

        private void buttonหาร_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
             operation = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "Nigga on sell";
        }

        private void buttonenter_Click(object sender, EventArgs e)
        {
            string number2 = textBoxInput.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            if (operation == "+")
            {
                int output = num1 + num2 ;
                textBoxInput.Text = output. ToString();
            }
            else if (operation == "-")
            {
                int output = num1 - num2;
                textBoxInput.Text = output. ToString();
            }
            else if (operation == "*")
            {
                int output = num1 * num2;
                textBoxInput.Text = output.ToString();
            }
            else if (operation == "/")
            {
                int output = num1 / num2;
                textBoxInput.Text = output.ToString();
            }
        }
    }
}
