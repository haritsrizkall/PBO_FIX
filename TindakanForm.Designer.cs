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
            this.btnCariDokter = new System.Windows.Forms.Button();
            this.btnInfoRumahSakit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNamaPenyakit = new System.Windows.Forms.Label();
            this.btnInfoDokter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCariDokter
            // 
            this.btnCariDokter.Location = new System.Drawing.Point(344, 159);
            this.btnCariDokter.Name = "btnCariDokter";
            this.btnCariDokter.Size = new System.Drawing.Size(165, 41);
            this.btnCariDokter.TabIndex = 0;
            this.btnCariDokter.Text = "Cari Dokter";
            this.btnCariDokter.UseVisualStyleBackColor = true;
            this.btnCariDokter.Click += new System.EventHandler(this.btnCariDokter_Click);
            // 
            // btnInfoRumahSakit
            // 
            this.btnInfoRumahSakit.Location = new System.Drawing.Point(344, 206);
            this.btnInfoRumahSakit.Name = "btnInfoRumahSakit";
            this.btnInfoRumahSakit.Size = new System.Drawing.Size(165, 41);
            this.btnInfoRumahSakit.TabIndex = 1;
            this.btnInfoRumahSakit.Text = "Info Rumah Sakit";
            this.btnInfoRumahSakit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Penyakit Anda Adalah :";
            // 
            // lblNamaPenyakit
            // 
            this.lblNamaPenyakit.AutoSize = true;
            this.lblNamaPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPenyakit.Location = new System.Drawing.Point(44, 53);
            this.lblNamaPenyakit.Name = "lblNamaPenyakit";
            this.lblNamaPenyakit.Size = new System.Drawing.Size(144, 25);
            this.lblNamaPenyakit.TabIndex = 4;
            this.lblNamaPenyakit.Text = "Nama Penyakit";
            // 
            // btnInfoDokter
            // 
            this.btnInfoDokter.Location = new System.Drawing.Point(344, 253);
            this.btnInfoDokter.Name = "btnInfoDokter";
            this.btnInfoDokter.Size = new System.Drawing.Size(165, 41);
            this.btnInfoDokter.TabIndex = 5;
            this.btnInfoDokter.Text = "Info Dokter";
            this.btnInfoDokter.UseVisualStyleBackColor = true;
            this.btnInfoDokter.Click += new System.EventHandler(this.btnInfoDokter_Click);
            // 
            // TindakanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInfoDokter);
            this.Controls.Add(this.lblNamaPenyakit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInfoRumahSakit);
            this.Controls.Add(this.btnCariDokter);
            this.Name = "TindakanForm";
            this.Text = "TindakanForm";
            this.Load += new System.EventHandler(this.TindakanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCariDokter;
        private System.Windows.Forms.Button btnInfoRumahSakit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNamaPenyakit;
        private System.Windows.Forms.Button btnInfoDokter;
    }
}