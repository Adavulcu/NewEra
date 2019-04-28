using DevExpress.Xpf.Carousel;
using NewEra.DepoSimulasyon.Models;
using NewEra.DepoSimulasyon.ShapeControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace NewEra.DepoSimulasyon
{
    /// <summary>
    /// Interaction logic for WindowRaf.xaml
    /// </summary>
    public partial class WindowRaf : Window
    {
        private const int _PK = 10;//point kat sayısı
        Data _data;
        Grid _gridKat;

        Grid _gridColors;
        Grid _rafOranGrid;
        dynamic _CG;//CurrentGrid
        List<RafOran> _ro;
        Stack<dynamic> _StackGrid;

        List<string> _raflar;



        public WindowRaf()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            Init();
        }

        MyCarousel _mc;
        CarouselItemsControl _CIC;

        private void Init()
        {
            try
            {
                _gridKat = new Grid();
                _data = new Data();
                _gridColors = new Grid();
                _rafOranGrid = new Grid();
                MyGrid.Background = Brushes.LightGray;
                MyWindow mw = new MyWindow();
                DataTable dt = _data.DepoGetir();
                _StackGrid = new Stack<dynamic>();
                List<DepoModel> list = new List<DepoModel>();
                foreach (DataRow row in dt.Rows)
                {
                    Guid depoId = new Guid(row["DepoId"].ToString());
                    byte[] arr = (byte[])row["Img"];
                    string name = row["DepoIsim"].ToString();
                    list.Add(new DepoModel(arr, name, depoId));
                }
                _CIC = carouselItemsControl1;
                _mc = new MyCarousel(list, _CIC);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Init\n" + ex.Message);
            }
        }



        private void BtnRaf_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                WindowDepo wd = new WindowDepo();
                switch (btn.Name)
                {
                    case "BtnBack":
                        BtnBackCilck();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnRaf_Click\n" + ex.Message);
            }
        }

        private void BtnBackCilck()
        {
            try
            {
                SetControlsVisibilty(false);
                if (_StackGrid.Count != 0)
                {
                    MyGrid.Children.Remove(_CG);
                    _CG = _StackGrid.Peek();
                    MyGrid.Children.Remove(_CG);
                    MyGrid.Children.Add(_StackGrid.Pop());
                    try
                    {
                        MyGrid.Children.Remove(_gridColors);
                    }
                    catch (Exception)
                    {


                    }

                }
                else
                {
                    if (_CG == null)
                    {

                    }
                    else
                    {
                        _CG = null;
                        MyGrid.Children.Add(_CIC);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnBackCilck\n" + ex.Message);
            }
        }

        public void Btn1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                CarouselItemsControl cic = _CIC;
                FrameworkElement fwe = (FrameworkElement)(cic.Carousel.ActiveItem);
                if (((FrameworkElement)sender).DataContext == fwe.DataContext)
                {
                    // MessageBox.Show("ActiveItemIsClicked");

                    KatShape ks = new KatShape(500, 250);
                    Guid depoId = new Guid(((Button)sender).Tag.ToString());
                    DataTable dt = _data.KatGetir(depoId);

                    double toplam = 0;
                    double ortalama = 0;
                    if (dt.Rows.Count != 0)
                    {
                        List<KatModel> list = new List<KatModel>();
                        foreach (DataRow row in dt.Rows)
                        {
                            Guid ulId = new Guid(row["UlId"].ToString());
                            Guid id = new Guid(row["Id"].ToString());
                            string isim = row["Isim"].ToString();
                            DataTable katDt = _data.KatDetayGetir(id, ulId);

                            if (katDt.Rows.Count == 0)
                            {
                                MessageBox.Show("BU DEPOYA AİT FİZİKSEL ADRES TANIMLAMASI YOKTUR");
                                return;
                            }
                            MyGrid.Children.Remove(_CIC);
                            _StackGrid.Push(_CIC);
                            double katOran = katDt.AsEnumerable()
                                .Sum(r => r["oran"].ToString().To<double>());
                            if (katOran > 0)
                            {
                                toplam += (katOran) / katDt.Rows.Count;
                            }
                            list.Add(new KatModel(ulId, isim, id, (katOran) / katDt.Rows.Count, katDt));
                        }
                        ortalama = (toplam) / dt.Rows.Count;
                        ortalama = Math.Round(ortalama, 1);

                        if (list.Count > 1)
                        {

                            _CG = _gridKat;
                            _gridKat = ks.CanvasKat(list.Count);
                            _gridKat.VerticalAlignment = VerticalAlignment.Center;
                            _gridKat.HorizontalAlignment = HorizontalAlignment.Center;
                            for (int i = 0; i < list.Count; i++)
                            {

                                KatModel km = (KatModel)list[i];
                                Button btn = new Button()
                                {
                                    Content = list[i].Name,
                                    VerticalAlignment = VerticalAlignment.Stretch,
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    FontSize = 40 - list.Count * 2,
                                    FontWeight = FontWeights.Bold,
                                    Tag = list[i]


                                };
                                btn.Click += delegate (object s, RoutedEventArgs ee) { BtnClick(s, ee, ortalama); };


                                if (i == 0)
                                {
                                    Grid.SetRow(btn, 1);
                                    Grid.SetColumn(btn, 1);

                                }
                                else
                                {
                                    Grid.SetRow(btn, i * 2 + 1);
                                    Grid.SetColumn(btn, 1);
                                }
                                _gridKat.Children.Add(btn);
                            }
                            Grid.SetRow(_gridKat, 1);
                            Grid.SetColumn(_gridKat, 0);

                            _CG = _gridKat;
                            MyGrid.Children.Remove(_CG);
                            MyGrid.Children.Add(_CG);
                        }

                        else
                        {
                            CreateKatDetay(list[0], ortalama);
                        }
                    }
                    else
                        MessageBox.Show("BU DEPO İÇİN TANIMLI BİR KAT YOKTUR");

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("btn1_PreviewMouseDown\n" + ex.Message);
            }

        }

        private void BtnClick(object sender, RoutedEventArgs e, double depoOran)
        {
            _StackGrid.Push(_CG);
            KatModel km = (KatModel)((Button)sender).Tag;
            CreateKatDetay(km, depoOran);

        }

        private void CreateKatDetay(KatModel km, double ortalama)
        {
            try
            {
                SetControlsVisibilty(true);

                _gridColors = UlOperation.CreateColorsGrid(MyGrid, 2, 0);
                Grid.SetRow(_gridColors, 2);
                Grid.SetColumn(_gridColors, 0);
                MyGrid.Children.Remove(_gridColors);
                MyGrid.Children.Add(_gridColors);

                // DataTable dt = _data.KatDetayGetir(new Guid());

                List<KatDetayModel> kdm = new List<KatDetayModel>();
                MyGrid.GetColAndRowSize(out int b, out int a, 0, 1);

                DataTable dt = _data.KatBoyutGetir(km.Id);
                int katx = 0, katy = 0;
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    katx = row["X"].ToString().ToInt();
                    katy = row["Y"].ToString().ToInt();
                }


                //  MessageBox.Show("height="+ a.ToString()+"\n width="+b.ToString());
                KatDetayShape kds = new KatDetayShape(b, a, katx, katy);
                Canvas canvas = new Canvas();
                foreach (DataRow row in km.KatData.Rows)
                {
                    Guid id = new Guid(row["AdresId"].ToString());
                    Guid UlId = new Guid(row["RafID"].ToString());
                    string name = row["Raf"].ToString();
                    int x = row["KX"].ToInt();
                    int y = row["KY"].ToInt();
                    string koy = row["Koy"].ToString();
                    double oran = row["oran"].To<double>();
                    //if (oran > 0)
                    //{
                    //    toplam += (1 / oran) * 100;
                    //}

                    int sira = row["Sira"].ToInt();
                    kdm.Add(new KatDetayModel(id, UlId, new Point(x, y), name, oran, sira, koy, km.Id, km.UlId));
                }

                CreateRafOranGrid(GetRafOran(km.KatData, kdm));
                //   ortalama = (100 * toplam) / dt.Rows.Count;
                string ttString = Math.Round(ortalama, 3).ToString();
                string ttStringKatoran = Math.Round(km.KatOran, 3).ToString();

                ToolTip tt = new ToolTip()
                {

                    Placement = System.Windows.Controls.Primitives.PlacementMode.Mouse,

                };

                ortalama = Math.Round(ortalama, 1);
                double katOrtalama = Math.Round(km.KatOran, 1);
                lblDepoDolulukOran.Content = "% " + ortalama.ToString();
                tt.Content = ttString;
                lblDepoDolulukOran.ToolTip = tt;
                tt.Content = ttStringKatoran;
                lblKatDolulukOran.ToolTip = tt;
                lblKatDolulukOran.Content = "% " + katOrtalama.ToString();

                lblDepoDolulukOran.Background = UlOperation.GetScaleColor(ortalama);
                lblKatDolulukOran.Background = UlOperation.GetScaleColor(katOrtalama);



                canvas = kds.DrawCanvas(kdm);
                _CG = canvas;

                canvas.MouseLeftButtonDown += CanvasClick;
                canvas.MouseMove += CanvasOver;
                canvas.MouseRightButtonDown += CanvasRightClick;


                Grid.SetRow(canvas, 1);
                Grid.SetColumn(canvas, 0);
                canvas.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#ccccff");
                MyGrid.Children.Remove(_CG);
                MyGrid.Children.Add(_CG);
            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateKatDetay\n" + ex.Message);
            }
        }

        private void CanvasRightClick(object sender, MouseButtonEventArgs e)
        {
            try
            {

                if (e.Source is FrameworkElement o && o is Polygon)
                {
                    Polygon p = (Polygon)o;
                    KatDetayModel km = (KatDetayModel)p.Tag;
                    WindowRafGenelDurum wrgd = new WindowRafGenelDurum();

                    RafOran oran = new RafOran();
                    for (int i = 0; i < _ro.Count; i++)
                    {
                        if (_ro[i].RafName == km.Name)
                        {
                            oran = _ro[i];
                            break;
                        }
                    }
                    this.Cursor = Cursors.Wait;
                    wrgd.Init(km, oran.Oran);
                    Cursor = Cursors.AppStarting;
                    wrgd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    wrgd.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("CanvasRightClick\n" + ex.Message);
            }
        }

        private void CanvasOver(object sender, MouseEventArgs e)
        {

            if (e.Source is FrameworkElement o && o is Polygon)
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void CreateRafOranGrid(List<RafOran> list)
        {
            try
            {
                int colCount = 0;

                if (list.Count > 0)
                {
                    if (list.Count % 2 == 0)
                    {
                        colCount = list.Count / 2;
                    }
                    else
                        colCount = (list.Count + 1) / 2;
                    UlOperation.GetColAndRowSize(GridRafOran, out int width, out int height, 3, 0);
                    _rafOranGrid.CreateGridRowsColoums(2, colCount, width / colCount, (height * 4) / 2);
                    int rowIndex = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list.Count % 2 == 0)
                        {
                            if (i > 0 && i % (list.Count / 2) == 0)
                                rowIndex++;
                        }
                        else
                        {
                            if (i > 0 && i % ((list.Count + 1) / 2) == 0)
                                rowIndex++;
                        }

                        Label lbl = new Label();
                        string lblName = list[i].RafName + " = % " + list[i].Oran;
                        int colIndex = i % (list.Count / 2);
                        lbl.CreateLabel(lblName, rowIndex, colIndex, width / colCount, (height * 4) / 2);
                        if (list[i].Oran > 80)
                        {
                            lbl.Foreground = Brushes.White;
                        }
                        else
                            lbl.Foreground = Brushes.Black;
                        lbl.Background = UlOperation.GetScaleColor(list[i].Oran);
                        _rafOranGrid.Children.Add(lbl);

                    }

                    _rafOranGrid.Background = Brushes.Black;
                    Grid.SetRow(_rafOranGrid, 0);
                    Grid.SetRowSpan(_rafOranGrid, 3);
                    Grid.SetColumn(_rafOranGrid, 3);

                    try
                    {
                        GridRafOran.Children.Remove(_rafOranGrid);
                    }
                    catch (Exception)
                    {


                    }
                    GridRafOran.Children.Add(_rafOranGrid);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateRafOranGrid\n" + ex.Message);
            }
        }

        private void CanvasClick(object sender, MouseButtonEventArgs e)
        {

            if (e.Source is FrameworkElement o && o is Polygon)
            {
                Polygon p = (Polygon)o;
                //  MessageBox.Show(((KatDetayModel)p.Tag).Name.ToString());
                KatDetayModel kdm = (KatDetayModel)p.Tag;

                List<HucreModel> list = new List<HucreModel>();
                DataTable dt = _data.RafSıraDetayGetir(kdm);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        string adres = row["Adres"].ToString();
                        int tip = row["Tip"].ToInt();
                        string tipIsim = row["TipIsim"].ToString();
                        Guid id = new Guid(row["AdresId"].ToString());
                        Guid ulId = new Guid(row["RafId"].ToString());
                        int yukseklik = row["Yukseklik"].ToInt();
                        string koy = row["Koy"].ToString();
                        int sira = row["Sira"].ToInt();
                        string raf = row["Raf"].ToString();
                        double oran = Convert.ToDouble(row["Oran"].ToString());
                        list.Add(new HucreModel(kdm.KatId, kdm.DepoId, id, ulId, adres, koy, sira, yukseklik, raf, oran, tip, tipIsim));
                    }

                    Window w = UlOperation.CreateRafSıra(list, kdm.Oran);
                    w.WindowStyle = WindowStyle.ToolWindow;
                    Point mousePoint = Mouse.GetPosition(this);
                    w.Topmost = true;
                    w.KeyDown += Windows_KeyDown;
                    double wWidth = w.Width;
                    double wHeigt = w.Height;
                    double x = mousePoint.X;
                    double y = mousePoint.Y;
                    if (x > this.Width - wWidth)
                    {
                        x = this.Width - wWidth;
                    }
                    if (y > this.Height - wHeigt)
                    {
                        y = this.Height - wHeigt;
                    }
                    w.Left = x;
                    w.Top = y;
                    w.Show();

                }


            }
            Canvas c = (Canvas)sender;

        }

        private void Windows_KeyDown(object sender, KeyEventArgs e)
        {
            Window w = (Window)sender;
            if (e.Key == Key.Escape)
            {
                w.Close();
            }
        }

        private void SetControlsVisibilty(bool flag)
        {
            if (!flag)
            {
                lblDepoDoluluk.Visibility = Visibility.Hidden;
                lblDepoDolulukOran.Visibility = Visibility.Hidden;
                lblKatDoluluk.Visibility = Visibility.Hidden;
                lblKatDolulukOran.Visibility = Visibility.Hidden;
                //  lblRafDoluluk.Visibility = Visibility.Hidden;
                _rafOranGrid.Visibility = Visibility.Hidden;
                _gridColors.Visibility = Visibility.Hidden;
                rectangle.Visibility = Visibility.Hidden;

            }
            else
            {
                lblDepoDoluluk.Visibility = Visibility.Visible;
                lblDepoDolulukOran.Visibility = Visibility.Visible;
                lblKatDoluluk.Visibility = Visibility.Visible;
                lblKatDolulukOran.Visibility = Visibility.Visible;
                // lblRafDoluluk.Visibility = Visibility.Visible;
                _gridColors.Visibility = Visibility.Visible;
                _rafOranGrid.Visibility = Visibility.Visible;
                rectangle.Visibility = Visibility.Visible;
            }

        }

        private List<RafOran> GetRafOran(DataTable dt, List<KatDetayModel> kdm)
        {
            string rafName = "xxxxxxx";
            _ro = new List<RafOran>();
            _raflar = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string raf = row["Raf"].ToString();
                if (!rafName.Equals(raf))
                {
                    _raflar.Add(raf);
                    rafName = raf;
                }
            }

            for (int i = 0; i < _raflar.Count; i++)
            {
                int counter = 0;
                double toplam = 0;
                double ortalama = 0;

                for (int j = 0; j < kdm.Count; j++)
                {
                    if (_raflar[i].Equals(kdm[j].Name))
                    {
                        if (kdm[j].Oran > 0)
                        {
                            // toplam += (1 / kdm[j].Oran) * 100;
                            toplam += kdm[j].Oran;
                        }

                        counter++;
                    }
                }
                ortalama = Math.Round((toplam) / counter, 1);
                _ro.Add(new RafOran() { RafName = _raflar[i], Oran = ortalama });
            }

            return _ro;
        }

        class RafOran
        {
            public string RafName { get; set; }
            public double Oran { get; set; }


        }

    }


}
