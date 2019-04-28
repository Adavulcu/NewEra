using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using NewEra.DepoSimulasyon.Models;
namespace NewEra.DepoSimulasyon
{
   public class DepoModel:BaseAdresModel
    {
        public Byte[] Img{ get; set; }

       
        public DepoModel(Byte[] img,string depoName, Guid depoId):base(depoId,depoName)
        {
            Img = img;
            Name = depoName;
            Id = depoId;
        }

       
    }
}
