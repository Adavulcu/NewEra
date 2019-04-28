using NewEraDepo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Data
{
    public class IsEmriOp : DbOp
    {
        public IsEmri YukIndirmeEmriOlustur(MalKabulArac malKabulArac, Kapi kapi, Kullanici personel, DepoIciArac depoIciArac)
        {
            Guid isEmriId = IsEmriOlustur(TipIsEmri.YukIndirme);
            string cmdText = " DECLARE @Id uniqueidentifier = NEWID() " +
                " INSERT INTO ne_IsEmriYukIndirme " +
                "([Id]" +
                ",[EmirId]" +
                ",[KullaniciId]" +
                ",[AdresId]" +
                ",[DepoIciAracId]" +
                ",[MalKabulAracId]" +
                ",[KayitKullaniciId]" +
                ",[GuncellemeKullaniciId]) " +
                "VALUES(@Id, @EmirId, @PersonelId, @AdresId, @DepoIciAracId, @MalKabulAracId, @KId, @KId ) " +
                " SELECT " +
                "  Id" +
                " ,EmirId " +
                " ,KullaniciId " +
                " ,AdresId " +
                " FROM ne_IsEmriYukIndirme " +
                " WHERE " +
                " Id=@Id";
            DataTable dtYukIndirme = DBDataTable(cmdText, new List<SqlParameter>()
            {
                new SqlParameter(){ParameterName="@EmirId",Value=isEmriId},
                new SqlParameter(){ParameterName="@PersonelId",Value=personel.Id},
                new SqlParameter(){ParameterName="@AdresId",Value=kapi.ULId},
                new SqlParameter(){ParameterName="@DepoIciAracId",Value=depoIciArac.Id},
                new SqlParameter(){ParameterName="@MalKabulAracId",Value=malKabulArac.Id},
                new SqlParameter(){ParameterName="@KId",Value=_kullanici.Id}

            });
            IsEmri isEmri = new IsEmri();
            isEmri.Id = isEmriId;
            isEmri.Tip = TipIsEmri.YukIndirme;
            IsEmriYukIndirme isEmriYukIndirme = new IsEmriYukIndirme();
            DataRow row = dtYukIndirme.Rows[0];
            isEmriYukIndirme.Id = row["Id"].ToString().ToGuid();
            isEmriYukIndirme.EmirId = row["EmirId"].ToString().ToGuid();
            isEmriYukIndirme.PersonelId = row["KullaniciId"].ToString().ToGuid();
            isEmriYukIndirme.AdresId = row["AdresId"].ToString().ToGuid();

            isEmri.Emir = isEmriYukIndirme;
            return isEmri;
        }
        Guid IsEmriOlustur(TipIsEmri tip)
        {
            string cmdText = " DECLARE @Id uniqueidentifier = NEWID()" +
                "INSERT INTO ne_IsEmri(Id, Tip, Durum, KayitKullaniciId, GuncellemeKullaniciId) " +
                "VALUES (@Id, @Tip, @Durum, @KId, @KId) " +
                "SELECT @Id AS IsEmriId ";
            DataTable sonuc = DBDataTable(cmdText, new List<SqlParameter>()
            {
                new SqlParameter(){ParameterName="@Tip",Value =tip},
                new SqlParameter(){ParameterName="@Durum",Value=DurumIsEmri.Olusturma},
                new SqlParameter(){ParameterName="@KId",Value =_kullanici.Id}
            });
            Guid result = sonuc.Rows[0]["IsEmriId"].ToString().ToGuid();
            return result;
        }

        public DataTable ListeKullanici(Guid kullaniciId,TipIsEmri tip)
        {
            string cmdText;
            DataTable result;
            switch (tip)
            {
                case TipIsEmri.YukIndirme:
                    cmdText = SelectSQLListeIsEmriYukIndirme() + 
                       " WHERE " +
                       " Emir.KullaniciId = @kId " +
                       " ORDER BY Emir.KayitTarihi DESC";
                    break;
                default:
                    cmdText = "";
                    break;
            }
            if (cmdText != "")                
                result = DBDataTable(cmdText, new List<SqlParameter>()
                {
                    new SqlParameter(){ParameterName="@DepoId",Value = _kullanici.DepoId},
                    new SqlParameter(){ParameterName="@kId",Value = kullaniciId}
                });
            else
                result = new DataTable();
            return result;
        }
        public DataTable Liste(TipIsEmri tip)
        {
            string cmdText;
            DataTable result;
            switch (tip)
            {
                case TipIsEmri.YukIndirme:
                    cmdText = GetListeIsEmriYukIndirme()+ " ORDER BY Emir.KayitTarihi DESC";
                    break;
                default:
                    cmdText = "";
                    break;
            }
            if (cmdText != "")
                result = DBDataTable(cmdText, new List<SqlParameter>()
                {
                    new SqlParameter(){ParameterName="@DepoId",Value = _kullanici.DepoId}
                });
            else
                result = new DataTable();
            return result;
        }

        string GetListeIsEmriYukIndirme()
        {
            string cmdText = SelectSQLListeIsEmriYukIndirme()+
                " WHERE " +
                "  [dbo].[fn_DepoIdFromAdresId] (Emir.AdresId) = @DepoId ";
                
            return cmdText;
        }

        string SelectSQLListeIsEmriYukIndirme()
        {
            string cmdText = "SELECT " +
                " Emir.Id" +
                ",Emir.EmirId" +
                ",IsEmri.Durum" +
                ",ISNULL(Drm.Isim,N'') AS IsEmriDurum" +
                ",Emir.KullaniciId AS PersonelId" +
                ",Per.Isim AS PersonelIsim" +
                ",Emir.AdresId " +
                ",Adres.Isim AS AdresIsim "+
                ",AdresListe.Adres AS AdresKod "+
                ",Kapi.Id AS KapiId " +
                ",Kapi.Isim AS KapiIsim" +
                ",Emir.DepoIciAracId " +
                ",DArac.Isim AS DepoIciAracIsim" +
                ",Emir.MalKabulAracId " +
                ",MalKabulArac.Plaka AS MalKabulAracPlaka " +
                ",MalKabulArac.Firma AS MalKabulAracFirma" +
                " FROM ne_IsEmriYukIndirme AS Emir " +
                " INNER JOIN ne_IsEmri AS IsEmri ON IsEmri.Id = Emir.EmirId "+
                " INNER JOIN ne_Kullanici AS Per ON Per.Id=Emir.KullaniciId " +
                " INNER JOIN ne_DepoX AS Adres ON Adres.Id=Emir.AdresId " +
                " INNER JOIN ne_V_DepoAdresListe AS AdresListe ON AdresListe.AdresId = Emir.AdresId" +
                " INNER JOIN ne_DepoKapi AS Kapi ON Kapi.ULId=Emir.AdresId " +
                " INNER JOIN ne_DepoIciArac AS DArac ON DArac.Id = Emir.DepoIciAracId " +
                " INNER JOIN ne_MalKabulArac AS MalKabulArac ON MalKabulArac.Id = Emir.MalKabulAracId " +
                " LEFT OUTER JOIN ne_IsEmriDurum AS Drm ON Drm.Durum=IsEmri.Durum";                
            return cmdText;
        }

        public bool DurumGuncelle(IsEmri isEmri,DurumIsEmri durum)
        {
            bool result = false;
            string cmdText = "UPDATE ne_IsEmri " +
                "SET " +
                " Durum = @Durum " +
                ",GuncellemeKullaniciId=@KId " +
                ",GuncellemeTarihi=GETDATE()" +
                " WHERE " +
                " Id = @Id";
            SqlCommand cmd = DBCmd(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Durum",Value = durum},
                new SqlParameter(){ParameterName="@Id",Value = isEmri.Id},
                new SqlParameter(){ParameterName="@KId",Value = _kullanici.Id}
            });
            try
            {
                cmd.Connection.Open();
                int sonuc = cmd.ExecuteNonQuery();
                result = sonuc != (-1);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return result;
        }
    }
}
