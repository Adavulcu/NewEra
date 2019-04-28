using NewEra.DepoSimulasyon.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace NewEra.DepoSimulasyon
{
    /// <summary>
    /// Interaction logic for WindowRafDetay.xaml
    /// </summary>
    public partial class WindowRafDetay : Window
    {
        public WindowRafDetay()
        {
            InitializeComponent();


        }
        Guid _depoId, _katId;
        DataTable _dt;
        private int _width = 50;
        private int _height = 50;
        List<IEnumerable<DataRow>> _rows;

        private int _hucreRowCount;
        private int _hucreColCount;

        private int _tipLabelWidth;
        private int _tipLabelHeight;

        double _genelOrtalama;
        int _counter=0;
        int _bos = 0;
        int _asiriYuklu = 0;
        int _c0_10 = 0;
        int _c10_20 = 0;
        int _c20_30 = 0;
        int _c30_40 = 0;
        int _c40_50 = 0;
        int _c50_60 = 0;
        int _c60_70 = 0;
        int _c70_80 = 0;
        int _c80_90 = 0;
        int _c90_100 = 0;

        public void Init(DataTable dt,Guid katId,Guid depoId, string rafIsim,double genOrt)
        {
            try
            {
                _depoId = depoId;
                _katId = katId;
                _dt = dt;
                _genelOrtalama = genOrt;
                this.Title = "RAF - " + rafIsim + " TÜM PALETLER";
                int maxYukseklik = _dt.AsEnumerable()
                        .Max(row => row["Yukseklik"]).ToString().ToInt();
                int count = dt.Rows.Count;

                List<int> listTip = SelectTips();
                _rows = ClassifyingTips(listTip);
                var datas = _dt.Select("Yukseklik=" + 1);

                int c = ((DataRow[])datas).Length;

                _hucreRowCount = maxYukseklik;
                _hucreColCount = c;


                GridOran.CreateGridRowsColoums(1, _hucreColCount, _width, _height);
                GridHucre.CreateGridRowsColoums(_hucreRowCount, _hucreColCount, _width, _height);

                CreateHucre();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Init\n" + ex.Message);
            }
        }

        private void CreateHucre()
        {
            try
            {
                int counter = 0;
                for (int i = 0; i < _hucreColCount; i++)
                {
                    int oranCounter = 0;
                    double toplam = 0;
                    double Or = 0;

                    int yukseklikControl = _hucreRowCount;

                    for (int j = 0; j < _hucreRowCount; j++)
                    {
                        

                        Label lblHucre = new Label();

                        DataRow row = _dt.Rows[counter];
                        int yukseklik = row["Yukseklik"].ToInt();

                        if (yukseklikControl!=yukseklik)
                        {
                            yukseklikControl--;
                            continue;
                        }
                        yukseklikControl--;
                        string adres = row["Adres"].ToString();
                        int tip = row["Tip"].ToInt();
                        string tipIsim = row["TipIsim"].ToString();
                        Guid id = new Guid(row["AdresId"].ToString());
                        Guid ulId = new Guid(row["RafId"].ToString());
                       
                        string koy = row["Koy"].ToString();
                        int sira = row["Sira"].ToInt();
                        string raf = row["Raf"].ToString();
                        double oran = Convert.ToDouble(row["Oran"].ToString());

                        HucreModel hm = new HucreModel(_katId,_depoId, id, ulId, adres, koy, sira, yukseklik, raf, oran, tip, tipIsim);

                       
                        lblHucre.Tag = hm;
                       
                        lblHucre.CreateLabel(j, i, _width, _height);
                        lblHucre.FontSize = 12;
                        if (tip == 100)
                        {
                            lblHucre.Background = Brushes.Transparent;
                            lblHucre.Content = "";
                        }
                        else if (tip == 255)
                        {
                            lblHucre.Background = Brushes.Black;
                            lblHucre.Content = "K";
                            lblHucre.Foreground = Brushes.White;
                        }
                        else
                        {
                            lblHucre.MouseDoubleClick += delegate (object sender, MouseButtonEventArgs e) { UlOperation.HucreClick(sender, e, hm, oran); };
                            lblHucre.Background = UlOperation.GetScaleColor(oran);
                            lblHucre.Content = "%" +Math.Round( oran,1).ToString();
                            if (oran > 80)
                                lblHucre.Foreground = Brushes.White;
                            else
                                lblHucre.Foreground = Brushes.Black;

                            oranCounter++;
                            toplam += oran;
                        }

                        GridHucre.Children.Add(lblHucre);

                        counter++;
                    }
                    if (oranCounter > 0)
                        Or = (double)toplam / oranCounter;
                    else
                        Or = -1;
                    Label lblOran = new Label();
                    lblOran.CreateLabel(0, i, _width, _height);
                    lblOran.FontSize = 12;

                    if (Or == -1)
                    {
                        lblOran.Content = " ";
                        lblOran.Background = Brushes.DarkGray;
                    }

                    else
                    {
                        lblOran.Content = "%" + Math.Round( Or,1).ToString();
                        lblOran.Background = UlOperation.GetScaleColor(Or);

                    }
                    if (Or > 80)
                        lblOran.Foreground = Brushes.White;
                    else
                        lblOran.Foreground = Brushes.Black;

                    Grid.SetRow(lblOran, 0);
                    Grid.SetColumn(lblOran, i);
                    GridOran.Children.Add(lblOran);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateHucre\n" + ex.Message);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
          //      this.Close();
            }
        }

        public void CreateColorScale()
        {
            try
            {

                GridColor = UlOperation.CreateColorsGrid(MainGrid, 2, 0, 1, 1);
                Grid.SetColumn(GridColor, 0);
                Grid.SetRow(GridColor, 2);
                MainGrid.Children.Add(GridColor);

                if (_hucreColCount * _width < this.Width)
                {
                    GrBox.Width = this.Width;
                    GridHucre.HorizontalAlignment = HorizontalAlignment.Center;
                    GridOran.HorizontalAlignment = HorizontalAlignment.Center;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CreateColorScale\n" + ex.Message);
            }

        }

        private List<int> SelectTips()
        {
            try
            {
                List<int> list = new List<int>();

                int tipVal = -1;
                List<int> listControl = new List<int>
                {
                    tipVal
                };
                foreach (DataRow row in _dt.Rows)
                {
                    int tip = row["Tip"].ToString().ToInt();
                    if (!listControl.Contains(tip) && tip != 100 && tip != 255)
                    {
                        list.Add(tip);
                        listControl.Add(tip);
                    }
                }

                return list;
            }
            catch (Exception ex)
            {

                MessageBox.Show("SelectTips\n" + ex.Message);
                return null;
            }
        }

        private List<IEnumerable<DataRow>> ClassifyingTips(List<int> tipList)
        {
            try
            {

                List<IEnumerable<DataRow>> rows = new List<IEnumerable<DataRow>>();
                for (int i = 0; i < tipList.Count; i++)
                {
                    var datas = _dt.Select("Tip=" + tipList[i]);

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

        public void CreateTipGrid()
        {
            try
            {
                CreateTipGridRowsAndColumns(_rows.Count);
                Label lblOrtalama = new Label
                {
                    Background = Brushes.Wheat
                };
                lblOrtalama.CreateLabel("Ortalama", 0, 14, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lblOrtalama);

                Label lblToplam = new Label
                {
                    Background = Brushes.Wheat
                };
                lblToplam.CreateLabel("Toplam", 0, 13, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lblToplam);

                for (int i = 0; i < _rows.Count; i++)
                {
                    DataRow[] rowArray = (DataRow[])_rows[i];
                    string tipIsim = rowArray[0]["TipIsim"].ToString();
                    CreateTipColorsLabels(rowArray, tipIsim, i);
                }

                CreateGenelToplamLabels(_rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateTipGrid\n" + ex.Message);
            }


        }

        private void CreateTipGridRowsAndColumns(int rowCount)
        {
            try
            {
                MainGrid.GetColAndRowSize(out int colWidth, out int rowHeight, 0, 0);
                _tipLabelHeight = rowHeight/(rowCount+2);
                _tipLabelWidth = colWidth/15;
                GridTip.CreateGridRowsColoums(rowCount + 2, 15, _tipLabelWidth, _tipLabelHeight);
            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateTipGridRowsAndColumns\n"+ex.Message);
            }

        }

        private void CreateTipColorsLabels(DataRow[] rows, string tipIsim, int gridRowIndex)
        {
            try
            {
                Label lblTipIsim = new Label
                {
                    Background = Brushes.WhiteSmoke
                };
                lblTipIsim.CreateLabel(tipIsim, gridRowIndex + 1, 0, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lblTipIsim);

                Label lblOrtalamaSonuc = new Label();
                lblOrtalamaSonuc.CreateLabel(gridRowIndex + 1, 14, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lblOrtalamaSonuc);

                Label lbl_bos = new Label { Background = UlOperation.GetScaleColor(0) };
                Label lbl_asiriYuklu = new Label() { Background = UlOperation.GetScaleColor(110) , Foreground = Brushes.White };
                Label lbl_0_10 = new Label() { Background = UlOperation.GetScaleColor(5) };
                Label lbl_10_20 = new Label() { Background = UlOperation.GetScaleColor(15) };
                Label lbl_20_30 = new Label() { Background = UlOperation.GetScaleColor(25) };
                Label lbl_30_40 = new Label() { Background = UlOperation.GetScaleColor(35) };
                Label lbl_40_50 = new Label() { Background = UlOperation.GetScaleColor(45) };
                Label lbl_50_60 = new Label() { Background = UlOperation.GetScaleColor(55) };
                Label lbl_60_70 = new Label() { Background = UlOperation.GetScaleColor(66) };
                Label lbl_70_80 = new Label() { Background = UlOperation.GetScaleColor(77)};
                Label lbl_80_90 = new Label() { Background = UlOperation.GetScaleColor(88), Foreground = Brushes.White };
                Label lbl_90_100 = new Label() { Background = UlOperation.GetScaleColor(99), Foreground = Brushes.White };
                Label lbl_toplam = new Label() { Background = Brushes.Wheat };
                int bos = 0;
                int asiriYuklu = 0;
                int c0_10 = 0;
                int c10_20 = 0;
                int c20_30 = 0;
                int c30_40 = 0;
                int c40_50 = 0;
                int c50_60 = 0;
                int c60_70 = 0;
                int c70_80 = 0;
                int c80_90 = 0;
                int c90_100 = 0;

                int counter = 0;
                double toplam = 0;
                double ortalama = 0;
                for (int i = 0; i < rows.Length; i++)
                {
                    double oran = rows[i]["oran"].To<double>();
                    if (oran == 0)
                        bos++;
                    else if (oran > 100)
                        asiriYuklu++;
                    else if (oran > 0 && oran <= 10)
                        c0_10++;
                    else if (oran > 10 && oran <= 20)
                        c10_20++;
                    else if (oran > 20 && oran <= 30)
                        c20_30++;
                    else if (oran > 30 && oran <= 40)
                        c30_40++;
                    else if (oran > 40 && oran <= 50)
                        c40_50++;
                    else if (oran > 50 && oran <= 60)
                        c50_60++;
                    else if (oran > 60 && oran <= 70)
                        c60_70++;
                    else if (oran > 70 && oran <= 80)
                        c70_80++;
                    else if (oran > 80 && oran <= 90)
                        c80_90++;
                    else if (oran > 90 && oran <= 100)
                        c90_100++;
                    else
                        throw new Exception("Geçersiz Oran Değeri");

                    counter++;
                    toplam += oran;
                }

                _bos += bos;
                _asiriYuklu += asiriYuklu;
                _c0_10 += c0_10;
                _c10_20 += c10_20;
                _c20_30 += c20_30;
                _c30_40 += c30_40;
                _c40_50 += c40_50;
                _c50_60 += c50_60;
                _c60_70 += c60_70;
                _c70_80 += c70_80;
                _c80_90 += c80_90;
                _c90_100 += c90_100;

                ortalama = toplam / counter;
                _counter += counter;

                

                lblOrtalamaSonuc.Background = UlOperation.GetScaleColor(ortalama);
                lblOrtalamaSonuc.Content ="% "+ Math.Round( ortalama,1).ToString();

                lbl_toplam.CreateLabel(counter.ToString(), gridRowIndex + 1, 13, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_toplam);

                lbl_bos.CreateLabel(bos.ToString(), gridRowIndex + 1, 1, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_bos);

                lbl_asiriYuklu.CreateLabel(asiriYuklu.ToString(), gridRowIndex + 1, 12, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_asiriYuklu);

                lbl_0_10.CreateLabel(c0_10.ToString(), gridRowIndex + 1, 2, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_0_10);

                lbl_10_20.CreateLabel(c10_20.ToString(), gridRowIndex + 1, 3, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_10_20);

                lbl_20_30.CreateLabel(c20_30.ToString(), gridRowIndex + 1, 4, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_20_30);

                lbl_30_40.CreateLabel(c30_40.ToString(), gridRowIndex + 1, 5, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_30_40);

                lbl_40_50.CreateLabel(c40_50.ToString(), gridRowIndex + 1, 6, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_40_50);

                lbl_50_60.CreateLabel(c50_60.ToString(), gridRowIndex + 1, 7, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_50_60);

                lbl_60_70.CreateLabel(c60_70.ToString(), gridRowIndex + 1, 8, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_60_70);

                lbl_70_80.CreateLabel(c70_80.ToString(), gridRowIndex + 1, 9, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_70_80);

                lbl_80_90.CreateLabel(c80_90.ToString(), gridRowIndex + 1, 10, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_80_90);

                lbl_90_100.CreateLabel(c90_100.ToString(), gridRowIndex + 1, 11, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_90_100);

            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateTipColorsLabels\n"+ex.Message);
            }


        }

        private void CreateGenelToplamLabels(int rowCount)
        {
            try
            {
                Label lblGenelToplam = new Label{ Background = Brushes.Wheat };
                lblGenelToplam.CreateLabel("Genel Toplam", rowCount + 1, 0, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lblGenelToplam);

                Label lblToplam= new Label { Background = Brushes.Wheat };
                lblToplam.CreateLabel(_counter.ToString(), rowCount + 1, 13, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lblToplam);

                Label lblGenelOrtalama = new Label { Background = UlOperation.GetScaleColor(_genelOrtalama) };
                lblGenelOrtalama.CreateLabel("% "+_genelOrtalama.ToString(), rowCount + 1, 14, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lblGenelOrtalama);

                Label lbl_bos = new Label { Background = UlOperation.GetScaleColor(0) };
                lbl_bos.CreateLabel(_bos.ToString(), rowCount + 1, 1, _tipLabelWidth, _tipLabelWidth);
                GridTip.Children.Add(lbl_bos);

                Label lbl_asiriYuklu = new Label() { Background = UlOperation.GetScaleColor(110), Foreground = Brushes.White };
                lbl_asiriYuklu.CreateLabel(_asiriYuklu.ToString(), rowCount + 1, 12, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_asiriYuklu);

                Label lbl_0_10 = new Label() { Background = UlOperation.GetScaleColor(5) };
                lbl_0_10.CreateLabel(_c0_10.ToString(), rowCount + 1, 2, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_0_10);

                Label lbl_10_20 = new Label() { Background = UlOperation.GetScaleColor(11) };
                lbl_10_20.CreateLabel(_c10_20.ToString(), rowCount + 1, 3, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_10_20);

                Label lbl_20_30 = new Label() { Background = UlOperation.GetScaleColor(22) };
                lbl_20_30.CreateLabel(_c20_30.ToString(), rowCount + 1, 4, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_20_30);

                Label lbl_30_40 = new Label() { Background = UlOperation.GetScaleColor(33) };
                lbl_30_40.CreateLabel(_c30_40.ToString(), rowCount + 1, 5, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_30_40);

                Label lbl_40_50 = new Label() { Background = UlOperation.GetScaleColor(44) };
                lbl_40_50.CreateLabel(_c40_50.ToString(), rowCount + 1, 6, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_40_50);

                Label lbl_50_60 = new Label() { Background = UlOperation.GetScaleColor(55) };
                lbl_50_60.CreateLabel(_c50_60.ToString(), rowCount + 1, 7, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_50_60);

                Label lbl_60_70 = new Label() { Background = UlOperation.GetScaleColor(66) };
                lbl_60_70.CreateLabel(_c60_70.ToString(), rowCount + 1, 8, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_60_70);

                Label lbl_70_80 = new Label() { Background = UlOperation.GetScaleColor(77)};
                lbl_70_80.CreateLabel(_c70_80.ToString(), rowCount + 1, 9, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_70_80);

                Label lbl_80_90 = new Label() { Background = UlOperation.GetScaleColor(88), Foreground = Brushes.White };
                lbl_80_90.CreateLabel(_c80_90.ToString(), rowCount + 1, 10, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_80_90);

                Label lbl_90_100 = new Label() { Background = UlOperation.GetScaleColor(99),Foreground=Brushes.White };
                lbl_90_100.CreateLabel(_c90_100.ToString(), rowCount + 1, 11, _tipLabelWidth, _tipLabelHeight);
                GridTip.Children.Add(lbl_90_100);
            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateGenelToplamLabels\n"+ex.Message);
            }
        }
    }
}
