using DAL.Helper;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();
        public TaiKhoanDAL()
        {
        }
        public NguoiDung DangNhap(string tenDangNhap, string matKhau)
        {
            try
            {
                string error = "";

                // Gọi stored procedure sp_DangNhap
                var dataTable = _dbHelper.ExecuteSProcedureReturnDataTable(out error, "sp_DangNhap",
                    "@TenDangNhap", tenDangNhap,
                    "@MatKhau", matKhau);

                // Kiểm tra lỗi từ stored procedure
                if (!string.IsNullOrEmpty(error))
                {
                    throw new Exception("Lỗi từ stored procedure: " + error);
                }

                // Nếu không có dữ liệu trả về, nghĩa là đăng nhập thất bại
                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    return null; // Trả về null nếu không tìm thấy tài khoản
                }

                // Lấy thông tin người dùng từ DataTable
                DataRow row = dataTable.Rows[0];

                NguoiDung user = new NguoiDung()
                {
                    MaNguoiDung = Convert.ToInt32(row["MaNguoiDung"]),
                    HoTen = row["HoTen"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    Email = row["Email"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    AnhDaiDien = row["AnhDaiDien"] != DBNull.Value ? row["AnhDaiDien"].ToString() : null,
                    Role = row["Role"].ToString() // Lấy thông tin phân quyền
                };

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong phương thức DangNhap: " + ex.Message);
            }
        }

        public bool DangKy(string tenDangNhap, string matKhau, string hoTen, string soDienThoai, string email, string diaChi, string anhDaiDien, string role)
        {
            try
            {
                string error = "";

                // Gọi stored procedure sp_DangKy
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_DangKy",
                    "@TenDangNhap", tenDangNhap,
                    "@MatKhau", matKhau,
                    "@HoTen", hoTen,
                    "@SoDienThoai", soDienThoai,
                    "@Email", email,
                    "@DiaChi", diaChi,
                    "@AnhDaiDien", anhDaiDien,
                    "@Role", role);

                // Kiểm tra lỗi từ stored procedure
                if (!string.IsNullOrEmpty(error))
                {
                    throw new Exception("Lỗi từ stored procedure: " + error);
                }

                // Kiểm tra kết quả trả về
                if (kq != null && !string.IsNullOrEmpty(kq.ToString()))
                {
                    throw new Exception("Lỗi xử lý: " + kq.ToString());
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong phương thức DangKy: " + ex.Message);
            }
        }

    
    }
}
