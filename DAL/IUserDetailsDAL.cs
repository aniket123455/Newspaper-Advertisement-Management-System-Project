using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public interface IUserDetailsDAL<USER_DETAILS>
    {
        bool SaveUser(USER_DETAILS userdetails);

        bool DeleteUser(int code);

        bool UpdateUser(USER_DETAILS userdetails);

        USER_DETAILS GetUser(int code);

    }
}
