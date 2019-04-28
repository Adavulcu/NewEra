namespace NewEra.DepoSimu
{
    partial class MainForm
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
            this.btnRafA = new System.Windows.Forms.Button();
            this.btnRafB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRafA
            // 
            this.btnRafA.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRafA.Location = new System.Drawing.Point(32, 81);
            this.btnRafA.Name = "btnRafA";
            this.btnRafA.Size = new System.Drawing.Size(292, 132);
            this.btnRafA.TabIndex = 0;
            this.btnRafA.Text = "A RAFI";
            this.btnRafA.UseVisualStyleBackColor = true;
            this.btnRafA.Click += new System.EventHandler(this.RafClick);
            // 
            // btnRafB
            // 
            this.btnRafB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRafB.Location = new System.Drawing.Point(377, 81);
            this.btnRafB.Name = "btnRafB";
            this.btnRafB.Size = new System.Drawing.Size(292, 132);
            this.btnRafB.TabIndex = 1;
            this.btnRafB.Text = "B RAFI";
            this.btnRafB.UseVisualStyleBackColor = true;
            this.btnRafB.Click += new System.EventHandler(this.RafClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRafB);
            this.Controls.Add(this.btnRafA);
            this.Name = "MainForm";
            this.Text = "DEPO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRafA;
        private System.Windows.Forms.Button btnRafB;
    }
}

