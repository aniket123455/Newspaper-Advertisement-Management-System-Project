using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public interface IImageInfoDAL<IMAGE_INFO>
    {
        bool SaveImage(IMAGE_INFO img);

        bool DeleteImage(int code);

        bool UpdateImage(IMAGE_INFO img);

        int GetMaxImgNo();
    }
}
