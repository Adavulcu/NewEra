using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    public class Kapi : ModelBase
    {
        public string Kod { get; set; }
        public string Isim { get; set; }
        public Guid ULId { get; set; } // Up Level Id -> Kapının bağlı olduğu adres

    }
}
