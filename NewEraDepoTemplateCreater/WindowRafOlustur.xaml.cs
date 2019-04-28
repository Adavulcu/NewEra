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
using System.Windows.Shapes;

namespace NewEraDepoTemplateCreater
{
    /// <summary>
    /// Interaction logic for WindowRafOlustur.xaml
    /// </summary>
    public partial class WindowRafOlustur : Window
    {
      //  public bool _BtnFlag;
       public RafOlusturIslem ro;
       public RafModel _Raf;
        private ColorModel _color;
        public WindowRafOlustur()
        {
            InitializeComponent();
            _Raf = new RafModel();
            Color c = ((SolidColorBrush)LblRenk.Background).Color;
            BtnSil.Visibility = Visibility.Hidden;
            BtnGuncelle.Visibility = Visibility.Hidden;
            string colorName = LblRenkAd.Content.ToString();
           
            _color = new ColorModel(colorName, new SolidColorBrush(c));
           
            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                ro = RafOlusturIslem.Iptal;
                this.Close();
            }
        }

        public void Init(RafModel raf)
        {
            try
            {
                BtnSil.Visibility = Visibility.Visible;
                BtnKaydet.Visibility = Visibility.Hidden;
                BtnGuncelle.Visibility = Visibility.Visible;
                TextRafAd.Text = raf.Name;
                LblRenk.Background = raf.Color.Color;
                LblRenkAd.Content = raf.Color.ColorName;
                _Raf = raf;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Init\n"+ex.Message);
            }
        }

        private void LblRenk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                WindowColorPicker wcp = new WindowColorPicker();
                wcp.Init(_color);
                wcp.ShowDialog();
                _color = wcp._Color;
                LblRenkAd.Content = _color.ColorName;
                LblRenk.Background = _color.Color;
            }
            catch (Exception ex)
            {

                MessageBox.Show("LblRenk_MouseLeftButtonDown\n" + ex.Message);
            }

        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                switch (btn.Name)
                {
                    case "BtnSil":
                        MessageBoxResult result = MessageBox.Show("SİLME İŞLEMİNİ ONAYLIYOR MUSUNUZ?","UYARI!" , MessageBoxButton.YesNo, MessageBoxImage.Warning);
                        if (result==MessageBoxResult.Yes)
                        {
                            //_BtnFlag = true;
                            ro = RafOlusturIslem.Sil;
                            this.Close();
                        }
                     
                        break;
                    case "BtnKaydet":
                       // _BtnFlag = false;
                        string name = TextRafAd.Text;
                        string alias = TextRafAdAdlias.Text;
                        _Raf = new RafModel(name,alias, _color, new List<LabelModel>(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(),false);
                        ro = RafOlusturIslem.Ekle;
                        this.Close();
                        break;
                    case "BtnGuncelle":
                        string name1 = TextRafAd.Text;
                        string alias1 = TextRafAdAdlias.Text;
                        _Raf = new RafModel(name1,alias1, _color, new List<LabelModel>(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(),false);
                        ro = RafOlusturIslem.Guncelle;
                        this.Close();
                        break;
                    default:
                        break;
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnKaydet_Click\n"+ex.Message);
            }
        }
    }
}
