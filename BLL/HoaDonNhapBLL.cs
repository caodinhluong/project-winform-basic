using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public  class HoaDonNhapBLL
    {
        private HoaDonNhapDAL _dal = new HoaDonNhapDAL();

        public bool TaoHoaDonNhap(string tenNCC, string soDienThoai, string email, string diaChi, int maNguoiDung, DateTime ngayLap, decimal tongTien,
       List<ChiTietHoaDonNhap> chiTietList)
        {
            return _dal.TaoHoaDonNhap(tenNCC, soDienThoai, email, diaChi, maNguoiDung, ngayLap, tongTien, chiTietList);
        }
    }
}
