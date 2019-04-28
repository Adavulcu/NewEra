namespace NewEraDepo
{
    partial class FormKullaniciEkle
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
            this.cbDepoKayit = new System.Windows.Forms.ComboBox();
            this.gridControlKullaniciEkle = new DevExpress.XtraGrid.GridControl();
            this.gridViewKullaniciEkle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IsChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkBoxGuncelleme = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rolKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rolAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxIsim = new System.Windows.Forms.TextBox();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKullaniciEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKullaniciEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxGuncelleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDepoKayit);
            this.groupBox1.Controls.Add(this.gridControlKullaniciEkle);
            this.groupBox1.Controls.Add(this.textBoxSifre);
            this.groupBox1.Controls.Add(this.textBoxIsim);
            this.groupBox1.Controls.Add(this.textBoxKod);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(124, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 492);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cbDepoKayit
            // 
            this.cbDepoKayit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepoKayit.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbDepoKayit.FormattingEnabled = true;
            this.cbDepoKayit.Location = new System.Drawing.Point(242, 136);
            this.cbDepoKayit.Name = "cbDepoKayit";
            this.cbDepoKayit.Size = new System.Drawing.Size(288, 33);
            this.cbDepoKayit.TabIndex = 4;
            // 
            // gridControlKullaniciEkle
            // 
            this.gridControlKullaniciEkle.Location = new System.Drawing.Point(11, 202);
            this.gridControlKullaniciEkle.MainView = this.gridViewKullaniciEkle;
            this.gridControlKullaniciEkle.Name = "gridControlKullaniciEkle";
            this.gridControlKullaniciEkle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkBoxGuncelleme,
            this.repositoryItemFontEdit1,
            this.repositoryItemHypertextLabel1});
            this.gridControlKullaniciEkle.Size = new System.Drawing.Size(533, 200);
            this.gridControlKullaniciEkle.TabIndex = 13;
            this.gridControlKullaniciEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKullaniciEkle});
            // 
            // gridViewKullaniciEkle
            // 
            this.gridViewKullaniciEkle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IsChecked,
            this.ID,
            this.rolKod,
            this.rolAd});
            this.gridViewKullaniciEkle.GridControl = this.gridControlKullaniciEkle;
            this.gridViewKullaniciEkle.Name = "gridViewKullaniciEkle";
            this.gridViewKullaniciEkle.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridViewKullaniciEkle.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewKullaniciEkle.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewKullaniciEkle.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewKullaniciEkle.OptionsView.ShowFooter = true;
            // 
            // IsChecked
            // 
            this.IsChecked.Caption = " ";
            this.IsChecked.ColumnEdit = this.checkBoxGuncelleme;
            this.IsChecked.CustomizationCaption = "OK";
            this.IsChecked.FieldName = "IsChecked";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.IsChecked.Visible = true;
            this.IsChecked.VisibleIndex = 0;
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
            // rolKod
            // 
            this.rolKod.Caption = "ROL KODU";
            this.rolKod.FieldName = "Kod";
            this.rolKod.Name = "rolKod";
            this.rolKod.OptionsColumn.AllowEdit = false;
            this.rolKod.OptionsColumn.ReadOnly = true;
            this.rolKod.Visible = true;
            this.rolKod.VisibleIndex = 1;
            this.rolKod.Width = 220;
            // 
            // rolAd
            // 
            this.rolAd.Caption = "ROL ADI";
            this.rolAd.FieldName = "Isim";
            this.rolAd.Name = "rolAd";
            this.rolAd.OptionsColumn.AllowEdit = false;
            this.rolAd.OptionsColumn.ReadOnly = true;
            this.rolAd.Visible = true;
            this.rolAd.VisibleIndex = 2;
            this.rolAd.Width = 226;
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
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.textBoxSifre.Location = new System.Drawing.Point(242, 93);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(272, 33);
            this.textBoxSifre.TabIndex = 3;
            // 
            // textBoxIsim
            // 
            this.textBoxIsim.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.textBoxIsim.Location = new System.Drawing.Point(242, 53);
            this.textBoxIsim.Name = "textBoxIsim";
            this.textBoxIsim.Size = new System.Drawing.Size(272, 33);
            this.textBoxIsim.TabIndex = 2;
            // 
            // textBoxKod
            // 
            this.textBoxKod.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.textBoxKod.Location = new System.Drawing.Point(242, 13);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(272, 33);
            this.textBoxKod.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnEkle.Location = new System.Drawing.Point(252, 441);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(123, 45);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "KOD ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "İSİM ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "DEPO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ŞİFRE  ";
            // 
            // FormKullaniciEkle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKullaniciEkle";
            this.Text = "FormKullaniciEkle";
            this.Shown += new System.EventHandler(this.FormKullaniciEkle_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKullaniciEkle_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKullaniciEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKullaniciEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxGuncelleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlKullaniciEkle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKullaniciEkle;
        private DevExpress.XtraGrid.Columns.GridColumn IsChecked;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkBoxGuncelleme;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn rolKod;
        private DevExpress.XtraGrid.Columns.GridColumn rolAd;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxIsim;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDepoKayit;
    }
}