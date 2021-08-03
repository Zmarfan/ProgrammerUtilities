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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.SortTab = new System.Windows.Forms.TabPage();
            this.sortControl1 = new ProgrammerUtils.SortControl();
            this.matchCompareTab = new System.Windows.Forms.TabPage();
            this.compareControl1 = new ProgrammerUtils.CompareControl();
            this.CountTab = new System.Windows.Forms.TabPage();
            this.countControl1 = new ProgrammerUtils.CountControl();
            this.htmlTab = new System.Windows.Forms.TabPage();
            this.htmlControl1 = new ProgrammerUtils.HTMLControl();
            this.generateTextTab = new System.Windows.Forms.TabPage();
            this.navigationMenu = new ProgrammerUtils.NavigationMenu();
            this.CopyTimer = new System.Windows.Forms.Timer(this.components);
            this.htmlColorTagPicker = new System.Windows.Forms.ColorDialog();
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.generateTextControl1 = new ProgrammerUtils.GenerateTextControl();
            this.MainTableLayout.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SortTab.SuspendLayout();
            this.matchCompareTab.SuspendLayout();
            this.CountTab.SuspendLayout();
            this.htmlTab.SuspendLayout();
            this.generateTextTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.MainTabControl, 1, 0);
            this.MainTableLayout.Controls.Add(this.navigationMenu, 0, 0);
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
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.SortTab);
            this.MainTabControl.Controls.Add(this.matchCompareTab);
            this.MainTabControl.Controls.Add(this.CountTab);
            this.MainTabControl.Controls.Add(this.htmlTab);
            this.MainTabControl.Controls.Add(this.generateTextTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(252, 3);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(15, 10);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(696, 538);
            this.MainTabControl.TabIndex = 0;
            // 
            // SortTab
            // 
            this.SortTab.Controls.Add(this.sortControl1);
            this.SortTab.ForeColor = System.Drawing.Color.White;
            this.SortTab.Location = new System.Drawing.Point(4, 39);
            this.SortTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SortTab.Name = "SortTab";
            this.SortTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SortTab.Size = new System.Drawing.Size(688, 495);
            this.SortTab.TabIndex = 0;
            this.SortTab.Text = "Sort";
            // 
            // sortControl1
            // 
            this.sortControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortControl1.Location = new System.Drawing.Point(2, 3);
            this.sortControl1.Margin = new System.Windows.Forms.Padding(0);
            this.sortControl1.Name = "sortControl1";
            this.sortControl1.Size = new System.Drawing.Size(684, 489);
            this.sortControl1.TabIndex = 0;
            // 
            // matchCompareTab
            // 
            this.matchCompareTab.Controls.Add(this.compareControl1);
            this.matchCompareTab.Location = new System.Drawing.Point(4, 39);
            this.matchCompareTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matchCompareTab.Name = "matchCompareTab";
            this.matchCompareTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matchCompareTab.Size = new System.Drawing.Size(688, 495);
            this.matchCompareTab.TabIndex = 1;
            this.matchCompareTab.Text = "Compare";
            this.matchCompareTab.UseVisualStyleBackColor = true;
            // 
            // compareControl1
            // 
            this.compareControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compareControl1.Location = new System.Drawing.Point(2, 3);
            this.compareControl1.Margin = new System.Windows.Forms.Padding(0);
            this.compareControl1.Name = "compareControl1";
            this.compareControl1.Size = new System.Drawing.Size(684, 489);
            this.compareControl1.TabIndex = 0;
            // 
            // CountTab
            // 
            this.CountTab.Controls.Add(this.countControl1);
            this.CountTab.Location = new System.Drawing.Point(4, 39);
            this.CountTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CountTab.Name = "CountTab";
            this.CountTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CountTab.Size = new System.Drawing.Size(688, 495);
            this.CountTab.TabIndex = 2;
            this.CountTab.Text = "Count";
            this.CountTab.UseVisualStyleBackColor = true;
            // 
            // countControl1
            // 
            this.countControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countControl1.Location = new System.Drawing.Point(2, 3);
            this.countControl1.Margin = new System.Windows.Forms.Padding(0);
            this.countControl1.Name = "countControl1";
            this.countControl1.Size = new System.Drawing.Size(684, 489);
            this.countControl1.TabIndex = 0;
            // 
            // htmlTab
            // 
            this.htmlTab.Controls.Add(this.htmlControl1);
            this.htmlTab.Location = new System.Drawing.Point(4, 39);
            this.htmlTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlTab.Name = "htmlTab";
            this.htmlTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlTab.Size = new System.Drawing.Size(688, 495);
            this.htmlTab.TabIndex = 3;
            this.htmlTab.Text = "HTML:ify";
            this.htmlTab.UseVisualStyleBackColor = true;
            // 
            // htmlControl1
            // 
            this.htmlControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlControl1.Location = new System.Drawing.Point(2, 3);
            this.htmlControl1.Margin = new System.Windows.Forms.Padding(0);
            this.htmlControl1.Name = "htmlControl1";
            this.htmlControl1.Size = new System.Drawing.Size(684, 489);
            this.htmlControl1.TabIndex = 0;
            // 
            // generateTextTab
            // 
            this.generateTextTab.Controls.Add(this.generateTextControl1);
            this.generateTextTab.Location = new System.Drawing.Point(4, 39);
            this.generateTextTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateTextTab.Name = "generateTextTab";
            this.generateTextTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateTextTab.Size = new System.Drawing.Size(688, 495);
            this.generateTextTab.TabIndex = 4;
            this.generateTextTab.Text = "Generate Text";
            this.generateTextTab.UseVisualStyleBackColor = true;
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
            // generateTextControl1
            // 
            this.generateTextControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateTextControl1.Location = new System.Drawing.Point(2, 3);
            this.generateTextControl1.Margin = new System.Windows.Forms.Padding(0);
            this.generateTextControl1.Name = "generateTextControl1";
            this.generateTextControl1.Size = new System.Drawing.Size(684, 489);
            this.generateTextControl1.TabIndex = 0;
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
            this.MainTabControl.ResumeLayout(false);
            this.SortTab.ResumeLayout(false);
            this.matchCompareTab.ResumeLayout(false);
            this.CountTab.ResumeLayout(false);
            this.htmlTab.ResumeLayout(false);
            this.generateTextTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage SortTab;
        private System.Windows.Forms.TabPage matchCompareTab;
        private System.Windows.Forms.TabPage CountTab;
        private System.Windows.Forms.TabPage htmlTab;
        private System.Windows.Forms.Timer CopyTimer;
        private System.Windows.Forms.ColorDialog htmlColorTagPicker;
        private System.Windows.Forms.TabPage generateTextTab;
        private NavigationMenu navigationMenu;
        private System.Windows.Forms.Timer FrameTimer;
        private SortControl sortControl1;
        private CompareControl compareControl1;
        private CountControl countControl1;
        private HTMLControl htmlControl1;
        private GenerateTextControl generateTextControl1;
    }
}

