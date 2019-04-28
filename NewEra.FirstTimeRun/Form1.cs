using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewEraDepo.Data;
using NewEraDepo;

namespace NewEra.FirstTimeRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("", DM.Connection);
            cmd.CommandText = "DELETE FROM ne_Kullanici " +
                " DELETE FROM ne_Rol " +
                " INSERT INTO [dbo].[ne_Kullanici]([Id],[Kod],[Isim],[Sifre],[KayitKullaniciId],[GuncellemeKullaniciId]) " +
                " VALUES(@Id, @Kod, @Isim, @Sifre, @KayitKullaniciId, @GuncellemeKullaniciId) " +
                " INSERT INTO [dbo].[ne_Rol]([Id],[Kod],[Isim],[KayitKullaniciId],[GuncellemeKullaniciId]) " +
                " VALUES(@RId, @RKod, @RIsim, @KayitKullaniciId, @GuncellemeKullaniciId) " +

                " INSERT INTO [dbo].[ne_KullaniciRol]([Id],[KullaniciId],[RolId],[KayitKullaniciId],[GuncellemeKullaniciId]) " +
                " VALUES(@KRId, @Id, @RId, @KayitKullaniciId, @GuncellemeKullaniciId) ";




            cmd.Parameters.AddWithValue("@Id", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));
            cmd.Parameters.AddWithValue("@Kod", "admin");
            cmd.Parameters.AddWithValue("@Isim", "Sistem Administrator");
            cmd.Parameters.AddWithValue("@Sifre", "1234");
            cmd.Parameters.AddWithValue("@KayitKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));
            cmd.Parameters.AddWithValue("@GuncellemeKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));

            cmd.Parameters.AddWithValue("@RId", new Guid("C7877C98-6054-4A5F-9F19-94A2C05B79A6"));
            cmd.Parameters.AddWithValue("@RKod", "rolAdmin");
            cmd.Parameters.AddWithValue("@RIsim", "Sistem Administrator Rolü");

            cmd.Parameters.AddWithValue("@KRId", new Guid("1C1EF538-D0AD-485B-B821-87480D8C80A8"));
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem Tamamlandı.");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("", DM.Connection);
            SqlCommand cmdDelete = new SqlCommand("", cmd.Connection);
            cmdDelete.CommandText = "DELETE FROM ne_Modul ";

            cmd.CommandText = " INSERT INTO [dbo].[ne_Modul]([Id],[ModulId],[ClassName],[ImageIndex],[Isim],[Tip],[Aktif],[KayitKullaniciId],[GuncellemeKullaniciId]) " +
                " VALUES(@Id, @ModulId, @ClassName, @ImageIndex, @Isim, @Tip, @Aktif, @KayitKullaniciId, @GuncellemeKullaniciId) " +
                
                " INSERT INTO [dbo].[ne_ModulRol]([Id],[RolId],[ModulId],[Giris],[KayitKullaniciId],[GuncellemeKullaniciId]) " +
                " VALUES(@MRId, @RolId, @Id, @Giris, @KayitKullaniciId, @GuncellemeKullaniciId) ";

            

            try
            {
                cmd.Connection.Open();

                cmdDelete.ExecuteNonQuery();
                ///////////////////////////////////////////////////////////
                Guid modulId = new Guid("432A3933-0617-4D9E-AD12-7F6C21F0E5A5");
                
                cmd.Parameters.AddWithValue("@Id", modulId);
                cmd.Parameters.AddWithValue("@ModulId", "MDL999");
                cmd.Parameters.AddWithValue("@ClassName", "");
                cmd.Parameters.AddWithValue("@ImageIndex", 1); 
                cmd.Parameters.AddWithValue("@Isim", "Ayarlar");
                cmd.Parameters.AddWithValue("@Tip", 0); // Tip -> 0 grup başlığı 1 form adı 
                cmd.Parameters.AddWithValue("@Aktif", true);
                cmd.Parameters.AddWithValue("@KayitKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));
                cmd.Parameters.AddWithValue("@GuncellemeKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));

                cmd.Parameters.AddWithValue("@MRId", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@RolId", new Guid("C7877C98-6054-4A5F-9F19-94A2C05B79A6"));
                cmd.Parameters.AddWithValue("@Giris", true);
                cmd.ExecuteNonQuery();
                //////////////////////////////////////////////////////////////////////////////////////
                cmd.Parameters.Clear();
                modulId = Guid.NewGuid();
                cmd.Parameters.AddWithValue("@Id", modulId);
                cmd.Parameters.AddWithValue("@ModulId", "MDL99901");
                cmd.Parameters.AddWithValue("@ClassName", "FormSirketTanimlama");
                cmd.Parameters.AddWithValue("@ImageIndex", 1);
                cmd.Parameters.AddWithValue("@Isim", "Şirket Tanımlama");
                cmd.Parameters.AddWithValue("@Tip", 1); // Tip -> 0 grup başlığı 1 form adı 
                cmd.Parameters.AddWithValue("@Aktif", true);
                cmd.Parameters.AddWithValue("@KayitKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));
                cmd.Parameters.AddWithValue("@GuncellemeKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));

                cmd.Parameters.AddWithValue("@MRId", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@RolId", new Guid("C7877C98-6054-4A5F-9F19-94A2C05B79A6"));
                cmd.Parameters.AddWithValue("@Giris", true);
                cmd.ExecuteNonQuery();
                //////////////////////////////////////////////////////////////////////////////////////
                cmd.Parameters.Clear();
                modulId = Guid.NewGuid();
                cmd.Parameters.AddWithValue("@Id", modulId);
                cmd.Parameters.AddWithValue("@ModulId", "MDL99902");
                cmd.Parameters.AddWithValue("@ClassName", "FormDepoTanimlama");
                cmd.Parameters.AddWithValue("@ImageIndex", 1); 
                cmd.Parameters.AddWithValue("@Isim", "Depo Tanımlama");
                cmd.Parameters.AddWithValue("@Tip", 1); // Tip -> 0 grup başlığı 1 form adı 
                cmd.Parameters.AddWithValue("@Aktif", true);
                cmd.Parameters.AddWithValue("@KayitKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));
                cmd.Parameters.AddWithValue("@GuncellemeKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));

                cmd.Parameters.AddWithValue("@MRId", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@RolId", new Guid("C7877C98-6054-4A5F-9F19-94A2C05B79A6"));
                cmd.Parameters.AddWithValue("@Giris", true);
                cmd.ExecuteNonQuery();
                //////////////////////////////////////////////////////////////////////////////////////
                cmd.Parameters.Clear();
                modulId = Guid.NewGuid();
                cmd.Parameters.AddWithValue("@Id", modulId);
                cmd.Parameters.AddWithValue("@ModulId", "MDL99903");
                cmd.Parameters.AddWithValue("@ClassName", "FormKullaniciTanimlama");
                cmd.Parameters.AddWithValue("@ImageIndex", 1);
                cmd.Parameters.AddWithValue("@Isim", "Kullanıcı Tanımlama");
                cmd.Parameters.AddWithValue("@Tip", 1); // Tip -> 0 grup başlığı 1 form adı 
                cmd.Parameters.AddWithValue("@Aktif", true);
                cmd.Parameters.AddWithValue("@KayitKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));
                cmd.Parameters.AddWithValue("@GuncellemeKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));

                cmd.Parameters.AddWithValue("@MRId", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@RolId", new Guid("C7877C98-6054-4A5F-9F19-94A2C05B79A6"));
                cmd.Parameters.AddWithValue("@Giris", true);
                cmd.ExecuteNonQuery();
                //////////////////////////////////////////////////////////////////////////////////////
                cmd.Parameters.Clear();
                modulId = Guid.NewGuid();
                cmd.Parameters.AddWithValue("@Id", modulId);
                cmd.Parameters.AddWithValue("@ModulId", "MDL99904");
                cmd.Parameters.AddWithValue("@ClassName", "FormAdresTanimlama");
                cmd.Parameters.AddWithValue("@ImageIndex", 1);
                cmd.Parameters.AddWithValue("@Isim", "Depo Adres Tanımlama");
                cmd.Parameters.AddWithValue("@Tip", 1); // Tip -> 0 grup başlığı 1 form adı 
                cmd.Parameters.AddWithValue("@Aktif", true);
                cmd.Parameters.AddWithValue("@KayitKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));
                cmd.Parameters.AddWithValue("@GuncellemeKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));

                cmd.Parameters.AddWithValue("@MRId", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@RolId", new Guid("C7877C98-6054-4A5F-9F19-94A2C05B79A6"));
                cmd.Parameters.AddWithValue("@Giris", true);
                cmd.ExecuteNonQuery();
                //////////////////////////////////////////////////////////////////////////////////////
                cmd.Parameters.Clear();
                modulId = Guid.NewGuid();
                cmd.Parameters.AddWithValue("@Id", modulId);
                cmd.Parameters.AddWithValue("@ModulId", "MDL99905");
                cmd.Parameters.AddWithValue("@ClassName", "FormAracTanimlama");
                cmd.Parameters.AddWithValue("@ImageIndex", 1);
                cmd.Parameters.AddWithValue("@Isim", "Araç Tanımlama");
                cmd.Parameters.AddWithValue("@Tip", 1); // Tip -> 0 grup başlığı 1 form adı 
                cmd.Parameters.AddWithValue("@Aktif", true);
                cmd.Parameters.AddWithValue("@KayitKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));
                cmd.Parameters.AddWithValue("@GuncellemeKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));

                cmd.Parameters.AddWithValue("@MRId", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@RolId", new Guid("C7877C98-6054-4A5F-9F19-94A2C05B79A6"));
                cmd.Parameters.AddWithValue("@Giris", true);
                cmd.ExecuteNonQuery();
                //////////////////////////////////////////////////////////////////////////////////////
                cmd.Parameters.Clear();
                modulId = Guid.NewGuid();
                cmd.Parameters.AddWithValue("@Id", modulId);
                cmd.Parameters.AddWithValue("@ModulId", "MDL99906");
                cmd.Parameters.AddWithValue("@ClassName", "FormTerminalTanimlama");
                cmd.Parameters.AddWithValue("@ImageIndex", 1);
                cmd.Parameters.AddWithValue("@Isim", "Terminal Tanımlama");
                cmd.Parameters.AddWithValue("@Tip", 1); // Tip -> 0 grup başlığı 1 form adı 
                cmd.Parameters.AddWithValue("@Aktif", true);
                cmd.Parameters.AddWithValue("@KayitKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));
                cmd.Parameters.AddWithValue("@GuncellemeKullaniciId", new Guid("0362A7AB-7CF9-427D-A10D-4B93C2B8B12F"));

                cmd.Parameters.AddWithValue("@MRId", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@RolId", new Guid("C7877C98-6054-4A5F-9F19-94A2C05B79A6"));
                cmd.Parameters.AddWithValue("@Giris", true);
                cmd.ExecuteNonQuery();

                MessageBox.Show("İşlem Tamamlandı.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
