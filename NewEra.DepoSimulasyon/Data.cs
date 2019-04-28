using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEra.DepoSimulasyon.Models;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace NewEra.DepoSimulasyon
{
    class Data : DbOp
    {


        public DataTable DepoGetir()
        {
            try
            {
                string cmdText = "select " +
                    "d.Id as DepoId," +
                    "d.Isim DepoIsim ," +
                    "img.Image as Img from ne_Depo d " +
                    "left join ne_DepoImg img on d.Id=img.DepoId ";
                return DBDataTable(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\nDepoGetir\n" + ex.Message);
            }
        }

        public DataTable KatGetir(Guid depoId)
        {
            try
            {
                string cmdText = "Select " +
                    "Id , " +
                    "ULId , " +
                    "Isim " +
                    "from ne_DepoKat where ULId=@UlId";

                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@UlId",Value=depoId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nKatGetir\n" + ex.Message);
            }
        }

        public DataTable KatDetayGetir(Guid KatId, Guid depoId)
        {
            try
            {

                //string cmdText = "select " +Environment.NewLine+
                //       "sorgu.* " +Environment.NewLine+
                //       ",f.X as KX " +Environment.NewLine+
                //       ",f.Y as KY " +Environment.NewLine+
                //       ",adr.AdresId " +Environment.NewLine+
                //       "from( " +Environment.NewLine+
                //       "select " +Environment.NewLine+
                //       " adr.RafId " +Environment.NewLine+
                //       " , adr.KoyId " +Environment.NewLine+
                //       " , adr.X as Sira " +Environment.NewLine+
                //       " , adr.Raf " +Environment.NewLine+
                //        ", adr.Koy " +Environment.NewLine+


                //                               ", ( " +Environment.NewLine+
                //         "select " +Environment.NewLine+
                //        "round(sum(oran) / count(*), 2) " +Environment.NewLine+
                //         "from( " +Environment.NewLine+
                //         "select " +Environment.NewLine+
                //        "Raf, "+Environment.NewLine+
                //        "Koy, "+Environment.NewLine+
                //         "ISNULL(sorgu2.oran, 0) as oran "+Environment.NewLine+
                //         "from ne_V_DepoAdresListe da "+Environment.NewLine+
                //        "left outer join( "+Environment.NewLine+
                //        "select "+Environment.NewLine+
                //        "sorgu.AdresId "+Environment.NewLine+
                //        " , SUM(ROUND(sorgu.Miktar / SORGU.paletMiktar * 100, 2)) AS oran "+Environment.NewLine+
                //        "from( "+Environment.NewLine+
                //        "select "+Environment.NewLine+
                //        "AdresId, "+Environment.NewLine+
                //        "x.StokId, "+Environment.NewLine+
                //        "SUM(x.Miktar) AS Miktar, "+Environment.NewLine+
                //        "case when  ISNULL(p.Miktar, SUM(x.Miktar)) = 0 then 1  "+Environment.NewLine+
                //        "else  ISNULL(p.Miktar, SUM(x.Miktar)) end "+Environment.NewLine+
                //        "as paletMiktar "+Environment.NewLine+
                //        "from ne_DepoXStokMiktar as x "+Environment.NewLine+
                //        "left outer  join ne_StokPaletMiktar as p on p.StokId = x.StokId "+Environment.NewLine+
                //        "group by "+Environment.NewLine+
                //        "AdresId, "+Environment.NewLine+
                //        "x.StokId, "+Environment.NewLine+
                //        "p.miktar "+Environment.NewLine+
                //        ") as sorgu "+Environment.NewLine+
                //        "GROUP BY AdresId "+Environment.NewLine+
                //        ") as sorgu2 "+Environment.NewLine+
                //        "on da.AdresId = sorgu2.AdresId "+Environment.NewLine+
                //        "where " +Environment.NewLine+
                //        "da.DepoId = @DepoId "+Environment.NewLine+
                //        "and da.DepoKatId = @KatId " +Environment.NewLine+
                //        "and da.Koy = adr.Koy "+Environment.NewLine+
                //        "and da.RafId=adr.RafId " +Environment.NewLine+
                //        "and da.Tip not in(100,255) "+Environment.NewLine+
                //        "and da.X = adr.X " +Environment.NewLine+
                //        ") as sorgu "+Environment.NewLine+
                //        ") as oran " +Environment.NewLine+ 

                //       "from ne_V_DepoAdresListe AS adr " +Environment.NewLine+
                //       "where " +Environment.NewLine+
                //       "DepoId = @DepoId " +Environment.NewLine+
                //       "and DepoKatId = @KatId " +Environment.NewLine+
                //       "and  adr.Tip not in (100, 255) " +Environment.NewLine+
                //       "group by " +Environment.NewLine+
                //       "adr.RafId " +Environment.NewLine+
                //       ", adr.KoyId " +Environment.NewLine+
                //       ", adr.Raf " +Environment.NewLine+
                //       ", adr.Koy " +Environment.NewLine+
                //       ", adr.X) as sorgu " +Environment.NewLine+
                //       "inner join ne_V_DepoAdresListe as adr " +Environment.NewLine+
                //       "on adr.RafId = sorgu.RafId " +Environment.NewLine+
                //       "and adr.Yukseklik = 1 and sorgu.sira = adr.X " +Environment.NewLine+
                //       "and adr.KoyId = sorgu.KoyId " +Environment.NewLine+
                //       "inner join ne_FizikselAdres as f " +Environment.NewLine+
                //       "on f.AdresId = adr.AdresId " +Environment.NewLine+
                //       "order by adr.Raf ";
                string cmdText =
                    ";with adresStoklar AS(" + Environment.NewLine +
                    "select " + Environment.NewLine +
                    "adr.AdresId " + Environment.NewLine +
                    ",ISNULL(X.StokId,CAST(0X0 AS uniqueidentifier)) AS StokId" + Environment.NewLine +
                    ",ISNULL(X.Miktar,0) AS Miktar " + Environment.NewLine +
                    ",ISNULL(ISNULL(p.Miktar,X.Miktar),1) AS paletMiktar" + Environment.NewLine +
                    "from ne_V_DepoAdresListe as adr " + Environment.NewLine +
                    "left outer join ne_DepoXStokMiktar as x " + Environment.NewLine +
                    "on x.AdresId = adr.AdresId" + Environment.NewLine +
                    "left outer  join ne_StokPaletMiktar as p on p.StokId = x.StokId " + Environment.NewLine +
                    "where" + Environment.NewLine +
                    "DepoId		= @DepoId" + Environment.NewLine +
                    "and DepoKatId	= @KatId" + Environment.NewLine +
                    "and Tip not in (100) " + Environment.NewLine +
                    ")," + Environment.NewLine +
                    "adresStokOran as (" + Environment.NewLine +
                    "select AdresId,stokId,sum(miktar/paletmiktar)*100 oran from adresStoklar" + Environment.NewLine +
                    "GROUP BY AdresId,StokId)," + Environment.NewLine +
                    "AdresDoluluk AS(" + Environment.NewLine +
                    "select AdresId,sum(oran) / count(*) as oran from adresStokOran" + Environment.NewLine +
                    "GROUP BY AdresId)," + Environment.NewLine +
                    "KusBakisiDoluluk AS(" + Environment.NewLine +
                    "select adrs.rafId,adrs.raf,adrs.X,adrs.KoyId, sum(dl.oran)/count(*) As Oran from ne_V_DepoAdresListe AS adrs" + Environment.NewLine +
                    "inner JOIN  AdresDoluluk as dl" + Environment.NewLine +
                    "ON adrs.AdresId=dl.AdresId" + Environment.NewLine +
                    "group by adrs.X,adrs.KoyId,adrs.rafId,adrs.raf)" + Environment.NewLine +
                    "" + Environment.NewLine +
                    "select" + Environment.NewLine +
                    "adr.RafId" + Environment.NewLine +
                    ",adr.KoyId" + Environment.NewLine +
                    ",adr.X As Sira" + Environment.NewLine +
                    ",adr.Raf" + Environment.NewLine +
                    ",adr.Koy" + Environment.NewLine +
                    ",fiziksel.X AS KX" + Environment.NewLine +
                    ",fiziksel.Y AS KY" + Environment.NewLine +
                    ",adr.AdresId" + Environment.NewLine +
                    ",dl.oran" + Environment.NewLine +
                    "" + Environment.NewLine +
                    " from KusBakisiDoluluk as dl" + Environment.NewLine +
                    "inner join ne_V_DepoAdresListe as  adr" + Environment.NewLine +
                    "inner join ne_FizikselAdres as fiziksel " + Environment.NewLine +
                    "on fiziksel.AdresId = adr.AdresId" + Environment.NewLine +
                    "on adr.RafId=dl.RafId" + Environment.NewLine +
                    "and adr.KoyId = dl.KoyId" + Environment.NewLine +
                    "and adr.X = dl.X" + Environment.NewLine +
                    "where" + Environment.NewLine +
                    "adr.Yukseklik=1" + Environment.NewLine +
                    "order by adr.Raf";


                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@DepoId",Value=depoId},
                new SqlParameter(){ParameterName="@katId",Value=KatId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nKatDetayGetir\n" + ex.Message);
            }
        }

        public DataTable RafSıraDetayGetir(KatDetayModel rafSira)
        {

            try
            {
                //string cmdText = "select " +
                //             " Adres, " +
                //             " Tip, " +
                //             " TipIsim, " +
                //             " Yukseklik, " +
                //             " RafId, " +
                //              "Raf, " +
                //             " Koy, " +
                //             " da.AdresId ," +
                //             "X as Sira, " +
                //             "ISNULL(sorgu2.oran, 0) as Oran " +
                //             " from ne_V_DepoAdresListe da " +
                //            "left outer join( " +
                //            "select " +
                //            "   sorgu.AdresId " +
                //             " , SUM(ROUND(sorgu.Miktar / SORGU.paletMiktar * 100,2)) AS oran " +
                //            "from( " +
                //            "select " +
                //             " AdresId, " +
                //             " x.StokId, " +
                //             " SUM(x.Miktar) AS Miktar, " +
                //             " case when  ISNULL(p.Miktar, SUM(x.Miktar))=0 then 1 " +
                //             " else  ISNULL(p.Miktar, SUM(x.Miktar)) end" +
                //             " as paletMiktar " +
                //             "from ne_DepoXStokMiktar as x " +
                //            " left outer  join ne_StokPaletMiktar as p on p.StokId = x.StokId " +
                //            " group by " +
                //            "  AdresId, " +
                //            "  x.StokId, " +
                //            "  p.miktar " +
                //            ") as sorgu " +
                //            "GROUP BY AdresId " +
                //            ") as sorgu2 " +
                //            "on da.AdresId = sorgu2.AdresId " +
                //             //"where da.DepoId = 'A6ED6BEB-BD92-4F9D-BC19-F2ED7FD20C9D' " +
                //             //"and da.DepoKatId = '05394D0F-2AFB-42B2-B401-381182D615BB' " +
                //             "where da.DepoId = @DepoId " +
                //            "and da.DepoKatId = @KatId " +
                //            "and da.RafId = @RafId " +
                //            "and da.X = @X " +
                //            "and da.Koy = @Koy " +
                //            "order by da.Yukseklik desc";

                string cmdText = ";with adresStoklar AS( " +Environment.NewLine+
                               "select " + Environment.NewLine +
                                "adr.AdresId " + Environment.NewLine +
                               ",ISNULL(X.StokId,CAST(0X0 AS uniqueidentifier)) AS StokId" + Environment.NewLine +
                               ",ISNULL(X.Miktar,0) AS Miktar " + Environment.NewLine +
                               ",ISNULL(ISNULL(p.Miktar,X.Miktar),1) AS paletMiktar" + Environment.NewLine +
                               "from ne_V_DepoAdresListe as adr " + Environment.NewLine +
                               "left outer join ne_DepoXStokMiktar as x " + Environment.NewLine +
                               "on x.AdresId = adr.AdresId" + Environment.NewLine +
                               "left outer  join ne_StokPaletMiktar as p on p.StokId = x.StokId " + Environment.NewLine +
                               "where" + Environment.NewLine +
                               "DepoId		= @DepoId" + Environment.NewLine +
                               "and DepoKatId	= @KatId" + Environment.NewLine +
                               "and RafId		=@RafId" + Environment.NewLine +
                                "and X = @X " + Environment.NewLine +
                                "and Koy = @Koy " + Environment.NewLine +
                               ")," + Environment.NewLine +
                               "adresStokOran as (" + Environment.NewLine +
                               "select AdresId,stokId,sum(miktar/paletmiktar)*100 oran from adresStoklar" + Environment.NewLine +
                               "GROUP BY AdresId,StokId)," + Environment.NewLine +
                               "AdresDoluluk AS(" + Environment.NewLine +
                               "select AdresId,round( sum(oran) / count(*),1) as oran from adresStokOran" + Environment.NewLine +
                               "GROUP BY AdresId)," + Environment.NewLine +
                               "KusBakisiDoluluk AS(" + Environment.NewLine +
                               "select adrs.rafId,adrs.raf,adrs.X,adrs.KoyId, sum(dl.oran)/count(*) As Oran from ne_V_DepoAdresListe AS adrs" + Environment.NewLine +
                               "inner JOIN  AdresDoluluk as dl" + Environment.NewLine +
                               "ON adrs.AdresId=dl.AdresId" + Environment.NewLine +
                               "group by adrs.X,adrs.KoyId,adrs.rafId,adrs.raf)" + Environment.NewLine +
                               "select" + Environment.NewLine +
                               "adr.Adres" + Environment.NewLine +
                               ",adr.RafId" + Environment.NewLine +
                               ",adr.Koy as Koy" + Environment.NewLine +
                               ",adr.X As Sira" + Environment.NewLine +
                               ",adr.Raf" + Environment.NewLine +
                               ",adr.Koy	" + Environment.NewLine +
                               ",adr.AdresId" + Environment.NewLine +
                                ",dl.oran" + Environment.NewLine +
                                ",adr.Tip " + Environment.NewLine +
                                ",adr.TipIsim " + Environment.NewLine +
                                ",adr.Yukseklik " + Environment.NewLine +
                               "from AdresDoluluk as dl " + Environment.NewLine +
                               "inner join ne_V_DepoAdresListe as  adr " + Environment.NewLine +
                                "on adr.AdresId = dl.AdresId" + Environment.NewLine +
                               "order by adr.Koy,adr.X,adr.AdresXY desc ";

                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@RafId",Value=rafSira.UlId },
                new SqlParameter(){ParameterName="@X",Value=rafSira.Sira },
                new SqlParameter(){ParameterName="@Koy",Value=rafSira.Koy },
                new SqlParameter(){ParameterName="@DepoId",Value=rafSira.DepoId },
                new SqlParameter(){ParameterName="@KatId",Value=rafSira.KatId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nRafSıraDetayGetir\n" + ex.Message);
            }
        }

        public DataTable RafGenelBilgiGetir(KatDetayModel rafSira)
        {
            try
            {
                string cmdText = ";with adresStoklar AS( " + Environment.NewLine +
                                "select " + Environment.NewLine +
                                 "adr.AdresId " + Environment.NewLine +
                                ",ISNULL(X.StokId,CAST(0X0 AS uniqueidentifier)) AS StokId" + Environment.NewLine +
                                ",ISNULL(X.Miktar,0) AS Miktar " + Environment.NewLine +
                                ",ISNULL(ISNULL(p.Miktar,X.Miktar),1) AS paletMiktar" + Environment.NewLine +
                                "from ne_V_DepoAdresListe as adr " + Environment.NewLine +
                                "left outer join ne_DepoXStokMiktar as x " + Environment.NewLine +
                                "on x.AdresId = adr.AdresId" + Environment.NewLine +
                                "left outer  join ne_StokPaletMiktar as p on p.StokId = x.StokId " + Environment.NewLine +
                                "where" + Environment.NewLine +
                                "DepoId		= @DepoId" + Environment.NewLine +
                                "and DepoKatId	= @KatId" + Environment.NewLine +
                                "and RafId		=@RafId" + Environment.NewLine +
                                ")," + Environment.NewLine +
                                "adresStokOran as (" + Environment.NewLine +
                                "select AdresId,stokId,sum(miktar/paletmiktar)*100 oran from adresStoklar" + Environment.NewLine +
                                "GROUP BY AdresId,StokId)," + Environment.NewLine +
                                "AdresDoluluk AS(" + Environment.NewLine +
                                "select AdresId,round(sum(oran) / count(*),1) as oran from adresStokOran" + Environment.NewLine +
                                "GROUP BY AdresId)," + Environment.NewLine +
                                "KusBakisiDoluluk AS(" + Environment.NewLine +
                                "select adrs.rafId,adrs.raf,adrs.X,adrs.KoyId, sum(dl.oran)/count(*) As Oran from ne_V_DepoAdresListe AS adrs" + Environment.NewLine +
                                "inner JOIN  AdresDoluluk as dl" + Environment.NewLine +
                                "ON adrs.AdresId=dl.AdresId" + Environment.NewLine +
                                "group by adrs.X,adrs.KoyId,adrs.rafId,adrs.raf)" + Environment.NewLine +
                                "select" + Environment.NewLine +
                                "adr.Adres" + Environment.NewLine +
                                ",adr.RafId" + Environment.NewLine +
                                ",adr.Koy as Koy" + Environment.NewLine +
                                ",adr.X As Sira" + Environment.NewLine +
                                ",adr.Raf" + Environment.NewLine +
                                ",adr.Koy	" + Environment.NewLine +
                                ",adr.AdresId" + Environment.NewLine +
                                 ",dl.oran" + Environment.NewLine +
                                 ",adr.Tip" + Environment.NewLine +
                                 ",adr.TipIsim" + Environment.NewLine +
                                 ",adr.Yukseklik" + Environment.NewLine +
                                "from AdresDoluluk as dl " + Environment.NewLine +
                               "inner join ne_V_DepoAdresListe as  adr " + Environment.NewLine +
                                "on adr.AdresId = dl.AdresId" + Environment.NewLine +
                                "order by adr.Koy,adr.X,adr.AdresXY desc";

                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@RafId",Value=rafSira.UlId } ,
                new SqlParameter(){ParameterName="@DepoId",Value=rafSira.DepoId },
                new SqlParameter(){ParameterName="@KatId",Value=rafSira.KatId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nRafGenelBilgiGetir\n" + ex.Message);
            }
        }

        public DataTable HucreBilgiGetir(HucreModel h)
        {
            try
            {

                string cmdText = " select " +
                                               "ISNULL(s.Kod, '-----') as Kod, " +
                                              " ISNULL(s.Isim, '-----') as Isim, " +
                                              " ISNUll(dsm.Miktar, -1) as Miktar, " +
                                              " ISNUll(sp.Miktar, dsm.Miktar) as PaletMiktar , " +
                                              " ISNULL(s.Id, '00000000-0000-0000-0000-000000000000') as StokId " +
                                              " from ne_DepoXStokMiktar as dsm " +
                                              "left join ne_Stok as s on dsm.StokId = s.Id " +
                                             " left join ne_StokPaletMiktar sp on dsm.StokId = sp.StokId " +
                                             " left join ne_V_DepoAdresListe as da on dsm.AdresId = da.AdresId " +
                                             " where " +
                                             "da.DepoId =@DepoId " +
                                             "and da.DepoKatId = @KatId " +
                                             "and da.RafId = @RafId " +
                                             "and da.AdresId = @AdresId";

                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@DepoId",Value=h.DepoId },
                new SqlParameter(){ParameterName="@KatId",Value=h.KatId },
                new SqlParameter(){ParameterName="@RafId",Value=h.UlId },
                new SqlParameter(){ParameterName="@AdresId",Value=h.Id }});
            }
            catch (Exception ex)
            {

                throw new Exception("\nHucreBilgiGetir\n" + ex.Message);
            }
        }

        public DataTable KatBoyutGetir(Guid KatId)
        {
            try
            {
                string cmdText = "select X,Y from ne_DepoKatCizimBoyut where KatId=@KatId";

                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@KatId",Value=KatId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nKatBoyutGetir\n" + ex.Message);
            }
        }


    }
}
