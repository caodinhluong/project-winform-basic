namespace GUI
{
    partial class DangKyGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyGUI));
            label4 = new Label();
            linkDangky = new LinkLabel();
            btnDangky = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbRole = new ComboBox();
            txtMatKhau = new TextBox();
            label5 = new Label();
            txtXacNhanMatKhau = new TextBox();
            label6 = new Label();
            txtHoVaTen = new TextBox();
            txtTenDangNhap = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(316, 26);
            label4.Name = "label4";
            label4.Size = new Size(214, 55);
            label4.TabIndex = 21;
            label4.Text = "Đăng ký";
            // 
            // linkDangky
            // 
            linkDangky.AutoSize = true;
            linkDangky.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkDangky.Location = new Point(316, 653);
            linkDangky.Name = "linkDangky";
            linkDangky.Size = new Size(230, 18);
            linkDangky.TabIndex = 18;
            linkDangky.TabStop = true;
            linkDangky.Text = "Đã có tài khoản? Đăng nhập";
            linkDangky.LinkClicked += linkDangky_LinkClicked;
            // 
            // btnDangky
            // 
            btnDangky.BackColor = Color.MistyRose;
            btnDangky.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangky.Image = (Image)resources.GetObject("btnDangky.Image");
            btnDangky.Location = new Point(344, 582);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(186, 56);
            btnDangky.TabIndex = 17;
            btnDangky.Text = "Đăng ký";
            btnDangky.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangky.UseVisualStyleBackColor = false;
            btnDangky.Click += btnDangky_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(56, 517);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 16;
            label3.Text = "Phân quyền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 233);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 15;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 180);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 14;
            label1.Text = "Tên đăng nhập";
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.MistyRose;
            cbRole.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "NhanVien" });
            cbRole.Location = new Point(297, 514);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(500, 35);
            cbRole.TabIndex = 13;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.MistyRose;
            txtMatKhau.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(297, 229);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(500, 34);
            txtMatKhau.TabIndex = 12;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 287);
            label5.Name = "label5";
            label5.Size = new Size(235, 28);
            label5.TabIndex = 23;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.BackColor = Color.MistyRose;
            txtXacNhanMatKhau.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtXacNhanMatKhau.Location = new Point(297, 284);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(500, 34);
            txtXacNhanMatKhau.TabIndex = 22;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(56, 125);
            label6.Name = "label6";
            label6.Size = new Size(124, 28);
            label6.TabIndex = 25;
            label6.Text = "Họ và tên";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BackColor = Color.MistyRose;
            txtHoVaTen.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtHoVaTen.Location = new Point(297, 119);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(500, 34);
            txtHoVaTen.TabIndex = 24;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.MistyRose;
            txtTenDangNhap.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(297, 177);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(500, 34);
            txtTenDangNhap.TabIndex = 26;
            txtTenDangNhap.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(56, 349);
            label7.Name = "label7";
            label7.Size = new Size(163, 28);
            label7.TabIndex = 27;
            label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(56, 401);
            label8.Name = "label8";
            label8.Size = new Size(81, 28);
            label8.TabIndex = 28;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(56, 459);
            label9.Name = "label9";
            label9.Size = new Size(90, 28);
            label9.TabIndex = 29;
            label9.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.MistyRose;
            txtDiaChi.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(297, 453);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(500, 34);
            txtDiaChi.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.MistyRose;
            txtEmail.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(297, 401);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(500, 34);
            txtEmail.TabIndex = 31;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.MistyRose;
            txtSDT.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtSDT.Location = new Point(297, 343);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(500, 34);
            txtSDT.TabIndex = 32;
            // 
            // DangKyGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(844, 689);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label6);
            Controls.Add(txtHoVaTen);
            Controls.Add(label5);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(label4);
            Controls.Add(linkDangky);
            Controls.Add(btnDangky);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbRole);
            Controls.Add(txtMatKhau);
            Name = "DangKyGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangKyGUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private LinkLabel linkDangky;
        private Button btnDangky;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbRole;
        private TextBox txtMatKhau;
        private Label label5;
        private TextBox txtXacNhanMatKhau;
        private Label label6;
        private TextBox txtHoVaTen;
        private TextBox txtTenDangNhap;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSDT;
    }
}