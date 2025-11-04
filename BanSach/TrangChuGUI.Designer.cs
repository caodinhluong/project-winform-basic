namespace BanSach
{
    partial class TrangChuGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuGUI));
            picLogo = new PictureBox();
            panelNavBar = new Panel();
            btnOpenFormCaNhan = new Button();
            btnDangXuat = new Button();
            btnOpenFormHoaDonNhap = new Button();
            btnOpenFormNguoiDung = new Button();
            btnOpenFormHoaDon = new Button();
            btnOpenFormNhaXuatBan = new Button();
            btnOpenFormNhaCungCap = new Button();
            btnOpenFormKhachHang = new Button();
            btnOpenFormTheLoai = new Button();
            btnOpenFormTacGia = new Button();
            btnOpenFormSach = new Button();
            panelForm = new Panel();
            lblHeader = new Label();
            panelHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelNavBar.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.BackColor = SystemColors.ActiveCaption;
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(-6, 1);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(234, 120);
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panelNavBar
            // 
            panelNavBar.Anchor = AnchorStyles.None;
            panelNavBar.AutoSize = true;
            panelNavBar.BackColor = Color.White;
            panelNavBar.Controls.Add(btnOpenFormCaNhan);
            panelNavBar.Controls.Add(btnDangXuat);
            panelNavBar.Controls.Add(btnOpenFormHoaDonNhap);
            panelNavBar.Controls.Add(btnOpenFormNguoiDung);
            panelNavBar.Controls.Add(btnOpenFormHoaDon);
            panelNavBar.Controls.Add(btnOpenFormNhaXuatBan);
            panelNavBar.Controls.Add(btnOpenFormNhaCungCap);
            panelNavBar.Controls.Add(btnOpenFormKhachHang);
            panelNavBar.Controls.Add(btnOpenFormTheLoai);
            panelNavBar.Controls.Add(btnOpenFormTacGia);
            panelNavBar.Controls.Add(btnOpenFormSach);
            panelNavBar.Location = new Point(-2, 124);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(233, 691);
            panelNavBar.TabIndex = 2;
            // 
            // btnOpenFormCaNhan
            // 
            btnOpenFormCaNhan.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFormCaNhan.Image = (Image)resources.GetObject("btnOpenFormCaNhan.Image");
            btnOpenFormCaNhan.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFormCaNhan.Location = new Point(3, 539);
            btnOpenFormCaNhan.Name = "btnOpenFormCaNhan";
            btnOpenFormCaNhan.Size = new Size(227, 54);
            btnOpenFormCaNhan.TabIndex = 11;
            btnOpenFormCaNhan.Text = "Cá nhân";
            btnOpenFormCaNhan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFormCaNhan.UseVisualStyleBackColor = true;
            btnOpenFormCaNhan.Click += btnOpenFormCaNhan_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.Red;
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(3, 599);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(227, 54);
            btnDangXuat.TabIndex = 10;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnOpenFormHoaDonNhap
            // 
            btnOpenFormHoaDonNhap.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFormHoaDonNhap.Image = (Image)resources.GetObject("btnOpenFormHoaDonNhap.Image");
            btnOpenFormHoaDonNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFormHoaDonNhap.Location = new Point(3, 419);
            btnOpenFormHoaDonNhap.Name = "btnOpenFormHoaDonNhap";
            btnOpenFormHoaDonNhap.Size = new Size(227, 54);
            btnOpenFormHoaDonNhap.TabIndex = 9;
            btnOpenFormHoaDonNhap.Text = "Hóa đơn nhập";
            btnOpenFormHoaDonNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFormHoaDonNhap.UseVisualStyleBackColor = true;
            btnOpenFormHoaDonNhap.Click += btnOpenFormHoaDonNhap_Click;
            // 
            // btnOpenFormNguoiDung
            // 
            btnOpenFormNguoiDung.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFormNguoiDung.Image = (Image)resources.GetObject("btnOpenFormNguoiDung.Image");
            btnOpenFormNguoiDung.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFormNguoiDung.Location = new Point(3, 479);
            btnOpenFormNguoiDung.Name = "btnOpenFormNguoiDung";
            btnOpenFormNguoiDung.Size = new Size(227, 54);
            btnOpenFormNguoiDung.TabIndex = 7;
            btnOpenFormNguoiDung.Text = "Người dùng";
            btnOpenFormNguoiDung.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFormNguoiDung.UseVisualStyleBackColor = true;
            btnOpenFormNguoiDung.Click += btnOpenFormNguoiDung_Click;
            // 
            // btnOpenFormHoaDon
            // 
            btnOpenFormHoaDon.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFormHoaDon.Image = (Image)resources.GetObject("btnOpenFormHoaDon.Image");
            btnOpenFormHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFormHoaDon.Location = new Point(3, 359);
            btnOpenFormHoaDon.Name = "btnOpenFormHoaDon";
            btnOpenFormHoaDon.Size = new Size(227, 54);
            btnOpenFormHoaDon.TabIndex = 6;
            btnOpenFormHoaDon.Text = "Hóa đơn";
            btnOpenFormHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFormHoaDon.UseVisualStyleBackColor = true;
            btnOpenFormHoaDon.Click += btnOpenFormHoaDon_Click;
            // 
            // btnOpenFormNhaXuatBan
            // 
            btnOpenFormNhaXuatBan.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFormNhaXuatBan.Image = (Image)resources.GetObject("btnOpenFormNhaXuatBan.Image");
            btnOpenFormNhaXuatBan.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFormNhaXuatBan.Location = new Point(3, 179);
            btnOpenFormNhaXuatBan.Name = "btnOpenFormNhaXuatBan";
            btnOpenFormNhaXuatBan.Size = new Size(227, 54);
            btnOpenFormNhaXuatBan.TabIndex = 5;
            btnOpenFormNhaXuatBan.Text = "Nhà xuất bản";
            btnOpenFormNhaXuatBan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFormNhaXuatBan.UseVisualStyleBackColor = true;
            btnOpenFormNhaXuatBan.Click += btnOpenFormNhaXuatBan_Click;
            // 
            // btnOpenFormNhaCungCap
            // 
            btnOpenFormNhaCungCap.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFormNhaCungCap.Image = (Image)resources.GetObject("btnOpenFormNhaCungCap.Image");
            btnOpenFormNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFormNhaCungCap.Location = new Point(3, 239);
            btnOpenFormNhaCungCap.Name = "btnOpenFormNhaCungCap";
            btnOpenFormNhaCungCap.Size = new Size(227, 54);
            btnOpenFormNhaCungCap.TabIndex = 4;
            btnOpenFormNhaCungCap.Text = "Nhà cung cấp";
            btnOpenFormNhaCungCap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFormNhaCungCap.UseVisualStyleBackColor = true;
            btnOpenFormNhaCungCap.Click += btnOpenFormNhaCungCap_Click;
            // 
            // btnOpenFormKhachHang
            // 
            btnOpenFormKhachHang.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFormKhachHang.Image = (Image)resources.GetObject("btnOpenFormKhachHang.Image");
            btnOpenFormKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFormKhachHang.Location = new Point(3, 299);
            btnOpenFormKhachHang.Name = "btnOpenFormKhachHang";
            btnOpenFormKhachHang.Size = new Size(227, 54);
            btnOpenFormKhachHang.TabIndex = 3;
            btnOpenFormKhachHang.Text = "Khách hàng";
            btnOpenFormKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFormKhachHang.UseVisualStyleBackColor = true;
            btnOpenFormKhachHang.Click += btnOpenFormKhachHang_Click;
            // 
            // btnOpenFormTheLoai
            // 
            btnOpenFormTheLoai.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFormTheLoai.Image = (Image)resources.GetObject("btnOpenFormTheLoai.Image");
            btnOpenFormTheLoai.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFormTheLoai.Location = new Point(3, 119);
            btnOpenFormTheLoai.Name = "btnOpenFormTheLoai";
            btnOpenFormTheLoai.Size = new Size(227, 54);
            btnOpenFormTheLoai.TabIndex = 2;
            btnOpenFormTheLoai.Text = "Thể loại";
            btnOpenFormTheLoai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFormTheLoai.UseVisualStyleBackColor = true;
            btnOpenFormTheLoai.Click += btnOpenFormTheLoai_Click;
            // 
            // btnOpenFormTacGia
            // 
            btnOpenFormTacGia.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFormTacGia.Image = (Image)resources.GetObject("btnOpenFormTacGia.Image");
            btnOpenFormTacGia.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFormTacGia.Location = new Point(3, 63);
            btnOpenFormTacGia.Name = "btnOpenFormTacGia";
            btnOpenFormTacGia.Size = new Size(227, 50);
            btnOpenFormTacGia.TabIndex = 1;
            btnOpenFormTacGia.Text = "Tác Giả";
            btnOpenFormTacGia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFormTacGia.UseVisualStyleBackColor = true;
            btnOpenFormTacGia.Click += btnOpenFormTacGia_Click;
            // 
            // btnOpenFormSach
            // 
            btnOpenFormSach.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFormSach.Image = (Image)resources.GetObject("btnOpenFormSach.Image");
            btnOpenFormSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFormSach.Location = new Point(3, 3);
            btnOpenFormSach.Name = "btnOpenFormSach";
            btnOpenFormSach.Size = new Size(227, 54);
            btnOpenFormSach.TabIndex = 0;
            btnOpenFormSach.Text = "Sách";
            btnOpenFormSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFormSach.UseVisualStyleBackColor = true;
            btnOpenFormSach.Click += btnOpenFormSach_Click;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.None;
            panelForm.AutoSize = true;
            panelForm.BackColor = SystemColors.GradientInactiveCaption;
            panelForm.BackgroundImage = (Image)resources.GetObject("panelForm.BackgroundImage");
            panelForm.BackgroundImageLayout = ImageLayout.Stretch;
            panelForm.Location = new Point(229, 124);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1109, 691);
            panelForm.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.White;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblHeader.Location = new Point(376, 33);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(349, 54);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Hi tớ là Lương nè";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.None;
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Location = new Point(230, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1108, 120);
            panelHeader.TabIndex = 3;
            // 
            // TrangChuGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 814);
            Controls.Add(panelHeader);
            Controls.Add(panelForm);
            Controls.Add(panelNavBar);
            Controls.Add(picLogo);
            MaximizeBox = false;
            Name = "TrangChuGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChuGUI";
            Load += TrangChuGUI_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelNavBar.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Panel panelNavBar;
        private Panel panelForm;
        private Button btnOpenFormTacGia;
        private Button btnOpenFormSach;
        private Button btnOpenFormNhaXuatBan;
        private Button btnOpenFormNhaCungCap;
        private Button btnOpenFormKhachHang;
        private Button btnOpenFormTheLoai;
        private Label lblHeader;
        private Button btnOpenFormHoaDonNhap;
        private Button btnOpenFormNguoiDung;
        private Button btnOpenFormHoaDon;
        private Button btnDangXuat;
        private Panel panelHeader;
        private Button btnOpenFormCaNhan;
    }
}