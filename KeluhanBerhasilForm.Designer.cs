namespace UASPBO
{
    partial class KeluhanBerhasilForm
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
            this.btnKonsultasi = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKonsultasi
            // 
            this.btnKonsultasi.Location = new System.Drawing.Point(323, 209);
            this.btnKonsultasi.Name = "btnKonsultasi";
            this.btnKonsultasi.Size = new System.Drawing.Size(155, 40);
            this.btnKonsultasi.TabIndex = 0;
            this.btnKonsultasi.Text = "Konsultasi";
            this.btnKonsultasi.UseVisualStyleBackColor = true;
            this.btnKonsultasi.Click += new System.EventHandler(this.btnKonsultasi_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(323, 267);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(155, 40);
            this.btnKembali.TabIndex = 1;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // KeluhanBerhasilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnKonsultasi);
            this.Name = "KeluhanBerhasilForm";
            this.Text = "KeluhanBerhasilForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKonsultasi;
        private System.Windows.Forms.Button btnKembali;
    }
}