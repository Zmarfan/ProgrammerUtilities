namespace ProgrammerUtils
{
    partial class HtmlExtraSettings
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
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CustomSettingsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.htmlCustomRule1 = new ProgrammerUtils.HtmlCustomRule();
            this.htmlCustomRule2 = new ProgrammerUtils.HtmlCustomRule();
            this.htmlCustomRule3 = new ProgrammerUtils.HtmlCustomRule();
            this.mainTableLayout.SuspendLayout();
            this.CustomSettingsFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.Controls.Add(this.CustomSettingsFlowLayout, 1, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.Size = new System.Drawing.Size(836, 450);
            this.mainTableLayout.TabIndex = 0;
            // 
            // CustomSettingsFlowLayout
            // 
            this.CustomSettingsFlowLayout.AutoScroll = true;
            this.CustomSettingsFlowLayout.Controls.Add(this.htmlCustomRule1);
            this.CustomSettingsFlowLayout.Controls.Add(this.htmlCustomRule2);
            this.CustomSettingsFlowLayout.Controls.Add(this.htmlCustomRule3);
            this.CustomSettingsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomSettingsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CustomSettingsFlowLayout.Location = new System.Drawing.Point(421, 3);
            this.CustomSettingsFlowLayout.Name = "CustomSettingsFlowLayout";
            this.mainTableLayout.SetRowSpan(this.CustomSettingsFlowLayout, 2);
            this.CustomSettingsFlowLayout.Size = new System.Drawing.Size(412, 444);
            this.CustomSettingsFlowLayout.TabIndex = 0;
            this.CustomSettingsFlowLayout.WrapContents = false;
            // 
            // htmlCustomRule1
            // 
            this.htmlCustomRule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htmlCustomRule1.Location = new System.Drawing.Point(3, 3);
            this.htmlCustomRule1.Name = "htmlCustomRule1";
            this.htmlCustomRule1.Size = new System.Drawing.Size(386, 51);
            this.htmlCustomRule1.TabIndex = 0;
            // 
            // htmlCustomRule2
            // 
            this.htmlCustomRule2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htmlCustomRule2.Location = new System.Drawing.Point(3, 60);
            this.htmlCustomRule2.Name = "htmlCustomRule2";
            this.htmlCustomRule2.Size = new System.Drawing.Size(386, 51);
            this.htmlCustomRule2.TabIndex = 1;
            // 
            // htmlCustomRule3
            // 
            this.htmlCustomRule3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htmlCustomRule3.Location = new System.Drawing.Point(3, 117);
            this.htmlCustomRule3.Name = "htmlCustomRule3";
            this.htmlCustomRule3.Size = new System.Drawing.Size(386, 51);
            this.htmlCustomRule3.TabIndex = 2;
            // 
            // HtmlExtraSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.mainTableLayout);
            this.Name = "HtmlExtraSettings";
            this.Text = "Html:ify Custom Settings";
            this.TopMost = true;
            this.mainTableLayout.ResumeLayout(false);
            this.CustomSettingsFlowLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.FlowLayoutPanel CustomSettingsFlowLayout;
        private HtmlCustomRule htmlCustomRule1;
        private HtmlCustomRule htmlCustomRule2;
        private HtmlCustomRule htmlCustomRule3;
    }
}