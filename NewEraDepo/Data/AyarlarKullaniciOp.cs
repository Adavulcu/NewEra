using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewEraDepo.Models;
namespace NewEraDepo.Data
{
    public class AyarlarKullaniciOp : DbOp
    {
        #region GetRegion

        /// <summary>
        /// Kullanici ayarları için gerekli kullanıcı bilgilerini List olarak geriye döndürür
        /// </summary>
        /// <returns></returns>
        public List<AyarlarKullanici> KullaniciGetir()
        {
            try
            {
                List<AyarlarKullanici> ayarlarKullanici = new List<Models.AyarlarKullanici>();

                string cmdTetx = "SELECT distinct(k.Id) , " +
           " k.Kod , " +
           " k.Isim , " +
            "k.Sifre , " +
            "d.Isim as Depo , " +
            "k.KayitTarihi , " +
            "k.GuncellemeTarihi , " +
            "d.Id as [DepoId] " +
            "from ne_Kullanici k left join  ne_Depo d on k.DepoId = d.Id  left join ne_KullaniciRol kr on k.Id = kr.KullaniciId " +
            "left join ne_Rol r on kr.RolId = r.Id ";
                ayarlarKullanici = GetAyarlarList(cmdTetx);

                return ayarlarKullanici;
            }
            catch (Exception ex)
            {

                throw new Exception("\ngetAyarlar\n" + ex.Message);
            }
        }

        /// <summary>
        /// Kullanıcılar için bütün rol bilgisini DataTable olrak geriye döndürür.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetRoles(Guid id)
        {
            try
            {
                DataTable dt = new DataTable();

                string cmdText = "select rol.Id  , rol.Kod , rol.Isim" +
                    ",CASE WHEN kr.RolId is not null THEN CAST(1 as bit) ELSE CAST(0 AS bit) end as IsChecked " +
                    "  from ne_Rol as rol " +
                    " left outer join ne_KullaniciRol as kr on kr.RolId = rol.Id and kr.KullaniciId=@KullaniciId ";

                dt = DBDataTable(cmdText, new List<SqlParameter>() { new SqlParameter() { ParameterName = "@KullaniciId", Value = id } });

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception("\nGetRoles\n" + ex.Message);
            }
        }

        /// <summary>
        /// ComboBox doldurmak için rol bilgilerini DataTable olarak geriye döndürürü (Admin rollleri Haric).
        /// </summary>
        /// <returns></returns>
        public DataTable CbGetRoles()
        {
            try
            {
                string cmdText = "Select Id ,Kod from ne_Rol ";
                return DBDataTable(cmdText);
                //string cmdText = "Select Id ,Kod from ne_Rol where Kod!=@admin";
                //return DBDataTable(cmdText, new List<SqlParameter>() {
                //new SqlParameter(){ParameterName="@admin",Value=DM.KodAdmin} });

            }
            catch (Exception ex)
            {

                throw new Exception("\nGerRoles\n" + ex.Message);
            }
        }

        /// <summary>
        /// Bir role ait Modul bilgilerini DataTable olarak geriye döndürür
        /// </summary>
        /// <param name="RolId"></param>
        /// <returns></returns>
        public DataTable ModulGetir(Guid RolId)
        {
            try
            {
                string cmdText = "select m.Id  ,m.ModulId , m.Isim" +
                   ",Isnull(Giris,cast(0 as bit)) as Giris " +
                   ",Isnull(Silme,cast(0 as bit)) as Silme " +
                   ",Isnull(Ekleme,cast(0 as bit)) as Ekleme " +
                   ",Isnull(Guncelleme,cast(0 as bit)) as Guncelleme " +
                   "  from ne_Modul as m " +
                   " left outer join ne_ModulRol as mr on m.Id = mr.ModulId and mr.RolId=@RolId" +
                   " where Tip=1  ";
                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@RolId",Value=RolId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nModulgetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Kullanıcıya ait rol bilgilerini List olarak geriye döndürür.
        /// </summary>
        /// <returns></returns>
        public List<AyarlarKullaniciDetail> GetKullaniciDetails()
        {
            try
            {
                List<AyarlarKullaniciDetail> list = new List<AyarlarKullaniciDetail>();

                string cmdText = "select kr.KullaniciId as KulId , kr.RolId , r.Kod , r.Isim from ne_KullaniciRol kr " +
                                "left join ne_Rol r on kr.RolId = r.Id";

                list = GetAyarlarDetailList(cmdText);

                return list;
            }
            catch (Exception ex)
            {

                throw new Exception("\nGetAyarlarDetails\n" + ex.Message);
            }
        }

        /// <summary>
        /// Parametre olarak algıgı rolId ve modulId ye ait modul bilgisini DataTable olarak döndürür.
        /// </summary>
        /// <param name="rolId"></param>
        /// <param name="modulId"></param>
        /// <returns></returns>
        public DataTable GetIdIsModulRolExist(Guid rolId, Guid modulId)
        {

            try
            {
                DataTable dt = new DataTable();
                string cmdText = "select Id from ne_ModulRol where RolId=@RolId and ModulId=@ModulId";
                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@RolId ",Value=rolId},
                new SqlParameter(){ParameterName="@ModulId",Value=modulId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nIsModulRolExist\n" + ex.Message);
            }
        }

        /// <summary>
        /// Depo Bilgilerini DataTable olarak geriye döndürür.
        /// </summary>
        /// <returns></returns>
        public DataTable KullaciniDepoCbDoldur()
        {

            return DBDataTable("select Id , Isim from ne_Depo");

        }
        #endregion



        #region UpdateRegion

        /// <summary>
        /// Kullanıcı bilgilerini günceller.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Kod"></param>
        /// <param name="Isim"></param>
        /// <param name="Sifre"></param>
        /// <param name="depoId"></param>
        /// <returns></returns>
        public int KullaniciGuncelle(Guid Id, string Kod, string Isim, string Sifre, Guid depoId)
        {


            try
            {
                // Guid DepoId = new Guid(depoId);
                string cmdText = "update ne_Kullanici set" +
                    " Kod=@Kod , " +
                    "Isim=@Isim , " +
                    "Sifre=@Sifre  , " +
                    "DepoId=@DepoId , " +
                    "GuncellemeKullaniciId=@GuncellemeKullaniciId , " +
                    "[GuncellemeTarihi]=getDate() " +
                    "where Id=@Id";
                _connection.Open();
                int result = DBCmd(cmdText, new List<SqlParameter>() { new SqlParameter() {ParameterName="@Id",Value=Id },
            new SqlParameter(){ParameterName="@Kod",Value=Kod },
            new SqlParameter(){ParameterName="@Isim",Value=Isim },
            new SqlParameter(){ParameterName="@Sifre",Value=Sifre },
            new SqlParameter(){ParameterName="@DepoId",Value=depoId },
            new SqlParameter(){ ParameterName="@GuncellemeKullaniciId",Value=_kullanici.Id}}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nKullaniciGuncelle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Rollere ait modulleri günceller.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="giris"></param>
        /// <param name="silme"></param>
        /// <param name="ekleme"></param>
        /// <param name="guncelleme"></param>
        /// <returns></returns>
        public int ModulRolGuncelle(Guid id, bool giris, bool silme, bool ekleme, bool guncelleme)
        {
            try
            {
                _connection.Open();
                string cmdText = "Update ne_ModulRol set " +
                    "Giris=@Giris , " +
                    "Silme=@Silme , " +
                    "Ekleme=@Ekleme , " +
                    "Guncelleme=@Guncelleme , " +
                    "GuncellemeKullaniciId=@AdminId , " +
                    "GuncellemeTarihi=getDate() " +
                    "where Id=@Id";
                int result = DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Giris",Value=giris } ,
                new SqlParameter(){ParameterName="@Silme",Value=silme },
                new SqlParameter(){ParameterName="@Ekleme",Value=ekleme },
                new SqlParameter(){ParameterName="@Guncelleme",Value=guncelleme },
                new SqlParameter(){ParameterName="@AdminId",Value=_kullanici.Id },
                new SqlParameter(){ParameterName="@Id",Value=id }}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nModulRolGuncelle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region InsertRegion
        /// <summary>
        /// Rollere ait modulleri ekler.
        /// </summary>
        /// <param name="rolId"></param>
        /// <param name="modulId"></param>
        /// <param name="giris"></param>
        /// <param name="silme"></param>
        /// <param name="ekleme"></param>
        /// <param name="guncelleme"></param>
        /// <returns></returns>
        public int ModulRolEkle(Guid rolId, Guid modulId, bool giris, bool silme, bool ekleme, bool guncelleme)
        {
            try
            {
                int result = -1;
                _connection.Open();
                Guid id = Guid.NewGuid();
                string cmdText = "insert into ne_ModulRol (" +
                    "Id , " +
                    "RolId , " +
                    "ModulId , " +
                    "Giris , " +
                    "Ekleme, " +
                    "Silme , " +
                    "Guncelleme , " +
                    "KayitKullaniciId , " +
                    "GuncellemeKullaniciId ) values (" +
                    "@Id , " +
                    "@RolId , " +
                    "@ModulId , " +
                    "@Giris , " +
                    "@Ekleme , " +
                    "@Silme , " +
                    "@Guncelleme , " +
                    "@AdminId, " +
                    "@AdminId) ";
                result = DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Id",Value=id },
                new SqlParameter(){ParameterName="@RolId",Value=rolId },
                new SqlParameter(){ParameterName="@ModulId",Value=modulId },
                new SqlParameter(){ParameterName="@Giris",Value=giris },
                new SqlParameter(){ParameterName="@Ekleme",Value=ekleme },
                new SqlParameter(){ParameterName="@Silme",Value=silme },
                new SqlParameter(){ ParameterName="@Guncelleme",Value=guncelleme},
                new SqlParameter(){ParameterName="@AdminId",Value=_kullanici.Id }}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("ModulRolEkle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Kullanıcıya ait Rolleri ekler.
        /// </summary>
        /// <param name="KullaniciId"></param>
        /// <param name="rolId"></param>
        /// <returns></returns>
        public int KullaniciRolEkle(Guid KullaniciId, string rolId)
        {
            try
            {
                Guid RolId = new Guid(rolId);
                _connection.Open();
                string cmdText = "insert into ne_KullaniciRol (RolId,KullaniciId,GuncellemeKullaniciId,KayitKullaniciId)" +
                    " values(@RolId,@KullaniciId,@ID,@ID)  ";

                int result = DBCmd(cmdText, new List<SqlParameter>() { new SqlParameter() {ParameterName="@RolId",Value=RolId },
            new SqlParameter(){ ParameterName="@KullaniciId",Value=KullaniciId},
                new SqlParameter(){ ParameterName="@ID",Value=_kullanici.Id}}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nKullaniciRolEkle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }


        /// <summary>
        /// Kullanıcı Ekler.
        /// </summary>
        /// <param name="KullaniciId"></param>
        /// <param name="kod"></param>
        /// <param name="isim"></param>
        /// <param name="sifre"></param>
        /// <param name="depoId"></param>
        /// <returns></returns>
        public int KullaniciEkle(Guid KullaniciId, string kod, string isim, string sifre, Guid depoId)
        {
            try
            {
                _connection.Open();
                string cmdText = "insert into ne_Kullanici (Id,Kod,Isim,Sifre,DepoId,KayitKullaniciId,GuncellemeKullaniciId) " +
                    " values (" +
                    "@KullaniciId , " +
                    "@Kod , " +
                    "@Isim ," +
                    "@Sifre , " +
                    "@DepoId , " +
                    "@ID , " +
                    "@ID ) ";

                int result = DBCmd(cmdText, new List<SqlParameter>() {
                 new SqlParameter() {ParameterName="@KullaniciId",Value=KullaniciId },
                 new SqlParameter() {ParameterName="@Kod",Value=kod },
                 new SqlParameter() {ParameterName="@Isim",Value=isim },
                 new SqlParameter() {ParameterName="@Sifre",Value=sifre },
                 new SqlParameter() {ParameterName="@DepoId",Value=depoId },
                 new SqlParameter() { ParameterName="@ID",Value=_kullanici.Id}}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nKullaniciEkle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region DeleteRegion
        /// <summary>
        /// Kullanıcıya ait rolü siler
        /// </summary>
        /// <param name="KullanicIdi"></param>
        /// <param name="rolId"></param>
        /// <returns></returns>
        public int KullaniciRolSil(Guid KullanicIdi, string rolId)
        {
            try
            {
                Guid RolId = new Guid(rolId);
                _connection.Open();
                string cmdText = "delete from ne_KullaniciRol where KullaniciId=@KullaniciId and RolId=@RolId";
                int result = DBCmd(cmdText, new List<SqlParameter>() { new SqlParameter() {ParameterName="@KullaniciId",Value=KullanicIdi },
            new SqlParameter(){ParameterName="@RolId",Value=RolId } }).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nKullaniciRolSil\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}
