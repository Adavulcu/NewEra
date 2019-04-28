using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEraDepo.Data;

namespace NewEraDepo.Models
{
    public class Kullanici : ModelBase
    {
        public string Kod { get; set; }
        public string Isim { get; set; }
        public Guid DepoId { get; set; }
        //public Guid KayitKullaniciId { get; set; }
        //public DateTime KayitTarihi { get; set; }
        //public Guid GuncellemeKullaniciId { get; set; }
        //public DateTime GuncellemeTarihi { get; set; }
        //public Guid[] Roller { get; set; }

        public Kullanici()
        {

        }
        public Kullanici(Guid Id, string Kod, string Isim, Guid DepoId) //, Guid KayitKullaniciId, DateTime KayitTarihi, Guid GuncellemeKullaniciId, DateTime GuncellemeTarihi)
        {
            this.Id = Id;
            this.Kod = Kod;
            this.Isim = Isim;
            this.DepoId = DepoId;
            //this.KayitKullaniciId = KayitKullaniciId;
            //this.KayitTarihi = KayitTarihi;
            //this.GuncellemeKullaniciId = GuncellemeKullaniciId;
            //this.GuncellemeTarihi = GuncellemeTarihi;


        }

        public List<Rol> Roller()
        {
            List<Rol> result = new List<Rol>();
            KullaniciOp kullaniciOp = new KullaniciOp();
            DataTable roller = kullaniciOp.GetUserRols(Id);
            foreach (DataRow item in roller.Rows)
            {
                Rol rol = new Rol
                {
                    Id = item["Id"].ToString().ToGuid(),
                    Isim = item["Isim"].ToString(),
                    Kod = item["Kod"].ToString(),

                };
                result.Add(rol);
            }
            return result;
        }
        //public void Menu
    }
}
