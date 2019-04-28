using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    public class DepoKoy : BaseAdres
    {


        public DepoKoy(Guid id, Guid ulId, string isim, string kod) : base(id, ulId, kod, isim)
        {

        }
    }
}
