using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ThanhVien_BL
    {
        public List<ThanhVien_BO> LoadThanhVien()
        {
            ThanhVien_DA d = new ThanhVien_DA();
            return d.LoadThanhVien();
        }
        public List<ThanhVien_BO> TimTV(ThanhVien_BO s)
        {
            ThanhVien_DA d = new ThanhVien_DA();
            return d.TimTV(s);
        }
        public bool InsertUpdateTV(ThanhVien_BO s)
        {
            ThanhVien_DA d = new ThanhVien_DA();
            return d.InsertUpdateTV(s);
        }
        public bool DeleteTV(ThanhVien_BO s)
        {
            ThanhVien_DA d = new ThanhVien_DA();
            return d.DeleteTV(s);
        }
    }
}
