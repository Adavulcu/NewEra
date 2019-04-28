using NewEraDepo.Data;
using NewEraDepo.Models;
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
    public partial class FormAracYukIndirme : Form
    {
        DataTable _personelIsEmirleri;
        IsEmri _isEmri;
        IsEmriYukIndirme _isEmriYukIndirme;
        DepoIciArac depoIciArac;
        public FormAracYukIndirme()
        {
            InitializeComponent();
            DM.ClearFormText(this,FormNesnesi.Label);
            DM.ClearFormText(this, FormNesnesi.TextEdit);
            DM.DisableControls(this,FormNesnesi.TextEdit);
            _isEmri = new IsEmri();
        }

        private void TEDepoIciArac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AracOp aracOp = new AracOp();
                depoIciArac = aracOp.GetDepoIciArac(teDepoIciArac.Text);
                if (depoIciArac != null && depoIciArac.Id.CompareTo(((IsEmriYukIndirme)_isEmri.Emir).DepoIciAracId) == 0)
                {
                    // uygun araç seçildi.
                    lblDepoIciArac.Text = depoIciArac.Isim;
                    teAdres.Enabled = true;
                    teAdres.Focus();
                }
                else MessageBox.Show("Seçilen Araç ile İş Emri Uyuşmuyor.", DM.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAracYukIndirme_Shown(object sender, EventArgs e)
        {
            KullaniciOp kullaniciOp = new KullaniciOp();
            _personelIsEmirleri = kullaniciOp.IsEmriListesi(TipIsEmri.YukIndirme);
            grdIsEmriListeKullanici.DataSource = _personelIsEmirleri;
            IsEmriKontrol();

        }

        void IsEmriKontrol()
        {

        }

        private void grdVIsEmriListe_DoubleClick(object sender, EventArgs e)
        {
            DM.ClearFormText(this,FormNesnesi.Label);
            DM.ClearFormText(this, FormNesnesi.TextEdit);
            DM.DisableControls(this,FormNesnesi.TextEdit);
            _isEmri.Id = grdVIsEmriListe.GetFocusedRowCellValue("EmirId").ToString().ToGuid();
            _isEmriYukIndirme = new IsEmriYukIndirme();
            _isEmriYukIndirme.Id = grdVIsEmriListe.GetFocusedRowCellValue("Id").ToString().ToGuid();
            _isEmriYukIndirme.MalKabulAracId = grdVIsEmriListe.GetFocusedRowCellValue("MalKabulAracId").ToString().ToGuid();
            _isEmriYukIndirme.PersonelId = grdVIsEmriListe.GetFocusedRowCellValue("PersonelId").ToString().ToGuid();
            _isEmriYukIndirme.AdresId = grdVIsEmriListe.GetFocusedRowCellValue("AdresId").ToString().ToGuid();
            _isEmriYukIndirme.DepoIciAracId = grdVIsEmriListe.GetFocusedRowCellValue("DepoIciAracId").ToString().ToGuid();
            _isEmriYukIndirme.EmirId = grdVIsEmriListe.GetFocusedRowCellValue("EmirId").ToString().ToGuid();
            _isEmri.Emir = _isEmriYukIndirme;

            lblIsEmri.Text = "{0} kapısıdan {1} plakalı aracın yükü, {2}({3}) alanına {4} ile indirilecek.".Display(
                grdVIsEmriListe.GetFocusedRowCellValue("KapiIsim").ToString(),
                grdVIsEmriListe.GetFocusedRowCellValue("MalKabulAracPlaka").ToString(),
                grdVIsEmriListe.GetFocusedRowCellValue("AdresIsim").ToString(),
                grdVIsEmriListe.GetFocusedRowCellValue("AdresKod").ToString(),
                grdVIsEmriListe.GetFocusedRowCellValue("DepoIciAracIsim").ToString()
                );
            teDepoIciArac.Enabled = true;
            teDepoIciArac.Focus();
        }

        private void TEAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AdresOp adresOp = new AdresOp();
                Adres adres = adresOp.GetAdres(teAdres.Text);
                if (adres != null && adres.Id == ((IsEmriYukIndirme)_isEmri.Emir).AdresId)
                {
                    lblAdres.Text = adres.Isim;
                    IsEmriOp isEmriOp = new IsEmriOp();
                    if(isEmriOp.DurumGuncelle(_isEmri,DurumIsEmri.Baslama))
                    {
                        MessageBox.Show("İş Başladı...");
                        KullaniciOp kullaniciOp = new KullaniciOp();
                        _personelIsEmirleri = kullaniciOp.IsEmriListesi(TipIsEmri.YukIndirme);
                        grdIsEmriListeKullanici.DataSource = _personelIsEmirleri;
                    }
                }
                else MessageBox.Show("Seçili Adres İş Emri İle Uyuşmuyor.", DM.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teDepoIciArac_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            teAdres.Enabled = false;
            lblDepoIciArac.Text = "";
        }

        private void teAdres_EditValueChanged(object sender, EventArgs e)
        {
            lblAdres.Text = "";
        }
    }
}
