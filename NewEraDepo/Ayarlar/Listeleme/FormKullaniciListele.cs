using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FormKullaniciListele : Form
    {
        Data.AyarlarKullaniciOp _ayarKullaniciOP;
        Models.AyarlarKullanici _ayarlarKullanici;

        List<Models.AyarlarKullanici> _listAyarlar;
        List<Models.AyarlarKullaniciDetail> _ListAyarlarDetail;

        public FormKullaniciListele()
        {
            InitializeComponent();
            this.Text = DM.ProjectName + "-KULLANICI AYARLARI";
            _ayarKullaniciOP = new Data.AyarlarKullaniciOp();

            _listAyarlar = new List<Models.AyarlarKullanici>();
            _ListAyarlarDetail = new List<Models.AyarlarKullaniciDetail>();
            this.CenterToScreen();
        }

        private void FormKullaniciKaydet_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void LoadData()
        {
            _listAyarlar = _ayarKullaniciOP.KullaniciGetir();
            _ListAyarlarDetail = _ayarKullaniciOP.GetKullaniciDetails();
           
            gridControl1.DataSource = _listAyarlar;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Guid Id = new Guid(gridViewAyarlar.GetFocusedRowCellValue("Id").ToString());
                string Isim = gridViewAyarlar.GetFocusedRowCellValue("Isim").ToString();
                string Kod = gridViewAyarlar.GetFocusedRowCellValue("Kod").ToString();
                string Depo = gridViewAyarlar.GetFocusedRowCellValue("Depo").ToString();

                string Sifre = gridViewAyarlar.GetFocusedRowCellValue("Sifre").ToString();
                string depoId = gridViewAyarlar.GetFocusedRowCellValue("DepoId").ToString();
                _ayarlarKullanici = new Models.AyarlarKullanici(Id, Kod, Isim, Sifre, Depo, new Guid(depoId));

                FormGuncelleme fg = new FormGuncelleme();

                fg.InitControls(_ayarlarKullanici);
                fg.ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("gridControlDouble_Click\n"+ex.Message);
            }
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            FormKullaniciEkle fe = new FormKullaniciEkle();
            fe.ShowDialog();
        }

        private void gridViewAyarlar_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            GridView view =sender as GridView;

            if (view.GetRow(e.RowHandle) is Models.AyarlarKullanici ayar)
            {
                e.IsEmpty = !_ListAyarlarDetail.Any(x => x.KulId == ayar.Id);
            }
        }

        private void gridViewAyarlar_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (view.GetRow(e.RowHandle) is Models.AyarlarKullanici ayar)
                {
                    e.ChildList = _ListAyarlarDetail.Where(x => x.KulId == ayar.Id).ToList();
                    
                }

               
                //   GridView v = view.GetDetailView(0, 0) as GridView;
                //     v.Columns["RolId"].Visible = false;
                //    v.Columns["KulId"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("\ngetChildList\n"+ex.Message);
            }
        }

        private void gridViewAyarlar_MasterRowGetRelationCount(object sender,MasterRowGetRelationCountEventArgs e)
        {
            //set 1:Detail
            e.RelationCount = 1;
        }

        private void gridViewAyarlar_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ROLLER";
            
        }

        private void gridViewAyarlar_MasterRowExpanding(object sender, MasterRowCanExpandEventArgs e)
        {
            
            //gridViewAyarlarDetail.Columns["KulId"].Visible = false;
            //gridViewAyarlarDetail.Columns["RolId"].Visible = false;
        }

        private void gridViewAyarlar_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridView v = view.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            v.Columns["RolId"].Visible = false;
            v.Columns["KulId"].Visible = false;
            gridViewAyarlarDetail.AllowEdit(false);
            v.AllowEdit(false);
        }

        private void barBtnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Guid Id = new Guid(gridViewAyarlar.GetFocusedRowCellValue("Id").ToString());
                string Isim = gridViewAyarlar.GetFocusedRowCellValue("Isim").ToString();
                string Kod = gridViewAyarlar.GetFocusedRowCellValue("Kod").ToString();
                string Depo = gridViewAyarlar.GetFocusedRowCellValue("Depo").ToString();

                string Sifre = gridViewAyarlar.GetFocusedRowCellValue("Sifre").ToString();
                string depoId = gridViewAyarlar.GetFocusedRowCellValue("DepoId").ToString();
                _ayarlarKullanici = new Models.AyarlarKullanici(Id, Kod, Isim, Sifre, Depo, new Guid(depoId));

                FormGuncelleme fg = new FormGuncelleme();

                fg.InitControls(_ayarlarKullanici);
                fg.ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("barBtnGuncelle\n"+ex.Message);
            }
        }

        private void gridViewAyarlar_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {

                if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
                {
                    GridView v = (GridView)sender;
                    popupMenuKullanici.ShowPopup(MousePosition);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("gridViewAyarlar_PopupMenuShowing\n"+ex.Message);
            }
        }

        private void FormKullaniciListele_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
