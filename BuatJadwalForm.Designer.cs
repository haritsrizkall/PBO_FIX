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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuatJadwalForm));
            this.cbJadwal1 = new System.Windows.Forms.CheckBox();
            this.cbJadwal2 = new System.Windows.Forms.CheckBox();
            this.lblNamaDokter = new System.Windows.Forms.Label();
            this.btnBuatJadwal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbJadwal1
            // 
            this.cbJadwal1.AutoSize = true;
            this.cbJadwal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJadwal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.cbJadwal1.Location = new System.Drawing.Point(80, 241);
            this.cbJadwal1.Name = "cbJadwal1";
            this.cbJadwal1.Size = new System.Drawing.Size(260, 33);
            this.cbJadwal1.TabIndex = 1;
            this.cbJadwal1.Text = "Kamis (08:00 - 12:00)";
            this.cbJadwal1.UseVisualStyleBackColor = true;
            // 
            // cbJadwal2
            // 
            this.cbJadwal2.AutoSize = true;
            this.cbJadwal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJadwal2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.cbJadwal2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbJadwal2.Location = new System.Drawing.Point(373, 241);
            this.cbJadwal2.Name = "cbJadwal2";
            this.cbJadwal2.Size = new System.Drawing.Size(255, 33);
            this.cbJadwal2.TabIndex = 2;
            this.cbJadwal2.Text = "Senin (17:00 - 20:00)";
            this.cbJadwal2.UseVisualStyleBackColor = true;
            // 
            // lblNamaDokter
            // 
            this.lblNamaDokter.AutoSize = true;
            this.lblNamaDokter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.lblNamaDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaDokter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNamaDokter.Location = new System.Drawing.Point(212, 185);
            this.lblNamaDokter.Name = "lblNamaDokter";
            this.lblNamaDokter.Size = new System.Drawing.Size(0, 29);
            this.lblNamaDokter.TabIndex = 3;
            this.lblNamaDokter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuatJadwal
            // 
            this.btnBuatJadwal.Image = ((System.Drawing.Image)(resources.GetObject("btnBuatJadwal.Image")));
            this.btnBuatJadwal.Location = new System.Drawing.Point(271, 294);
            this.btnBuatJadwal.Name = "btnBuatJadwal";
            this.btnBuatJadwal.Size = new System.Drawing.Size(170, 34);
            this.btnBuatJadwal.TabIndex = 4;
            this.btnBuatJadwal.UseVisualStyleBackColor = true;
            this.btnBuatJadwal.Click += new System.EventHandler(this.btnBuatJadwal_Click);
            // 
            // BuatJadwalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 479);
            this.Controls.Add(this.btnBuatJadwal);
            this.Controls.Add(this.lblNamaDokter);
            this.Controls.Add(this.cbJadwal2);
            this.Controls.Add(this.cbJadwal1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuatJadwalForm";
            this.Text = "BuatJadwal";
            this.Load += new System.EventHandler(this.BuatJadwal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbJadwal1;
        private System.Windows.Forms.CheckBox cbJadwal2;
        private System.Windows.Forms.Label lblNamaDokter;
        private System.Windows.Forms.Button btnBuatJadwal;
    }
}