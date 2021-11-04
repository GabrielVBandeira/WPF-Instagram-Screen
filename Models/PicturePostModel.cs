using MVC_Test.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MVC_Test.Models
{
    public class PicturePostModel
    {
        public BitmapImage _postImage;

        public BitmapImage PostImage
        {
            get
            {
                if (_postImage == null)
                {
                    return MockDb.GetPostPicture();
                }
                else
                {
                    return _postImage;
                }
            }
            set
            {
                _postImage = value;
            }
        }
    }
}
