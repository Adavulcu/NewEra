namespace NewEraDepo
{
    partial class FormAracYukIndirmeEmriOlusturma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAracYukIndirmeEmriOlusturma));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridArac = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFirma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblAlan = new DevExpress.XtraEditors.LabelControl();
            this.gridKapi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridKapiId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridKapiKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridKapiIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridKapiAlanAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridKullanici = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gridForklift = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEmirOlustur = new System.Windows.Forms.Button();
            this.lblSecilenArac = new DevExpress.XtraEditors.LabelControl();
            this.lblPersonel = new DevExpress.XtraEditors.LabelControl();
            this.lblYIArac = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridArac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKapi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridForklift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bekleyen Araçlar";
            // 
            // gridArac
            // 
            this.gridArac.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridArac.Location = new System.Drawing.Point(12, 43);
            this.gridArac.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridArac.MainView = this.gridView1;
            this.gridArac.Name = "gridArac";
            this.gridArac.Size = new System.Drawing.Size(261, 270);
            this.gridArac.TabIndex = 1;
            this.gridArac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.ColumnPanelRowHeight = 40;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnPlaka,
            this.gridColumnFirma});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridArac;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.InvertSelection = true;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gridView1.RowHeight = 50;
            this.gridView1.DoubleClick += new System.EventHandler(this.GridView1_DoubleClick);
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "gridColumn1";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            // 
            // gridColumnPlaka
            // 
            this.gridColumnPlaka.Caption = "Plaka";
            this.gridColumnPlaka.FieldName = "Plaka";
            this.gridColumnPlaka.Name = "gridColumnPlaka";
            this.gridColumnPlaka.Visible = true;
            this.gridColumnPlaka.VisibleIndex = 0;
            // 
            // gridColumnFirma
            // 
            this.gridColumnFirma.Caption = "Firma";
            this.gridColumnFirma.FieldName = "Firma";
            this.gridColumnFirma.Name = "gridColumnFirma";
            this.gridColumnFirma.Visible = true;
            this.gridColumnFirma.VisibleIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 340);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(205, 25);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Araç Yük İndirme İş Emri";
            // 
            // lblAlan
            // 
            this.lblAlan.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlan.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblAlan.Appearance.Options.UseFont = true;
            this.lblAlan.Appearance.Options.UseForeColor = true;
            this.lblAlan.Location = new System.Drawing.Point(279, 383);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(129, 32);
            this.lblAlan.TabIndex = 3;
            this.lblAlan.Text = "Seçilen Araç";
            // 
            // gridKapi
            // 
            this.gridKapi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridKapi.Location = new System.Drawing.Point(279, 43);
            this.gridKapi.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridKapi.MainView = this.gridView2;
            this.gridKapi.Name = "gridKapi";
            this.gridKapi.Size = new System.Drawing.Size(261, 270);
            this.gridKapi.TabIndex = 4;
            this.gridKapi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.ActiveFilterEnabled = false;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.ColumnPanelRowHeight = 40;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridKapiId,
            this.gridKapiKod,
            this.gridKapiIsim,
            this.gridKapiAlanAdres});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView2.GridControl = this.gridKapi;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsSelection.InvertSelection = true;
            this.gridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowHeight = 50;
            this.gridView2.DoubleClick += new System.EventHandler(this.GridView2_DoubleClick);
            // 
            // gridKapiId
            // 
            this.gridKapiId.Caption = "gridColumn1";
            this.gridKapiId.FieldName = "Id";
            this.gridKapiId.Name = "gridKapiId";
            // 
            // gridKapiKod
            // 
            this.gridKapiKod.Caption = "Kod";
            this.gridKapiKod.FieldName = "Kod";
            this.gridKapiKod.Name = "gridKapiKod";
            this.gridKapiKod.Visible = true;
            this.gridKapiKod.VisibleIndex = 0;
            // 
            // gridKapiIsim
            // 
            this.gridKapiIsim.Caption = "İsim";
            this.gridKapiIsim.FieldName = "Isim";
            this.gridKapiIsim.Name = "gridKapiIsim";
            this.gridKapiIsim.Visible = true;
            this.gridKapiIsim.VisibleIndex = 1;
            // 
            // gridKapiAlanAdres
            // 
            this.gridKapiAlanAdres.Caption = "gridColumn7";
            this.gridKapiAlanAdres.FieldName = "ULId";
            this.gridKapiAlanAdres.Name = "gridKapiAlanAdres";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(279, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(149, 25);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Yük İndirme Alanı";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(546, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 25);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Personel";
            // 
            // gridKullanici
            // 
            this.gridKullanici.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridKullanici.Location = new System.Drawing.Point(546, 43);
            this.gridKullanici.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridKullanici.MainView = this.gridView3;
            this.gridKullanici.Name = "gridKullanici";
            this.gridKullanici.Size = new System.Drawing.Size(261, 270);
            this.gridKullanici.TabIndex = 6;
            this.gridKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.ActiveFilterEnabled = false;
            this.gridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3.ColumnPanelRowHeight = 40;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView3.GridControl = this.gridKullanici;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsBehavior.ReadOnly = true;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsSelection.InvertSelection = true;
            this.gridView3.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.RowHeight = 50;
            this.gridView3.DoubleClick += new System.EventHandler(this.GridView3_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Kod";
            this.gridColumn2.FieldName = "Kod";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "İsim";
            this.gridColumn3.FieldName = "Isim";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(813, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(143, 25);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Yük Taşıma Aracı";
            // 
            // gridForklift
            // 
            this.gridForklift.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridForklift.Location = new System.Drawing.Point(813, 43);
            this.gridForklift.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridForklift.MainView = this.gridView4;
            this.gridForklift.Name = "gridForklift";
            this.gridForklift.Size = new System.Drawing.Size(261, 270);
            this.gridForklift.TabIndex = 8;
            this.gridForklift.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.ActiveFilterEnabled = false;
            this.gridView4.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView4.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView4.ColumnPanelRowHeight = 40;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView4.GridControl = this.gridForklift;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsBehavior.ReadOnly = true;
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsSelection.InvertSelection = true;
            this.gridView4.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.RowHeight = 50;
            this.gridView4.DoubleClick += new System.EventHandler(this.GridView4_DoubleClick);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Id";
            this.gridColumn4.FieldName = "Id";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Kod";
            this.gridColumn5.FieldName = "Kod";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "İsim";
            this.gridColumn6.FieldName = "Isim";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Marka";
            this.gridColumn7.FieldName = "Marka";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Model";
            this.gridColumn8.FieldName = "Model";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Seviye";
            this.gridColumn9.FieldName = "Seviye";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // btnEmirOlustur
            // 
            this.btnEmirOlustur.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmirOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnEmirOlustur.Image")));
            this.btnEmirOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmirOlustur.Location = new System.Drawing.Point(12, 424);
            this.btnEmirOlustur.Name = "btnEmirOlustur";
            this.btnEmirOlustur.Size = new System.Drawing.Size(180, 47);
            this.btnEmirOlustur.TabIndex = 10;
            this.btnEmirOlustur.Text = "İş Emri Oluştur";
            this.btnEmirOlustur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmirOlustur.UseVisualStyleBackColor = true;
            this.btnEmirOlustur.Click += new System.EventHandler(this.BtnEmirOlustur_Click);
            // 
            // lblSecilenArac
            // 
            this.lblSecilenArac.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenArac.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSecilenArac.Appearance.Options.UseFont = true;
            this.lblSecilenArac.Appearance.Options.UseForeColor = true;
            this.lblSecilenArac.Location = new System.Drawing.Point(12, 383);
            this.lblSecilenArac.Name = "lblSecilenArac";
            this.lblSecilenArac.Size = new System.Drawing.Size(129, 32);
            this.lblSecilenArac.TabIndex = 11;
            this.lblSecilenArac.Text = "Seçilen Araç";
            // 
            // lblPersonel
            // 
            this.lblPersonel.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblPersonel.Appearance.Options.UseFont = true;
            this.lblPersonel.Appearance.Options.UseForeColor = true;
            this.lblPersonel.Location = new System.Drawing.Point(546, 383);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(129, 32);
            this.lblPersonel.TabIndex = 12;
            this.lblPersonel.Text = "Seçilen Araç";
            // 
            // lblYIArac
            // 
            this.lblYIArac.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYIArac.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblYIArac.Appearance.Options.UseFont = true;
            this.lblYIArac.Appearance.Options.UseForeColor = true;
            this.lblYIArac.Location = new System.Drawing.Point(813, 383);
            this.lblYIArac.Name = "lblYIArac";
            this.lblYIArac.Size = new System.Drawing.Size(129, 32);
            this.lblYIArac.TabIndex = 13;
            this.lblYIArac.Text = "Seçilen Araç";
            // 
            // FormAracYukIndirmeEmriOlusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 606);
            this.Controls.Add(this.lblYIArac);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.lblSecilenArac);
            this.Controls.Add(this.btnEmirOlustur);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.gridForklift);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gridKullanici);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridKapi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridArac);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FormAracYukIndirmeEmriOlusturma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAracYukIndirmeEmriOlusturma";
            this.Shown += new System.EventHandler(this.FormAracYukIndirmeEmriOlusturma_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridArac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKapi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridForklift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPlaka;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirma;
        private DevExpress.XtraGrid.GridControl gridArac;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblAlan;
        private DevExpress.XtraGrid.GridControl gridKapi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridKapiId;
        private DevExpress.XtraGrid.Columns.GridColumn gridKapiKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridKapiIsim;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridKullanici;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gridForklift;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Button btnEmirOlustur;
        private DevExpress.XtraEditors.LabelControl lblSecilenArac;
        private DevExpress.XtraEditors.LabelControl lblPersonel;
        private DevExpress.XtraEditors.LabelControl lblYIArac;
        private DevExpress.XtraGrid.Columns.GridColumn gridKapiAlanAdres;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}