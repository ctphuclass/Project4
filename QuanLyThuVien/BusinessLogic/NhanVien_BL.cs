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
    }
}
