namespace NewEraDepo.Ayarlar.Ekleme
{
    partial class FormSirketEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSirketEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSec = new System.Windows.Forms.Button();
            this.PicLogo = new DevExpress.XtraEditors.PictureEdit();
            this.Btnkaydet = new System.Windows.Forms.Button();
            this.textAciklama = new System.Windows.Forms.TextBox();
            this.textKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnSec);
            this.groupBox1.Controls.Add(this.PicLogo);
            this.groupBox1.Controls.Add(this.Btnkaydet);
            this.groupBox1.Controls.Add(this.textAciklama);
            this.groupBox1.Controls.Add(this.textKod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textIsim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 450);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // BtnSec
            // 
            this.BtnSec.Location = new System.Drawing.Point(583, 225);
            this.BtnSec.Name = "BtnSec";
            this.BtnSec.Size = new System.Drawing.Size(203, 39);
            this.BtnSec.TabIndex = 7;
            this.BtnSec.Text = "BİR LOGO SEÇİN";
            this.BtnSec.UseVisualStyleBackColor = true;
            this.BtnSec.Click += new System.EventHandler(this.BtnSec_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicLogo.EditValue = ((object)(resources.GetObject("PicLogo.EditValue")));
            this.PicLogo.Location = new System.Drawing.Point(583, 16);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PicLogo.Size = new System.Drawing.Size(213, 192);
            this.PicLogo.TabIndex = 6;
            this.PicLogo.DoubleClick += new System.EventHandler(this.PicLogo_DoubleClick);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.Btnkaydet.Location = new System.Drawing.Point(292, 285);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(144, 53);
            this.Btnkaydet.TabIndex = 5;
            this.Btnkaydet.Text = "KAYDET";
            this.Btnkaydet.UseVisualStyleBackColor = true;
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // textAciklama
            // 
            this.textAciklama.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.textAciklama.Location = new System.Drawing.Point(225, 161);
            this.textAciklama.Name = "textAciklama";
            this.textAciklama.Size = new System.Drawing.Size(272, 47);
            this.textAciklama.TabIndex = 3;
            // 
            // textKod
            // 
            this.textKod.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.textKod.Location = new System.Drawing.Point(225, 86);
            this.textKod.Name = "textKod";
            this.textKod.Size = new System.Drawing.Size(272, 47);
            this.textKod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARİ İSMİ";
            // 
            // textIsim
            // 
            this.textIsim.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.textIsim.Location = new System.Drawing.Point(225, 16);
            this.textIsim.Name = "textIsim";
            this.textIsim.Size = new System.Drawing.Size(272, 47);
            this.textIsim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "CARİ KODU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label3.Location = new System.Drawing.Point(7, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "AÇIKLAMA";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.BtnGuncelle.Location = new System.Drawing.Point(273, 285);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(178, 53);
            this.BtnGuncelle.TabIndex = 8;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // FormSirketEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSirketEkle";
            this.Text = "FormSirketEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btnkaydet;
        private System.Windows.Forms.TextBox textAciklama;
        private System.Windows.Forms.TextBox textKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PictureEdit PicLogo;
        private System.Windows.Forms.Button BtnSec;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}