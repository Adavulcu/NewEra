using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    internal class DepoX : BaseAdres
    {
       
        public DepoX(Guid id, Guid ulId, string kod, string isim) : base(id, ulId, kod, isim)
        {
           
        }
    }
}
