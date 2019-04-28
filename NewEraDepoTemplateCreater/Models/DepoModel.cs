using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepoTemplateCreater.Models
{
    public class DepoModel : BaseAdresModel
    {

        public DepoModel()
        { }

        public DepoModel( string depoName, Guid depoId) : base(depoId, depoName)
        {
            Name = depoName;
            Id = depoId;
        }
    }
}
