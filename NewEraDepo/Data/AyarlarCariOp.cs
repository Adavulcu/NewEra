using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NewEraDepo.Data
{
    class AyarlarCariOp:DbOp
    {
        #region GetRegion
        public DataTable CariGetir()
        {
            try
            {
                string cmdText = "  select c.Id as CariId ," +
                    " c.Kod as CariKod , c.Isim as CariIsim , " +
                    "c.Aciklama as Aciklama , l.Id as LogoId ," +
                    " l.Logo as Logo from ne_Cari c "+
                    "left join ne_CariLogo l on c.Id = l.CariId ";
                return DBDataTable(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\nCariGetir\n"+ex.Message);
            }

        }
        #endregion

        #region InsertRegion
        /// <summary>
        /// Cari EKler
        /// </summary>
        /// <param name="cariId"></param>
        /// <param name="cariKod"></param>
        /// <param name="cariIsim"></param>
        /// <param name="aciklama"></param>
        /// <returns></returns>
        public int CariEkle(Guid cariId,string cariKod,string cariIsim , string aciklama)
        {
            try
            {
                int result = -1;
                _connection.Open();
                string cmdText = "insert into ne_Cari (" +
                    "Id , " +
                    "Kod , " +
                    "Isim , " +
                    "Aciklama , " +
                    "[KayitKullaniciId] , " +
                    "[GuncellemeKullaniciId] ) values ( " +
                    "@Id , " +
                    "@Kod , " +
                    "@Isim , " +
                    "@Aciklama , " +
                    "@AdminId , " +
                    "@AdminId )";
                result = DBCmd(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Id",Value=cariId },
                new SqlParameter(){ParameterName="@Kod",Value=cariKod },
                new SqlParameter(){ ParameterName="@Isim",Value=cariIsim},
                new SqlParameter(){ParameterName="@Aciklama",Value=aciklama },
                new SqlParameter(){ParameterName="@AdminId",Value=_kullanici.Id }}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nCariEkle\n"+ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        /// <summary>
        /// Cariye ait bir logo ekler
        /// </summary>
        /// <param name="cariId"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public int LogoEkle(Guid cariId, Image img)
        {
            try
            {
                int result = -1;
                Guid logoId = Guid.NewGuid();
                _connection.Open();
             
                byte[] arr;
                arr = img.ImgToByte();
                string cmdText = "insert into ne_CariLogo (" +
                    "Id ," +
                    "CariId , " +
                    "Logo , " +
                    "[KayitKullaniciId] ," +
                    "[GuncellemeKullaniciId] ) values ( " +
                    "@Id , " +
                    "@CariId , " +
                    "@Logo , " +
                    "@AdminId , " +
                    "@AdminId ) ";
                result = DBCmd(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Id",Value=logoId },
                new SqlParameter(){ParameterName="@CariId" ,Value=cariId},
                new SqlParameter(){ParameterName="@Logo",Value=arr },
                new SqlParameter(){ParameterName="@AdminId",Value=_kullanici.Id }}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nLogoEkle\n" + ex.Message);
            }finally
            {
                _connection.Close();
            }
        }
        #endregion


        #region UpdateRegion
        /// <summary>
        /// Cari günceller
        /// </summary>
        /// <param name="cariId"></param>
        /// <param name="cariKod"></param>
        /// <param name="cariIsim"></param>
        /// <param name="aciklama"></param>
        /// <returns></returns>
        public int CariGuncelle(Guid cariId, string cariKod, string cariIsim, string aciklama)
        {
            try
            {
                _connection.Open();
                int result = -1;
                string cmdText = "update ne_Cari set " +
                    "Kod=@Kod , " +
                    "Isim=@Isim , " +
                    "Aciklama=@Aciklama , " +
                    "[GuncellemeKullaniciId]=@AdminId , " +
                    "[GuncellemeTarihi]=getDate() where Id=@Id";
                result = DBCmd(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Id",Value=cariId } ,
                 new SqlParameter(){ParameterName="@Kod",Value=cariKod },
                 new SqlParameter(){ParameterName="@Isim",Value=cariIsim },
                 new SqlParameter(){ParameterName="@Aciklama",Value=aciklama },
                 new SqlParameter(){ParameterName="@AdminId",Value=_kullanici.Id }}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nCariGuncelle\n"+ex.Message);
            }finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Logo günceller
        /// </summary>
        /// <param name="logoId"></param>
        /// <param name="cariId"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public int LogoGuncelle(Guid logoId, Image img)
        {
            try
            {
                _connection.Open();
                int result = -1;
                
                byte[] arr;

                arr = img.ImgToByte();
                string cmdText = "update ne_CariLogo set " +
                    "Logo=@Logo , " +
                    "[GuncellemeKullaniciId]=@AdminId , " +
                    "[GuncellemeTarihi]=getDate() where Id=@Id";
                
                result = DBCmd(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Logo",Value=arr },
                new SqlParameter(){ParameterName="@Id",Value=logoId },
                new SqlParameter(){ParameterName="@AdminId",Value=_kullanici.Id } }).ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nLogoGuncelle\n"+ex.Message);
            }finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}
