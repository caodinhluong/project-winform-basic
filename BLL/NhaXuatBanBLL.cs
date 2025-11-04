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
    public class NhaXuatBanBLL
    {
        public NhaXuatBanDAL _dal = new NhaXuatBanDAL();

        public NhaXuatBanBLL() { }

        public DataTable GetAll()
        {
            return _dal.GetAll();
        }

        public bool Create(NhaXuatBan nxb)
        {
            // (Nếu có logic nghiệp vụ, xử lý ở đây)
            return _dal.Create(nxb);
        }

        public bool Update(NhaXuatBan nxb)
        {
            // (Nếu có logic nghiệp vụ, xử lý ở đây)
            return _dal.Update(nxb);
        }

        public bool Delete(string maNhaXuatBan)
        {
            return _dal.Delete(maNhaXuatBan);
        }
    }
}