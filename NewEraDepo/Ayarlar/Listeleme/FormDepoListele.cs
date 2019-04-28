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
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using NewEraDepo.Ayarlar.Guncelleme;
using NewEraDepo.Ayarlar;
using NewEraDepo.Ayarlar.Ekleme;

namespace NewEraDepo
{
    public partial class FormDepoListele : Form
    {
        #region Variables
        AyarlarDepoOp _ayarlarDepoOp;
        DataTable _depoList;

        private Guid _ULIdKat;
        private Guid _ULIdBol;
        private Guid _ULIdRaf;
        private Guid _ULIdKoy;
        private Guid _ULIdY;
        private Guid _ULIdX;

        private int _FocusRowDepo = 0;
        private int _FocusRowKat = 0;
        private int _FocusRowBol = 0;
        private int _FocusRowRaf = 0;
        private int _FocusRowKoy = 0;
        private int _FocusRowY = 0;

        private int _currentFocusAdres = 0;


        BaseAdres _currentAdres;
        Depo _currentDepo;

        GridView _currentEkleView;
        GridView _currentAdresView;

        bool isDepoSelected = false;

        bool isAdresSelected = false;

        string _currentAdresTblName = "";
        #endregion



        public FormDepoListele()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// Depo bilgilerini listelemek için gerekli nesneleri oluşturup gerekli motoları cagırır.
        /// </summary>
        private void Init()
        {
            this.Text = DM.ProjectName + "-DEPO AYARLARI";
            this.CenterToScreen();
            _ayarlarDepoOp = new AyarlarDepoOp();
            _depoList = new DataTable();

            LoadData();
        }

        /// <summary>
        /// Depo listelemek için gerekli verileri oluşturur.
        /// </summary>
        public void LoadData()
        {
            try
            {
                _currentEkleView = gridViewDepo;
                _depoList = _ayarlarDepoOp.DepoGetir();
                gridAyarlarDepo.DataSource = _depoList;
                gridViewDepo.FocusedRowHandle = gridViewDepo.GetRowHandle(_FocusRowDepo);

                BtnKat.Visible = false;
                BtnBol.Visible = false;
                BtnRaf.Visible = false;
                BtnKoy.Visible = false;
                BtnY.Visible = false;
                BtnX.Visible = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show("\nLoadData\n" + ex.Message);
            }
        }

        /// <summary>
        /// ParentView den aldıgı ULID ile ChildView i doldurur ve yeni MainView ChildView olur
        /// </summary>
        /// <param name="parenView"></param>
        /// <param name="childView"></param>
        /// <param name="tblName"></param>
        private void SetMainView(GridView parenView, GridView childView, Guid ULId, string tblName)
        {
            try
            {
                DataTable dt = new DataTable();
                //Guid Id = new Guid(parenView.GetFocusedRowCellValue("Id").ToString());
                if (parenView.Name == "gridViewDepoY")
                    dt = _ayarlarDepoOp.AdresDepoXGetir(ULId);
                else
                    dt = _ayarlarDepoOp.AdresDTGetir(ULId, tblName);

                if (dt.Rows.Count != 0)
                {
                    gridAyarlarDepo.DataSource = dt;
                    gridAyarlarDepo.MainView = childView;
                //    childView.AllowEdit(false);
                    _currentEkleView = childView;

                }
                else
                {
                    gridAyarlarDepo.DataSource = dt;
                    gridAyarlarDepo.MainView = childView;
                 //   childView.AllowEdit(false);
                    _currentEkleView = childView;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("SetMainView\n" + ex.Message);

            }
        }
        /// <summary>
        /// MainView i yeniler
        /// </summary>
        /// <param name="view"></param>
        /// <param name="Id"></param>
        /// <param name="tblName"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        private Boolean RefleshMainView(GridView view, Guid Id, string tblName, int rowIndex)
        {
            try
            {
                DataTable dt = new DataTable();
                if (view.Name == "gridViewDepoX")
                    dt = _ayarlarDepoOp.AdresDepoXGetir(Id);
                else
                dt = _ayarlarDepoOp.AdresDTGetir(Id, tblName);

                gridAyarlarDepo.DataSource = dt;
                gridAyarlarDepo.MainView = view;
                view.FocusedRowHandle = view.GetRowHandle(rowIndex);
             //   view.AllowEdit(false);
                _currentEkleView = view;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("RefleshMainView \n" + ex.Message);
                return false;

            }
        }
        /// <summary>
        /// Çift tıklanan GridView in secilen satırındaki adres bilgilerini alıp
        /// Alt adresteki veriler oluşturmak için gerekli metorlara gönderir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridViewDouble_Click(object sender, EventArgs e)
        {
            try
            {
                GridView v = (GridView)sender;

                if (v.RowCount>0)
                {
                    switch (v.Name)
                    {
                        case "gridViewKat":
                            _FocusRowKat = v.GetFocusedDataSourceRowIndex();
                            _ULIdBol = new Guid(v.GetFocusedRowCellValue("Id").ToString());
                            SetMainView(v, gridViewBolge, _ULIdBol, "ne_DepoBolge");
                            BtnBol.Visible = true;

                            break;
                        case "gridViewBolge":
                            _FocusRowBol = v.GetFocusedDataSourceRowIndex();
                            _ULIdRaf = new Guid(v.GetFocusedRowCellValue("Id").ToString());
                            SetMainView(v, gridViewRaf, _ULIdRaf, "ne_DepoRaf");
                            BtnRaf.Visible = true;

                            break;
                        case "gridViewRaf":
                            _FocusRowRaf = v.GetFocusedDataSourceRowIndex();
                            _ULIdKoy = new Guid(v.GetFocusedRowCellValue("Id").ToString());
                            SetMainView(v, gridViewKoy, _ULIdKoy, "ne_DepoKoy");
                            BtnKoy.Visible = true;
                            break;
                        case "gridViewKoy":
                            _FocusRowKoy = v.GetFocusedDataSourceRowIndex();
                            _ULIdY = new Guid(v.GetFocusedRowCellValue("Id").ToString());
                            SetMainView(v, gridViewDepoY, _ULIdY, "ne_DepoY");
                            BtnY.Visible = true;
                            break;
                        case "gridViewDepoY":
                            _FocusRowY = v.GetFocusedDataSourceRowIndex();
                            _ULIdX = new Guid(v.GetFocusedRowCellValue("Id").ToString());
                            SetMainView(v, gridViewDepoX, _ULIdX, "ne_DepoX");
                            BtnX.Visible = true;
                            break;
                        default:
                            break;
                    } 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("\nGridViewDouble_Click\n" + ex.Message);
            }
        }
        /// <summary>
        /// Depo verilerini alıp DepoKat adresindeki verileri oluşturmak için gerekli metotlara gönderir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewDepo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView v = (GridView)sender;
                if(v.RowCount>0)
                {
                    _currentEkleView = gridViewDepo; ;
                    _FocusRowDepo = v.GetFocusedDataSourceRowIndex();
                    _ULIdKat = new Guid(gridViewDepo.GetFocusedRowCellValue("Id").ToString());
                    SetMainView(gridViewDepo, gridViewKat, _ULIdKat, "ne_DepoKat");
                    BtnKat.Visible = true;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("\nGridViewDepo_doubleClick\n" + ex.Message);
            }
        }

        /// <summary>
        /// MainView i depo bilgileri ile doldurur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHome_Click(object sender, EventArgs e)
        {
            try
            {
                gridAyarlarDepo.MainView = gridViewDepo;
                LoadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnHome\n" + ex.Message);
            }
        }

        /// <summary>
        /// İlgili button a ait bilgileri MainView e doldurur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            bool flag = false;
            switch (btn.Name)
            {
                case "BtnDepo":
                    gridAyarlarDepo.MainView = gridViewDepo;
                    LoadData();
                    break;
                case "BtnKat":
                    flag = RefleshMainView(gridViewKat, _ULIdKat, "ne_DepoKat", _FocusRowKat);
                    if (flag)
                    {
                        SetButtomVisibility(false, BtnBol, BtnRaf, BtnKoy, BtnY, BtnX);
                    }
                    break;
                case "BtnBol":
                    flag = RefleshMainView(gridViewBolge, _ULIdBol, "ne_DepoBolge", _FocusRowBol);
                    if (flag)
                    {
                        SetButtomVisibility(false, BtnRaf, BtnKoy, BtnY, BtnX);
                    }
                    break;
                case "BtnRaf":
                    flag = RefleshMainView(gridViewRaf, _ULIdRaf, "ne_DepoRaf", _FocusRowRaf);
                    if (flag)
                    {
                        SetButtomVisibility(false, BtnKoy, BtnY, BtnX);
                    }
                    break;
                case "BtnKoy":
                    flag = RefleshMainView(gridViewKoy, _ULIdKoy, "ne_DepoKoy", _FocusRowKoy);
                    if (flag)
                    {
                        SetButtomVisibility(false, BtnY, BtnX);
                    }
                    break;
                case "BtnY":
                    flag = RefleshMainView(gridViewDepoY, _ULIdY, "ne_DepoY", _FocusRowY);
                    if (flag)
                    {
                        SetButtomVisibility(false, BtnX);
                    }
                    break;

                default:
                    break;

            }
        }
     
        /// <summary>
        /// parametre olarak gönderilen Button ların görünürülüğünü paramatre olarak alınan
        /// bool flag degerine göre ayarlar
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="btn"></param>
        private void SetButtomVisibility(bool flag, params Button[] btn)
        {
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Visible = flag;
            }
        }


        private void barButtonGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (isDepoSelected)
                {
                    FormDepoGuncelle fdg = new FormDepoGuncelle();
                    fdg.Init(_currentDepo);
                    fdg.ShowDialog();
                    LoadData();
                }
                else if (isAdresSelected)
                {
                    FormAdresGuncelle fag = new FormAdresGuncelle();
                    fag.Init(_currentAdres, _currentAdresTblName);
                    fag.ShowDialog();
                    RefleshMainView(_currentAdresView, _currentAdres.UlId, _currentAdresTblName, _currentFocusAdres);
                }
                else
                    return;
            }
            catch (Exception ex)
            {

                MessageBox.Show("barButtonGuncelle_IitemClick\n" + ex.Message);
            }
        }

        /// <summary>
        /// Sağ tıklanan GridView in secilen satırındaki adres bilgilerini alıp
        /// Yeni bir adres nesnesi oluşturulur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_PopupMenıShoving(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
                {
                    GridView v = (GridView)sender;

                    switch (v.Name)
                    {
                        case "gridViewDepo":
                            isDepoSelected = true;
                            isAdresSelected = false;
                            Guid imgId;
                            Image img;
                            Guid depoID = new Guid(gridViewDepo.GetFocusedRowCellValue("Id").ToString());
                            var i = gridViewDepo.GetFocusedRowCellValue("ImageId").ToString();                                                 
                            var j = gridViewDepo.GetFocusedRowCellValue("Image");
                            if (i=="" || j==null)
                            {
                                 imgId =new Guid();
                                img = null;
                            }
                            else
                            {
                                 imgId = new Guid(i);
                                byte[] array = (byte[])j;
                                 img = array.ByteToImage();
                            }
                           
                            string depoIsim = gridViewDepo.GetFocusedRowCellValue("Isim").ToString();
                            string depoKod = gridViewDepo.GetFocusedRowCellValue("Kod").ToString();
                            int depoTip = (gridViewDepo.GetFocusedRowCellValue("Tip").ToString()).ToInt();
                            string depoAciklama = gridViewDepo.GetFocusedRowCellValue("Aciklama").ToString();
                            _currentDepo = new Depo(depoID, depoIsim, depoKod, depoAciklama, depoTip,imgId,img);

                            break;
                        case "gridViewKat":
                            isDepoSelected = false;
                            isAdresSelected = true;

                            _currentAdresView = v;
                            _currentFocusAdres = v.GetFocusedDataSourceRowIndex();
                            _currentAdresTblName = "ne_DepoKat";
                            _currentAdres = CreateAdres(v);

                            break;
                        case "gridViewBolge":
                            isDepoSelected = false;
                            isAdresSelected = true;

                            _currentAdresView = v;
                            _currentAdresTblName = "ne_DepoBolge";
                            _currentFocusAdres = v.GetFocusedDataSourceRowIndex();
                            _currentAdres = CreateAdres(v);

                            break;
                        case "gridViewRaf":
                            isDepoSelected = false;
                            isAdresSelected = true;

                            _currentAdresView = v;
                            _currentAdresTblName = "ne_DepoRaf";
                            _currentFocusAdres = v.GetFocusedDataSourceRowIndex();
                            _currentAdres = CreateAdres(v);

                            break;
                        case "gridViewKoy":
                            isDepoSelected = false;
                            isAdresSelected = true;

                            _currentAdresView = v;
                            _currentAdresTblName = "ne_DepoKoy";
                            _currentFocusAdres = v.GetFocusedDataSourceRowIndex();
                            _currentAdres = CreateAdres(v);

                            break;
                        case "gridViewDepoY":
                            isDepoSelected = false;
                            isAdresSelected = true;

                            _currentAdresView = v;
                            _currentAdresTblName = "ne_DepoY";
                            _currentFocusAdres = v.GetFocusedDataSourceRowIndex();
                            _currentAdres = CreateAdres(v);

                            break;
                        case "gridViewDepoX":
                            isDepoSelected = false;
                            isAdresSelected = true;
                            _currentAdresView = v;
                            _currentAdresTblName = "ne_DepoX";
                            _currentFocusAdres = v.GetFocusedDataSourceRowIndex();
                            _currentAdres = CreateAdres(v);

                            break;
                        default:
                            break;
                    }



                }

                popupMenuAdres.ShowPopup(MousePosition); // menu is GridViewMenu instance
            }
            catch (Exception ex)
            {

                MessageBox.Show("PopupMenuAdres\n" + ex.Message);
            }
        }

        /// <summary>
        /// Parametre olarak gelen GridView nesnesinin seclili satırındaki bilgileri larak yeni BaseAdress
        /// oluşturup geriye döndürür.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private BaseAdres CreateAdres(GridView v)
        {
            Guid id = new Guid(v.GetFocusedRowCellValue("Id").ToString());
            Guid ULId = new Guid(v.GetFocusedRowCellValue("ULId").ToString());
            string kod = v.GetFocusedRowCellValue("Kod").ToString();
            string isim = v.GetFocusedRowCellValue("Isim").ToString();
            return new BaseAdres(id, ULId, kod, isim);
        }

        private void BtnAdresEkle_Click(object sender, EventArgs e)
        {
            try
            {
                FormAdresEkle fae = new FormAdresEkle();
                FormDepoEkle fde = new FormDepoEkle();
                FormDepoXEkle fdex = new FormDepoXEkle();

                switch (_currentEkleView.Name)
                {
                    case "gridViewDepo":

                        fde.ShowDialog();
                        LoadData();
                        break;
                    case "gridViewKat":

                        fae.Init(_ULIdKat, "ne_DepoKat");
                        fae.ShowDialog();
                        RefleshMainView(_currentEkleView, _ULIdKat, "ne_DepoKat", 0);
                        break;
                    case "gridViewBolge":
                        fae.Init(_ULIdBol, "ne_DepoBolge");
                        fae.ShowDialog();
                        RefleshMainView(_currentEkleView, _ULIdBol, "ne_DepoBolge", 0);
                        break;
                    case "gridViewRaf":
                        fae.Init(_ULIdRaf, "ne_DepoRaf");
                        fae.ShowDialog();
                        RefleshMainView(_currentEkleView, _ULIdRaf, "ne_DepoRaf", 0);
                        break;
                    case "gridViewKoy":
                        fae.Init(_ULIdKoy, "ne_DepoKoy");
                        fae.ShowDialog();
                        RefleshMainView(_currentEkleView, _ULIdKoy, "ne_DepoKoy", 0);
                        break;
                    case "gridViewDepoY":
                        fae.Init(_ULIdY, "ne_DepoY");
                        fae.ShowDialog();
                        RefleshMainView(_currentEkleView, _ULIdY, "ne_DepoY", 0);
                        break;
                    case "gridViewDepoX":
                        fdex.Init(_ULIdX);
                        fdex.ShowDialog();
                        RefleshMainView(_currentEkleView, _ULIdX, "ne_DepoX", 0);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("BtnAdresEkle\n" + ex.Message);
            }
        }

        private void FormDepoListele_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }

}
