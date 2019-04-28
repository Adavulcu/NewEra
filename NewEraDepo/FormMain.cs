using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewEraDepo.Dialogs;
using NewEraDepo.Models;
using System.Windows;
using NewEra.DepoSimulasyon;

namespace NewEraDepo
{
    public partial class FormMain : Form
    {
        Kullanici kullanici;
        public FormMain()
        {
            InitializeComponent();
            this.Text = DM.ProjectName;
            FormLogin formLogin = new FormLogin();

            formLogin.ShowDialog();
            kullanici = formLogin.LgnKullanici;
            DM.kullanici = kullanici;
            this.CenterToScreen();


        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (DM.kullanici == null) Close();
            else
            statusStrip1.Items[0].Text = kullanici.Isim;
        }

        private void BtnMalKabul_Click(object sender, EventArgs e)
        {
            FormAracKabul formAracKabul = new FormAracKabul();
            formAracKabul.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormAracYukIndirmeEmriOlusturma formAracYukIndirmeEmriOlusturma = new FormAracYukIndirmeEmriOlusturma();
            formAracYukIndirmeEmriOlusturma.ShowDialog();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            WindowRaf wr = new WindowRaf();
            System.Windows.MessageBox.Show(wr.GetType().ToString());
            wr.ShowDialog();
        }

        private void BtnModul_Click(object sender, EventArgs e)
        {
            FormModules m = new FormModules();
            m.ShowDialog();
        }
    }
}
