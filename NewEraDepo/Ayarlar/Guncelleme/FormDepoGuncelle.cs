using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewEraDepo.Models;
using NewEraDepo.Data;
namespace NewEraDepo.Ayarlar.Guncelleme
{
    public partial class FormDepoGuncelle : Form
    {
        AyarlarDepoOp _ayarlarDepoOp;
        Depo _depo;
        Image _img;
        Boolean _picFlag;
        public FormDepoGuncelle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// İçerisinine Depo sınıfın nesnesini alarak controllerin içini doldurur
        /// </summary>
        /// <param name="depo"></param>
        internal void Init(Depo depo)
        {
            this.Text = DM.ProjectName + "-DEPO GÜNCELLEME";
            this.CenterToScreen();
            _depo = depo;
            _ayarlarDepoOp = new AyarlarDepoOp();
            textAciklama.Text = _depo.Aciklama;
            textKod.Text = _depo.Kod;
            textIsim.Text = _depo.Isim;
            if (_depo.Img!=null)
            {
                pictureBox.Image = _depo.Img;
                
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsTextEmpty() &&_picFlag)
                {
                    DialogResult dialogResult = MessageBox.Show("ADRESS GÜNCELLEME İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                                "ÖNEMLİ UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string isim = textIsim.Text;
                        string kod = textKod.Text;
                        string aciklama = textAciklama.Text;
                        int result = _ayarlarDepoOp.DepoGuncelle(_depo.Id, isim, kod, aciklama);
                        int result1 = -1;
                        if (_depo.Img==null || _depo.ImgId==new Guid())
                        {

                            result1 = _ayarlarDepoOp.DepoImgEkle(_depo.Id, _img);
                        }
                        else
                        {
                            result1= _ayarlarDepoOp.DepoImgGuncelle(_depo.ImgId, _img);
                        }
                         
                        MessageBox.Show("ADRES GÜNCELLEME İŞLEMİ BAŞARILI");
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

                MessageBox.Show("btnGuncelle_Click\n", ex.Message);
            }
        }
        /// <summary>
        /// TexBox ın içinin boş olup olmadıgını kontrol eder
        /// </summary>
        /// <returns></returns>
        private bool IsTextEmpty()
        {

            foreach (object item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).TextIsEmpty())
                        return true;
                }

            }

            return false;
        }

        private void FormDepoGuncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                _img = (str.GetPicPath()).SetPicEdit();
                _picFlag = true;
                pictureBox.Image = _img;
            }
            catch (Exception ex)
            {

                MessageBox.Show("pictureBox_DoubleClick\n" + ex.Message);
            }
        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                _img = (str.GetPicPath()).SetPicEdit();
                _picFlag = true;
                pictureBox.Image = _img;
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnPicSec_Click\n" + ex.Message);
            }
        }
    }
}
