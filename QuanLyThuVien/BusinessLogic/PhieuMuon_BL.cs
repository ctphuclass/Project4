using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;

namespace BusinessLogic
{
    public class PhieuMuon_BL
    {
        public static bool PhieuMuon(PhieuMuon_BO PMS)
        {
            return PhieuMuon_DA.PhieuMuonSach(PMS);
        }
    }
}
