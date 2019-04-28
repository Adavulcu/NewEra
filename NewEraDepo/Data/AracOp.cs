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
    public class AracOp : DbOp
    {

        public bool PlakaKontrol(string plaka)
        {
            bool result = false;
            string cmdText = " SELECT * FROM ne_MalKabulArac " +
                " WHERE " +
                " Plaka = @Plaka";
            DataTable dt = DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Plaka",Value=plaka}
            });
            try
            {
                result = dt.Rows.Count > 0;
            }
            catch (Exception)
            {


            }
            return result;
        }

        public MalKabulArac GetMalKabulArac(string plaka)
        {
            MalKabulArac result = new MalKabulArac();
            string cmdText = " SELECT * FROM ne_MalKabulArac " +
                " WHERE " +
                " Plaka = @Plaka";
            DataTable dt = DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Plaka",Value=plaka}
            });
            try
            {
                DataRow row = dt.Rows[0];
                result.Id = new Guid(row["Id"].ToString());
                result.Plaka = row["Plaka"].ToString();
                result.Durum = (int)row["Durum"];
                result.AdresId = (Guid)row["AdresId"];
                result.Sofor = row["Sofor"].ToString();
                result.Firma = row["Firma"].ToString();
                result.DepoId = row["DepoId"].ToString().ToGuid();
            }
            catch (Exception)
            {
                result.Plaka = plaka;
                result.AdresId = new Guid();
            }
            return result;
        }
        public bool CreateMalKabulArac(MalKabulArac malKabulArac)
        {
            bool result = false;
            string cmdText = " DECLARE @KONTROL BIT = 0 " +

                " SELECT TOP 1 @KONTROL = 1 FROM ne_MalKabulArac " +
                " WHERE " +
                " Id=@Id " +

                " IF @KONTROL = 0 " + // ARAÇ İLK KEZ GELMİŞ

                " BEGIN " +
                " INSERT INTO ne_MalKabulArac(Id,Plaka,Sofor,Firma,Durum,DepoId,AdresId,KayitKullaniciId,GuncellemeKullaniciId) " +
                " VALUES (@Id, @Plaka, @Firma, @Sofor, @Durum, @DepoId, @AdresId, @KId, @KId) " +
                " END " +
                " ELSE " +

                " BEGIN " +

                " UPDATE ne_MalKabulArac " +
                " SET " +
                " Durum = @Durum " +
                ",Sofor = @Sofor " +
                ",Firma = @Firma " +
                ",DepoId = @DepoId " +
                ",GuncellemeKullaniciId=@KId " +
                ",GuncellemeTarihi=GETDATE() " +
                " WHERE " +
                " Id = @Id " +

                " END " +
                //" EXECUTE [dbo].[sp_MalkabulAracHareket] @Id " + // MALKABULARAC LOG
                // GİRİŞİ YAPILAN VEYA GÜNCELLENEN ARACIN SEÇİLMESİ
                " SELECT @Id AS Id";
            DataTable dt = DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Plaka",Value=malKabulArac.Plaka},
                new SqlParameter(){ParameterName="@Id",Value=malKabulArac.Id},
                new SqlParameter(){ParameterName="@Sofor",Value=malKabulArac.Sofor},
                new SqlParameter(){ParameterName="@Durum",Value=malKabulArac.Durum},
                new SqlParameter(){ParameterName="@DepoId",Value=_kullanici.DepoId},
                new SqlParameter(){ParameterName="@Firma",Value=malKabulArac.Firma},
                new SqlParameter(){ParameterName="@AdresId",Value=new Guid()},
                new SqlParameter(){ParameterName="@KId",Value=_kullanici.Id}
            });
            try
            {
                result = dt.Rows.Count > 0;

            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
        public string GetAracDurum(MalKabulArac malKabulArac)
        {
            string result = "";
            string cmdText = "SELECT Isim FROM ne_MalKabulAracDurum " +
                " WHERE " +
                " Durum = @Durum ";
            DataTable dt = DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Durum",Value=malKabulArac.Durum}
            });
            try
            {
                DataRow row = dt.Rows[0];
                result = row["Isim"].ToString();
            }
            catch (Exception)
            {

            }
            return result;
        }

        public DataTable MalKabulAracListesi(DurumArac durum)
        {
            string cmdText = "SELECT Id, Plaka, Firma FROM ne_MalKabulArac " +
                " WHERE Durum=@Durum " +
                " AND DepoId = @DepoId";
            DataTable result = DBDataTable(cmdText, new List<SqlParameter>()
            {
                new SqlParameter(){ParameterName="@Durum",Value = durum},
                new SqlParameter(){ParameterName="@DepoId",Value = _kullanici.DepoId}
            });
            return result;
        }

        public DataTable DepoIciAracListesi(Guid depoId)
        {
            string cmdText = "SELECT Id, Isim, Kod, Marka, Model " +
                " ,DepoId ,Durum, YuklemedeKullanilir, YukIndirmeOncelik, Seviye " +
                "FROM ne_DepoIciArac " +
                "WHERE " +
                " DepoId = @DepoId " +
                " AND Durum != @DurumDepoIciArac " +
                " AND YuklemedeKullanilir = 1 " +
                " ORDER BY Durum, YukIndirmeOncelik";

            DataTable result = DBDataTable(cmdText, new List<SqlParameter>() {
            new SqlParameter(){ParameterName="@DepoId",Value=depoId },
            new SqlParameter(){ParameterName="@DurumDepoIciArac",Value=DurumDepoIciArac.Arizali}
            });
            return result;
        }

        public DepoIciArac GetDepoIciArac(string kod)
        {
            string cmdText = "SELECT Id, Isim, Kod, Marka, Model " +
                " ,DepoId ,Durum, YuklemedeKullanilir, YukIndirmeOncelik, Seviye " +
                " FROM ne_DepoIciArac " +
                " WHERE " +
                " DepoId = @DepoId " +
                " AND Durum != @DurumDepoIciArac " +
                " AND YuklemedeKullanilir = 1 " +
                " AND Kod = @Kod";
            DataTable depoArac = DBDataTable(cmdText, new List<SqlParameter>()
            {
                new SqlParameter(){ParameterName="@DepoId",Value=_kullanici.DepoId },
                new SqlParameter(){ParameterName="@DurumDepoIciArac",Value=DurumDepoIciArac.Arizali},
                new SqlParameter(){ParameterName="@Kod",Value=kod}
            });
            DepoIciArac depoIciArac = null;
            if (depoArac != null && depoArac.Rows.Count > 0)
            {
                depoIciArac = DepoIciAracFromDataRow(depoArac.Rows[0]);
            }
            return depoIciArac;
        }

        DepoIciArac DepoIciAracFromDataRow(DataRow row)
        {
            DepoIciArac depoIciArac = null;
            if (row != null)
            {

                depoIciArac = new DepoIciArac();
                depoIciArac.Id = row["Id"].To<Guid>();
                depoIciArac.Isim = row["Isim"].ToString();
                depoIciArac.Kod = row["Kod"].ToString();
                depoIciArac.Marka = row["Marka"].ToString();
                depoIciArac.Model = row["Model"].ToString();
                depoIciArac.Seviye = row["Seviye"].To<int>();
                depoIciArac.YukIndirmeOncelik = row["YukIndirmeOncelik"].To<int>();
                depoIciArac.YuklemedeKullanilir = row["YuklemedeKullanilir"].To<bool>();
            }
            return depoIciArac;
        }
    }
}
