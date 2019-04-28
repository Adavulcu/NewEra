using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewEraDepo.Data;

namespace NewEraDepo.Ayarlar.Ekleme
{
    public partial class FormSirketEkle : Form
    {
        public FormSirketEkle()
        {
            InitializeComponent();
            Init();
        }
        #region Variables
        Image _img;
        Boolean _picFlag = false;
        AyarlarCariOp _cariOp;
        Guid _cariId;
        Guid _logoId;
        #endregion

        private void Init()
        {
            this.Text = DM.ProjectName + "-CARİ EKLEME";
            this.CenterToScreen();
            _cariOp = new AyarlarCariOp();
            BtnGuncelle.Visible = false;
            Btnkaydet.Visible = true;
        }
        /// <summary>
        /// Güncelleme işlemi için gerekli verileri oluşturur.
        /// </summary>
        /// <param name="cariId"></param>
        /// <param name="logoId"></param>
        /// <param name="kod"></param>
        /// <param name="isim"></param>
        /// <param name="aciklama"></param>
        /// <param name="img"></param>
         public void Init(Guid cariId,Guid logoId,string kod, string isim,string aciklama,Image img)
        {
            BtnGuncelle.Visible = true;
            Btnkaydet.Visible = false;
            _picFlag = true;

            _cariId = cariId;
            _logoId = logoId;

            textKod.Text = kod;
            textIsim.Text = isim;
            textAciklama.Text = aciklama;
            PicLogo.Image = img;
            _img = img;
        }

        private void PicLogo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                _img = (str.GetPicPath()).SetPicEdit();
                _picFlag = true;
                PicLogo.Image = _img;
            }
            catch (Exception ex)
            {

                MessageBox.Show("PicLogo_DoubleClick\n"+ex.Message);
            }
        }

    
        private void BtnSec_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                _img = (str.GetPicPath()).SetPicEdit();
                _picFlag = true;
                PicLogo.Image = _img;
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnSec_Click\n"+ex.Message);
            }
        }
        /// <summary>
        /// GroupBox içierisndeki textBoxların boş olup olmadıgı  kontrol edip boolean deger döndürür
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

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsTextEmpty() && _picFlag)
                {

                    DialogResult dialogResult = MessageBox.Show("CARİ EKLEME İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                "ÖNEMLİ UYARI",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Guid cariId = Guid.NewGuid();
                        string kod = textKod.Text;
                        string isim = textIsim.Text;
                        string aciklama = textAciklama.Text;
                        _cariOp.CariEkle(cariId, kod, isim, aciklama);
                        _cariOp.LogoEkle(cariId, _img);
                        MessageBox.Show("CARİ EKLEME İŞLEMİ BAŞARILI");
                    }
                    else if (dialogResult == DialogResult.No)
                        this.Close();
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
                MessageBox.Show("CARİ EKLEME İŞLEMİ BAŞARISIZ");
                MessageBox.Show("BtnKaydet_Click\n"+ex.Message);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsTextEmpty() && _picFlag)
                {

                    DialogResult dialogResult = MessageBox.Show("CARİ GÜNCELLEME İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                "ÖNEMLİ UYARI",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                       
                        string kod = textKod.Text;
                        string isim = textIsim.Text;
                        string aciklama = textAciklama.Text;
                        _cariOp.CariGuncelle(_cariId,kod,isim,aciklama);
                        _cariOp.LogoGuncelle(_logoId, _img);
                        MessageBox.Show("CARİ GÜNCELLEME İŞLEMİ BAŞARILI");
                        this.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                        this.Close();
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
                MessageBox.Show("CARİ GÜNCELLEME İŞLEMİ BAŞARISIZ");
                MessageBox.Show("BtnGuncelle_Click\n" + ex.Message);
            }
        }
    }
}
