using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class SachBO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoTrang { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNXB { get; set; }
        public string MaTacGia { get; set; }
        public string MaTheLoai { get; set; }
        public bool TinhTrang { get; set; }
    }
}
