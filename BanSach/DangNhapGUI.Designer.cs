namespace BanSach
{
    partial class DangNhapGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapGUI));
            txtMatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDangNhap = new Button();
            linkDangky = new LinkLabel();
            linkQuenMatKhau = new LinkLabel();
            picLogoLogin = new PictureBox();
            label4 = new Label();
            txtTenDangNhap = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).BeginInit();
            SuspendLayout();
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.MistyRose;
            txtMatKhau.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(667, 273);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(293, 34);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(469, 220);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(469, 276);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.MistyRose;
            btnDangNhap.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.Image = (Image)resources.GetObject("btnDangNhap.Image");
            btnDangNhap.Location = new Point(642, 353);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(180, 57);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // linkDangky
            // 
            linkDangky.AutoSize = true;
            linkDangky.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkDangky.Location = new Point(618, 430);
            linkDangky.Name = "linkDangky";
            linkDangky.Size = new Size(228, 18);
            linkDangky.TabIndex = 6;
            linkDangky.TabStop = true;
            linkDangky.Text = "Chưa có tài khoản? Đăng ký";
            linkDangky.LinkClicked += linkDangky_LinkClicked;
            // 
            // linkQuenMatKhau
            // 
            linkQuenMatKhau.AutoSize = true;
            linkQuenMatKhau.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkQuenMatKhau.Location = new Point(667, 463);
            linkQuenMatKhau.Name = "linkQuenMatKhau";
            linkQuenMatKhau.Size = new Size(137, 18);
            linkQuenMatKhau.TabIndex = 7;
            linkQuenMatKhau.TabStop = true;
            linkQuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // picLogoLogin
            // 
            picLogoLogin.Image = (Image)resources.GetObject("picLogoLogin.Image");
            picLogoLogin.Location = new Point(82, 140);
            picLogoLogin.Name = "picLogoLogin";
            picLogoLogin.Size = new Size(370, 370);
            picLogoLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogoLogin.TabIndex = 9;
            picLogoLogin.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(397, 48);
            label4.Name = "label4";
            label4.Size = new Size(274, 55);
            label4.TabIndex = 2;
            label4.Text = "Đăng nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.MistyRose;
            txtTenDangNhap.Font = new Font("Century", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(667, 217);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(293, 34);
            txtTenDangNhap.TabIndex = 0;
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            txtTenDangNhap.KeyDown += txtTenDangNhap_KeyDown;
            // 
            // DangNhapGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1025, 603);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label4);
            Controls.Add(picLogoLogin);
            Controls.Add(linkQuenMatKhau);
            Controls.Add(linkDangky);
            Controls.Add(btnDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMatKhau);
            Name = "DangNhapGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhapGUI";
            Load += DangNhapGUI_Load;
            ((System.ComponentModel.ISupportInitialize)picLogoLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMatKhau;
        private Label label1;
        private Label label2;
        private Button btnDangNhap;
        private LinkLabel linkDangky;
        private LinkLabel linkQuenMatKhau;
        private PictureBox picLogoLogin;
        private Label label4;
        private TextBox txtTenDangNhap;
    }
}