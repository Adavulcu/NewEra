using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepoTemplateCreater.Models
{
    public class RafSiraModel : BaseAdresModel
    {
        public RafSiraModel() { }

        public string Adres { get; set; }

        public RafSiraModel(string adres,Guid id):base(id)
        {
           
            Id = id;
            Adres = adres;
        }
    }
}
