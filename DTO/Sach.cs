using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int? MaTheLoai { get; set; }
        public int? MaTacGia { get; set; }
        public int? MaNhaXuatBan { get; set; }
        public int? NamXuatBan { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
        public string MoTa { get; set; }
        public string AnhBia { get; set; }
    }

}
