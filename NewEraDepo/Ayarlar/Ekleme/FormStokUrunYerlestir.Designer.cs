namespace NewEraDepo
{
    partial class FormStokUrunYerlestir
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
            this.CbDepo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.textAdesKod = new System.Windows.Forms.TextBox();
            this.btnAdresAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSonuc2 = new System.Windows.Forms.Label();
            this.textUrunKod = new System.Windows.Forms.TextBox();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbDepo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSonuc);
            this.groupBox1.Controls.Add(this.textAdesKod);
            this.groupBox1.Controls.Add(this.btnAdresAra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CbDepo
            // 
            this.CbDepo.AccessibleName = "CBDepo";
            this.CbDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDepo.FormattingEnabled = true;
            this.CbDepo.Location = new System.Drawing.Point(334, 49);
            this.CbDepo.Name = "CbDepo";
            this.CbDepo.Size = new System.Drawing.Size(256, 33);
            this.CbDepo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "DEPO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "DURUM ";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(329, 194);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(73, 25);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "durum";
            this.lblSonuc.Visible = false;
            // 
            // textAdesKod
            // 
            this.textAdesKod.Location = new System.Drawing.Point(334, 127);
            this.textAdesKod.Name = "textAdesKod";
            this.textAdesKod.Size = new System.Drawing.Size(241, 33);
            this.textAdesKod.TabIndex = 2;
            this.textAdesKod.TextChanged += new System.EventHandler(this.textAdesKod_TextChanged);
            // 
            // btnAdresAra
            // 
            this.btnAdresAra.Location = new System.Drawing.Point(600, 124);
            this.btnAdresAra.Name = "btnAdresAra";
            this.btnAdresAra.Size = new System.Drawing.Size(91, 36);
            this.btnAdresAra.TabIndex = 1;
            this.btnAdresAra.Text = "ARA";
            this.btnAdresAra.UseVisualStyleBackColor = true;
            this.btnAdresAra.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPOLAMA ADRESİ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUrunAra);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblSonuc2);
            this.groupBox2.Controls.Add(this.textUrunKod);
            this.groupBox2.Controls.Add(this.btnStokEkle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(23, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Location = new System.Drawing.Point(600, 26);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(91, 36);
            this.btnUrunAra.TabIndex = 8;
            this.btnUrunAra.Text = "ARA";
            this.btnUrunAra.UseVisualStyleBackColor = true;
            this.btnUrunAra.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "DURUM";
            // 
            // lblSonuc2
            // 
            this.lblSonuc2.AutoSize = true;
            this.lblSonuc2.Location = new System.Drawing.Point(329, 95);
            this.lblSonuc2.Name = "lblSonuc2";
            this.lblSonuc2.Size = new System.Drawing.Size(73, 25);
            this.lblSonuc2.TabIndex = 6;
            this.lblSonuc2.Text = "durum";
            this.lblSonuc2.Visible = false;
            // 
            // textUrunKod
            // 
            this.textUrunKod.Location = new System.Drawing.Point(334, 29);
            this.textUrunKod.Name = "textUrunKod";
            this.textUrunKod.Size = new System.Drawing.Size(241, 33);
            this.textUrunKod.TabIndex = 5;
            this.textUrunKod.TextChanged += new System.EventHandler(this.textUrunKod_TextChanged);
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.Enabled = false;
            this.btnStokEkle.Location = new System.Drawing.Point(334, 175);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(172, 36);
            this.btnStokEkle.TabIndex = 4;
            this.btnStokEkle.Text = "YERLEŞTİR";
            this.btnStokEkle.UseVisualStyleBackColor = true;
            this.btnStokEkle.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÜRÜN BİLGİSİ";
            // 
            // FormStokUrunYerlestir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormStokUrunYerlestir";
            this.Text = "FormStokUrunYerlestir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox textAdesKod;
        private System.Windows.Forms.Button btnAdresAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textUrunKod;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSonuc2;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.ComboBox CbDepo;
        private System.Windows.Forms.Label label5;
    }
}