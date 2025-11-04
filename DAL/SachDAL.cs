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
    public class SachDAL
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public DataTable GetAll()
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
        public DataTable GetTheLoai()
        {
            string erorr = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out erorr, "sp_GetAll_TheLoai");
                if (!string.IsNullOrEmpty(erorr))
                    throw new Exception(erorr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetTacGia()
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
        public DataTable GetNhaXuatBan()
        {
            string erorr = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out erorr, "sp_GetAll_NhaXuatBan");
                if (!string.IsNullOrEmpty(erorr))
                    throw new Exception(erorr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(Sach model)
        {
            string erorr = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out erorr, "sp_ThemSach",
                "@TenSach", model.TenSach,
                "@MaTheLoai", model.MaTheLoai,
                "@MaTacGia", model.MaTacGia,
                "@MaNhaXuatBan", model.MaNhaXuatBan,
                "@NamXuatBan", model.NamXuatBan,
                "@SoLuong", model.SoLuong,
                "@GiaBan", model.GiaBan,
                "@MoTa", model.MoTa,
                "@AnhBia", model.AnhBia
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
        public bool Update(Sach model)
        {

            string erorr = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out erorr, "sp_SuaSach",
                "@MaSach", model.MaTacGia,
                "@TenSach", model.TenSach,
                "@MaTheLoai", model.MaTheLoai,
                "@MaTacGia", model.MaTacGia,
                "@MaNhaXuatBan", model.MaNhaXuatBan,
                "@NamXuatBan", model.NamXuatBan,
                "@SoLuong", model.SoLuong,
                "@GiaBan", model.GiaBan,
                "@MoTa", model.MoTa,
                "@AnhBia", model.AnhBia);
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
        public bool Delete(int maSach)
        {
            string erorr = "";
            try
            {
                var kq = _dbHelper.ExcSPWithTransaction(out erorr, "sp_XoaSach",
                "@MaSach", maSach);
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
    }
}
