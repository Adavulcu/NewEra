namespace NewEraDepo.Ayarlar
{
    partial class FormModulRol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbRoller = new System.Windows.Forms.ComboBox();
            this.gridControlModul = new DevExpress.XtraGrid.GridControl();
            this.gridViewMoldul = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Giris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkBoxGuncelleme = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModulId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.modIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Silme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Ekleme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Guncelleme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlModul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMoldul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxGuncelleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.CbRoller);
            this.groupBox1.Controls.Add(this.gridControlModul);
            this.groupBox1.Controls.Add(this.btnGuncelleme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 400);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // CbRoller
            // 
            this.CbRoller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRoller.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CbRoller.FormattingEnabled = true;
            this.CbRoller.Location = new System.Drawing.Point(252, 38);
            this.CbRoller.Name = "CbRoller";
            this.CbRoller.Size = new System.Drawing.Size(288, 33);
            this.CbRoller.TabIndex = 15;
            this.CbRoller.Tag = "4";
            this.CbRoller.SelectedIndexChanged += new System.EventHandler(this.CbRoller_SelectedIndexChanged);
            // 
            // gridControlModul
            // 
            this.gridControlModul.Location = new System.Drawing.Point(17, 92);
            this.gridControlModul.MainView = this.gridViewMoldul;
            this.gridControlModul.Name = "gridControlModul";
            this.gridControlModul.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkBoxGuncelleme,
            this.repositoryItemFontEdit1,
            this.repositoryItemHypertextLabel1,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3});
            this.gridControlModul.Size = new System.Drawing.Size(777, 217);
            this.gridControlModul.TabIndex = 0;
            this.gridControlModul.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMoldul});
            // 
            // gridViewMoldul
            // 
            this.gridViewMoldul.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Giris,
            this.ID,
            this.ModulId,
            this.modIsim,
            this.Silme,
            this.Ekleme,
            this.Guncelleme});
            this.gridViewMoldul.GridControl = this.gridControlModul;
            this.gridViewMoldul.Name = "gridViewMoldul";
            this.gridViewMoldul.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMoldul.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMoldul.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridViewMoldul.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewMoldul.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewMoldul.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewMoldul.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMoldul.OptionsView.ShowGroupPanel = false;
            // 
            // Giris
            // 
            this.Giris.Caption = " GİRİŞ";
            this.Giris.ColumnEdit = this.checkBoxGuncelleme;
            this.Giris.CustomizationCaption = "OK";
            this.Giris.FieldName = "Giris";
            this.Giris.Name = "Giris";
            this.Giris.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Giris.Visible = true;
            this.Giris.VisibleIndex = 0;
            // 
            // checkBoxGuncelleme
            // 
            this.checkBoxGuncelleme.AutoHeight = false;
            this.checkBoxGuncelleme.Name = "checkBoxGuncelleme";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "Id";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Width = 171;
            // 
            // ModulId
            // 
            this.ModulId.Caption = "MODUL ID";
            this.ModulId.FieldName = "ModulId";
            this.ModulId.Name = "ModulId";
            this.ModulId.OptionsColumn.AllowEdit = false;
            this.ModulId.OptionsColumn.ReadOnly = true;
            this.ModulId.Visible = true;
            this.ModulId.VisibleIndex = 4;
            this.ModulId.Width = 220;
            // 
            // modIsim
            // 
            this.modIsim.Caption = "MODUL KODU";
            this.modIsim.FieldName = "Isim";
            this.modIsim.Name = "modIsim";
            this.modIsim.OptionsColumn.AllowEdit = false;
            this.modIsim.OptionsColumn.ReadOnly = true;
            this.modIsim.Visible = true;
            this.modIsim.VisibleIndex = 5;
            this.modIsim.Width = 226;
            // 
            // Silme
            // 
            this.Silme.Caption = "SİLME";
            this.Silme.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Silme.FieldName = "Silme";
            this.Silme.Name = "Silme";
            this.Silme.Visible = true;
            this.Silme.VisibleIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // Ekleme
            // 
            this.Ekleme.Caption = "EKLEME";
            this.Ekleme.ColumnEdit = this.repositoryItemCheckEdit2;
            this.Ekleme.FieldName = "Ekleme";
            this.Ekleme.Name = "Ekleme";
            this.Ekleme.Visible = true;
            this.Ekleme.VisibleIndex = 2;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // Guncelleme
            // 
            this.Guncelleme.Caption = "GÜNCELLEME";
            this.Guncelleme.ColumnEdit = this.repositoryItemCheckEdit3;
            this.Guncelleme.FieldName = "Guncelleme";
            this.Guncelleme.Name = "Guncelleme";
            this.Guncelleme.Visible = true;
            this.Guncelleme.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnGuncelleme.Location = new System.Drawing.Point(252, 441);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(123, 45);
            this.btnGuncelleme.TabIndex = 5;
            this.btnGuncelleme.Text = "GÜNCELLE";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(81, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "ROLLER";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(323, 332);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 49);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormModulRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormModulRol";
            this.Text = "FormModulRol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlModul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMoldul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxGuncelleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbRoller;
        private DevExpress.XtraGrid.GridControl gridControlModul;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMoldul;
        private DevExpress.XtraGrid.Columns.GridColumn Giris;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkBoxGuncelleme;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ModulId;
        private DevExpress.XtraGrid.Columns.GridColumn modIsim;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn Silme;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Ekleme;
        private DevExpress.XtraGrid.Columns.GridColumn Guncelleme;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private System.Windows.Forms.Button btnKaydet;
    }
}