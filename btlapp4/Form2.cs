using System;
using System.Windows.Forms;

namespace btlapp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Sự kiện Ẩn / Hiển thị mật khẩu
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0'; // Hiện mật khẩu
            }
            else
            {
                txtMatKhau.PasswordChar = '*';  // Ẩn mật khẩu thành dấu *
            }
        }

        // Sự kiện Nút Đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            // Kiểm tra nhập thiếu thông tin
            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tài khoản mẫu
            if (tenDN == "admin" && matKhau == "123456")
            {
                string thongBao = "Đăng nhập thành công!";
                if (chkGhiNho.Checked)
                {
                    thongBao += "\n(Đã ghi nhớ thông tin đăng nhập)";
                }
                MessageBox.Show(thongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

        }
    }
}