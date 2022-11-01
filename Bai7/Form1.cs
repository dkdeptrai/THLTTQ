namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Button> PickedRow1 = new List<Button>();
        List<Button> PickedRow2 = new List<Button>();
        List<Button> PickedRow3 = new List<Button>();

        int Total = 0;
        private void ButtonR1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor != Color.Yellow)
            {
                if (button.BackColor == Color.White)
                {
                    button.BackColor = Color.Blue;
                    PickedRow1.Add(button);
                }
                else
                {
                    button.BackColor = Color.White;
                    PickedRow1.Remove(button);
                }
            }
            else
            {
                MessageBox.Show("Ghế đã có người chọn");
            }
        }
        private void ButtonR2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor != Color.Yellow)
            {
                if (button.BackColor == Color.White)
                {
                    button.BackColor = Color.Blue;
                    PickedRow2.Add(button);
                }
                else
                {
                    button.BackColor = Color.White;
                    PickedRow2.Remove(button);
                }
            }
            else
            {
                MessageBox.Show("Ghế đã có người chọn");
            }
        }
        private void ButtonR3_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor != Color.Yellow)
            {
                if (button.BackColor == Color.White)
                {
                    button.BackColor = Color.Blue;
                    PickedRow3.Add(button);
                }
                else
                {
                    button.BackColor = Color.White;
                    PickedRow3.Remove(button);
                }
            }
            else
            {
                MessageBox.Show("Ghế đã có người chọn");
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            foreach (Button btn in PickedRow1)
            {
                btn.BackColor = Color.Yellow;
                Total += 5000;
            }
            foreach (Button btn in PickedRow2)
            {
                btn.BackColor = Color.Yellow;
                Total += 6500;
            }
            foreach (Button btn in PickedRow3)
            {
                btn.BackColor = Color.Yellow;
                Total += 8000;
            }
            TxtThanhTien.Text = Total.ToString();
            PickedRow1 = PickedRow2 = PickedRow3 = new List<Button>();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            foreach (Button btn in PickedRow1)
            {
                btn.BackColor = Color.White;
            }
            foreach (Button btn in PickedRow1)
            {
                btn.BackColor = Color.White;
            }
            foreach (Button btn in PickedRow1)
            {
                btn.BackColor = Color.White;
            }
            TxtThanhTien.Text = "0";
            PickedRow1 = PickedRow2 = PickedRow3 = new List<Button>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
