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
    public partial class FormDepoKapiEkle : Form
    {
        AyarlarDepoOp _ayarlarDepoOp;
        public FormDepoKapiEkle()
        {
            InitializeComponent();
            Init();
        }


        private void Init()
        {
            this.Text = DM.ProjectName + "-KULLANICI AYARLARI";
            this.CenterToScreen();
            _ayarlarDepoOp = new AyarlarDepoOp();
            CbDepoXDoldur();
        }

        private void CbDepoXDoldur()
        {
            CbDepoX.ValueMember = "Id";
            CbDepoX.DisplayMember = "Isim";
            CbDepoX.DataSource = _ayarlarDepoOp.CbDepoXGetir();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if(!IsTextEmpty())
                {
                    DialogResult dialogResult = MessageBox.Show("KAPI EKLEME İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                                           "ÖNEMLİ UYARI",
                                            MessageBoxButtons.YesNoCancel,
                                           MessageBoxIcon.Question);
                    if (dialogResult==DialogResult.Yes)
                    {
                        Guid ULId = new Guid(CbDepoX.SelectedValue.ToString());
                        string kod = TextKod.Text;
                        string isim = TextIsim.Text;

                        _ayarlarDepoOp.DepoKapiEkle(ULId,kod,isim);

                        MessageBox.Show("KAPI EKLEME İŞLEMİ BAŞARILI");
                    }
                    else if (dialogResult==DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("BOŞ ALANLAR DOLDURULMALIDIR!",
                             "HATA",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                              MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("KAPI EKLEME İŞLEMİ BAŞARISIZ");
                MessageBox.Show("BtnEkle\n"+ex.Message);
            }
        }

        private void CbDepoX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
    }
}
