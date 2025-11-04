namespace GUI
{
    partial class TheLoaiGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheLoaiGUI));
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            label4 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label1 = new Label();
            dgTheLoai = new DataGridView();
            txtMaTheLoai = new TextBox();
            txtTenTheLoai = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgTheLoai).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(738, 46);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập từ khóa...";
            txtTimKiem.Size = new Size(272, 30);
            txtTimKiem.TabIndex = 28;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(887, 93);
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
            label4.Location = new Point(81, 50);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 25;
            label4.Text = "Mã thể loại";
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(233, 204);
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
            btnXoa.Location = new Point(382, 204);
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
            btnThem.Location = new Point(81, 204);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 45);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 93);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 18;
            label1.Text = "Tên thể loại";
            // 
            // dgTheLoai
            // 
            dgTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTheLoai.BackgroundColor = Color.MistyRose;
            dgTheLoai.BorderStyle = BorderStyle.Fixed3D;
            dgTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTheLoai.Location = new Point(12, 272);
            dgTheLoai.Name = "dgTheLoai";
            dgTheLoai.RowHeadersWidth = 51;
            dgTheLoai.RowTemplate.Height = 29;
            dgTheLoai.Size = new Size(1085, 407);
            dgTheLoai.TabIndex = 15;
            dgTheLoai.CellClick += dgTheLoai_CellClick;
            // 
            // txtMaTheLoai
            // 
            txtMaTheLoai.Location = new Point(220, 47);
            txtMaTheLoai.Name = "txtMaTheLoai";
            txtMaTheLoai.Size = new Size(239, 27);
            txtMaTheLoai.TabIndex = 29;
            // 
            // txtTenTheLoai
            // 
            txtTenTheLoai.Location = new Point(220, 90);
            txtTenTheLoai.Name = "txtTenTheLoai";
            txtTenTheLoai.Size = new Size(239, 27);
            txtTenTheLoai.TabIndex = 30;
            // 
            // TheLoaiGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1109, 691);
            Controls.Add(txtTenTheLoai);
            Controls.Add(txtMaTheLoai);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(label4);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Controls.Add(dgTheLoai);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TheLoaiGUI";
            Text = "TheLoaiGUI";
            Load += TheLoaiGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgTheLoai).EndInit();
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
        private TextBox txtTenTG;
        private TextBox txtQuocTich;
        private DataGridView dgTheLoai;
        private TextBox txtMaTheLoai;
        private TextBox txtTenTheLoai;
    }
}