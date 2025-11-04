using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HoaDonGUI : Form
    {
        private HoaDonBLL _bll = new HoaDonBLL();
        public HoaDonGUI()
        {
            InitializeComponent();
        }

        private void HoaDonGUI_Load(object sender, EventArgs e)
        {
            DataTable dtSach = _bll.GetSach();
            cbbSach.DataSource = dtSach;
            cbbSach.DisplayMember = "TenSach";
            cbbSach.ValueMember = "MaSach";
            cbbSach.SelectedIndex = 0;
            dgDSChiTietHoaDon.ColumnCount = 4; // Tạo 4 cột
            dgDSChiTietHoaDon.Columns[0].HeaderText = "Mã sách";
            dgDSChiTietHoaDon.Columns[1].HeaderText = "Số lượng";
            dgDSChiTietHoaDon.Columns[2].HeaderText = "Đơn giá";
            dgDSChiTietHoaDon.Columns[3].HeaderText = "Tổng";

            dgDSChiTietHoaDon.Columns[0].Name = "MaSach";
            dgDSChiTietHoaDon.Columns[1].Name = "SoLuong";
            dgDSChiTietHoaDon.Columns[2].Name = "DonGia";
            dgDSChiTietHoaDon.Columns[3].Name = "TongTien";

            dgDSChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // --- CODE MỚI (Cho Tab Danh Sách Hóa Đơn) ---
            LoadData_AllInvoices(); // Gọi hàm tải danh sách hóa đơn

            // Cấu hình cho grid xem chi tiết
            dgChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadData_AllInvoices()
        {
            try
            {
                dgHoaDon.DataSource = _bll.GetAllHoaDon();
                // Cấu hình tiêu đề cho DataGridView danh sách
                dgHoaDon.Columns["MaHoaDon"].HeaderText = "Mã HĐ";
                dgHoaDon.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
                dgHoaDon.Columns["TenNguoiLap"].HeaderText = "Người Lập";
                dgHoaDon.Columns["NgayLap"].HeaderText = "Ngày Lập";
                dgHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
                dgHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message);
            }
        }
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(cbbSach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(numericSoLuong.Value.ToString(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm vào DataGridView
            dgDSChiTietHoaDon.Rows.Add(cbbSach.SelectedValue, soLuong, donGia, soLuong * donGia);

            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgDSChiTietHoaDon.Rows)
            {
                if (row.Cells[0].Value != null) // Kiểm tra có dữ liệu không
                {
                    ChiTietHoaDon chiTiet = new ChiTietHoaDon()
                    {
                        MaSach = Convert.ToInt32(row.Cells[0].Value),
                        SoLuong = Convert.ToInt32(row.Cells[1].Value),
                        DonGia = Convert.ToDecimal(row.Cells[2].Value)
                    };

                    tongTien += chiTiet.SoLuong * chiTiet.DonGia;

                }
            }
            txtTongTien.Text = tongTien.ToString();

            // Xóa dữ liệu sau khi thêm
            numericSoLuong.Value = 0;
            txtDonGia.Clear();
        }



        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu khách hàng
                if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                // Kiểm tra danh sách chi tiết hóa đơn
                if (dgDSChiTietHoaDon.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm vào hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo danh sách chi tiết hóa đơn
                List<ChiTietHoaDon> chiTietList = new List<ChiTietHoaDon>();
                decimal tongTien = 0;
                string danhSachSanPham = "";

                foreach (DataGridViewRow row in dgDSChiTietHoaDon.Rows)
                {
                    if (row.Cells[0].Value != null) // Kiểm tra có dữ liệu không
                    {
                        int maSach = Convert.ToInt32(row.Cells[0].Value);
                        int soLuong = Convert.ToInt32(row.Cells[1].Value);
                        decimal donGia = Convert.ToDecimal(row.Cells[2].Value);
                        decimal thanhTien = soLuong * donGia;

                        // Thêm vào danh sách
                        chiTietList.Add(new ChiTietHoaDon()
                        {
                            MaSach = maSach,
                            SoLuong = soLuong,
                            DonGia = donGia
                        });

                        // Tính tổng tiền
                        tongTien += thanhTien;

                        // Ghi thông tin sản phẩm vào chuỗi hiển thị
                        danhSachSanPham += $"- Mã sách: {maSach}, SL: {soLuong}, Giá: {donGia}, Thành tiền: {thanhTien}\n";
                    }
                }
                txtTongTien.Text = tongTien.ToString();



                // Hiển thị dữ liệu đầu vào trước khi lưu
                string message = $"Xác nhận tạo hóa đơn với các thông tin:\n\n" +
                                 $"🟢 Khách hàng:\n" +
                                 $"Họ tên: {txtTenKH.Text}\n" +
                                 $"SĐT: {txtSDT.Text}\n" +
                                 $"Email: {txtEmail.Text}\n" +
                                 $"Địa chỉ: {txtDiaChi.Text}\n\n" +
                                 $"🛒 Danh sách sản phẩm:\n{danhSachSanPham}\n" +
                                 $"💰 Tổng tiền: {tongTien}\n\n" +
                                 $"Bạn có muốn tạo hóa đơn không?";

                DialogResult result = MessageBox.Show(message, "Xác nhận hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Gọi phương thức tạo hóa đơn
                bool ketQua = _bll.TaoHoaDon(
                txtTenKH.Text,
                txtSDT.Text,
                txtEmail.Text,
                txtDiaChi.Text,
                Session.MaNguoiDung,
                DateTime.Now,
                tongTien,
                chiTietList);

                if (ketQua)
                {
                    MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu sau khi tạo hóa đơn
                    txtTenKH.Clear();
                    txtSDT.Clear();
                    txtEmail.Clear();
                    txtDiaChi.Clear();
                    dgDSChiTietHoaDon.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Tạo hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo bấm vào một dòng hợp lệ
            {
                try
                {
                    // Lấy MaHoaDon từ dòng được chọn
                    DataGridViewRow row = dgHoaDon.Rows[e.RowIndex];
                    int maHoaDon = Convert.ToInt32(row.Cells["MaHoaDon"].Value);

                    // Gọi BLL để lấy chi tiết
                    dgChiTietHoaDon.DataSource = _bll.GetChiTietByMaHoaDon(maHoaDon);

                    // Cấu hình tiêu đề cho DataGridView chi tiết
                    dgChiTietHoaDon.Columns["MaSach"].HeaderText = "Mã Sách";
                    dgChiTietHoaDon.Columns["TenSach"].HeaderText = "Tên Sách";
                    dgChiTietHoaDon.Columns["SoLuong"].HeaderText = "Số Lượng";
                    dgChiTietHoaDon.Columns["DonGia"].HeaderText = "Đơn Giá";
                    dgChiTietHoaDon.Columns["ThanhTien"].HeaderText = "Thành Tiền";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xem chi tiết: " + ex.Message);
                }
            }
        }
    }
}
