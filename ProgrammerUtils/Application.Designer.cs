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
            this.CountTab = new System.Windows.Forms.TabPage();
            this.countTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.countClearButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.countSortModes = new System.Windows.Forms.ComboBox();
            this.countSortModeLabel = new System.Windows.Forms.Label();
            this.countCaseSensitive = new System.Windows.Forms.CheckBox();
            this.countInputTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.countInputTextbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countTabs = new System.Windows.Forms.TabControl();
            this.countWordFrequencyTab = new System.Windows.Forms.TabPage();
            this.countWordFrequencyFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.countWordDensityTab = new System.Windows.Forms.TabPage();
            this.countWordDensityFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.countUniqueWordsTab = new System.Windows.Forms.TabPage();
            this.countUniqueWordsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.countInfoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.countInfoLabel = new System.Windows.Forms.Label();
            this.countInfoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.countDetailWords = new ProgrammerUtils.CountDetail();
            this.countDetailUniqueWords = new ProgrammerUtils.CountDetail();
            this.countDetailDifferentWords = new ProgrammerUtils.CountDetail();
            this.countDetailCharacters = new ProgrammerUtils.CountDetail();
            this.countDetailSentences = new ProgrammerUtils.CountDetail();
            this.countDetailParagraphs = new ProgrammerUtils.CountDetail();
            this.htmlTab = new System.Windows.Forms.TabPage();
            this.htmlTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.htmlSettingsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.htmlColorCustomTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.htmlChangeCustomColorButton = new System.Windows.Forms.Button();
            this.htmlCustomColorRectangle = new System.Windows.Forms.Button();
            this.htmlColorCustomCheckbox = new System.Windows.Forms.CheckBox();
            this.htmlColorEntityTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.htmlChangeEntityColorButton = new System.Windows.Forms.Button();
            this.htmlEntityColorRectangle = new System.Windows.Forms.Button();
            this.htmlColorEntitiesCheckbox = new System.Windows.Forms.CheckBox();
            this.htmlButton = new System.Windows.Forms.Button();
            this.htmlColorTagsCheckbox = new System.Windows.Forms.CheckBox();
            this.htmlColorTagOptionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.htmlChooseColorButton = new System.Windows.Forms.Button();
            this.htmlTagColorRectangle = new System.Windows.Forms.Button();
            this.htmlCustomRulesButton = new System.Windows.Forms.Button();
            this.htmlInputTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.htmlInputLabel = new System.Windows.Forms.Label();
            this.htmlInputTextbox = new System.Windows.Forms.RichTextBox();
            this.htmlInputTextSettingsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.htmlLoweredButton = new System.Windows.Forms.CheckBox();
            this.htmlUnderscoreButton = new System.Windows.Forms.CheckBox();
            this.htmlStrikeThroughButton = new System.Windows.Forms.CheckBox();
            this.htmlItalicButton = new System.Windows.Forms.CheckBox();
            this.htmlBoldButton = new System.Windows.Forms.CheckBox();
            this.htmlRaisedButton = new System.Windows.Forms.CheckBox();
            this.htmlOutputTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.htmlOutputLabel = new System.Windows.Forms.Label();
            this.htmlOutputTextbox = new System.Windows.Forms.RichTextBox();
            this.htmlSideTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.htmlOpenAllTags = new System.Windows.Forms.Button();
            this.htmlClearButton = new System.Windows.Forms.Button();
            this.htmlCopyButton = new System.Windows.Forms.Button();
            this.htmlCopyLabel = new System.Windows.Forms.Label();
            this.generateTextTab = new System.Windows.Forms.TabPage();
            this.generateTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.generateCopyLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.generateClearButton = new System.Windows.Forms.Button();
            this.generateCopyButton = new System.Windows.Forms.Button();
            this.generateSettingsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.generateSeed = new System.Windows.Forms.NumericUpDown();
            this.generateAmountOfWordsLabel = new System.Windows.Forms.Label();
            this.generateGenerateButton = new System.Windows.Forms.Button();
            this.generateParagraphType = new System.Windows.Forms.ComboBox();
            this.generateParagraphTypeLabel = new System.Windows.Forms.Label();
            this.generateNumberOfWords = new System.Windows.Forms.NumericUpDown();
            this.generateSeedTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.generateSeedLabel = new System.Windows.Forms.Label();
            this.generateCustomSeed = new System.Windows.Forms.CheckBox();
            this.generateParagraphSizeSlider = new System.Windows.Forms.TrackBar();
            this.generateParagraphSizeLabel = new System.Windows.Forms.Label();
            this.generateOutputTextbox = new System.Windows.Forms.RichTextBox();
            this.navigationMenu = new ProgrammerUtils.NavigationMenu();
            this.CopyTimer = new System.Windows.Forms.Timer(this.components);
            this.htmlColorTagPicker = new System.Windows.Forms.ColorDialog();
            this.htmlColorHoverTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.compareControl1 = new ProgrammerUtils.CompareControl();
            this.MainTableLayout.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SortTab.SuspendLayout();
            this.matchCompareTab.SuspendLayout();
            this.CountTab.SuspendLayout();
            this.countTableLayout.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.countInputTableLayout.SuspendLayout();
            this.countTabs.SuspendLayout();
            this.countWordFrequencyTab.SuspendLayout();
            this.countWordDensityTab.SuspendLayout();
            this.countUniqueWordsTab.SuspendLayout();
            this.countInfoTableLayout.SuspendLayout();
            this.countInfoFlowLayoutPanel.SuspendLayout();
            this.htmlTab.SuspendLayout();
            this.htmlTableLayout.SuspendLayout();
            this.htmlSettingsTableLayout.SuspendLayout();
            this.htmlColorCustomTableLayout.SuspendLayout();
            this.htmlColorEntityTableLayout.SuspendLayout();
            this.htmlColorTagOptionTableLayout.SuspendLayout();
            this.htmlInputTableLayout.SuspendLayout();
            this.htmlInputTextSettingsTableLayout.SuspendLayout();
            this.htmlOutputTableLayout.SuspendLayout();
            this.htmlSideTableLayout.SuspendLayout();
            this.generateTextTab.SuspendLayout();
            this.generateTableLayout.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.generateSettingsTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateNumberOfWords)).BeginInit();
            this.generateSeedTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateParagraphSizeSlider)).BeginInit();
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
            this.MainTableLayout.Size = new System.Drawing.Size(854, 544);
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
            this.MainTabControl.Size = new System.Drawing.Size(600, 538);
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
            this.SortTab.Size = new System.Drawing.Size(592, 495);
            this.SortTab.TabIndex = 0;
            this.SortTab.Text = "Sort";
            // 
            // sortControl1
            // 
            this.sortControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortControl1.Location = new System.Drawing.Point(2, 3);
            this.sortControl1.Margin = new System.Windows.Forms.Padding(0);
            this.sortControl1.Name = "sortControl1";
            this.sortControl1.Size = new System.Drawing.Size(588, 489);
            this.sortControl1.TabIndex = 0;
            // 
            // matchCompareTab
            // 
            this.matchCompareTab.Controls.Add(this.compareControl1);
            this.matchCompareTab.Location = new System.Drawing.Point(4, 39);
            this.matchCompareTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matchCompareTab.Name = "matchCompareTab";
            this.matchCompareTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matchCompareTab.Size = new System.Drawing.Size(592, 495);
            this.matchCompareTab.TabIndex = 1;
            this.matchCompareTab.Text = "Compare";
            this.matchCompareTab.UseVisualStyleBackColor = true;
            // 
            // CountTab
            // 
            this.CountTab.Controls.Add(this.countTableLayout);
            this.CountTab.Location = new System.Drawing.Point(4, 39);
            this.CountTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CountTab.Name = "CountTab";
            this.CountTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CountTab.Size = new System.Drawing.Size(592, 495);
            this.CountTab.TabIndex = 2;
            this.CountTab.Text = "Count";
            this.CountTab.UseVisualStyleBackColor = true;
            // 
            // countTableLayout
            // 
            this.countTableLayout.ColumnCount = 3;
            this.countTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.countTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.countTableLayout.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.countTableLayout.Controls.Add(this.countInputTableLayout, 0, 1);
            this.countTableLayout.Controls.Add(this.countTabs, 2, 1);
            this.countTableLayout.Controls.Add(this.countInfoTableLayout, 1, 1);
            this.countTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countTableLayout.Location = new System.Drawing.Point(2, 3);
            this.countTableLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countTableLayout.Name = "countTableLayout";
            this.countTableLayout.RowCount = 2;
            this.countTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.countTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countTableLayout.Size = new System.Drawing.Size(588, 489);
            this.countTableLayout.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.countTableLayout.SetColumnSpan(this.tableLayoutPanel5, 3);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel5.Controls.Add(this.countClearButton, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.countButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.countSortModes, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.countSortModeLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.countCaseSensitive, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(588, 57);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // countClearButton
            // 
            this.countClearButton.BackColor = System.Drawing.Color.LightPink;
            this.countClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countClearButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countClearButton.Location = new System.Drawing.Point(480, 3);
            this.countClearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countClearButton.Name = "countClearButton";
            this.tableLayoutPanel5.SetRowSpan(this.countClearButton, 2);
            this.countClearButton.Size = new System.Drawing.Size(106, 51);
            this.countClearButton.TabIndex = 5;
            this.countClearButton.Text = "Clear";
            this.countClearButton.UseVisualStyleBackColor = false;
            this.countClearButton.Click += new System.EventHandler(this.CountClearButton_Click);
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.countButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countButton.Location = new System.Drawing.Point(2, 3);
            this.countButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countButton.Name = "countButton";
            this.tableLayoutPanel5.SetRowSpan(this.countButton, 2);
            this.countButton.Size = new System.Drawing.Size(171, 51);
            this.countButton.TabIndex = 0;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // countSortModes
            // 
            this.countSortModes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countSortModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countSortModes.FormattingEnabled = true;
            this.countSortModes.Items.AddRange(new object[] {
            "Alphabetical",
            "Value"});
            this.countSortModes.Location = new System.Drawing.Point(177, 31);
            this.countSortModes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countSortModes.Name = "countSortModes";
            this.countSortModes.Size = new System.Drawing.Size(107, 24);
            this.countSortModes.TabIndex = 6;
            this.countSortModes.SelectedIndexChanged += new System.EventHandler(this.CountSortModes_SelectedIndexChanged);
            // 
            // countSortModeLabel
            // 
            this.countSortModeLabel.AutoSize = true;
            this.countSortModeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countSortModeLabel.Location = new System.Drawing.Point(177, 0);
            this.countSortModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countSortModeLabel.Name = "countSortModeLabel";
            this.countSortModeLabel.Size = new System.Drawing.Size(107, 28);
            this.countSortModeLabel.TabIndex = 7;
            this.countSortModeLabel.Text = "Sort mode";
            this.countSortModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countCaseSensitive
            // 
            this.countCaseSensitive.AutoSize = true;
            this.countCaseSensitive.Checked = true;
            this.countCaseSensitive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.countCaseSensitive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countCaseSensitive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countCaseSensitive.Location = new System.Drawing.Point(288, 3);
            this.countCaseSensitive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countCaseSensitive.Name = "countCaseSensitive";
            this.tableLayoutPanel5.SetRowSpan(this.countCaseSensitive, 2);
            this.countCaseSensitive.Size = new System.Drawing.Size(122, 51);
            this.countCaseSensitive.TabIndex = 8;
            this.countCaseSensitive.Text = "Case sensitive";
            this.countCaseSensitive.UseVisualStyleBackColor = true;
            this.countCaseSensitive.CheckedChanged += new System.EventHandler(this.CountCaseSensitive_CheckedChanged);
            // 
            // countInputTableLayout
            // 
            this.countInputTableLayout.ColumnCount = 1;
            this.countInputTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countInputTableLayout.Controls.Add(this.countInputTextbox, 0, 0);
            this.countInputTableLayout.Controls.Add(this.label2, 0, 1);
            this.countInputTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countInputTableLayout.Location = new System.Drawing.Point(0, 57);
            this.countInputTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.countInputTableLayout.Name = "countInputTableLayout";
            this.countInputTableLayout.RowCount = 2;
            this.countInputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countInputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.countInputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.countInputTableLayout.Size = new System.Drawing.Size(52, 432);
            this.countInputTableLayout.TabIndex = 3;
            // 
            // countInputTextbox
            // 
            this.countInputTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countInputTextbox.Location = new System.Drawing.Point(2, 3);
            this.countInputTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countInputTextbox.Name = "countInputTextbox";
            this.countInputTextbox.Size = new System.Drawing.Size(48, 212);
            this.countInputTextbox.TabIndex = 4;
            this.countInputTextbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.label2.Size = new System.Drawing.Size(48, 214);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text that should be analyzed.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countTabs
            // 
            this.countTabs.Controls.Add(this.countWordFrequencyTab);
            this.countTabs.Controls.Add(this.countWordDensityTab);
            this.countTabs.Controls.Add(this.countUniqueWordsTab);
            this.countTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countTabs.Location = new System.Drawing.Point(315, 60);
            this.countTabs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countTabs.Name = "countTabs";
            this.countTabs.SelectedIndex = 0;
            this.countTabs.Size = new System.Drawing.Size(271, 426);
            this.countTabs.TabIndex = 4;
            // 
            // countWordFrequencyTab
            // 
            this.countWordFrequencyTab.Controls.Add(this.countWordFrequencyFlowLayoutPanel);
            this.countWordFrequencyTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countWordFrequencyTab.Location = new System.Drawing.Point(4, 25);
            this.countWordFrequencyTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countWordFrequencyTab.Name = "countWordFrequencyTab";
            this.countWordFrequencyTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countWordFrequencyTab.Size = new System.Drawing.Size(263, 397);
            this.countWordFrequencyTab.TabIndex = 0;
            this.countWordFrequencyTab.Text = "Frequency";
            this.countWordFrequencyTab.UseVisualStyleBackColor = true;
            // 
            // countWordFrequencyFlowLayoutPanel
            // 
            this.countWordFrequencyFlowLayoutPanel.AutoScroll = true;
            this.countWordFrequencyFlowLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.countWordFrequencyFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countWordFrequencyFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countWordFrequencyFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.countWordFrequencyFlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countWordFrequencyFlowLayoutPanel.Location = new System.Drawing.Point(2, 3);
            this.countWordFrequencyFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countWordFrequencyFlowLayoutPanel.Name = "countWordFrequencyFlowLayoutPanel";
            this.countWordFrequencyFlowLayoutPanel.Size = new System.Drawing.Size(259, 391);
            this.countWordFrequencyFlowLayoutPanel.TabIndex = 6;
            this.countWordFrequencyFlowLayoutPanel.WrapContents = false;
            // 
            // countWordDensityTab
            // 
            this.countWordDensityTab.Controls.Add(this.countWordDensityFlowLayoutPanel);
            this.countWordDensityTab.Location = new System.Drawing.Point(4, 25);
            this.countWordDensityTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countWordDensityTab.Name = "countWordDensityTab";
            this.countWordDensityTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countWordDensityTab.Size = new System.Drawing.Size(263, 0);
            this.countWordDensityTab.TabIndex = 1;
            this.countWordDensityTab.Text = "Density";
            this.countWordDensityTab.UseVisualStyleBackColor = true;
            // 
            // countWordDensityFlowLayoutPanel
            // 
            this.countWordDensityFlowLayoutPanel.AutoScroll = true;
            this.countWordDensityFlowLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.countWordDensityFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countWordDensityFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countWordDensityFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.countWordDensityFlowLayoutPanel.Location = new System.Drawing.Point(2, 3);
            this.countWordDensityFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countWordDensityFlowLayoutPanel.Name = "countWordDensityFlowLayoutPanel";
            this.countWordDensityFlowLayoutPanel.Size = new System.Drawing.Size(259, 0);
            this.countWordDensityFlowLayoutPanel.TabIndex = 7;
            this.countWordDensityFlowLayoutPanel.WrapContents = false;
            // 
            // countUniqueWordsTab
            // 
            this.countUniqueWordsTab.Controls.Add(this.countUniqueWordsFlowLayoutPanel);
            this.countUniqueWordsTab.Location = new System.Drawing.Point(4, 25);
            this.countUniqueWordsTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countUniqueWordsTab.Name = "countUniqueWordsTab";
            this.countUniqueWordsTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countUniqueWordsTab.Size = new System.Drawing.Size(263, 0);
            this.countUniqueWordsTab.TabIndex = 2;
            this.countUniqueWordsTab.Text = "Unique Words";
            this.countUniqueWordsTab.UseVisualStyleBackColor = true;
            // 
            // countUniqueWordsFlowLayoutPanel
            // 
            this.countUniqueWordsFlowLayoutPanel.AutoScroll = true;
            this.countUniqueWordsFlowLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.countUniqueWordsFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countUniqueWordsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countUniqueWordsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.countUniqueWordsFlowLayoutPanel.Location = new System.Drawing.Point(2, 3);
            this.countUniqueWordsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countUniqueWordsFlowLayoutPanel.Name = "countUniqueWordsFlowLayoutPanel";
            this.countUniqueWordsFlowLayoutPanel.Size = new System.Drawing.Size(259, 0);
            this.countUniqueWordsFlowLayoutPanel.TabIndex = 8;
            this.countUniqueWordsFlowLayoutPanel.WrapContents = false;
            // 
            // countInfoTableLayout
            // 
            this.countInfoTableLayout.ColumnCount = 1;
            this.countInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countInfoTableLayout.Controls.Add(this.countInfoLabel, 0, 0);
            this.countInfoTableLayout.Controls.Add(this.countInfoFlowLayoutPanel, 0, 1);
            this.countInfoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countInfoTableLayout.Location = new System.Drawing.Point(52, 57);
            this.countInfoTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.countInfoTableLayout.Name = "countInfoTableLayout";
            this.countInfoTableLayout.RowCount = 2;
            this.countInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.countInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countInfoTableLayout.Size = new System.Drawing.Size(261, 432);
            this.countInfoTableLayout.TabIndex = 5;
            // 
            // countInfoLabel
            // 
            this.countInfoLabel.AutoSize = true;
            this.countInfoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.countInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countInfoLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countInfoLabel.Location = new System.Drawing.Point(2, 0);
            this.countInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countInfoLabel.Name = "countInfoLabel";
            this.countInfoLabel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.countInfoLabel.Size = new System.Drawing.Size(257, 38);
            this.countInfoLabel.TabIndex = 4;
            this.countInfoLabel.Text = "Text information";
            this.countInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countInfoFlowLayoutPanel
            // 
            this.countInfoFlowLayoutPanel.AutoScroll = true;
            this.countInfoFlowLayoutPanel.BackColor = System.Drawing.Color.LightGray;
            this.countInfoFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countInfoFlowLayoutPanel.Controls.Add(this.countDetailWords);
            this.countInfoFlowLayoutPanel.Controls.Add(this.countDetailUniqueWords);
            this.countInfoFlowLayoutPanel.Controls.Add(this.countDetailDifferentWords);
            this.countInfoFlowLayoutPanel.Controls.Add(this.countDetailCharacters);
            this.countInfoFlowLayoutPanel.Controls.Add(this.countDetailSentences);
            this.countInfoFlowLayoutPanel.Controls.Add(this.countDetailParagraphs);
            this.countInfoFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countInfoFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.countInfoFlowLayoutPanel.Location = new System.Drawing.Point(2, 41);
            this.countInfoFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countInfoFlowLayoutPanel.Name = "countInfoFlowLayoutPanel";
            this.countInfoFlowLayoutPanel.Size = new System.Drawing.Size(257, 388);
            this.countInfoFlowLayoutPanel.TabIndex = 5;
            this.countInfoFlowLayoutPanel.WrapContents = false;
            // 
            // countDetailWords
            // 
            this.countDetailWords.DetailText = "Words";
            this.countDetailWords.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDetailWords.Location = new System.Drawing.Point(0, 0);
            this.countDetailWords.Margin = new System.Windows.Forms.Padding(0);
            this.countDetailWords.Name = "countDetailWords";
            this.countDetailWords.Size = new System.Drawing.Size(255, 37);
            this.countDetailWords.TabIndex = 0;
            this.countDetailWords.ValueText = "0";
            // 
            // countDetailUniqueWords
            // 
            this.countDetailUniqueWords.DetailText = "Unique Words";
            this.countDetailUniqueWords.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDetailUniqueWords.Location = new System.Drawing.Point(0, 37);
            this.countDetailUniqueWords.Margin = new System.Windows.Forms.Padding(0);
            this.countDetailUniqueWords.Name = "countDetailUniqueWords";
            this.countDetailUniqueWords.Size = new System.Drawing.Size(255, 37);
            this.countDetailUniqueWords.TabIndex = 4;
            this.countDetailUniqueWords.ValueText = "0";
            // 
            // countDetailDifferentWords
            // 
            this.countDetailDifferentWords.DetailText = "Different Words";
            this.countDetailDifferentWords.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDetailDifferentWords.Location = new System.Drawing.Point(0, 74);
            this.countDetailDifferentWords.Margin = new System.Windows.Forms.Padding(0);
            this.countDetailDifferentWords.Name = "countDetailDifferentWords";
            this.countDetailDifferentWords.Size = new System.Drawing.Size(255, 37);
            this.countDetailDifferentWords.TabIndex = 5;
            this.countDetailDifferentWords.ValueText = "0";
            // 
            // countDetailCharacters
            // 
            this.countDetailCharacters.DetailText = "Characters";
            this.countDetailCharacters.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDetailCharacters.Location = new System.Drawing.Point(0, 111);
            this.countDetailCharacters.Margin = new System.Windows.Forms.Padding(0);
            this.countDetailCharacters.Name = "countDetailCharacters";
            this.countDetailCharacters.Size = new System.Drawing.Size(255, 37);
            this.countDetailCharacters.TabIndex = 1;
            this.countDetailCharacters.ValueText = "0";
            // 
            // countDetailSentences
            // 
            this.countDetailSentences.DetailText = "Sentences";
            this.countDetailSentences.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDetailSentences.Location = new System.Drawing.Point(0, 148);
            this.countDetailSentences.Margin = new System.Windows.Forms.Padding(0);
            this.countDetailSentences.Name = "countDetailSentences";
            this.countDetailSentences.Size = new System.Drawing.Size(255, 37);
            this.countDetailSentences.TabIndex = 2;
            this.countDetailSentences.ValueText = "0";
            // 
            // countDetailParagraphs
            // 
            this.countDetailParagraphs.DetailText = "Paragraphs";
            this.countDetailParagraphs.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDetailParagraphs.Location = new System.Drawing.Point(0, 185);
            this.countDetailParagraphs.Margin = new System.Windows.Forms.Padding(0);
            this.countDetailParagraphs.Name = "countDetailParagraphs";
            this.countDetailParagraphs.Size = new System.Drawing.Size(255, 37);
            this.countDetailParagraphs.TabIndex = 3;
            this.countDetailParagraphs.ValueText = "0";
            // 
            // htmlTab
            // 
            this.htmlTab.Controls.Add(this.htmlTableLayout);
            this.htmlTab.Location = new System.Drawing.Point(4, 39);
            this.htmlTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlTab.Name = "htmlTab";
            this.htmlTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlTab.Size = new System.Drawing.Size(592, 495);
            this.htmlTab.TabIndex = 3;
            this.htmlTab.Text = "HTML:ify";
            this.htmlTab.UseVisualStyleBackColor = true;
            // 
            // htmlTableLayout
            // 
            this.htmlTableLayout.ColumnCount = 3;
            this.htmlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.htmlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.htmlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.htmlTableLayout.Controls.Add(this.htmlSettingsTableLayout, 0, 0);
            this.htmlTableLayout.Controls.Add(this.htmlInputTableLayout, 0, 1);
            this.htmlTableLayout.Controls.Add(this.htmlOutputTableLayout, 1, 1);
            this.htmlTableLayout.Controls.Add(this.htmlSideTableLayout, 2, 1);
            this.htmlTableLayout.Controls.Add(this.htmlCopyLabel, 2, 0);
            this.htmlTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlTableLayout.Location = new System.Drawing.Point(2, 3);
            this.htmlTableLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlTableLayout.Name = "htmlTableLayout";
            this.htmlTableLayout.RowCount = 2;
            this.htmlTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.htmlTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlTableLayout.Size = new System.Drawing.Size(588, 489);
            this.htmlTableLayout.TabIndex = 0;
            // 
            // htmlSettingsTableLayout
            // 
            this.htmlSettingsTableLayout.ColumnCount = 8;
            this.htmlTableLayout.SetColumnSpan(this.htmlSettingsTableLayout, 2);
            this.htmlSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.htmlSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.htmlSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.htmlSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.htmlSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.htmlSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.htmlSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.htmlSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlSettingsTableLayout.Controls.Add(this.htmlColorCustomTableLayout, 6, 1);
            this.htmlSettingsTableLayout.Controls.Add(this.htmlColorCustomCheckbox, 6, 0);
            this.htmlSettingsTableLayout.Controls.Add(this.htmlColorEntityTableLayout, 5, 1);
            this.htmlSettingsTableLayout.Controls.Add(this.htmlColorEntitiesCheckbox, 5, 0);
            this.htmlSettingsTableLayout.Controls.Add(this.htmlButton, 0, 0);
            this.htmlSettingsTableLayout.Controls.Add(this.htmlColorTagsCheckbox, 4, 0);
            this.htmlSettingsTableLayout.Controls.Add(this.htmlColorTagOptionTableLayout, 4, 1);
            this.htmlSettingsTableLayout.Controls.Add(this.htmlCustomRulesButton, 2, 0);
            this.htmlSettingsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlSettingsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.htmlSettingsTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.htmlSettingsTableLayout.Name = "htmlSettingsTableLayout";
            this.htmlSettingsTableLayout.RowCount = 2;
            this.htmlSettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.htmlSettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.htmlSettingsTableLayout.Size = new System.Drawing.Size(526, 57);
            this.htmlSettingsTableLayout.TabIndex = 0;
            // 
            // htmlColorCustomTableLayout
            // 
            this.htmlColorCustomTableLayout.ColumnCount = 2;
            this.htmlColorCustomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlColorCustomTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.htmlColorCustomTableLayout.Controls.Add(this.htmlChangeCustomColorButton, 0, 0);
            this.htmlColorCustomTableLayout.Controls.Add(this.htmlCustomColorRectangle, 1, 0);
            this.htmlColorCustomTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlColorCustomTableLayout.Location = new System.Drawing.Point(563, 28);
            this.htmlColorCustomTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.htmlColorCustomTableLayout.Name = "htmlColorCustomTableLayout";
            this.htmlColorCustomTableLayout.RowCount = 1;
            this.htmlColorCustomTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlColorCustomTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.htmlColorCustomTableLayout.Size = new System.Drawing.Size(126, 29);
            this.htmlColorCustomTableLayout.TabIndex = 8;
            // 
            // htmlChangeCustomColorButton
            // 
            this.htmlChangeCustomColorButton.BackColor = System.Drawing.Color.Lavender;
            this.htmlChangeCustomColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlChangeCustomColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlChangeCustomColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlChangeCustomColorButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlChangeCustomColorButton.Location = new System.Drawing.Point(0, 0);
            this.htmlChangeCustomColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.htmlChangeCustomColorButton.Name = "htmlChangeCustomColorButton";
            this.htmlChangeCustomColorButton.Size = new System.Drawing.Size(104, 29);
            this.htmlChangeCustomColorButton.TabIndex = 7;
            this.htmlChangeCustomColorButton.Text = "Custom Color";
            this.htmlChangeCustomColorButton.UseVisualStyleBackColor = false;
            this.htmlChangeCustomColorButton.Click += new System.EventHandler(this.HtmlChangeCustomColorButton_Click);
            // 
            // htmlCustomColorRectangle
            // 
            this.htmlCustomColorRectangle.BackColor = System.Drawing.Color.Green;
            this.htmlCustomColorRectangle.Cursor = System.Windows.Forms.Cursors.Help;
            this.htmlCustomColorRectangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlCustomColorRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.htmlCustomColorRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.htmlCustomColorRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlCustomColorRectangle.Location = new System.Drawing.Point(109, 5);
            this.htmlCustomColorRectangle.Margin = new System.Windows.Forms.Padding(5);
            this.htmlCustomColorRectangle.Name = "htmlCustomColorRectangle";
            this.htmlCustomColorRectangle.Size = new System.Drawing.Size(12, 19);
            this.htmlCustomColorRectangle.TabIndex = 0;
            this.htmlCustomColorRectangle.TabStop = false;
            this.htmlColorHoverTooltip.SetToolTip(this.htmlCustomColorRectangle, "R0G255B0");
            this.htmlCustomColorRectangle.UseVisualStyleBackColor = false;
            // 
            // htmlColorCustomCheckbox
            // 
            this.htmlColorCustomCheckbox.AutoSize = true;
            this.htmlColorCustomCheckbox.Checked = true;
            this.htmlColorCustomCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.htmlColorCustomCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlColorCustomCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlColorCustomCheckbox.Location = new System.Drawing.Point(565, 3);
            this.htmlColorCustomCheckbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlColorCustomCheckbox.Name = "htmlColorCustomCheckbox";
            this.htmlColorCustomCheckbox.Size = new System.Drawing.Size(122, 22);
            this.htmlColorCustomCheckbox.TabIndex = 6;
            this.htmlColorCustomCheckbox.Text = "Color custom";
            this.htmlColorCustomCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlColorCustomCheckbox.UseVisualStyleBackColor = true;
            this.htmlColorCustomCheckbox.CheckedChanged += new System.EventHandler(this.HtmlColorCheckbox_CheckedChanged);
            // 
            // htmlColorEntityTableLayout
            // 
            this.htmlColorEntityTableLayout.ColumnCount = 2;
            this.htmlColorEntityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlColorEntityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.htmlColorEntityTableLayout.Controls.Add(this.htmlChangeEntityColorButton, 0, 0);
            this.htmlColorEntityTableLayout.Controls.Add(this.htmlEntityColorRectangle, 1, 0);
            this.htmlColorEntityTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlColorEntityTableLayout.Location = new System.Drawing.Point(437, 28);
            this.htmlColorEntityTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.htmlColorEntityTableLayout.Name = "htmlColorEntityTableLayout";
            this.htmlColorEntityTableLayout.RowCount = 1;
            this.htmlColorEntityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlColorEntityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.htmlColorEntityTableLayout.Size = new System.Drawing.Size(126, 29);
            this.htmlColorEntityTableLayout.TabIndex = 5;
            // 
            // htmlChangeEntityColorButton
            // 
            this.htmlChangeEntityColorButton.BackColor = System.Drawing.Color.Lavender;
            this.htmlChangeEntityColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlChangeEntityColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlChangeEntityColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlChangeEntityColorButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlChangeEntityColorButton.Location = new System.Drawing.Point(0, 0);
            this.htmlChangeEntityColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.htmlChangeEntityColorButton.Name = "htmlChangeEntityColorButton";
            this.htmlChangeEntityColorButton.Size = new System.Drawing.Size(104, 29);
            this.htmlChangeEntityColorButton.TabIndex = 5;
            this.htmlChangeEntityColorButton.Text = "Tag Color";
            this.htmlChangeEntityColorButton.UseVisualStyleBackColor = false;
            this.htmlChangeEntityColorButton.Click += new System.EventHandler(this.HtmlChangeEntityColorButton_Click);
            // 
            // htmlEntityColorRectangle
            // 
            this.htmlEntityColorRectangle.BackColor = System.Drawing.Color.Red;
            this.htmlEntityColorRectangle.Cursor = System.Windows.Forms.Cursors.Help;
            this.htmlEntityColorRectangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlEntityColorRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.htmlEntityColorRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.htmlEntityColorRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlEntityColorRectangle.Location = new System.Drawing.Point(109, 5);
            this.htmlEntityColorRectangle.Margin = new System.Windows.Forms.Padding(5);
            this.htmlEntityColorRectangle.Name = "htmlEntityColorRectangle";
            this.htmlEntityColorRectangle.Size = new System.Drawing.Size(12, 19);
            this.htmlEntityColorRectangle.TabIndex = 0;
            this.htmlEntityColorRectangle.TabStop = false;
            this.htmlColorHoverTooltip.SetToolTip(this.htmlEntityColorRectangle, "R255G0B0");
            this.htmlEntityColorRectangle.UseVisualStyleBackColor = false;
            // 
            // htmlColorEntitiesCheckbox
            // 
            this.htmlColorEntitiesCheckbox.AutoSize = true;
            this.htmlColorEntitiesCheckbox.Checked = true;
            this.htmlColorEntitiesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.htmlColorEntitiesCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlColorEntitiesCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlColorEntitiesCheckbox.Location = new System.Drawing.Point(439, 3);
            this.htmlColorEntitiesCheckbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlColorEntitiesCheckbox.Name = "htmlColorEntitiesCheckbox";
            this.htmlColorEntitiesCheckbox.Size = new System.Drawing.Size(122, 22);
            this.htmlColorEntitiesCheckbox.TabIndex = 4;
            this.htmlColorEntitiesCheckbox.Text = "Color entities";
            this.htmlColorEntitiesCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlColorEntitiesCheckbox.UseVisualStyleBackColor = true;
            this.htmlColorEntitiesCheckbox.CheckedChanged += new System.EventHandler(this.HtmlColorCheckbox_CheckedChanged);
            // 
            // htmlButton
            // 
            this.htmlButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.htmlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlButton.Location = new System.Drawing.Point(2, 3);
            this.htmlButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlButton.Name = "htmlButton";
            this.htmlSettingsTableLayout.SetRowSpan(this.htmlButton, 2);
            this.htmlButton.Size = new System.Drawing.Size(171, 51);
            this.htmlButton.TabIndex = 0;
            this.htmlButton.Text = "HTML:ify";
            this.htmlButton.UseVisualStyleBackColor = false;
            this.htmlButton.Click += new System.EventHandler(this.HtmlButton_Click);
            // 
            // htmlColorTagsCheckbox
            // 
            this.htmlColorTagsCheckbox.AutoSize = true;
            this.htmlColorTagsCheckbox.Checked = true;
            this.htmlColorTagsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.htmlColorTagsCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlColorTagsCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlColorTagsCheckbox.Location = new System.Drawing.Point(313, 3);
            this.htmlColorTagsCheckbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlColorTagsCheckbox.Name = "htmlColorTagsCheckbox";
            this.htmlColorTagsCheckbox.Size = new System.Drawing.Size(122, 22);
            this.htmlColorTagsCheckbox.TabIndex = 2;
            this.htmlColorTagsCheckbox.Text = "Color tags";
            this.htmlColorTagsCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlColorTagsCheckbox.UseVisualStyleBackColor = true;
            this.htmlColorTagsCheckbox.CheckedChanged += new System.EventHandler(this.HtmlColorCheckbox_CheckedChanged);
            // 
            // htmlColorTagOptionTableLayout
            // 
            this.htmlColorTagOptionTableLayout.ColumnCount = 2;
            this.htmlColorTagOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlColorTagOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.htmlColorTagOptionTableLayout.Controls.Add(this.htmlChooseColorButton, 0, 0);
            this.htmlColorTagOptionTableLayout.Controls.Add(this.htmlTagColorRectangle, 1, 0);
            this.htmlColorTagOptionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlColorTagOptionTableLayout.Location = new System.Drawing.Point(311, 28);
            this.htmlColorTagOptionTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.htmlColorTagOptionTableLayout.Name = "htmlColorTagOptionTableLayout";
            this.htmlColorTagOptionTableLayout.RowCount = 1;
            this.htmlColorTagOptionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlColorTagOptionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.htmlColorTagOptionTableLayout.Size = new System.Drawing.Size(126, 29);
            this.htmlColorTagOptionTableLayout.TabIndex = 3;
            // 
            // htmlChooseColorButton
            // 
            this.htmlChooseColorButton.BackColor = System.Drawing.Color.Lavender;
            this.htmlChooseColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlChooseColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlChooseColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlChooseColorButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlChooseColorButton.Location = new System.Drawing.Point(0, 0);
            this.htmlChooseColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.htmlChooseColorButton.Name = "htmlChooseColorButton";
            this.htmlChooseColorButton.Size = new System.Drawing.Size(104, 29);
            this.htmlChooseColorButton.TabIndex = 3;
            this.htmlChooseColorButton.Text = "Tag Color";
            this.htmlChooseColorButton.UseVisualStyleBackColor = false;
            this.htmlChooseColorButton.Click += new System.EventHandler(this.HtmlChooseColorButton_Click);
            // 
            // htmlTagColorRectangle
            // 
            this.htmlTagColorRectangle.BackColor = System.Drawing.Color.Blue;
            this.htmlTagColorRectangle.Cursor = System.Windows.Forms.Cursors.Help;
            this.htmlTagColorRectangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlTagColorRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.htmlTagColorRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.htmlTagColorRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlTagColorRectangle.Location = new System.Drawing.Point(109, 5);
            this.htmlTagColorRectangle.Margin = new System.Windows.Forms.Padding(5);
            this.htmlTagColorRectangle.Name = "htmlTagColorRectangle";
            this.htmlTagColorRectangle.Size = new System.Drawing.Size(12, 19);
            this.htmlTagColorRectangle.TabIndex = 0;
            this.htmlTagColorRectangle.TabStop = false;
            this.htmlColorHoverTooltip.SetToolTip(this.htmlTagColorRectangle, "R0G0B255");
            this.htmlTagColorRectangle.UseVisualStyleBackColor = false;
            // 
            // htmlCustomRulesButton
            // 
            this.htmlCustomRulesButton.BackColor = System.Drawing.Color.Thistle;
            this.htmlCustomRulesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlCustomRulesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlCustomRulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlCustomRulesButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlCustomRulesButton.Location = new System.Drawing.Point(182, 3);
            this.htmlCustomRulesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlCustomRulesButton.Name = "htmlCustomRulesButton";
            this.htmlSettingsTableLayout.SetRowSpan(this.htmlCustomRulesButton, 2);
            this.htmlCustomRulesButton.Size = new System.Drawing.Size(122, 51);
            this.htmlCustomRulesButton.TabIndex = 1;
            this.htmlCustomRulesButton.Text = "Custom Rules";
            this.htmlCustomRulesButton.UseVisualStyleBackColor = false;
            this.htmlCustomRulesButton.Click += new System.EventHandler(this.HtmlCustomRulesButton_Click);
            // 
            // htmlInputTableLayout
            // 
            this.htmlInputTableLayout.ColumnCount = 1;
            this.htmlInputTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlInputTableLayout.Controls.Add(this.htmlInputLabel, 0, 2);
            this.htmlInputTableLayout.Controls.Add(this.htmlInputTextbox, 0, 0);
            this.htmlInputTableLayout.Controls.Add(this.htmlInputTextSettingsTableLayout, 0, 1);
            this.htmlInputTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlInputTableLayout.Location = new System.Drawing.Point(0, 57);
            this.htmlInputTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.htmlInputTableLayout.Name = "htmlInputTableLayout";
            this.htmlInputTableLayout.RowCount = 3;
            this.htmlInputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlInputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.htmlInputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.htmlInputTableLayout.Size = new System.Drawing.Size(263, 432);
            this.htmlInputTableLayout.TabIndex = 1;
            // 
            // htmlInputLabel
            // 
            this.htmlInputLabel.AutoSize = true;
            this.htmlInputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.htmlInputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.htmlInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlInputLabel.Location = new System.Drawing.Point(2, 394);
            this.htmlInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.htmlInputLabel.Name = "htmlInputLabel";
            this.htmlInputLabel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.htmlInputLabel.Size = new System.Drawing.Size(259, 38);
            this.htmlInputLabel.TabIndex = 3;
            this.htmlInputLabel.Text = "Write plain text that should be converted to HTML text!";
            this.htmlInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // htmlInputTextbox
            // 
            this.htmlInputTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlInputTextbox.Location = new System.Drawing.Point(2, 3);
            this.htmlInputTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlInputTextbox.Name = "htmlInputTextbox";
            this.htmlInputTextbox.Size = new System.Drawing.Size(259, 350);
            this.htmlInputTextbox.TabIndex = 8;
            this.htmlInputTextbox.Text = "";
            this.htmlInputTextbox.SelectionChanged += new System.EventHandler(this.HtmlInputTextbox_SelectionChanged);
            // 
            // htmlInputTextSettingsTableLayout
            // 
            this.htmlInputTextSettingsTableLayout.ColumnCount = 7;
            this.htmlInputTextSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.htmlInputTextSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.htmlInputTextSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.htmlInputTextSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.htmlInputTextSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.htmlInputTextSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.htmlInputTextSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlInputTextSettingsTableLayout.Controls.Add(this.htmlLoweredButton, 5, 0);
            this.htmlInputTextSettingsTableLayout.Controls.Add(this.htmlUnderscoreButton, 0, 0);
            this.htmlInputTextSettingsTableLayout.Controls.Add(this.htmlStrikeThroughButton, 2, 0);
            this.htmlInputTextSettingsTableLayout.Controls.Add(this.htmlItalicButton, 1, 0);
            this.htmlInputTextSettingsTableLayout.Controls.Add(this.htmlBoldButton, 0, 0);
            this.htmlInputTextSettingsTableLayout.Controls.Add(this.htmlRaisedButton, 4, 0);
            this.htmlInputTextSettingsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlInputTextSettingsTableLayout.Location = new System.Drawing.Point(2, 359);
            this.htmlInputTextSettingsTableLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlInputTextSettingsTableLayout.Name = "htmlInputTextSettingsTableLayout";
            this.htmlInputTextSettingsTableLayout.RowCount = 1;
            this.htmlInputTextSettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlInputTextSettingsTableLayout.Size = new System.Drawing.Size(259, 32);
            this.htmlInputTextSettingsTableLayout.TabIndex = 4;
            // 
            // htmlLoweredButton
            // 
            this.htmlLoweredButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.htmlLoweredButton.AutoSize = true;
            this.htmlLoweredButton.BackColor = System.Drawing.Color.Lavender;
            this.htmlLoweredButton.BackgroundImage = global::ProgrammerUtils.Properties.Resources.html_Lowered;
            this.htmlLoweredButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.htmlLoweredButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlLoweredButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlLoweredButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlLoweredButton.Location = new System.Drawing.Point(152, 3);
            this.htmlLoweredButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlLoweredButton.Name = "htmlLoweredButton";
            this.htmlLoweredButton.Size = new System.Drawing.Size(26, 26);
            this.htmlLoweredButton.TabIndex = 14;
            this.htmlLoweredButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlLoweredButton.UseVisualStyleBackColor = false;
            this.htmlLoweredButton.CheckedChanged += new System.EventHandler(this.HtmlLoweredButton_CheckedChanged);
            this.htmlLoweredButton.CheckStateChanged += new System.EventHandler(this.HTMLTextStyleButtonChange);
            // 
            // htmlUnderscoreButton
            // 
            this.htmlUnderscoreButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.htmlUnderscoreButton.AutoSize = true;
            this.htmlUnderscoreButton.BackColor = System.Drawing.Color.Lavender;
            this.htmlUnderscoreButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlUnderscoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlUnderscoreButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlUnderscoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlUnderscoreButton.Font = new System.Drawing.Font("Arial", 7.7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlUnderscoreButton.Location = new System.Drawing.Point(32, 3);
            this.htmlUnderscoreButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlUnderscoreButton.Name = "htmlUnderscoreButton";
            this.htmlUnderscoreButton.Size = new System.Drawing.Size(26, 26);
            this.htmlUnderscoreButton.TabIndex = 10;
            this.htmlUnderscoreButton.Text = "U";
            this.htmlUnderscoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlUnderscoreButton.UseVisualStyleBackColor = false;
            this.htmlUnderscoreButton.CheckedChanged += new System.EventHandler(this.HtmlUnderscoreButton_CheckedChanged);
            this.htmlUnderscoreButton.CheckStateChanged += new System.EventHandler(this.HTMLTextStyleButtonChange);
            // 
            // htmlStrikeThroughButton
            // 
            this.htmlStrikeThroughButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.htmlStrikeThroughButton.AutoSize = true;
            this.htmlStrikeThroughButton.BackColor = System.Drawing.Color.Lavender;
            this.htmlStrikeThroughButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlStrikeThroughButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlStrikeThroughButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlStrikeThroughButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlStrikeThroughButton.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlStrikeThroughButton.Location = new System.Drawing.Point(92, 3);
            this.htmlStrikeThroughButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlStrikeThroughButton.Name = "htmlStrikeThroughButton";
            this.htmlStrikeThroughButton.Size = new System.Drawing.Size(26, 26);
            this.htmlStrikeThroughButton.TabIndex = 12;
            this.htmlStrikeThroughButton.Text = "S";
            this.htmlStrikeThroughButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlStrikeThroughButton.UseVisualStyleBackColor = false;
            this.htmlStrikeThroughButton.CheckedChanged += new System.EventHandler(this.HtmlStrikeThroughButton_CheckedChanged);
            this.htmlStrikeThroughButton.CheckStateChanged += new System.EventHandler(this.HTMLTextStyleButtonChange);
            // 
            // htmlItalicButton
            // 
            this.htmlItalicButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.htmlItalicButton.AutoSize = true;
            this.htmlItalicButton.BackColor = System.Drawing.Color.Lavender;
            this.htmlItalicButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlItalicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlItalicButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlItalicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlItalicButton.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlItalicButton.Location = new System.Drawing.Point(62, 3);
            this.htmlItalicButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlItalicButton.Name = "htmlItalicButton";
            this.htmlItalicButton.Size = new System.Drawing.Size(26, 26);
            this.htmlItalicButton.TabIndex = 11;
            this.htmlItalicButton.Text = "I";
            this.htmlItalicButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlItalicButton.UseVisualStyleBackColor = false;
            this.htmlItalicButton.CheckedChanged += new System.EventHandler(this.HtmlItalicButton_CheckedChanged);
            this.htmlItalicButton.CheckStateChanged += new System.EventHandler(this.HTMLTextStyleButtonChange);
            // 
            // htmlBoldButton
            // 
            this.htmlBoldButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.htmlBoldButton.AutoSize = true;
            this.htmlBoldButton.BackColor = System.Drawing.Color.Lavender;
            this.htmlBoldButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlBoldButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlBoldButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlBoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlBoldButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlBoldButton.Location = new System.Drawing.Point(2, 3);
            this.htmlBoldButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlBoldButton.Name = "htmlBoldButton";
            this.htmlBoldButton.Size = new System.Drawing.Size(26, 26);
            this.htmlBoldButton.TabIndex = 9;
            this.htmlBoldButton.Text = "B";
            this.htmlBoldButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlBoldButton.UseVisualStyleBackColor = false;
            this.htmlBoldButton.CheckedChanged += new System.EventHandler(this.HtmlBoldButton_CheckedChanged);
            this.htmlBoldButton.CheckStateChanged += new System.EventHandler(this.HTMLTextStyleButtonChange);
            // 
            // htmlRaisedButton
            // 
            this.htmlRaisedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.htmlRaisedButton.AutoSize = true;
            this.htmlRaisedButton.BackColor = System.Drawing.Color.Lavender;
            this.htmlRaisedButton.BackgroundImage = global::ProgrammerUtils.Properties.Resources.html_Raised;
            this.htmlRaisedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.htmlRaisedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlRaisedButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlRaisedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlRaisedButton.Location = new System.Drawing.Point(122, 3);
            this.htmlRaisedButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlRaisedButton.Name = "htmlRaisedButton";
            this.htmlRaisedButton.Size = new System.Drawing.Size(26, 26);
            this.htmlRaisedButton.TabIndex = 13;
            this.htmlRaisedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlRaisedButton.UseVisualStyleBackColor = false;
            this.htmlRaisedButton.CheckedChanged += new System.EventHandler(this.HtmlRaisedButton_CheckedChanged);
            this.htmlRaisedButton.CheckStateChanged += new System.EventHandler(this.HTMLTextStyleButtonChange);
            // 
            // htmlOutputTableLayout
            // 
            this.htmlOutputTableLayout.ColumnCount = 1;
            this.htmlOutputTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlOutputTableLayout.Controls.Add(this.htmlOutputLabel, 0, 1);
            this.htmlOutputTableLayout.Controls.Add(this.htmlOutputTextbox, 0, 0);
            this.htmlOutputTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlOutputTableLayout.Location = new System.Drawing.Point(263, 57);
            this.htmlOutputTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.htmlOutputTableLayout.Name = "htmlOutputTableLayout";
            this.htmlOutputTableLayout.RowCount = 2;
            this.htmlOutputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlOutputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.htmlOutputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.htmlOutputTableLayout.Size = new System.Drawing.Size(263, 432);
            this.htmlOutputTableLayout.TabIndex = 2;
            // 
            // htmlOutputLabel
            // 
            this.htmlOutputLabel.AutoSize = true;
            this.htmlOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.htmlOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.htmlOutputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlOutputLabel.Location = new System.Drawing.Point(2, 394);
            this.htmlOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.htmlOutputLabel.Name = "htmlOutputLabel";
            this.htmlOutputLabel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.htmlOutputLabel.Size = new System.Drawing.Size(259, 38);
            this.htmlOutputLabel.TabIndex = 4;
            this.htmlOutputLabel.Text = "Text converted to HTML.";
            this.htmlOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // htmlOutputTextbox
            // 
            this.htmlOutputTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlOutputTextbox.Location = new System.Drawing.Point(2, 3);
            this.htmlOutputTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlOutputTextbox.Name = "htmlOutputTextbox";
            this.htmlOutputTextbox.ReadOnly = true;
            this.htmlOutputTextbox.Size = new System.Drawing.Size(259, 388);
            this.htmlOutputTextbox.TabIndex = 15;
            this.htmlOutputTextbox.Text = "";
            // 
            // htmlSideTableLayout
            // 
            this.htmlSideTableLayout.ColumnCount = 1;
            this.htmlSideTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlSideTableLayout.Controls.Add(this.htmlOpenAllTags, 0, 0);
            this.htmlSideTableLayout.Controls.Add(this.htmlClearButton, 0, 2);
            this.htmlSideTableLayout.Controls.Add(this.htmlCopyButton, 0, 1);
            this.htmlSideTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlSideTableLayout.Location = new System.Drawing.Point(526, 57);
            this.htmlSideTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.htmlSideTableLayout.Name = "htmlSideTableLayout";
            this.htmlSideTableLayout.RowCount = 4;
            this.htmlSideTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.htmlSideTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.htmlSideTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.htmlSideTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlSideTableLayout.Size = new System.Drawing.Size(62, 432);
            this.htmlSideTableLayout.TabIndex = 3;
            // 
            // htmlOpenAllTags
            // 
            this.htmlOpenAllTags.AutoSize = true;
            this.htmlOpenAllTags.BackColor = System.Drawing.Color.PaleTurquoise;
            this.htmlOpenAllTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlOpenAllTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlOpenAllTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlOpenAllTags.Font = new System.Drawing.Font("Arial", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlOpenAllTags.ForeColor = System.Drawing.Color.DarkBlue;
            this.htmlOpenAllTags.Location = new System.Drawing.Point(2, 3);
            this.htmlOpenAllTags.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlOpenAllTags.Name = "htmlOpenAllTags";
            this.htmlOpenAllTags.Size = new System.Drawing.Size(58, 60);
            this.htmlOpenAllTags.TabIndex = 16;
            this.htmlOpenAllTags.Text = "HTML Special Chars";
            this.htmlOpenAllTags.UseVisualStyleBackColor = false;
            this.htmlOpenAllTags.Click += new System.EventHandler(this.HtmlOpenAllTags_Click);
            // 
            // htmlClearButton
            // 
            this.htmlClearButton.AutoSize = true;
            this.htmlClearButton.BackColor = System.Drawing.Color.LightPink;
            this.htmlClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlClearButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlClearButton.Location = new System.Drawing.Point(2, 135);
            this.htmlClearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlClearButton.Name = "htmlClearButton";
            this.htmlClearButton.Size = new System.Drawing.Size(58, 60);
            this.htmlClearButton.TabIndex = 18;
            this.htmlClearButton.Text = "Clear";
            this.htmlClearButton.UseVisualStyleBackColor = false;
            this.htmlClearButton.Click += new System.EventHandler(this.HtmlClearButton_Click);
            // 
            // htmlCopyButton
            // 
            this.htmlCopyButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.htmlCopyButton.BackgroundImage = global::ProgrammerUtils.Properties.Resources.copy_image;
            this.htmlCopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.htmlCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htmlCopyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlCopyButton.Location = new System.Drawing.Point(2, 69);
            this.htmlCopyButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlCopyButton.Name = "htmlCopyButton";
            this.htmlCopyButton.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.htmlCopyButton.Size = new System.Drawing.Size(58, 60);
            this.htmlCopyButton.TabIndex = 17;
            this.htmlCopyButton.UseVisualStyleBackColor = false;
            this.htmlCopyButton.Click += new System.EventHandler(this.HtmlCopyButton_Click);
            // 
            // htmlCopyLabel
            // 
            this.htmlCopyLabel.AutoSize = true;
            this.htmlCopyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlCopyLabel.Font = new System.Drawing.Font("Arial", 7.6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlCopyLabel.ForeColor = System.Drawing.Color.Green;
            this.htmlCopyLabel.Location = new System.Drawing.Point(528, 0);
            this.htmlCopyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.htmlCopyLabel.Name = "htmlCopyLabel";
            this.htmlCopyLabel.Size = new System.Drawing.Size(58, 57);
            this.htmlCopyLabel.TabIndex = 4;
            this.htmlCopyLabel.Text = "Copied!";
            this.htmlCopyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateTextTab
            // 
            this.generateTextTab.Controls.Add(this.generateTableLayout);
            this.generateTextTab.Location = new System.Drawing.Point(4, 39);
            this.generateTextTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateTextTab.Name = "generateTextTab";
            this.generateTextTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateTextTab.Size = new System.Drawing.Size(592, 495);
            this.generateTextTab.TabIndex = 4;
            this.generateTextTab.Text = "Generate Text";
            this.generateTextTab.UseVisualStyleBackColor = true;
            // 
            // generateTableLayout
            // 
            this.generateTableLayout.ColumnCount = 3;
            this.generateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.generateTableLayout.Controls.Add(this.generateCopyLabel, 0, 0);
            this.generateTableLayout.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.generateTableLayout.Controls.Add(this.generateSettingsTableLayout, 0, 0);
            this.generateTableLayout.Controls.Add(this.generateOutputTextbox, 0, 1);
            this.generateTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateTableLayout.Location = new System.Drawing.Point(2, 3);
            this.generateTableLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateTableLayout.Name = "generateTableLayout";
            this.generateTableLayout.RowCount = 2;
            this.generateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.generateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generateTableLayout.Size = new System.Drawing.Size(588, 489);
            this.generateTableLayout.TabIndex = 0;
            // 
            // generateCopyLabel
            // 
            this.generateCopyLabel.AutoSize = true;
            this.generateCopyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateCopyLabel.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCopyLabel.ForeColor = System.Drawing.Color.Green;
            this.generateCopyLabel.Location = new System.Drawing.Point(524, 0);
            this.generateCopyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generateCopyLabel.Name = "generateCopyLabel";
            this.generateCopyLabel.Size = new System.Drawing.Size(62, 57);
            this.generateCopyLabel.TabIndex = 10;
            this.generateCopyLabel.Text = "Copied!";
            this.generateCopyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.generateClearButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.generateCopyButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(522, 57);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(66, 432);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // generateClearButton
            // 
            this.generateClearButton.AutoSize = true;
            this.generateClearButton.BackColor = System.Drawing.Color.LightPink;
            this.generateClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateClearButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateClearButton.Location = new System.Drawing.Point(2, 69);
            this.generateClearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateClearButton.Name = "generateClearButton";
            this.generateClearButton.Size = new System.Drawing.Size(62, 60);
            this.generateClearButton.TabIndex = 18;
            this.generateClearButton.Text = "Clear";
            this.generateClearButton.UseVisualStyleBackColor = false;
            this.generateClearButton.Click += new System.EventHandler(this.GenerateClearButton_Click);
            // 
            // generateCopyButton
            // 
            this.generateCopyButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.generateCopyButton.BackgroundImage = global::ProgrammerUtils.Properties.Resources.copy_image;
            this.generateCopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateCopyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCopyButton.Location = new System.Drawing.Point(2, 3);
            this.generateCopyButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateCopyButton.Name = "generateCopyButton";
            this.generateCopyButton.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.generateCopyButton.Size = new System.Drawing.Size(62, 60);
            this.generateCopyButton.TabIndex = 17;
            this.generateCopyButton.UseVisualStyleBackColor = false;
            this.generateCopyButton.Click += new System.EventHandler(this.GenerateCopyButton_Click);
            // 
            // generateSettingsTableLayout
            // 
            this.generateSettingsTableLayout.ColumnCount = 6;
            this.generateTableLayout.SetColumnSpan(this.generateSettingsTableLayout, 2);
            this.generateSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.generateSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generateSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generateSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generateSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generateSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generateSettingsTableLayout.Controls.Add(this.generateSeed, 4, 1);
            this.generateSettingsTableLayout.Controls.Add(this.generateAmountOfWordsLabel, 1, 0);
            this.generateSettingsTableLayout.Controls.Add(this.generateGenerateButton, 0, 0);
            this.generateSettingsTableLayout.Controls.Add(this.generateParagraphType, 2, 1);
            this.generateSettingsTableLayout.Controls.Add(this.generateParagraphTypeLabel, 2, 0);
            this.generateSettingsTableLayout.Controls.Add(this.generateNumberOfWords, 1, 1);
            this.generateSettingsTableLayout.Controls.Add(this.generateSeedTableLayout, 4, 0);
            this.generateSettingsTableLayout.Controls.Add(this.generateParagraphSizeSlider, 3, 1);
            this.generateSettingsTableLayout.Controls.Add(this.generateParagraphSizeLabel, 3, 0);
            this.generateSettingsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateSettingsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.generateSettingsTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.generateSettingsTableLayout.Name = "generateSettingsTableLayout";
            this.generateSettingsTableLayout.RowCount = 2;
            this.generateSettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generateSettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generateSettingsTableLayout.Size = new System.Drawing.Size(522, 57);
            this.generateSettingsTableLayout.TabIndex = 7;
            // 
            // generateSeed
            // 
            this.generateSeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateSeed.Enabled = false;
            this.generateSeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.generateSeed.Location = new System.Drawing.Point(540, 31);
            this.generateSeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateSeed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.generateSeed.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.generateSeed.Name = "generateSeed";
            this.generateSeed.Size = new System.Drawing.Size(145, 22);
            this.generateSeed.TabIndex = 5;
            // 
            // generateAmountOfWordsLabel
            // 
            this.generateAmountOfWordsLabel.AutoSize = true;
            this.generateAmountOfWordsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateAmountOfWordsLabel.Location = new System.Drawing.Point(177, 0);
            this.generateAmountOfWordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generateAmountOfWordsLabel.Name = "generateAmountOfWordsLabel";
            this.generateAmountOfWordsLabel.Size = new System.Drawing.Size(116, 28);
            this.generateAmountOfWordsLabel.TabIndex = 4;
            this.generateAmountOfWordsLabel.Text = "Amount of words";
            this.generateAmountOfWordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generateGenerateButton
            // 
            this.generateGenerateButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.generateGenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateGenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateGenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateGenerateButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateGenerateButton.Location = new System.Drawing.Point(2, 3);
            this.generateGenerateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateGenerateButton.Name = "generateGenerateButton";
            this.generateSettingsTableLayout.SetRowSpan(this.generateGenerateButton, 2);
            this.generateGenerateButton.Size = new System.Drawing.Size(171, 51);
            this.generateGenerateButton.TabIndex = 0;
            this.generateGenerateButton.Text = "Generate Text";
            this.generateGenerateButton.UseVisualStyleBackColor = false;
            this.generateGenerateButton.Click += new System.EventHandler(this.GenerateGenerateButton_Click);
            // 
            // generateParagraphType
            // 
            this.generateParagraphType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateParagraphType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generateParagraphType.FormattingEnabled = true;
            this.generateParagraphType.Items.AddRange(new object[] {
            "Blank row",
            "Indent",
            "No paragraphs"});
            this.generateParagraphType.Location = new System.Drawing.Point(297, 31);
            this.generateParagraphType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateParagraphType.Name = "generateParagraphType";
            this.generateParagraphType.Size = new System.Drawing.Size(107, 24);
            this.generateParagraphType.TabIndex = 1;
            this.generateParagraphType.SelectedIndexChanged += new System.EventHandler(this.GenerateParagraphType_SelectedIndexChanged);
            // 
            // generateParagraphTypeLabel
            // 
            this.generateParagraphTypeLabel.AutoSize = true;
            this.generateParagraphTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateParagraphTypeLabel.Location = new System.Drawing.Point(297, 0);
            this.generateParagraphTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generateParagraphTypeLabel.Name = "generateParagraphTypeLabel";
            this.generateParagraphTypeLabel.Size = new System.Drawing.Size(107, 28);
            this.generateParagraphTypeLabel.TabIndex = 2;
            this.generateParagraphTypeLabel.Text = "Paragraph type";
            this.generateParagraphTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generateNumberOfWords
            // 
            this.generateNumberOfWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateNumberOfWords.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.generateNumberOfWords.Location = new System.Drawing.Point(177, 31);
            this.generateNumberOfWords.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateNumberOfWords.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.generateNumberOfWords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.generateNumberOfWords.Name = "generateNumberOfWords";
            this.generateNumberOfWords.Size = new System.Drawing.Size(116, 22);
            this.generateNumberOfWords.TabIndex = 3;
            this.generateNumberOfWords.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // generateSeedTableLayout
            // 
            this.generateSeedTableLayout.ColumnCount = 2;
            this.generateSeedTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generateSeedTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generateSeedTableLayout.Controls.Add(this.generateSeedLabel, 0, 0);
            this.generateSeedTableLayout.Controls.Add(this.generateCustomSeed, 1, 0);
            this.generateSeedTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateSeedTableLayout.Location = new System.Drawing.Point(538, 0);
            this.generateSeedTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.generateSeedTableLayout.Name = "generateSeedTableLayout";
            this.generateSeedTableLayout.RowCount = 1;
            this.generateSeedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generateSeedTableLayout.Size = new System.Drawing.Size(149, 28);
            this.generateSeedTableLayout.TabIndex = 7;
            // 
            // generateSeedLabel
            // 
            this.generateSeedLabel.AutoSize = true;
            this.generateSeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateSeedLabel.Enabled = false;
            this.generateSeedLabel.Location = new System.Drawing.Point(2, 0);
            this.generateSeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generateSeedLabel.Name = "generateSeedLabel";
            this.generateSeedLabel.Size = new System.Drawing.Size(41, 28);
            this.generateSeedLabel.TabIndex = 7;
            this.generateSeedLabel.Text = "Seed";
            this.generateSeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generateCustomSeed
            // 
            this.generateCustomSeed.AutoSize = true;
            this.generateCustomSeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateCustomSeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateCustomSeed.Location = new System.Drawing.Point(47, 3);
            this.generateCustomSeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateCustomSeed.Name = "generateCustomSeed";
            this.generateCustomSeed.Size = new System.Drawing.Size(100, 22);
            this.generateCustomSeed.TabIndex = 8;
            this.generateCustomSeed.Text = "Custom Seed";
            this.generateCustomSeed.UseVisualStyleBackColor = true;
            this.generateCustomSeed.CheckedChanged += new System.EventHandler(this.GenerateCustomSeed_CheckedChanged);
            // 
            // generateParagraphSizeSlider
            // 
            this.generateParagraphSizeSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateParagraphSizeSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateParagraphSizeSlider.Location = new System.Drawing.Point(406, 28);
            this.generateParagraphSizeSlider.Margin = new System.Windows.Forms.Padding(0);
            this.generateParagraphSizeSlider.Maximum = 200;
            this.generateParagraphSizeSlider.Name = "generateParagraphSizeSlider";
            this.generateParagraphSizeSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.generateParagraphSizeSlider.Size = new System.Drawing.Size(132, 29);
            this.generateParagraphSizeSlider.TabIndex = 8;
            this.generateParagraphSizeSlider.TickFrequency = 75;
            this.generateParagraphSizeSlider.Value = 75;
            this.generateParagraphSizeSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GenerateParagraphSizeSlider_MouseUp);
            // 
            // generateParagraphSizeLabel
            // 
            this.generateParagraphSizeLabel.AutoSize = true;
            this.generateParagraphSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateParagraphSizeLabel.Location = new System.Drawing.Point(408, 0);
            this.generateParagraphSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generateParagraphSizeLabel.Name = "generateParagraphSizeLabel";
            this.generateParagraphSizeLabel.Size = new System.Drawing.Size(128, 28);
            this.generateParagraphSizeLabel.TabIndex = 9;
            this.generateParagraphSizeLabel.Text = "Paragraph sizes";
            this.generateParagraphSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generateOutputTextbox
            // 
            this.generateTableLayout.SetColumnSpan(this.generateOutputTextbox, 2);
            this.generateOutputTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateOutputTextbox.Location = new System.Drawing.Point(2, 60);
            this.generateOutputTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateOutputTextbox.Name = "generateOutputTextbox";
            this.generateOutputTextbox.ReadOnly = true;
            this.generateOutputTextbox.Size = new System.Drawing.Size(518, 426);
            this.generateOutputTextbox.TabIndex = 8;
            this.generateOutputTextbox.Text = "";
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
            this.CopyTimer.Tick += new System.EventHandler(this.CopyTimer_Tick);
            // 
            // htmlColorTagPicker
            // 
            this.htmlColorTagPicker.FullOpen = true;
            this.htmlColorTagPicker.SolidColorOnly = true;
            // 
            // htmlColorHoverTooltip
            // 
            this.htmlColorHoverTooltip.ToolTipTitle = "Color:";
            // 
            // FrameTimer
            // 
            this.FrameTimer.Interval = 20;
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // compareControl1
            // 
            this.compareControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compareControl1.Location = new System.Drawing.Point(2, 3);
            this.compareControl1.Margin = new System.Windows.Forms.Padding(0);
            this.compareControl1.Name = "compareControl1";
            this.compareControl1.Size = new System.Drawing.Size(588, 489);
            this.compareControl1.TabIndex = 0;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(854, 544);
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
            this.countTableLayout.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.countInputTableLayout.ResumeLayout(false);
            this.countInputTableLayout.PerformLayout();
            this.countTabs.ResumeLayout(false);
            this.countWordFrequencyTab.ResumeLayout(false);
            this.countWordDensityTab.ResumeLayout(false);
            this.countUniqueWordsTab.ResumeLayout(false);
            this.countInfoTableLayout.ResumeLayout(false);
            this.countInfoTableLayout.PerformLayout();
            this.countInfoFlowLayoutPanel.ResumeLayout(false);
            this.htmlTab.ResumeLayout(false);
            this.htmlTableLayout.ResumeLayout(false);
            this.htmlTableLayout.PerformLayout();
            this.htmlSettingsTableLayout.ResumeLayout(false);
            this.htmlSettingsTableLayout.PerformLayout();
            this.htmlColorCustomTableLayout.ResumeLayout(false);
            this.htmlColorEntityTableLayout.ResumeLayout(false);
            this.htmlColorTagOptionTableLayout.ResumeLayout(false);
            this.htmlInputTableLayout.ResumeLayout(false);
            this.htmlInputTableLayout.PerformLayout();
            this.htmlInputTextSettingsTableLayout.ResumeLayout(false);
            this.htmlInputTextSettingsTableLayout.PerformLayout();
            this.htmlOutputTableLayout.ResumeLayout(false);
            this.htmlOutputTableLayout.PerformLayout();
            this.htmlSideTableLayout.ResumeLayout(false);
            this.htmlSideTableLayout.PerformLayout();
            this.generateTextTab.ResumeLayout(false);
            this.generateTableLayout.ResumeLayout(false);
            this.generateTableLayout.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.generateSettingsTableLayout.ResumeLayout(false);
            this.generateSettingsTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateNumberOfWords)).EndInit();
            this.generateSeedTableLayout.ResumeLayout(false);
            this.generateSeedTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateParagraphSizeSlider)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel htmlTableLayout;
        private System.Windows.Forms.TableLayoutPanel htmlSettingsTableLayout;
        private System.Windows.Forms.Button htmlButton;
        private System.Windows.Forms.TableLayoutPanel htmlInputTableLayout;
        private System.Windows.Forms.Label htmlInputLabel;
        private System.Windows.Forms.RichTextBox htmlInputTextbox;
        private System.Windows.Forms.TableLayoutPanel htmlInputTextSettingsTableLayout;
        private System.Windows.Forms.CheckBox htmlBoldButton;
        private System.Windows.Forms.CheckBox htmlItalicButton;
        private System.Windows.Forms.CheckBox htmlStrikeThroughButton;
        private System.Windows.Forms.CheckBox htmlUnderscoreButton;
        private System.Windows.Forms.CheckBox htmlLoweredButton;
        private System.Windows.Forms.CheckBox htmlRaisedButton;
        private System.Windows.Forms.TableLayoutPanel htmlOutputTableLayout;
        private System.Windows.Forms.Label htmlOutputLabel;
        private System.Windows.Forms.RichTextBox htmlOutputTextbox;
        private System.Windows.Forms.CheckBox htmlColorTagsCheckbox;
        private System.Windows.Forms.ColorDialog htmlColorTagPicker;
        private System.Windows.Forms.TableLayoutPanel htmlColorTagOptionTableLayout;
        private System.Windows.Forms.Button htmlChooseColorButton;
        private System.Windows.Forms.Button htmlTagColorRectangle;
        private System.Windows.Forms.ToolTip htmlColorHoverTooltip;
        private System.Windows.Forms.CheckBox htmlColorEntitiesCheckbox;
        private System.Windows.Forms.TableLayoutPanel htmlColorEntityTableLayout;
        private System.Windows.Forms.Button htmlChangeEntityColorButton;
        private System.Windows.Forms.Button htmlEntityColorRectangle;
        private System.Windows.Forms.Button htmlCustomRulesButton;
        private System.Windows.Forms.TableLayoutPanel htmlColorCustomTableLayout;
        private System.Windows.Forms.Button htmlChangeCustomColorButton;
        private System.Windows.Forms.Button htmlCustomColorRectangle;
        private System.Windows.Forms.CheckBox htmlColorCustomCheckbox;
        private System.Windows.Forms.TableLayoutPanel htmlSideTableLayout;
        private System.Windows.Forms.Button htmlCopyButton;
        private System.Windows.Forms.Label htmlCopyLabel;
        private System.Windows.Forms.Button htmlClearButton;
        private System.Windows.Forms.Button htmlOpenAllTags;
        private System.Windows.Forms.TabPage generateTextTab;
        private System.Windows.Forms.TableLayoutPanel generateTableLayout;
        private System.Windows.Forms.TableLayoutPanel generateSettingsTableLayout;
        private System.Windows.Forms.Button generateGenerateButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button generateClearButton;
        private System.Windows.Forms.Button generateCopyButton;
        private System.Windows.Forms.RichTextBox generateOutputTextbox;
        private System.Windows.Forms.Label generateCopyLabel;
        private System.Windows.Forms.ComboBox generateParagraphType;
        private System.Windows.Forms.Label generateParagraphTypeLabel;
        private System.Windows.Forms.NumericUpDown generateNumberOfWords;
        private System.Windows.Forms.Label generateAmountOfWordsLabel;
        private System.Windows.Forms.NumericUpDown generateSeed;
        private System.Windows.Forms.TableLayoutPanel generateSeedTableLayout;
        private System.Windows.Forms.Label generateSeedLabel;
        private System.Windows.Forms.CheckBox generateCustomSeed;
        private System.Windows.Forms.TrackBar generateParagraphSizeSlider;
        private System.Windows.Forms.Label generateParagraphSizeLabel;
        private System.Windows.Forms.TableLayoutPanel countTableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TableLayoutPanel countInputTableLayout;
        private System.Windows.Forms.RichTextBox countInputTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl countTabs;
        private System.Windows.Forms.TabPage countWordFrequencyTab;
        private System.Windows.Forms.TabPage countWordDensityTab;
        private System.Windows.Forms.TableLayoutPanel countInfoTableLayout;
        private System.Windows.Forms.Label countInfoLabel;
        private System.Windows.Forms.FlowLayoutPanel countInfoFlowLayoutPanel;
        private CountDetail countDetailWords;
        private CountDetail countDetailCharacters;
        private CountDetail countDetailSentences;
        private CountDetail countDetailParagraphs;
        private CountDetail countDetailUniqueWords;
        private CountDetail countDetailDifferentWords;
        private System.Windows.Forms.FlowLayoutPanel countWordFrequencyFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel countWordDensityFlowLayoutPanel;
        private System.Windows.Forms.TabPage countUniqueWordsTab;
        private System.Windows.Forms.FlowLayoutPanel countUniqueWordsFlowLayoutPanel;
        private System.Windows.Forms.Button countClearButton;
        private System.Windows.Forms.ComboBox countSortModes;
        private System.Windows.Forms.Label countSortModeLabel;
        private System.Windows.Forms.CheckBox countCaseSensitive;
        private NavigationMenu navigationMenu;
        private System.Windows.Forms.Timer FrameTimer;
        private SortControl sortControl1;
        private CompareControl compareControl1;
    }
}

