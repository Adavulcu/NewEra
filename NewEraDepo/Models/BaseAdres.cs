using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    public class BaseAdres : ModelBase
    {
        public Guid UlId { get; set; }
        public string Kod { get; set; }
        public string Isim { get; set; }

        public BaseAdres(Guid id,Guid ulId,string kod ,string isim)
        {
            Id = id;
            UlId = ulId;
            Kod = kod;
            Isim = isim;
        }
    }
}
