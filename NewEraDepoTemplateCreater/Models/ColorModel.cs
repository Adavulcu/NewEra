using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NewEraDepoTemplateCreater
{
    public class ColorModel
    {
        public SolidColorBrush Color { get; set; }
        public string ColorName { get; set; }

        public ColorModel() { }

        public ColorModel(string name,SolidColorBrush color)
        {
            ColorName = name;
            Color = color;
        }

      
    }
}
