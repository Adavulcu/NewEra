namespace NewEraDepo.Ayarlar
{
    partial class FormAdresEkle
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
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.textIsim = new System.Windows.Forms.TextBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.textKod = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 2;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.Controls.Add(this.textIsim, 1, 1);
            this.tblLayout.Controls.Add(this.lblKod, 0, 0);
            this.tblLayout.Controls.Add(this.lblIsim, 0, 1);
            this.tblLayout.Controls.Add(this.textKod, 1, 0);
            this.tblLayout.Controls.Add(this.btnEkle, 0, 2);
            this.tblLayout.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tblLayout.Location = new System.Drawing.Point(173, 116);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 3;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayout.Size = new System.Drawing.Size(500, 200);
            this.tblLayout.TabIndex = 1;
            // 
            // textIsim
            // 
            this.textIsim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIsim.Location = new System.Drawing.Point(253, 69);
            this.textIsim.Name = "textIsim";
            this.textIsim.Size = new System.Drawing.Size(244, 39);
            this.textIsim.TabIndex = 2;
            this.textIsim.Tag = "111";
            // 
            // lblKod
            // 
            this.lblKod.Location = new System.Drawing.Point(3, 0);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(160, 50);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "KOD";
            this.lblKod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIsim
            // 
            this.lblIsim.Location = new System.Drawing.Point(3, 66);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(160, 50);
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
            this.textKod.TabIndex = 1;
            this.textKod.Tag = "111";
            // 
            // btnEkle
            // 
            this.tblLayout.SetColumnSpan(this.btnEkle, 2);
            this.btnEkle.Location = new System.Drawing.Point(150, 135);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(150, 3, 150, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(200, 44);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // FormAdresEkle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.tblLayout);
            this.Name = "FormAdresEkle";
            this.Text = "FormDepoKatEkle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAdresEkle_KeyDown);
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tblLayout;
        public System.Windows.Forms.TextBox textIsim;
        public System.Windows.Forms.Label lblKod;
        public System.Windows.Forms.Label lblIsim;
        public System.Windows.Forms.TextBox textKod;
        public System.Windows.Forms.Button btnEkle;
    }
}