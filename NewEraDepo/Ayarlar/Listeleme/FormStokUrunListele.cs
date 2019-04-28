using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using NewEraDepo.Data;
using NewEraDepo.Models;
namespace NewEraDepo
{
    public partial class FormStokUrunListele : Form
    {
        StokOp _stopOp;
        FormStokUrunYerlestir _fsuy;
        public FormStokUrunListele()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                this.Text = DM.ProjectName + "-STOK ÜRÜN LİSTELEME";
                this.CenterToScreen();
                _stopOp = new StokOp();
                
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Init\n"+ex.Message);
            }
        }

       private void LoadData()
        {
            gridControlStok.DataSource = _stopOp.AdresUrunGetir();

        }

        private void BarBtnClick(object sender,ItemClickEventArgs e)
        {
            try
            {
                string name = e.Item.Name.ToString();
                switch (name)
                {
                    case "barBtnGuncelle":
                        Guncelle();
                        break;
                    case "barBtnSil":
                        Sil();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("BarBtnClick\n"+ex.Message);
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            _fsuy = new FormStokUrunYerlestir();
            _fsuy.ShowDialog();
            LoadData();
        }

        private void gridViewStok_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {

                if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
                {
                    GridView v = (GridView)sender;
                    popupMenuStok.ShowPopup(MousePosition);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("gridViewStok_PopupMenuShowing\n" + ex.Message);
            }
        }

        private void gridControlStok_DoubleClick(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            try
            {
                Guid adresId = new Guid(gridViewStok.GetFocusedRowCellValue("AdresId").ToString());
                Guid stokId = new Guid(gridViewStok.GetFocusedRowCellValue("StokId").ToString());
                Guid depoId = new Guid(gridViewStok.GetFocusedRowCellValue("DepoId").ToString());
                string adresKod = gridViewStok.GetFocusedRowCellValue("Adres").ToString();
                string urunKod = gridViewStok.GetFocusedRowCellValue("UrunKod").ToString();
                _fsuy = new FormStokUrunYerlestir();
                _fsuy.InitForGuncelleme(adresId, stokId, depoId, adresKod, urunKod);
                _fsuy.ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Guncelle\n"+ex.Message);
            }
        }

        private void Sil()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("SİLME İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                                            "ÖNEMLİ UYARI",
                                             MessageBoxButtons.YesNoCancel,
                                            MessageBoxIcon.Question);
                Guid Id = new Guid(gridViewStok.GetFocusedRowCellValue("Id").ToString());
                _stopOp.StokSil(Id);
                MessageBox.Show("SİLME İŞLMEİ BAŞARILI");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SİLME İŞLMEİ BAŞARISIZ");
                MessageBox.Show("Sil\n" + ex.Message);
            }
        }
    }
}
