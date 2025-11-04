namespace GUI
{
    partial class HoaDonNhapGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonNhapGUI));
            label7 = new Label();
            txtDonGia = new TextBox();
            btnTaoHoaDonNhap = new Button();
            pickerNgayTao = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTongTien = new TextBox();
            txtDiaChi = new TextBox();
            btnThemCTHDNhap = new Button();
            dgChiTietHoaDonNhap = new DataGridView();
            numericSoLuong = new NumericUpDown();
            txtMaSach = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            label1 = new Label();
            label8 = new Label();
            panelChiTietHoaDon = new Panel();
            panelHoaDon = new Panel();
            dgHoaDonNhap = new DataGridView();
            cbbNCC = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgChiTietHoaDonNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSoLuong).BeginInit();
            panelChiTietHoaDon.SuspendLayout();
            panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgHoaDonNhap).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 44);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 1;
            label7.Text = "Mã sách";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(215, 112);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(279, 27);
            txtDonGia.TabIndex = 3;
            // 
            // btnTaoHoaDonNhap
            // 
            btnTaoHoaDonNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaoHoaDonNhap.Image = (Image)resources.GetObject("btnTaoHoaDonNhap.Image");
            btnTaoHoaDonNhap.Location = new Point(279, 265);
            btnTaoHoaDonNhap.Name = "btnTaoHoaDonNhap";
            btnTaoHoaDonNhap.Size = new Size(191, 48);
            btnTaoHoaDonNhap.TabIndex = 14;
            btnTaoHoaDonNhap.Text = "Tạo hóa đơn nhập";
            btnTaoHoaDonNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaoHoaDonNhap.UseVisualStyleBackColor = true;
            btnTaoHoaDonNhap.Click += btnTaoHoaDonNhap_Click;
            // 
            // pickerNgayTao
            // 
            pickerNgayTao.Format = DateTimePickerFormat.Custom;
            pickerNgayTao.Location = new Point(191, 182);
            pickerNgayTao.Name = "pickerNgayTao";
            pickerNgayTao.Size = new Size(279, 27);
            pickerNgayTao.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 81);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 12;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 116);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 154);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 10;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 186);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 9;
            label3.Text = "Ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 220);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 8;
            label2.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(191, 218);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(279, 27);
            txtTongTien.TabIndex = 6;
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(191, 148);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(279, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // btnThemCTHDNhap
            // 
            btnThemCTHDNhap.Location = new Point(400, 150);
            btnThemCTHDNhap.Name = "btnThemCTHDNhap";
            btnThemCTHDNhap.Size = new Size(94, 29);
            btnThemCTHDNhap.TabIndex = 15;
            btnThemCTHDNhap.Text = "Thêm";
            btnThemCTHDNhap.UseVisualStyleBackColor = true;
            btnThemCTHDNhap.Click += btnThemCTHDNhap_Click;
            // 
            // dgChiTietHoaDonNhap
            // 
            dgChiTietHoaDonNhap.BackgroundColor = Color.MistyRose;
            dgChiTietHoaDonNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgChiTietHoaDonNhap.Location = new Point(14, 182);
            dgChiTietHoaDonNhap.Name = "dgChiTietHoaDonNhap";
            dgChiTietHoaDonNhap.RowHeadersWidth = 51;
            dgChiTietHoaDonNhap.RowTemplate.Height = 29;
            dgChiTietHoaDonNhap.Size = new Size(506, 135);
            dgChiTietHoaDonNhap.TabIndex = 14;
            // 
            // numericSoLuong
            // 
            numericSoLuong.Location = new Point(215, 77);
            numericSoLuong.Name = "numericSoLuong";
            numericSoLuong.Size = new Size(279, 27);
            numericSoLuong.TabIndex = 13;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(215, 41);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(279, 27);
            txtMaSach.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 80);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 12;
            label9.Text = "Số lượng";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(191, 78);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(279, 27);
            txtSDT.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 48);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhà cung cấp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 117);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 11;
            label8.Text = "Đơn giá";
            // 
            // panelChiTietHoaDon
            // 
            panelChiTietHoaDon.BackColor = Color.SkyBlue;
            panelChiTietHoaDon.Controls.Add(btnThemCTHDNhap);
            panelChiTietHoaDon.Controls.Add(dgChiTietHoaDonNhap);
            panelChiTietHoaDon.Controls.Add(numericSoLuong);
            panelChiTietHoaDon.Controls.Add(txtMaSach);
            panelChiTietHoaDon.Controls.Add(label9);
            panelChiTietHoaDon.Controls.Add(label7);
            panelChiTietHoaDon.Controls.Add(label8);
            panelChiTietHoaDon.Controls.Add(txtDonGia);
            panelChiTietHoaDon.Location = new Point(558, 12);
            panelChiTietHoaDon.Name = "panelChiTietHoaDon";
            panelChiTietHoaDon.Size = new Size(533, 331);
            panelChiTietHoaDon.TabIndex = 5;
            panelChiTietHoaDon.Paint += panelChiTietHoaDon_Paint;
            // 
            // panelHoaDon
            // 
            panelHoaDon.BackColor = Color.SkyBlue;
            panelHoaDon.Controls.Add(cbbNCC);
            panelHoaDon.Controls.Add(btnTaoHoaDonNhap);
            panelHoaDon.Controls.Add(pickerNgayTao);
            panelHoaDon.Controls.Add(label6);
            panelHoaDon.Controls.Add(label5);
            panelHoaDon.Controls.Add(label4);
            panelHoaDon.Controls.Add(label3);
            panelHoaDon.Controls.Add(label2);
            panelHoaDon.Controls.Add(txtTongTien);
            panelHoaDon.Controls.Add(txtDiaChi);
            panelHoaDon.Controls.Add(txtEmail);
            panelHoaDon.Controls.Add(txtSDT);
            panelHoaDon.Controls.Add(label1);
            panelHoaDon.Location = new Point(10, 12);
            panelHoaDon.Name = "panelHoaDon";
            panelHoaDon.Size = new Size(509, 331);
            panelHoaDon.TabIndex = 4;
            // 
            // dgHoaDonNhap
            // 
            dgHoaDonNhap.BackgroundColor = Color.MistyRose;
            dgHoaDonNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHoaDonNhap.Location = new Point(10, 363);
            dgHoaDonNhap.Name = "dgHoaDonNhap";
            dgHoaDonNhap.RowHeadersWidth = 51;
            dgHoaDonNhap.RowTemplate.Height = 29;
            dgHoaDonNhap.Size = new Size(1082, 316);
            dgHoaDonNhap.TabIndex = 3;
            // 
            // cbbNCC
            // 
            cbbNCC.FormattingEnabled = true;
            cbbNCC.Location = new Point(191, 44);
            cbbNCC.Name = "cbbNCC";
            cbbNCC.Size = new Size(279, 28);
            cbbNCC.TabIndex = 15;
            // 
            // HoaDonNhapGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1101, 691);
            Controls.Add(panelChiTietHoaDon);
            Controls.Add(panelHoaDon);
            Controls.Add(dgHoaDonNhap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HoaDonNhapGUI";
            Text = "HoaDonNhapGUI";
            ((System.ComponentModel.ISupportInitialize)dgChiTietHoaDonNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSoLuong).EndInit();
            panelChiTietHoaDon.ResumeLayout(false);
            panelChiTietHoaDon.PerformLayout();
            panelHoaDon.ResumeLayout(false);
            panelHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgHoaDonNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private TextBox txtDonGia;
        private Button btnTaoHoaDonNhap;
        private DateTimePicker pickerNgayTao;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTongTien;
        private TextBox txtDiaChi;
        private Button btnThemCTHDNhap;
        private DataGridView dgChiTietHoaDonNhap;
        private NumericUpDown numericSoLuong;
        private TextBox txtMaSach;
        private Label label9;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private Label label1;
        private Label label8;
        private Panel panelChiTietHoaDon;
        private Panel panelHoaDon;
        private DataGridView dgHoaDonNhap;
        private ComboBox cbbNCC;
    }
}