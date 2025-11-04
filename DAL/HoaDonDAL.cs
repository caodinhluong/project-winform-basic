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
    public class HoaDonDAL
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        // 1. HÀM MỚI: Lấy danh sách tóm tắt hóa đơn
        public DataTable GetAllHoaDon()
        {
            string error = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out error, "sp_GetAll_HoaDon_View");
                if (!string.IsNullOrEmpty(error))
                    throw new Exception(error);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // 2. HÀM MỚI: Lấy chi tiết của một hóa đơn
        public DataTable GetChiTietByMaHoaDon(int maHoaDon)
        {
            string error = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out error, "sp_GetChiTietByMaHoaDon_View",
                    "@MaHoaDon", maHoaDon);
                if (!string.IsNullOrEmpty(error))
                    throw new Exception(error);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetSach()
        {
            string erorr = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out erorr, "sp_GetAll_Sach");
                if (!string.IsNullOrEmpty(erorr))
                    throw new Exception(erorr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool TaoHoaDon(string hoTen, string soDienThoai, string email, string diaChi ,int maNguoiDung, DateTime ngayLap, decimal tongTien,
        List<ChiTietHoaDon> chiTietList)
        {
            try
            {
                string error = "";

                // Tạo DataTable cho danh sách chi tiết hóa đơn
                DataTable dtChiTiet = new DataTable();
                dtChiTiet.Columns.Add("MaSanPham", typeof(int));
                dtChiTiet.Columns.Add("SoLuong", typeof(int));
                dtChiTiet.Columns.Add("DonGia", typeof(decimal));

                foreach (var item in chiTietList)
                {
                    dtChiTiet.Rows.Add(item.MaSach, item.SoLuong, item.DonGia);
                }

                // Gọi stored procedure
                var kq = _dbHelper.ExcSPWithTransaction(out error,"sp_ThemHoaDon",
                    "@HoTen", hoTen,
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
