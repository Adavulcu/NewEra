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
    public partial class FormAracYukIndirmeEmriOlusturma : Form
    {
        Kullanici kullanici;

        MalKabulArac malKabulArac;
        Adres adres;
        Kullanici personel;
        DepoIciArac depoIciArac;
        Kapi kapi;

        AracOp aracOp;
        KullaniciOp kullaniciOp;
        KapiOp kapiOp;
        

        public FormAracYukIndirmeEmriOlusturma()
        {
            InitializeComponent();
            this.Text = DM.ProjectName + " - Yük İndirme Emri Oluşturma";
            kullanici = DM.kullanici;
            aracOp = new AracOp();
            //adresOp = new AdresOp();
            kapiOp = new KapiOp();
            kullaniciOp = new KullaniciOp();

            malKabulArac = new MalKabulArac();
            adres = new Adres();
            kapi = new Kapi();
            personel = new Kullanici();
            depoIciArac = new DepoIciArac();

            lblSecilenArac.Text = "";
            lblPersonel.Text = "";
            lblAlan.Text = "";
            lblYIArac.Text = "";
            this.CenterToScreen();
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            malKabulArac.Id = gridView1.GetFocusedRowCellValue("Id").ToString().ToGuid();
            
            malKabulArac.Plaka = gridView1.GetFocusedRowCellValue("Plaka").ToString();
            lblSecilenArac.Text = malKabulArac.Plaka;
        }

        private void FormAracYukIndirmeEmriOlusturma_Shown(object sender, EventArgs e)
        {
            gridArac.DataSource = aracOp.MalKabulAracListesi(DurumArac.Giris);
            gridKapi.DataSource = kapiOp.Liste();
            gridKullanici.DataSource = kullaniciOp.RoleBagliListe(kullanici.DepoId, "depoPersonel");
            gridForklift.DataSource = aracOp.DepoIciAracListesi(kullanici.DepoId);
        }

        private void GridView2_DoubleClick(object sender, EventArgs e)
        {
            kapi.Id= gridView2.GetFocusedRowCellValue("Id").ToString().ToGuid();
            // indirme alanı adresi
            kapi.ULId = gridView2.GetFocusedRowCellValue("ULId").ToString().ToGuid();
            kapi.Isim = gridView2.GetFocusedRowCellValue("Isim").ToString();
            lblAlan.Text = kapi.Isim;
        }

        private void GridView3_DoubleClick(object sender, EventArgs e)
        {
            personel.Id = gridView3.GetFocusedRowCellValue("Id").ToString().ToGuid();
            personel.Isim = gridView3.GetFocusedRowCellValue("Isim").ToString();
            personel.Kod = gridView3.GetFocusedRowCellValue("Kod").ToString();
            lblPersonel.Text = personel.Isim;
        }

        private void GridView4_DoubleClick(object sender, EventArgs e)
        {
            depoIciArac.Id= gridView4.GetFocusedRowCellValue("Id").ToString().ToGuid();
            lblYIArac.Text = gridView4.GetFocusedRowCellValue("Isim").ToString();
        }

        private void BtnEmirOlustur_Click(object sender, EventArgs e)
        {
            string mesaj = lblSecilenArac.Text +" plakalı aracın yükünü\r"
                          +lblPersonel.Text.ToUpper()+" isimli personel "+lblYIArac.Text.ToUpper()+" ile "
                          +lblAlan.Text +" alanına indirecektir. \r\r"
                          +"İş emrini oanaylıyor musunuz?";
            DialogResult cevap = MessageBox.Show(mesaj, DM.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(cevap==DialogResult.Yes)
            {

            }
        }
    }
}
