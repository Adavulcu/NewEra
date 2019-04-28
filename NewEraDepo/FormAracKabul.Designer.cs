namespace NewEraDepo
{
    partial class FormAracKabul
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
            this.tePlaka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teSofor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teFirma = new DevExpress.XtraEditors.TextEdit();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tePlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSofor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirma.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tePlaka
            // 
            this.tePlaka.Location = new System.Drawing.Point(143, 27);
            this.tePlaka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tePlaka.Name = "tePlaka";
            this.tePlaka.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tePlaka.Properties.Appearance.Options.UseFont = true;
            this.tePlaka.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tePlaka.Properties.Mask.EditMask = "(0[1-9]|[1-7][0-9]|8[01])(([A-PR-VYZ])(\\d{4,5})|([A-PR-VYZ]{2})(\\d{3,4})|([A-PR-V" +
    "YZ]{3})(\\d{2,3}))";
            this.tePlaka.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tePlaka.Properties.Mask.ShowPlaceHolders = false;
            this.tePlaka.Size = new System.Drawing.Size(150, 32);
            this.tePlaka.TabIndex = 0;
            this.tePlaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TePlaka_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 33);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Araç Plakası";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 75);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Şoför";
            // 
            // teSofor
            // 
            this.teSofor.Location = new System.Drawing.Point(143, 69);
            this.teSofor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teSofor.Name = "teSofor";
            this.teSofor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teSofor.Properties.Appearance.Options.UseFont = true;
            this.teSofor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teSofor.Properties.Mask.EditMask = "/^[a-zA-ZöçşığüÖÇŞİĞÜ,]+(\\s{0,1}[a-zA-ZöçşığüÖÇŞİĞÜ, ])*$/";
            this.teSofor.Properties.Mask.ShowPlaceHolders = false;
            this.teSofor.Size = new System.Drawing.Size(376, 32);
            this.teSofor.TabIndex = 3;
            this.teSofor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeSofor_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 117);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Firma";
            // 
            // teFirma
            // 
            this.teFirma.Location = new System.Drawing.Point(143, 111);
            this.teFirma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teFirma.Name = "teFirma";
            this.teFirma.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teFirma.Properties.Appearance.Options.UseFont = true;
            this.teFirma.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teFirma.Properties.Mask.EditMask = "/^[a-zA-ZöçşığüÖÇŞİĞÜ,]+(\\s{0,1}[a-zA-ZöçşığüÖÇŞİĞÜ, ])*$/";
            this.teFirma.Properties.Mask.ShowPlaceHolders = false;
            this.teFirma.Size = new System.Drawing.Size(376, 32);
            this.teFirma.TabIndex = 5;
            this.teFirma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeFirma_KeyPress);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(187, 162);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(163, 42);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(356, 162);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(163, 42);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.Button2_Click);
            // 
            // FormAracKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 229);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.teFirma);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.teSofor);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tePlaka);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAracKabul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAracKabul";
            ((System.ComponentModel.ISupportInitialize)(this.tePlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSofor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirma.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tePlaka;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teSofor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teFirma;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnIptal;
    }
}