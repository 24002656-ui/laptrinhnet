namespace btlapp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtKetQua = new TextBox();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnChia = new Button();
            btnLamMoi = new Button();
            btnNhan = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(34, 27);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(125, 27);
            txtKetQua.TabIndex = 2;
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(34, 79);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(125, 27);
            txtSo1.TabIndex = 3;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(34, 139);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(125, 27);
            txtSo2.TabIndex = 4;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(556, 12);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(94, 29);
            btnCong.TabIndex = 5;
            btnCong.Text = "Cộng";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(556, 56);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(94, 29);
            btnTru.TabIndex = 6;
            btnTru.Text = "Trừ";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(556, 153);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(94, 29);
            btnChia.TabIndex = 8;
            btnChia.Text = "CHIA";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(556, 265);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(596, 104);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(94, 29);
            btnNhan.TabIndex = 11;
            btnNhan.Text = "Nhân";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(600, 217);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnNhan);
            Controls.Add(btnLamMoi);
            Controls.Add(btnChia);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(txtKetQua);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtKetQua;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Button btnCong;
        private Button btnTru;
        private Button Nhân;
        private Button btnChia;
        private Button button5;
        private Button btnLamMoi;
        private Button btnNhan;
        private Button btnThoat;
    }
}
