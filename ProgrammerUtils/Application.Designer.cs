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
            this.SortTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sortLabel2 = new System.Windows.Forms.Label();
            this.sortTextBoxLeft = new System.Windows.Forms.RichTextBox();
            this.sortTextBoxRight = new System.Windows.Forms.RichTextBox();
            this.sortLabel1 = new System.Windows.Forms.Label();
            this.sortHeader = new System.Windows.Forms.TableLayoutPanel();
            this.SortButton = new System.Windows.Forms.Button();
            this.AutoSortCheckbox = new System.Windows.Forms.CheckBox();
            this.sortModeTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sortAlphabeticlyRadio = new System.Windows.Forms.RadioButton();
            this.notSortAlphabeticlyRadio = new System.Windows.Forms.RadioButton();
            this.sortStyleTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sortSeperatorCommaRadio = new System.Windows.Forms.RadioButton();
            this.sortSeperatorNewLineRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sortCopyButton = new System.Windows.Forms.Button();
            this.SortClearButton = new System.Windows.Forms.Button();
            this.SortTextPresentationButton = new System.Windows.Forms.Button();
            this.SortChangeTextCapsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SortExportDropdown = new System.Windows.Forms.ComboBox();
            this.SortExportEnumButton = new System.Windows.Forms.Button();
            this.SortCopyNotice = new System.Windows.Forms.Label();
            this.MatchTab = new System.Windows.Forms.TabPage();
            this.CountTab = new System.Windows.Forms.TabPage();
            this.htmlTab = new System.Windows.Forms.TabPage();
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.asdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aasdasdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTimer = new System.Windows.Forms.Timer(this.components);
            this.SortEnumOptionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SortEnumClassName = new System.Windows.Forms.TextBox();
            this.SortEnumClassNameStatus = new System.Windows.Forms.Label();
            this.MainTableLayout.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SortTab.SuspendLayout();
            this.SortTableLayout.SuspendLayout();
            this.sortHeader.SuspendLayout();
            this.sortModeTableLayout.SuspendLayout();
            this.sortStyleTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.SortEnumOptionTableLayout.SuspendLayout();
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
            this.MainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(924, 543);
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
            this.MainTabControl.Size = new System.Drawing.Size(918, 507);
            this.MainTabControl.TabIndex = 0;
            // 
            // SortTab
            // 
            this.SortTab.Controls.Add(this.SortTableLayout);
            this.SortTab.Location = new System.Drawing.Point(4, 25);
            this.SortTab.Name = "SortTab";
            this.SortTab.Padding = new System.Windows.Forms.Padding(3);
            this.SortTab.Size = new System.Drawing.Size(910, 478);
            this.SortTab.TabIndex = 0;
            this.SortTab.Text = "Sort";
            this.SortTab.UseVisualStyleBackColor = true;
            // 
            // SortTableLayout
            // 
            this.SortTableLayout.ColumnCount = 3;
            this.SortTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SortTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SortTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.SortTableLayout.Controls.Add(this.sortLabel2, 1, 3);
            this.SortTableLayout.Controls.Add(this.sortTextBoxLeft, 0, 1);
            this.SortTableLayout.Controls.Add(this.sortTextBoxRight, 1, 1);
            this.SortTableLayout.Controls.Add(this.sortLabel1, 0, 3);
            this.SortTableLayout.Controls.Add(this.sortHeader, 0, 0);
            this.SortTableLayout.Controls.Add(this.tableLayoutPanel1, 2, 1);
            this.SortTableLayout.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.SortTableLayout.Controls.Add(this.SortCopyNotice, 2, 0);
            this.SortTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortTableLayout.Location = new System.Drawing.Point(3, 3);
            this.SortTableLayout.Name = "SortTableLayout";
            this.SortTableLayout.RowCount = 4;
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortTableLayout.Size = new System.Drawing.Size(904, 472);
            this.SortTableLayout.TabIndex = 0;
            // 
            // sortLabel2
            // 
            this.sortLabel2.AutoSize = true;
            this.sortLabel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sortLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortLabel2.Location = new System.Drawing.Point(423, 433);
            this.sortLabel2.Name = "sortLabel2";
            this.sortLabel2.Size = new System.Drawing.Size(414, 39);
            this.sortLabel2.TabIndex = 3;
            this.sortLabel2.Text = "Sorted items.";
            this.sortLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortTextBoxLeft
            // 
            this.sortTextBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortTextBoxLeft.Location = new System.Drawing.Point(3, 55);
            this.sortTextBoxLeft.Name = "sortTextBoxLeft";
            this.SortTableLayout.SetRowSpan(this.sortTextBoxLeft, 2);
            this.sortTextBoxLeft.Size = new System.Drawing.Size(414, 375);
            this.sortTextBoxLeft.TabIndex = 0;
            this.sortTextBoxLeft.Text = "Sverige, Danmark, Finland, Ryssland, Spanien, Tyskland, Polen, Egypten\nEstland\nIs" +
    "land\nJapan, China Hong Kong, Iran Irak";
            this.sortTextBoxLeft.TextChanged += new System.EventHandler(this.SortTextChanged);
            // 
            // sortTextBoxRight
            // 
            this.sortTextBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortTextBoxRight.Location = new System.Drawing.Point(423, 55);
            this.sortTextBoxRight.Name = "sortTextBoxRight";
            this.sortTextBoxRight.ReadOnly = true;
            this.sortTextBoxRight.Size = new System.Drawing.Size(414, 315);
            this.sortTextBoxRight.TabIndex = 1;
            this.sortTextBoxRight.Text = "";
            // 
            // sortLabel1
            // 
            this.sortLabel1.AutoSize = true;
            this.sortLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sortLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortLabel1.Location = new System.Drawing.Point(3, 433);
            this.sortLabel1.Name = "sortLabel1";
            this.sortLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.sortLabel1.Size = new System.Drawing.Size(414, 39);
            this.sortLabel1.TabIndex = 2;
            this.sortLabel1.Text = "Items to sort. Separate entries by commas or new lines!";
            this.sortLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortHeader
            // 
            this.sortHeader.ColumnCount = 4;
            this.SortTableLayout.SetColumnSpan(this.sortHeader, 2);
            this.sortHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.sortHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.sortHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.sortHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.sortHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sortHeader.Controls.Add(this.SortButton, 0, 0);
            this.sortHeader.Controls.Add(this.AutoSortCheckbox, 1, 0);
            this.sortHeader.Controls.Add(this.sortModeTableLayout, 2, 0);
            this.sortHeader.Controls.Add(this.sortStyleTableLayout, 2, 1);
            this.sortHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortHeader.Location = new System.Drawing.Point(0, 0);
            this.sortHeader.Margin = new System.Windows.Forms.Padding(0);
            this.sortHeader.Name = "sortHeader";
            this.sortHeader.RowCount = 2;
            this.sortHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sortHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sortHeader.Size = new System.Drawing.Size(840, 52);
            this.sortHeader.TabIndex = 4;
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.Location = new System.Drawing.Point(3, 3);
            this.SortButton.Name = "SortButton";
            this.sortHeader.SetRowSpan(this.SortButton, 2);
            this.SortButton.Size = new System.Drawing.Size(194, 46);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // AutoSortCheckbox
            // 
            this.AutoSortCheckbox.AutoSize = true;
            this.AutoSortCheckbox.Checked = true;
            this.AutoSortCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoSortCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoSortCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoSortCheckbox.Location = new System.Drawing.Point(203, 3);
            this.AutoSortCheckbox.Name = "AutoSortCheckbox";
            this.sortHeader.SetRowSpan(this.AutoSortCheckbox, 2);
            this.AutoSortCheckbox.Size = new System.Drawing.Size(89, 46);
            this.AutoSortCheckbox.TabIndex = 1;
            this.AutoSortCheckbox.Text = "Auto Sort";
            this.AutoSortCheckbox.UseVisualStyleBackColor = true;
            this.AutoSortCheckbox.CheckedChanged += new System.EventHandler(this.AutoSortCheckbox_CheckedChanged);
            // 
            // sortModeTableLayout
            // 
            this.sortModeTableLayout.ColumnCount = 2;
            this.sortModeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sortModeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sortModeTableLayout.Controls.Add(this.sortAlphabeticlyRadio, 0, 0);
            this.sortModeTableLayout.Controls.Add(this.notSortAlphabeticlyRadio, 1, 0);
            this.sortModeTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortModeTableLayout.Location = new System.Drawing.Point(295, 0);
            this.sortModeTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.sortModeTableLayout.Name = "sortModeTableLayout";
            this.sortModeTableLayout.RowCount = 1;
            this.sortModeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sortModeTableLayout.Size = new System.Drawing.Size(350, 26);
            this.sortModeTableLayout.TabIndex = 4;
            // 
            // sortAlphabeticlyRadio
            // 
            this.sortAlphabeticlyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sortAlphabeticlyRadio.AutoSize = true;
            this.sortAlphabeticlyRadio.Checked = true;
            this.sortAlphabeticlyRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortAlphabeticlyRadio.Location = new System.Drawing.Point(3, 3);
            this.sortAlphabeticlyRadio.Name = "sortAlphabeticlyRadio";
            this.sortAlphabeticlyRadio.Size = new System.Drawing.Size(116, 20);
            this.sortAlphabeticlyRadio.TabIndex = 2;
            this.sortAlphabeticlyRadio.TabStop = true;
            this.sortAlphabeticlyRadio.Text = "Alphabetically";
            this.sortAlphabeticlyRadio.UseVisualStyleBackColor = true;
            this.sortAlphabeticlyRadio.CheckedChanged += new System.EventHandler(this.SortStyleChanged);
            // 
            // notSortAlphabeticlyRadio
            // 
            this.notSortAlphabeticlyRadio.AutoSize = true;
            this.notSortAlphabeticlyRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notSortAlphabeticlyRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notSortAlphabeticlyRadio.Location = new System.Drawing.Point(178, 3);
            this.notSortAlphabeticlyRadio.Name = "notSortAlphabeticlyRadio";
            this.notSortAlphabeticlyRadio.Size = new System.Drawing.Size(169, 20);
            this.notSortAlphabeticlyRadio.TabIndex = 3;
            this.notSortAlphabeticlyRadio.Text = "Reverse";
            this.notSortAlphabeticlyRadio.UseVisualStyleBackColor = true;
            this.notSortAlphabeticlyRadio.CheckedChanged += new System.EventHandler(this.SortStyleChanged);
            // 
            // sortStyleTableLayout
            // 
            this.sortStyleTableLayout.ColumnCount = 2;
            this.sortStyleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sortStyleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sortStyleTableLayout.Controls.Add(this.sortSeperatorCommaRadio, 0, 0);
            this.sortStyleTableLayout.Controls.Add(this.sortSeperatorNewLineRadio, 1, 0);
            this.sortStyleTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortStyleTableLayout.Location = new System.Drawing.Point(295, 26);
            this.sortStyleTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.sortStyleTableLayout.Name = "sortStyleTableLayout";
            this.sortStyleTableLayout.RowCount = 1;
            this.sortStyleTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sortStyleTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.sortStyleTableLayout.Size = new System.Drawing.Size(350, 26);
            this.sortStyleTableLayout.TabIndex = 5;
            // 
            // sortSeperatorCommaRadio
            // 
            this.sortSeperatorCommaRadio.AutoSize = true;
            this.sortSeperatorCommaRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortSeperatorCommaRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortSeperatorCommaRadio.Location = new System.Drawing.Point(3, 3);
            this.sortSeperatorCommaRadio.Name = "sortSeperatorCommaRadio";
            this.sortSeperatorCommaRadio.Size = new System.Drawing.Size(169, 20);
            this.sortSeperatorCommaRadio.TabIndex = 0;
            this.sortSeperatorCommaRadio.TabStop = true;
            this.sortSeperatorCommaRadio.Text = "Comma seperated";
            this.sortSeperatorCommaRadio.UseVisualStyleBackColor = true;
            this.sortSeperatorCommaRadio.CheckedChanged += new System.EventHandler(this.SortDisplayModeChange);
            // 
            // sortSeperatorNewLineRadio
            // 
            this.sortSeperatorNewLineRadio.AutoSize = true;
            this.sortSeperatorNewLineRadio.Checked = true;
            this.sortSeperatorNewLineRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortSeperatorNewLineRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortSeperatorNewLineRadio.Location = new System.Drawing.Point(178, 3);
            this.sortSeperatorNewLineRadio.Name = "sortSeperatorNewLineRadio";
            this.sortSeperatorNewLineRadio.Size = new System.Drawing.Size(169, 20);
            this.sortSeperatorNewLineRadio.TabIndex = 1;
            this.sortSeperatorNewLineRadio.TabStop = true;
            this.sortSeperatorNewLineRadio.Text = "New line seperated";
            this.sortSeperatorNewLineRadio.UseVisualStyleBackColor = true;
            this.sortSeperatorNewLineRadio.CheckedChanged += new System.EventHandler(this.SortDisplayModeChange);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.sortCopyButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SortClearButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SortTextPresentationButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SortChangeTextCapsButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(840, 52);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(64, 321);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // sortCopyButton
            // 
            this.sortCopyButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.sortCopyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortCopyButton.BackgroundImage")));
            this.sortCopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortCopyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortCopyButton.Location = new System.Drawing.Point(3, 123);
            this.sortCopyButton.Name = "sortCopyButton";
            this.sortCopyButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.sortCopyButton.Size = new System.Drawing.Size(58, 54);
            this.sortCopyButton.TabIndex = 8;
            this.sortCopyButton.UseVisualStyleBackColor = false;
            this.sortCopyButton.Click += new System.EventHandler(this.sortCopyButton_Click);
            // 
            // SortClearButton
            // 
            this.SortClearButton.AutoSize = true;
            this.SortClearButton.BackColor = System.Drawing.Color.LightPink;
            this.SortClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortClearButton.Location = new System.Drawing.Point(3, 183);
            this.SortClearButton.Name = "SortClearButton";
            this.SortClearButton.Size = new System.Drawing.Size(58, 54);
            this.SortClearButton.TabIndex = 7;
            this.SortClearButton.Text = "Clear";
            this.SortClearButton.UseVisualStyleBackColor = false;
            this.SortClearButton.Click += new System.EventHandler(this.SortClearButton_Click);
            // 
            // SortTextPresentationButton
            // 
            this.SortTextPresentationButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SortTextPresentationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortTextPresentationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortTextPresentationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortTextPresentationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortTextPresentationButton.Location = new System.Drawing.Point(3, 63);
            this.SortTextPresentationButton.Name = "SortTextPresentationButton";
            this.SortTextPresentationButton.Size = new System.Drawing.Size(58, 54);
            this.SortTextPresentationButton.TabIndex = 1;
            this.SortTextPresentationButton.Text = "A_B";
            this.SortTextPresentationButton.UseVisualStyleBackColor = false;
            this.SortTextPresentationButton.Click += new System.EventHandler(this.SortTextPresentationButton_Click);
            // 
            // SortChangeTextCapsButton
            // 
            this.SortChangeTextCapsButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SortChangeTextCapsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortChangeTextCapsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortChangeTextCapsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortChangeTextCapsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortChangeTextCapsButton.Location = new System.Drawing.Point(3, 3);
            this.SortChangeTextCapsButton.Name = "SortChangeTextCapsButton";
            this.SortChangeTextCapsButton.Size = new System.Drawing.Size(58, 54);
            this.SortChangeTextCapsButton.TabIndex = 0;
            this.SortChangeTextCapsButton.Text = "ABC";
            this.SortChangeTextCapsButton.UseVisualStyleBackColor = false;
            this.SortChangeTextCapsButton.Click += new System.EventHandler(this.SortChangeTextCapsButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.SortExportDropdown, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SortExportEnumButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SortEnumOptionTableLayout, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(423, 376);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(414, 54);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // SortExportDropdown
            // 
            this.SortExportDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortExportDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortExportDropdown.FormattingEnabled = true;
            this.SortExportDropdown.Items.AddRange(new object[] {
            "Java",
            "C#",
            "Typescript"});
            this.SortExportDropdown.Location = new System.Drawing.Point(3, 30);
            this.SortExportDropdown.Name = "SortExportDropdown";
            this.SortExportDropdown.Size = new System.Drawing.Size(304, 24);
            this.SortExportDropdown.TabIndex = 0;
            // 
            // SortExportEnumButton
            // 
            this.SortExportEnumButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.SortExportEnumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortExportEnumButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortExportEnumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortExportEnumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortExportEnumButton.Location = new System.Drawing.Point(313, 3);
            this.SortExportEnumButton.Name = "SortExportEnumButton";
            this.tableLayoutPanel2.SetRowSpan(this.SortExportEnumButton, 2);
            this.SortExportEnumButton.Size = new System.Drawing.Size(98, 48);
            this.SortExportEnumButton.TabIndex = 2;
            this.SortExportEnumButton.Text = "Copy as Enum";
            this.SortExportEnumButton.UseVisualStyleBackColor = false;
            this.SortExportEnumButton.Click += new System.EventHandler(this.SortExportEnumButton_Click);
            // 
            // SortCopyNotice
            // 
            this.SortCopyNotice.AutoSize = true;
            this.SortCopyNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortCopyNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortCopyNotice.ForeColor = System.Drawing.Color.Green;
            this.SortCopyNotice.Location = new System.Drawing.Point(843, 0);
            this.SortCopyNotice.Name = "SortCopyNotice";
            this.SortCopyNotice.Size = new System.Drawing.Size(58, 52);
            this.SortCopyNotice.TabIndex = 7;
            this.SortCopyNotice.Text = "Copied!";
            this.SortCopyNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MatchTab
            // 
            this.MatchTab.Location = new System.Drawing.Point(4, 25);
            this.MatchTab.Name = "MatchTab";
            this.MatchTab.Padding = new System.Windows.Forms.Padding(3);
            this.MatchTab.Size = new System.Drawing.Size(910, 478);
            this.MatchTab.TabIndex = 1;
            this.MatchTab.Text = "Match";
            this.MatchTab.UseVisualStyleBackColor = true;
            // 
            // CountTab
            // 
            this.CountTab.Location = new System.Drawing.Point(4, 25);
            this.CountTab.Name = "CountTab";
            this.CountTab.Padding = new System.Windows.Forms.Padding(3);
            this.CountTab.Size = new System.Drawing.Size(910, 478);
            this.CountTab.TabIndex = 2;
            this.CountTab.Text = "Count";
            this.CountTab.UseVisualStyleBackColor = true;
            // 
            // htmlTab
            // 
            this.htmlTab.Location = new System.Drawing.Point(4, 25);
            this.htmlTab.Name = "htmlTab";
            this.htmlTab.Padding = new System.Windows.Forms.Padding(3);
            this.htmlTab.Size = new System.Drawing.Size(910, 478);
            this.htmlTab.TabIndex = 3;
            this.htmlTab.Text = "HTML:ify";
            this.htmlTab.UseVisualStyleBackColor = true;
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
            this.Toolbar.Size = new System.Drawing.Size(924, 30);
            this.Toolbar.TabIndex = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
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
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.asdasdToolStripMenuItem.Text = "asdasd";
            // 
            // aasdasdasdToolStripMenuItem
            // 
            this.aasdasdasdToolStripMenuItem.Name = "aasdasdasdToolStripMenuItem";
            this.aasdasdasdToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.aasdasdasdToolStripMenuItem.Text = "aasdasdasd";
            // 
            // copyTimer
            // 
            this.copyTimer.Interval = 2500;
            this.copyTimer.Tick += new System.EventHandler(this.copyTimer_Tick);
            // 
            // SortEnumOptionTableLayout
            // 
            this.SortEnumOptionTableLayout.ColumnCount = 2;
            this.SortEnumOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.SortEnumOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SortEnumOptionTableLayout.Controls.Add(this.SortEnumClassName, 0, 0);
            this.SortEnumOptionTableLayout.Controls.Add(this.SortEnumClassNameStatus, 1, 0);
            this.SortEnumOptionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortEnumOptionTableLayout.Location = new System.Drawing.Point(0, 0);
            this.SortEnumOptionTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SortEnumOptionTableLayout.Name = "SortEnumOptionTableLayout";
            this.SortEnumOptionTableLayout.RowCount = 1;
            this.SortEnumOptionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SortEnumOptionTableLayout.Size = new System.Drawing.Size(310, 27);
            this.SortEnumOptionTableLayout.TabIndex = 3;
            // 
            // SortEnumClassName
            // 
            this.SortEnumClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortEnumClassName.Location = new System.Drawing.Point(3, 3);
            this.SortEnumClassName.MaxLength = 30;
            this.SortEnumClassName.Name = "SortEnumClassName";
            this.SortEnumClassName.Size = new System.Drawing.Size(226, 22);
            this.SortEnumClassName.TabIndex = 0;
            // 
            // SortEnumClassNameStatus
            // 
            this.SortEnumClassNameStatus.AutoSize = true;
            this.SortEnumClassNameStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortEnumClassNameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortEnumClassNameStatus.ForeColor = System.Drawing.Color.Green;
            this.SortEnumClassNameStatus.Location = new System.Drawing.Point(235, 0);
            this.SortEnumClassNameStatus.Name = "SortEnumClassNameStatus";
            this.SortEnumClassNameStatus.Size = new System.Drawing.Size(72, 27);
            this.SortEnumClassNameStatus.TabIndex = 1;
            this.SortEnumClassNameStatus.Text = "Valid!";
            this.SortEnumClassNameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(924, 543);
            this.Controls.Add(this.MainTableLayout);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.MinimumSize = new System.Drawing.Size(744, 528);
            this.Name = "Application";
            this.Text = "ProgrammingUtils";
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.SortTab.ResumeLayout(false);
            this.SortTableLayout.ResumeLayout(false);
            this.SortTableLayout.PerformLayout();
            this.sortHeader.ResumeLayout(false);
            this.sortHeader.PerformLayout();
            this.sortModeTableLayout.ResumeLayout(false);
            this.sortModeTableLayout.PerformLayout();
            this.sortStyleTableLayout.ResumeLayout(false);
            this.sortStyleTableLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.SortEnumOptionTableLayout.ResumeLayout(false);
            this.SortEnumOptionTableLayout.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel sortHeader;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.CheckBox AutoSortCheckbox;
        private System.Windows.Forms.TableLayoutPanel sortModeTableLayout;
        private System.Windows.Forms.RadioButton sortAlphabeticlyRadio;
        private System.Windows.Forms.RadioButton notSortAlphabeticlyRadio;
        private System.Windows.Forms.TableLayoutPanel sortStyleTableLayout;
        private System.Windows.Forms.RadioButton sortSeperatorCommaRadio;
        private System.Windows.Forms.RadioButton sortSeperatorNewLineRadio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SortClearButton;
        private System.Windows.Forms.Button SortTextPresentationButton;
        private System.Windows.Forms.Button SortChangeTextCapsButton;
        private System.Windows.Forms.Button sortCopyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox SortExportDropdown;
        private System.Windows.Forms.Button SortExportEnumButton;
        private System.Windows.Forms.Label SortCopyNotice;
        private System.Windows.Forms.Timer copyTimer;
        private System.Windows.Forms.TableLayoutPanel SortEnumOptionTableLayout;
        private System.Windows.Forms.TextBox SortEnumClassName;
        private System.Windows.Forms.Label SortEnumClassNameStatus;
    }
}

