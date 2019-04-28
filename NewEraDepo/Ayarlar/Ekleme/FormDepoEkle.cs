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
    public partial class FormDepoEkle : Form
    {
        Data.AyarlarDepoOp _ayarlarDepoOp;
        Image _img;
        Boolean _picFlag;
        public FormDepoEkle()
        {
            InitializeComponent();
            this.Text = DM.ProjectName + "-DEPO EKLE";
            this.CenterToScreen();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsTextEmpty() &&_picFlag)
                {
                    DialogResult dialogResult = MessageBox.Show("KAYIT İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                                             "ÖNEMLİ UYARI",
                                              MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Guid depoId = Guid.NewGuid();
                        int result = 0;
                        int result1 = 0;
                        string depoIisim = textDepoIsim.Text;
                        string depoKod = textDepoKod.Text;
                        string aciklama = textDepoAçiklama.Text;
                        int tip = Convert.ToInt32(textDepoTip.Text);
                        result = _ayarlarDepoOp.DepoEkle(depoId,depoIisim, depoKod, aciklama, tip);
                        result1 = _ayarlarDepoOp.DepoImgEkle(depoId, _img);
                        MessageBox.Show("DEPO EKLEME BAŞARLILI");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
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
                MessageBox.Show("DEPO EKLEME BAŞARISIZ");
                MessageBox.Show("BtnKaydet_Click"+ex.Message);
            }

        }

        private void FormDepoEkle_Shown(object sender, EventArgs e)
        {
            _ayarlarDepoOp = new Data.AyarlarDepoOp();
        }

        /// <summary>
        /// TextBox ın içinin boş olup olmadıgını kontrol eder
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

        private void FormDepoEkle_KeyDown(object sender, KeyEventArgs e)
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

                MessageBox.Show("pictureBox_DoubleClick\n"+ex.Message);
            }
        }

        private void BtnPicSec_Click(object sender, EventArgs e)
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
