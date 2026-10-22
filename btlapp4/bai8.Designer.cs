namespace btlapp4
{
    partial class bai8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCanNang = new TextBox();
            txtChieuCao = new TextBox();
            lblKetQua = new Label();
            lblPhanLoai = new Label();
            btnTinhBMI = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtCanNang
            // 
            txtCanNang.Location = new Point(479, 41);
            txtCanNang.Name = "txtCanNang";
            txtCanNang.Size = new Size(125, 27);
            txtCanNang.TabIndex = 2;
            // 
            // txtChieuCao
            // 
            txtChieuCao.Location = new Point(479, 86);
            txtChieuCao.Name = "txtChieuCao";
            txtChieuCao.Size = new Size(125, 27);
            txtChieuCao.TabIndex = 3;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(510, 132);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(81, 20);
            lblKetQua.TabIndex = 4;
            lblKetQua.Text = "Chỉ Số BMI";
            // 
            // lblPhanLoai
            // 
            lblPhanLoai.AutoSize = true;
            lblPhanLoai.Location = new Point(510, 172);
            lblPhanLoai.Name = "lblPhanLoai";
            lblPhanLoai.Size = new Size(73, 20);
            lblPhanLoai.TabIndex = 5;
            lblPhanLoai.Text = "Phân Loại";
            // 
            // btnTinhBMI
            // 
            btnTinhBMI.Location = new Point(479, 206);
            btnTinhBMI.Name = "btnTinhBMI";
            btnTinhBMI.Size = new Size(94, 29);
            btnTinhBMI.TabIndex = 6;
            btnTinhBMI.Text = "Tính BMI";
            btnTinhBMI.UseVisualStyleBackColor = true;
            btnTinhBMI.Click += btnTinhBMI_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(479, 257);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // bai8
            // 
            ClientSize = new Size(711, 388);
            Controls.Add(btnThoat);
            Controls.Add(btnTinhBMI);
            Controls.Add(lblPhanLoai);
            Controls.Add(lblKetQua);
            Controls.Add(txtChieuCao);
            Controls.Add(txtCanNang);
            Name = "bai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtCanNang;
        private TextBox txtChieuCao;
        private Label lblKetQua;
        private Label lblPhanLoai;
        private Button btnTinhBMI;
        private Button btnThoat;
    }
}