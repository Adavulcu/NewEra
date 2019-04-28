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

namespace NewEraDepo.Ayarlar
{
    public partial class FormModulRol : Form
    {
        private AyarlarKullaniciOp _ayarKullaniciOP;

        public FormModulRol()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            this.Text = DM.ProjectName + "-MODUL AYARLAMA";
            _ayarKullaniciOP = new AyarlarKullaniciOp();
            this.CenterToScreen();
            CbRolDoldur();
        }
        /// <summary>
        /// ComboBox a Rol bilgilerini doldurur.
        /// </summary>
        private void CbRolDoldur()
        {
            CbRoller.DisplayMember = "Kod";
            CbRoller.ValueMember = "Id";
            CbRoller.DataSource= _ayarKullaniciOP.CbGetRoles();
        }

        private void CbRoller_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Guid rolID = new Guid(CbRoller.SelectedValue.ToString());
                gridControlModul.DataSource = _ayarKullaniciOP.ModulGetir(rolID);

            }
            catch (Exception ex)
            {

                MessageBox.Show("CbRoller_SelectedIndexChanged\n" + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ModulKaydet();
        }

        private void ModulKaydet()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("KAYIT İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
           "ÖNEMLİ UYARI",
           MessageBoxButtons.YesNoCancel,
           MessageBoxIcon.Question);

                if (dialogResult==DialogResult.Yes)
                {
                    for (int i = 0; i < gridViewMoldul.RowCount; i++)
                    {
                        Guid rolId = new Guid(CbRoller.SelectedValue.ToString());
                        Guid moduld = new Guid(gridViewMoldul.GetRowCellValue(i, "Id").ToString());
                        bool giris = gridViewMoldul.GetRowCellValue(i, "Giris").To<bool>();
                        bool ekleme = gridViewMoldul.GetRowCellValue(i, "Ekleme").To<bool>();
                        bool guncelleme = gridViewMoldul.GetRowCellValue(i, "Guncelleme").To<bool>();
                        bool silme = gridViewMoldul.GetRowCellValue(i, "Silme").To<bool>();
                        DataTable dt = _ayarKullaniciOP.GetIdIsModulRolExist(rolId, moduld);
                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            Guid mrId = new Guid(row["Id"].ToString());
                            _ayarKullaniciOP.ModulRolGuncelle(mrId, giris, silme, ekleme, guncelleme);
                        }
                        else
                        {
                            _ayarKullaniciOP.ModulRolEkle(rolId, moduld, giris, silme, ekleme, guncelleme);
                        }
                      
                    }
                    MessageBox.Show("KAYIT İŞLEMİ BAŞARILI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("KAYIT İŞLEMİ BAŞARISIZ");
                MessageBox.Show("ModulKaydet\n"+ex.Message);
            }
        }
    }
}
