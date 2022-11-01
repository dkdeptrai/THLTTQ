using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool reset = false;
        bool clear = false;
        double memo;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonCEClick(Object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void ButtonCClick(Object sender, EventArgs e)
        {
            Reset();
        }
        private void ButtonBackspaceClick(Object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);
        }
        private void ButtonMinusClick(Object sender, EventArgs e)
        {
            Val1 = Convert.ToDouble(textBox1.Text);
            Val1 *= -1;
            textBox1.Text = Val1.ToString();
        }

        private void OneOverButtonClick(Object sender, EventArgs e)
        {
            Val1 = Convert.ToDouble(textBox1.Text);
            Val1 = 1 / Val1;
            textBox1.Text = Val1.ToString();
        }
        private void SqrtButtonClick(Object sender, EventArgs e)
        {
            Val1 = Convert.ToDouble(textBox1.Text);
            Val1 = Math.Sqrt(Val1);
            textBox1.Text = Val1.ToString();
        }
        private void NumberButtonClick(object sender, EventArgs e)
        {
            if(clear)
            {
                textBox1.Text = "";
                clear = false;
            }
            Button button = sender as Button;
            if (button.Text == "." && (textBox1.Text == "" || textBox1.Text.Contains(".")))
            {
                return;
            }
            textBox1.Text += button.Text;
        }

        private void OperatorButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (Operator == "")
            {
                Val1 = Convert.ToDouble(textBox1.Text);
                Operator = button.Text;
                textBox1.Text = "";
            }
            else
            {
                if(textBox1.Text != "")
                {
                    Val2 = Convert.ToDouble(textBox1.Text);
                    Operator = button.Text;
                    clear = true;
                    Calculate();
                }
            }
        }

        private void EqualButtonClick(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Reset()
        {
            textBox1.Text = "";
            Val1 = 0;
            Val2 = 0;
        }

        private void Calculate()
        {
            Val2 = Convert.ToDouble(textBox1.Text);
            switch (Operator)
            {
                case "+":
                    Val1 += Val2;
                    break;
                case "-":
                    Val1 -= Val2;
                    break;
                case "*":
                    Val1 *= Val2;
                    break;
                case "/":
                    if (Val2 == 0)
                    {
                        textBox1.Text = "Error: Divided by 0";
                    }
                    else
                    {
                        Val1 /= Val2;
                    }
                    break;
            }
            textBox1.Text = Val1.ToString();
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            memo = 0;

        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = memo.ToString();
            clear = true;
        }

        private void BtnMS_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                memo = Convert.ToDouble(textBox1.Text);
                clear = true;
            }
        }

        private void BtnMPlus_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(textBox1.Text);
            temp += memo;
            textBox1.Text = temp.ToString();
        }

        private void BtnPercentage_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(textBox1.Text);
            temp = Val1 * temp / 100;
            textBox1.Text = temp.ToString();
        }
    }
}