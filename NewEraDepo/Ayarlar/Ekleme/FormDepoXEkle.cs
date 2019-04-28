using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewEraDepo.Ayarlar;
using NewEraDepo.Data;
namespace NewEraDepo.Ayarlar.Ekleme
{
    public partial class FormDepoXEkle : Form
    {
        Guid _ULId;
        AyarlarDepoOp _ayarlarDepoOp;
        public FormDepoXEkle()
        {
            InitializeComponent();
            this.Text = DM.ProjectName + "-DEPO ADRES EKLE";
            this.CenterToScreen();
            _ayarlarDepoOp = new AyarlarDepoOp();
        }

        /// <summary>
        /// Formda Kullanılacak önemli parametrelere deger atayıp , gerekli nesneleri oluşturur
        /// </summary>
        /// <param name="ULId"></param>
        public void Init(Guid ULId)
        {
            _ULId = ULId;
            CBParentDolur();
           
        }
        /// <summary>
        /// ComboBox ı doldurur.
        /// </summary>
        private void CBParentDolur()
        {
            try
            {
                CBTip.DisplayMember = "Isim";
                CBTip.ValueMember = "TipNo";
                CBTip.DataSource = _ayarlarDepoOp.DepoXCBGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show("CBParentDoldur\n"+ex.Message);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsTextEmpty())
                {
                    DialogResult dialogResult = MessageBox.Show("ADRES EKLEME İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?", "ÖNEMLİ UYARI",
           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string kod = textKod.Text;
                        string isim = textIsim.Text;
                        int tip = (CBTip.SelectedValue.ToString()).ToInt();
                        int result = _ayarlarDepoOp.DepoXEkle(_ULId, kod, isim, tip, "ne_DepoX");
                        MessageBox.Show("ADRES EKLEME İŞLEMİ BAŞARILI");
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
                MessageBox.Show("ADRES EKLEME İŞLEMİ BAŞARISIZ");
               MessageBox.Show("btnEkle_Click\n"+ex.Message);

            }
        }
        /// <summary>
        /// TextBox ın içinin boş olup olmadıgını kontrol eder.
        /// </summary>
        /// <returns></returns>
        private bool IsTextEmpty()
        {

            foreach (object item in tableLayoutPanel1.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).TextIsEmpty())
                        return true;
                }

            }

            return false;
        }

        private void FormDepoXEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
