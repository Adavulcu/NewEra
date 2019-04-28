using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NewEraDepoTemplateCreater
{
   public class LabelModel
    {
        public int Col { get; set; }
        public int Row { get; set; }
        public string Adres { get; set; }
        public LabelTip Tip { get; set; }
        public string RafAd { get; set; }
        public Guid RafId { get; set; }
        public string Alias { get; set; }
        public LabelModel()
        {

        }

        public LabelModel(int col,int row ,LabelTip tip, string adres= "000000000")
        {
            Adres = adres;
            Tip = tip;
            Col = col;
            Row = row;
        }

        public LabelModel(int col, int row, LabelTip tip, Guid rafId,string rafAd,string alias, string adres = "000000000")
        {
            RafAd = rafAd;
            RafId = rafId;
            Alias = alias;
            Adres = adres;
            Tip = tip;
            Col = col;
            Row = row;
        }
    }
}
