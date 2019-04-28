using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    public class Adres : ModelBase
    {
        public string Kod { get; set; }
        public string Isim { get; set; }
        public int Tip { get; set; }
        public Guid DepoId { get; set; }

    }
}
