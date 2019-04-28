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

namespace NewEraDepo
{
    public partial class FormAracKabul : Form
    {
        Kullanici kullanici;
        MalKabulArac malKabulArac;
        AracOp aracOp;

        public FormAracKabul()
        {
            InitializeComponent();
            this.Text = DM.ProjectName + " - Araç Kabul";
            kullanici = DM.kullanici;
            aracOp = new AracOp();
            teSofor.ReadOnly = true;
            teFirma.ReadOnly = true;
            btnKayit.Enabled = false;
            this.CenterToScreen();
        }



        private void TePlaka_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                if (!tePlaka.Text.CheckRegex(tePlaka.Properties.Mask.EditMask))
                {
                    MessageBox.Show("Lütfen geçerli bir plaka bilgisi giriniz.");
                    this.Focus();
                    return;
                }

                malKabulArac = aracOp.GetMalKabulArac(tePlaka.Text);
                teSofor.Text = malKabulArac.Sofor;
                teFirma.Text = malKabulArac.Firma;
                if (malKabulArac.Durum == 0 || malKabulArac.Durum == 4)
                {
                    teSofor.ReadOnly = false;
                    teFirma.ReadOnly = false;
                    btnKayit.Enabled = true;
                    teSofor.Focus();
                }
                else
                {
                    string aracDurum = aracOp.GetAracDurum(malKabulArac);
                    MessageBox.Show(aracDurum);
                }

            }
        }

        private void TeSofor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (teSofor.Text == "")
                {
                    MessageBox.Show("Lütfen geçerli bir şöför ismi giriniz.");
                    return;
                }
                //malKabulArac = aracOp.SetSofor(malKabulArac,teSofor.Text);
                malKabulArac.Sofor = teSofor.Text;
                teFirma.Focus();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (malKabulArac != null)
            {
                DialogResult cevap = MessageBox.Show("İşlem iptal edilecek. Emin misiniz?", "NewEra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes) Close();
            }
            else Close();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            if (aracOp.CreateMalKabulArac(malKabulArac))
            {
                MessageBox.Show("İşlem Tamamlandı.", "NewEra");
                Close();
            }
            else MessageBox.Show("İşlem Tamamlanamadı.", "NewEra", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TeFirma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (teFirma.Text == "")
                {
                    MessageBox.Show("Lütfen geçerli bir şöför ismi giriniz.");
                    return;
                }
                malKabulArac.Firma = teFirma.Text;
                //malKabulArac = aracOp.SetFirma(malKabulArac, teSofor.Text);
                btnKayit.Focus();
            }
        }
    }
}
