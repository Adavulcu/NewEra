using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
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
using NewEra.DepoSimulasyon;
using System.Data;
using NewEraDepoTemplateCreater.Models;

namespace NewEraDepoTemplateCreater
{
    /// <summary>
    /// Interaction logic for WindowRafBagla.xaml
    /// </summary>
    public partial class WindowRafBagla : Window
    {
        public WindowRafBagla()
        {
            _Raflar = new List<RafModel>();
            InitializeComponent();
            _Size32 = new Size(32, 32);
            _Size40 = new Size(40, 40);
            _data = new Data();
            InitImages();
            _defaultBrush = Brushes.DarkGray;

        }
        bool _FlagBaglantiKontrol;
        RafModel _DefaulRafModel;
        SolidColorBrush _defaultBrush;
        RafModel _LinkToRaf;
        RafModel _ConnectToRaf;
        MyRafControl _prevMyRafControl;
        MyRafControl _SelectedMyRafControl;
        DataTable _DtDepo;
        DataTable _DtKat;
        DataTable _DtRaf;
        List<RafModel> _Raflar;
        List<RafModel> _RaflarDB;
        Size _Size32;
        Size _Size40;
        Data _data;

        public void Init(List<RafModel> raf)
        {
            _DtDepo = new DataTable();
            _DtKat = new DataTable();
            _DtRaf = new DataTable();
            _Raflar = raf;
            _RaflarDB = _Raflar;
            InitLabels();
            FillComboBoxes();
            for (int i = 0; i < _Raflar.Count; i++)
            {
                ComboBoxItem cbi = new ComboBoxItem()
                {
                    Content = _Raflar[i].Name,
                    Tag = _Raflar[i],
                    FontWeight = FontWeights.Bold,
                    FontSize = 20,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    HorizontalContentAlignment = HorizontalAlignment.Left
                };
                CBSimuRaf.Items.Add(cbi);
            }


        }

        private void FillComboBoxes()
        {
            try
            {
                #region Depo
                _DtDepo = _data.DepoGetir();
                _DtKat = _data.KatGetir();
                foreach (DataRow row in _DtDepo.Rows)
                {
                    string name = row["DepoIsim"].ToString();
                    Guid id = new Guid(row["DepoId"].ToString());

                    Models.DepoModel dm = new Models.DepoModel(name, id);
                    ComboBoxItem cbi = new ComboBoxItem()
                    {
                        Tag = dm,
                        Content = dm.Name,
                        FontWeight = FontWeights.Bold,
                        FontSize = 20,
                        VerticalContentAlignment = VerticalAlignment.Center,
                        HorizontalContentAlignment = HorizontalAlignment.Left

                    };
                    CBSimuDepo.Items.Add(cbi);
                }
                if (_DtDepo.Rows.Count > 0)
                    CBSimuDepo.SelectedIndex = 0;
                #endregion



            }
            catch (Exception ex)
            {

                MessageBox.Show("FillComboBoxes\n" + ex.Message);
            }
        }

        private void Mrc_click(object sender, MouseButtonEventArgs e)
        {
            MyRafControl mrc = (MyRafControl)sender;
            if (_prevMyRafControl != null)
            {
               
                if (_prevMyRafControl.Equals(mrc))
                {
                    _prevMyRafControl.IsSelected = !_prevMyRafControl.IsSelected;
                    return;
                }
                _prevMyRafControl.IsSelected = false;
            }
            _prevMyRafControl = mrc;
            mrc.IsSelected = !mrc.IsSelected;
            _LinkToRaf = (RafModel)mrc.Tag;
            if (mrc.IsSelected)
            {
                _SelectedMyRafControl = mrc;
            }
            else
                _SelectedMyRafControl = null;
        }

        private void SetRafToBind()
        {
            try
            {
                if (_SelectedMyRafControl != null)
                {
                    LblDBAdet.Content = _LinkToRaf.SiraAdedi.ToString();
                    LblDBDepoID.Content = _LinkToRaf.DepoId.ToString();
                    LblDBKatID.Content = _LinkToRaf.UlId.ToString();
                    LblDBRafId.Content = _LinkToRaf.Id.ToString();
                    LblDBRafAd.Content = _LinkToRaf.Name.ToString();
                }
                else
                    throw new Exception("Bir Raf Seçiniz");
            }
            catch (Exception ex)
            {

                MessageBox.Show("SetRafToBind\n"+ex.Message);
            }
        }

        private void InitLabels()
        {
            LblSimuToplamRaf.Content = _Raflar.Count.ToString();
            LblSimuBaglananRaf.Content = "0";
            LblSimuBostaRaf.Content = _Raflar.Count.ToString();

            
        }

        private void InitImages()
        {

            string executableLocation = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string ImgUpPath = System.IO.Path.Combine(executableLocation, "Up.png");
            string ImgDownPath = System.IO.Path.Combine(executableLocation, "Down.png");
            string ImgBaglaPath = System.IO.Path.Combine(executableLocation, "Bagla.png");
            string ImgSilPath = System.IO.Path.Combine(executableLocation, "Sil.png");
            string ImgBagliPath = System.IO.Path.Combine(executableLocation, "Bagli.png");
            string ImgUyariPath= System.IO.Path.Combine(executableLocation, "Uyari.png");

            ImgDown.Source = UlOperation.StrToImage(ImgDownPath);
            ImgRafBagla.Source = UlOperation.StrToImage(ImgBaglaPath);
            ImgRafBagKopkar.Source = UlOperation.StrToImage(ImgSilPath);
            ImgRafDurumBagli.Source = UlOperation.StrToImage(ImgBagliPath);
            ImgUp.Source = UlOperation.StrToImage(ImgUpPath);
            ImgRafUyari.Source = UlOperation.StrToImage(ImgUyariPath);

            ImgDown.MouseLeftButtonDown += Image_Clik;
            ImgUp.MouseLeftButtonDown += Image_Clik;
            ImgRafBagKopkar.MouseLeftButtonDown += Image_Clik;
            ImgRafBagla.MouseLeftButtonDown += Image_Clik;

            ImgDown.ResizeImage(_Size32);
            ImgUp.ResizeImage(_Size32);
            ImgRafBagKopkar.ResizeImage(_Size32);
            ImgRafBagla.ResizeImage(_Size32);
            ImgRafDurumBagli.ResizeImage(_Size40);
            ImgRafUyari.ResizeImage(_Size40);


            ImgDown.ToolTip = "ÇIKAR";
            ImgUp.ToolTip = "EKLE";
            ImgRafDurumBagli.ToolTip = "BAĞLI";
            ImgRafBagla.ToolTip = "RAFLARI BAGLA";
            ImgRafBagKopkar.ToolTip = "BAĞI KES";
            ImgRafUyari.ToolTip = "BU RAF HALİHAZIRDA BAĞLIDIR";
        }

        private void ImageEnter(object sender, MouseEventArgs e)
        {
            Image img = (Image)sender;

            if (e.RoutedEvent == MouseLeaveEvent)
            {
                img.ResizeImage(_Size32);
            }
            else if (e.RoutedEvent == MouseEnterEvent)
            {
                img.ResizeImage(_Size40);
            }
        }

        private void Image_Clik(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Image img = (Image)sender;
                switch (img.Name)
                {
                    case "ImgUp":
                        if (_LinkToRaf == null)
                        return;
                        SetRafToBind();
                        BaglatiKontrol();
                        break;
                    case "ImgDown":
                        SetDbRafLabelsDefault();
                        BaglatiKontrol();
                        break;
                    case "ImgRafBagla":
                        Guid id = _Raflar[0].Id;
                        BaglantiSonuc bs= RaflariBagla();
                        MessageBox.Show(bs.ToString());
                        BaglatiKontrol();
                        id = _Raflar[0].Id;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Image_Clik\n"+ex.Message);
            }
        }

        private void CBSimuRaf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            ComboBoxItem cbi = (ComboBoxItem)cb.SelectedItem;
            RafModel rm = (RafModel)cbi.Tag;
            _ConnectToRaf = rm;
            SetSimuLabels(rm);
            BaglatiKontrol();

           
        }

        private void BaglatiKontrol()
        {
            try
            {
                
                if (_ConnectToRaf==null ||_LinkToRaf==null)
                {
                    UlOperation.SetImagesVisibiyt(Visibility.Hidden, ImgRafBagKopkar, ImgRafBagla, ImgRafDurumBagli, ImgRafUyari);
                    return;
                }
                if (_ConnectToRaf.IsBound==false && _LinkToRaf.IsBound==false)
                {
                    _FlagBaglantiKontrol = true;
                    UlOperation.SetImagesVisibiyt(Visibility.Visible, ImgRafBagla);
                    UlOperation.SetImagesVisibiyt(Visibility.Hidden, ImgRafBagKopkar, ImgRafDurumBagli, ImgRafUyari);
                }
                else if (_ConnectToRaf.IsBound == true && _LinkToRaf.IsBound == true)
                {
                   
                    UlOperation.SetImagesVisibiyt(Visibility.Visible, ImgRafDurumBagli, ImgRafBagKopkar);
                    UlOperation.SetImagesVisibiyt(Visibility.Hidden, ImgRafUyari, ImgRafBagla);
                }
                else if(_ConnectToRaf.IsBound == true && _LinkToRaf.IsBound == false)
                {
                    _FlagBaglantiKontrol = false;
                    string tool = "Bağlanılacak Raf Halihazırda Başka Bir Rafa Bağlıdır ";
                    UlOperation.SetImagesVisibiyt(Visibility.Visible, ImgRafBagla,ImgRafUyari);
                    UlOperation.SetImagesVisibiyt(Visibility.Hidden, ImgRafBagKopkar, ImgRafDurumBagli);
                    ImgRafUyari.ToolTip = tool;

                }
                else if (_ConnectToRaf.IsBound == false && _LinkToRaf.IsBound == true)
                {
                    string tool = "Bağlanacak Raf Halihazırda Başka Bir Rafa Bağlıdır ";
                    UlOperation.SetImagesVisibiyt(Visibility.Visible, ImgRafBagla, ImgRafUyari);
                    UlOperation.SetImagesVisibiyt(Visibility.Hidden, ImgRafBagKopkar, ImgRafDurumBagli);
                    ImgRafUyari.ToolTip = tool;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("BaglatiKontrol\n"+ex.Message);
            }
        }

        private BaglantiSonuc RaflariBagla()
        {
            try
            {
                

                if (_ConnectToRaf.Coordinats.Count != _LinkToRaf.SiraAdedi)
                    return BaglantiSonuc.SiraEsitDegil;

              
                else
                {
                    _ConnectToRaf.Coordinats= _ConnectToRaf.Coordinats.OrderBy(row => row.Row).ThenBy(col => col.Col).ToList<LabelModel>();
                 //   _ConnectToRaf.Coordinats = (List<LabelModel>)a;
                    for (int i = 0; i < _ConnectToRaf.Coordinats.Count; i++)
                    {
                        _ConnectToRaf.Coordinats[i].Adres = _LinkToRaf.RafSira[i].Adres;
                        _ConnectToRaf.Coordinats[i].Alias = _LinkToRaf.RafSira[i].Adres;
                    }
                    _ConnectToRaf.Id = _LinkToRaf.Id;
                    _ConnectToRaf.UlId = _LinkToRaf.UlId;
                    _ConnectToRaf.DepoId = _LinkToRaf.DepoId;
                    _ConnectToRaf.Alias = _LinkToRaf.Name;
                    _ConnectToRaf.IsBound = true;
                    _LinkToRaf.IsBound = true;
                   
                    SetSimuLabels(_ConnectToRaf);
                    _SelectedMyRafControl.MyLblBagliRafAd.Content = _ConnectToRaf.Name;
                    _SelectedMyRafControl.MyLblRafRenk.Background = _ConnectToRaf.Color.Color;
                    _SelectedMyRafControl.IsCompleted = true;

                   
                    return BaglantiSonuc.Basarili;
                }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show("RaflariBagla\n"+ex.Message);
                return BaglantiSonuc.Hata;
            }
        }

        private void SetSimuLabels(RafModel rm)
        {
            LblSimuRafAd.Content = rm.Name;
            LblSimuRafId.Content = rm.Id.ToString();
            LblSimuKatID.Content = rm.UlId.ToString();
            LblSimuDepoID.Content = rm.DepoId.ToString();
            LblSimuAdet.Content = rm.Coordinats.Count.ToString();
        }

        private void CBSimuDepo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBox cb = (ComboBox)sender;
                ComboBoxItem cbi = (ComboBoxItem)cb.SelectedItem;
                Models.DepoModel dm = (Models.DepoModel)cbi.Tag;
                CbSimuKat.Items.Clear();
                foreach (DataRow row in _DtKat.Rows)
                {
                    Guid UlId = new Guid(row["ULId"].ToString());
                    if (dm.Id.Equals(UlId))
                    {
                        string name = row["Isim"].ToString();
                        Guid Id = new Guid(row["Id"].ToString());
                        Models.KatModel km = new Models.KatModel(UlId, name, Id);
                        ComboBoxItem cbi1 = new ComboBoxItem()
                        {
                            Tag = km,
                            Content = km.Name,
                            FontWeight = FontWeights.Bold,
                            FontSize = 20,
                            VerticalContentAlignment = VerticalAlignment.Center,
                            HorizontalContentAlignment = HorizontalAlignment.Left
                        };
                        CbSimuKat.Items.Add(cbi1);
                        CbSimuKat.SelectedIndex = 0;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("CBSimuDepo_SelectionChanged\n" + ex.Message);
            }
        }

        private void BtnRafGetir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RafGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnRafGetir_Click\n" + ex.Message);
            }
        }

        private void RafGetir()
        {
            try
            {
                ComboBoxItem cbi = (ComboBoxItem)CbSimuKat.SelectedItem;
                if (cbi == null)
                {
                    return;
                }

                Models.KatModel km = (Models.KatModel)cbi.Tag;
                _DtRaf = _data.RafGetir(km.UlId, km.Id);

                List<string> rafadList = RafAdListGetir();
                List<IEnumerable<DataRow>> rows=ClassifyingRafs(rafadList);
                List<RafModel> rafModels = new List<RafModel>();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow[] dataRow = (DataRow[])rows[i];

                    string rafName = dataRow[0]["Raf"].ToString();
                    Guid rafId = new Guid(dataRow[0]["RafId"].ToString());
                    Guid katId = new Guid(dataRow[0]["KatId"].ToString());
                    Guid depoId = new Guid(dataRow[0]["DepoId"].ToString());
                    List<RafSiraModel> sira = new List<RafSiraModel>();
                    for (int j = 0; j < dataRow.Length; j++)
                    {
                        string adres = dataRow[j]["Adres"].ToString();
                        Guid adresId = new Guid(dataRow[j]["AdresId"].ToString());

                        sira.Add(new RafSiraModel(adres,adresId));
                    }

                    rafModels.Add(new RafModel(rafName,dataRow.Length,sira,rafId,katId,depoId,false));
                }

                CreateRafControls(rafModels);
            }
            catch (Exception ex)
            {

                MessageBox.Show("RafGetir\n"+ex.Message);
            }
        }

        private List<string> RafAdListGetir()
        {
            List<string> rafAdList = new List<string>();
            try
            {


                string prevRafIsim = "xxxxx";

                foreach (DataRow row in _DtRaf.Rows)
                {
                    string RafIsim = row["Raf"].ToString();
                    if (!prevRafIsim.Equals(RafIsim))
                    {
                        rafAdList.Add(RafIsim);
                        prevRafIsim = RafIsim;
                    }
                }
                return rafAdList;

            }
            catch (Exception ex)
            {

                MessageBox.Show("RafAdListGetir");
                return null;
            }
        }


        private List<IEnumerable<DataRow>> ClassifyingRafs(List<string> rafList)
        {
            try
            {

                List<IEnumerable<DataRow>> rows = new List<IEnumerable<DataRow>>();
                for (int i = 0; i < rafList.Count; i++)
                {
                    var datas = _DtRaf.Select("Raf= '"+rafList[i]+"'");

                    if (datas != null)
                    {
                        rows.Add(datas);
                    }

                }

                return rows;
            }
            catch (Exception ex)
            {

                MessageBox.Show("ClassifyingTips\n" + ex.Message);
                return null;
            }
        }

        private void CreateRafControls(List<RafModel> list)
        {
            try
            {
                StckPanel.Children.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                   
                    MyRafControl mrc = new MyRafControl()
                    {
                        Tag = list[i],
                        RafAD = list[i].Name,
                        Color = _defaultBrush,
                        SıraAdedi = list[i].SiraAdedi,
                        IsCompleted = false,
                        HorizontalAlignment = HorizontalAlignment.Stretch
                    };
                    mrc.MouseLeftButtonDown += Mrc_click;
                    StckPanel.Children.Add(mrc);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateRafControls\n" + ex.Message);
            }
        }

        private void SetDbRafLabelsDefault()
        {
            LblDBAdet.Content = "";
            LblDBDepoID.Content = "";
            LblDBKatID.Content = "";
            LblDBRafId.Content = "";
            LblDBRafAd.Content = "";
        }

       
    }
}
