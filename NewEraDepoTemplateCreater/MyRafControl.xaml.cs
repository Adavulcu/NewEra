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
using NewEra.DepoSimulasyon;

namespace NewEraDepoTemplateCreater
{
    /// <summary>
    /// Interaction logic for MyRafControl.xaml
    /// </summary>
    public partial class MyRafControl : UserControl
    {
        public MyRafControl()
        {
            InitializeComponent();
            ImgNotCompeleted = new Image();
            ImgCompleted = new Image();

            MyImageCheck.Source = UlOperation.CreateFilePath("NotCompleted.png").StrToImage();
            ImgCompleted.Source = UlOperation.CreateFilePath("Completed.png").StrToImage();

        }
        #region Variables

        private Image ImgCompleted;
        private Image ImgNotCompeleted;

        public string RafAD
        {
            get
            {
                return MyLblRafAd.Content.ToString();
            }
            set
            {
                MyLblRafAd.Content = value;
            }
        }
        public string BagliRafAD
        {
            get
            {
                return MyLblBagliRafAd.Content.ToString();
            }
            set
            {
                if (!value.Equals(""))
                {
                    MyLblBagliRafAd.Content = value;
                }
                else
                    MyLblBagliRafAd.Content = "-----------";
            }
        }
        public int SıraAdedi
        {
            get
            {
                return MyLblRafSiraAdedi.Content.ToInt();
            }
            set
            {
                if (value > 0)
                {
                    MyLblRafSiraAdedi.Content = value;
                }
                else
                    MyLblRafSiraAdedi.Content = "0";
            }
        }
        public SolidColorBrush Color
        {
            get
            {
                return (SolidColorBrush)MyLblRafRenk.Background;
            }
            set
            {
                MyLblRafRenk.Background = value;
            }
        }
        public bool IsSelected
        {
            get
            {
                if (MyRdbtn.IsChecked == true)
                    return true;
                else
                    return false;
            }
            set
            {
                MyRdbtn.IsChecked = value;
                if (MyRdbtn.IsChecked == true)
                {
                    MyGrid.Background = Brushes.LightBlue;
                }
                else
                    MyGrid.Background = Brushes.LightGoldenrodYellow;
            }
        }
        public bool IsCompleted
        {
           
            set
            {
                if (value)
                {
                   
                    MyImageCheck.Source = UlOperation.CreateFilePath("Completed.png").StrToImage();
                }
                else
                    MyImageCheck.Source = UlOperation.CreateFilePath("NotCompleted.png").StrToImage();
            }
        }

        public double Width
        {
            get
            {
                return MyGrid.Width;
            }
            set
            {
                if (value > 0)
                    MyGrid.Width = value;
                else
                    MyGrid.Width = 0;

            }
        }
        public double Height
        {
            get
            {
                return MyGrid.Height;
            }
            set
            {
                if (value > 0)
                    MyGrid.Height = value;
                else
                    MyGrid.Height = 0;

            }
        }


        public VerticalAlignment VerticalAlignment
        {

            set
            {
                MyGrid.VerticalAlignment = value;
            }
        }
        public HorizontalAlignment HorizontalAlignment
        {
            set
            {
                MyGrid.HorizontalAlignment = value;
               
            }
        }
        public string Name { get; set; }
        public object Tag { get; set; }
        #endregion

      
    }
}
