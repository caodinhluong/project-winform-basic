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
    public class NhaCungCapDAL
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public NhaCungCapDAL() { }

        public DataTable GetAll()
        {
            string error = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out error, "sp_GetAll_NhaCungCap");
                if (!string.IsNullOrEmpty(error))
                    throw new Exception(error);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Create(NhaCungCap model)
        {
            string error = "";
            try
            {
                // Gọi SP sp_ThemNhaCungCap
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_ThemNhaCungCap",
                "@TenNhaCungCap", model.TenNhaCungCap,
                "@DiaChi", model.DiaChi,
                "@SoDienThoai", model.SoDienThoai,
                "@Email", model.Email);

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

        public bool Update(NhaCungCap model)
        {
            string error = "";
            try
            {
                // Gọi SP sp_SuaNhaCungCap
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_SuaNhaCungCap",
                "@MaNhaCungCap", model.MaNhaCungCap,
                "@TenNhaCungCap", model.TenNhaCungCap,
                "@DiaChi", model.DiaChi,
                "@SoDienThoai", model.SoDienThoai,
                "@Email", model.Email);

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

        public bool Delete(string maNhaCungCap)
        {
            string error = "";
            try
            {
                // Gọi SP sp_XoaNhaCungCap
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_XoaNhaCungCap",
                "@MaNhaCungCap", maNhaCungCap);

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