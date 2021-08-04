namespace ProgrammerUtils
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.linkPortfolio = new System.Windows.Forms.LinkLabel();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.info2Label = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.MainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Location = new System.Drawing.Point(3, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(234, 150);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Programming Utilities 1.0.0\r\nBuilt for Windows platforms.\r\nVersion 1.0.0.\r\n© 2021" +
    " Copyright: Filip Petersson\r\n";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::ProgrammerUtils.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(243, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(234, 144);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(this.closeButton, 1, 5);
            this.MainTableLayout.Controls.Add(this.linkPortfolio, 0, 3);
            this.MainTableLayout.Controls.Add(this.linkGithub, 0, 2);
            this.MainTableLayout.Controls.Add(this.info2Label, 0, 1);
            this.MainTableLayout.Controls.Add(this.infoLabel, 0, 0);
            this.MainTableLayout.Controls.Add(this.logo, 1, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 6;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainTableLayout.Size = new System.Drawing.Size(480, 338);
            this.MainTableLayout.TabIndex = 6;
            // 
            // linkPortfolio
            // 
            this.linkPortfolio.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.linkPortfolio.AutoSize = true;
            this.MainTableLayout.SetColumnSpan(this.linkPortfolio, 2);
            this.linkPortfolio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPortfolio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkPortfolio.LinkArea = new System.Windows.Forms.LinkArea(43, 62);
            this.linkPortfolio.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(175)))), ((int)(((byte)(218)))));
            this.linkPortfolio.Location = new System.Drawing.Point(3, 260);
            this.linkPortfolio.Name = "linkPortfolio";
            this.linkPortfolio.Size = new System.Drawing.Size(474, 35);
            this.linkPortfolio.TabIndex = 5;
            this.linkPortfolio.TabStop = true;
            this.linkPortfolio.Text = "Support and/or contact the developer here: Developer Portfolio";
            this.linkPortfolio.UseCompatibleTextRendering = true;
            this.linkPortfolio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPortfolio_LinkClicked);
            // 
            // linkGithub
            // 
            this.linkGithub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.linkGithub.AutoSize = true;
            this.MainTableLayout.SetColumnSpan(this.linkGithub, 2);
            this.linkGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkGithub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkGithub.LinkArea = new System.Windows.Forms.LinkArea(60, 71);
            this.linkGithub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(175)))), ((int)(((byte)(218)))));
            this.linkGithub.Location = new System.Drawing.Point(3, 225);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(474, 35);
            this.linkGithub.TabIndex = 4;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "Check out the source code and how to use this program here: Github Page";
            this.linkGithub.UseCompatibleTextRendering = true;
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGithub_LinkClicked);
            // 
            // info2Label
            // 
            this.MainTableLayout.SetColumnSpan(this.info2Label, 2);
            this.info2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info2Label.Location = new System.Drawing.Point(3, 150);
            this.info2Label.Name = "info2Label";
            this.info2Label.Size = new System.Drawing.Size(474, 75);
            this.info2Label.TabIndex = 3;
            this.info2Label.Text = resources.GetString("info2Label.Text");
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(243, 291);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(234, 44);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(480, 338);
            this.Controls.Add(this.MainTableLayout);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpWindow";
            this.Text = "About Programming Utilities";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.LinkLabel linkPortfolio;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Label info2Label;
        private System.Windows.Forms.Button closeButton;
    }
}