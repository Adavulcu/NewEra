using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
        public class AyarlarKullanici : ModelBase
    {
        public string Kod { get; set; }
        public string Isim { get; set; }
        public string Sifre { get; set; }     
        public string Depo { get; set; }      
        public Guid DepoId { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
       
        public AyarlarKullanici ()
        { }


        public AyarlarKullanici(Guid id,string kod,string isim,string sifre,
            string depo,DateTime kayitTarihi,DateTime guncellemeTarihi,Guid depoId)
        {
            
            this.Id = id;
            this.Kod = kod;
            this.Isim = isim;
            this.Sifre = sifre;           
            this.Depo = depo;        
            this.KayitTarihi = kayitTarihi;
            this.GuncellemeTarihi = guncellemeTarihi;
            this.DepoId = depoId;

        }

        public AyarlarKullanici(Guid id,string kod,string isim,string sifre,  string depo,  Guid depoId)
        {
            this.Id = id;
            this.Kod = kod;
            this.Isim = isim;
            this.Sifre = sifre;
          
            this.Depo = depo;
           
            this.DepoId = depoId;
        }
    }
}
