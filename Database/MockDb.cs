using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MVC_Test.Database
{
    class MockDb
    {
        public static Uri GetPostVideo()
        {
            return new Uri(Environment.CurrentDirectory + @"\..\..\..\Videos\Catjamloop-1.mp4", UriKind.RelativeOrAbsolute);
        }

        public static BitmapImage GetPostPicture()
        {
            List<string> filepaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\..\Icons", "*.jpg").ToList<string>();
            Random generator = new Random(DateTime.Now.Millisecond);

            FileInfo myRandomFile = new FileInfo(filepaths[generator.Next(filepaths.Count)]);

            return new BitmapImage(new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute));
        }

    }
}
