using System;
using System.Windows.Forms;

namespace btlapp4
{
    public partial class bai9 : Form
    {
        public bai9()
        {
            InitializeComponent();
        }

        // Sự kiện khi Form tải lên: Thêm danh sách Lớp vào ComboBox
        // Thêm học viên vào ListBox
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Thêm vào ListBox
        }
        // Xóa 1 phần tử đang chọn trong ListBox
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng chọn một dòng trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
            
      

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
