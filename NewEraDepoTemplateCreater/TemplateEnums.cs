using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepoTemplateCreater
{
  public enum RafOlusturIslem
    {
        Ekle=1,
        Sil=2,
        Iptal=3,
        Guncelle=4
    }

    public enum LabelTip
    {
        Duvar,
        Tunel,
        Alan,
        Raf,
        Default,
        Sil
    }

    public enum BaglantiSonuc
    {
        SiraEsitDegil,
        Hata,
        Basarili
    }
}
