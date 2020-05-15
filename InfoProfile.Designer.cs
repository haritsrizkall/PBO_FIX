namespace UASPBO
{
    partial class InfoProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoProfile));
            this.lblNama = new System.Windows.Forms.Label();
            this.lblTanggalLahir = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.BackColor = System.Drawing.Color.Transparent;
            this.lblNama.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lblNama.Location = new System.Drawing.Point(69, 187);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(0, 28);
            this.lblNama.TabIndex = 1;
            // 
            // lblTanggalLahir
            // 
            this.lblTanggalLahir.AutoSize = true;
            this.lblTanggalLahir.BackColor = System.Drawing.Color.Transparent;
            this.lblTanggalLahir.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalLahir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lblTanggalLahir.Location = new System.Drawing.Point(69, 270);
            this.lblTanggalLahir.Name = "lblTanggalLahir";
            this.lblTanggalLahir.Size = new System.Drawing.Size(0, 28);
            this.lblTanggalLahir.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lblEmail.Location = new System.Drawing.Point(69, 445);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 28);
            this.lblEmail.TabIndex = 5;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.BackColor = System.Drawing.Color.Transparent;
            this.lblAlamat.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lblAlamat.Location = new System.Drawing.Point(69, 360);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(0, 28);
            this.lblAlamat.TabIndex = 7;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnKembali.Image = ((System.Drawing.Image)(resources.GetObject("btnKembali.Image")));
            this.btnKembali.Location = new System.Drawing.Point(11, 10);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(58, 34);
            this.btnKembali.TabIndex = 11;
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // InfoProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 522);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTanggalLahir);
            this.Controls.Add(this.lblNama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoProfile";
            this.Text = "InfoProfile";
            this.Load += new System.EventHandler(this.InfoProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblTanggalLahir;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Button btnKembali;
    }
}