using System.Diagnostics.CodeAnalysis;

namespace Bai8
{

    public partial class Form1 : Form
    {
        List<KhachHang> DS = new List<KhachHang>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = DS;
            dataGridView1.Columns[0].HeaderCell.Value = "Mã tài khoản";
            dataGridView1.Columns[1].HeaderCell.Value = "Tên khách hàng";
            dataGridView1.Columns[2].HeaderCell.Value = "Địa chỉ";
            dataGridView1.Columns[3].HeaderCell.Value = "Số tiền";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!VerifyInput())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = Find(TxtSTK.Text);
            if(index == -1)
            {
                this.AddRecord();
                //dataGridView1.Update();
                //dataGridView1.Refresh();
            }
            else
            {
                ModifyRecord(index);
                //dataGridView1.Update();
                //dataGridView1.Refresh();
            }
            ClearFields();
        }

        private void AddRecord()
        {
            KhachHang model = new KhachHang(TxtSTK.Text, TxtTen.Text, TxtDiaChi.Text, Convert.ToInt64(TxtSoTien.Text));
            DS.Add(model);
            var source = new BindingSource(DS, null);
            dataGridView1.DataSource = source;
        }

        private void ModifyRecord(int index)
        {
            DS[index].TenKhachHang = TxtTen.Text;
            DS[index].DiaChi = TxtDiaChi.Text;
            DS[index].SoTien = Convert.ToInt64(TxtSoTien.Text);
            var source = new BindingSource(DS, null);
            dataGridView1.DataSource = source;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            TxtSTK.Text = row.Cells[0].Value.ToString();
            TxtTen.Text = row.Cells[1].Value.ToString();
            TxtDiaChi.Text = row.Cells[2].Value.ToString();
            TxtSoTien.Text = row.Cells[3].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerifyInput()
        {
            bool result = true;
            if (TxtSTK.Text == "" || TxtTen.Text == "" || TxtDiaChi.Text == "" || TxtSoTien.Text == "")
            {
                result = false;
            }
            return result;
        }

        private int Find(string MaTK)
        {
            var result = DS.FindIndex(c => c.SoTaiKhoan == MaTK);
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtSTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = Find(TxtSTK.Text);
            if(index == -1)
            {
                MessageBox.Show("Không tìm thấy tài khoản với số tài khoản cần tìm!", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Yes/No", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DS.RemoveAt(index);
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
            }
            ClearFields();
            return;
        }
        private void ClearFields()
        {
            TxtDiaChi.Text = TxtSoTien.Text = TxtSTK.Text = TxtTen.Text = "";
        }

        private void TxtSTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}