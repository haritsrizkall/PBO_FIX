﻿namespace UASPBO
{
    partial class LandingForm
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
            System.Windows.Forms.Button btnSignUp;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = System.Drawing.Color.Black;
            btnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUp.BackgroundImage")));
            btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSignUp.ForeColor = System.Drawing.Color.Transparent;
            btnSignUp.Location = new System.Drawing.Point(249, 480);
            btnSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new System.Drawing.Size(310, 71);
            btnSignUp.TabIndex = 0;
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            btnSignUp.MouseHover += new System.EventHandler(this.btnSignUp_Click);
            // 
            // linkSignIn
            // 
            this.linkSignIn.BackColor = System.Drawing.Color.Transparent;
            this.linkSignIn.DisabledLinkColor = System.Drawing.Color.White;
            this.linkSignIn.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(104)))), ((int)(((byte)(200)))));
            this.linkSignIn.Image = ((System.Drawing.Image)(resources.GetObject("linkSignIn.Image")));
            this.linkSignIn.LinkColor = System.Drawing.Color.Transparent;
            this.linkSignIn.Location = new System.Drawing.Point(486, 452);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(59, 17);
            this.linkSignIn.TabIndex = 1;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "                 ";
            this.linkSignIn.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(104)))), ((int)(((byte)(200)))));
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignIn_LinkClicked);
            this.linkSignIn.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 599);
            this.Controls.Add(this.linkSignIn);
            this.Controls.Add(btnSignUp);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LandingForm";
            this.Text = "LandingForm";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkSignIn;
    }
}