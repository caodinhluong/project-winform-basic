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
    public class TheLoaiDAL
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public TheLoaiDAL() { }

        public DataTable GetAll()
        {
            string error = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out error, "sp_GetAll_TheLoai");
                if (!string.IsNullOrEmpty(error))
                    throw new Exception(error);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Create(TheLoai model)
        {
            string error = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_ThemTheLoai",
                "@TenTheLoai", model.TenTheLoai);

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

        public bool Update(TheLoai model)
        {
            string error = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_SuaTheLoai",
                "@MaTheLoai", model.MaTheLoai,
                "@TenTheLoai", model.TenTheLoai);

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

        public bool Delete(string maTheLoai)
        {
            string error = "";
            try
            {
                // @MaTheLoai trong SP của bạn là INT, nhưng DatabaseHelper có vẻ
                // sẽ xử lý việc ép kiểu tự động khi truyền tham số.
                var kq = _dbHelper.ExcSPWithTransaction(out error, "sp_XoaTheLoai",
                "@MaTheLoai", maTheLoai);

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