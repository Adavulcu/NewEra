namespace NewEraDepo.Ayarlar.Ekleme
{
    partial class FormDepoXEkle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textIsim = new System.Windows.Forms.TextBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.textKod = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBTip = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textIsim, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblKod, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIsim, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textKod, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEkle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CBTip, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(150, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 200);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textIsim
            // 
            this.textIsim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIsim.Location = new System.Drawing.Point(253, 53);
            this.textIsim.Name = "textIsim";
            this.textIsim.Size = new System.Drawing.Size(244, 39);
            this.textIsim.TabIndex = 5;
            // 
            // lblKod
            // 
            this.lblKod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKod.Location = new System.Drawing.Point(3, 0);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(244, 50);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "KOD";
            this.lblKod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIsim
            // 
            this.lblIsim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIsim.Location = new System.Drawing.Point(3, 50);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(244, 50);
            this.lblIsim.TabIndex = 1;
            this.lblIsim.Text = "İSİM";
            this.lblIsim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textKod
            // 
            this.textKod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textKod.Location = new System.Drawing.Point(253, 3);
            this.textKod.Name = "textKod";
            this.textKod.Size = new System.Drawing.Size(244, 39);
            this.textKod.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnEkle, 2);
            this.btnEkle.Location = new System.Drawing.Point(150, 153);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(150, 3, 150, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(200, 44);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "TİP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBTip
            // 
            this.CBTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBTip.FormattingEnabled = true;
            this.CBTip.Location = new System.Drawing.Point(253, 103);
            this.CBTip.Name = "CBTip";
            this.CBTip.Size = new System.Drawing.Size(244, 40);
            this.CBTip.TabIndex = 7;
            // 
            // FormDepoXEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormDepoXEkle";
            this.Text = "FormDepoXEkle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDepoXEkle_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox textIsim;
        public System.Windows.Forms.Label lblKod;
        public System.Windows.Forms.Label lblIsim;
        public System.Windows.Forms.TextBox textKod;
        public System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBTip;
    }
}