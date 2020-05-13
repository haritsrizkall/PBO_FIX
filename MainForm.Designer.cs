namespace UASPBO
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.btnBuatKeluhan = new System.Windows.Forms.Button();
            this.btnCariDokter = new System.Windows.Forms.Button();
            this.lblJadwal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang,";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(33, 52);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(136, 29);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Akun";
            // 
            // btnBuatKeluhan
            // 
            this.btnBuatKeluhan.Location = new System.Drawing.Point(320, 144);
            this.btnBuatKeluhan.Name = "btnBuatKeluhan";
            this.btnBuatKeluhan.Size = new System.Drawing.Size(195, 33);
            this.btnBuatKeluhan.TabIndex = 2;
            this.btnBuatKeluhan.Text = "Buat Keluhan";
            this.btnBuatKeluhan.UseVisualStyleBackColor = true;
            this.btnBuatKeluhan.Click += new System.EventHandler(this.btnBuatKeluhan_Click);
            // 
            // btnCariDokter
            // 
            this.btnCariDokter.Location = new System.Drawing.Point(320, 192);
            this.btnCariDokter.Name = "btnCariDokter";
            this.btnCariDokter.Size = new System.Drawing.Size(195, 33);
            this.btnCariDokter.TabIndex = 3;
            this.btnCariDokter.Text = "Info Jadwal";
            this.btnCariDokter.UseVisualStyleBackColor = true;
            this.btnCariDokter.Click += new System.EventHandler(this.btnCariDokter_Click);
            // 
            // lblJadwal
            // 
            this.lblJadwal.AutoSize = true;
            this.lblJadwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJadwal.Location = new System.Drawing.Point(34, 316);
            this.lblJadwal.Name = "lblJadwal";
            this.lblJadwal.Size = new System.Drawing.Size(0, 20);
            this.lblJadwal.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblJadwal);
            this.Controls.Add(this.btnCariDokter);
            this.Controls.Add(this.btnBuatKeluhan);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button btnBuatKeluhan;
        private System.Windows.Forms.Button btnCariDokter;
        private System.Windows.Forms.Label lblJadwal;
    }
}