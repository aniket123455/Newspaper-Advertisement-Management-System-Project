using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class UserDetailsBLL
    {
        UserDetailsDAL userDetailsDAL = new UserDetailsDAL();

        public bool Adduser(USER_DETAILS userdetails)
        {
            return userDetailsDAL.SaveUser(userdetails);
        }

        public bool Deluser(int code)
        {
            return userDetailsDAL.DeleteUser(code);
        }

        public bool upuser(USER_DETAILS userdetails)
        {
            return userDetailsDAL.UpdateUser(userdetails);
        }

        public USER_DETAILS gtuser(int code)
        {
            return userDetailsDAL.GetUser(code);
        }
    }
}
