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
    public class TacGiaDAL
    {
        private DatabaseHelper _dbHelper  = new DatabaseHelper();
        public TacGiaDAL()
        {
        }
        public DataTable GetAll()
        {
            string erorr = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out erorr, "sp_GetAll_TacGia");
                if (!string.IsNullOrEmpty(erorr))
                    throw new Exception(erorr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(TacGia model)
        {
            string erorr = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out erorr, "sp_ThemTacGia",
                "@TenTacGia", model.TenTacGia,
                "@NgaySinh", model.NgaySinh,
                "@QuocTich",model.QuocTich);
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
        public bool Update(TacGia model)
        {

            string erorr = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out erorr,"sp_SuaTacGia",
                "@MaTacGia", model.MaTacGia,
                "@TenTacGia", model.TenTacGia,
                "@NgaySinh", model.NgaySinh,
                "@QuocTich", model.QuocTich);
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
        public bool Delete(string maTacGia)
        {
            string erorr = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out erorr, "sp_XoaTacGia",
                "@MaTacGia", maTacGia);
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
        //public DataTable GetByCategory(string categoryName)
        //{
        //    string msgError = "";
        //    try
        //    {
        //        var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_product_get_by_category_name",
        //        "@category_name", categoryName);
        //        if (!string.IsNullOrEmpty(msgError))
        //            throw new Exception(msgError);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //} 
         
    }
}
