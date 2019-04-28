using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo.Data
{
    public class StokOp : DbOp
    {

        #region GetRegion

        /// <summary>
        /// Bir depoya ait AdresId degerini DataTable olarak geri döndürür
        /// </summary>
        /// <param name="kodAdres"></param>
        /// <param name="depoId"></param>
        /// <returns></returns>
        public DataTable AdresKodGetir(string kodAdres, Guid depoId)
        {
            try
            {
                string cmdTextt = "select AdresId from ne_V_DepoAdresListe where" +
                    " DepoId=@DepoId and Adres=@Kod ";
                return DBDataTable(cmdTextt, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Kod",Value=kodAdres },
                 new SqlParameter(){ParameterName="@DepoId",Value=depoId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nAdresKodgetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Depodaki Adreslere ait bilgileri DataTable olarak geriye döndürür.
        /// </summary>
        /// <returns></returns>
        public DataTable AdresUrunGetir()
        {
            try
            {
                string cmdTextt = " select  dal.Adres , " +
                     "s.Kod as UrunKod ," +
                     "dxs.StokId , " +
                     "dxs.AdresId , " +
                     "s.Isim as UrunIsim  , " +
                     "dal.DepoId  , " +
                     "dxs.Id from ne_DepoXStok dxs " +
                     "inner join ne_V_DepoAdresListe dal on dxs.AdresId = dal.AdresId " +
                     "inner join ne_Stok s on dxs.StokId = s.Id ";
                return DBDataTable(cmdTextt);
            }
            catch (Exception ex)
            {

                throw new Exception("\nAdresUrunGetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Belirli bir adresteki ürün ismini DataTable olarak geriye döndürür.
        /// </summary>
        /// <param name="kodAdres"></param>
        /// <returns></returns>
        public DataTable AdresUrunGetir(string kodAdres)
        {
            try
            {
                string cmdTextt = "select s.Isim as StokIsim from ne_Stok s " +
                      " left join ne_DepoXStok dxs on s.Id = dxs.StokId " +
                      " left join ne_V_DepoAdresListe dal on dxs.AdresId = dal.AdresId where dal.Adres = @Kod";
                return DBDataTable(cmdTextt, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="Kod",Value=kodAdres } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nStokUrunGetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Bir ürüne ait bilgileri DataTable olarak geriye döndürür.
        /// </summary>
        /// <param name="kodUrun"></param>
        /// <returns></returns>
        public DataTable UrunBilgisiGetir(string kodUrun)
        {
            try
            {
                string cmdText = "select s.Id ,s.Isim from ne_Stok s " +
                " left join ne_StokBarkod sb on s.Id = sb.StokId " +
                " where s.Kod = @Kod or sb.Kod =@Kod ";

                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Kod" ,Value=kodUrun} });
            }
            catch (Exception ex)
            {

                throw new Exception("\nUrunBilgisiGetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Bir Depo ya ait bilgileri ComboBox doldurmak için DataTable olarak geriye döndürür.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable DepoCbGetir(Guid id)
        {
            try
            {
                string cmdText = "select Id , Isim from ne_Depo where Id=@Id";
                return DBDataTable(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ ParameterName="@Id" ,Value=id} });
            }
            catch (Exception ex)
            {

                throw new Exception("\nDepoCbGetir\n"+ex.Message);
            }
        }
        #endregion

        #region InsertRegion
        /// <summary>
        /// Depodaki hücrelere ürün ekleme işlemi yapar
        /// </summary>
        /// <param name="adresId"></param>
        /// <param name="stokId"></param>
        /// <returns></returns>
        public int StokEkle(Guid adresId, Guid stokId)
        {
            int result = -1;
            try
            {
                _connection.Open();
                Guid id = Guid.NewGuid();
                string cmdText = "insert into ne_DepoXStok (" +
                    "Id , " +
                    "AdresId , " +
                    "StokId , " +
                    "KayitKullaniciId , " +
                    "GuncellemeKullaniciId ) values( " +
                    "@Id , " +
                    "@AdresId , " +
                    "@StokId , " +
                    "@AdminId , " +
                    "@AdminId )";
                result = DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ ParameterName="@Id",Value=id},
                 new SqlParameter(){ ParameterName="@AdresId",Value=adresId},
                 new SqlParameter(){ParameterName="@StokId",Value=stokId },
                 new SqlParameter(){ParameterName="@AdminId",Value=_kullanici.Id }}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nStokEkle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();

            }
        }
        #endregion

        #region UpdateRegion
        /// <summary>
        /// Depodaki hücreyi günceller
        /// </summary>
        /// <param name="adresId"></param>
        /// <param name="stokId"></param>
        /// <returns></returns>
        public int StokGuncelle(Guid adresId, Guid stokId)
        {
            int result = -1;
            try
            {
                _connection.Open();
                string cmdText = "update ne_DepoXStok set " +
                    "StokId=@StokId, " +
                    "GuncellemeKullaniciId= @AdminId , " +
                    "[GuncellemeTarihi]=getDate() where AdresId=@AdresId";

                result = DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@StokId",Value=stokId },
                new SqlParameter(){ParameterName="@AdresId",Value=adresId },
                new SqlParameter(){ParameterName="@AdminId",Value=_kullanici.Id }}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nStokGuncelle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region DeleteRegion
        /// <summary>
        /// Depodaki hücrede bulunan ürünü siler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int StokSil(Guid id)
        {
            try
            {
                _connection.Open();
                int result = 0;
                string cmdText = "delete from ne_DepoXStok where Id=@Id";
                result = DBCmd(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Id",Value=id } }).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nStokSil\n"+ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        #endregion
    }
}
