using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Session
    {
        public static int MaNguoiDung { get; set; }  // Lưu ID người dùng
        public static string HoTen { get; set; }     // Lưu tên
        public static string Role { get; set; }      // Lưu vai trò (Admin/Nhân viên)

        public static void DangXuat()
        {
            // Xóa thông tin đăng nhập khi đăng xuất
            MaNguoiDung = 0;
            HoTen = null;
            Role = null;
        }
    }
}
