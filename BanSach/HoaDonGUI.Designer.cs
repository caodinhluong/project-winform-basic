namespace GUI
{
    partial class HoaDonGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonGUI));
            dgHoaDon = new DataGridView();
            panelHoaDon = new Panel();
            btnTaoHoaDon = new Button();
            pickerNgayTao = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTongTien = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            label1 = new Label();
            txtTenKH = new TextBox();
            panelChiTietHoaDon = new Panel();
            cbbSach = new ComboBox();
            btnThemCTHD = new Button();
            dgDSChiTietHoaDon = new DataGridView();
            numericSoLuong = new NumericUpDown();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDonGia = new TextBox();
            dgChiTietHoaDon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgHoaDon).BeginInit();
            panelHoaDon.SuspendLayout();
            panelChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSChiTietHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgChiTietHoaDon).BeginInit();
            SuspendLayout();
            // 
            // dgHoaDon
            // 
            dgHoaDon.BackgroundColor = Color.MistyRose;
            dgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHoaDon.Location = new Point(10, 363);
            dgHoaDon.Name = "dgHoaDon";
            dgHoaDon.RowHeadersWidth = 51;
            dgHoaDon.RowTemplate.Height = 29;
            dgHoaDon.Size = new Size(593, 316);
            dgHoaDon.TabIndex = 0;
            dgHoaDon.CellClick += dgHoaDon_CellClick;
            // 
            // panelHoaDon
            // 
            panelHoaDon.BackColor = Color.SkyBlue;
            panelHoaDon.Controls.Add(btnTaoHoaDon);
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
            panelHoaDon.Controls.Add(txtTenKH);
            panelHoaDon.Location = new Point(12, 12);
            panelHoaDon.Name = "panelHoaDon";
            panelHoaDon.Size = new Size(509, 331);
            panelHoaDon.TabIndex = 1;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaoHoaDon.Image = (Image)resources.GetObject("btnTaoHoaDon.Image");
            btnTaoHoaDon.Location = new Point(319, 272);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(151, 48);
            btnTaoHoaDon.TabIndex = 14;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // pickerNgayTao
            // 
            pickerNgayTao.Format = DateTimePickerFormat.Custom;
            pickerNgayTao.Location = new Point(191, 185);
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
            txtDiaChi.Location = new Point(191, 149);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(279, 27);
            txtDiaChi.TabIndex = 4;
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
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ tên khách hàng";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(191, 45);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(279, 27);
            txtTenKH.TabIndex = 0;
            // 
            // panelChiTietHoaDon
            // 
            panelChiTietHoaDon.BackColor = Color.SkyBlue;
            panelChiTietHoaDon.Controls.Add(cbbSach);
            panelChiTietHoaDon.Controls.Add(btnThemCTHD);
            panelChiTietHoaDon.Controls.Add(dgDSChiTietHoaDon);
            panelChiTietHoaDon.Controls.Add(numericSoLuong);
            panelChiTietHoaDon.Controls.Add(label9);
            panelChiTietHoaDon.Controls.Add(label7);
            panelChiTietHoaDon.Controls.Add(label8);
            panelChiTietHoaDon.Controls.Add(txtDonGia);
            panelChiTietHoaDon.Location = new Point(559, 12);
            panelChiTietHoaDon.Name = "panelChiTietHoaDon";
            panelChiTietHoaDon.Size = new Size(533, 331);
            panelChiTietHoaDon.TabIndex = 2;
            // 
            // cbbSach
            // 
            cbbSach.FormattingEnabled = true;
            cbbSach.Location = new Point(214, 37);
            cbbSach.Name = "cbbSach";
            cbbSach.Size = new Size(280, 28);
            cbbSach.TabIndex = 16;
            // 
            // btnThemCTHD
            // 
            btnThemCTHD.Location = new Point(400, 151);
            btnThemCTHD.Name = "btnThemCTHD";
            btnThemCTHD.Size = new Size(94, 29);
            btnThemCTHD.TabIndex = 15;
            btnThemCTHD.Text = "Thêm";
            btnThemCTHD.UseVisualStyleBackColor = true;
            btnThemCTHD.Click += btnThemCTHD_Click;
            // 
            // dgDSChiTietHoaDon
            // 
            dgDSChiTietHoaDon.BackgroundColor = Color.MistyRose;
            dgDSChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSChiTietHoaDon.Location = new Point(14, 183);
            dgDSChiTietHoaDon.Name = "dgDSChiTietHoaDon";
            dgDSChiTietHoaDon.RowHeadersWidth = 51;
            dgDSChiTietHoaDon.RowTemplate.Height = 29;
            dgDSChiTietHoaDon.Size = new Size(506, 135);
            dgDSChiTietHoaDon.TabIndex = 14;
            // 
            // numericSoLuong
            // 
            numericSoLuong.Location = new Point(215, 77);
            numericSoLuong.Name = "numericSoLuong";
            numericSoLuong.Size = new Size(279, 27);
            numericSoLuong.TabIndex = 13;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 44);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 1;
            label7.Text = "Sách";
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
            // txtDonGia
            // 
            txtDonGia.Location = new Point(215, 112);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(279, 27);
            txtDonGia.TabIndex = 3;
            // 
            // dgChiTietHoaDon
            // 
            dgChiTietHoaDon.BackgroundColor = Color.MistyRose;
            dgChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgChiTietHoaDon.Location = new Point(618, 363);
            dgChiTietHoaDon.Name = "dgChiTietHoaDon";
            dgChiTietHoaDon.RowHeadersWidth = 51;
            dgChiTietHoaDon.RowTemplate.Height = 29;
            dgChiTietHoaDon.Size = new Size(471, 316);
            dgChiTietHoaDon.TabIndex = 3;
            // 
            // HoaDonGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1101, 691);
            Controls.Add(dgChiTietHoaDon);
            Controls.Add(panelChiTietHoaDon);
            Controls.Add(panelHoaDon);
            Controls.Add(dgHoaDon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HoaDonGUI";
            Text = "HoaDonGUI";
            Load += HoaDonGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgHoaDon).EndInit();
            panelHoaDon.ResumeLayout(false);
            panelHoaDon.PerformLayout();
            panelChiTietHoaDon.ResumeLayout(false);
            panelChiTietHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSChiTietHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgChiTietHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgHoaDon;
        private Panel panelHoaDon;
        private Panel panelChiTietHoaDon;
        private Label label1;
        private TextBox txtTenKH;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTongTien;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private DateTimePicker pickerNgayTao;
        private Label label9;
        private Label label7;
        private Label label8;
        private TextBox txtDonGia;
        private DataGridView dgDSChiTietHoaDon;
        private NumericUpDown numericSoLuong;
        private Button btnTaoHoaDon;
        private Button btnThemCTHD;
        private ComboBox cbbSach;
        private DataGridView dgChiTietHoaDon;
    }
}