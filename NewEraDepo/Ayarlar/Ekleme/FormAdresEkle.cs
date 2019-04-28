using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEraDepo.Ayarlar
{
    public partial class FormAdresEkle : Form
    {
        Data.AyarlarDepoOp _ayarlarDepoOp;
        Guid _ULId;
        string _tblName = "";
        public FormAdresEkle()
        {
            InitializeComponent();
            this.Text = DM.ProjectName + "-DEPO ADRES EKLE";
           
            this.CenterToScreen();
        }

        /// <summary>
        /// Formda Kullanılacak önemli parametrelere deger atayıp , gerekli nesneleri oluşturur.
        /// </summary>
        /// <param name="ULId"></param>
        /// <param name="tblName"></param>
     public void Init(Guid ULId,string tblName)
        {
            _ayarlarDepoOp = new Data.AyarlarDepoOp();
            _ULId = ULId;
            _tblName = tblName;         
        }
        
     

        private void Ekle_Click(object sender , EventArgs e)
        {
            try
            {

                if (!IsTextEmpty())
                {
                    DialogResult dialogResult = MessageBox.Show("ADRES EKLEME İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                "ÖNEMLİ UYARI",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        string katKod = textKod.Text;
                        string katIisim = textIsim.Text;

                         int result = _ayarlarDepoOp.AdresEkle(_ULId, katKod,katIisim,_tblName);
                        MessageBox.Show("ADRES EKLEME İŞLEMİ BAŞARILI");

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
                MessageBox.Show("ADRES EKLEME İŞLEMİ BAŞARISIZ");
                MessageBox.Show("\nEkle_Click\n"+ex.Message);
            }
        }

        /// <summary>
        /// TextBox ın içinin boş olup olmadıgını kontrol eder.
        /// </summary>
        /// <returns></returns>
        private bool IsTextEmpty()
        {
           
            foreach (object item in tblLayout.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).TextIsEmpty())
                        return true;
                }
                    
            }

            return false;
        }

        private void FormAdresEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
