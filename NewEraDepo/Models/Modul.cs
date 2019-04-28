using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
  public  class Modul:ModelBase
    {

        public int ImgIndex { get; set; }
        public List<SubModul> SubModuls { get; set; }
        public Image Image { get; set; }
        public string ModulId { get; set; }
        public string Isim { get; set; }

     
        public Modul(Guid id ,List<SubModul> subModuls, string ısim,int imgIndex,string modulId)
        {
            Id = id;
            SubModuls = subModuls;
            Isim = ısim;
            ImgIndex = imgIndex;
            ModulId = modulId;
        }

        public Modul()
        { }
    }
}
