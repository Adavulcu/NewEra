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
using NewEraDepo.Models;
namespace NewEraDepo.Ayarlar.Guncelleme
{
    public partial class FormAdresGuncelle : Form
    {
       private AyarlarDepoOp _ayarlarDepoOp;
       private BaseAdres _adres;
       private string _tblName;
        public FormAdresGuncelle()
        {
            InitializeComponent();
        }

        public void Init(BaseAdres adres,string tblName)
        {
            this.Text = DM.ProjectName + "-DEPO ADRESS GÜNCELLE";
            this.CenterToScreen();
            _ayarlarDepoOp = new AyarlarDepoOp();
            _adres = adres;
            _tblName = tblName;
            textKod.Text = adres.Kod;
            textIsim.Text = adres.Isim;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsTextEmpty())
                {
                    DialogResult dialogResult = MessageBox.Show("ADRESS GÜNCELLEME İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                                 "ÖNEMLİ UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string isim = textIsim.Text;
                        string kod = textKod.Text;
                        int result = _ayarlarDepoOp.AdresGuncelle(_adres.Id, _adres.UlId, isim, kod, _tblName);
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
                MessageBox.Show("ADRES GÜNCELLEME İŞLEMİ BAŞARISIZ");
                MessageBox.Show("btnGuncelle_Click"+ex.Message);
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

        private void FormAdresGuncelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
