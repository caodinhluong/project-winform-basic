using BLL;
using DTO;
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
    public partial class CaNhanGUI : Form
    {
        bool _isDmk = false;
        bool _isUpdate = false;
        string _tenFileAnh = "";


        private NguoiDungBLL _bll = new NguoiDungBLL();
        public CaNhanGUI()
        {
            InitializeComponent();
        }
        private void CaNhanGUI_Load(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            txtMKM.Visible = false;
            lblMKM.Visible = false;
            txtXNMKM.Visible = false;
            lblXNMKM.Visible = false;
            txtMK.Visible = false;
            lblMK.Visible = false;
            txtMK.Text = "";
            txtMKM.Text = "";
            txtXNMKM.Text = "";
            btnSave.Enabled = false;
            btnChooseImage.Enabled = false;
            txtMK.Text = "";
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            cbbGioiTinh.Enabled = false;
            txtTenDangNhap.Enabled = false;
            txtSDT.Enabled = false;
            _isDmk = false;
            if (Session.Role == "Admin")
            {
                lblRole.Text = "Admin";
            }
            else
            {
                lblRole.Text = "Nhân viên";

            }
            try
            {
                int maNguoiDung = Session.MaNguoiDung;

                NguoiDung nguoiDung = _bll.GetByID(maNguoiDung);

                if (nguoiDung != null)
                {
                    txtMa.Text = Session.MaNguoiDung.ToString();
                    txtTen.Text = nguoiDung.HoTen;
                    txtSDT.Text = nguoiDung.SoDienThoai;
                    txtEmail.Text = nguoiDung.Email;
                    txtDiaChi.Text = nguoiDung.DiaChi;
                    txtTenDangNhap.Text = nguoiDung.TenDangNhap;
                    txtMK.Text = nguoiDung.MatKhau;
                    _tenFileAnh = nguoiDung.AnhDaiDien;
                    cbbGioiTinh.SelectedItem = nguoiDung.GioiTinh;

                    // Load ảnh đại diện vào PictureBox
                    if (!string.IsNullOrEmpty(nguoiDung.AnhDaiDien))
                    {
                        // Thư mục chứa ảnh
                        string folderPath = @"D:\Đồ án 1\lam thue\BanSach\Images"; // Đường dẫn thư mục cố định

                        // Kết hợp đường dẫn thư mục với tên file ảnh từ CSDL
                        string imagePath = Path.Combine(folderPath, nguoiDung.AnhDaiDien);

                        if (File.Exists(imagePath))
                        {
                            picAvt.Image = Image.FromFile(imagePath);
                            picAvt.SizeMode = PictureBoxSizeMode.StretchImage; // Điều chỉnh kích thước ảnh
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy file ảnh đại diện tại: " + imagePath);
                            picAvt.Image = null; // Xóa ảnh nếu không tìm thấy
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin người dùng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }


        private void btnDMK_Click(object sender, EventArgs e)
        {
            _isDmk = true;

            txtMKM.Visible = true;
            lblMKM.Visible = true;
            txtXNMKM.Visible = true;
            lblXNMKM.Visible = true;
            txtMK.Visible = true;
            lblMK.Visible = true;
            btnBack.Enabled = true;
            btnDMK.Enabled = false;
            btnCapNhatInfo.Enabled = false;
            btnSave.Enabled = true;

          

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtMKM.Visible = false;
            lblMKM.Visible = false;
            txtXNMKM.Visible = false;
            lblXNMKM.Visible = false;
            txtMK.Visible = false;
            lblMK.Visible = false;
            btnDMK.Enabled = true;
            btnCapNhatInfo.Enabled = true;
            btnBack.Enabled = false;
            _isDmk = false;

            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            cbbGioiTinh.Enabled = true;
            txtTenDangNhap.Enabled = true;
            txtSDT.Enabled = true;
            CaNhanGUI_Load(sender, e);
        }

        private void btnCapNhatInfo_Click(object sender, EventArgs e)
        {
            _isUpdate = true;
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            cbbGioiTinh.Enabled = true;
            txtSDT.Enabled = true;
            btnBack.Enabled = true;
            btnSave.Enabled = true;
            btnDMK.Enabled = false;
            btnChooseImage.Enabled = true;
            btnCapNhatInfo.Enabled = false;

            
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Nếu đang trạng thái đổi mật khẩu
            if (_isDmk)
            {
                // Kiểm tra các trường có rỗng không
                if (string.IsNullOrWhiteSpace(txtMK.Text)) // mk cũ
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu cũ!");
                    txtMK.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMKM.Text)) // mk mới
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới!");
                    txtMKM.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtXNMKM.Text)) // xác nhận mk mới
                {
                    MessageBox.Show("Vui lòng nhập xác nhận mật khẩu mới!");
                    txtXNMKM.Focus();
                    return;
                }
                // Kiểm tra mật khẩu cũ có đúng không
                NguoiDung nguoiDung = _bll.GetByID(Session.MaNguoiDung);
                string matKhauHienTai = nguoiDung.MatKhau;
                if (matKhauHienTai != txtMK.Text.Trim())
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!");
                    txtMK.Focus();
                    return;
                }
                // Kiểm tra mật khẩu mới và xác nhận có khớp không
                if (txtMKM.Text.Trim() != txtXNMKM.Text.Trim())
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận không khớp!");
                    txtXNMKM.Focus();
                    return;
                }
                try
                {
                    _bll.DoiMatKhau(nguoiDung.TenDangNhap, txtMKM.Text.Trim());
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    _isDmk = false;
                    btnBack_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message);
                }
            }
            if (_isUpdate)
            {
                try
                {
                    // Tạo đối tượng NguoiDung từ dữ liệu trên form
                    NguoiDung nguoiDung = new NguoiDung
                    {
                        MaNguoiDung = int.Parse(txtMa.Text.Trim()),
                        HoTen = txtTen.Text.Trim(),
                        SoDienThoai = txtSDT.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        GioiTinh = cbbGioiTinh.Text,
                        AnhDaiDien = _tenFileAnh
                    };
                    // Kiểm tra dữ liệu đầu vào
                    if (string.IsNullOrWhiteSpace(nguoiDung.HoTen))
                    {
                        MessageBox.Show("Vui lòng nhập họ tên!");
                        txtTen.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(nguoiDung.SoDienThoai))
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại!");
                        txtSDT.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(nguoiDung.Email))
                    {
                        MessageBox.Show("Vui lòng nhập email!");
                        txtEmail.Focus();
                        return;
                    }

                    if (!IsValidEmail(nguoiDung.Email))
                    {
                        MessageBox.Show("Email không đúng định dạng!");
                        txtEmail.Focus();
                        return;
                    }

                    bool result = _bll.CapNhatThongTinCaNhan(nguoiDung);

                    if (result)
                    {
                        MessageBox.Show("Cập nhật thông tin cá nhân thành công!");
                        _isUpdate = false;
                        btnBack_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message);
                }
                btnCapNhatInfo.Enabled = true;
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {

            // Tạo OpenFileDialog để chọn ảnh
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Cài đặt các thuộc tính cho dialog
                ofd.Title = "Chọn ảnh";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả file (*.*)|*.*";
                ofd.Multiselect = false; // Chỉ cho phép chọn 1 file

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lấy đường dẫn file gốc
                        string fileGoc = ofd.FileName;

                        // Lấy tên file không đường dẫn
                        _tenFileAnh = Path.GetFileName(fileGoc);

                        // Thư mục chứa ảnh
                        string folderPath = @"D:\Đồ án 1\lam thue\BanSach\Images";

                        // Đường dẫn đích đầy đủ
                        string imagePath = Path.Combine(folderPath, _tenFileAnh);

                        // Hiển thị ảnh lên PictureBox
                        picAvt.Image = Image.FromFile(imagePath);
                        picAvt.SizeMode = PictureBoxSizeMode.StretchImage;
                        MessageBox.Show("Đã chọn ảnh: " + _tenFileAnh);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xử lý ảnh: " + ex.Message);
                    }
                }
            }
        }

    }
}
