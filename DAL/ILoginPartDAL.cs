using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public interface IloginPartDAL<LOGIN_PART>
    {
        bool SaveLogin(LOGIN_PART loginPart);

        int GetMaxUserId();
    }
}
