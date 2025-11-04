namespace GUI
{
    partial class KhachHangGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangGUI));
            txtSDT = new TextBox();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            txtMaKH = new TextBox();
            label4 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTenKH = new TextBox();
            txtEmail = new TextBox();
            dgKhachHang = new DataGridView();
            label5 = new Label();
            txtDiaChi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgKhachHang).BeginInit();
            SuspendLayout();
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(217, 125);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 27);
            txtSDT.TabIndex = 43;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(760, 42);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập từ khóa...";
            txtTimKiem.Size = new Size(272, 30);
            txtTimKiem.TabIndex = 42;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(909, 89);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(123, 45);
            btnTimKiem.TabIndex = 41;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtMaKH
            // 
            txtMaKH.BackColor = Color.White;
            txtMaKH.Location = new Point(217, 39);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(250, 27);
            txtMaKH.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 42);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 39;
            label4.Text = "Mã khách hàng";
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(764, 195);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 45);
            btnSua.TabIndex = 38;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(908, 195);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 45);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.Location = new Point(615, 195);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 45);
            btnThem.TabIndex = 36;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 127);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 35;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 170);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 34;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 85);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 33;
            label1.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(217, 83);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(250, 27);
            txtTenKH.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(217, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 31;
            // 
            // dgKhachHang
            // 
            dgKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgKhachHang.BackgroundColor = Color.MistyRose;
            dgKhachHang.BorderStyle = BorderStyle.Fixed3D;
            dgKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKhachHang.Location = new Point(12, 279);
            dgKhachHang.Name = "dgKhachHang";
            dgKhachHang.RowHeadersWidth = 51;
            dgKhachHang.RowTemplate.Height = 29;
            dgKhachHang.Size = new Size(1077, 400);
            dgKhachHang.TabIndex = 30;
            dgKhachHang.CellClick += dgKhachHang_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 211);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 44;
            label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(217, 213);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(250, 27);
            txtDiaChi.TabIndex = 45;
            // 
            // KhachHangGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1101, 691);
            Controls.Add(txtDiaChi);
            Controls.Add(label5);
            Controls.Add(txtSDT);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtMaKH);
            Controls.Add(label4);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenKH);
            Controls.Add(txtEmail);
            Controls.Add(dgKhachHang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KhachHangGUI";
            Text = "KhachHangGUI";
            Load += KhachHangGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSDT;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private TextBox txtMaKH;
        private Label label4;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTenKH;
        private TextBox txtEmail;
        private DataGridView dgKhachHang;
        private Label label5;
        private TextBox txtDiaChi;
    }
}