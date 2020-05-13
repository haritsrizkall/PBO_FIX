namespace UASPBO
{
    partial class KeluhanForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKeluhan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb1Hari = new System.Windows.Forms.CheckBox();
            this.cb2Minggu = new System.Windows.Forms.CheckBox();
            this.cb2Hari = new System.Windows.Forms.CheckBox();
            this.cb1Minggu = new System.Windows.Forms.CheckBox();
            this.rtbKeluhan = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInputKeluhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buat Keluhan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Keluhan";
            // 
            // cmbKeluhan
            // 
            this.cmbKeluhan.FormattingEnabled = true;
            this.cmbKeluhan.Location = new System.Drawing.Point(63, 124);
            this.cmbKeluhan.Name = "cmbKeluhan";
            this.cmbKeluhan.Size = new System.Drawing.Size(263, 24);
            this.cmbKeluhan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lama Sakit";
            // 
            // cb1Hari
            // 
            this.cb1Hari.AutoSize = true;
            this.cb1Hari.Location = new System.Drawing.Point(63, 211);
            this.cb1Hari.Name = "cb1Hari";
            this.cb1Hari.Size = new System.Drawing.Size(68, 21);
            this.cb1Hari.TabIndex = 4;
            this.cb1Hari.Text = "1 Hari";
            this.cb1Hari.UseVisualStyleBackColor = true;
            // 
            // cb2Minggu
            // 
            this.cb2Minggu.AutoSize = true;
            this.cb2Minggu.Location = new System.Drawing.Point(199, 249);
            this.cb2Minggu.Name = "cb2Minggu";
            this.cb2Minggu.Size = new System.Drawing.Size(96, 21);
            this.cb2Minggu.TabIndex = 5;
            this.cb2Minggu.Text = ">2 Minggu";
            this.cb2Minggu.UseVisualStyleBackColor = true;
            // 
            // cb2Hari
            // 
            this.cb2Hari.AutoSize = true;
            this.cb2Hari.Location = new System.Drawing.Point(199, 211);
            this.cb2Hari.Name = "cb2Hari";
            this.cb2Hari.Size = new System.Drawing.Size(81, 21);
            this.cb2Hari.TabIndex = 6;
            this.cb2Hari.Text = "2-3 Hari";
            this.cb2Hari.UseVisualStyleBackColor = true;
            // 
            // cb1Minggu
            // 
            this.cb1Minggu.AutoSize = true;
            this.cb1Minggu.Location = new System.Drawing.Point(63, 249);
            this.cb1Minggu.Name = "cb1Minggu";
            this.cb1Minggu.Size = new System.Drawing.Size(88, 21);
            this.cb1Minggu.TabIndex = 7;
            this.cb1Minggu.Text = "1 Minggu";
            this.cb1Minggu.UseVisualStyleBackColor = true;
            // 
            // rtbKeluhan
            // 
            this.rtbKeluhan.Location = new System.Drawing.Point(63, 324);
            this.rtbKeluhan.Name = "rtbKeluhan";
            this.rtbKeluhan.Size = new System.Drawing.Size(261, 91);
            this.rtbKeluhan.TabIndex = 8;
            this.rtbKeluhan.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Deskripsi Tambahan";
            // 
            // btnInputKeluhan
            // 
            this.btnInputKeluhan.Location = new System.Drawing.Point(63, 434);
            this.btnInputKeluhan.Name = "btnInputKeluhan";
            this.btnInputKeluhan.Size = new System.Drawing.Size(132, 39);
            this.btnInputKeluhan.TabIndex = 10;
            this.btnInputKeluhan.Text = "Input";
            this.btnInputKeluhan.UseVisualStyleBackColor = true;
            this.btnInputKeluhan.Click += new System.EventHandler(this.btnInputKeluhan_Click);
            // 
            // KeluhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.btnInputKeluhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbKeluhan);
            this.Controls.Add(this.cb1Minggu);
            this.Controls.Add(this.cb2Hari);
            this.Controls.Add(this.cb2Minggu);
            this.Controls.Add(this.cb1Hari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKeluhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KeluhanForm";
            this.Text = "KeluhanForm";
            this.Load += new System.EventHandler(this.KeluhanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKeluhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb1Hari;
        private System.Windows.Forms.CheckBox cb2Minggu;
        private System.Windows.Forms.CheckBox cb2Hari;
        private System.Windows.Forms.CheckBox cb1Minggu;
        private System.Windows.Forms.RichTextBox rtbKeluhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInputKeluhan;
    }
}