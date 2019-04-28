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
using NewEra.DepoSimulasyon;

namespace NewEraDepoTemplateCreater
{
    /// <summary>
    /// Interaction logic for WindowTemplate.xaml
    /// </summary>
    public partial class WindowTemplate : Window
    {
        private class PathIndex
        {
            public int X { get; set; }
            public int Y { get; set; }
            public PathIndex() { }
            public List<Label> ValidPathLabels { get; set; }
            public PathIndex(int x, int y, List<Label> labels) { X = x; Y = y; ValidPathLabels = labels; }
        }

        private SolidColorBrush _SelectedColor;
        private LabelTip _SelectedTip;
        private int _X, _Y;
        private Boolean _GridBoyutFlag;

        private List<Label> _SelectedLabels;
        private List<RafModel> _Raflar;
        private RafModel _CurrentRaf;
        private List<Label> _PathLabels;
        private int _PathLabelsIndexCounter = 0;
        private Queue<PathIndex> _ValidPaths;
        public Grid _GridOuter;
        public Grid _GridScaleLeft;
        public Grid _GridScaleTop;
        public Grid _GridScaleRight;
        public Grid _GridScaleBottom;
        public Grid _GridTemplate;
        public ComboBox _CbRaf;

        public const int _StandartSize = 20;
        public int _Size = 20;

        private bool _KeyState;

        public SolidColorBrush _DefaultColor;

        private void InitGrids()
        {


            _GridOuter = new Grid();
            _GridScaleBottom = new Grid();
            _GridScaleLeft = new Grid();
            _GridScaleRight = new Grid();
            _GridScaleTop = new Grid();
            _GridTemplate = new Grid();

        }

        public WindowTemplate()
        {
            InitializeComponent();
            _CbRaf = CbRaf;
            _SelectedTip = LabelTip.Default;
            _CurrentRaf = new RafModel();
            _Raflar = new List<RafModel>();
         
            if (_CbRaf.Items.Count == 0)
            {
                RbtnRaf.Visibility = Visibility.Hidden;
                LblRenkRaf.Visibility = Visibility.Hidden;
            }
            else
            {
                RbtnRaf.Visibility = Visibility.Visible;
                LblRenkRaf.Visibility = Visibility.Visible;
            }
            _ValidPaths = new Queue<PathIndex>();
            Color c = ((SolidColorBrush)LblRenkDefault.Background).Color;
            _SelectedColor = new SolidColorBrush(c);
            _DefaultColor = Brushes.WhiteSmoke;
            _PathLabels = new List<Label>();
            _SelectedLabels = new List<Label>();

            InitGrids();
            //this.MouseLeftButtonDown += WindowClick;
            //_GridOuter.MouseLeftButtonDown += WindowClick;
        }

        private void WindowClick(object sender, MouseButtonEventArgs e)
        {
            MyPopUp.IsOpen = false;
        }

        private void BtnGridOlusturDegistir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowGridBoyut wgb = new WindowGridBoyut();
                string[] str = SplitX_Y();

                int x = str[0].ToInt();
                int y = str[1].ToInt();
                wgb.Init(x, y);

                wgb.ShowDialog();
                _X = wgb._X;
                _Y = wgb._Y;
                _GridBoyutFlag = wgb._Flag;
                CreateGrids();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnGridOlusturDegistir_Click\n" + ex.Message);
            }
        }

        private async void CreateGrids()
        {
            try
            {


                InitGrids();
                this.Cursor = Cursors.Wait;
                Boolean result1 = await Task.Run(() => CreateOuterAndScaleGrids());
                Boolean result2 = await Task.Run(() => CreateTemplateGrid());
                this.Cursor = Cursors.Arrow;

                if (!result1 || !result2)
                    MessageBox.Show("GRİDLER OLUŞTURULURKEN BİR HATA OLUŞTU!", "OOOPS!", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {

                    SW.Content = _GridOuter;
                    _GridOuter.Children.Add(_GridScaleTop);
                    _GridOuter.Children.Add(_GridScaleRight);
                    _GridOuter.Children.Add(_GridScaleLeft);
                    _GridOuter.Children.Add(_GridScaleBottom);
                    _GridOuter.Children.Add(_GridTemplate);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("CreateGrids\n" + ex.Message);
            }
        }

        private Task<Boolean> CreateOuterAndScaleGrids()
        {
            try
            {
                return Task.Run<Boolean>(() =>
                    {
                        this.Dispatcher.Invoke((Action)(() =>
                    {
                        RowDefinition row = new RowDefinition() { Height = new GridLength(_Size) };
                        _GridOuter.RowDefinitions.Add(row);
                        row = new RowDefinition() { Height = new GridLength(_Size * _Y) };
                        _GridOuter.RowDefinitions.Add(row);
                        row = new RowDefinition() { Height = new GridLength(_Size) };
                        _GridOuter.RowDefinitions.Add(row);

                        ColumnDefinition col = new ColumnDefinition() { Width = new GridLength(_Size) };
                        _GridOuter.ColumnDefinitions.Add(col);
                        col = new ColumnDefinition() { Width = new GridLength(_Size * _X) };
                        _GridOuter.ColumnDefinitions.Add(col);
                        col = new ColumnDefinition() { Width = new GridLength(_Size) };
                        _GridOuter.ColumnDefinitions.Add(col);

                        UlOperation.SetGridIndex(_GridOuter, 1, 0);
                        _GridOuter.VerticalAlignment = VerticalAlignment.Center;
                        _GridOuter.HorizontalAlignment = HorizontalAlignment.Center;


                        _GridScaleRight.BeginInit();
                        _GridScaleRight.CreateGridRowsColoums(_Y, 1, _Size, _Size);
                        UlOperation.SetGridIndex(_GridScaleRight, 1, 2);
                        CreateScaleGridLabels(_GridScaleRight, _Y, true);
                        _GridScaleRight.EndInit();

                        _GridScaleLeft.BeginInit();
                        _GridScaleLeft.CreateGridRowsColoums(_Y, 1, _Size, _Size);
                        UlOperation.SetGridIndex(_GridScaleLeft, 1, 0);
                        CreateScaleGridLabels(_GridScaleLeft, _Y, true);
                        _GridScaleLeft.EndInit();

                        _GridScaleTop.BeginInit();
                        _GridScaleTop.CreateGridRowsColoums(1, _X, _Size, _Size);
                        UlOperation.SetGridIndex(_GridScaleTop, 0, 1);
                        CreateScaleGridLabels(_GridScaleTop, _X, false);
                        _GridScaleTop.EndInit();


                        _GridScaleBottom.BeginInit();
                        _GridScaleBottom.CreateGridRowsColoums(1, _X, _Size, _Size);
                        UlOperation.SetGridIndex(_GridScaleBottom, 2, 1);
                        CreateScaleGridLabels(_GridScaleBottom, _X, false);
                        _GridScaleBottom.EndInit();


                    }
                    ));
                        return true;
                    });
            }
            catch (Exception ex)
            {

                //MessageBox.Show("CreateOuterAndScaleGrids\n"+ex.Message);
                return Task.Run<Boolean>(() => { return false; });
            }
        }

        private Task<Boolean> CreateTemplateGrid()
        {
            try
            {
                return Task.Run<Boolean>(() =>
                {
                    this.Dispatcher.Invoke((Action)(() =>
                    {

                        _GridTemplate.CreateGridRowsColoums(_Y, _X, _Size, _Size);
                        UlOperation.SetGridIndex(_GridTemplate, 1, 1);
                        for (int i = 0; i < _X; i++)
                        {
                            for (int j = 0; j < _Y; j++)
                            {
                                LabelModel lm = new LabelModel(i, j, LabelTip.Sil);
                                Label lbl = new Label();
                                lbl.CreateLabel(j, i, _Size, _Size);
                                lbl.Background = Brushes.WhiteSmoke;
                                lbl.Tag = lm;
                                lbl.BorderBrush = Brushes.Black;
                                lbl.Margin = new Thickness(0);
                                lbl.BorderThickness = new Thickness(0.5);
                                _GridTemplate.Children.Add(lbl);
                                lbl.MouseLeftButtonDown += Lbl_Click;
                                lbl.MouseRightButtonDown += lblRight_Click;
                                
                            }
                        }

                    }
                ));
                    return true;
                });
            }
            catch (Exception ex)
            {

                // MessageBox.Show("CreateTemplateGrid\n" + ex.Message);
                return Task.Run<Boolean>(() => { return false; });
            }
        }

        private void lblRight_Click(object sender, MouseButtonEventArgs e)
        {
            Label lbl = (Label)sender;
            LabelModel lm = (LabelModel)lbl.Tag;
            if (!_KeyState)
            {
                MyPopUp.IsOpen = true;
                PopLblRafAd.Content = lm.Adres;
                PopLblRafSiraAdet.Content = lm.Tip.ToString();
            }
            else
            {
                //List<Label> list = new List<Label>();
                //foreach (Label label in _GridTemplate.Children)
                //{
                //    if (lm.Tip== ((LabelModel)label.Tag).Tip)
                //    {
                //        label.BorderThickness = new Thickness(3);
                //        list.Add(label);
                //    }
                //}

              

                //System.Threading.Thread.Sleep(3000);
                //for (int i = 0; i < list.Count; i++)
                //{
                //    list[i].BorderThickness = new Thickness(0.5);
                //}
            }
        }



        private void Lbl_Click(object sender, MouseButtonEventArgs e)
        {
            Label lbl = (Label)sender;
            LabelModel lm = (LabelModel)lbl.Tag;
            LabelTip tip = lm.Tip;
            if (_SelectedTip == LabelTip.Tunel && tip != LabelTip.Raf)
            {
                return;
            }
            if (_SelectedTip == LabelTip.Tunel && tip == LabelTip.Raf)
            {
                lm = new LabelModel(lm.Col, lm.Row, LabelTip.Raf, lm.RafId, lm.RafAd,lm.Alias);
            }
          

            lbl.Tag = lm;
            PathIndex pathIndex = new PathIndex();
            if (tip == _SelectedTip)
            {
                if (_KeyState)
                {
                    if (_SelectedTip == LabelTip.Raf)
                    {
                        lm = new LabelModel(lm.Col, lm.Row, _SelectedTip, _CurrentRaf.Id, _CurrentRaf.Name, _CurrentRaf.Alias);
                    }

                    else
                        lm = new LabelModel(lm.Col, lm.Row, _SelectedTip);

                    if (_ValidPaths.Count == 0)
                    {

                        lbl.BorderThickness = new Thickness(3);
                        _SelectedLabels.Add(lbl);
                        pathIndex = new PathIndex(lm.Col, lm.Row, SetValidPath(lm.Col, lm.Row));
                        _ValidPaths.Enqueue(pathIndex);
                        _PathLabelsIndexCounter++;
                    }
                    else
                    {
                        if (IsInValidPath(lm.Col, lm.Row))
                        {
                            lbl.BorderThickness = new Thickness(3);
                            _SelectedLabels.Add(lbl);

                            pathIndex = new PathIndex(lm.Col, lm.Row, SetValidPath(lm.Col, lm.Row));
                            _ValidPaths.Enqueue(pathIndex);
                            SetValidPathIndexLabelsToDefault();
                            SetPathLabels();
                            _PathLabelsIndexCounter++;
                        }
                        else
                            return;
                    }
                    if (RbtnRaf.IsChecked == true)
                    {
                        _CurrentRaf.Coordinats.Add((LabelModel)lbl.Tag);
                    }
                     lbl.Tag = lm;
                }
                else
                {
                    lbl.Background = _DefaultColor;
                    lbl.Content = "";
                    lm = new LabelModel(lm.Col, lm.Row, LabelTip.Sil);
                    lbl.Tag = lm;
                    lbl.BorderBrush = Brushes.Black;
                    lbl.BorderThickness = new Thickness(0.5);

                }

            }
            else
            {
                if (_SelectedTip == LabelTip.Raf)
                {
                    lm = new LabelModel(lm.Col, lm.Row, _SelectedTip, _CurrentRaf.Id, _CurrentRaf.Name, _CurrentRaf.Alias);
                }

                else
                    lm = new LabelModel(lm.Col, lm.Row, _SelectedTip);

                if (_KeyState)
                {
                   
                    if (_ValidPaths.Count == 0)
                    {

                        lbl.BorderThickness = new Thickness(3);
                        _SelectedLabels.Add(lbl);

                        pathIndex = new PathIndex(lm.Col, lm.Row, SetValidPath(lm.Col, lm.Row));
                        _ValidPaths.Enqueue(pathIndex);
                        lbl.Background = _SelectedColor;
                        lbl.BorderBrush = _SelectedColor.InvertSoldibrushes();
                        _PathLabelsIndexCounter++;
                    }
                    else
                    {
                        if (IsInValidPath(lm.Col, lm.Row))
                        {
                            lbl.BorderThickness = new Thickness(3);
                            _SelectedLabels.Add(lbl);

                            pathIndex = new PathIndex(lm.Col, lm.Row, SetValidPath(lm.Col, lm.Row));
                            _ValidPaths.Enqueue(pathIndex);
                            SetValidPathIndexLabelsToDefault();
                            lbl.Background = _SelectedColor;
                            lbl.BorderBrush = _SelectedColor.InvertSoldibrushes();
                            SetPathLabels();
                            _PathLabelsIndexCounter++;
                        }
                        else
                            return;
                    }
                    lbl.Tag = lm;
                }
                else
                {


                    lbl.Background = _SelectedColor;
                    lbl.BorderBrush = _SelectedColor.InvertSoldibrushes();
                    lbl.Tag = lm;
                }
                if (RbtnRaf.IsChecked == true)
                {
                    _CurrentRaf.Coordinats.Add((LabelModel)lbl.Tag);
                    lbl.FontSize = _Size * 0.4;
                    lbl.Content = lm.Alias;
                }
            }

        }

        private void CreateScaleGridLabels(Grid grid, int count, bool IsVertical)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    Label lbl = new Label();
                    if (IsVertical)
                    {
                        lbl.CreateLabel(i.ToString(), i, 0, _Size, _Size);

                    }
                    else
                    {
                        lbl.CreateLabel(i.ToString(), 0, i, _Size, _Size);
                    }
                    lbl.FontSize = 8;
                    lbl.Background = Brushes.LightGray;
                    grid.Children.Add(lbl);
                }



            }
                ));
        }



        private void Rbtn_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                RadioButton rb = (RadioButton)sender;
                Color c = new Color();
                switch (rb.Name)
                {
                    case "RbtnDuvar":
                        c = ((SolidColorBrush)LblRenkDuvar.Background).Color;
                        _SelectedColor = new SolidColorBrush(c);
                        _SelectedTip = LabelTip.Duvar;
                        break;
                    case "RbtnAlan":
                        c = ((SolidColorBrush)LblRenkAlan.Background).Color;
                        _SelectedColor = new SolidColorBrush(c);
                        _SelectedTip = LabelTip.Alan;
                        break;
                    case "RbtnTunel":
                        c = ((SolidColorBrush)LblRenkTunel.Background).Color;
                        _SelectedColor = new SolidColorBrush(c);
                        _SelectedTip = LabelTip.Tunel;
                        break;
                    case "RbtnRaf":
                        c = ((SolidColorBrush)LblRenkRaf.Background).Color;
                        _SelectedColor = new SolidColorBrush(c);
                        _SelectedTip = LabelTip.Raf;
                        break;
                    case "RbtnDefault":
                        c = ((SolidColorBrush)LblRenkDefault.Background).Color;
                        _SelectedColor = new SolidColorBrush(c);
                        _SelectedTip = LabelTip.Default;
                        break;
                    case "RbtnSil":
                        _SelectedColor = _DefaultColor;
                        _SelectedTip = LabelTip.Sil;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Rbtn_Checked\n" + ex.Message);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl)// && (e.KeyStates == KeyStates.Down || e.KeyStates==KeyStates.Toggled))
            {
                _KeyState = true;
            }

        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl)
            {
                _KeyState = false;

                for (int i = 0; i < _SelectedLabels.Count; i++)
                {
                    _SelectedLabels[i].BorderThickness = new Thickness(0.5);
                }

                SetValidPathIndexLabelsToDefault();

                SetLabelInPath();
                _PathLabelsIndexCounter = 0;
                _SelectedLabels = null;
                _SelectedLabels = new List<Label>();

            }
        }

        private void LblRenk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Label lbl = (Label)sender;

            switch (lbl.Name)
            {
                case "LblRenkDuvar":
                    RbtnDuvar.IsChecked = true;
                    break;
                case "LblRenkAlan":
                    RbtnAlan.IsChecked = true;
                    break;
                case "LblRenkRaf":
                    RbtnRaf.IsChecked = true;
                    break;
                case "LblRenkTunel":
                    RbtnTunel.IsChecked = true;
                    break;
                case "LblRenkDefault":
                    RbtnDefault.IsChecked = true;
                    break;
                case "LblRenkSil":
                    RbtnSil.IsChecked = true;
                    break;
                default:
                    break;
            }
        }

        private void SetValidPathIndexLabelsToDefault()
        {
            try
            {
                if (_ValidPaths.Count != 0)
                {
                    PathIndex p = _ValidPaths.Dequeue();
                    for (int i = 0; i < p.ValidPathLabels.Count; i++)
                    {
                        p.ValidPathLabels[i].BorderThickness = new Thickness(0.5);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("SetValidPathIndexLabelsToDefault\n" + ex.Message);
            }
        }

        private string[] SplitX_Y()
        {
            char[] c = { '-' };
            string[] s = (LblXY.Content.ToString()).Split(c);
            string str1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                str1 += s[i];

            }

            return s;
        }

        private List<Label> SetValidPath(int x, int y)
        {
            try
            {
                List<Label> list = new List<Label>();
                for (int i = 0; i < _X; i++)
                {
                    Label lbl = _GridTemplate.Getlabel(y, i);
                    lbl.BorderThickness = new Thickness(3);
                    list.Add(lbl);
                }
                for (int i = 0; i < _Y; i++)
                {
                    Label lbl = _GridTemplate.Getlabel(i, x);
                    lbl.BorderThickness = new Thickness(3);
                    list.Add(lbl);
                }
                return list;
            }
            catch (Exception ex)
            {

                MessageBox.Show("SetPath\n" + ex.Message);
                return null;
            }
        }

        private void SetPathLabels()
        {
            try
            {
                Label firstLabel = _SelectedLabels[_PathLabelsIndexCounter - 1];
                Label SecondLabel = _SelectedLabels[_PathLabelsIndexCounter];

                LabelModel lm1 = (LabelModel)firstLabel.Tag;
                LabelModel lm2 = (LabelModel)SecondLabel.Tag;

                int minIndex = 0;
                int maxIndex = 0;

                if (lm1.Col == lm2.Col)
                {
                    if (lm1.Row > lm2.Row)
                    {
                        maxIndex = lm1.Row;
                        minIndex = lm2.Row;
                    }
                    else
                    {
                        minIndex = lm1.Row;
                        maxIndex = lm2.Row;
                    }
                    for (int i = minIndex + 1; i < maxIndex; i++)
                    {
                        LabelModel lm = new LabelModel();
                        if (_SelectedTip==LabelTip.Tunel)
                        {
                            lm = new LabelModel(lm1.Col, i, lm1.Tip,lm1.RafId,lm1.RafAd,lm.Alias,lm.Alias);
                        }
                        else
                             lm = new LabelModel(lm1.Col, i, _SelectedTip);

                        Label lbl = _GridTemplate.Getlabel(i, lm1.Col);
                        lbl.Tag = lm;
                        lbl.Background = _SelectedColor.DarkerSolidBrushes();
                        lbl.BorderBrush = _SelectedColor.InvertSoldibrushes();
                        lbl.BorderThickness = new Thickness(3);
                        _PathLabels.Add(lbl);
                    }
                }
                else if (lm1.Row == lm2.Row)
                {
                    if (lm1.Col > lm2.Col)
                    {
                        maxIndex = lm1.Col;
                        minIndex = lm2.Col;
                    }
                    else
                    {
                        minIndex = lm1.Col;
                        maxIndex = lm2.Col;
                    }

                    for (int i = minIndex + 1; i < maxIndex; i++)
                    {
                        LabelModel lm = new LabelModel();
                        if (_SelectedTip == LabelTip.Tunel)
                        {
                            lm = new LabelModel(i, lm1.Row, lm1.Tip, lm1.RafId, lm1.RafAd,lm.Alias);
                        }
                        else
                            lm = new LabelModel(i, lm1.Row, _SelectedTip);
                        Label lbl = _GridTemplate.Getlabel(lm1.Row, i);
                        lbl.Tag = lm;
                        lbl.Background = _SelectedColor.DarkerSolidBrushes();
                        lbl.BorderBrush = _SelectedColor.InvertSoldibrushes();
                        lbl.BorderThickness = new Thickness(3);
                        _PathLabels.Add(lbl);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("SetPathLabels\n" + ex.Message);
            }
        }

        private void SetLabelInPath()
        {
            try
            {

                for (int i = 0; i < _PathLabels.Count; i++)
                {
                    LabelModel lm = (LabelModel)_PathLabels[i].Tag;
                    _PathLabels[i].Background = _SelectedColor;
                    _PathLabels[i].BorderThickness = new Thickness(0.5);
                    if (_SelectedTip == LabelTip.Tunel)
                    {
                        lm = new LabelModel(lm.Col, lm.Row, LabelTip.Raf, lm.RafId, lm.RafAd,lm.Alias);
                        _PathLabels[i].Tag = lm;
                        _PathLabels[i].FontSize = _Size * 0.4;
                        _PathLabels[i].Content = lm.Alias;
                        _CurrentRaf.Coordinats.Add(lm);
                    }
                    else if (lm.Tip == LabelTip.Raf)
                    {
                        lm = new LabelModel(lm.Col, lm.Row, _SelectedTip, _CurrentRaf.Id, _CurrentRaf.Name,_CurrentRaf.Alias);
                        _PathLabels[i].Tag = lm;
                        _PathLabels[i].FontSize = _Size*0.4;
                        _PathLabels[i].Content = lm.Alias;
                        _CurrentRaf.Coordinats.Add(lm);
                    }
                    else
                    {
                        lm = new LabelModel(lm.Col, lm.Row, _SelectedTip);
                        _PathLabels[i].Tag = lm;
                        _PathLabels[i].Content = "";
                    }



                }
                _PathLabels = null;
                _PathLabels = new List<Label>();
            }
            catch (Exception ex)
            {

                MessageBox.Show("SetLabelInPath\n" + ex.Message);
            }
        }

        private void BtnRafEkleSil_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowRafOlustur wro = new WindowRafOlustur();
                Button btn = (Button)sender;
                switch (btn.Name)
                {
                    case "BtnRafEkle":
                        wro.ShowDialog();
                        break;
                    case "BtnRafSil":
                        if (_CbRaf.Items.Count != 0)
                        {
                            wro.Init(_CurrentRaf);
                            wro.ShowDialog();
                        }

                        break;
                    default:
                        break;
                }



                if (wro.ro.Equals(RafOlusturIslem.Sil))
                {
                    if (_CbRaf.Items.Count != 0 && _Raflar.Count != 0)
                    {

                        int index = _CbRaf.SelectedIndex;

                        if (_CbRaf.Items.Count > 1)
                        {
                            if (index == 0)
                            {
                                _CbRaf.SelectedIndex = index + 1;
                                _CurrentRaf = _Raflar[index + 1];
                            }
                            else
                            {
                                _CbRaf.SelectedIndex = index - 1;
                                _CurrentRaf = _Raflar[index - 1];
                            }
                        }
                        _CbRaf.Items.RemoveAt(index);
                        _Raflar.RemoveAt(index);

                    }
                }
                else if (wro.ro.Equals(RafOlusturIslem.Ekle))
                {
                    if (wro._Raf.Color != null)
                    {
                        _CurrentRaf = wro._Raf;
                        _Raflar.Add(_CurrentRaf);
                        ComboBoxItem cbi = new ComboBoxItem();
                        cbi.Background = _CurrentRaf.Color.Color;
                        cbi.Tag = _CurrentRaf;
                        cbi.Content = _CurrentRaf.Name;
                        _CbRaf.Items.Add(cbi);
                        _CbRaf.SelectedIndex = _Raflar.Count - 1;
                        LblRenkRaf.Background = _CurrentRaf.Color.Color;
                        LblRenkRaf.Visibility = Visibility.Visible;
                        RbtnRaf.Visibility = Visibility.Visible;
                    }
                }
                else if (wro.ro.Equals(RafOlusturIslem.Guncelle))
                {
                    ComboBoxItem cbi =(ComboBoxItem)_CbRaf.SelectedItem;
                    _CurrentRaf = wro._Raf;
                    cbi.Content = _CurrentRaf.Name;
                    LblRenkRaf.Background = _CurrentRaf.Color.Color;
                    if (RbtnRaf.IsChecked == true)
                        _SelectedColor = _CurrentRaf.Color.Color;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnRafEkleSil_Click\n" + ex.Message);
            }
        }

        private void CbRaf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBox cb = (ComboBox)sender;

                if (cb.Items.Count > 0)
                {
                    ComboBoxItem cbi = (ComboBoxItem)cb.SelectedItem;
                    LblRenkRaf.Background = ((RafModel)cbi.Tag).Color.Color;
                    _CurrentRaf = (RafModel)cbi.Tag;
                    if (RbtnRaf.IsChecked==true)
                    {
                        _SelectedColor = ((RafModel)cbi.Tag).Color.Color; 
                    }
                }
                else
                {
                    _CurrentRaf = null;
                    LblRenkRaf.Visibility = Visibility.Hidden;
                    RbtnRaf.Visibility = Visibility.Hidden;
                    RbtnDefault.IsChecked = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("CbRaf_SelectionChanged\n" + ex.Message);
            }
        }

        private void BtnFile_Click(object sender, RoutedEventArgs e)
        {
            //if (_Raflar.Count==0)
            //{
            //    MessageBoxResult result = MessageBox.Show("BAĞLAMA İŞLEMİ İÇİN YETERLİ SAYIDA RAF OLUŞTURULMAMIŞTIR", "UYARI!",MessageBoxButton.OK, MessageBoxImage.Warning);
            //    return;
            //}

            WindowRafBagla wrb = new WindowRafBagla();
            wrb.Init(_Raflar);
            wrb.Show();
        }

        private bool IsInValidPath(int x, int y)
        {
            if (_ValidPaths.Count != 0)
            {
                PathIndex p = _ValidPaths.Peek();
                if (p.X == x || p.Y == y)
                    return true;
            }


            return false;
        }
    }
}
