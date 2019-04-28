using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEraDepo.Models;

namespace NewEraDepo.Data
{
    public class KapiOp : DbOp
    {
        public DataTable Liste()
        {
            string cmdText = "SELECT Id, Kod, Isim, ULId FROM ne_DepoKapi " +
                " WHERE " +
                " [dbo].[fn_DepoIdFromAdresId] (ULId) = @DepoId";
            DataTable result = DBDataTable(cmdText, new List<SqlParameter>()
            {
                new SqlParameter(){ParameterName="@DepoId",Value=_kullanici.DepoId}
            });
            return result;
        }
    }
}
