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
    public class TheLoaiBLL
    {
        public TheLoaiDAL _dal = new TheLoaiDAL();

        public TheLoaiBLL() { }

        public DataTable GetAll()
        {
            return _dal.GetAll();
        }

        public bool Create(TheLoai tl)
        {

            return _dal.Create(tl);
        }

        public bool Update(TheLoai tl)
        {
            return _dal.Update(tl);
        }

        public bool Delete(string maTheLoai)
        {
            return _dal.Delete(maTheLoai);
        }
    }
}