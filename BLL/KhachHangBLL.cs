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
    public class KhachHangBLL
    {
        public KhachHangDAL _dal = new KhachHangDAL();

        public KhachHangBLL() { }

        public DataTable GetAll()
        {
            return _dal.GetAll();
        }

        public bool Create(KhachHang kh)
        {
            // (Bạn có thể thêm logic kiểm tra Email, SĐT hợp lệ ở đây)
            return _dal.Create(kh);
        }

        public bool Update(KhachHang kh)
        {
            // (Tương tự, kiểm tra logic trước khi cập nhật)
            return _dal.Update(kh);
        }

        public bool Delete(string maKhachHang)
        {
            return _dal.Delete(maKhachHang);
        }
    }
}