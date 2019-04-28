using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    public class IsEmriYukIndirme : IIsEmri
    {
        public Guid Id { get ; set ; }
        public Guid AdresId { get ; set; }
        public Guid EmirId { get; set; }
        public Guid PersonelId { get; set; }
        public Guid MalKabulAracId { get; set; }
        public Guid DepoIciAracId { get; set; }


    }
}
