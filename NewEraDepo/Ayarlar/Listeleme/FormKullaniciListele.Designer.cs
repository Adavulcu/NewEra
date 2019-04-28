namespace NewEraDepo
{
    partial class FormKullaniciListele
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullaniciListele));
            this.gridViewAyarlarDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDetailRolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDetailKulId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDetailRolAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDetailRolKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewAyarlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Isim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Depo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kayitTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuncellemeTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnYeniKullanici = new System.Windows.Forms.Button();
            this.popupMenuKullanici = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barBtnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAyarlarDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewAyarlarDetail
            // 
            this.gridViewAyarlarDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColDetailRolId,
            this.ColDetailKulId,
            this.ColDetailRolAd,
            this.ColDetailRolKod});
            this.gridViewAyarlarDetail.GridControl = this.gridControl1;
            this.gridViewAyarlarDetail.Name = "gridViewAyarlarDetail";
            this.gridViewAyarlarDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewAyarlarDetail.OptionsView.ShowViewCaption = true;
            // 
            // ColDetailRolId
            // 
            this.ColDetailRolId.Caption = "ROL ID";
            this.ColDetailRolId.FieldName = "RolId";
            this.ColDetailRolId.Name = "ColDetailRolId";
            this.ColDetailRolId.OptionsColumn.AllowEdit = false;
            // 
            // ColDetailKulId
            // 
            this.ColDetailKulId.Caption = "KULLANICI ID";
            this.ColDetailKulId.FieldName = "KulId";
            this.ColDetailKulId.Name = "ColDetailKulId";
            this.ColDetailKulId.OptionsColumn.AllowEdit = false;
            this.ColDetailKulId.Visible = true;
            this.ColDetailKulId.VisibleIndex = 1;
            // 
            // ColDetailRolAd
            // 
            this.ColDetailRolAd.Caption = "ROL ADI";
            this.ColDetailRolAd.FieldName = "Isim";
            this.ColDetailRolAd.Name = "ColDetailRolAd";
            this.ColDetailRolAd.OptionsColumn.AllowEdit = false;
            this.ColDetailRolAd.Visible = true;
            this.ColDetailRolAd.VisibleIndex = 0;
            // 
            // ColDetailRolKod
            // 
            this.ColDetailRolKod.Caption = "ROL KODU";
            this.ColDetailRolKod.FieldName = "Kod";
            this.ColDetailRolKod.Name = "ColDetailRolKod";
            this.ColDetailRolKod.OptionsColumn.AllowEdit = false;
            // 
            // gridControl1
            // 
            gridLevelNode1.LevelTemplate = this.gridViewAyarlarDetail;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(1, 24);
            this.gridControl1.MainView = this.gridViewAyarlar;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(889, 296);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAyarlar,
            this.gridViewAyarlarDetail});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridViewAyarlar
            // 
            this.gridViewAyarlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Kod,
            this.Isim,
            this.Sifre,
            this.Depo,
            this.kayitTarih,
            this.GuncellemeTarih,
            this.DepoID});
            this.gridViewAyarlar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewAyarlar.GridControl = this.gridControl1;
            this.gridViewAyarlar.Name = "gridViewAyarlar";
            this.gridViewAyarlar.OptionsDetail.ShowDetailTabs = false;
            this.gridViewAyarlar.OptionsView.ShowFooter = true;
            this.gridViewAyarlar.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Kod, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewAyarlar.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridViewAyarlar_MasterRowEmpty);
            this.gridViewAyarlar.MasterRowExpanding += new DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventHandler(this.gridViewAyarlar_MasterRowExpanding);
            this.gridViewAyarlar.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridViewAyarlar_MasterRowExpanded);
            this.gridViewAyarlar.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridViewAyarlar_MasterRowGetChildList);
            this.gridViewAyarlar.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridViewAyarlar_MasterRowGetRelationName);
            this.gridViewAyarlar.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridViewAyarlar_MasterRowGetRelationCount);
            this.gridViewAyarlar.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewAyarlar_PopupMenuShowing);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "Id";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.ReadOnly = true;
            // 
            // Kod
            // 
            this.Kod.Caption = "KOD";
            this.Kod.FieldName = "Kod";
            this.Kod.Name = "Kod";
            this.Kod.OptionsColumn.AllowEdit = false;
            this.Kod.OptionsColumn.ReadOnly = true;
            this.Kod.Visible = true;
            this.Kod.VisibleIndex = 0;
            this.Kod.Width = 106;
            // 
            // Isim
            // 
            this.Isim.Caption = "İSİM";
            this.Isim.FieldName = "Isim";
            this.Isim.Name = "Isim";
            this.Isim.OptionsColumn.AllowEdit = false;
            this.Isim.OptionsColumn.ReadOnly = true;
            this.Isim.Visible = true;
            this.Isim.VisibleIndex = 1;
            this.Isim.Width = 106;
            // 
            // Sifre
            // 
            this.Sifre.Caption = "ŞİFRE";
            this.Sifre.FieldName = "Sifre";
            this.Sifre.Name = "Sifre";
            this.Sifre.OptionsColumn.AllowEdit = false;
            this.Sifre.OptionsColumn.ReadOnly = true;
            this.Sifre.Width = 106;
            // 
            // Depo
            // 
            this.Depo.Caption = "DEPO";
            this.Depo.FieldName = "Depo";
            this.Depo.Name = "Depo";
            this.Depo.OptionsColumn.AllowEdit = false;
            this.Depo.OptionsColumn.ReadOnly = true;
            this.Depo.Visible = true;
            this.Depo.VisibleIndex = 2;
            this.Depo.Width = 120;
            // 
            // kayitTarih
            // 
            this.kayitTarih.Caption = "KAYIT TARiHİ";
            this.kayitTarih.FieldName = "KayitTarihi";
            this.kayitTarih.Name = "kayitTarih";
            this.kayitTarih.OptionsColumn.AllowEdit = false;
            this.kayitTarih.OptionsColumn.ReadOnly = true;
            this.kayitTarih.Visible = true;
            this.kayitTarih.VisibleIndex = 3;
            this.kayitTarih.Width = 109;
            // 
            // GuncellemeTarih
            // 
            this.GuncellemeTarih.Caption = "GÜNCELLEME TARİHİ";
            this.GuncellemeTarih.FieldName = "GuncellemeTarihi";
            this.GuncellemeTarih.Name = "GuncellemeTarih";
            this.GuncellemeTarih.OptionsColumn.AllowEdit = false;
            this.GuncellemeTarih.OptionsColumn.ReadOnly = true;
            this.GuncellemeTarih.Visible = true;
            this.GuncellemeTarih.VisibleIndex = 4;
            this.GuncellemeTarih.Width = 114;
            // 
            // DepoID
            // 
            this.DepoID.Caption = "DEPO ID";
            this.DepoID.FieldName = "DepoId";
            this.DepoID.Name = "DepoID";
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnYeniKullanici.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniKullanici.Image")));
            this.btnYeniKullanici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniKullanici.Location = new System.Drawing.Point(669, 341);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(200, 88);
            this.btnYeniKullanici.TabIndex = 1;
            this.btnYeniKullanici.Text = "YENİ KULLANICI";
            this.btnYeniKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeniKullanici.UseVisualStyleBackColor = true;
            this.btnYeniKullanici.Click += new System.EventHandler(this.btnYeniKullanici_Click);
            // 
            // popupMenuKullanici
            // 
            this.popupMenuKullanici.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGuncelle)});
            this.popupMenuKullanici.Manager = this.barManager1;
            this.popupMenuKullanici.Name = "popupMenuKullanici";
            // 
            // barBtnGuncelle
            // 
            this.barBtnGuncelle.Caption = "DÜZENLE";
            this.barBtnGuncelle.Id = 0;
            this.barBtnGuncelle.Name = "barBtnGuncelle";
            this.barBtnGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGuncelle_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnGuncelle});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(891, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(891, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(891, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 450);
            // 
            // FormKullaniciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.btnYeniKullanici);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKullaniciListele";
            this.Text = "FormKullaniciKaydet";
            this.Shown += new System.EventHandler(this.FormKullaniciKaydet_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKullaniciListele_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAyarlarDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAyarlar;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Kod;
        private DevExpress.XtraGrid.Columns.GridColumn Isim;
        private DevExpress.XtraGrid.Columns.GridColumn Sifre;
        private DevExpress.XtraGrid.Columns.GridColumn Depo;
        private DevExpress.XtraGrid.Columns.GridColumn kayitTarih;
        private DevExpress.XtraGrid.Columns.GridColumn GuncellemeTarih;
        private DevExpress.XtraGrid.Columns.GridColumn DepoID;
        private System.Windows.Forms.Button btnYeniKullanici;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAyarlarDetail;
        private DevExpress.XtraGrid.Columns.GridColumn ColDetailRolAd;
        private DevExpress.XtraGrid.Columns.GridColumn ColDetailRolKod;
        private DevExpress.XtraGrid.Columns.GridColumn ColDetailRolId;
        private DevExpress.XtraGrid.Columns.GridColumn ColDetailKulId;
        private DevExpress.XtraBars.PopupMenu popupMenuKullanici;
        private DevExpress.XtraBars.BarButtonItem barBtnGuncelle;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}