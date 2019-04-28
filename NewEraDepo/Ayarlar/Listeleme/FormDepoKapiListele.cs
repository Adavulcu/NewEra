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
using NewEraDepo.Data;
using NewEraDepo.Ayarlar.Ekleme;
using NewEraDepo.Ayarlar.Guncelleme;
namespace NewEraDepo.Ayarlar.Listeleme
{
    public partial class FormDepoKapiListele : Form
    {
        AyarlarDepoOp _ayrlarDepoOp;
        public FormDepoKapiListele()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                this.Text = DM.ProjectName + "-DEPO KAPI LİSTESİ";
                this.CenterToScreen();
                _ayrlarDepoOp = new AyarlarDepoOp();
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Init\n"+ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                gridControlDepoKapi.DataSource = _ayrlarDepoOp.AdresKapiGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show("LoadData\n"+ex.Message);
            }
        }

      

        private void Guncelle()
        {
            try
            {
                Guid id = new Guid(gridViewDepoKapi.GetFocusedRowCellValue("KapiId").ToString());
                string isim = gridViewDepoKapi.GetFocusedRowCellValue("KapiIsim").ToString();
                string kod = gridViewDepoKapi.GetFocusedRowCellValue("KapiKod").ToString();
                string depox= gridViewDepoKapi.GetFocusedRowCellValue("DepoXIsim").ToString();
                FormDepoKapiGuncelle fdkg = new FormDepoKapiGuncelle();
                fdkg.Init(id,kod,isim,depox);
                fdkg.ShowDialog();
                LoadData();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Guncelle\n"+ex.Message);
            }
        }

        private void gridViewDepoKapi_PopupMenuShowing(object sender,PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                popupMenuKapi.ShowPopup(MousePosition);
            }
        }

        private void BarBtnClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Guncelle();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BarBtnClick\n"+ex.Message);
            }
        }

        

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                FormDepoKapiEkle fdke = new FormDepoKapiEkle();
                fdke.ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnEkle_Click\n"+ex.Message);
            }
        }

        private void gridViewDepoKapi_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                Guncelle();
            }
            catch (Exception ex)
            {

                MessageBox.Show("\nGridDepoDepoKapi_doubleClick\n" + ex.Message);
            }
        }
    }
}
