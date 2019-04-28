using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEraDepo
{
    public partial class FormGuncelleme : Form
    {
        Data.AyarlarKullaniciOp _ayarKullaniciOP;
        Models.AyarlarKullanici _ayarlarKullanici;
        public FormGuncelleme()
        {
            InitializeComponent();
            try
            {
                this.Text = DM.ProjectName + "-KULLANICI GÜNCELLEME";
                _ayarKullaniciOP = new Data.AyarlarKullaniciOp();
                this.CenterToScreen();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Init\n" + ex.Message);
            }

        }

        /// <summary>
        /// İçerisinne AyarlarKullanicici sınıfının nesnesini alarak gerekli konrollerin içini doldurur.
        /// </summary>
        /// <param name="ayarlar"></param>
        public void InitControls(Models.AyarlarKullanici ayarlar)
        {
            try
            {
                _ayarlarKullanici = ayarlar;

                textBoxKod.Text = _ayarlarKullanici.Kod;
                textBoxIsim.Text = _ayarlarKullanici.Isim;
                textBoxSifre.Text = _ayarlarKullanici.Sifre;


            }
            catch (Exception ex)
            {

                MessageBox.Show("InitControls\n" + ex.Message);
            }
        }

        private void FormGuncelleme_Shown(object sender, EventArgs e)
        {
            gridControlGuncelleme.DataSource = _ayarKullaniciOP.GetRoles(_ayarlarKullanici.Id);
            CbDepoDoldur();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if(!IsTextEmpty())
                {
                    if (RolKontrol())
                    {
                        Boolean val;
                        DialogResult dialogResult = MessageBox.Show("KAYIT İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                                    "ÖNEMLİ UYARI",
                                     MessageBoxButtons.YesNoCancel,
                                     MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {

                            string kod = textBoxKod.Text;
                            string isim = textBoxIsim.Text;
                            string sifre = textBoxSifre.Text;
                            Guid depoId = new Guid(cbDepoGuncelleme.SelectedValue.ToString());
                            int result1 = 0;
                            result1 = _ayarKullaniciOP.KullaniciGuncelle(_ayarlarKullanici.Id, kod, isim, sifre, depoId);
                            int result2 = 0;
                            int result3 = 0;
                            for (int i = 0; i < gridViewGuncelleme.RowCount; i++)
                            {
                                val = Convert.ToBoolean(gridViewGuncelleme.GetDataRow(i)["IsChecked"]);
                                string rolId = gridViewGuncelleme.GetDataRow(i)["Id"].ToString();
                                if (val)
                                {
                                    result3 = _ayarKullaniciOP.KullaniciRolSil(_ayarlarKullanici.Id, rolId);
                                    result2 = _ayarKullaniciOP.KullaniciRolEkle(_ayarlarKullanici.Id, rolId);
                                }

                                else
                                    result3 = _ayarKullaniciOP.KullaniciRolSil(_ayarlarKullanici.Id, rolId);
                            }

                            MessageBox.Show("GÜNCELLEME BAŞARLI");
                            this.Close();

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            FormKullaniciListele fkl = new FormKullaniciListele();
                            fkl.LoadData();
                            this.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("EN AZ 1 ROL SEÇİLMELDİR!",
                                                "HATA",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation,
                                                 MessageBoxDefaultButton.Button1);
                    }
                    
                }
                else
                    MessageBox.Show("BOŞ ALANLAR DOLDURULMALIDIR!",
                                                 "HATA",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation,
                                                  MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("GÜNCELLEME BAŞARISIZ");
                MessageBox.Show("BtnGuncelle\n" + ex.Message);
            }
        }
        /// <summary>
        /// Mevcut tüm depoları ValueMember ve DisplayMember olarak ComboBoxa doldurur.
        /// </summary>
        private void CbDepoDoldur()
        {
            try
            {
                cbDepoGuncelleme.ValueMember = "Id";
                cbDepoGuncelleme.DisplayMember = "Isim";
                cbDepoGuncelleme.DataSource = _ayarKullaniciOP.KullaciniDepoCbDoldur();
            }
            catch (Exception ex)
            {

                MessageBox.Show("CbDepoDoldur\n" + ex.Message);
            }
        }
        /// <summary>
        ///  Seçili Kullanıcı Rolu olup olmadıgını kontrol edererek Boolean deger dönrürür.
        /// </summary>
        /// <returns></returns>
        private Boolean RolKontrol()
        {
            Boolean val = false;
            for (int i = 0; i < gridViewGuncelleme.RowCount; i++)
            {
                val = Convert.ToBoolean(gridViewGuncelleme.GetDataRow(i)["IsChecked"]);
                if (val)
                    return val;
            }

            return val;
        }

        /// <summary>
        /// TexBox ın içinin boş olup olmadıgını kontrol eder
        /// </summary>
        /// <returns></returns>
        private bool IsTextEmpty()
        {

            foreach (object item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).TextIsEmpty())
                        return true;
                }

            }

            return false;
        }

        private void FormGuncelleme_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
