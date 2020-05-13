namespace UASPBO
{
    partial class BuatJadwalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbJadwal1 = new System.Windows.Forms.CheckBox();
            this.cbJadwal2 = new System.Windows.Forms.CheckBox();
            this.lblNamaDokter = new System.Windows.Forms.Label();
            this.btnBuatJadwal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dokter yang tersedia  :";
            // 
            // cbJadwal1
            // 
            this.cbJadwal1.AutoSize = true;
            this.cbJadwal1.Location = new System.Drawing.Point(219, 210);
            this.cbJadwal1.Name = "cbJadwal1";
            this.cbJadwal1.Size = new System.Drawing.Size(167, 21);
            this.cbJadwal1.TabIndex = 1;
            this.cbJadwal1.Text = "Kamis (08:00 - 12:00)";
            this.cbJadwal1.UseVisualStyleBackColor = true;
            // 
            // cbJadwal2
            // 
            this.cbJadwal2.AutoSize = true;
            this.cbJadwal2.Location = new System.Drawing.Point(412, 210);
            this.cbJadwal2.Name = "cbJadwal2";
            this.cbJadwal2.Size = new System.Drawing.Size(165, 21);
            this.cbJadwal2.TabIndex = 2;
            this.cbJadwal2.Text = "Senin (17:00 - 20:00)";
            this.cbJadwal2.UseVisualStyleBackColor = true;
            // 
            // lblNamaDokter
            // 
            this.lblNamaDokter.AutoSize = true;
            this.lblNamaDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaDokter.Location = new System.Drawing.Point(315, 149);
            this.lblNamaDokter.Name = "lblNamaDokter";
            this.lblNamaDokter.Size = new System.Drawing.Size(154, 29);
            this.lblNamaDokter.TabIndex = 3;
            this.lblNamaDokter.Text = "Nama Dokter";
            // 
            // btnBuatJadwal
            // 
            this.btnBuatJadwal.Location = new System.Drawing.Point(320, 266);
            this.btnBuatJadwal.Name = "btnBuatJadwal";
            this.btnBuatJadwal.Size = new System.Drawing.Size(143, 46);
            this.btnBuatJadwal.TabIndex = 4;
            this.btnBuatJadwal.Text = "Buat Jadwal";
            this.btnBuatJadwal.UseVisualStyleBackColor = true;
            this.btnBuatJadwal.Click += new System.EventHandler(this.btnBuatJadwal_Click);
            // 
            // BuatJadwalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuatJadwal);
            this.Controls.Add(this.lblNamaDokter);
            this.Controls.Add(this.cbJadwal2);
            this.Controls.Add(this.cbJadwal1);
            this.Controls.Add(this.label1);
            this.Name = "BuatJadwalForm";
            this.Text = "BuatJadwal";
            this.Load += new System.EventHandler(this.BuatJadwal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbJadwal1;
        private System.Windows.Forms.CheckBox cbJadwal2;
        private System.Windows.Forms.Label lblNamaDokter;
        private System.Windows.Forms.Button btnBuatJadwal;
    }
}