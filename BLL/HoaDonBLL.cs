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
    public class HoaDonBLL
    {
        private HoaDonDAL _dal = new HoaDonDAL();
        // 1. HÀM MỚI
        public DataTable GetAllHoaDon()
        {
            return _dal.GetAllHoaDon();
        }

        // 2. HÀM MỚI
        public DataTable GetChiTietByMaHoaDon(int maHoaDon)
        {
            return _dal.GetChiTietByMaHoaDon(maHoaDon);
        }
        public DataTable GetSach()
        {
            return _dal.GetSach();
        }
        public bool TaoHoaDon(string hoTen, string soDienThoai, string email, string diaChi, int maNguoiDung, DateTime ngayLap, decimal tongTien,
                List<ChiTietHoaDon> chiTietList)
        {
            return _dal.TaoHoaDon(hoTen,soDienThoai,email, diaChi,maNguoiDung, ngayLap, tongTien,chiTietList);
        }
    }
}
