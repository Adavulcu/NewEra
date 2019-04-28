namespace NewEraDepo.Ayarlar.Listeleme
{
    partial class FormDepoKapiListele
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
            this.gridControlDepoKapi = new DevExpress.XtraGrid.GridControl();
            this.gridViewDepoKapi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColKapiId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColKapiKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColKapiIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColKapiTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDepoXIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColKapiULId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.popupMenuKapi = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barBtnDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerKapi = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepoKapi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepoKapi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuKapi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerKapi)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlDepoKapi, 0, 0);
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
            // gridControlDepoKapi
            // 
            this.gridControlDepoKapi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDepoKapi.Location = new System.Drawing.Point(3, 3);
            this.gridControlDepoKapi.MainView = this.gridViewDepoKapi;
            this.gridControlDepoKapi.Name = "gridControlDepoKapi";
            this.gridControlDepoKapi.Size = new System.Drawing.Size(794, 376);
            this.gridControlDepoKapi.TabIndex = 0;
            this.gridControlDepoKapi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDepoKapi});
            // 
            // gridViewDepoKapi
            // 
            this.gridViewDepoKapi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColKapiId,
            this.gridColKapiKod,
            this.gridColKapiIsim,
            this.gridColKapiTip,
            this.gridColDepoXIsim,
            this.gridColKapiULId});
            this.gridViewDepoKapi.GridControl = this.gridControlDepoKapi;
            this.gridViewDepoKapi.Name = "gridViewDepoKapi";
            this.gridViewDepoKapi.OptionsView.ShowGroupPanel = false;
            this.gridViewDepoKapi.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewDepoKapi_PopupMenuShowing);
            this.gridViewDepoKapi.DoubleClick += new System.EventHandler(this.gridViewDepoKapi_DoubleClick);
            // 
            // gridColKapiId
            // 
            this.gridColKapiId.Caption = "KAPI ID";
            this.gridColKapiId.FieldName = "KapiId";
            this.gridColKapiId.Name = "gridColKapiId";
            this.gridColKapiId.OptionsColumn.AllowEdit = false;
            // 
            // gridColKapiKod
            // 
            this.gridColKapiKod.Caption = "KAPI KODU";
            this.gridColKapiKod.FieldName = "KapiKod";
            this.gridColKapiKod.Name = "gridColKapiKod";
            this.gridColKapiKod.OptionsColumn.AllowEdit = false;
            this.gridColKapiKod.Visible = true;
            this.gridColKapiKod.VisibleIndex = 0;
            // 
            // gridColKapiIsim
            // 
            this.gridColKapiIsim.Caption = "KAPI İSMİ";
            this.gridColKapiIsim.FieldName = "KapiIsim";
            this.gridColKapiIsim.Name = "gridColKapiIsim";
            this.gridColKapiIsim.OptionsColumn.AllowEdit = false;
            this.gridColKapiIsim.Visible = true;
            this.gridColKapiIsim.VisibleIndex = 1;
            // 
            // gridColKapiTip
            // 
            this.gridColKapiTip.Caption = "TİP";
            this.gridColKapiTip.FieldName = "Tip";
            this.gridColKapiTip.Name = "gridColKapiTip";
            this.gridColKapiTip.OptionsColumn.AllowEdit = false;
            this.gridColKapiTip.Visible = true;
            this.gridColKapiTip.VisibleIndex = 2;
            // 
            // gridColDepoXIsim
            // 
            this.gridColDepoXIsim.Caption = "DEPO X İSİM";
            this.gridColDepoXIsim.FieldName = "DepoXIsim";
            this.gridColDepoXIsim.Name = "gridColDepoXIsim";
            this.gridColDepoXIsim.OptionsColumn.AllowEdit = false;
            this.gridColDepoXIsim.Visible = true;
            this.gridColDepoXIsim.VisibleIndex = 3;
            // 
            // gridColKapiULId
            // 
            this.gridColKapiULId.Caption = "ULID";
            this.gridColKapiULId.FieldName = "ULId";
            this.gridColKapiULId.Name = "gridColKapiULId";
            this.gridColKapiULId.OptionsColumn.AllowEdit = false;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.Location = new System.Drawing.Point(250, 385);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(250, 3, 250, 3);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(300, 62);
            this.BtnEkle.TabIndex = 1;
            this.BtnEkle.Text = "YENİ KAPI EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // popupMenuKapi
            // 
            this.popupMenuKapi.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDuzenle)});
            this.popupMenuKapi.Manager = this.barManagerKapi;
            this.popupMenuKapi.Name = "popupMenuKapi";
            // 
            // barBtnDuzenle
            // 
            this.barBtnDuzenle.Caption = "DÜZENLE";
            this.barBtnDuzenle.Id = 0;
            this.barBtnDuzenle.Name = "barBtnDuzenle";
            this.barBtnDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnClick);
            // 
            // barManagerKapi
            // 
            this.barManagerKapi.DockControls.Add(this.barDockControlTop);
            this.barManagerKapi.DockControls.Add(this.barDockControlBottom);
            this.barManagerKapi.DockControls.Add(this.barDockControlLeft);
            this.barManagerKapi.DockControls.Add(this.barDockControlRight);
            this.barManagerKapi.Form = this;
            this.barManagerKapi.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnDuzenle});
            this.barManagerKapi.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerKapi;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManagerKapi;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManagerKapi;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManagerKapi;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 450);
            // 
            // FormDepoKapiListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDepoKapiListele";
            this.Text = "FormDepoKapiListele";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepoKapi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepoKapi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuKapi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerKapi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControlDepoKapi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDepoKapi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColKapiId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColKapiKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColKapiIsim;
        private DevExpress.XtraGrid.Columns.GridColumn gridColKapiTip;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDepoXIsim;
        private DevExpress.XtraGrid.Columns.GridColumn gridColKapiULId;
        private DevExpress.XtraBars.PopupMenu popupMenuKapi;
        private DevExpress.XtraBars.BarButtonItem barBtnDuzenle;
        private DevExpress.XtraBars.BarManager barManagerKapi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Button BtnEkle;
    }
}