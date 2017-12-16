using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BusinessLogic
{
    public class SachBL
    {
        public List<SachBO> LoadSach()
        {
                SachDA d = new SachDA();
                return d.LoadSach();
        }
        public List<SachBO> TimSach(SachBO s)
        {
                SachDA d = new SachDA();
                return d.TimSach(s);
        }
        public bool InsertUpdate(SachBO s)
        {
            SachDA d = new SachDA();
            return d.InsertUpdate(s);
        }
        public bool Delete(SachBO s)
        {
            SachDA d = new SachDA();
            return d.Delete(s);
        }
    }
}
