using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NguoiDungGUI : Form
    {
        public NguoiDungGUI()
        {
            InitializeComponent();
        }
        // Tách hàm cấu hình DataGridView ra riêng
        private NguoiDungBLL _bll = new NguoiDungBLL();

        // Cập nhật đường dẫn này cho phù hợp
        private string _pathImg = "D:\\Đồ án 1\\lam thue\\BanSach\\Images\\";
        void LoadData()
        {
            try
            {
                // Tải toàn bộ danh sách
                DataTable dtNguoiDung = _bll.GetAll_View();
                ConfigureDataGridView(dtNguoiDung);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void ConfigureDataGridView(DataTable dataSource)
        {
            dgNguoiDung.AutoGenerateColumns = false;
            dgNguoiDung.Columns.Clear(); // Xóa cột cũ trước khi thêm

            // 1. Cột Hình Ảnh
            dgNguoiDung.Columns.Add(new DataGridViewImageColumn
            {
                Name = "HinhAnh",
                HeaderText = "Ảnh",
                Width = 60,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });

            // 2. Các cột văn bản
            dgNguoiDung.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "MaNguoiDung", HeaderText = "Mã ND", DataPropertyName = "MaNguoiDung", Width = 50 });
            dgNguoiDung.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "HoTen", HeaderText = "Họ Tên", DataPropertyName = "HoTen", Width = 150 });
            dgNguoiDung.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "TenDangNhap", HeaderText = "Tên Đăng Nhập", DataPropertyName = "TenDangNhap" });
            dgNguoiDung.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Role", HeaderText = "Quyền", DataPropertyName = "Role", Width = 70 });
            dgNguoiDung.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "SoDienThoai", HeaderText = "SĐT", DataPropertyName = "SoDienThoai" });
            dgNguoiDung.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "Email", HeaderText = "Email", DataPropertyName = "Email", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            // 3. Cột ẩn (chỉ dùng để lấy tên file ảnh)
            dgNguoiDung.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "AnhDaiDien", DataPropertyName = "AnhDaiDien", Visible = false });

            // 4. Gán DataSource
            dgNguoiDung.DataSource = dataSource;
            dgNguoiDung.RowTemplate.Height = 60;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text.Trim()))
            {
                LoadData();
            }
        }

        private void NguoiDungGUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgNguoiDung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgNguoiDung.Columns[e.ColumnIndex].Name == "HinhAnh" && e.RowIndex >= 0)
            {
                // Đã sửa lỗi null
                object cellValue = dgNguoiDung.Rows[e.RowIndex].Cells["AnhDaiDien"].Value;

                if (cellValue == null || cellValue == DBNull.Value)
                {
                    e.Value = null;
                    return;
                }

                string imagePath = cellValue.ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    string fullPath = Path.Combine(_pathImg, imagePath);
                    if (File.Exists(fullPath))
                    {
                        e.Value = new Bitmap(fullPath); // Dùng Bitmap để tránh lỗi file-in-use
                    }
                    else { e.Value = null; }
                }
                else { e.Value = null; }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu ô tìm kiếm trống, tải lại toàn bộ danh sách
                LoadData();
                return;
            }

            try
            {
                // Gọi BLL/DAL để tìm kiếm trên Server
                DataTable dtKetQua = _bll.Search_View(keyword);

                // Cập nhật DataGridView với kết quả tìm kiếm
                dgNguoiDung.DataSource = dtKetQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
