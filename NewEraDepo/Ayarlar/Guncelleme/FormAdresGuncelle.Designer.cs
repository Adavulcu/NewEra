namespace NewEraDepo.Ayarlar.Guncelleme
{
    partial class FormAdresGuncelle
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textKod = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.textIsim = new System.Windows.Forms.TextBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
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
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // textKod
            // 
            this.textKod.Location = new System.Drawing.Point(394, 92);
            this.textKod.Name = "textKod";
            this.textKod.Size = new System.Drawing.Size(221, 39);
            this.textKod.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(295, 269);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(167, 47);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // textIsim
            // 
            this.textIsim.Location = new System.Drawing.Point(394, 172);
            this.textIsim.Name = "textIsim";
            this.textIsim.Size = new System.Drawing.Size(221, 39);
            this.textIsim.TabIndex = 2;
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(130, 175);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(62, 32);
            this.lblIsim.TabIndex = 1;
            this.lblIsim.Text = "İSİM";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(129, 95);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(63, 32);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "KOD";
            // 
            // FormAdresGuncelle
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormAdresGuncelle";
            this.Text = "FormAdresGuncelle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAdresGuncelle_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox textIsim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox textKod;
    }
}