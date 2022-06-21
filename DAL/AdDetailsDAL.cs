using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class AdDetailsDAL : IAdDetailsDAL<ADVERTISEMENT_DETAILS>
    {
        public bool SaveDetails(ADVERTISEMENT_DETAILS Adverdetails)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    dbContext.ADVERTISEMENT_DETAILS.Add(Adverdetails);
                    dbContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteDetails(int code)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var UserDelete = dbContext.ADVERTISEMENT_DETAILS.Where(User => User.USER_ID == code).FirstOrDefault();
                    dbContext.ADVERTISEMENT_DETAILS.Remove(UserDelete);
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateDetails(ADVERTISEMENT_DETAILS Adverdetails)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var exisitingusers = dbContext.ADVERTISEMENT_DETAILS.Where(User => User.USER_ID == Adverdetails.USER_ID).FirstOrDefault();
                    exisitingusers.ad_number = Adverdetails.ad_number;
                    exisitingusers.USER_ID = Adverdetails.USER_ID;
                    exisitingusers.ad_title = Adverdetails.ad_title;
                    exisitingusers.ad_date = Adverdetails.ad_date;
                    exisitingusers.ad_desc = Adverdetails.ad_desc;

                    dbContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public ADVERTISEMENT_DETAILS GetDetails(int code)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var DetailsByCode = dbContext.ADVERTISEMENT_DETAILS.Where(User => User.USER_ID == code).FirstOrDefault();
                    return DetailsByCode;

                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int GetMaxAdNumber()
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var maxAdNum = dbContext.ADVERTISEMENT_DETAILS.Max(User => User.ad_number);
                    return maxAdNum;
                }

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
