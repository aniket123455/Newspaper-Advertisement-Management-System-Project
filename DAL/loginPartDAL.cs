using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class loginPartDAL : IloginPartDAL<LOGIN_PART>
    {
        public int GetMaxUserId()
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var maxuserid = dbContext.LOGIN_PART.Max(User => User.USER_ID);
                    return maxuserid;
                }

            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public bool SaveLogin(LOGIN_PART loginPart)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    dbContext.LOGIN_PART.Add(loginPart);
                    dbContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
