using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

namespace UXIManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\Facebook"))
                FBGSBtn.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\uninstall.png"));
            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\FacebookWeb"))
                FBFBWeb.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\uninstall.png"));
            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\Facebook"))
                FBFBBtn.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\uninstall.png"));
            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\Muhasebex"))
                MuhasebeBtn.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\uninstall.png"));
        }

        private void HamburgerMenuItem_Selected(object sender, RoutedEventArgs e)
        {


            FBUGS.Visibility = Visibility.Hidden;
            FBUFB.Visibility = Visibility.Hidden;
            MuhasebeUX.Visibility = Visibility.Hidden;
            FBGrid.Visibility = Visibility.Visible;
            MuhasebeGrid.Visibility = Visibility.Hidden;
            TwitterGrid.Visibility = Visibility.Hidden;
            InstagramGrid.Visibility = Visibility.Hidden;
            FBUFBWEB.Visibility = Visibility.Hidden;
        }

        private void HamburgerMenuItem_Selected_1(object sender, RoutedEventArgs e)
        {
            FBUGS.Visibility = Visibility.Hidden;
            FBUFB.Visibility = Visibility.Hidden;
            MuhasebeUX.Visibility = Visibility.Hidden;
            FBGrid.Visibility = Visibility.Hidden;
            MuhasebeGrid.Visibility = Visibility.Visible;
            TwitterGrid.Visibility = Visibility.Hidden;
            InstagramGrid.Visibility = Visibility.Hidden;
            FBUFBWEB.Visibility = Visibility.Hidden;
        }

        private void HamburgerMenuItem_Selected_2(object sender, RoutedEventArgs e)
        {
            FBUGS.Visibility = Visibility.Hidden;
            FBUFB.Visibility = Visibility.Hidden;
            MuhasebeUX.Visibility = Visibility.Hidden;
            FBGrid.Visibility = Visibility.Hidden;
            MuhasebeGrid.Visibility = Visibility.Hidden;
            TwitterGrid.Visibility = Visibility.Visible;
            InstagramGrid.Visibility = Visibility.Hidden;
            FBUFBWEB.Visibility = Visibility.Hidden;
        }

        private void HamburgerMenuItem_Selected_3(object sender, RoutedEventArgs e)
        {

            FBUGS.Visibility = Visibility.Hidden;
            FBUFB.Visibility = Visibility.Hidden;
            MuhasebeUX.Visibility = Visibility.Hidden;
            FBGrid.Visibility = Visibility.Hidden;
            MuhasebeGrid.Visibility = Visibility.Hidden;
            TwitterGrid.Visibility = Visibility.Hidden;
            InstagramGrid.Visibility = Visibility.Visible;
            FBUFBWEB.Visibility = Visibility.Hidden;
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            FBUGS.Visibility = Visibility.Hidden;
            FBUFB.Visibility = Visibility.Hidden;
            MuhasebeUX.Visibility = Visibility.Visible;
            FBGrid.Visibility = Visibility.Hidden;
            MuhasebeGrid.Visibility = Visibility.Hidden;
            TwitterGrid.Visibility = Visibility.Hidden;
            InstagramGrid.Visibility = Visibility.Hidden;
            FBUFBWEB.Visibility = Visibility.Hidden;
        }

        private void Grid_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {

            FBUGS.Visibility = Visibility.Visible;
            FBUFB.Visibility = Visibility.Hidden;
            MuhasebeUX.Visibility = Visibility.Hidden; 
            FBGrid.Visibility = Visibility.Hidden;
            MuhasebeGrid.Visibility = Visibility.Hidden;
            TwitterGrid.Visibility = Visibility.Hidden;
            InstagramGrid.Visibility = Visibility.Hidden;
            FBUFBWEB.Visibility = Visibility.Hidden;
        }

        private void Grid_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {

            FBUGS.Visibility = Visibility.Hidden; 
            MuhasebeUX.Visibility = Visibility.Hidden;
            FBUFB.Visibility = Visibility.Visible;
            FBGrid.Visibility = Visibility.Hidden;
            MuhasebeGrid.Visibility = Visibility.Hidden;
            TwitterGrid.Visibility = Visibility.Hidden;
            InstagramGrid.Visibility = Visibility.Hidden;
            FBUFBWEB.Visibility = Visibility.Hidden;
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\Facebook"))
            {
                System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\Facebook", true);
                FBGSBtn.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\download.png"));
            }
            else
            {

                FBGSBtn.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\uninstall.png"));
                DirectoryCopy(@"C:\Users\Dante\Documents\VirtualAzureBlobStorage\FBGS", @"C:\Users\Dante\Documents\UXI Themes\Facebook", true);
            }

        }

        private void Image_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {

            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\Facebook"))
            {
                System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\Facebook", true);
                FBFBBtn.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\download.png"));

            }
            else
            {
                FBFBBtn.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\uninstall.png"));
                DirectoryCopy(@"C:\Users\Dante\Documents\VirtualAzureBlobStorage\FBFB", @"C:\Users\Dante\Documents\UXI Themes\Facebook", true);

            }
        }

        private void Image_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {

            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\Muhasebex"))
            {
                System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\Muhasebex", true);
                MuhasebeBtn.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\download.png"));

            }
            else
            { 
                MuhasebeBtn.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\uninstall.png"));
                DirectoryCopy(@"C:\Users\Dante\Documents\VirtualAzureBlobStorage\UXDeneme", @"C:\Users\Dante\Documents\UXI Themes\Muhasebex", true);
            }
        }
        private static void DirectoryCopy(
            string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, false);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)//facebook desktop
        {

            FBUGS.Visibility = Visibility.Hidden;
            MuhasebeUX.Visibility = Visibility.Hidden;
            FBUFB.Visibility = Visibility.Visible;
            FBGrid.Visibility = Visibility.Hidden;
            MuhasebeGrid.Visibility = Visibility.Hidden;
            TwitterGrid.Visibility = Visibility.Hidden;
            InstagramGrid.Visibility = Visibility.Hidden;
            FBUFBWEB.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//facebook web
        {

            FBUGS.Visibility = Visibility.Hidden;
            MuhasebeUX.Visibility = Visibility.Hidden;
            FBUFB.Visibility = Visibility.Hidden;
            FBGrid.Visibility = Visibility.Hidden;
            MuhasebeGrid.Visibility = Visibility.Hidden;
            TwitterGrid.Visibility = Visibility.Hidden;
            InstagramGrid.Visibility = Visibility.Hidden;
            FBUFBWEB.Visibility = Visibility.Visible;
        }

        private void Image_PreviewMouseDown_3(object sender, MouseButtonEventArgs e)//install facebook web ux
        {


            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\FacebookWeb"))
            {
                System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\FacebookWeb", true);
                FBFBWeb.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\download.png"));

            }
            else
            {
                FBFBWeb.Source = new BitmapImage(new Uri(@"E:\SystemFolders\documents\Visual Studio 2017 Projects\UXIDemo_WF\UXIManager\Assets\uninstall.png"));
                DirectoryCopy(@"C:\Users\Dante\Documents\VirtualAzureBlobStorage\FBFBWeb", @"C:\Users\Dante\Documents\UXI Themes\FacebookWeb", true);

            }
        }
    }
}
