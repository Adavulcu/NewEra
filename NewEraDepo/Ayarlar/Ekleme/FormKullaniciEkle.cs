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
    public partial class FormKullaniciEkle : Form
    {
        Data.AyarlarKullaniciOp _ayarKullaniciOP;
        Models.AyarlarKullanici _ayarlarKullanici;

        Guid _id;
        public FormKullaniciEkle()
        {
            InitializeComponent();
            this.Text = DM.ProjectName + "-KULLANICI EKLE";
            _ayarKullaniciOP = new Data.AyarlarKullaniciOp();
            _ayarlarKullanici = new Models.AyarlarKullanici();
            _id = Guid.NewGuid();
            this.CenterToScreen();


        }

        private void FormKullaniciEkle_Shown(object sender, EventArgs e)
        {
            gridControlKullaniciEkle.DataSource = _ayarKullaniciOP.GetRoles(_id);
            CbDepoDoldur();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {


                if (!IsTextEmpty())
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
                            Guid depoId = new Guid(cbDepoKayit.SelectedValue.ToString());
                            int result1 = 0;
                            result1 = _ayarKullaniciOP.KullaniciEkle(_id, kod, isim, sifre, depoId);
                            int result2 = 0;


                            for (int i = 0; i < gridViewKullaniciEkle.RowCount; i++)
                            {
                                val = Convert.ToBoolean(gridViewKullaniciEkle.GetDataRow(i)["IsChecked"]);
                                string rolId = gridViewKullaniciEkle.GetDataRow(i)["Id"].ToString();
                                if (val)
                                {
                                    result2 = _ayarKullaniciOP.KullaniciRolEkle(_id, rolId);

                                }

                            }
                            MessageBox.Show("KAYIT BAŞARILI");

                        }
                        else if (dialogResult == DialogResult.No)
                        {
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

                MessageBox.Show("btnEkleClick\n" + ex.Message);
                MessageBox.Show("KAYIT BAŞARISIZ");
            }


        }
        /// <summary>
        /// Depoya ait bilgileri ComboBox a doldurur.
        /// </summary>
        private void CbDepoDoldur()
        {
            try
            {
                cbDepoKayit.ValueMember = "Id";
                cbDepoKayit.DisplayMember = "Isim";
                cbDepoKayit.DataSource = _ayarKullaniciOP.KullaciniDepoCbDoldur();
            }
            catch (Exception ex)
            {

                MessageBox.Show("CbDepoDoldur\n" + ex.Message);
            }
        }

        /// <summary>
        /// Listedeki herhangi bir rolun seçilip seçilmediğini kontrol eder
        /// </summary>
        /// <returns></returns>
        private Boolean RolKontrol()
        {
            Boolean val = false;
            for (int i = 0; i < gridViewKullaniciEkle.RowCount; i++)
            {
                val = Convert.ToBoolean(gridViewKullaniciEkle.GetDataRow(i)["IsChecked"]);
                if (val)
                    return val;
            }

            return val;
        }

        /// <summary>
        /// TextBox ın içinin boş olup olmadıgını kontrol eder.
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

        private void FormKullaniciEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
