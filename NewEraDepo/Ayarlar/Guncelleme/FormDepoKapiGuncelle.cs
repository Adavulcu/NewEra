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
namespace NewEraDepo.Ayarlar.Guncelleme
{
    public partial class FormDepoKapiGuncelle : Form
    {
        AyarlarDepoOp _ayarlarDepoOp;
        Guid _id;
        public FormDepoKapiGuncelle()
        {
            InitializeComponent();
        }

        private void CbDepoXDoldur()
        {
            CbDepoX.ValueMember = "Id";
            CbDepoX.DisplayMember = "Isim";
            CbDepoX.DataSource = _ayarlarDepoOp.CbDepoXGetir();
        }

        public void Init(Guid id , string kod,string isim,string depoX)
        {
            try
            {
                this.Text = DM.ProjectName + "-MODULLER";
                _id = id;
                this.CenterToScreen();
                _ayarlarDepoOp = new AyarlarDepoOp();
                CbDepoXDoldur();
                TextKod.Text = kod;
                TextIsim.Text = isim;
                CbDepoX.SelectedIndex = CbDepoX.FindString(depoX).ToInt();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Init\n"+ex.Message);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsTextEmpty())
                {
                    DialogResult dialogResult = MessageBox.Show("KAPI GÜNCELLEME İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                                           "ÖNEMLİ UYARI",
                                            MessageBoxButtons.YesNoCancel,
                                           MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string kod = TextKod.Text;
                        string isim = TextIsim.Text;
                        Guid ULId = new Guid(CbDepoX.SelectedValue.ToString());
                        _ayarlarDepoOp.DepoKapiGuncelle(_id,isim,ULId);

                        MessageBox.Show("KAPI GÜNCELLEME İŞLEMİ BAŞARILI");
                        this.Close();
                    }
                    else if (dialogResult == DialogResult.No)
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
                MessageBox.Show("KAPI GÜNCELLEME İŞLEMİ BAŞARISIZ");
                MessageBox.Show("BtnGuncelle\n" + ex.Message);
            }
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
