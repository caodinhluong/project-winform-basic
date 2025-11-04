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
    public class KhachHangDAL
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public KhachHangDAL() { }

        public DataTable GetAll()
        {
            string error = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out error, "sp_GetAll_KhachHang");
                if (!string.IsNullOrEmpty(error))
                    throw new Exception(error);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Create(KhachHang model)
        {
            string error = "";
            try
            {
                // Gọi SP sp_ThemKhachHang
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_ThemKhachHang",
                "@HoTen", model.HoTen,
                "@SoDienThoai", model.SoDienThoai,
                "@Email", model.Email,
                "@DiaChi", model.DiaChi);

                if ((kq != null && !string.IsNullOrEmpty(kq.ToString())) || !string.IsNullOrEmpty(error))
                {
                    throw new Exception(Convert.ToString(kq) + error);
                }
                return true;
            }
            catch (Exception ex)
            {
                // Bắt lỗi nếu Email hoặc SĐT bị trùng (UNIQUE constraint)
                if (ex.Message.Contains("UNIQUE KEY"))
                {
                    throw new Exception("Số điện thoại hoặc Email đã tồn tại!");
                }
                throw ex;
            }
        }

        public bool Update(KhachHang model)
        {
            string error = "";
            try
            {
                // Gọi SP sp_SuaKhachHang
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_SuaKhachHang",
                "@MaKhachHang", model.MaKhachHang,
                "@HoTen", model.HoTen,
                "@SoDienThoai", model.SoDienThoai,
                "@Email", model.Email,
                "@DiaChi", model.DiaChi);

                if ((kq != null && !string.IsNullOrEmpty(kq.ToString())) || !string.IsNullOrEmpty(error))
                {
                    throw new Exception(Convert.ToString(kq) + error);
                }
                return true;
            }
            catch (Exception ex)
            {
                // Bắt lỗi nếu Email hoặc SĐT bị trùng (UNIQUE constraint)
                if (ex.Message.Contains("UNIQUE KEY"))
                {
                    throw new Exception("Số điện thoại hoặc Email đã tồn tại!");
                }
                throw ex;
            }
        }

        public bool Delete(string maKhachHang)
        {
            string error = "";
            try
            {
                // Gọi SP sp_XoaKhachHang
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_XoaKhachHang",
                "@MaKhachHang", maKhachHang);

                if ((kq != null && !string.IsNullOrEmpty(kq.ToString())) || !string.IsNullOrEmpty(error))
                {
                    throw new Exception(Convert.ToString(kq) + error);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}