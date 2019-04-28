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
    public class KullaniciOp : DbOp
    {

        public Kullanici KullaniciGiris(string KullaniciAdi, string Sifre)
        {
            Kullanici kullanici = null;
            SqlCommand cmd = new SqlCommand("", _connection)
            {
                CommandText = "SELECT [Id] " +
                ",[Kod]" +
                ",[Isim]" +
                ",[Sifre]" +
                ",[DepoId]" +
                ",[KayitKullaniciId]" +
                ",[KayitTarihi]" +
                ",[GuncellemeKullaniciId]" +
                ",[GuncellemeTarihi] " +
                "FROM [dbo].[ne_Kullanici] " +
                "WHERE " +
                "[Kod]=@Kod " +
                "AND [Sifre]=@Sifre"
            };
            cmd.Parameters.AddWithValue("@Kod", KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", Sifre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            _connection.Open();
            da.Fill(dt);
            _connection.Close();
            // Kullanıcı Tanımlı
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                kullanici = new Kullanici((Guid)row["Id"], row["Kod"].ToString(), row["Isim"].ToString(), row["DepoId"].ToString().ToGuid());//, (Guid)row["KayitKullanici"],(DateTime)row["KayitTarihi"], (Guid)row["GuncellemeKullaniciId"], (DateTime)row["GuncellemeTarihi"]);
            }
            return kullanici;
        }

        /// <summary>
        /// Kullanıcıya ait Rol bilgilerini DataTable olarak geriye döndürür.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public DataTable GetUserRols(Guid Id)
        {
            string cmdText = "SELECT rol.Id, rol.Kod, rol.Isim FROM ne_Rol AS rol " +
                " INNER JOIN ne_KullaniciRol AS kRol ON rol.Id=kRol.RolId " +
                " INNER JOIN ne_Kullanici AS kullanici ON kRol.KullaniciId=kullanici.Id " +
                " WHERE " +
                " kullanici.Id = @kId ";
            DataTable roller = DBDataTable(cmdText, new List<SqlParameter>() { new SqlParameter() { ParameterName = "@kId", Value = Id } });
            return roller;
        }

        /// <summary>
        /// Kullanıcı bilgilerini DataTable olarak geriye döndürür
        /// </summary>
        /// <returns></returns>
        public DataTable Liste()
        {
            string cmdText = "SELECT Id,Kod,Isim FROM ne_Kullanici ";
            DataTable result = DBDataTable(cmdText);

            return result;
        }


        public DataTable RoleBagliListe(Guid depoId, string kod)
        {
            string cmdText = "SELECT kul.Id, kul.Kod, kul.Isim FROM ne_Kullanici AS kul " +
                " INNER JOIN ne_KullaniciRol AS kRol ON kRol.KullaniciId = kul.Id " +
                " INNER JOIN ne_Rol AS rol ON rol.Id = kRol.RolId " +
                " WHERE " +
                " rol.Kod = @Kod " +
                " AND kul.DepoId = @DepoId";
            DataTable result = DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter() {ParameterName="@Kod",Value=kod } ,
                new SqlParameter() {ParameterName="@DepoId",Value=depoId}
            });

            return result;
        }

        public DataTable IsEmriListesi(TipIsEmri isEmri)
        {
            IsEmriOp isEmriOp = new IsEmriOp();
            return isEmriOp.ListeKullanici(_kullanici.Id, isEmri);
        }

        /// <summary>
        /// Modul bilgilerini List<Modul> olarak geriye döndürür.
        /// </summary>
        /// <returns></returns>
        public List<Modul> ModulOlustur()
        {

            try
            {
                List<Modul> moduls = new List<Modul>();
                string cmdText = "select Id, " +
                    "ModulId, " +
                    "Isim ," +
                    "ImageIndex from ne_Modul where RootId='0' and Aktif=1";
                DataTable dt = DBDataTable(cmdText);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Guid Id = item["Id"].ToString().ToGuid();
                        string modulId = item["ModulId"].ToString();
                        string isim = item["Isim"].ToString();
                        int imgIndex = item["ImageIndex"].ToString().ToInt();

                        Modul modul = new Modul(Id, SubModulOlustur(modulId), isim, imgIndex, modulId);

                        moduls.Add(modul);
                    }
                }

                return moduls;
            }
            catch (Exception ex)
            {

                throw new Exception("\nModulOlustur\n" + ex.Message);
            }
            finally
            {
            }
        }

        /// <summary>
        /// SubModul bilgilerini List<SubModul> olarak geriye döndürür.
        /// </summary>
        /// <param name="rootId"></param>
        /// <returns></returns>
        public List<SubModul> SubModulOlustur(string rootId)
        {
            try
            {
                List<SubModul> subModuls = new List<SubModul>();
                string cmdText = " select m.Id  , " +
                         "m.ModulId ," +
                         "m.ClassName , " +
                         "m.ImageIndex , " +
                         "m.Isim as ModulIsim , " +
                         "m.Tip " +
                         "from ne_Modul m " +
                         "where RootId =@RootId ";
                DataTable dt = DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@RootId",Value=rootId } });

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        SubModul subModul = new SubModul();

                        Guid id = item["Id"].ToString().ToGuid();
                        string modulId = item["ModulId"].ToString();
                        string className = item["ClassName"].ToString();
                        int ımgIndex = item["ImageIndex"].ToString().ToInt();
                        string isim = item["ModulIsim"].ToString();
                        int tip = item["Tip"].ToString().ToInt();
                        if (tip == 0)
                        {
                            List<SubModul> subModuls2 = SubModulOlustur(modulId);
                            subModul = new SubModul(id, className, isim, false, ımgIndex, modulId, subModuls2);
                        }
                        else
                        {
                            subModul = new SubModul(id, className, isim, true, ımgIndex, modulId);
                        }
                        subModuls.Add(subModul);
                    }
                }

                return subModuls;
            }
            catch (Exception ex)
            {

                throw new Exception("\nSubModulOlustur\n" + ex.Message);
            }
            finally
            {
            }
        }

        /// <summary>
        /// Aldıgı Parametreleri  ModulRol Tablosuna ait RolId ve ModulId Alanları ile Kıyaslayıp
        /// Boolean Deger Döndürür
        /// </summary>
        /// <param name="rolId"></param>
        /// <param name="modulId"></param>
        /// <returns></returns>
        public Boolean YetkiIzni(Guid rolId, Guid modulId, Yetki yetki)

        {
            try
            {
                _connection.Open();
                int result = 0;
                string cmdText = "";
                switch (yetki)
                {
                    case Yetki.Giris:
                        cmdText = "select Giris from ne_ModulRol " +
                         "where ModulId=@ModulId and RolId=@RolId";
                        result = DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@ModulId",Value=modulId },
                new SqlParameter(){ParameterName="@RolId",Value=rolId } }).ExecuteScalar().ToInt();
                        if (result == 1)
                            return true;
                        else
                            return false;


                    case Yetki.Ekleme:
                        cmdText = "select Ekleme from ne_ModulRol " +
                 "where ModulId=@ModulId and RolId=@RolId";
                        result = DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@ModulId",Value=modulId },
                new SqlParameter(){ParameterName="@RolId",Value=rolId } }).ExecuteScalar().ToInt();
                        if (result == 1)
                            return true;
                        else
                            return false;

                    case Yetki.Silme:
                        cmdText = "select Silme from ne_ModulRol " +
       "where ModulId=@ModulId and RolId=@RolId";
                        result = DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@ModulId",Value=modulId },
                new SqlParameter(){ParameterName="@RolId",Value=rolId } }).ExecuteScalar().ToInt();
                        if (result == 1)
                            return true;
                        else
                            return false;

                    case Yetki.Guncelleme:
                        cmdText = "select Guncelleme from ne_ModulRol " +
       "where ModulId=@ModulId and RolId=@RolId";
                        result = DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@ModulId",Value=modulId },
                new SqlParameter(){ParameterName="@RolId",Value=rolId } }).ExecuteScalar().ToInt();
                        if (result == 1)
                            return true;
                        else
                            return false;
                    default:
                        return false;

                }

            }
            catch (Exception ex)
            {

                throw new Exception("\nGirisYetkisi\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

    }
}
