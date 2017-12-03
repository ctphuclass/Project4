using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;

namespace BusinessLogic
{
    public class NhanVien_BL
    {
        public static List<NhanVien_BO> DanhSachNhanVien()
        {
            NhanVien_DA NVDA = new NhanVien_DA();
            return NVDA.HamNV();
        }

        public static bool Them(NhanVien_BO NhanVien)
        {
            return NhanVien_DA.ThemNV(NhanVien); 
        }

        public static bool Sua(NhanVien_BO NhanVien)
        {
            return NhanVien_DA.UpdateNhanVien(NhanVien);
        }

        public static bool Xoa(NhanVien_BO NhanVien)
        {
            return NhanVien_DA.XoaNhanVien(NhanVien);
        }
    }
}
