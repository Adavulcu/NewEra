namespace NewEraDepo
{
    partial class FormMain
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnMalKabul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.BtnModul = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMalKabul
            // 
            this.btnMalKabul.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMalKabul.Image = ((System.Drawing.Image)(resources.GetObject("btnMalKabul.Image")));
            this.btnMalKabul.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMalKabul.Location = new System.Drawing.Point(40, 43);
            this.btnMalKabul.Name = "btnMalKabul";
            this.btnMalKabul.Size = new System.Drawing.Size(238, 168);
            this.btnMalKabul.TabIndex = 0;
            this.btnMalKabul.Text = "Araç Kabul";
            this.btnMalKabul.UseVisualStyleBackColor = true;
            this.btnMalKabul.Click += new System.EventHandler(this.BtnMalKabul_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(302, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 168);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yük İndirme Emri oluştur";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(555, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 168);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yük İndirme Emri";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(812, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 168);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ürün Kabul ve Kalite Kontrol";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(46, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 168);
            this.button4.TabIndex = 4;
            this.button4.Text = "Depo Ürün Yerleştirme";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1070, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAyarlar.Location = new System.Drawing.Point(555, 241);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(232, 168);
            this.btnAyarlar.TabIndex = 7;
            this.btnAyarlar.Text = "AYARLAR";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // BtnModul
            // 
            this.BtnModul.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.BtnModul.Image = ((System.Drawing.Image)(resources.GetObject("BtnModul.Image")));
            this.BtnModul.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModul.Location = new System.Drawing.Point(812, 241);
            this.BtnModul.Name = "BtnModul";
            this.BtnModul.Size = new System.Drawing.Size(232, 168);
            this.BtnModul.TabIndex = 8;
            this.BtnModul.Text = "MODÜLLER";
            this.BtnModul.UseVisualStyleBackColor = true;
            this.BtnModul.Click += new System.EventHandler(this.BtnModul_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(1070, 592);
            this.Controls.Add(this.BtnModul);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMalKabul);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FormMain";
            this.Text = "NewEra";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnMalKabul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button BtnModul;
    }
}

