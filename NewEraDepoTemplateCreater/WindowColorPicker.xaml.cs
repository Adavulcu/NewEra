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
    /// Interaction logic for WindowColorPicker.xaml
    /// </summary>
    public partial class WindowColorPicker : Window
    {
        public ColorModel _Color;
        public WindowColorPicker()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        private void BtnKayde_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Color c = (Color)ClrPicker.SelectedColor;
                string name = ClrPicker.SelectedColorText;
                _Color = new ColorModel(name, new SolidColorBrush(c));
                this.Close();
            }
            catch (ArgumentNullException )
            {

                MessageBox.Show("LÜTFEN BİR RENK SEÇİNİZ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("BtnKayde_Click\n" + ex.Message);
            }
        }

        public void Init(ColorModel cm)
        {
            _Color = cm;
            ClrPicker.SelectedColor =cm.Color.Color;
           
        }

       
    }
}
