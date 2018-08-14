using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using MaterialDesignThemes.Wpf;

namespace skylum_com
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Gallery> gall = null;
        public string CurrImage { get; set; }
        private int cuttImageInt;

        public MainWindow()
        {
            InitializeComponent();

            new Thread(new ThreadStart(LoadImg)).Start();
        }
        /// <summary>
        /// Loading images
        /// </summary>
        private void LoadImg()
        {
            Dispatcher.Invoke(() =>
            {
                gall = SearchPic.GetPic();
                AllPic.ItemsSource = gall;
            });
        }


        /// <summary>
        /// Select image and scale
        /// </summary>
        /// <param name="sender">ListView</param>
        /// <param name="e"></param>
        private void AllPic_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListView lv)
            {
                cuttImageInt = lv.SelectedIndex;
                CurrImage = gall[cuttImageInt].ImagePath;

                AllPic.Visibility = Visibility.Hidden;
                OneImg.Visibility = Visibility.Visible;

                OneImgConnection();
            }
        }

        /// <summary>
        /// Edit one image
        /// </summary>
        private void OneImgConnection()
        {
            if (OneImg.DataContext != null)
                OneImg.DataContext = null;
            OneImg.DataContext = this;
        }

        /// <summary>
        /// Single image is hidden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ImageExit();
        }



        /// <summary>
        /// Move form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleForm_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnMinTitle_Click(object sender, RoutedEventArgs e)
        {
            Button btmTitle = sender as Button;

            switch ((sender as Button).Name)
            {
                case "BtnMinTitle":
                    this.WindowState = WindowState.Minimized;
                    break;

                case "BtnMaxTitle":
                    this.WindowState = this.WindowState == WindowState.Maximized ?
                        WindowState.Normal : WindowState.Maximized;
                    break;

                case "BtnCloseTitle":
                    this.Close();
                    break;
            }
        }

        /// <summary>
        /// Drag and Drop image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllPic_Drop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            bool isNewPic = false;

            foreach (var item in files)
                if (SearchPic.IsPicture(item))
                {
                    string filePath = Directory.GetCurrentDirectory() + @"\img\img";
                    string format = item.Substring(item.LastIndexOf("."), item.Length - item.LastIndexOf("."));

                    for (int i = 0; i < int.MaxValue; i++)
                        if (!File.Exists(filePath + i + format))
                        {
                            filePath += i + format;
                            File.Copy(item, filePath);
                            break;
                        }

                    gall.Add(new Gallery(item));
                    isNewPic = true;
                }

            if (isNewPic)
            {
                Dispatcher.Invoke(() =>
                {
                    AllPic.ItemsSource = null;
                    AllPic.ItemsSource = gall;
                });
            }
        }

        /// <summary>
        /// Edit image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PackIcon_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if ((sender as PackIcon).Kind == PackIconKind.ArrowUpBoldCircle)
                ImageUp();
            else
                ImageDown();
        }

        /// <summary>
        /// Edit image up
        /// </summary>
        private void ImageUp()
        {
            if (cuttImageInt - 1 < 0)
                cuttImageInt = gall.Count;

            CurrImage = gall[--cuttImageInt].ImagePath;
            OneImgConnection();
        }

        /// <summary>
        /// Edit image down
        /// </summary>
        private void ImageDown()
        {
            if (cuttImageInt + 1 >= gall.Count)
                cuttImageInt = 0;

            CurrImage = gall[cuttImageInt++].ImagePath;
            OneImgConnection();
        }

        /// <summary>
        /// Single image is hidden
        /// </summary>
        private void ImageExit()
        {
            AllPic.Visibility = Visibility.Visible;
            OneImg.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// keyboard events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Up)
            {
                ImageUp();
            }
            else if(e.Key == Key.Down)
            {
                ImageDown();
            }
            else if(e.Key == Key.Escape)
            {
                ImageExit();
            }
        }
    }
}
