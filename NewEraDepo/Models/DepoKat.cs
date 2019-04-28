using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    public class DepoKat : BaseAdres
    {
       

        public DepoKat(Guid id, Guid ulId, string kod, string isim) : base(id, ulId, kod, isim)
        {
        }
    }
}
