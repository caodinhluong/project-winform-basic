namespace GUI
{
    partial class NhaXuatBanGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaXuatBanGUI));
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            txtMaNXB = new TextBox();
            label4 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTenNXB = new TextBox();
            txtSDT = new TextBox();
            dgNXB = new DataGridView();
            txtDiaChi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgNXB).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(760, 39);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập từ khóa...";
            txtTimKiem.Size = new Size(272, 30);
            txtTimKiem.TabIndex = 28;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(909, 86);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(123, 45);
            btnTimKiem.TabIndex = 27;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtMaNXB
            // 
            txtMaNXB.BackColor = Color.White;
            txtMaNXB.Location = new Point(217, 39);
            txtMaNXB.Name = "txtMaNXB";
            txtMaNXB.ReadOnly = true;
            txtMaNXB.Size = new Size(250, 27);
            txtMaNXB.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 42);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 25;
            label4.Text = "Mã nhà xuất bản";
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(202, 228);
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
            btnXoa.Location = new Point(346, 228);
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
            btnThem.Location = new Point(53, 228);
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
            label3.Location = new Point(53, 127);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 20;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 170);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 19;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 85);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 18;
            label1.Text = "Tên nhà xuất bản";
            // 
            // txtTenNXB
            // 
            txtTenNXB.Location = new Point(217, 83);
            txtTenNXB.Name = "txtTenNXB";
            txtTenNXB.Size = new Size(250, 27);
            txtTenNXB.TabIndex = 17;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(217, 169);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 27);
            txtSDT.TabIndex = 16;
            // 
            // dgNXB
            // 
            dgNXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNXB.BackgroundColor = Color.MistyRose;
            dgNXB.BorderStyle = BorderStyle.Fixed3D;
            dgNXB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNXB.Location = new Point(12, 297);
            dgNXB.Name = "dgNXB";
            dgNXB.RowHeadersWidth = 51;
            dgNXB.RowTemplate.Height = 29;
            dgNXB.Size = new Size(1077, 382);
            dgNXB.TabIndex = 15;
            dgNXB.CellClick += dgNXB_CellClick;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(217, 125);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(250, 27);
            txtDiaChi.TabIndex = 29;
            txtDiaChi.TextChanged += textBox1_TextChanged;
            // 
            // NhaXuatBanGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1101, 691);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtMaNXB);
            Controls.Add(label4);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenNXB);
            Controls.Add(txtSDT);
            Controls.Add(dgNXB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhaXuatBanGUI";
            Text = "NhaXuatBanGUI";
            Load += NhaXuatBanGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgNXB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private TextBox txtMaNXB;
        private Label label4;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTenNXB;
        private TextBox txtSDT;
        private DataGridView dgNXB;
        private TextBox txtDiaChi;
    }
}