using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SachGUI : Form
    {
        private DataTable _dtSach;
        private SachBLL _bll = new SachBLL();
        private string _pathImg = "D:\\Đồ án 1\\lam thue\\BanSach\\Images\\";
        private string _fileNameImg = "";
        public SachGUI()
        {
            InitializeComponent();
            datePickNamXatBan.Format = DateTimePickerFormat.Custom;
            datePickNamXatBan.CustomFormat = "yyyy";
        }

        private void SachGUI_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        void LoadData()
        {
            DataTable dtTheLoai = _bll.GetTheLoai();
            cbTheLoai.DataSource = dtTheLoai;
            cbTheLoai.DisplayMember = "TenTheLoai";
            cbTheLoai.ValueMember = "MaTheLoai";
            cbTheLoai.SelectedIndex = 0;
            DataTable dtTacGia = _bll.GetTacGia();
            cbTacGia.DataSource = dtTacGia;
            cbTacGia.DisplayMember = "TenTacGia";
            cbTacGia.ValueMember = "MaTacGia";
            cbTacGia.SelectedIndex = 0;
            DataTable dtNXB = _bll.GetNhaXuatBan();
            cbNXB.DataSource = dtNXB;
            cbNXB.DisplayMember = "TenNhaXuatBan";
            cbNXB.ValueMember = "MaNhaXuatBan";
            cbNXB.SelectedIndex = 0;

            try
            {
                _dtSach = _bll.GetAll();

                // Thêm cột HinhAnh vào DataTable ở vị trí đầu tiên
                if (!_dtSach.Columns.Contains("HinhAnh"))
                {
                    DataColumn imgColumn = new DataColumn("HinhAnh", typeof(Image));
                    _dtSach.Columns.Add(imgColumn);
                    imgColumn.SetOrdinal(0);
                }

                // Load ảnh từ AnhBia vào cột HinhAnh trong DataTable
                foreach (DataRow row in _dtSach.Rows)
                {
                    if (row["AnhBia"] != null && row["AnhBia"] != DBNull.Value)
                    {
                        string imagePath = row["AnhBia"].ToString();
                        string fullPath = Path.Combine(_pathImg, imagePath);
                        if (File.Exists(fullPath))
                        {
                            using (Image originalImg = Image.FromFile(fullPath))
                            {
                                Bitmap img = new Bitmap(originalImg);
                                row["HinhAnh"] = img;
                            }
                        }
                        else
                        {
                            row["HinhAnh"] = null; // Hoặc ảnh mặc định
                        }
                    }
                }

                // Tắt AutoGenerateColumns để tự quản lý cột
                dgSach.AutoGenerateColumns = false;

                // Xóa các cột cũ trong DataGridView (nếu có)
                dgSach.Columns.Clear();

                // Thêm cột HinhAnh vào DataGridView
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "HinhAnh";
                imgCol.HeaderText = "Hình Ảnh";
                imgCol.DataPropertyName = "HinhAnh";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgSach.Columns.Add(imgCol);
                imgCol.DisplayIndex = 0; // Vị trí đầu tiên

                // Thêm các cột khác
                if (_dtSach.Columns.Contains("MaSach"))
                {
                    DataGridViewTextBoxColumn tenSachCol = new DataGridViewTextBoxColumn();
                    tenSachCol.Name = "MaSach";
                    tenSachCol.HeaderText = "Mã Sách";
                    tenSachCol.DataPropertyName = "MaSach";
                    dgSach.Columns.Add(tenSachCol);
                }
                if (_dtSach.Columns.Contains("TenSach"))
                {
                    DataGridViewTextBoxColumn tenSachCol = new DataGridViewTextBoxColumn();
                    tenSachCol.Name = "TenSach";
                    tenSachCol.HeaderText = "Tên Sách";
                    tenSachCol.DataPropertyName = "TenSach";
                    dgSach.Columns.Add(tenSachCol);
                }

                if (_dtSach.Columns.Contains("MaTheLoai"))
                {
                    DataGridViewTextBoxColumn maTheLoaiCol = new DataGridViewTextBoxColumn();
                    maTheLoaiCol.Name = "MaTheLoai";
                    maTheLoaiCol.HeaderText = "Mã Thể Loại";
                    maTheLoaiCol.DataPropertyName = "MaTheLoai";
                    dgSach.Columns.Add(maTheLoaiCol);
                }

                if (_dtSach.Columns.Contains("MaTacGia"))
                {
                    DataGridViewTextBoxColumn maTacGiaCol = new DataGridViewTextBoxColumn();
                    maTacGiaCol.Name = "MaTacGia";
                    maTacGiaCol.HeaderText = "Mã Tác Giả";
                    maTacGiaCol.DataPropertyName = "MaTacGia";
                    dgSach.Columns.Add(maTacGiaCol);
                }

                if (_dtSach.Columns.Contains("MaNhaXuatBan"))
                {
                    DataGridViewTextBoxColumn maNXBCol = new DataGridViewTextBoxColumn();
                    maNXBCol.Name = "MaNhaXuatBan";
                    maNXBCol.HeaderText = "Mã Nhà Xuất Bản";
                    maNXBCol.DataPropertyName = "MaNhaXuatBan";
                    dgSach.Columns.Add(maNXBCol);
                }

                if (_dtSach.Columns.Contains("NamXuatBan"))
                {
                    DataGridViewTextBoxColumn namXBCol = new DataGridViewTextBoxColumn();
                    namXBCol.Name = "NamXuatBan";
                    namXBCol.HeaderText = "Năm Xuất Bản";
                    namXBCol.DataPropertyName = "NamXuatBan";
                    dgSach.Columns.Add(namXBCol);
                }

                if (_dtSach.Columns.Contains("SoLuong"))
                {
                    DataGridViewTextBoxColumn soLuongCol = new DataGridViewTextBoxColumn();
                    soLuongCol.Name = "SoLuong";
                    soLuongCol.HeaderText = "Số Lượng";
                    soLuongCol.DataPropertyName = "SoLuong";
                    dgSach.Columns.Add(soLuongCol);
                }

                if (_dtSach.Columns.Contains("GiaBan"))
                {
                    DataGridViewTextBoxColumn giaBanCol = new DataGridViewTextBoxColumn();
                    giaBanCol.Name = "GiaBan";
                    giaBanCol.HeaderText = "Giá Bán";
                    giaBanCol.DataPropertyName = "GiaBan";
                    dgSach.Columns.Add(giaBanCol);
                }

                if (_dtSach.Columns.Contains("MoTa"))
                {
                    DataGridViewTextBoxColumn moTaCol = new DataGridViewTextBoxColumn();
                    moTaCol.Name = "MoTa";
                    moTaCol.HeaderText = "Mô Tả";
                    moTaCol.DataPropertyName = "MoTa";
                    dgSach.Columns.Add(moTaCol);
                }

                // Thêm cột AnhBia và ẩn nó
                if (_dtSach.Columns.Contains("AnhBia"))
                {
                    DataGridViewTextBoxColumn anhBiaCol = new DataGridViewTextBoxColumn();
                    anhBiaCol.Name = "AnhBia";
                    anhBiaCol.HeaderText = "Ảnh Bìa";
                    anhBiaCol.DataPropertyName = "AnhBia";
                    anhBiaCol.Visible = false;
                    dgSach.Columns.Add(anhBiaCol);
                }

                // Gán DataSource sau khi định nghĩa cột
                dgSach.DataSource = _dtSach;
                dgSach.RowTemplate.Height = 50;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại mà người dùng đã chọn
                DataGridViewRow row = dgSach.Rows[e.RowIndex];

                // Đổ dữ liệu lên các control tương ứng
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();

                // Gán giá trị mã vào ComboBox và hiển thị tên tương ứng
                cbTheLoai.SelectedValue = Convert.ToInt32(row.Cells["MaTheLoai"].Value); // Gán mã thể loại
                cbTacGia.SelectedValue = Convert.ToInt32(row.Cells["MaTacGia"].Value);   // Gán mã tác giả
                cbNXB.SelectedValue = Convert.ToInt32(row.Cells["MaNhaXuatBan"].Value);  // Gán mã nhà xuất bản

                // Xử lý NamXuatBan (INT) sang DateTime cho DateTimePicker
                int namXuatBan = Convert.ToInt32(row.Cells["NamXuatBan"].Value);
                datePickNamXatBan.Value = new DateTime(namXuatBan, 1, 1); // 

                numSoLuong.Value = Convert.ToInt32(row.Cells["SoLuong"].Value);
                txtGiaNhap.Text = row.Cells["GiaBan"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();

                // Xử lý ảnh bìa
                if (row.Cells["AnhBia"].Value != DBNull.Value && row.Cells["AnhBia"].Value != null)
                {
                    string imagePath = row.Cells["AnhBia"].Value.ToString();
                    string fullPath = _pathImg + imagePath;
                    if (File.Exists(fullPath)) // Kiểm tra file có tồn tại không
                    {
                        picAnhBia.Image = Image.FromFile(fullPath);
                    }
                    else
                    {
                        picAnhBia.Image = null; // Không tìm thấy file
                    }
                }
                else
                {
                    picAnhBia.Image = null; // Nếu không có đường dẫn
                }
            }
        }

        private void picAnhBia_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng Sach từ dữ liệu nhập trên form
                Sach sachMoi = new Sach
                {
                    TenSach = txtTenSach.Text.Trim(),
                    MaTheLoai = Convert.ToInt32(cbTheLoai.SelectedValue),
                    MaTacGia = Convert.ToInt32(cbTacGia.SelectedValue),
                    MaNhaXuatBan = Convert.ToInt32(cbNXB.SelectedValue),
                    NamXuatBan = Convert.ToInt32(datePickNamXatBan.Value.ToString("yyyy")), // Lấy năm từ DateTimePicker
                    SoLuong = Convert.ToInt32(numSoLuong.Value), // Lấy giá trị từ NumericUpDown
                    GiaBan = Convert.ToDecimal(txtGiaNhap.Text.Trim()),
                    MoTa = txtMoTa.Text.Trim(),
                    AnhBia = _fileNameImg
                };

                bool result = _bll.Create(sachMoi);

                if (result)
                {
                    MessageBox.Show("Thêm sách thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelper.ResetForm(this);
                    SachGUI_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sách: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaSach.Text))
                {
                    MessageBox.Show("Vui lòng chọn sách cần sửa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng Sach từ dữ liệu trên form
                Sach sachSua = new Sach
                {
                    MaSach = Convert.ToInt32(txtMaSach.Text.Trim()),
                    TenSach = txtTenSach.Text.Trim(),
                    MaTheLoai = Convert.ToInt32(cbTheLoai.SelectedValue),
                    MaTacGia = Convert.ToInt32(cbTacGia.SelectedValue),
                    MaNhaXuatBan = Convert.ToInt32(cbNXB.SelectedValue),
                    NamXuatBan = Convert.ToInt32(datePickNamXatBan.Value.ToString("yyyy")),
                    SoLuong = Convert.ToInt32(numSoLuong.Value),
                    GiaBan = Convert.ToDecimal(txtGiaNhap.Text.Trim()),
                    MoTa = txtMoTa.Text.Trim(),
                    AnhBia = _fileNameImg
                };

                bool result = _bll.Update(sachSua);

                if (result)
                {
                    MessageBox.Show("Sửa sách thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelper.ResetForm(this);
                    SachGUI_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa sách: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn sách để xóa chưa
                if (string.IsNullOrEmpty(txtMaSach.Text))
                {
                    MessageBox.Show("Vui lòng chọn sách cần xóa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa sách này?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int maSach = Convert.ToInt32(txtMaSach.Text.Trim());
                    bool result = _bll.Delete(maSach);

                    if (result)
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHelper.ResetForm(this);
                        SachGUI_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sách: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";
                openFileDialog.Title = "Chọn ảnh bìa sách";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);
                    _fileNameImg = fileName;
                    if (picAnhBia != null)
                    {
                        picAnhBia.Image = Image.FromFile(filePath);
                        picAnhBia.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn ảnh: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTImKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu ô tìm kiếm rỗng, xóa bộ lọc
                _dtSach.DefaultView.RowFilter = string.Empty;
                return;
            }

            try
            {
                // Xây dựng bộ lọc (filter)
                // Tìm kiếm trên Tên sách, Mô tả, và cả Mã sách
                string filter = $"TenSach LIKE '%{keyword}%' OR " +
                                $"MoTa LIKE '%{keyword}%' OR " +
                                $"CONVERT(MaSach, 'System.String') LIKE '%{keyword}%'";

                _dtSach.DefaultView.RowFilter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                _dtSach.DefaultView.RowFilter = string.Empty;
            }
        }
    }
}
