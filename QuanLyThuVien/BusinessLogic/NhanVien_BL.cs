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
        public List<NhanVien_BO> DanhSachNhanVien()
        {
            NhanVien_DA NVDA = new NhanVien_DA();
            return NVDA.LoadNV();
        }

        public bool Sua(NhanVien_BO NhanVien)
        {
            NhanVien_DA NVDA = new NhanVien_DA();
            return NVDA.UpdateNhanVien(NhanVien);
        }

        public bool Xoa(NhanVien_BO NhanVien)
        {
            NhanVien_DA NVDA = new NhanVien_DA();
            return NVDA.XoaNhanVien(NhanVien);
        }
        public List<NhanVien_BO> TimNV(NhanVien_BO NhanVien)
        {
            NhanVien_DA NVDA = new NhanVien_DA();
            return NVDA.TimNV(NhanVien);
        }
    }
}
