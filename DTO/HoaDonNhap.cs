using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonNhap
    {
        public int MaHoaDonNhap { get; set; }
        public int? MaNhaCungCap { get; set; }
        public int? MaNguoiDung { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal TongTien { get; set; }
    }

}
