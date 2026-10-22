using System;
using System.Windows.Forms;

namespace btlapp4
{
    public partial class bai8 : Form
    {
        public bai8()
        {
            InitializeComponent();
        }

        private void btnTinhBMI_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCanNang.Text, out double canNang) || canNang <= 0)
            {
                MessageBox.Show("Vui lòng nhập cân nặng hợp lệ (kg)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCanNang.Focus();
                return;
            }

            if (!double.TryParse(txtChieuCao.Text, out double chieuCao) || chieuCao <= 0)
            {
                MessageBox.Show("Vui lòng nhập chiều cao hợp lệ (mét, ví dụ: 1.7)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChieuCao.Focus();
                return;
            }

            double bmi = canNang / (chieuCao * chieuCao);
            lblKetQua.Text = $"Chỉ số BMI: {bmi:F2}";

            string phanLoai = "";
            if (bmi < 18.5)
            {
                phanLoai = "Gầy (Thiếu cân)";
            }
            else if (bmi < 24.9)
            {
                phanLoai = "Bình thường";
            }
            else if (bmi < 29.9)
            {
                phanLoai = "Thừa cân";
            }
            else
            {
                phanLoai = "Béo phì";
            }

            lblPhanLoai.Text = $"Phân loại: {phanLoai}";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}