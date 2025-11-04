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
    public class NguoiDungBLL
    {
        private NguoiDungDAL _dal = new NguoiDungDAL();
        // 1. Hàm tải toàn bộ
        public DataTable GetAll_View()
        {
            return _dal.GetAll_View();
        }

        // 2. Hàm tìm kiếm
        public DataTable Search_View(string keyword)
        {
            return _dal.Search_View(keyword);
        }
        public NguoiDung DangNhap(string tk, string mk)
        {
            return _dal.DangNhap(tk,mk);
        }
        public bool DangKy(string tenDangNhap, string matKhau, string hoTen, string soDienThoai, string email, string diaChi, string anhDaiDien, string role)
        {
            return _dal.DangKy(tenDangNhap,matKhau,hoTen,soDienThoai,email,diaChi,anhDaiDien,role);
        }
        public NguoiDung GetByID(int maNguoiDung)
        {
            return _dal.GetByID(maNguoiDung);
        }
        public bool DoiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            return _dal.DoiMatKhau(tenDangNhap, matKhauMoi);
        }
        public bool CapNhatThongTinCaNhan(NguoiDung model)
        {
            return _dal.CapNhatThongTinCaNhan(model);
        }
    }
}
