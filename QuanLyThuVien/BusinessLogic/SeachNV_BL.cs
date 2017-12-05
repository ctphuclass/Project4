using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObject;

namespace BusinessLogic
{
   public  class SeachNV_BL
    {
        public static List<NhanVien_BO> DSTK(NhanVien_BO SBO)
        {
            SeachNV_DA DS = new SeachNV_DA();
            return DS.Seach(SBO);
        }
    }
}
