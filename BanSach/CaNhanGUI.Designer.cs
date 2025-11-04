namespace GUI
{
    partial class CaNhanGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaNhanGUI));
            picAvt = new PictureBox();
            txtMa = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtTen = new TextBox();
            txtDiaChi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbbGioiTinh = new ComboBox();
            btnChooseImage = new Button();
            btnSave = new Button();
            txtTenDangNhap = new TextBox();
            txtMK = new TextBox();
            label7 = new Label();
            lblMK = new Label();
            btnDMK = new Button();
            txtMKM = new TextBox();
            lblMKM = new Label();
            button1 = new Button();
            btnBack = new Button();
            txtXNMKM = new TextBox();
            lblXNMKM = new Label();
            btnCapNhatInfo = new Button();
            lblRole = new Label();
            ((System.ComponentModel.ISupportInitialize)picAvt).BeginInit();
            SuspendLayout();
            // 
            // picAvt
            // 
            picAvt.BackgroundImage = (Image)resources.GetObject("picAvt.BackgroundImage");
            picAvt.BackgroundImageLayout = ImageLayout.Stretch;
            picAvt.Location = new Point(44, 61);
            picAvt.Name = "picAvt";
            picAvt.Size = new Size(192, 260);
            picAvt.TabIndex = 0;
            picAvt.TabStop = false;
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMa.Location = new Point(414, 86);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(225, 31);
            txtMa.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(414, 207);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(225, 31);
            txtSDT.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(811, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 31);
            txtEmail.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(414, 147);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(225, 31);
            txtTen.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(811, 150);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(247, 31);
            txtDiaChi.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(273, 89);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 7;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(273, 147);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 8;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(272, 210);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 9;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(677, 92);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(677, 154);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 11;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(676, 213);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 12;
            label6.Text = "Giới tính";
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbbGioiTinh.Location = new Point(811, 210);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(247, 33);
            cbbGioiTinh.TabIndex = 13;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnChooseImage.Image = (Image)resources.GetObject("btnChooseImage.Image");
            btnChooseImage.Location = new Point(44, 344);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(192, 46);
            btnChooseImage.TabIndex = 14;
            btnChooseImage.Text = "Chon ảnh";
            btnChooseImage.TextAlign = ContentAlignment.MiddleRight;
            btnChooseImage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(919, 603);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 48);
            btnSave.TabIndex = 15;
            btnSave.Text = "Lưu";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(414, 266);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(225, 31);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMK.Location = new Point(811, 271);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(247, 31);
            txtMK.TabIndex = 6;
            txtMK.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(273, 266);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 8;
            label7.Text = "Tên đăng nhập";
            // 
            // lblMK
            // 
            lblMK.AutoSize = true;
            lblMK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMK.Location = new Point(677, 275);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(86, 25);
            lblMK.TabIndex = 11;
            lblMK.Text = "Mật khẩu";
            // 
            // btnDMK
            // 
            btnDMK.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDMK.Image = (Image)resources.GetObject("btnDMK.Image");
            btnDMK.Location = new Point(726, 603);
            btnDMK.Name = "btnDMK";
            btnDMK.Size = new Size(159, 48);
            btnDMK.TabIndex = 15;
            btnDMK.Text = "Đổi mật khẩu";
            btnDMK.TextAlign = ContentAlignment.MiddleRight;
            btnDMK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDMK.UseVisualStyleBackColor = true;
            btnDMK.Click += btnDMK_Click;
            // 
            // txtMKM
            // 
            txtMKM.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMKM.Location = new Point(811, 327);
            txtMKM.Name = "txtMKM";
            txtMKM.Size = new Size(247, 31);
            txtMKM.TabIndex = 6;
            txtMKM.UseSystemPasswordChar = true;
            // 
            // lblMKM
            // 
            lblMKM.AutoSize = true;
            lblMKM.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMKM.Location = new Point(676, 329);
            lblMKM.Name = "lblMKM";
            lblMKM.Size = new Size(122, 25);
            lblMKM.TabIndex = 11;
            lblMKM.Text = "Mật khẩu mới";
            // 
            // button1
            // 
            button1.Location = new Point(464, 341);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(44, 603);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(142, 48);
            btnBack.TabIndex = 17;
            btnBack.Text = "Trở lại";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtXNMKM
            // 
            txtXNMKM.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtXNMKM.Location = new Point(811, 379);
            txtXNMKM.Name = "txtXNMKM";
            txtXNMKM.Size = new Size(247, 31);
            txtXNMKM.TabIndex = 6;
            txtXNMKM.UseSystemPasswordChar = true;
            // 
            // lblXNMKM
            // 
            lblXNMKM.AutoSize = true;
            lblXNMKM.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblXNMKM.Location = new Point(677, 381);
            lblXNMKM.Name = "lblXNMKM";
            lblXNMKM.Size = new Size(89, 25);
            lblXNMKM.TabIndex = 11;
            lblXNMKM.Text = "Xác nhận ";
            // 
            // btnCapNhatInfo
            // 
            btnCapNhatInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCapNhatInfo.Image = (Image)resources.GetObject("btnCapNhatInfo.Image");
            btnCapNhatInfo.Location = new Point(497, 603);
            btnCapNhatInfo.Name = "btnCapNhatInfo";
            btnCapNhatInfo.Size = new Size(202, 48);
            btnCapNhatInfo.TabIndex = 18;
            btnCapNhatInfo.Text = "Cập nhật thông tin";
            btnCapNhatInfo.TextAlign = ContentAlignment.MiddleRight;
            btnCapNhatInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCapNhatInfo.UseVisualStyleBackColor = true;
            btnCapNhatInfo.Click += btnCapNhatInfo_Click;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.BackColor = SystemColors.GradientInactiveCaption;
            lblRole.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            lblRole.Location = new Point(1089, 9);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(0, 31);
            lblRole.TabIndex = 19;
            lblRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CaNhanGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1101, 691);
            Controls.Add(lblRole);
            Controls.Add(btnCapNhatInfo);
            Controls.Add(btnBack);
            Controls.Add(button1);
            Controls.Add(btnDMK);
            Controls.Add(btnSave);
            Controls.Add(btnChooseImage);
            Controls.Add(cbbGioiTinh);
            Controls.Add(label6);
            Controls.Add(lblMKM);
            Controls.Add(lblXNMKM);
            Controls.Add(lblMK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMKM);
            Controls.Add(txtXNMKM);
            Controls.Add(txtMK);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtTen);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtMa);
            Controls.Add(picAvt);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaNhanGUI";
            Text = "CaNhanGUI";
            Load += CaNhanGUI_Load;
            ((System.ComponentModel.ISupportInitialize)picAvt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAvt;
        private TextBox txtMa;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtTen;
        private TextBox txtDiaChi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbbGioiTinh;
        private Button btnChooseImage;
        private Button btnSave;
        private TextBox txtTenDangNhap;
        private TextBox txtMK;
        private Label label7;
        private Label lblMK;
        private Button btnDMK;
        private TextBox txtMKM;
        private Label lblMKM;
        private Button button1;
        private Button btnBack;
        private TextBox txtXNMKM;
        private Label lblXNMKM;
        private Button btnCapNhatInfo;
        private Label lblRole;
    }
}