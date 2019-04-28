using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
   public class AyarlarKullaniciDetail
    {
     
        public Guid KulId { get; set; }

        public Guid RolId { get; set; }

        public string Kod { get; set; }

        public string Isim { get; set; }

        public AyarlarKullaniciDetail(Guid kulId, Guid rolId, string kod, string isim)
        {
            KulId = kulId;
            RolId = rolId;
            Kod = kod;
            Isim = isim;
        }

        public AyarlarKullaniciDetail()
        {

        }
    }
}
