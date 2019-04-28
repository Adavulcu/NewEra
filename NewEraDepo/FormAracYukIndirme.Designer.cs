namespace NewEraDepo
{
    partial class FormAracYukIndirme
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teDepoIciArac = new DevExpress.XtraEditors.TextEdit();
            this.lblDepoIciArac = new DevExpress.XtraEditors.LabelControl();
            this.grdIsEmriListeKullanici = new DevExpress.XtraGrid.GridControl();
            this.grdVIsEmriListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmirId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapiId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapiIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoIciAracId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoIciAracIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalKabulAracId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalKabulAracPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalKabulAracFirma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblIsEmri = new DevExpress.XtraEditors.LabelControl();
            this.lblAdres = new DevExpress.XtraEditors.LabelControl();
            this.teAdres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.colIsEmriDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblIseBaslamaZamani = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teDepoIciArac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIsEmriListeKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVIsEmriListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAdres.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 253);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(143, 25);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Yük Taşıma Aracı";
            // 
            // teDepoIciArac
            // 
            this.teDepoIciArac.Location = new System.Drawing.Point(200, 253);
            this.teDepoIciArac.Name = "teDepoIciArac";
            this.teDepoIciArac.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teDepoIciArac.Properties.Appearance.Options.UseFont = true;
            this.teDepoIciArac.Size = new System.Drawing.Size(149, 28);
            this.teDepoIciArac.TabIndex = 4;
            this.teDepoIciArac.Tag = "9998";
            this.teDepoIciArac.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teDepoIciArac_EditValueChanging);
            this.teDepoIciArac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TEDepoIciArac_KeyPress);
            // 
            // lblDepoIciArac
            // 
            this.lblDepoIciArac.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepoIciArac.Appearance.Options.UseFont = true;
            this.lblDepoIciArac.Location = new System.Drawing.Point(364, 253);
            this.lblDepoIciArac.Name = "lblDepoIciArac";
            this.lblDepoIciArac.Size = new System.Drawing.Size(143, 25);
            this.lblDepoIciArac.TabIndex = 5;
            this.lblDepoIciArac.Tag = "9999";
            this.lblDepoIciArac.Text = "Yük Taşıma Aracı";
            // 
            // grdIsEmriListeKullanici
            // 
            this.grdIsEmriListeKullanici.DataMember = "Query";
            this.grdIsEmriListeKullanici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdIsEmriListeKullanici.Location = new System.Drawing.Point(12, 12);
            this.grdIsEmriListeKullanici.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.grdIsEmriListeKullanici.MainView = this.grdVIsEmriListe;
            this.grdIsEmriListeKullanici.Name = "grdIsEmriListeKullanici";
            this.grdIsEmriListeKullanici.Size = new System.Drawing.Size(960, 185);
            this.grdIsEmriListeKullanici.TabIndex = 6;
            this.grdIsEmriListeKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVIsEmriListe});
            // 
            // grdVIsEmriListe
            // 
            this.grdVIsEmriListe.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.grdVIsEmriListe.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdVIsEmriListe.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grdVIsEmriListe.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdVIsEmriListe.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdVIsEmriListe.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdVIsEmriListe.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdVIsEmriListe.Appearance.Row.Options.UseFont = true;
            this.grdVIsEmriListe.Appearance.SelectedRow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.grdVIsEmriListe.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdVIsEmriListe.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grdVIsEmriListe.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdVIsEmriListe.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.grdVIsEmriListe.ColumnPanelRowHeight = 30;
            this.grdVIsEmriListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colEmirId,
            this.colPersonelId,
            this.colPersonelIsim,
            this.colAdresId,
            this.colAdresIsim,
            this.colAdresKod,
            this.colKapiId,
            this.colKapiIsim,
            this.colDepoIciAracId,
            this.colDepoIciAracIsim,
            this.colMalKabulAracId,
            this.colMalKabulAracPlaka,
            this.colMalKabulAracFirma,
            this.colIsEmriDurum});
            this.grdVIsEmriListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdVIsEmriListe.GridControl = this.grdIsEmriListeKullanici;
            this.grdVIsEmriListe.Name = "grdVIsEmriListe";
            this.grdVIsEmriListe.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdVIsEmriListe.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdVIsEmriListe.OptionsBehavior.Editable = false;
            this.grdVIsEmriListe.OptionsBehavior.ReadOnly = true;
            this.grdVIsEmriListe.OptionsCustomization.AllowGroup = false;
            this.grdVIsEmriListe.OptionsMenu.EnableColumnMenu = false;
            this.grdVIsEmriListe.OptionsSelection.InvertSelection = true;
            this.grdVIsEmriListe.OptionsView.ShowGroupPanel = false;
            this.grdVIsEmriListe.RowHeight = 40;
            this.grdVIsEmriListe.ViewCaptionHeight = 30;
            this.grdVIsEmriListe.DoubleClick += new System.EventHandler(this.grdVIsEmriListe_DoubleClick);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colEmirId
            // 
            this.colEmirId.FieldName = "EmirId";
            this.colEmirId.Name = "colEmirId";
            // 
            // colPersonelId
            // 
            this.colPersonelId.FieldName = "PersonelId";
            this.colPersonelId.Name = "colPersonelId";
            // 
            // colPersonelIsim
            // 
            this.colPersonelIsim.FieldName = "PersonelIsim";
            this.colPersonelIsim.Name = "colPersonelIsim";
            // 
            // colAdresId
            // 
            this.colAdresId.FieldName = "AdresId";
            this.colAdresId.Name = "colAdresId";
            // 
            // colAdresIsim
            // 
            this.colAdresIsim.FieldName = "AdresIsim";
            this.colAdresIsim.Name = "colAdresIsim";
            this.colAdresIsim.Visible = true;
            this.colAdresIsim.VisibleIndex = 2;
            // 
            // colAdresKod
            // 
            this.colAdresKod.FieldName = "AdresKod";
            this.colAdresKod.Name = "colAdresKod";
            this.colAdresKod.Visible = true;
            this.colAdresKod.VisibleIndex = 1;
            // 
            // colKapiId
            // 
            this.colKapiId.FieldName = "KapiId";
            this.colKapiId.Name = "colKapiId";
            // 
            // colKapiIsim
            // 
            this.colKapiIsim.FieldName = "KapiIsim";
            this.colKapiIsim.Name = "colKapiIsim";
            this.colKapiIsim.Visible = true;
            this.colKapiIsim.VisibleIndex = 0;
            // 
            // colDepoIciAracId
            // 
            this.colDepoIciAracId.FieldName = "DepoIciAracId";
            this.colDepoIciAracId.Name = "colDepoIciAracId";
            // 
            // colDepoIciAracIsim
            // 
            this.colDepoIciAracIsim.FieldName = "DepoIciAracIsim";
            this.colDepoIciAracIsim.Name = "colDepoIciAracIsim";
            this.colDepoIciAracIsim.Visible = true;
            this.colDepoIciAracIsim.VisibleIndex = 3;
            // 
            // colMalKabulAracId
            // 
            this.colMalKabulAracId.FieldName = "MalKabulAracId";
            this.colMalKabulAracId.Name = "colMalKabulAracId";
            // 
            // colMalKabulAracPlaka
            // 
            this.colMalKabulAracPlaka.FieldName = "MalKabulAracPlaka";
            this.colMalKabulAracPlaka.Name = "colMalKabulAracPlaka";
            this.colMalKabulAracPlaka.Visible = true;
            this.colMalKabulAracPlaka.VisibleIndex = 4;
            // 
            // colMalKabulAracFirma
            // 
            this.colMalKabulAracFirma.FieldName = "MalKabulAracFirma";
            this.colMalKabulAracFirma.Name = "colMalKabulAracFirma";
            // 
            // lblIsEmri
            // 
            this.lblIsEmri.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsEmri.Appearance.Options.UseFont = true;
            this.lblIsEmri.Location = new System.Drawing.Point(12, 215);
            this.lblIsEmri.Name = "lblIsEmri";
            this.lblIsEmri.Size = new System.Drawing.Size(143, 25);
            this.lblIsEmri.TabIndex = 7;
            this.lblIsEmri.Text = "Yük Taşıma Aracı";
            // 
            // lblAdres
            // 
            this.lblAdres.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Appearance.Options.UseFont = true;
            this.lblAdres.Location = new System.Drawing.Point(364, 293);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(143, 25);
            this.lblAdres.TabIndex = 10;
            this.lblAdres.Tag = "9999";
            this.lblAdres.Text = "Yük Taşıma Aracı";
            // 
            // teAdres
            // 
            this.teAdres.Location = new System.Drawing.Point(200, 293);
            this.teAdres.Name = "teAdres";
            this.teAdres.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teAdres.Properties.Appearance.Options.UseFont = true;
            this.teAdres.Size = new System.Drawing.Size(149, 28);
            this.teAdres.TabIndex = 9;
            this.teAdres.Tag = "9998";
            this.teAdres.EditValueChanged += new System.EventHandler(this.teAdres_EditValueChanged);
            this.teAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TEAdres_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 293);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 25);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Adres";
            // 
            // colIsEmriDurum
            // 
            this.colIsEmriDurum.FieldName = "IsEmriDurum";
            this.colIsEmriDurum.Name = "colIsEmriDurum";
            this.colIsEmriDurum.Visible = true;
            this.colIsEmriDurum.VisibleIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 356);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(166, 25);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "İşe Başlama Zamanı";
            // 
            // lblIseBaslamaZamani
            // 
            this.lblIseBaslamaZamani.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIseBaslamaZamani.Appearance.Options.UseFont = true;
            this.lblIseBaslamaZamani.Location = new System.Drawing.Point(200, 356);
            this.lblIseBaslamaZamani.Name = "lblIseBaslamaZamani";
            this.lblIseBaslamaZamani.Size = new System.Drawing.Size(166, 25);
            this.lblIseBaslamaZamani.TabIndex = 12;
            this.lblIseBaslamaZamani.Text = "İşe Başlama Zamanı";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(200, 398);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(166, 25);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "İşe Başlama Zamanı";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 398);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 25);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Durum";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAracYukIndirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblIseBaslamaZamani);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.teAdres);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblIsEmri);
            this.Controls.Add(this.grdIsEmriListeKullanici);
            this.Controls.Add(this.lblDepoIciArac);
            this.Controls.Add(this.teDepoIciArac);
            this.Controls.Add(this.labelControl2);
            this.Name = "FormAracYukIndirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAracYukIndirme";
            this.Shown += new System.EventHandler(this.FormAracYukIndirme_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.teDepoIciArac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIsEmriListeKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVIsEmriListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAdres.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teDepoIciArac;
        private DevExpress.XtraEditors.LabelControl lblDepoIciArac;
        private DevExpress.XtraGrid.GridControl grdIsEmriListeKullanici;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVIsEmriListe;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmirId;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelId;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresId;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresKod;
        private DevExpress.XtraGrid.Columns.GridColumn colKapiId;
        private DevExpress.XtraGrid.Columns.GridColumn colKapiIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoIciAracId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoIciAracIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colMalKabulAracId;
        private DevExpress.XtraGrid.Columns.GridColumn colMalKabulAracPlaka;
        private DevExpress.XtraGrid.Columns.GridColumn colMalKabulAracFirma;
        private DevExpress.XtraEditors.LabelControl lblIsEmri;
        private DevExpress.XtraEditors.LabelControl lblAdres;
        private DevExpress.XtraEditors.TextEdit teAdres;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEmriDurum;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblIseBaslamaZamani;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Button button1;
    }
}