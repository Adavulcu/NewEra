using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepoTemplateCreater.Models
{
    public class KatModel:BaseAdresModel
    {
       
        public KatModel()
        {

        }

        public KatModel(Guid ulId, string katName, Guid katId) : base(katId, ulId, katName)
        {
           
            UlId = ulId;
            Name = katName;
            Id = katId;
        }
    }
}
