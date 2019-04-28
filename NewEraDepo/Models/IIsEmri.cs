using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Models
{
    public interface IIsEmri
    {
        Guid Id { get; set; }
        Guid AdresId { get; set; }

    }
}
