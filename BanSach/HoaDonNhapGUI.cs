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
    public partial class HoaDonNhapGUI : Form
    {
        private HoaDonNhapBLL _bll = new HoaDonNhapBLL();
        public HoaDonNhapGUI()
        {
            InitializeComponent();
        }

        private void btnTaoHoaDonNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu khách hàng
                if (string.IsNullOrWhiteSpace(cbbNCC.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                // Kiểm tra danh sách chi tiết hóa đơn nhập
                if (dgChiTietHoaDonNhap.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm vào hóa đơn nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo danh sách chi tiết hóa đơn nhập
                List<ChiTietHoaDonNhap> chiTietList = new List<ChiTietHoaDonNhap>();
                decimal tongTien = 0;
                string danhSachSanPham = "";

                foreach (DataGridViewRow row in dgChiTietHoaDonNhap.Rows)
                {
                    if (row.Cells[0].Value != null) // Kiểm tra có dữ liệu không
                    {
                        int maSach = Convert.ToInt32(row.Cells[0].Value);
                        int soLuong = Convert.ToInt32(row.Cells[1].Value);
                        decimal giaNhap = Convert.ToDecimal(row.Cells[2].Value);
                        decimal thanhTien = soLuong * giaNhap;

                        // Thêm vào danh sách
                        chiTietList.Add(new ChiTietHoaDonNhap()
                        {
                            MaSach = maSach,
                            SoLuong = soLuong,
                            GiaNhap = giaNhap
                        });

                        // Tính tổng tiền
                        tongTien += thanhTien;

                        // Ghi thông tin sản phẩm vào chuỗi hiển thị
                        danhSachSanPham += $"- Mã sách: {maSach}, SL: {soLuong}, Giá nhập: {giaNhap}, Thành tiền: {thanhTien}\n";
                    }
                }
                txtTongTien.Text = tongTien.ToString();



                // Hiển thị dữ liệu đầu vào trước khi lưu
                string message = $"Xác nhận tạo hóa đơn với các thông tin:\n\n" +
                                 $"🟢 Khách hàng:\n" +
                                 $"Họ tên: {cbbNCC.Text}\n" +
                                 $"SĐT: {txtSDT.Text}\n" +
                                 $"Email: {txtEmail.Text}\n" +
                                 $"Địa chỉ: {txtDiaChi.Text}\n\n" +
                                 $"🛒 Danh sách sản phẩm:\n{danhSachSanPham}\n" +
                                 $"💰 Tổng tiền: {tongTien}\n\n" +
                                 $"Bạn có muốn tạo hóa đơn nhập không?";

                DialogResult result = MessageBox.Show(message, "Xác nhận hóa đơn nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Gọi phương thức tạo hóa đơn
                bool ketQua = _bll.TaoHoaDonNhap(
                cbbNCC.Text,
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
                    txtSDT.Clear();
                    txtEmail.Clear();
                    txtDiaChi.Clear();
                    dgChiTietHoaDonNhap.Rows.Clear();
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

        private void panelChiTietHoaDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemCTHDNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
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
            dgChiTietHoaDonNhap.Rows.Add(txtMaSach.Text, soLuong, donGia, soLuong * donGia);

            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgChiTietHoaDonNhap.Rows)
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
            txtMaSach.Clear();
            numericSoLuong.Value = 0;
            txtDonGia.Clear();
        }
    }
}
