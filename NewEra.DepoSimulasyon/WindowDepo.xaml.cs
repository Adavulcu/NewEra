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
namespace NewEra.DepoSimulasyon
{
    /// <summary>
    /// Interaction logic for WindowDepo.xaml
    /// </summary>
    public partial class WindowDepo : Window
    {
        #region VariableRegion
        RafModel _raf;
        int _x;
        int _y;
        string _rafAdi;
        private int _width;
        private int _height;
        Label _lbl;
        Brush _fullColor;
        Brush _emptyColor;
        Brush _borderFullColor;
        Brush _borderEmptyColor;
        Grid _gridOran, _gridHucre;

        #endregion
        public WindowDepo()
        {
            InitializeComponent();
           
        }

       

        private void InitElements()
        {
            try
            {
                _raf = new RafModel(_rafAdi, _x, _y);
                _gridHucre.BeginInit();
                _width = 50;
                _height = 50;
                CreateKoy();
                _gridHucre.EndInit();
                CreateOran();
            }
            catch (Exception ex)
            {

                MessageBox.Show("InitElements\n"+ex.Message);
            }
        }

        public void Init(string rafAdi, int x, int y)
        {
            try
            {
              
               
                _gridHucre = GridHucre;
                _gridOran = GridOran;
                _rafAdi = rafAdi;
                _x = x;
                _y = y;
                this.WindowState = WindowState.Maximized;
                _fullColor = Brushes.LightGreen;
                _emptyColor = Brushes.DimGray;
                _borderEmptyColor = Brushes.White;
                _borderFullColor = Brushes.Black;
                InitElements();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Init\n" + ex.Message);
            }
        }


        private void CreateKoy()
        {
            try
            {
                _gridHucre.CreateGridRowsColoums(_raf.RafX, _raf.RafY, _width, _height);
                for (int i = 0; i < _raf.RafX; i++)
                {
                    for (int j = 0; j < _raf.RafY; j++)
                    {
                        _lbl = new Label();
                        _lbl.CreateLabel(i, j,_width, _height, _raf.Koy[i, j]);
                        _lbl.BorderThickness = new Thickness(0.3, 0.3, 0.3, 0.3);
                        if (_raf.Koy[i,j].State)
                        {
                            _lbl.Background = _fullColor;
                           
                            _lbl.BorderBrush = Brushes.Black;
                        }
                        else
                        {
                            _lbl.Background = _emptyColor;
                            _lbl.BorderBrush = Brushes.White;
                        }
                        _lbl.MouseLeftButtonDown += Label_Click;
                        _gridHucre.Children.Add(_lbl);
                       
                    }
                }
            }
            catch (Exception ex)
            {

              MessageBox.Show("CreateKoy\n"+ex.Message);
            }
        }

        private void Label_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;

                string[] str;
                str = lbl.Name.SplitLabelName();
                int i = Convert.ToInt32(str[3]);
                int j = Convert.ToInt32(str[4]);
                string s = String.Format("KAT : {0} , Koy: {1}", i.ToString(), j.ToString());
                MessageBox.Show(s);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Label_Click\n"+ex.Message);
            }
        }

        private void CreateOran()
        {
            try
            {
                _gridOran.CreateGridRowsColoums(0, _raf.RafY, _width, _height);

                for (int i = 0; i < _raf.RafY; i++)
                {
                    _lbl = new Label();
                    int oran = _gridHucre.GetLabelOran(i);
                    _lbl.CreateLabel("% "+oran.ToString(),0, i, _width, _height);
                    _lbl.BorderThickness = new Thickness(0.3, 0.3, 0.3, 0.3);
                    _lbl.Background = Brushes.CornflowerBlue;
                    _lbl.BorderBrush = Brushes.White;
                    _gridOran.Children.Add(_lbl);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateOran\n"+ex.Message);
            }
        }

       

      

    }
}
