using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObject;

namespace BusinessLogic
{
    public class Seach_BL
    {
        public static  List<SeachBO> DSTK(SeachBO SBO)
        {
            Seach_DA DS = new Seach_DA();
            return DS.Seach(SBO);
        }
    }
}
