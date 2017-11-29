using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;

namespace BusinessLogic
{
    public class SeachBL
    {
       public public List<SeachBO> DSTK()
        {
           Seach_DA TKDA = new Seach_DA();
           return TKDA.Seach();
        }
    }
}
