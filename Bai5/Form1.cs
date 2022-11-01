namespace Bai5
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayAnswer()
        {
            textBox3.Text = result.ToString();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = num1 + num2;
            DisplayAnswer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            DisplayAnswer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = num1 - num2;
            DisplayAnswer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result = num1 * num2;
            DisplayAnswer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = num1 / num2;
            DisplayAnswer();
        }
    }
}