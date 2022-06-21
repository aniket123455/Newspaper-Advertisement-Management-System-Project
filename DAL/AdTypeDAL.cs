using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class AdTypeDAL : IAdType<ADVERTISEMENT_TYPE>
    {
        public bool SaveUser(ADVERTISEMENT_TYPE adtype)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    dbContext.ADVERTISEMENT_TYPE.Add(adtype);
                    dbContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateUser(ADVERTISEMENT_TYPE adtype)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var userty = dbContext.ADVERTISEMENT_TYPE.Where(User => User.USER_ID == adtype.USER_ID).FirstOrDefault();
                    userty.USER_ID = adtype.USER_ID;
                    userty.ad_type = adtype.ad_type;
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
