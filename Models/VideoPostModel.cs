using MVC_Test.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Test.Models
{
    public class VideoPostModel
    {
        public Uri _videoPlayersource;

        public Uri VideoPlayerSource
        {
            get
            {
                if(_videoPlayersource == null)
                {
                    return MockDb.GetPostVideo();
                }
                else
                {
                    return _videoPlayersource;
                }
            }
            set
            {
                _videoPlayersource = value;
            }
        }
    }
}
