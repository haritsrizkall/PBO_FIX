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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeluhanBerhasilForm));
            this.btnKonsultasi = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKonsultasi
            // 
            this.btnKonsultasi.Image = ((System.Drawing.Image)(resources.GetObject("btnKonsultasi.Image")));
            this.btnKonsultasi.Location = new System.Drawing.Point(324, 425);
            this.btnKonsultasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKonsultasi.Name = "btnKonsultasi";
            this.btnKonsultasi.Size = new System.Drawing.Size(153, 40);
            this.btnKonsultasi.TabIndex = 0;
            this.btnKonsultasi.UseVisualStyleBackColor = true;
            this.btnKonsultasi.Click += new System.EventHandler(this.btnKonsultasi_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Image = ((System.Drawing.Image)(resources.GetObject("btnKembali.Image")));
            this.btnKembali.Location = new System.Drawing.Point(324, 482);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(154, 42);
            this.btnKembali.TabIndex = 1;
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // KeluhanBerhasilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 599);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnKonsultasi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeluhanBerhasilForm";
            this.Text = "KeluhanBerhasilForm";
            this.Load += new System.EventHandler(this.KeluhanBerhasilForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKonsultasi;
        private System.Windows.Forms.Button btnKembali;
    }
}