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
    public class TacGiaBLL
    {
        public TacGiaDAL _dal = new TacGiaDAL();
        public TacGiaBLL()
        {
        }
        public DataTable GetAll()
        {
            return _dal.GetAll();
        }
        public bool Create(TacGia tg)
        {
            return _dal.Create(tg);
        }
        public bool Update(TacGia tg)
        {
            return _dal.Update(tg);
        }
        public bool Delete(string maTacGia)
        {
            return _dal.Delete(maTacGia);
        }
    }
}
