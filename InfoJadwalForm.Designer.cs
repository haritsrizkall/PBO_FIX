namespace UASPBO
{
    partial class InfoJadwalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoJadwalForm));
            this.lblJadwal1 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.lblNamaDokter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJadwal1
            // 
            this.lblJadwal1.AutoSize = true;
            this.lblJadwal1.BackColor = System.Drawing.Color.Transparent;
            this.lblJadwal1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJadwal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.lblJadwal1.Location = new System.Drawing.Point(67, 276);
            this.lblJadwal1.Name = "lblJadwal1";
            this.lblJadwal1.Size = new System.Drawing.Size(0, 30);
            this.lblJadwal1.TabIndex = 8;
            this.lblJadwal1.Click += new System.EventHandler(this.lblJadwal1_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnKembali.ForeColor = System.Drawing.Color.Black;
            this.btnKembali.Image = ((System.Drawing.Image)(resources.GetObject("btnKembali.Image")));
            this.btnKembali.Location = new System.Drawing.Point(12, 13);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(65, 43);
            this.btnKembali.TabIndex = 9;
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // lblNamaDokter
            // 
            this.lblNamaDokter.AutoSize = true;
            this.lblNamaDokter.BackColor = System.Drawing.Color.Transparent;
            this.lblNamaDokter.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaDokter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.lblNamaDokter.Location = new System.Drawing.Point(67, 206);
            this.lblNamaDokter.Name = "lblNamaDokter";
            this.lblNamaDokter.Size = new System.Drawing.Size(0, 30);
            this.lblNamaDokter.TabIndex = 10;
            // 
            // InfoJadwalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 599);
            this.Controls.Add(this.lblNamaDokter);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblJadwal1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoJadwalForm";
            this.Text = "InfoJadwalForm";
            this.Load += new System.EventHandler(this.InfoJadwalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJadwal1;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblNamaDokter;
    }
}