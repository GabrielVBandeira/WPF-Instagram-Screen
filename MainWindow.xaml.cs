using MVC_Test.Models;
using MVC_Test.User_Controls;
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

namespace MVC_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random Generator;

        public MainWindow()
        {
            InitializeComponent();

            Generator = new Random(DateTime.Now.Millisecond);

            MainStackPanel.Children.Add(new VideoPost(new VideoPostModel()));
            MainStackPanel.Children.Add(new PicturePost(new PicturePostModel()));

            

        }

        private void MainScrollViwer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if(e.VerticalChange > 0)
            {
                int adjusment = 400;
                if(e.VerticalOffset + e.ViewportHeight + adjusment >= e.ExtentHeight)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        if(Generator.Next(0,100) < 80)
                        {
                            PicturePost newPost = new PicturePost(new PicturePostModel());
                            MainStackPanel.Children.Add(newPost);
                        }
                        else
                        {
                            VideoPost newVid = new VideoPost(new VideoPostModel());
                            MainStackPanel.Children.Add(newVid);
                        }
                        
                    }
                }
            }
        }
    }
}
