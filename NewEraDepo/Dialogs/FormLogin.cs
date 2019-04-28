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

namespace NewEraDepo.Dialogs
{
    public partial class FormLogin : Form
    {
        public Kullanici LgnKullanici { get; set; }

        private int passCount = 0;
        public FormLogin()
        {
            InitializeComponent();
            this.Text = "";
            teKullaniciAdi.Text = "admin";
            teSifre.Text = "1234";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            passCount++;
            KullaniciOp kullaniciOp = new KullaniciOp();
            Kullanici kullanici = kullaniciOp.KullaniciGiris(teKullaniciAdi.Text, teSifre.Text);
            if (kullanici == null)
            {                
                if (passCount >= 3)
                {
                    MessageBox.Show("Şifreyi " + passCount.ToString() + " kez hatalı girdiniz.", "NewEra");
                    Close();
                }
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "NewEra");
                teKullaniciAdi.Text = "";
                teSifre.Text = "";
                teKullaniciAdi.Focus();
            }
            else
            {
                LgnKullanici = kullanici;
                Close();
            }
        }

        private void LabelControl1_Click(object sender, EventArgs e)
        {
            LgnKullanici = null;
            Close();
        }
    }
}
