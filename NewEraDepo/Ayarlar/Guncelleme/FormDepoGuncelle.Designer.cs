namespace NewEraDepo.Ayarlar.Guncelleme
{
    partial class FormDepoGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepoGuncelle));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnResimSec = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textKod = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.textIsim = new System.Windows.Forms.TextBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnResimSec);
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Controls.Add(this.textAciklama);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textKod);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.textIsim);
            this.groupBox2.Controls.Add(this.lblIsim);
            this.groupBox2.Controls.Add(this.lblKod);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 450);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // BtnResimSec
            // 
            this.BtnResimSec.Location = new System.Drawing.Point(500, 286);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(202, 47);
            this.BtnResimSec.TabIndex = 11;
            this.BtnResimSec.Text = "Bir Resim Seçin";
            this.BtnResimSec.UseVisualStyleBackColor = true;
            this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(464, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(282, 206);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // textAciklama
            // 
            this.textAciklama.Location = new System.Drawing.Point(190, 199);
            this.textAciklama.Name = "textAciklama";
            this.textAciklama.Size = new System.Drawing.Size(221, 39);
            this.textAciklama.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "AÇIKLAMA";
            // 
            // textKod
            // 
            this.textKod.Location = new System.Drawing.Point(191, 32);
            this.textKod.Name = "textKod";
            this.textKod.Size = new System.Drawing.Size(221, 39);
            this.textKod.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(126, 286);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(167, 47);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // textIsim
            // 
            this.textIsim.Location = new System.Drawing.Point(191, 112);
            this.textIsim.Name = "textIsim";
            this.textIsim.Size = new System.Drawing.Size(221, 39);
            this.textIsim.TabIndex = 2;
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(25, 115);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(62, 32);
            this.lblIsim.TabIndex = 1;
            this.lblIsim.Text = "İSİM";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(24, 35);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(63, 32);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "KOD";
            // 
            // FormDepoGuncelle
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.Name = "FormDepoGuncelle";
            this.Text = "FormDepoGuncelle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDepoGuncelle_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textKod;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox textIsim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox textAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnResimSec;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}