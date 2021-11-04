using MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVC_Test.User_Controls
{
    /// <summary>
    /// Interaction logic for VideoPost.xaml
    /// </summary>
    public partial class VideoPost : UserControl
    {
        public VideoPost(VideoPostModel videoPostModel)
        {
            InitializeComponent();

            VideoPlayer.Source = videoPostModel.VideoPlayerSource;
        }

        private void ContentControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (!PostOp.PostLiked)
            {
                PostOp.LikePost();
            }
            else
            {
                PostOp.UnLikePost();
            }
        }
    }
}
