using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NewEraDepo.Models;
using System.Data;
using System.Drawing;

namespace NewEraDepo.Data
{
    class AyarlarDepoOp : DbOp
    {


        #region GetRegion
        /// <summary>
        /// Depo bilgilerini List olarak geri döndürür
        /// </summary>
        /// <returns></returns>
        public List<Depo> DepoListGetir()
        {
            try
            {
                List<Depo> depo = new List<Depo>();
                string cmdText = "select d.Id as Id ," +
                     " d.Isim as Isim ," +
                     " d.Kod as Kod ," +
                     " d.Aciklama as Aciklama ," +
                     " img.Id as ImageId ," +
                      "img.Image as Image ," +
                     " d.Tip from ne_Depo d left join ne_DepoImg img on d.Id=img.DepoId  order by d.Id ";
                return depo = GetDepo(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\nDepoGetir (LİST)\n" + ex.Message);
            }
        }

        /// <summary>
        /// Bir arese baglı alt adres bilgisini parametre olarak girilen tablo adını alarak ilgili 
        /// depodan List olarak geriye döndürür.
        /// </summary>
        /// <param name="ULId"></param>
        /// <param name="tblName"></param>
        /// <returns></returns>
        public List<BaseAdres> AdresListGetir(Guid ULId, string tblName)
        {
            try
            {
                List<BaseAdres> adres = new List<BaseAdres>();
                string cmdText = "select Id , " +
                    "Kod , " +
                    "Isim , " +
                    "ULId from " + tblName + " where ULID=@ULID order by Id";
                return adres = GetAdres(DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@ULID",Value=ULId }}));
            }
            catch (Exception ex)
            {

                throw new Exception("\nAdresGetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Bir adresin üst adresine baglı bilgileri ComboBox doldurmak için Datatable olarak geriye döndürür.
        /// </summary>
        /// <param name="ULId"></param>
        /// <param name="tblName"></param>
        /// <returns></returns>
        public DataTable ParentCBGetir(Guid ULId, string tblName)
        {
            try
            {
                string cmdText = "select Id , Isim from " + tblName + " where ULId=@ULId";
                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="ULId",Value=ULId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nParentCBGetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// DepoX tablosundaki verileri ComboBox doldurmak için Datatable olarak geriye döndürür.
        /// </summary>
        /// <returns></returns>
        public DataTable DepoXCBGetir()
        {
            try
            {
                string cmdText = "select TipNo , Isim from ne_DepoXTip";
                return DBDataTable(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\nParentCBGetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Depoya ait bilgiler DataTable olarak geriye döndürür
        /// </summary>
        /// <returns></returns>
        public DataTable DepoGetir()
        {

            try
            {
                string cmdText = "select d.Id as Id ," +
                    " d.Isim as Isim ," +
                    " d.Kod as Kod ," +
                    " d.Aciklama as Aciklama ," +
                    " img.Id as ImageId ," +
                    "img.Image as Image ," +
                    " d.Tip from ne_Depo d left join ne_DepoImg img on d.Id=img.DepoId  order by d.Id ";
                return DBDataTable(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\n DepoGetir\n" + ex.Message);
            }
        }
        /// <summary>
        /// KatGuncelleme için KatId , KatKod , KatIsim , ULId , Aciklama , DepoIsim , DepoKod
        /// alan aldlarına ait degerler Datatable olarak döndürür
        /// </summary>
        /// <returns></returns>
        public DataTable KatGetir()
        {

            try
            {


                string cmdText = "select" +
                        " kt.Id , " +
                       " kt.Kod as KatKod , " +
                       "kt.Isim as KatIsim , " +
                       "kt.ULId , " +
                       "d.Aciklama , " +
                       "d.Isim as DepoIsim , " +
                       "d.Kod as DepoKod " +
                        "from ne_DepoKat kt left join ne_Depo d on kt.ULId=d.Id order by kt.Kod";

                return DBDataTable(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\nKatGetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Depodaki bölge bilgilerini Datatable olarak geriye döndürür.
        /// </summary>
        /// <returns></returns>
        public DataTable BolgeGetir()
        {
            try
            {
                string cmdText = "select" +
                    " b.Id , " +
                    "b.Isim as BolIsim , " +
                    "b.Kod as BolKod , " +
                    "k.Isim as KatIsim , " +
                    "k.Id as KatId , " +
                    "d.Isim as DepoIsim , " +
                    "d.Id as DepoId " +
                    " from ne_DepoBolge b left join ne_DepoKat k on b.ULId = k.Id " +
                    "  left join ne_Depo d on k.ULId = d.Id order by b.Kod";

                return DBDataTable(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\nBolgeGetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Depodaki raf bilgilerini Datatable olarak geriye döndürür.
        /// </summary>
        /// <returns></returns>
        public DataTable RafGetir()
        {
            try
            {
                string cmdText = "select " +
                       "r.Id , " +
                       "r.Isim as RafIsim , " +
                       "r.Kod as Kod , " +
                       "b.Isim as BolIsim , " +
                       "k.Isim as KatIsim , " +
                       "D.Isim as DepoIsim from ne_DepoRaf r " +
                       "left join ne_DepoBolge b on r.ULId=b.Id " +
                       "left join ne_DepoKat k on b.ULId=k.Id " +
                       "left Join ne_Depo d on k.ULId=d.Id order by r.Kod";

                return DBDataTable(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\nRafgetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Depodaki koy bilgilerinini Datatable olarak geriye döndürür.
        /// </summary>
        /// <returns></returns>
        public DataTable KoyGetir()
        {
            try
            {
                string cmdText = "select " +
                    "ky.Id ," +
                    "ky.Isim as KoyIsim , " +
                    "ky.Kod , " +
                    "ky.ULId , " +
                    "r.Isim as RafIsim , " +
                    "b.Isim as BolIsim , " +
                    "k.Isim As KatIsim , " +
                    "d.Isim as DepoIsim from ne_DepoKoy ky " +
                    "left join ne_DepoRaf r on ky.ULId = r.Id " +
                    "left join ne_DepoBolge b on r.ULId = b.Id " +
                    "left join ne_DepoKat k on b.ULId = k.Id " +
                    "left join ne_Depo d on k.ULId = d.Id order by ky.Kod";
                return DBDataTable(cmdText);
            }
            catch (Exception ex)
            {

                throw new Exception("\nKoyGetir\n" + ex.Message);
            }
        }

        /// <summary>
        /// Adress ekleme ve güncelleme işlemleri için combobaxları doldurur
        /// </summary>
        /// <param name="ULId"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable AdresDTGetir(Guid ULId, string tableName)
        {
            try
            {
                string cmdText = "select Id ,ULId,Kod ,Isim from " + tableName + " where ULId=@ULId order by Kod";
                return DBDataTable(cmdText, new List<SqlParameter>() {
            new SqlParameter(){ParameterName="@ULId",Value=ULId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nAdresCBGetir\n" + ex.Message);
            }
        }


        /// <summary>
        /// Depodaki  bilgilerini Datatable olarak geriye döndürür.
        /// </summary>
        /// <param name="ULId"></param>
        /// <returns></returns>
        public DataTable AdresDepoXGetir(Guid ULId)
        {
            try
            {
                string cmdText = "select " +
                    "x.Id , " +
                    "x.ULId , " +
                    "x.Kod , " +
                    "x.Isim, t.Isim as Tip " +
                    " from ne_DepoX x " +
                    "left join ne_DepoXTip t on x.Tip=t.TipNo " +
                    " where ULId=@ULId";
                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="ULId",Value=ULId } });
            }
            catch (Exception ex)
            {

                throw new Exception("\nAdresDepoXGetir\n" + ex.Message);
            }
        }

        public DataTable AdresKapiGetir()
        {
            try
            {
                string cmdText = "select k.Id as KapiId , " +
                        " k.Kod as KapiKod , " +
                        " k.ULId as ULId , " +
                        " k.Tip As Tip , " +
                        "k.Isim as KapiIsim , " +
                        "dx.Isim as DepoXIsim from ne_DepoKapi k " +
                        "left join ne_DepoX dx on k.ULId = dx.Id where dx.Tip = @Tip order by k.Kod";
                return DBDataTable(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ ParameterName="@Tip",Value=TipAdres.Kapi.ToInt()} });
            }
            catch (Exception ex)
            {

                throw new Exception("\nAdresKapiGetir\n" + ex.Message);
            }
        }

        public DataTable CbDepoXGetir()
        {
            try
            {
                string cmdText = "Select Id , Isim from ne_DepoX where Tip=@Tip";
                return DBDataTable(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ ParameterName="@Tip",Value=TipAdres.Kapi.ToInt()} });
            }
            catch (Exception ex)
            {

                throw new Exception("\nCbDepoXGetir\n"+ex.Message);
            }
        }
        #endregion




        #region InsertRegion
        public int DepoEkle(Guid depoId, string isim, string kod, string aciklama, int tip)
        {
            try
            {
                _connection.Open();
                string cmdtext = "insert into ne_Depo (" +
                                "[Id] " +
                                ",[Isim] " +
                                ",[Kod] " +
                                ",[Aciklama] " +
                                ",[Tip] " +
                                ",[KayitKullaniciId] " +
                                ",[GuncellemeKullaniciId]) " +
                                "values( " +
                                "@DepoId , " +
                                "@Isim , " +
                                "@Kod , " +
                                "@Aciklama , " +
                                "@Tip , " +
                                "@ID , " +
                                "@ID )";
                int result = DBCmd(cmdtext, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@DepoId",Value=depoId },
                new SqlParameter(){ParameterName="@Kod",Value=kod },
                new SqlParameter(){ParameterName="@Isim",Value=isim},
                new SqlParameter(){ParameterName="@Aciklama",Value=aciklama},
                new SqlParameter(){ParameterName="@Tip",Value=tip},
                new SqlParameter(){ParameterName="@ID",Value=_kullanici.Id }}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nDepoEkle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

        }

        public int DepoImgEkle(Guid depoId,Image img)
        {
            try
            {
                int result = -1;
                Guid Id = Guid.NewGuid();
               
                byte[] arr;
                arr = img.ImgToByte();
                _connection.Open();
                string cmdtext = "Insert into ne_DepoImg ( " +
                    "Id ," +
                    "DepoId , " +
                    "Image , " +
                    "KayitKullaniciId , " +
                    "GuncellemeKullaniciId ) values ( " +
                    "@Id ," +
                    "@DepoId , " +
                    "@Image , " +
                    "@AdminId , " +
                    "@AdminId ) ";

                result = DBCmd(cmdtext, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Id",Value=Id },
                new SqlParameter(){ParameterName="@DepoId",Value=depoId },
                new SqlParameter(){ ParameterName="@Image",Value=arr},
                new SqlParameter(){ ParameterName="@AdminId",Value=_kullanici.Id} }).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nDepoImgEkle"+ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int AdresEkle(Guid ulId, string kod, string isim, string tableName)
        {
            try
            {
                _connection.Open();
                Guid Id = Guid.NewGuid();
                string cmdText = "insert into " + tableName + " (" +
                    "Id , " +
                    "Kod , " +
                    "Isim , " +
                    "ULId , " +
                    "KayitKullaniciId , " +
                    "GuncellemeKullaniciId ) values( " +
                    "@Id , " +
                    "@Kod , " +
                    "@Isim , " +
                    "@ULId , " +
                    "@AdminID , " +
                    "@AdminID )";

                int result = DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Id",Value=Id },
                 new SqlParameter(){ParameterName="@Kod",Value=kod },
                 new SqlParameter(){ParameterName="@Isim",Value=isim },
                 new SqlParameter(){ ParameterName="@ULId",Value=ulId},
                 new SqlParameter(){ParameterName="@AdminID",Value=_kullanici.Id }}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nAdresEkle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        
        public int DepoXEkle(Guid UlId, string kod, string isim, int tip, string tblName)
        {
            try
            {
                _connection.Open();
                Guid id = Guid.NewGuid();
                string cmdText = "insert into " + tblName + " ( " +
                    "Id , " +
                    "Kod , " +
                    "Isim , " +
                    "ULId , " +
                    "Tip , " +
                    "KayitKullaniciId , " +
                    "GuncellemeKullaniciId ) values ( " +
                    "@Id , " +
                    "@Kod , " +
                    "@Isim , " +
                    "@ULId , " +
                    "@Tip , " +
                    "@AdminID , " +
                    "@AdminID ) ";


                int result = DBCmd(cmdText, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Id",Value=id },
                new SqlParameter(){ParameterName="@Kod",Value=kod },
                new SqlParameter(){ParameterName="@Isim",Value=isim },
                new SqlParameter(){ParameterName="@ULId",Value=UlId },
                 new SqlParameter(){ParameterName="@Tip",Value=tip },
                new SqlParameter(){ ParameterName="@AdminID",Value=_kullanici.Id}}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nDepoXEkle\n" + ex.Message);

            }
            finally
            {
                _connection.Close();
            }
        }

        public int DepoKapiEkle(Guid ULID ,string kod, string isim, int tip=0)
        {
            try
            {
                int result = -1;
                _connection.Open();
                Guid id = Guid.NewGuid();
                string cmdText = "insert into ne_DepoKapi ( " +
                    "Id , " +
                    "Kod , " +
                    "Isim , " +
                    "ULId , " +
                    "Tip , " +
                    "[KayitKullaniciId] , " +
                    "[GuncellemeKullaniciId] )  values ( " +
                    "@Id , " +
                    "@Kod , " +
                    "@Isim , " +
                    "@ULId , " +
                    "@Tip , " +
                    "@AdminId , " +
                    "@AdminId ) ";
                result = DBCmd(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Id",Value=id } ,
                new SqlParameter(){ ParameterName="@Kod",Value=kod} ,
                new SqlParameter(){ParameterName="@Isim",Value=isim } ,
                new SqlParameter(){ParameterName="@ULId",Value=ULID } ,
                new SqlParameter(){ ParameterName="@Tip",Value=tip} ,
                new SqlParameter(){ParameterName="@AdminId",Value=_kullanici.Id } }).ExecuteNonQuery();

                return result;
            }
            catch (Exception ex) 
            {

                throw new Exception("\nDepoKapiEkle\n"+ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region UpdateRegion
        /// <summary>
        /// Depo bilgilerini günceller
        /// </summary>
        /// <param name="depoId"></param>
        /// <param name="isim"></param>
        /// <param name="kod"></param>
        /// <param name="aciklama"></param>
        /// <param name="tip"></param>
        /// <returns></returns>
        public int DepoGuncelle(Guid depoId, string isim, string kod, string aciklama, int tip = 0)
        {
            try
            {
                _connection.Open();
                string cmdtext = "update ne_Depo set " +
                    "Isim=@Isim , " +
                    "Kod=@Kod , " +
                    "Aciklama=@Aciklama , " +
                //    "Tip=@Tip , " +
                    "GuncellemeKullaniciId=@ID , " +
                    "[GuncellemeTarihi]=getDate() where Id=@DepoId ";
                int result = DBCmd(cmdtext, new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Isim",Value=isim },
                new SqlParameter(){ParameterName="@Kod",Value=kod },
                new SqlParameter(){ParameterName="@Aciklama",Value=aciklama },
             //   new SqlParameter(){ParameterName="@Tip",Value=tip },
                new SqlParameter(){ParameterName="@ID",Value=_kullanici.Id },
                new SqlParameter(){ParameterName="@DepoId",Value=depoId }}).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nDepoGuncelle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int DepoImgGuncelle(Guid ImgId,Image img)
        {
            try
            {
                int result = -1;
                
                byte[] arr;
                arr = img.ImgToByte();
                _connection.Open();

                string cmdText = "update ne_DepoImg set " +
                    "Image=@Image , " +
                    "[GuncellemeKullaniciId]=@AdminId , " +
                    "[GuncellemeTarihi]=getDate() where Id=@Id";

                result = DBCmd(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@Image",Value=arr },
                new SqlParameter(){ParameterName="@AdminId",Value=_kullanici.Id },
                new SqlParameter(){ParameterName="@Id",Value=ImgId } }).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nDepoImgGuncelle\n"+ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }


        /// <summary>
        /// Adres Bilgilerini günceller
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="ULId"></param>
        /// <param name="isim"></param>
        /// <param name="kod"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public int AdresGuncelle(Guid Id, Guid ULId, string isim, string kod, string tableName)
        {
            try
            {
                _connection.Open();
                string cmdtext = "update " + tableName + " set " +
                    "Kod=@Kod , " +
                    "Isim=@Isim , " +
                    " GuncellemeKullaniciId=@AdminID , " +
                    "GuncellemeTarihi=getDate() " +
                    "where Id=@ID";

                int result = DBCmd(cmdtext, new List<SqlParameter>()
                {
                    new SqlParameter(){ParameterName="Kod",Value=kod},
                    new SqlParameter(){ParameterName="Isim",Value=isim},
                    new SqlParameter(){ParameterName="AdminID",Value=_kullanici.Id},
                    new SqlParameter(){ParameterName="ID",Value=Id}
                }).ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nBolgeGuncelle\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Depo Kapi Bilgilerini günceller
        /// </summary>
        /// <returns></returns>
        public int DepoKapiGuncelle(Guid id,string isim ,Guid uLId, int tip=0)
        {
            try
            {
                int result = -1;
                _connection.Open();
                string cmdText = "update  ne_DepoKapi set " +
                    "Isim=@Isim , " +
                    "Tip=@Tip , " +
                    "ULId=@ULId , " +
                    "[GuncellemeKullaniciId]=@AdminId , " +
                    "[GuncellemeTarihi]=getDate() where Id=@Id";
                result = DBCmd(cmdText,new List<SqlParameter>() {
                new SqlParameter(){ParameterName="@ULId",Value=uLId },
                new SqlParameter(){ParameterName="@Isim",Value=isim } ,
                new SqlParameter(){ParameterName="@Tip",Value=tip } ,
                 new SqlParameter(){ParameterName="@Id",Value=id } ,
                new SqlParameter(){ ParameterName="@AdminId",Value=_kullanici.Id} }).ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nDepoKapiGuncelle\n"+ex.Message);
            }finally
            {
                _connection.Close();
            }
        }

        #endregion
    }
}
