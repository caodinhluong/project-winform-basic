using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int? MaKhachHang { get; set; }
        public int? MaNguoiDung { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
    }

}
