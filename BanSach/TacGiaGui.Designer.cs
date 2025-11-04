namespace BanSach
{
    partial class TacGiaGui
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TacGiaGui));
            dgTacGia = new DataGridView();
            txtQuocTich = new TextBox();
            txtTenTG = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerNamSinhTG = new DateTimePicker();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            label4 = new Label();
            txtMaTacGia = new TextBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgTacGia).BeginInit();
            SuspendLayout();
            // 
            // dgTacGia
            // 
            dgTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTacGia.BackgroundColor = Color.MistyRose;
            dgTacGia.BorderStyle = BorderStyle.Fixed3D;
            dgTacGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTacGia.Location = new Point(12, 327);
            dgTacGia.Name = "dgTacGia";
            dgTacGia.RowHeadersWidth = 51;
            dgTacGia.RowTemplate.Height = 29;
            dgTacGia.Size = new Size(1077, 352);
            dgTacGia.TabIndex = 0;
            dgTacGia.CellClick += dgTacGia_CellClick;
            // 
            // txtQuocTich
            // 
            txtQuocTich.Location = new Point(195, 201);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.Size = new Size(250, 27);
            txtQuocTich.TabIndex = 1;
            // 
            // txtTenTG
            // 
            txtTenTG.Location = new Point(195, 115);
            txtTenTG.Name = "txtTenTG";
            txtTenTG.Size = new Size(250, 27);
            txtTenTG.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 118);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên tác giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 203);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Quốc tịch";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 160);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "Năm sinh";
            // 
            // dateTimePickerNamSinhTG
            // 
            dateTimePickerNamSinhTG.Format = DateTimePickerFormat.Custom;
            dateTimePickerNamSinhTG.Location = new Point(195, 160);
            dateTimePickerNamSinhTG.Name = "dateTimePickerNamSinhTG";
            dateTimePickerNamSinhTG.Size = new Size(250, 27);
            dateTimePickerNamSinhTG.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.Location = new Point(538, 68);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 45);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(538, 214);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 45);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(538, 141);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 45);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 75);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 11;
            label4.Text = "Mã tác giả";
            // 
            // txtMaTacGia
            // 
            txtMaTacGia.BackColor = Color.White;
            txtMaTacGia.Location = new Point(195, 71);
            txtMaTacGia.Name = "txtMaTacGia";
            txtMaTacGia.ReadOnly = true;
            txtMaTacGia.Size = new Size(250, 27);
            txtMaTacGia.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(916, 109);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(123, 45);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(767, 62);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập từ khóa...";
            txtTimKiem.Size = new Size(272, 30);
            txtTimKiem.TabIndex = 14;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // TacGiaGui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1101, 691);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtMaTacGia);
            Controls.Add(label4);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dateTimePickerNamSinhTG);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenTG);
            Controls.Add(txtQuocTich);
            Controls.Add(dgTacGia);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TacGiaGui";
            Text = "Form1";
            Load += TacGiaGui_Load;
            ((System.ComponentModel.ISupportInitialize)dgTacGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgTacGia;
        private TextBox txtQuocTich;
        private TextBox txtTenTG;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerNamSinhTG;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Label label4;
        private TextBox txtMaTacGia;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
    }
}
