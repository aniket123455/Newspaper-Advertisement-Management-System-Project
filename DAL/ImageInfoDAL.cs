using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class ImageInfoDAL : IImageInfoDAL<IMAGE_INFO>
    {

        public bool SaveImage(IMAGE_INFO img)
        {

            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    dbContext.IMAGE_INFO.Add(img);
                    dbContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteImage(int code)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var removeimageinfo = dbContext.IMAGE_INFO.Where(User => User.ad_number == code).FirstOrDefault();
                    dbContext.IMAGE_INFO.Remove(removeimageinfo);
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool UpdateImage(IMAGE_INFO img)
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var existimg = dbContext.IMAGE_INFO.Where(User => User.ad_number == img.ad_number).FirstOrDefault();
                    existimg.ad_number = img.ad_number;
                    existimg.image_number = img.image_number;
                    existimg.image_path = img.image_path;
                    existimg.image_file_name = img.image_file_name;

                    dbContext.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int GetMaxImgNo()
        {
            try
            {
                using (anidbEntities dbContext = new anidbEntities())
                {
                    var maxImgNo = dbContext.IMAGE_INFO.Max(User => User.image_number);
                    return maxImgNo;
                }

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
