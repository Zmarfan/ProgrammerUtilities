namespace ProgrammerUtils
{
    partial class Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PlayAreaPanel = new System.Windows.Forms.Panel();
            this.CopyTimer = new System.Windows.Forms.Timer(this.components);
            this.htmlColorTagPicker = new System.Windows.Forms.ColorDialog();
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.navigationMenu = new ProgrammerUtils.NavigationMenu();
            this.ImprovedTabsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TabsPanel = new System.Windows.Forms.Panel();
            this.sortTextBoxRight = new System.Windows.Forms.RichTextBox();
            this.sortEnumTextBoxRight = new System.Windows.Forms.RichTextBox();
            this.TabsHeader = new System.Windows.Forms.TableLayoutPanel();
            this.ListButton = new System.Windows.Forms.Button();
            this.EnumButton = new System.Windows.Forms.Button();
            this.TabsBorderPanel = new ProgrammerUtils.BorderPanel();
            this.MainTableLayout.SuspendLayout();
            this.PlayAreaPanel.SuspendLayout();
            this.ImprovedTabsTableLayout.SuspendLayout();
            this.TabsPanel.SuspendLayout();
            this.TabsHeader.SuspendLayout();
            this.TabsBorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.navigationMenu, 0, 0);
            this.MainTableLayout.Controls.Add(this.PlayAreaPanel, 1, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 1;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 544F));
            this.MainTableLayout.Size = new System.Drawing.Size(950, 544);
            this.MainTableLayout.TabIndex = 0;
            // 
            // PlayAreaPanel
            // 
            this.PlayAreaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.PlayAreaPanel.Controls.Add(this.TabsBorderPanel);
            this.PlayAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayAreaPanel.Location = new System.Drawing.Point(250, 0);
            this.PlayAreaPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PlayAreaPanel.Name = "PlayAreaPanel";
            this.PlayAreaPanel.Padding = new System.Windows.Forms.Padding(5);
            this.PlayAreaPanel.Size = new System.Drawing.Size(700, 544);
            this.PlayAreaPanel.TabIndex = 2;
            // 
            // CopyTimer
            // 
            this.CopyTimer.Interval = 1500;
            // 
            // htmlColorTagPicker
            // 
            this.htmlColorTagPicker.FullOpen = true;
            this.htmlColorTagPicker.SolidColorOnly = true;
            // 
            // FrameTimer
            // 
            this.FrameTimer.Interval = 20;
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // navigationMenu
            // 
            this.navigationMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationMenu.Location = new System.Drawing.Point(0, 0);
            this.navigationMenu.Margin = new System.Windows.Forms.Padding(0);
            this.navigationMenu.Name = "navigationMenu";
            this.navigationMenu.Size = new System.Drawing.Size(250, 544);
            this.navigationMenu.TabIndex = 1;
            // 
            // ImprovedTabsTableLayout
            // 
            this.ImprovedTabsTableLayout.ColumnCount = 1;
            this.ImprovedTabsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ImprovedTabsTableLayout.Controls.Add(this.TabsHeader, 0, 0);
            this.ImprovedTabsTableLayout.Controls.Add(this.TabsPanel, 0, 1);
            this.ImprovedTabsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImprovedTabsTableLayout.Location = new System.Drawing.Point(5, 5);
            this.ImprovedTabsTableLayout.Name = "ImprovedTabsTableLayout";
            this.ImprovedTabsTableLayout.RowCount = 2;
            this.ImprovedTabsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ImprovedTabsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ImprovedTabsTableLayout.Size = new System.Drawing.Size(680, 524);
            this.ImprovedTabsTableLayout.TabIndex = 1;
            // 
            // TabsPanel
            // 
            this.TabsPanel.Controls.Add(this.sortEnumTextBoxRight);
            this.TabsPanel.Controls.Add(this.sortTextBoxRight);
            this.TabsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsPanel.Location = new System.Drawing.Point(0, 35);
            this.TabsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TabsPanel.Name = "TabsPanel";
            this.TabsPanel.Size = new System.Drawing.Size(680, 489);
            this.TabsPanel.TabIndex = 1;
            // 
            // sortTextBoxRight
            // 
            this.sortTextBoxRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.sortTextBoxRight.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortTextBoxRight.Location = new System.Drawing.Point(0, 0);
            this.sortTextBoxRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortTextBoxRight.Name = "sortTextBoxRight";
            this.sortTextBoxRight.ReadOnly = true;
            this.sortTextBoxRight.Size = new System.Drawing.Size(332, 489);
            this.sortTextBoxRight.TabIndex = 1;
            this.sortTextBoxRight.Text = "";
            // 
            // sortEnumTextBoxRight
            // 
            this.sortEnumTextBoxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.sortEnumTextBoxRight.Location = new System.Drawing.Point(336, 0);
            this.sortEnumTextBoxRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortEnumTextBoxRight.Name = "sortEnumTextBoxRight";
            this.sortEnumTextBoxRight.ReadOnly = true;
            this.sortEnumTextBoxRight.Size = new System.Drawing.Size(344, 489);
            this.sortEnumTextBoxRight.TabIndex = 3;
            this.sortEnumTextBoxRight.Text = "";
            // 
            // TabsHeader
            // 
            this.TabsHeader.ColumnCount = 3;
            this.TabsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.TabsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.TabsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabsHeader.Controls.Add(this.EnumButton, 1, 0);
            this.TabsHeader.Controls.Add(this.ListButton, 0, 0);
            this.TabsHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsHeader.Location = new System.Drawing.Point(3, 3);
            this.TabsHeader.Name = "TabsHeader";
            this.TabsHeader.RowCount = 1;
            this.TabsHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabsHeader.Size = new System.Drawing.Size(674, 29);
            this.TabsHeader.TabIndex = 0;
            // 
            // ListButton
            // 
            this.ListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListButton.FlatAppearance.BorderSize = 0;
            this.ListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListButton.Location = new System.Drawing.Point(3, 3);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(69, 23);
            this.ListButton.TabIndex = 0;
            this.ListButton.Text = "List";
            this.ListButton.UseVisualStyleBackColor = false;
            // 
            // EnumButton
            // 
            this.EnumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.EnumButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumButton.FlatAppearance.BorderSize = 0;
            this.EnumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnumButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EnumButton.Location = new System.Drawing.Point(78, 3);
            this.EnumButton.Name = "EnumButton";
            this.EnumButton.Size = new System.Drawing.Size(69, 23);
            this.EnumButton.TabIndex = 1;
            this.EnumButton.Text = "Enum";
            this.EnumButton.UseVisualStyleBackColor = false;
            // 
            // TabsBorderPanel
            // 
            this.TabsBorderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.TabsBorderPanel.BorderWidth = 2;
            this.TabsBorderPanel.Controls.Add(this.ImprovedTabsTableLayout);
            this.TabsBorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsBorderPanel.Location = new System.Drawing.Point(5, 5);
            this.TabsBorderPanel.Margin = new System.Windows.Forms.Padding(5);
            this.TabsBorderPanel.Name = "TabsBorderPanel";
            this.TabsBorderPanel.Padding = new System.Windows.Forms.Padding(5);
            this.TabsBorderPanel.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.TabsBorderPanel.Size = new System.Drawing.Size(690, 534);
            this.TabsBorderPanel.TabIndex = 0;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 544);
            this.Controls.Add(this.MainTableLayout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(783, 528);
            this.Name = "Application";
            this.Text = "ProgrammingUtils";
            this.MainTableLayout.ResumeLayout(false);
            this.PlayAreaPanel.ResumeLayout(false);
            this.ImprovedTabsTableLayout.ResumeLayout(false);
            this.TabsPanel.ResumeLayout(false);
            this.TabsHeader.ResumeLayout(false);
            this.TabsBorderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Timer CopyTimer;
        private System.Windows.Forms.ColorDialog htmlColorTagPicker;
        private NavigationMenu navigationMenu;
        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.Panel PlayAreaPanel;
        private BorderPanel TabsBorderPanel;
        private System.Windows.Forms.TableLayoutPanel ImprovedTabsTableLayout;
        private System.Windows.Forms.TableLayoutPanel TabsHeader;
        private System.Windows.Forms.Button EnumButton;
        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Panel TabsPanel;
        private System.Windows.Forms.RichTextBox sortEnumTextBoxRight;
        private System.Windows.Forms.RichTextBox sortTextBoxRight;
    }
}

