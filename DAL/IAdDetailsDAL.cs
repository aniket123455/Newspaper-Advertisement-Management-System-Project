using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public interface IAdDetailsDAL<ADVERTISEMENT_DETAILS>
    {
        bool SaveDetails(ADVERTISEMENT_DETAILS Adverdetails);

        bool DeleteDetails(int code);

        bool UpdateDetails(ADVERTISEMENT_DETAILS Adverdetails);

        ADVERTISEMENT_DETAILS GetDetails(int code);

        int GetMaxAdNumber();

    }
}
