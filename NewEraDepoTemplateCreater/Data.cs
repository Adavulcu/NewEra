using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEra.DepoSimulasyon;
namespace NewEraDepoTemplateCreater
{
    public class Data : DbOp
    {

        public DataTable DepoGetir()
        {
            try
            {
                string cmdText = "select " +
                     "Id as DepoId," +
                     "Isim DepoIsim " +
                     " from ne_Depo ";


                return DBDataTable(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\nDepoGetir\n" + ex.Message);
            }
        }

        public DataTable KatGetir()
        {
            try
            {
                string cmdText = "Select " +
                    "Id , " +
                    "ULId , " +
                    "Isim " +
                    "from ne_DepoKat order by Isim" ;

                return DBDataTable(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\nKatGetir\n" + ex.Message);
            }
        }

        public DataTable RafGetir(Guid depoId, Guid katId)
        {
            try
            {
                string cmdText = "select " +
                                "RafId, " +
                                "DepoKatId as KatId, " +
                                "DepoId , " +
                                "Adres , " +
                                "Raf, " +
                                "AdresId " +
                                "from ne_V_DepoAdresListe " +
                                "where Yukseklik = 1 " +
                                "and DepoId = @DepoId " +
                                "and DepoKatId =@KatId " +
                                "order by AdresXY ";

                return DBDataTable(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@DepoId",Value=depoId },
                new SqlParameter(){ParameterName="@KatID",Value=katId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nRafGetir\n" + ex.Message);
            }
        }

    }
}
