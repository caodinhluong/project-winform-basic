using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SachBLL
    {
        private SachDAL _dal = new SachDAL();
        public DataTable GetAll()
        {
            return _dal.GetAll();
        }
        public DataTable GetTheLoai()
        {
            return _dal.GetTheLoai();
        }
        public DataTable GetNhaXuatBan()
        {
            return _dal.GetNhaXuatBan();
        }
        public DataTable GetTacGia()
        {
            return _dal.GetTacGia();
        }
        public bool Create(Sach model)
        {
            return _dal.Create(model);
        }public bool Update(Sach model)
        {
            return _dal.Update(model);
        }public bool Delete(int maSach)
        {
            return _dal.Delete(maSach);
        }
    }
}
