namespace NewEra.DepoSimu
{
    partial class FormRafDetay
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
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.grBoxOran = new System.Windows.Forms.GroupBox();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.grBoxKoy = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.xtraScrollableControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.xtraScrollableControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.grBoxOran);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(3, 3);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(816, 90);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // grBoxOran
            // 
            this.grBoxOran.AutoSize = true;
            this.grBoxOran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxOran.Location = new System.Drawing.Point(0, 0);
            this.grBoxOran.Name = "grBoxOran";
            this.grBoxOran.Size = new System.Drawing.Size(816, 90);
            this.grBoxOran.TabIndex = 0;
            this.grBoxOran.TabStop = false;
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.grBoxKoy);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.FireScrollEventOnMouseWheel = true;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(3, 99);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(816, 284);
            this.xtraScrollableControl2.TabIndex = 1;
            // 
            // grBoxKoy
            // 
            this.grBoxKoy.AutoSize = true;
            this.grBoxKoy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxKoy.Location = new System.Drawing.Point(0, 0);
            this.grBoxKoy.Name = "grBoxKoy";
            this.grBoxKoy.Size = new System.Drawing.Size(816, 284);
            this.grBoxKoy.TabIndex = 0;
            this.grBoxKoy.TabStop = false;
            // 
            // FormRafDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormRafDetay";
            this.Text = "FormRafDetay";
            this.Shown += new System.EventHandler(this.FormRafDetay_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            this.xtraScrollableControl2.ResumeLayout(false);
            this.xtraScrollableControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private System.Windows.Forms.GroupBox grBoxKoy;
        private System.Windows.Forms.GroupBox grBoxOran;
    }
}