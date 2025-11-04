namespace GUI
{
    partial class SachGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SachGUI));
            dgSach = new DataGridView();
            picAnhBia = new PictureBox();
            txtMaSach = new TextBox();
            txtGiaNhap = new TextBox();
            txtMoTa = new TextBox();
            numSoLuong = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnChooseImage = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTImKiem = new Button();
            txtTimKiem = new TextBox();
            datePickNamXatBan = new DateTimePicker();
            txtTenSach = new TextBox();
            label6 = new Label();
            cbTheLoai = new ComboBox();
            cbTacGia = new ComboBox();
            cbNXB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnhBia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // dgSach
            // 
            dgSach.BackgroundColor = Color.MistyRose;
            dgSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSach.Location = new Point(12, 302);
            dgSach.Name = "dgSach";
            dgSach.RowHeadersWidth = 51;
            dgSach.RowTemplate.Height = 29;
            dgSach.Size = new Size(1077, 377);
            dgSach.TabIndex = 0;
            dgSach.CellClick += dgSach_CellClick;
            // 
            // picAnhBia
            // 
            picAnhBia.Image = (Image)resources.GetObject("picAnhBia.Image");
            picAnhBia.Location = new Point(12, 12);
            picAnhBia.Name = "picAnhBia";
            picAnhBia.Size = new Size(152, 216);
            picAnhBia.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhBia.TabIndex = 1;
            picAnhBia.TabStop = false;
            picAnhBia.Click += picAnhBia_Click;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(290, 15);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(195, 27);
            txtMaSach.TabIndex = 2;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(290, 152);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(195, 27);
            txtGiaNhap.TabIndex = 3;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(290, 197);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(195, 27);
            txtMoTa.TabIndex = 6;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(290, 106);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(195, 27);
            numSoLuong.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 18);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 11;
            label1.Text = "Mã sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 64);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 12;
            label2.Text = "Năm xuất bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 108);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 13;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 197);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 14;
            label4.Text = "Mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 154);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 15;
            label5.Text = "GIá nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(495, 111);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 17;
            label7.Text = "Tác giả";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(495, 67);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 18;
            label8.Text = "Thể loại";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(495, 155);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 19;
            label9.Text = "Nhà xuất bản";
            // 
            // btnChooseImage
            // 
            btnChooseImage.Image = Properties.Resources.image_icon;
            btnChooseImage.ImageAlign = ContentAlignment.MiddleLeft;
            btnChooseImage.Location = new Point(12, 234);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(152, 45);
            btnChooseImage.TabIndex = 20;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.add_icon;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(683, 230);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(125, 46);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.edit_icon;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(814, 230);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 46);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete_icon;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(945, 230);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 46);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTImKiem
            // 
            btnTImKiem.Image = Properties.Resources.search_icon;
            btnTImKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTImKiem.Location = new Point(945, 51);
            btnTImKiem.Name = "btnTImKiem";
            btnTImKiem.Size = new Size(125, 45);
            btnTImKiem.TabIndex = 24;
            btnTImKiem.Text = "Tìm kiếm";
            btnTImKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTImKiem.UseVisualStyleBackColor = true;
            btnTImKiem.Click += btnTImKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(834, 14);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập từ khóa...";
            txtTimKiem.Size = new Size(236, 31);
            txtTimKiem.TabIndex = 25;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged_1;
            // 
            // datePickNamXatBan
            // 
            datePickNamXatBan.Format = DateTimePickerFormat.Short;
            datePickNamXatBan.Location = new Point(292, 62);
            datePickNamXatBan.Name = "datePickNamXatBan";
            datePickNamXatBan.Size = new Size(193, 27);
            datePickNamXatBan.TabIndex = 26;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(602, 18);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(205, 27);
            txtTenSach.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(495, 21);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 18;
            label6.Text = "Tên sách";
            // 
            // cbTheLoai
            // 
            cbTheLoai.FormattingEnabled = true;
            cbTheLoai.Location = new Point(602, 61);
            cbTheLoai.Name = "cbTheLoai";
            cbTheLoai.Size = new Size(205, 28);
            cbTheLoai.TabIndex = 27;
            // 
            // cbTacGia
            // 
            cbTacGia.FormattingEnabled = true;
            cbTacGia.Location = new Point(602, 107);
            cbTacGia.Name = "cbTacGia";
            cbTacGia.Size = new Size(205, 28);
            cbTacGia.TabIndex = 28;
            // 
            // cbNXB
            // 
            cbNXB.FormattingEnabled = true;
            cbNXB.Location = new Point(602, 151);
            cbNXB.Name = "cbNXB";
            cbNXB.Size = new Size(205, 28);
            cbNXB.TabIndex = 29;
            // 
            // SachGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1101, 691);
            Controls.Add(cbNXB);
            Controls.Add(cbTacGia);
            Controls.Add(cbTheLoai);
            Controls.Add(datePickNamXatBan);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTImKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnChooseImage);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numSoLuong);
            Controls.Add(txtTenSach);
            Controls.Add(txtMoTa);
            Controls.Add(txtGiaNhap);
            Controls.Add(txtMaSach);
            Controls.Add(picAnhBia);
            Controls.Add(dgSach);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SachGUI";
            Text = "SachGUI";
            Load += SachGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnhBia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgSach;
        private PictureBox picAnhBia;
        private TextBox txtMaSach;
        private TextBox txtGiaNhap;
        private TextBox txtMoTa;
        private NumericUpDown numSoLuong;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnChooseImage;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTImKiem;
        private TextBox txtTimKiem;
        private DateTimePicker datePickNamXatBan;
        private TextBox txtTenSach;
        private Label label6;
        private ComboBox cbTheLoai;
        private ComboBox cbTacGia;
        private ComboBox cbNXB;
    }
}