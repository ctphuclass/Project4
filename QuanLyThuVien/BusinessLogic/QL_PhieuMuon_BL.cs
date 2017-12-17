using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObject;

namespace BusinessLogic
{
    public class QL_PhieuMuon_BL
    {
        public static List<KhoSach_BO> LoadPhieuMuon()
        {
            QL_PhieuMuon_DA QLPM = new QL_PhieuMuon_DA();
            return QLPM.KhoSach();
        }

        public static List<ThanhVienMuonSach_BO> LoadTVMuon()
        {
            QL_PhieuMuon_DA QLTVM = new QL_PhieuMuon_DA();
            return QLTVM.ThanhVienMuonS();
        }
    }
}
