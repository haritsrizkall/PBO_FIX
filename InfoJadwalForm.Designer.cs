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
            this.lblJadwal1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJadwal1
            // 
            this.lblJadwal1.AutoSize = true;
            this.lblJadwal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJadwal1.Location = new System.Drawing.Point(28, 168);
            this.lblJadwal1.Name = "lblJadwal1";
            this.lblJadwal1.Size = new System.Drawing.Size(159, 25);
            this.lblJadwal1.TabIndex = 8;
            this.lblJadwal1.Text = "Tidak ada jadwal";
            this.lblJadwal1.Click += new System.EventHandler(this.lblJadwal1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jadwal Kamu  :";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(631, 372);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(133, 56);
            this.btnKembali.TabIndex = 9;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // InfoJadwalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblJadwal1);
            this.Controls.Add(this.label2);
            this.Name = "InfoJadwalForm";
            this.Text = "InfoJadwalForm";
            this.Load += new System.EventHandler(this.InfoJadwalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJadwal1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKembali;
    }
}