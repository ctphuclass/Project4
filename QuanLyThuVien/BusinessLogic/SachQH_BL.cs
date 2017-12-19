using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SachQH_BL
    {
        public List<SachQH_BO> LoadSachQH()
        {
            SachQH_DA DA = new SachQH_DA();
            return DA.LoadSachQH();
        }
    }
}
