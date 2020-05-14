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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblNama = new System.Windows.Forms.Label();
            this.btnBuatKeluhan = new System.Windows.Forms.Button();
            this.btnCariDokter = new System.Windows.Forms.Button();
            this.lblJadwal = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.BackColor = System.Drawing.Color.Transparent;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.White;
            this.lblNama.Location = new System.Drawing.Point(21, 60);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(0, 29);
            this.lblNama.TabIndex = 1;
            // 
            // btnBuatKeluhan
            // 
            this.btnBuatKeluhan.Image = ((System.Drawing.Image)(resources.GetObject("btnBuatKeluhan.Image")));
            this.btnBuatKeluhan.Location = new System.Drawing.Point(261, 223);
            this.btnBuatKeluhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuatKeluhan.Name = "btnBuatKeluhan";
            this.btnBuatKeluhan.Size = new System.Drawing.Size(282, 39);
            this.btnBuatKeluhan.TabIndex = 2;
            this.btnBuatKeluhan.UseVisualStyleBackColor = true;
            this.btnBuatKeluhan.Click += new System.EventHandler(this.btnBuatKeluhan_Click);
            // 
            // btnCariDokter
            // 
            this.btnCariDokter.Image = ((System.Drawing.Image)(resources.GetObject("btnCariDokter.Image")));
            this.btnCariDokter.Location = new System.Drawing.Point(261, 270);
            this.btnCariDokter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCariDokter.Name = "btnCariDokter";
            this.btnCariDokter.Size = new System.Drawing.Size(282, 41);
            this.btnCariDokter.TabIndex = 3;
            this.btnCariDokter.UseVisualStyleBackColor = true;
            this.btnCariDokter.Click += new System.EventHandler(this.btnCariDokter_Click);
            // 
            // lblJadwal
            // 
            this.lblJadwal.AutoSize = true;
            this.lblJadwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJadwal.Location = new System.Drawing.Point(38, 395);
            this.lblJadwal.Name = "lblJadwal";
            this.lblJadwal.Size = new System.Drawing.Size(0, 25);
            this.lblJadwal.TabIndex = 5;
            // 
            // btnProfile
            // 
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.Location = new System.Drawing.Point(261, 324);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(282, 41);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(333, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 57);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblJadwal);
            this.Controls.Add(this.btnCariDokter);
            this.Controls.Add(this.btnBuatKeluhan);
            this.Controls.Add(this.lblNama);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button btnBuatKeluhan;
        private System.Windows.Forms.Button btnCariDokter;
        private System.Windows.Forms.Label lblJadwal;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button button1;
    }
}