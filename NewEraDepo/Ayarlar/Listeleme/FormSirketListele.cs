using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewEraDepo.Ayarlar.Ekleme;
using NewEraDepo.Ayarlar.Guncelleme;
using NewEraDepo.Data;
namespace NewEraDepo.Ayarlar.Listeleme
{
    public partial class FormSirketListele : Form
    {
        public FormSirketListele()
        {
            InitializeComponent();
            Init();
        
        }
        AyarlarCariOp _cariOp;
        DataTable _dt;
        private void Init()
        {

            this.Text = DM.ProjectName + "-ŞİRKET LİSTESİ";
            this.CenterToScreen();
            _cariOp = new AyarlarCariOp();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
               _dt = _cariOp.CariGetir();
                if (_dt.Rows.Count>0)
                {
                    gridControlSirket.DataSource = _dt;
                }
              
                   

            }
            catch (Exception ex)
            {

                MessageBox.Show("LoadData\n" + ex.Message);
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                FormSirketEkle fse = new FormSirketEkle();
                fse.ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnEkle_Click\n"+ex.Message);
            }
        }

        private void BarBtnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Guncelle();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BarBtnGuncelle\n"+ex.Message);
            }
        }

        private void gridViewSirket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                popupMenuCari.ShowPopup(MousePosition);
               
            }
        }

        private void gridViewSirket_DoubleClick(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            try
            {
                Guid cariId = new Guid(gridViewSirket.GetFocusedRowCellValue("CariId").ToString());
                Guid logoId = new Guid(gridViewSirket.GetFocusedRowCellValue("LogoId").ToString());
               byte[] array =(byte[])gridViewSirket.GetFocusedRowCellValue("Logo");


                Image img = array.ByteToImage();

                string kod = gridViewSirket.GetFocusedRowCellValue("CariKod").ToString();
                string isim = gridViewSirket.GetFocusedRowCellValue("CariIsim").ToString();
                string aciklama = gridViewSirket.GetFocusedRowCellValue("Aciklama").ToString();
                FormSirketEkle fse = new FormSirketEkle();
                fse.Init(cariId,logoId,kod,isim,aciklama,img);
                fse.ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Guncelle\n"+ex.Message);
            }
        }

        private void FormSirketListele_Shown(object sender, EventArgs e)
        {
            if (_dt.Rows.Count == 0)
            {
                MessageBox.Show("KAYITLI BİR ŞİRKET BULUNMAMAKTATIR",
                                              "BİLGİLENDİRME!",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Exclamation,
                                               MessageBoxDefaultButton.Button1);
            }
        }
    }
}
