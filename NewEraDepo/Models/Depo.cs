using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
   public class Depo:ModelBase
    {
        public string Isim { get; set; }
        public string Kod { get; set; }
        public string Aciklama { get; set; }
        public int Tip { get; set; }
        public Guid ImgId { get; set; }
        public Image Img { get; set; }
        public Depo()
        {

        }

        public Depo(Guid id, string ısim, string kod, string aciklama, int tip, Guid imgId,Image img)
        {
            Img = img;
            ImgId = imgId;
            Id = id;
            Isim = ısim;
            Kod = kod;
            Aciklama = aciklama;
            Tip = tip;
        }
    }
}
