namespace UASPBO
{
    partial class TindakanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TindakanForm));
            this.btnCariDokter = new System.Windows.Forms.Button();
            this.btnInfoRumahSakit = new System.Windows.Forms.Button();
            this.btnInfoDokter = new System.Windows.Forms.Button();
            this.lblNamaPenyakit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCariDokter
            // 
            this.btnCariDokter.Image = ((System.Drawing.Image)(resources.GetObject("btnCariDokter.Image")));
            this.btnCariDokter.Location = new System.Drawing.Point(231, 179);
            this.btnCariDokter.Name = "btnCariDokter";
            this.btnCariDokter.Size = new System.Drawing.Size(252, 31);
            this.btnCariDokter.TabIndex = 0;
            this.btnCariDokter.UseVisualStyleBackColor = true;
            this.btnCariDokter.Click += new System.EventHandler(this.btnCariDokter_Click);
            // 
            // btnInfoRumahSakit
            // 
            this.btnInfoRumahSakit.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoRumahSakit.Image")));
            this.btnInfoRumahSakit.Location = new System.Drawing.Point(231, 221);
            this.btnInfoRumahSakit.Name = "btnInfoRumahSakit";
            this.btnInfoRumahSakit.Size = new System.Drawing.Size(252, 31);
            this.btnInfoRumahSakit.TabIndex = 1;
            this.btnInfoRumahSakit.UseVisualStyleBackColor = true;
            this.btnInfoRumahSakit.Click += new System.EventHandler(this.btnInfoRumahSakit_Click);
            // 
            // btnInfoDokter
            // 
            this.btnInfoDokter.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoDokter.Image")));
            this.btnInfoDokter.Location = new System.Drawing.Point(231, 265);
            this.btnInfoDokter.Name = "btnInfoDokter";
            this.btnInfoDokter.Size = new System.Drawing.Size(252, 31);
            this.btnInfoDokter.TabIndex = 5;
            this.btnInfoDokter.UseVisualStyleBackColor = true;
            this.btnInfoDokter.Click += new System.EventHandler(this.btnInfoDokter_Click);
            // 
            // lblNamaPenyakit
            // 
            this.lblNamaPenyakit.AutoSize = true;
            this.lblNamaPenyakit.BackColor = System.Drawing.Color.Transparent;
            this.lblNamaPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPenyakit.ForeColor = System.Drawing.Color.White;
            this.lblNamaPenyakit.Location = new System.Drawing.Point(24, 57);
            this.lblNamaPenyakit.Name = "lblNamaPenyakit";
            this.lblNamaPenyakit.Size = new System.Drawing.Size(0, 25);
            this.lblNamaPenyakit.TabIndex = 6;
            // 
            // TindakanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 479);
            this.Controls.Add(this.lblNamaPenyakit);
            this.Controls.Add(this.btnInfoDokter);
            this.Controls.Add(this.btnInfoRumahSakit);
            this.Controls.Add(this.btnCariDokter);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TindakanForm";
            this.Text = "TindakanForm";
            this.Load += new System.EventHandler(this.TindakanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCariDokter;
        private System.Windows.Forms.Button btnInfoRumahSakit;
        private System.Windows.Forms.Button btnInfoDokter;
        private System.Windows.Forms.Label lblNamaPenyakit;
    }
}