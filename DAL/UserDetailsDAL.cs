using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class UserDetailsDAL : IUserDetailsDAL<USER_DETAILS>
    {
        public bool SaveUser(USER_DETAILS userdetails)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    dbContext.USER_DETAILS.Add(userdetails);
                    dbContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteUser(int code)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var UserDel = dbContext.USER_DETAILS.Where(User => User.USER_ID == code).FirstOrDefault();
                    dbContext.USER_DETAILS.Remove(UserDel);
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateUser(USER_DETAILS userdetails)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var exisitinguser = dbContext.USER_DETAILS.Where(User => User.USER_ID == userdetails.USER_ID).FirstOrDefault();
                    exisitinguser.USER_ID = userdetails.USER_ID;
                    exisitinguser.First_Name = userdetails.First_Name;
                    exisitinguser.Last_Name = userdetails.Last_Name;
                    exisitinguser.Street = userdetails.Street;
                    exisitinguser.City = userdetails.City;
                    exisitinguser.State = userdetails.State;
                    exisitinguser.Address = userdetails.Address;
                    exisitinguser.Email = userdetails.Email;
                    exisitinguser.Contact = userdetails.Contact;

                    dbContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public USER_DETAILS GetUser(int code)
        {

            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var UserByCode = dbContext.USER_DETAILS.Where(User => User.USER_ID == code).FirstOrDefault();
                    return UserByCode;

                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
