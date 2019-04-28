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
using NewEra.DepoSimulasyon.Models;
namespace NewEra.DepoSimulasyon
{
    /// <summary>
    /// Interaction logic for WindowRafGenelDurum.xaml
    /// </summary>
    public partial class WindowRafGenelDurum : Window
    {
        Data _data;
        DataTable _rafGenelBilgi;
        string _rafIsim;
        public WindowRafGenelDurum()
        {
            InitializeComponent();
            
        }
        KatDetayModel _kdm;
        double _oran;
        int _toplam = 0;
        public void Init(KatDetayModel kdm,double oran)
        {
            try
            {
                _oran = oran;
                _kdm = kdm;
                _rafIsim = kdm.Name;
                _rafGenelBilgi = new DataTable();
                _data = new Data();
                this.Title = "RAF -" + kdm.Name;
                LblRafGenelDurum.Content = "RAF - " + kdm.Name + " = % " + Math.Round(oran,1) + "";
                LblRafGenelDurum.Background = UlOperation.GetScaleColor(oran);

                _rafGenelBilgi = _data.RafGenelBilgiGetir(kdm);
                SetOranLabelsValues(_rafGenelBilgi);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Init\n"+ex.Message);
            }
        }

        private void BtnRafDetay_Click(object sender, RoutedEventArgs e)
        {
            //WindowDepo wd = new WindowDepo();
            //wd.Init("RAF A", 50, 7);
            //wd.ShowDialog();

            WindowRafDetay wrd = new WindowRafDetay();
            wrd.Init( _rafGenelBilgi,_kdm.KatId,_kdm.DepoId, _rafIsim,_oran);
            wrd.Show();
            wrd.CreateColorScale();
            wrd.CreateTipGrid();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Escape)
            {
                this.Close();
            }
        }

        private void SetOranLabelsValues(DataTable dt)
        {
            try
            {
                int bos = 0;
                int asiriYuklu = 0;
                int tunel = 0;
                int kullanilmaz = 0;
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

                foreach (DataRow row in dt.Rows)
                {
                    _toplam++;
                    int tip = row["Tip"].ToInt();
                    double oran = row["oran"].To<double>();
                    if (tip == 100)
                    {
                        tunel++;
                    }
                    else if (tip == 255)
                        kullanilmaz++;
                    else
                    {
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

                    }
                    
                }

                lblBos.Content = bos.ToString() + " ADET";
                lblOverloaded.Content = asiriYuklu.ToString() + " ADET";
                lblTunnel.Content = tunel.ToString() + " ADET";
                lblUnUsing.Content = kullanilmaz.ToString() + " ADET";
                lbl_0_10.Content = c0_10.ToString() + " ADET";
                lbl_10_20.Content = c10_20.ToString() + " ADET";
                lbl_20_30.Content = c20_30.ToString() + " ADET";
                lbl_30_40.Content = c30_40.ToString() + " ADET";
                lbl_40_50.Content = c40_50.ToString() + " ADET";
                lbl_50_60.Content = c50_60.ToString() + " ADET";
                lbl_60_70.Content = c60_70.ToString() + " ADET";
                lbl_70_80.Content = c70_80.ToString() + " ADET";
                lbl_80_90.Content = c80_90.ToString() + " ADET";
                lbl_90_100.Content = c90_100.ToString() + " ADET";
                lblToplam.Content = _toplam.ToString() + " ADET";
            }
            catch (Exception ex)
            {

                MessageBox.Show("SetOranLabelsValues\n"+ex.Message);
            }
        }
    }
}
