using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace BusinessLogic
{
    public class UserBL
    {
        public ResultMessageBO CheckUserLoginBL(UserBO objUserBL)
        {
            try
            {
                UserDA objUserda = new UserDA(); // Creating object of Dataccess
                return objUserda.CheckUserLogin(objUserBL); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public List<UserPermissionBO> GetPermission(int piUserID, string psModule)
        {
            try
            {
                UserDA objUserda = new UserDA(); // Creating object of Dataccess
                return objUserda.GetPermission(piUserID, psModule); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public List<ThongTinCN> ThongTinCN(int UserID)
        {
            try
            {
                UserDA objUserda = new UserDA(); // Creating object of Dataccess
                return objUserda.ThongTinCN(UserID); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public ResultMessageBO ChangeUserLoginBL(UserBO objUserBL)
        {
            try
            {
                UserDA objUserda = new UserDA(); // Creating object of Dataccess
                return objUserda.ChangePass(objUserBL); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public bool UpdateTV(ThongTinCN s)
        {
            UserDA DA = new UserDA();
            return DA.UpdateTT(s);
        }
    }
}
