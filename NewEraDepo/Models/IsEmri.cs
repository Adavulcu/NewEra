using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    public class IsEmri : ModelBase
    {
        public TipIsEmri Tip { get; set; }
        public IIsEmri Emir { get; set; }

    }
}
