using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class AdDetailsBLL
    {
        AdDetailsDAL AdDetailsDAL = new AdDetailsDAL();

        public bool AddDetails(ADVERTISEMENT_DETAILS Adverdetails)
        {
            int newAdNumber = AdDetailsDAL.GetMaxAdNumber();
            newAdNumber++;
            Adverdetails.ad_number = newAdNumber;
            return AdDetailsDAL.SaveDetails(Adverdetails);
        }

        public bool DelDetails(int code)
        {
            return AdDetailsDAL.DeleteDetails(code);
        }

        public bool upDetails(ADVERTISEMENT_DETAILS Adverdetails)
        {
            return AdDetailsDAL.UpdateDetails(Adverdetails);
        }

        public ADVERTISEMENT_DETAILS gtDetails(int code)
        {
            return AdDetailsDAL.GetDetails(code);
        }
    }
}
