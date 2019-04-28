using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEra.DepoSimulasyon.Models
{
    class BolgeModel:BaseAdresModel
    {
       public PointModel Points { get; set; }

        public List<RafModel> Raf { get; set; }
        private Random rnd = new Random();
        public BolgeModel(Guid ulId,Guid id,string name,PointModel points ):base(id,ulId,name)
        {
            Points = points;
            
        }

      
    }
}
