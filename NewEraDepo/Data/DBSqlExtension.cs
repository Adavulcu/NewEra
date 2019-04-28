using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEraDepo;

namespace NewEraDepo.Data
{
    public static class DBSqlExtension
    {
        public static SqlCommand ExecQuery(this SqlCommand cmd)
        {
            cmd.Connection.Open();
            cmd.ExecuteReader();
            cmd.Connection.Close();
            return cmd;
        }
    }
}
