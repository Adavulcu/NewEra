using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
   public class SubModul:Modul
    {
        public string ClassName { get; set; }
        public bool IsSubmodul { get; set; }


        public SubModul(Guid id, string className, string ısim,int imgIndex,string modulId)
        {
            Id = id;
            ClassName = className;
            Isim = ısim;
            ImgIndex = imgIndex;
            ModulId = modulId;
        }

        public SubModul(Guid id , string className, string ısim, bool isSubModul,
            int imgIndex,string modulId, List<SubModul> subModuls = null)
        {
            Id = id;
            ClassName = className;
            Isim = ısim;
            IsSubmodul = isSubModul;
            SubModuls = subModuls;
            ImgIndex = imgIndex;
            ModulId = modulId;

        }

        public SubModul()
        { }
      
    }
}
