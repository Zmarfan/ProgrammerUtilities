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
            this.MainTableLayout.SuspendLayout();
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
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Timer CopyTimer;
        private System.Windows.Forms.ColorDialog htmlColorTagPicker;
        private NavigationMenu navigationMenu;
        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.Panel PlayAreaPanel;
    }
}

