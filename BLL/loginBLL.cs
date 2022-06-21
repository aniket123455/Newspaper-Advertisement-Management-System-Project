using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class loginBLL
    {
        loginPartDAL LoginPartDAL = new loginPartDAL();

        public bool AddLogin(LOGIN_PART loginPart)
        {
            int newUserid = LoginPartDAL.GetMaxUserId();
            newUserid++;
            loginPart.USER_ID = newUserid;

            return LoginPartDAL.SaveLogin(loginPart);
        }
    }
}
