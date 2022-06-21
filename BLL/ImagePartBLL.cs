using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class ImagePartBLL
    {
        ImageInfoDAL ImageInfoDAL = new ImageInfoDAL();

        public bool Addimg(IMAGE_INFO img)
        {
            int newImgnum = ImageInfoDAL.GetMaxImgNo();
            newImgnum++;
            img.image_number = newImgnum;
            return ImageInfoDAL.SaveImage(img);
        }

        public bool Delimg(int code)
        {
            return ImageInfoDAL.DeleteImage(code);
        }

        public bool upimg(IMAGE_INFO img)
        {
            return ImageInfoDAL.UpdateImage(img);
        }
    }
}
