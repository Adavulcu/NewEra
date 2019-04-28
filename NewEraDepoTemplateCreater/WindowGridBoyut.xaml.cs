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
    /// Interaction logic for WindowGridBoyut.xaml
    /// </summary>
    public partial class WindowGridBoyut : Window
    {
        public int _X;
        public int _Y;

        private string _prevXtext;
        private string _prevYtext;

        public Boolean _Flag;

        public WindowGridBoyut()
        {
            InitializeComponent();
        }

        public void Init(int x, int y)
        {
            _X = x;
            _Y = y;
            _prevXtext = _X.ToString();
            _prevYtext = _Y.ToString();
            TextX.Text = _X.ToString();
            TextY.Text = _Y.ToString();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                switch (((Button)sender).Name)
                {
                    case "BtnOlustur" :
                        _X = TextX.Text.ToInt();
                        _Y = TextY.Text.ToInt();
                        _Flag = true;
                        this.Close();
                        break;
                    case "BtnDegistir":
                        _X = TextX.Text.ToInt();
                        _Y = TextY.Text.ToInt();
                        _Flag = false;
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Btn_Click\n"+ex.Message);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int cursor = ((TextBox)sender).SelectionStart;
            try
            {

                int text = Convert.ToInt32(((TextBox)sender).Text);//gelen text i integere cevirmeye kalkar eger ceviremezse numeric deger girilmemiş demektir ve kod catch bölümüne gecer
                ((TextBox)sender).Text = ((TextBox)sender).Text;
                SetPrevText(((TextBox)sender), ((TextBox)sender).Text);
            }
            catch (Exception)
            {
                if (((TextBox)sender).Text.Length == 0)
                {
                    ((TextBox)sender).Text = "1";
                    ((TextBox)sender).SelectionStart = 0;
                }

                else
                {
                    ((TextBox)sender).Text = GetPrevText(((TextBox)sender));
                    ((TextBox)sender).SelectionStart = cursor;
                }



            }
        }

        private string GetPrevText(TextBox tb)
        {
            string text = "";
            switch (tb.Name)
            {
                case "TextX":
                    text = _prevXtext;
                    break;
                case "TextY":
                    text = _prevYtext;
                    break;
            }
            return text;
        }

        private void SetPrevText(TextBox tb, string text)
        {
            switch (tb.Name)
            {
                case "TextX":
                    _prevXtext = text;
                    break;
                case "TextY":
                    _prevYtext = text;
                    break;
            }
        }
    }
}
