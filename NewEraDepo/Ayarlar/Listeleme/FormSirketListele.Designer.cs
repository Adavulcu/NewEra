namespace NewEraDepo.Ayarlar.Listeleme
{
    partial class FormSirketListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControlSirket = new DevExpress.XtraGrid.GridControl();
            this.gridViewSirket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColCariId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColLogoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColLogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridColCariKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColCariIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.popupMenuCari = new DevExpress.XtraBars.PopupMenu(this.components);
            this.BarBtnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerCari = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSirket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSirket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCari)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlSirket, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEkle, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControlSirket
            // 
            this.gridControlSirket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSirket.Location = new System.Drawing.Point(3, 3);
            this.gridControlSirket.MainView = this.gridViewSirket;
            this.gridControlSirket.Name = "gridControlSirket";
            this.gridControlSirket.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            this.gridControlSirket.Size = new System.Drawing.Size(794, 376);
            this.gridControlSirket.TabIndex = 0;
            this.gridControlSirket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSirket});
            // 
            // gridViewSirket
            // 
            this.gridViewSirket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColCariId,
            this.gridColLogoId,
            this.gridColLogo,
            this.gridColCariKod,
            this.gridColCariIsim,
            this.gridColAciklama});
            this.gridViewSirket.GridControl = this.gridControlSirket;
            this.gridViewSirket.Name = "gridViewSirket";
            this.gridViewSirket.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewSirket.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Expand;
            this.gridViewSirket.OptionsView.RowAutoHeight = true;
            this.gridViewSirket.OptionsView.ShowGroupPanel = false;
            this.gridViewSirket.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewSirket_PopupMenuShowing);
            this.gridViewSirket.DoubleClick += new System.EventHandler(this.gridViewSirket_DoubleClick);
            // 
            // gridColCariId
            // 
            this.gridColCariId.Caption = "ID";
            this.gridColCariId.FieldName = "CariId";
            this.gridColCariId.Name = "gridColCariId";
            this.gridColCariId.OptionsColumn.AllowEdit = false;
            // 
            // gridColLogoId
            // 
            this.gridColLogoId.Caption = "LOGO ID";
            this.gridColLogoId.FieldName = "LogoId";
            this.gridColLogoId.Name = "gridColLogoId";
            this.gridColLogoId.OptionsColumn.AllowEdit = false;
            // 
            // gridColLogo
            // 
            this.gridColLogo.AppearanceCell.Options.UseImage = true;
            this.gridColLogo.Caption = "LOGO";
            this.gridColLogo.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColLogo.FieldName = "Logo";
            this.gridColLogo.MaxWidth = 64;
            this.gridColLogo.MinWidth = 64;
            this.gridColLogo.Name = "gridColLogo";
            this.gridColLogo.OptionsColumn.AllowEdit = false;
            this.gridColLogo.Visible = true;
            this.gridColLogo.VisibleIndex = 0;
            this.gridColLogo.Width = 64;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // gridColCariKod
            // 
            this.gridColCariKod.Caption = "ŞİRKET KODU";
            this.gridColCariKod.FieldName = "CariKod";
            this.gridColCariKod.Name = "gridColCariKod";
            this.gridColCariKod.OptionsColumn.AllowEdit = false;
            this.gridColCariKod.Visible = true;
            this.gridColCariKod.VisibleIndex = 1;
            // 
            // gridColCariIsim
            // 
            this.gridColCariIsim.Caption = "ŞİRKET İSMİ";
            this.gridColCariIsim.FieldName = "CariIsim";
            this.gridColCariIsim.Name = "gridColCariIsim";
            this.gridColCariIsim.OptionsColumn.AllowEdit = false;
            this.gridColCariIsim.Visible = true;
            this.gridColCariIsim.VisibleIndex = 2;
            // 
            // gridColAciklama
            // 
            this.gridColAciklama.Caption = "AÇIKLAMA";
            this.gridColAciklama.FieldName = "Aciklama";
            this.gridColAciklama.Name = "gridColAciklama";
            this.gridColAciklama.OptionsColumn.AllowEdit = false;
            this.gridColAciklama.Visible = true;
            this.gridColAciklama.VisibleIndex = 3;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.Location = new System.Drawing.Point(300, 385);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(300, 3, 300, 3);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(200, 62);
            this.BtnEkle.TabIndex = 1;
            this.BtnEkle.Text = "YENİ ŞİRKET EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // popupMenuCari
            // 
            this.popupMenuCari.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarBtnGuncelle)});
            this.popupMenuCari.Manager = this.barManagerCari;
            this.popupMenuCari.Name = "popupMenuCari";
            // 
            // BarBtnGuncelle
            // 
            this.BarBtnGuncelle.Caption = "DÜZENLE";
            this.BarBtnGuncelle.Id = 0;
            this.BarBtnGuncelle.Name = "BarBtnGuncelle";
            this.BarBtnGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnGuncelle_ItemClick);
            // 
            // barManagerCari
            // 
            this.barManagerCari.DockControls.Add(this.barDockControlTop);
            this.barManagerCari.DockControls.Add(this.barDockControlBottom);
            this.barManagerCari.DockControls.Add(this.barDockControlLeft);
            this.barManagerCari.DockControls.Add(this.barDockControlRight);
            this.barManagerCari.Form = this;
            this.barManagerCari.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BarBtnGuncelle});
            this.barManagerCari.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerCari;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManagerCari;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManagerCari;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManagerCari;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 450);
            // 
            // FormSirketListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormSirketListele";
            this.Text = "FormSirketListele";
            this.Shown += new System.EventHandler(this.FormSirketListele_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSirket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSirket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControlSirket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSirket;
        private System.Windows.Forms.Button BtnEkle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCariId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColLogoId;
        public DevExpress.XtraGrid.Columns.GridColumn gridColLogo;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCariKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCariIsim;
        private DevExpress.XtraGrid.Columns.GridColumn gridColAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.PopupMenu popupMenuCari;
        private DevExpress.XtraBars.BarButtonItem BarBtnGuncelle;
        private DevExpress.XtraBars.BarManager barManagerCari;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}