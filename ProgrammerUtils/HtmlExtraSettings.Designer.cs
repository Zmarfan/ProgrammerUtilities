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
            this.OptionsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.htmlCustomRule1 = new ProgrammerUtils.HtmlCustomRule();
            this.mainTableLayout.SuspendLayout();
            this.CustomSettingsFlowLayout.SuspendLayout();
            this.OptionsTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.mainTableLayout.Controls.Add(this.CustomSettingsFlowLayout, 1, 0);
            this.mainTableLayout.Controls.Add(this.OptionsTableLayout, 0, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.Size = new System.Drawing.Size(557, 309);
            this.mainTableLayout.TabIndex = 0;
            // 
            // CustomSettingsFlowLayout
            // 
            this.CustomSettingsFlowLayout.AutoScroll = true;
            this.CustomSettingsFlowLayout.Controls.Add(this.htmlCustomRule1);
            this.CustomSettingsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomSettingsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CustomSettingsFlowLayout.Location = new System.Drawing.Point(133, 3);
            this.CustomSettingsFlowLayout.Name = "CustomSettingsFlowLayout";
            this.mainTableLayout.SetRowSpan(this.CustomSettingsFlowLayout, 2);
            this.CustomSettingsFlowLayout.Size = new System.Drawing.Size(421, 303);
            this.CustomSettingsFlowLayout.TabIndex = 0;
            this.CustomSettingsFlowLayout.WrapContents = false;
            // 
            // OptionsTableLayout
            // 
            this.OptionsTableLayout.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OptionsTableLayout.ColumnCount = 1;
            this.OptionsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsTableLayout.Controls.Add(this.saveAndCloseButton, 0, 2);
            this.OptionsTableLayout.Controls.Add(this.SaveButton, 0, 1);
            this.OptionsTableLayout.Controls.Add(this.AddButton, 0, 0);
            this.OptionsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.OptionsTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.OptionsTableLayout.Name = "OptionsTableLayout";
            this.OptionsTableLayout.Padding = new System.Windows.Forms.Padding(5);
            this.OptionsTableLayout.RowCount = 4;
            this.mainTableLayout.SetRowSpan(this.OptionsTableLayout, 2);
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsTableLayout.Size = new System.Drawing.Size(130, 309);
            this.OptionsTableLayout.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.PaleGreen;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(8, 58);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 44);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(8, 8);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(114, 44);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Rule";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.BackColor = System.Drawing.Color.PaleGreen;
            this.saveAndCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAndCloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAndCloseButton.Location = new System.Drawing.Point(8, 108);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(114, 44);
            this.saveAndCloseButton.TabIndex = 2;
            this.saveAndCloseButton.Text = "Save && Close";
            this.saveAndCloseButton.UseVisualStyleBackColor = false;
            // 
            // htmlCustomRule1
            // 
            this.htmlCustomRule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htmlCustomRule1.Id = 0;
            this.htmlCustomRule1.Location = new System.Drawing.Point(3, 3);
            this.htmlCustomRule1.Name = "htmlCustomRule1";
            this.htmlCustomRule1.Size = new System.Drawing.Size(386, 51);
            this.htmlCustomRule1.TabIndex = 0;
            // 
            // HtmlExtraSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 309);
            this.Controls.Add(this.mainTableLayout);
            this.MaximumSize = new System.Drawing.Size(575, 2000);
            this.MinimumSize = new System.Drawing.Size(575, 356);
            this.Name = "HtmlExtraSettings";
            this.Text = "Html:ify Custom Settings";
            this.TopMost = true;
            this.mainTableLayout.ResumeLayout(false);
            this.CustomSettingsFlowLayout.ResumeLayout(false);
            this.OptionsTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.FlowLayoutPanel CustomSettingsFlowLayout;
        private System.Windows.Forms.TableLayoutPanel OptionsTableLayout;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private HtmlCustomRule htmlCustomRule1;
        private System.Windows.Forms.Button saveAndCloseButton;
    }
}