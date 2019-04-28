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

namespace NewEraDepo
{
    public partial class FormStokUrunYerlestir : Form
    {
        StokOp _stokOp;
        AyarlarKullaniciOp _ayarlarKulaniciOp;
        private Boolean _isAdresEmpty = false;
        private bool _isurunExist = false;
        private string _adresKod;
        private Guid _urunStokId;
        private Guid _adresId;

        private Color _foundColor;
        private Color _notFounColor;

        public FormStokUrunYerlestir()
        {
            InitializeComponent();
            this.Text = DM.ProjectName + "-STOĞA ÜRÜN YERLEŞTİRME";

            this.CenterToScreen();
            lblSonuc.Visible = false;
            lblSonuc2.Visible = false;
            _stokOp = new StokOp();
            _ayarlarKulaniciOp = new AyarlarKullaniciOp();

            btnStokEkle.Enabled = false;
            _foundColor = Color.Green;
            _notFounColor = Color.Red;

            CbDoldur();
           
        }

        /// <summary>
        /// Stok güncelleme işlemi için gerekli kontrollerin içini dolduracak parametreleri alır ve doldurur,
        /// 
        /// </summary>
        /// <param name="adresId"></param>
        /// <param name="stokId"></param>
        /// <param name="depoId"></param>
        /// <param name="adresKod"></param>
        /// <param name="urunKod"></param>
        public void InitForGuncelleme(Guid adresId,Guid stokId,Guid depoId, string adresKod,string urunKod)
        {
            try
            {
                textAdesKod.Text = adresKod;
                textUrunKod.Text = urunKod;
                _stokOp = new StokOp();
                btnStokEkle.Enabled = true;
                btnStokEkle.Text = "GÜNCELLE";
                CbDoldur(depoId);
                AdresAra();
                UrunAra();
            }
            catch (Exception ex)
            {

                MessageBox.Show("InitForGuncelleme\n"+ex.Message);
            }
        }

        /// <summary>
        /// Depo bilgilerini ComboBox a doldurur.
        /// </summary>
        private void CbDoldur()
        {
            CbDepo.ValueMember = "Id";
            CbDepo.DisplayMember = "Isim";
            CbDepo.DataSource = _ayarlarKulaniciOp.KullaciniDepoCbDoldur();
        }

        /// <summary>
        /// Gelen DepoId ye göre Depo bigilerini ComboBox a doldurur.
        /// </summary>
        /// <param name="depoId"></param>
        private void CbDoldur(Guid depoId)
        {
            CbDepo.ValueMember = "Id";
            CbDepo.DisplayMember = "Isim";
            CbDepo.DataSource = _stokOp.DepoCbGetir(depoId);
        }

        private void Btn_Click(object sender , EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                switch (btn.Name)
                {
                    case "btnAdresAra":
                        AdresAra();
                        break;
                    case "btnStokEkle":
                        StokEkle();
                        break;
                    case "btnUrunAra":
                        UrunAra();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Btn_Click"+ex.Message);
            }
        }

        /// <summary>
        /// Girilen Barkoda ait hücrenin olup olmadıgını ve ya o hücrenin dolu olup olmadıgını bilgisi getirir.
        /// Eger dolu ise o hücrede bulunan ürünün ismini ekrana basar
        /// </summary>
        private void AdresAra()
        {
            try
            {
                if (!textAdesKod.TextIsEmpty())
                {
                    string kod = textAdesKod.Text.RemoveWhitespaces();
                    if (IsAdresKodValid(kod))
                    {
                        lblSonuc.Visible = true;
                       
                        DataTable dt = _stokOp.AdresUrunGetir(kod);
                        if (dt.Rows.Count > 0)
                        {
                            _isAdresEmpty = false;
                            DataRow row = dt.Rows[0];
                            lblSonuc.Text = row["StokIsim"].ToString();
                            lblSonuc.ForeColor = _foundColor;
                            _adresKod = kod;
                            if (_isurunExist)
                                btnStokEkle.Enabled = true;
                            else
                                btnStokEkle.Enabled = false;
                        }
                        else
                        {
                            lblSonuc.Text = "BU HÜCREDE ÜRÜN BULUNMAMAKTADIR";
                            _isAdresEmpty = true;
                            lblSonuc.ForeColor = _notFounColor;
                        }
                    }
                    else
                    {
                        lblSonuc.Visible = false;
                        MessageBox.Show("GEÇERSİZ ADRES KODU!",
                                                    "UYARI",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error,
                                                     MessageBoxDefaultButton.Button1);
                    }
                        
                }
                else
                    MessageBox.Show("BOŞ ALANLAR DOLDURULMALIDIR!",
                                                 "HATA",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation,
                                                  MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {

                MessageBox.Show("AdresAra\n"+ex.Message);
            }
        }

        /// <summary>
        /// Girilen Barkoda ve ya Urun koduna ait ürünün olup olmadıgını kontrol eder. Eger ürün var ise ürünün 
        /// ismini ekrana basar.
        /// </summary>
        private void UrunAra()
        {
            try
            {
                if (!textUrunKod.TextIsEmpty())
                {
                    string kod = textUrunKod.Text.RemoveWhitespaces();
                    DataTable dt = _stokOp.UrunBilgisiGetir(kod);

                    if (dt.Rows.Count>0)
                    {
                        _isurunExist = true;
                        DataRow row = dt.Rows[0];
                        _urunStokId = new Guid(row["Id"].ToString());
                        string urunIsim = row["Isim"].ToString();
                        lblSonuc2.Text = urunIsim;
                        lblSonuc2.Visible = true;
                        lblSonuc2.ForeColor = _foundColor;
                        if (!textAdesKod.TextIsEmpty() && IsAdresKodValid(textAdesKod.Text))
                            btnStokEkle.Enabled = true;
                        else
                            btnStokEkle.Enabled = false;
                    
                    }
                    else
                    {
                        lblSonuc2.Visible = false;
                        btnStokEkle.Enabled = false;
                        _isurunExist = false;
                        MessageBox.Show("GEÇERSİZ URUN KODU!",
                                                    "UYARI",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error,
                                                     MessageBoxDefaultButton.Button1);
                    }
                }
                else
                    MessageBox.Show("BOŞ ALANLAR DOLDURULMALIDIR!",
                                                 "HATA",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation,
                                                  MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {

                MessageBox.Show("UrunAra\n"+ex.Message);
            }
        }

        /// <summary>
        /// İstenilen ürünü istenilen hücreye ekler ve ya o hücreyi günceller.
        /// </summary>
        private void StokEkle()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("YERLEŞTİRME İŞLEMİNİ TAMAMLAMAK İSTİYOR MUSUNUZ?",
                                             "ÖNEMLİ UYARI",
                                              MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (_isAdresEmpty)
                    {
                        _stokOp.StokEkle(_adresId, _urunStokId);
                        MessageBox.Show("STOK EKLEME BAŞARILI");
                    }
                    else
                    {
                        _stokOp.StokGuncelle(_adresId, _urunStokId);
                        MessageBox.Show("STOK GÜNCELLEME BAŞARILI");
                    }
                }
                else if (dialogResult == DialogResult.No)
                    this.Close();
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("STOK İŞLEMİ BAŞARISIZ");
                MessageBox.Show("StokEkle\n" + ex.Message);
            }
        }

        /// <summary>
        /// Adres kodunun geçerli olup olmadıgı kontrol edip boolean sonuc döndürür.
        /// </summary>
        /// <param name="kod"></param>
        /// <returns></returns>
        private bool IsAdresKodValid(string kod)
        {
            try
            {
                Guid depoId = new Guid(CbDepo.SelectedValue.ToString());
                DataTable dt=_stokOp.AdresKodGetir(kod,depoId);
                
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    _adresId = new Guid(row["AdresId"].ToString());
                    return true;
                }
                   


                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("IsAdresKodValid\n"+ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Adres kodunda degişiklik yapıldıgında ilgili kontroller ile ilgili işlem yapar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textAdesKod_TextChanged(object sender, EventArgs e)
        {
            btnStokEkle.Enabled = false;
            lblSonuc.Visible = false;
        }

        /// <summary>
        /// Ürün kodunda degişiklik yapıldıgında ilgili kontroller ile ilgili işlem yapar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textUrunKod_TextChanged(object sender, EventArgs e)
        {
            btnStokEkle.Enabled = false;
            lblSonuc2.Visible = false;
            _isurunExist = false;
        }
    }
}
