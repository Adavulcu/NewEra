namespace NewEraDepo.Ayarlar.Ekleme
{
    partial class FormDepoKapiEkle
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
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TextIsim = new System.Windows.Forms.TextBox();
            this.TextKod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbDepoX = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.TextIsim);
            this.groupBox1.Controls.Add(this.TextKod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbDepoX);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(125, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(247, 271);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(255, 51);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TextIsim
            // 
            this.TextIsim.Location = new System.Drawing.Point(247, 167);
            this.TextIsim.Name = "TextIsim";
            this.TextIsim.Size = new System.Drawing.Size(255, 35);
            this.TextIsim.TabIndex = 2;
            // 
            // TextKod
            // 
            this.TextKod.Location = new System.Drawing.Point(247, 104);
            this.TextKod.Name = "TextKod";
            this.TextKod.Size = new System.Drawing.Size(255, 35);
            this.TextKod.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "KAPI  İSİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "KAPI KODU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEPO X ADRES";
            // 
            // CbDepoX
            // 
            this.CbDepoX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDepoX.FormattingEnabled = true;
            this.CbDepoX.Location = new System.Drawing.Point(247, 36);
            this.CbDepoX.Name = "CbDepoX";
            this.CbDepoX.Size = new System.Drawing.Size(255, 38);
            this.CbDepoX.TabIndex = 0;
            this.CbDepoX.SelectedIndexChanged += new System.EventHandler(this.CbDepoX_SelectedIndexChanged);
            // 
            // FormDepoKapiEkle
            // 
            this.AcceptButton = this.BtnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDepoKapiEkle";
            this.Text = "FormDepoKapiEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TextIsim;
        private System.Windows.Forms.TextBox TextKod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDepoX;
    }
}