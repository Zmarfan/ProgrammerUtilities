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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HtmlExtraSettings));
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CustomSettingsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.OptionsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SavingInfoLabel = new System.Windows.Forms.Label();
            this.displaySaveTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTableLayout.SuspendLayout();
            this.OptionsTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 398F));
            this.mainTableLayout.Controls.Add(this.CustomSettingsFlowLayout, 1, 0);
            this.mainTableLayout.Controls.Add(this.OptionsTableLayout, 0, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.Size = new System.Drawing.Size(512, 356);
            this.mainTableLayout.TabIndex = 0;
            // 
            // CustomSettingsFlowLayout
            // 
            this.CustomSettingsFlowLayout.AutoScroll = true;
            this.CustomSettingsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomSettingsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CustomSettingsFlowLayout.Location = new System.Drawing.Point(117, 3);
            this.CustomSettingsFlowLayout.Name = "CustomSettingsFlowLayout";
            this.mainTableLayout.SetRowSpan(this.CustomSettingsFlowLayout, 2);
            this.CustomSettingsFlowLayout.Size = new System.Drawing.Size(392, 350);
            this.CustomSettingsFlowLayout.TabIndex = 0;
            this.CustomSettingsFlowLayout.WrapContents = false;
            // 
            // OptionsTableLayout
            // 
            this.OptionsTableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.OptionsTableLayout.ColumnCount = 1;
            this.OptionsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsTableLayout.Controls.Add(this.CloseButton, 0, 3);
            this.OptionsTableLayout.Controls.Add(this.saveAndCloseButton, 0, 2);
            this.OptionsTableLayout.Controls.Add(this.SaveButton, 0, 1);
            this.OptionsTableLayout.Controls.Add(this.AddButton, 0, 0);
            this.OptionsTableLayout.Controls.Add(this.SavingInfoLabel, 0, 4);
            this.OptionsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.OptionsTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.OptionsTableLayout.Name = "OptionsTableLayout";
            this.OptionsTableLayout.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OptionsTableLayout.RowCount = 5;
            this.mainTableLayout.SetRowSpan(this.OptionsTableLayout, 2);
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsTableLayout.Size = new System.Drawing.Size(114, 356);
            this.OptionsTableLayout.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(7, 158);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 44);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close Without Saving";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.saveAndCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAndCloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveAndCloseButton.FlatAppearance.BorderSize = 0;
            this.saveAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAndCloseButton.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAndCloseButton.ForeColor = System.Drawing.Color.White;
            this.saveAndCloseButton.Location = new System.Drawing.Point(7, 108);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(100, 44);
            this.saveAndCloseButton.TabIndex = 2;
            this.saveAndCloseButton.Text = "Save && Close";
            this.saveAndCloseButton.UseVisualStyleBackColor = false;
            this.saveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(7, 58);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 44);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(7, 8);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 44);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Rule";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SavingInfoLabel
            // 
            this.SavingInfoLabel.AutoSize = true;
            this.SavingInfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SavingInfoLabel.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.SavingInfoLabel.Location = new System.Drawing.Point(7, 205);
            this.SavingInfoLabel.Name = "SavingInfoLabel";
            this.SavingInfoLabel.Size = new System.Drawing.Size(100, 13);
            this.SavingInfoLabel.TabIndex = 3;
            this.SavingInfoLabel.Text = "Saving info Text";
            this.SavingInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displaySaveTimer
            // 
            this.displaySaveTimer.Interval = 5500;
            this.displaySaveTimer.Tick += new System.EventHandler(this.DisplaySaveTimer_Tick);
            // 
            // HtmlExtraSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(512, 356);
            this.Controls.Add(this.mainTableLayout);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(530, 2000);
            this.MinimumSize = new System.Drawing.Size(530, 356);
            this.Name = "HtmlExtraSettings";
            this.Text = "Html:ify Custom Rules";
            this.mainTableLayout.ResumeLayout(false);
            this.OptionsTableLayout.ResumeLayout(false);
            this.OptionsTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.FlowLayoutPanel CustomSettingsFlowLayout;
        private System.Windows.Forms.TableLayoutPanel OptionsTableLayout;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button saveAndCloseButton;
        private System.Windows.Forms.Label SavingInfoLabel;
        private System.Windows.Forms.Timer displaySaveTimer;
        private System.Windows.Forms.Button CloseButton;
    }
}