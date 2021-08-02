﻿namespace ProgrammerUtils
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.logo = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.info2Label = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.linkPortfolio = new System.Windows.Forms.LinkLabel();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logo.Image = global::ProgrammerUtils.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(203, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(337, 211);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(12, 12);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(185, 211);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Programming Utilities 1.0.0\r\nBuilt for Windows platforms.\r\nVersion 1.0.0.\r\n";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // info2Label
            // 
            this.info2Label.Location = new System.Drawing.Point(12, 226);
            this.info2Label.Name = "info2Label";
            this.info2Label.Size = new System.Drawing.Size(528, 114);
            this.info2Label.TabIndex = 2;
            this.info2Label.Text = resources.GetString("info2Label.Text");
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Location = new System.Drawing.Point(42, 311);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(87, 17);
            this.linkGithub.TabIndex = 3;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "Github Page";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGithub_LinkClicked);
            // 
            // linkPortfolio
            // 
            this.linkPortfolio.AutoSize = true;
            this.linkPortfolio.Location = new System.Drawing.Point(334, 311);
            this.linkPortfolio.Name = "linkPortfolio";
            this.linkPortfolio.Size = new System.Drawing.Size(129, 17);
            this.linkPortfolio.TabIndex = 4;
            this.linkPortfolio.TabStop = true;
            this.linkPortfolio.Text = "Developer Portfolio";
            this.linkPortfolio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPortfolio_LinkClicked);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(460, 339);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(80, 28);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 379);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.linkPortfolio);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.info2Label);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpWindow";
            this.Text = "About Programming Utilities";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label info2Label;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.LinkLabel linkPortfolio;
        private System.Windows.Forms.Button closeButton;
    }
}