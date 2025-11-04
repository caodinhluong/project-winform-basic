namespace GUI
{
    partial class NhaCungCapGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCapGUI));
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            label4 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTenNCC = new TextBox();
            txtSDT = new TextBox();
            dgNCC = new DataGridView();
            label5 = new Label();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtMaNCC = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgNCC).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(754, 58);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập từ khóa...";
            txtTimKiem.Size = new Size(272, 30);
            txtTimKiem.TabIndex = 28;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(903, 105);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(123, 45);
            btnTimKiem.TabIndex = 27;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 61);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 25;
            label4.Text = "Mã nhà cung cấp";
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(544, 131);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 45);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(544, 204);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 45);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.Location = new Point(544, 58);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 45);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 141);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 20;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 186);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 19;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 102);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 18;
            label1.Text = "Tên nhà cung cấp";
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(209, 101);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(250, 27);
            txtTenNCC.TabIndex = 17;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(209, 186);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 27);
            txtSDT.TabIndex = 16;
            // 
            // dgNCC
            // 
            dgNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNCC.BackgroundColor = Color.MistyRose;
            dgNCC.BorderStyle = BorderStyle.Fixed3D;
            dgNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNCC.GridColor = Color.MistyRose;
            dgNCC.Location = new Point(13, 285);
            dgNCC.Name = "dgNCC";
            dgNCC.RowHeadersWidth = 51;
            dgNCC.RowTemplate.Height = 29;
            dgNCC.Size = new Size(1077, 393);
            dgNCC.TabIndex = 15;
            dgNCC.CellClick += dgNCC_CellClick;
            dgNCC.CellContentClick += dgNCC_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 226);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 29;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(209, 226);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 30;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(209, 143);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(250, 27);
            txtDiaChi.TabIndex = 31;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(209, 60);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(250, 27);
            txtMaNCC.TabIndex = 32;
            // 
            // NhaCungCapGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1101, 691);
            Controls.Add(txtMaNCC);
            Controls.Add(txtDiaChi);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(label4);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenNCC);
            Controls.Add(txtSDT);
            Controls.Add(dgNCC);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhaCungCapGUI";
            Text = "NhaCungCapGUI";
            Load += NhaCungCapGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgNCC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private TextBox txtMaTacGia;
        private Label label4;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DateTimePicker dateTimePickerNamSinhTG;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTenNCC;
        private TextBox txtSDT;
        private DataGridView dgNCC;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private TextBox txtMaNCC;
    }
}