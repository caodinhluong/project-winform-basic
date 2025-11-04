using DAL.Helper;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungDAL
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();
        public NguoiDungDAL()
        {
        }
        public DataTable GetAll()
        {
            string erorr = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out erorr, "sp_GetAll_NguoiDung");
                if (!string.IsNullOrEmpty(erorr))
                    throw new Exception(erorr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public NguoiDung GetByID(int maNguoiDung)
        {
            string erorr = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out erorr, "sp_GetById_NguoiDung",
                    "@MaNguoiDung",maNguoiDung);
                if (!string.IsNullOrEmpty(erorr))
                    throw new Exception(erorr);
                return dt.ConvertTo<NguoiDung>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                if (!dataTable.Columns.Contains("MaNguoiDung"))
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
                var kq = _dbHelper.ExcSPWithTransaction(out error,"sp_DangKy",
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
        public bool DoiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            string erorr = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out erorr, "sp_DoiMatKhau_NguoiDung",
                "@TenDangNhap", tenDangNhap,
                "@MatKhauMoi",matKhauMoi
                    );
                if ((kq != null && !string.IsNullOrEmpty(kq.ToString())) || !string.IsNullOrEmpty(erorr))
                {
                    throw new Exception(Convert.ToString(kq) + erorr);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool CapNhatThongTinCaNhan(NguoiDung model)
        {
            string erorr = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out erorr, "sp_CapNhatThongTinCaNhan",
                "@MaNguoiDung", model.MaNguoiDung,
                "@HoTen", model.HoTen,
                "@SoDienThoai", model.SoDienThoai,
                "@Email", model.Email,
                "@DiaChi", model.DiaChi,
                "@GioiTinh", model.GioiTinh,
                "@AnhDaiDien", model.AnhDaiDien
                    );
                if ((kq != null && !string.IsNullOrEmpty(kq.ToString())) || !string.IsNullOrEmpty(erorr))
                {
                    throw new Exception(Convert.ToString(kq) + erorr);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool SuaTaiKhoan(TaiKhoan model)
        {
            string erorr = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out erorr, "sp_SuaTaiKhoan",
                "@TenDangNhap", model.TenDangNhap,
                "@MatKhau", model.MatKhau,
                "@MaNguoiDung", model.MaNguoiDung,
                "@Role", model.Role
                );
                if ((kq != null && !string.IsNullOrEmpty(kq.ToString())) || !string.IsNullOrEmpty(erorr))
                {
                    throw new Exception(Convert.ToString(kq) + erorr);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // 1. Hàm tải toàn bộ danh sách (đã có)
        public DataTable GetAll_View()
        {
            string erorr = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out erorr, "sp_GetAll_NguoiDung_TaiKhoan_View");
                if (!string.IsNullOrEmpty(erorr))
                    throw new Exception(erorr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // 2. HÀM MỚI (Tối ưu tìm kiếm, gọi SP mới)
        public DataTable Search_View(string keyword)
        {
            string erorr = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out erorr, "sp_Search_NguoiDung_View",
                    "@Keyword", keyword);
                if (!string.IsNullOrEmpty(erorr))
                    throw new Exception(erorr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
