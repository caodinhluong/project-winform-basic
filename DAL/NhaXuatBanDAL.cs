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
    public class NhaXuatBanDAL
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public NhaXuatBanDAL() { }

        public DataTable GetAll()
        {
            string error = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out error, "sp_GetAll_NhaXuatBan");
                if (!string.IsNullOrEmpty(error))
                    throw new Exception(error);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Create(NhaXuatBan model)
        {
            string error = "";
            try
            {
                // Gọi SP sp_ThemNhaXuatBan
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_ThemNhaXuatBan",
                "@TenNhaXuatBan", model.TenNhaXuatBan,
                "@DiaChi", model.DiaChi,
                "@SoDienThoai", model.SoDienThoai);

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

        public bool Update(NhaXuatBan model)
        {
            string error = "";
            try
            {
                // Gọi SP sp_SuaNhaXuatBan
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_SuaNhaXuatBan",
                "@MaNhaXuatBan", model.MaNhaXuatBan,
                "@TenNhaXuatBan", model.TenNhaXuatBan,
                "@DiaChi", model.DiaChi,
                "@SoDienThoai", model.SoDienThoai);

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

        public bool Delete(string maNhaXuatBan)
        {
            string error = "";
            try
            {
                // Gọi SP sp_XoaNhaXuatBan
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_XoaNhaXuatBan",
                "@MaNhaXuatBan", maNhaXuatBan);

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