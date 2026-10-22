using System;
using System.Windows.Forms;

namespace btlapp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        // Nút Cộng
        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                txtKetQua.Text = (so1 + so2).ToString();
            }
            catch { MessageBox.Show("Vui lòng nhập số hợp lệ!"); }
        }

        // Nút Trừ
        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                txtKetQua.Text = (so1 - so2).ToString();
            }
            catch { MessageBox.Show("Vui lòng nhập số hợp lệ!"); }
        }

        // Nút Nhân
        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                txtKetQua.Text = (so1 * so2).ToString();
            }
            catch { MessageBox.Show("Vui lòng nhập số hợp lệ!"); }
        }

        // Nút Chia
        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                if (so2 == 0) MessageBox.Show("Không thể chia cho 0!");
                else txtKetQua.Text = (so1 / so2).ToString();
            }
            catch { MessageBox.Show("Vui lòng nhập số hợp lệ!"); }
        }

        // Nút Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
            txtSo1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}