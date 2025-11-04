using DAL.Helper;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonNhapDAL
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public bool TaoHoaDonNhap(string tenNCC, string soDienThoai, string email, string diaChi, int maNguoiDung, DateTime ngayLap, decimal tongTien,
        List<ChiTietHoaDonNhap> chiTietList)
        {
            try
            {
                string error = "";

                // Tạo DataTable cho danh sách chi tiết hóa đơn
                DataTable dtChiTiet = new DataTable();
                dtChiTiet.Columns.Add("MaSach", typeof(int));
                dtChiTiet.Columns.Add("SoLuong", typeof(int));
                dtChiTiet.Columns.Add("GiaNhap", typeof(decimal));

                foreach (var item in chiTietList)
                {
                    dtChiTiet.Rows.Add(item.MaSach, item.SoLuong, item.GiaNhap);
                }

                // Gọi stored procedure
                var kq = _dbHelper.ExcSPWithTransaction(out error,"sp_ThemHoaDonNhap",
                    "@TenNhaCungCap", tenNCC,
                    "@SoDienThoai", soDienThoai,
                    "@Email", email,
                    "@DiaChi", diaChi,
                    "@MaNguoiDung", maNguoiDung,
                    "@NgayLap", ngayLap,
                    "@TongTien", tongTien,
                    "@DanhSachChiTiet", dtChiTiet // Truyền DataTable vào stored procedure
                );

                // Kiểm tra lỗi
                if (!string.IsNullOrEmpty(error))
                {
                    throw new Exception("Lỗi từ stored procedure: " + error);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong phương thức ThemHoaDon: " + ex.Message);
            }
        }
    }
}
