using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using NewEraDepo.Models;


namespace NewEraDepo.Data
{
    public class DbOp 
    {
        public readonly string _connectionString;
        public readonly SqlConnection _connection;
        public readonly Kullanici _kullanici;

        private SqlDataReader _reader;

        public DbOp()
        {
            _connectionString = DM.ConnectionString;
            _connection = DM.Connection;
            _kullanici = DM.kullanici;
        }

        /// <summary>
        /// Parametre olarak aldıgı string degerini ve List<SqlParameter> degerini kullanarak
        /// bir SqlCommand nesnesi oluşturup geriye döndürür.
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="parametre"></param>
        /// <returns></returns>
        public SqlCommand DBCmd(string cmdText, List<SqlParameter> parametre = null)
        {
            SqlCommand result = new SqlCommand(cmdText, _connection);
            result.Parameters.Clear();
            if (parametre != null)
                foreach (var item in parametre)
                {
                    result.Parameters.AddWithValue(item.ParameterName, item.Value);
                }
            return result;
        }

        /// <summary>
        /// Parametre olarak aldıgı string degerini ve List<SqlParameter> degerini kullanarak
        /// bir DataTable nesnesi oluşturarak geriye döndürür.
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="parametre"></param>
        /// <returns></returns>
        public DataTable DBDataTable(string cmdText, List<SqlParameter> parametre = null)
        {
            try
            {
                DataTable result = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(DBCmd(cmdText, parametre));
                _connection.Open();
                da.Fill(result);
               
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("\nDBDatTable\n"+ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Parametre olarak aldıgı string degerini ve List<SqlParameter> degerini kullanarak
        ///  bir SqlDataReader nesnesi oluşturarak geriye döndürür.
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="parametre"></param>
        /// <returns></returns>
        public SqlDataReader DBReader(string cmdText, List<SqlParameter> parametre = null)
        {
           
            try
            {
                _connection.Open();
                _reader = DBCmd(cmdText, parametre).ExecuteReader();
                return _reader;
            }
            catch (Exception ex)
            {

                throw new Exception("\nDBReader\n"+ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }


      public List<Depo> GetDepo(string cmdText)
        {
            try
            {
                List<Depo> depo = new List<Depo>();
                _connection.Open();
                _reader = DBCmd(cmdText).ExecuteReader();
                while (_reader.Read())
                {
                    depo.Add(ReaderToDepo(_reader));
                }
                return depo;
            }
            catch (Exception ex)
            {

                throw new Exception("\nGetDepo\n"+ex.Message);
            }
            finally
            {
                _connection.Close();
                _reader.Close();
            }
        }

        private Depo ReaderToDepo(SqlDataReader reader)
        {
            try
            {
                Depo depo;
                Guid id = reader.GetGuid(0);
                string isim = reader.GetString(1);
                string kod = reader.GetString(2);
                string aciklama = reader.GetString(3);
                int tip = reader.GetInt32(6);
                Guid imgId = reader.GetGuid(4);
               string img =reader.GetString(5);
                byte[] arr= img.To<Byte[]>();
                depo = new Depo(id,isim,kod,aciklama,tip,imgId,arr.ByteToImage());
                return depo;
            }
            catch (Exception ex)
            {

                throw new Exception("\nReaderToDepo\n"+ex.Message);
            }
        }

       public List<BaseAdres> GetAdres(SqlCommand cmd)
        {
            try
            {
                List<BaseAdres> adresList = new List<BaseAdres>();
                _connection.Open();
                _reader = cmd.ExecuteReader();
                while (_reader.Read())
                {
                    adresList.Add(ReaderToAdres(_reader));
                }
                return adresList;
            }
            catch (Exception ex)
            {

                throw new Exception("\nGetAdres\n"+ex.Message);
            }
            finally
            {
                _connection.Close();
                _reader.Close();
            }
        }

        private BaseAdres ReaderToAdres(SqlDataReader reader)
        {
            try
            {
               BaseAdres adres;

                Guid id = reader.GetGuid(0);
                string kod = reader.GetString(1);
                string isim = reader.GetString(2);
                Guid ULId = reader.GetGuid(3);
                adres = new BaseAdres(id, ULId, isim, kod);
                return adres;

            }
            catch (Exception ex)
            {

                throw new Exception("\nReaderToObject\n"+ex.Message);
            }
        }

        public List<AyarlarKullanici> GetAyarlarList(string cmdText)
        {

            try
            {
                List<AyarlarKullanici> list = new List<AyarlarKullanici>();
                _connection.Open();
                SqlCommand cmd = new SqlCommand(cmdText, _connection);
                _reader = cmd.ExecuteReader();

                while (_reader.Read())
                {
                    list.Add(ReaderToAyarlar(_reader));
                }
                return list;
            }
            catch (Exception ex)
            {

                throw new Exception("\n GetAyarlarList\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
                _reader.Close();
            }
        }

        private AyarlarKullanici ReaderToAyarlar(SqlDataReader reader)
        {
            try
            {
                AyarlarKullanici ayar;

                Guid kulId = reader.GetGuid(0);
                string kod = reader.GetString(1);
                string isim = reader.GetString(2);
                string sifre = reader.GetString(3);
                string depo = reader.GetString(4);
                DateTime kayitTarihi = reader.GetDateTime(5);
                DateTime guncellemTarihi = reader.GetDateTime(6);
                Guid dePoId = reader.GetGuid(7);
                ayar = new AyarlarKullanici(kulId, kod, isim, sifre, depo, kayitTarihi, guncellemTarihi, dePoId);

                return ayar;
            }
            catch (Exception ex)
            {

                throw new Exception("\n ReaderToAyarlar\n" + ex.Message);
            }
        }

        public List<AyarlarKullaniciDetail> GetAyarlarDetailList(string cmdText)
        {
            try
            {
                List<AyarlarKullaniciDetail> list = new List<AyarlarKullaniciDetail>();
                _connection.Open();
                SqlCommand cmd = new SqlCommand(cmdText, _connection);
                _reader = cmd.ExecuteReader();

                while (_reader.Read())
                {
                    list.Add(ReaderToAyarlarDetail(_reader));
                }
                return list;
            }
            catch (Exception ex)
            {

                throw new Exception("\n GetAyarlarDetailList\n" + ex.Message);
            }
            finally
            {
                _connection.Close();
                _reader.Close();
            }
        }

        /// <summary>
        /// Kullanıcıde detayını readerden dönüştürerek AyarlarKullaniciDetail olarak geri döndürür
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private AyarlarKullaniciDetail ReaderToAyarlarDetail(SqlDataReader reader)
        {
            try
            {
                AyarlarKullaniciDetail ayarDetail = new AyarlarKullaniciDetail();

                Guid kulId = reader.GetGuid(0);
                Guid rolId = reader.GetGuid(1);
                string kod = reader.GetString(2);
                string isim = reader.GetString(3);

                ayarDetail = new AyarlarKullaniciDetail(kulId, rolId, kod, isim);

                return ayarDetail;
            }
            catch (Exception ex)
            {

                throw new Exception("\nReaderToAyarlarDetail"+ex.Message);
            }
        }
    }
}
