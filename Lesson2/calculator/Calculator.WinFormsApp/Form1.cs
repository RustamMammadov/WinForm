namespace Calculator.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumber(string number)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = number;
            }
            else
            {
                textBox1.Text = textBox1.Text + number;
            }
        }

        double FirstNumber;
        string Operation;
        private void Ariyhmetic (string ariyhmetic)
        {
            
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = ariyhmetic;
        }



        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnterNumber("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnterNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnterNumber("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EnterNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnterNumber("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EnterNumber("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EnterNumber("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EnterNumber("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EnterNumber("0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Ariyhmetic("+");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ariyhmetic("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Ariyhmetic("*");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Ariyhmetic("/");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
    }
}