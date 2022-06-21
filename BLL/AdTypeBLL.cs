using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class AdTypeBLL
    {
        AdTypeDAL AdTypeDAL = new AdTypeDAL();

        public bool Addtype(ADVERTISEMENT_TYPE adtype)
        {
            return AdTypeDAL.SaveUser(adtype);
        }

        public bool upType(ADVERTISEMENT_TYPE adtype)
        {
            return AdTypeDAL.UpdateUser(adtype);
        }
    }
}
