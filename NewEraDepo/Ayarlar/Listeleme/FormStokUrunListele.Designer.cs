namespace NewEraDepo
{
    partial class FormStokUrunListele
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
            this.gridControlStok = new DevExpress.XtraGrid.GridControl();
            this.gridViewStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColAdresId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColStokId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColUrunKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDepoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEkle = new System.Windows.Forms.Button();
            this.popupMenuStok = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barBtnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSil = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerStok = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerStok)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlStok, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEkle, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControlStok
            // 
            this.gridControlStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStok.Location = new System.Drawing.Point(3, 3);
            this.gridControlStok.MainView = this.gridViewStok;
            this.gridControlStok.Name = "gridControlStok";
            this.gridControlStok.Size = new System.Drawing.Size(794, 376);
            this.gridControlStok.TabIndex = 0;
            this.gridControlStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStok});
            this.gridControlStok.DoubleClick += new System.EventHandler(this.gridControlStok_DoubleClick);
            // 
            // gridViewStok
            // 
            this.gridViewStok.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColAdresId,
            this.gridColStokId,
            this.gridColAdres,
            this.gridColUrunKod,
            this.gridColIsim,
            this.gridColDepoId,
            this.gridColId});
            this.gridViewStok.GridControl = this.gridControlStok;
            this.gridViewStok.Name = "gridViewStok";
            this.gridViewStok.OptionsView.ShowGroupPanel = false;
            this.gridViewStok.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewStok_PopupMenuShowing);
            // 
            // gridColAdresId
            // 
            this.gridColAdresId.Caption = "Adres ID";
            this.gridColAdresId.FieldName = "AdresId";
            this.gridColAdresId.Name = "gridColAdresId";
            // 
            // gridColStokId
            // 
            this.gridColStokId.Caption = "STOK ID";
            this.gridColStokId.FieldName = "StokId";
            this.gridColStokId.Name = "gridColStokId";
            // 
            // gridColAdres
            // 
            this.gridColAdres.Caption = "ADRES";
            this.gridColAdres.FieldName = "Adres";
            this.gridColAdres.Name = "gridColAdres";
            this.gridColAdres.OptionsColumn.AllowEdit = false;
            this.gridColAdres.Visible = true;
            this.gridColAdres.VisibleIndex = 0;
            // 
            // gridColUrunKod
            // 
            this.gridColUrunKod.Caption = "ÜRÜN KODU";
            this.gridColUrunKod.FieldName = "UrunKod";
            this.gridColUrunKod.Name = "gridColUrunKod";
            this.gridColUrunKod.OptionsColumn.AllowEdit = false;
            this.gridColUrunKod.Visible = true;
            this.gridColUrunKod.VisibleIndex = 1;
            // 
            // gridColIsim
            // 
            this.gridColIsim.Caption = "ÜRÜN İSMİ";
            this.gridColIsim.FieldName = "UrunIsim";
            this.gridColIsim.Name = "gridColIsim";
            this.gridColIsim.OptionsColumn.AllowEdit = false;
            this.gridColIsim.Visible = true;
            this.gridColIsim.VisibleIndex = 2;
            // 
            // gridColDepoId
            // 
            this.gridColDepoId.Caption = "DEPO ID";
            this.gridColDepoId.FieldName = "DepoId";
            this.gridColDepoId.Name = "gridColDepoId";
            // 
            // btnEkle
            // 
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(250, 385);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(250, 3, 250, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(300, 62);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "YENİ ÜRÜN YERLEŞTİR";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // popupMenuStok
            // 
            this.popupMenuStok.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGuncelle),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSil)});
            this.popupMenuStok.Manager = this.barManagerStok;
            this.popupMenuStok.Name = "popupMenuStok";
            // 
            // barBtnGuncelle
            // 
            this.barBtnGuncelle.Caption = "STOK DÜZENLE";
            this.barBtnGuncelle.Id = 0;
            this.barBtnGuncelle.Name = "barBtnGuncelle";
            this.barBtnGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnClick);
            // 
            // barBtnSil
            // 
            this.barBtnSil.Caption = "STOK SİL";
            this.barBtnSil.Id = 1;
            this.barBtnSil.Name = "barBtnSil";
            this.barBtnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnClick);
            // 
            // barManagerStok
            // 
            this.barManagerStok.DockControls.Add(this.barDockControlTop);
            this.barManagerStok.DockControls.Add(this.barDockControlBottom);
            this.barManagerStok.DockControls.Add(this.barDockControlLeft);
            this.barManagerStok.DockControls.Add(this.barDockControlRight);
            this.barManagerStok.Form = this;
            this.barManagerStok.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnGuncelle,
            this.barBtnSil});
            this.barManagerStok.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerStok;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManagerStok;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManagerStok;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManagerStok;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 450);
            // 
            // gridColId
            // 
            this.gridColId.Caption = "ID";
            this.gridColId.FieldName = "Id";
            this.gridColId.Name = "gridColId";
            // 
            // FormStokUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormStokUrunListele";
            this.Text = "FormStokUrunListele";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControlStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStok;
        private DevExpress.XtraGrid.Columns.GridColumn gridColAdresId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColStokId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColAdres;
        private DevExpress.XtraGrid.Columns.GridColumn gridColUrunKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColIsim;
        private System.Windows.Forms.Button btnEkle;
        private DevExpress.XtraBars.PopupMenu popupMenuStok;
        private DevExpress.XtraBars.BarButtonItem barBtnGuncelle;
        private DevExpress.XtraBars.BarButtonItem barBtnSil;
        private DevExpress.XtraBars.BarManager barManagerStok;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDepoId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColId;
    }
}