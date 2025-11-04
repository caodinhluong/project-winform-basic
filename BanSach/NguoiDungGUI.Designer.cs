namespace GUI
{
    partial class NguoiDungGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguoiDungGUI));
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgNguoiDung = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgNguoiDung).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(11, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập từ khóa...";
            txtTimKiem.Size = new Size(272, 38);
            txtTimKiem.TabIndex = 42;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(304, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(123, 45);
            btnTimKiem.TabIndex = 41;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgNguoiDung
            // 
            dgNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNguoiDung.BackgroundColor = Color.MistyRose;
            dgNguoiDung.BorderStyle = BorderStyle.Fixed3D;
            dgNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNguoiDung.Location = new Point(11, 63);
            dgNguoiDung.Name = "dgNguoiDung";
            dgNguoiDung.RowHeadersWidth = 51;
            dgNguoiDung.RowTemplate.Height = 29;
            dgNguoiDung.Size = new Size(1077, 616);
            dgNguoiDung.TabIndex = 29;
            dgNguoiDung.CellFormatting += dgNguoiDung_CellFormatting;
            // 
            // NguoiDungGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1101, 691);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgNguoiDung);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NguoiDungGUI";
            Text = "NguoiDungGUI";
            Load += NguoiDungGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgNguoiDung).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgNguoiDung;
    }
}