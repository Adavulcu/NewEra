using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NewEraDepo.Models;
using NewEraDepo.Dialogs;
using NewEraDepo.Data;
using System.IO;
using System.Reflection;

namespace NewEraDepo
{
    public partial class FormModules : Form
    {
        List<Rol> _roller;

        NavigationPane pane;
        NavigationPage page;

        Kullanici kullanici;
        KullaniciOp _kullaniciOp;
        public FormModules()
        {
            InitializeComponent();
            FormLogin formLogin = new FormLogin();

            formLogin.ShowDialog();
            kullanici = formLogin.LgnKullanici;
            DM.kullanici = kullanici;

        }

        private void FormModules_Shown(object sender, EventArgs e)
        {
            if (DM.kullanici == null) Close();
            else
            {
                statusStrip1.Items[0].Text = kullanici.Isim;
                Init();
            }
           
        }

        private void Init()
        {
            this.Text = DM.ProjectName + "-MODULLER";

            this.CenterToScreen();
            _kullaniciOp = new KullaniciOp();
            _roller = kullanici.Roller();
            InitModuls();

        }

        /// <summary>
        /// NavigationPane için Sayfaları oluşturur.
        /// </summary>
        private void InitModuls()
        {
            try
            {
                pane = paneModul;
                pane.StateChanging += StateChanging;
                List<Modul> Moduls = new List<Modul>();
                Moduls = _kullaniciOp.ModulOlustur();

                for (int j = 0; j < Moduls.Count; j++)
                {
                    page = new NavigationPage()
                    {
                        Name = Moduls[j].Isim,
                        Caption = Moduls[j].Isim.ToUpper(),
                        PageText = Moduls[j].Isim.ToUpper()
                        
                        
                        
                    };
                    
                    Image img= (ImgListModul.Images[Moduls[j].ImgIndex]).ResizeImage(new Size(50,50));
                    
                    page.ImageOptions.Image = img;
                    InitPages(page, Moduls[j]);
                    pane.Pages.Add(page);
                    

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("InitModuls\n" + ex.Message);
            }
        }

        private void StateChanging(object sender, StateChangingEventArgs e)
        {
            e.Cancel = true;
        }




        /// <summary>
        /// NavigationPage için Modul ve SubModul leri oluşturur.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="modul"></param>
        /// <param name="prevModul"></param>
        /// <param name="folderBackFlag"></param>
        private void InitPages(NavigationPage page, Modul modul, Modul prevModul = null, bool folderBackFlag = false)
        {
            ListView list = new ListView
            {
                MultiSelect = false
            };
            //  ListViewItem_SetSpacing(list, 64 + 32, 300 + 16);

            try
            {
                ImageList imgList = new ImageList();

                list.Dock = DockStyle.Fill;
                list.View = View.LargeIcon;

                list.LargeImageList = ImgListModul;

                ListViewItem item = new ListViewItem();
                if (folderBackFlag)
                {
                    item = new ListViewItem("GERİ", 0)
                    {
                        ImageIndex = 0,
                        Name = "folderBack",
                        Tag = new SubModul(new Guid(), "folderBack", "GERİ", false, 0, "0")
                    };
                    list.Items.Add(item);
                }

                for (int i = 0; i < modul.SubModuls.Count; i++)
                {

                    if (modul.SubModuls[i].IsSubmodul)
                    {
                        item = new ListViewItem(modul.SubModuls[i].Isim, 0)
                        {
                            ImageIndex = modul.SubModuls[i].ImgIndex,
                            Name = modul.SubModuls[i].ClassName,
                            Tag = modul.SubModuls[i]

                        };
                    }
                    else
                    {
                        item = new ListViewItem(modul.SubModuls[i].Isim, 0)
                        {
                            ImageIndex = modul.SubModuls[i].ImgIndex,
                            Name = "0",
                            Tag = new SubModul(new Guid(), modul.SubModuls[i].ClassName, modul.SubModuls[i].Isim, false, modul.SubModuls[i].ImgIndex, modul.SubModuls[i].ModulId, modul.SubModuls[i].SubModuls)
                        };
                    }


                    list.Items.Add(item);

                }
                list.DoubleClick += delegate (object sender, EventArgs e) { ListClick(sender, e, modul, page, prevModul); };
                page.Controls.Add(list);
            }
            catch (Exception ex)
            {

                MessageBox.Show("InitPage\n" + ex.Message);
            }


        }

       
        private void ListClick(object sender, EventArgs e, Modul m, NavigationPage page, Modul prev)
        {
            try
            {
                ListView list = (ListView)sender;
                ListViewItem item = list.FocusedItem;

                if (((SubModul)item.Tag).IsSubmodul)
                {
                    bool flag = false;
                    for (int i = 0; i < _roller.Count; i++)
                    {
                        if (_kullaniciOp.YetkiIzni(_roller[i].Id, ((SubModul)item.Tag).Id, Yetki.Giris))
                        {
                            object o = CreateForm(((SubModul)item.Tag).ClassName);
                            if (o is Form frm)
                            {
                                frm.ShowDialog(this);
                            }
                            else if (o is System.Windows.Window w)
                            {
                                w.ShowDialog();
                            }
                            flag = true;
                            break;

                        }

                    }
                    if (!flag)
                        MessageBox.Show("BU MODULE GİRİŞ YETKİNİZ YOKTUR");

                }

                else
                {
                    if (((SubModul)item.Tag).ClassName.Equals("folderBack"))
                    {
                        page.Controls.Clear();
                        InitPages(page, prev);
                    }
                    else
                    {
                        page.Controls.Clear();
                        InitPages(page, ((SubModul)item.Tag), m, true);
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("ListClick\n" + ex.Message);
            }
        }

        /// <summary>
        /// Tıklanan Module ait Formu oluşturur.
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        private object CreateForm(string formName)
        {
           
                try
                {
                    
                    string[] str = formName.Split('/');
                    string assemblyName = str[0];
                    string className = str[1];
                    Type type = Assembly.Load(assemblyName).GetTypes().First(t => t.Name == className);
                    return Activator.CreateInstance(type);
                }
                catch (Exception ex)
                {

                MessageBox.Show("CreateForm\n" + ex.Message);
                return null;
                }

            
        }



    }
}
