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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.SortTab = new System.Windows.Forms.TabPage();
            this.MatchTab = new System.Windows.Forms.TabPage();
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.HelpDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.asdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aasdasdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CountTab = new System.Windows.Forms.TabPage();
            this.htmlTab = new System.Windows.Forms.TabPage();
            this.SortTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sortTextBoxLeft = new System.Windows.Forms.RichTextBox();
            this.sortTextBoxRight = new System.Windows.Forms.RichTextBox();
            this.sortLabel1 = new System.Windows.Forms.Label();
            this.sortLabel2 = new System.Windows.Forms.Label();
            this.MainTableLayout.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SortTab.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.SortTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(this.MainTabControl, 0, 1);
            this.MainTableLayout.Controls.Add(this.Toolbar, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(904, 534);
            this.MainTableLayout.TabIndex = 0;
            // 
            // MainTabControl
            // 
            this.MainTableLayout.SetColumnSpan(this.MainTabControl, 2);
            this.MainTabControl.Controls.Add(this.SortTab);
            this.MainTabControl.Controls.Add(this.MatchTab);
            this.MainTabControl.Controls.Add(this.CountTab);
            this.MainTabControl.Controls.Add(this.htmlTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(3, 33);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(898, 498);
            this.MainTabControl.TabIndex = 0;
            // 
            // SortTab
            // 
            this.SortTab.Controls.Add(this.SortTableLayout);
            this.SortTab.Location = new System.Drawing.Point(4, 25);
            this.SortTab.Name = "SortTab";
            this.SortTab.Padding = new System.Windows.Forms.Padding(3);
            this.SortTab.Size = new System.Drawing.Size(890, 469);
            this.SortTab.TabIndex = 0;
            this.SortTab.Text = "Sort";
            this.SortTab.UseVisualStyleBackColor = true;
            // 
            // MatchTab
            // 
            this.MatchTab.Location = new System.Drawing.Point(4, 25);
            this.MatchTab.Name = "MatchTab";
            this.MatchTab.Padding = new System.Windows.Forms.Padding(3);
            this.MatchTab.Size = new System.Drawing.Size(817, 480);
            this.MatchTab.TabIndex = 1;
            this.MatchTab.Text = "Match";
            this.MatchTab.UseVisualStyleBackColor = true;
            // 
            // Toolbar
            // 
            this.MainTableLayout.SetColumnSpan(this.Toolbar, 2);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Toolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.HelpDropdown});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(904, 30);
            this.Toolbar.TabIndex = 1;
            // 
            // HelpDropdown
            // 
            this.HelpDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdasdToolStripMenuItem,
            this.aasdasdasdToolStripMenuItem});
            this.HelpDropdown.Image = ((System.Drawing.Image)(resources.GetObject("HelpDropdown.Image")));
            this.HelpDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpDropdown.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.HelpDropdown.Name = "HelpDropdown";
            this.HelpDropdown.Size = new System.Drawing.Size(55, 27);
            this.HelpDropdown.Text = "Help";
            // 
            // asdasdToolStripMenuItem
            // 
            this.asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.asdasdToolStripMenuItem.Text = "asdasd";
            // 
            // aasdasdasdToolStripMenuItem
            // 
            this.aasdasdasdToolStripMenuItem.Name = "aasdasdasdToolStripMenuItem";
            this.aasdasdasdToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aasdasdasdToolStripMenuItem.Text = "aasdasdasd";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // CountTab
            // 
            this.CountTab.Location = new System.Drawing.Point(4, 25);
            this.CountTab.Name = "CountTab";
            this.CountTab.Padding = new System.Windows.Forms.Padding(3);
            this.CountTab.Size = new System.Drawing.Size(817, 480);
            this.CountTab.TabIndex = 2;
            this.CountTab.Text = "Count";
            this.CountTab.UseVisualStyleBackColor = true;
            // 
            // htmlTab
            // 
            this.htmlTab.Location = new System.Drawing.Point(4, 25);
            this.htmlTab.Name = "htmlTab";
            this.htmlTab.Padding = new System.Windows.Forms.Padding(3);
            this.htmlTab.Size = new System.Drawing.Size(817, 480);
            this.htmlTab.TabIndex = 3;
            this.htmlTab.Text = "HTML:ify";
            this.htmlTab.UseVisualStyleBackColor = true;
            // 
            // SortTableLayout
            // 
            this.SortTableLayout.ColumnCount = 2;
            this.SortTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SortTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SortTableLayout.Controls.Add(this.sortLabel2, 1, 2);
            this.SortTableLayout.Controls.Add(this.sortTextBoxLeft, 0, 1);
            this.SortTableLayout.Controls.Add(this.sortTextBoxRight, 1, 1);
            this.SortTableLayout.Controls.Add(this.sortLabel1, 0, 2);
            this.SortTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortTableLayout.Location = new System.Drawing.Point(3, 3);
            this.SortTableLayout.Name = "SortTableLayout";
            this.SortTableLayout.RowCount = 3;
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortTableLayout.Size = new System.Drawing.Size(884, 463);
            this.SortTableLayout.TabIndex = 0;
            // 
            // sortTextBoxLeft
            // 
            this.sortTextBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortTextBoxLeft.Location = new System.Drawing.Point(3, 33);
            this.sortTextBoxLeft.Name = "sortTextBoxLeft";
            this.sortTextBoxLeft.Size = new System.Drawing.Size(436, 388);
            this.sortTextBoxLeft.TabIndex = 0;
            this.sortTextBoxLeft.Text = "";
            // 
            // sortTextBoxRight
            // 
            this.sortTextBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortTextBoxRight.Location = new System.Drawing.Point(445, 33);
            this.sortTextBoxRight.Name = "sortTextBoxRight";
            this.sortTextBoxRight.Size = new System.Drawing.Size(436, 388);
            this.sortTextBoxRight.TabIndex = 1;
            this.sortTextBoxRight.Text = "";
            // 
            // sortLabel1
            // 
            this.sortLabel1.AutoSize = true;
            this.sortLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.sortLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortLabel1.Location = new System.Drawing.Point(3, 424);
            this.sortLabel1.Name = "sortLabel1";
            this.sortLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.sortLabel1.Size = new System.Drawing.Size(436, 39);
            this.sortLabel1.TabIndex = 2;
            this.sortLabel1.Text = "Items to sort. Seperate words by commas!";
            this.sortLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortLabel2
            // 
            this.sortLabel2.AutoSize = true;
            this.sortLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.sortLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortLabel2.Location = new System.Drawing.Point(445, 424);
            this.sortLabel2.Name = "sortLabel2";
            this.sortLabel2.Size = new System.Drawing.Size(436, 39);
            this.sortLabel2.TabIndex = 3;
            this.sortLabel2.Text = "Sorted items.";
            this.sortLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(904, 534);
            this.Controls.Add(this.MainTableLayout);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.MinimumSize = new System.Drawing.Size(547, 413);
            this.Name = "Application";
            this.Text = "ProgrammingUtils";
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.SortTab.ResumeLayout(false);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.SortTableLayout.ResumeLayout(false);
            this.SortTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage SortTab;
        private System.Windows.Forms.TabPage MatchTab;
        private System.Windows.Forms.ToolStrip Toolbar;
        private System.Windows.Forms.ToolStripDropDownButton HelpDropdown;
        private System.Windows.Forms.ToolStripMenuItem asdasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aasdasdasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel SortTableLayout;
        private System.Windows.Forms.TabPage CountTab;
        private System.Windows.Forms.TabPage htmlTab;
        private System.Windows.Forms.RichTextBox sortTextBoxLeft;
        private System.Windows.Forms.RichTextBox sortTextBoxRight;
        private System.Windows.Forms.Label sortLabel1;
        private System.Windows.Forms.Label sortLabel2;
    }
}

