using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    public class DepoIciArac : ModelBase
    {
        public string Isim { get; set; }
        public string Kod { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public Guid DepoId { get; set; }
        public DurumDepoIciArac Durum { get; set; }
        public bool YuklemedeKullanilir { get; set; }
        // İndirme iş emri oluşturulurken listede hangi sırada çıkacağı
        public int YukIndirmeOncelik { get; set; }
        // aracın yük alabileceği max seviye
        public int Seviye { get; set; }

    }
}
