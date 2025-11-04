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
    public class NhaCungCapBLL
    {
        public NhaCungCapDAL _dal = new NhaCungCapDAL();

        public NhaCungCapBLL() { }

        public DataTable GetAll()
        {
            return _dal.GetAll();
        }

        public bool Create(NhaCungCap ncc)
        {
            // (Bạn có thể thêm logic kiểm tra Email, SĐT hợp lệ ở đây)
            return _dal.Create(ncc);
        }

        public bool Update(NhaCungCap ncc)
        {
            // (Tương tự, kiểm tra logic trước khi cập nhật)
            return _dal.Update(ncc);
        }

        public bool Delete(string maNhaCungCap)
        {
            return _dal.Delete(maNhaCungCap);
        }
    }
}