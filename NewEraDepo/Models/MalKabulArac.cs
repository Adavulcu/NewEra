using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    public class MalKabulArac : ModelBase
    {

        public string Plaka { get; set; }
        public int Durum { get; set; }
        public Guid AdresId { get; set; }
        public string Sofor { get; set; }
        public string Firma { get; set; }
        public Guid DepoId { get; set; }




        public MalKabulArac()
        {
            Id = Guid.NewGuid();
            Plaka = "00XX000";
            Durum = 0;
            AdresId = new Guid();
            Sofor = "TANIMSIZ";
            Firma = "TANIMSIZ";
            DepoId = new Guid();
        }

        public MalKabulArac(Guid id, string plaka, int durum, Guid depoId, Guid adresId, string sofor, string firma)
        {
            Id = id;
            Plaka = plaka;
            Durum = durum;
            AdresId = adresId;
            Sofor = sofor;
            Firma = firma;
            DepoId = depoId;
        }

        public override string ToString()
        {
            return Plaka + " \r " + Id.ToString();
        }
    }
}
