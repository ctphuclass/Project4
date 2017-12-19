using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TraSachBL
    {
        public void PhieuTra(TraSachBO TS)
        {
            QL_PhieuTra_DA PT = new QL_PhieuTra_DA();
            PT.PhieuTra(TS);
        }
        public List<TraSachBO> LoadTraSach()
        {
            QL_PhieuTra_DA PT = new QL_PhieuTra_DA();
            return PT.LoadTraSach();
        }
    }
}
