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
            this.matchCompareTab = new System.Windows.Forms.TabPage();
            this.CountTab = new System.Windows.Forms.TabPage();
            this.htmlTab = new System.Windows.Forms.TabPage();
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
            this.CopyTimer = new System.Windows.Forms.Timer(this.components);
            this.htmlColorTagPicker = new System.Windows.Forms.ColorDialog();
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.sortControl1 = new ProgrammerUtils.SortControl();
            this.compareControl1 = new ProgrammerUtils.CompareControl();
            this.countControl1 = new ProgrammerUtils.CountControl();
            this.navigationMenu = new ProgrammerUtils.NavigationMenu();
            this.htmlControl1 = new ProgrammerUtils.HTMLControl();
            this.MainTableLayout.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SortTab.SuspendLayout();
            this.matchCompareTab.SuspendLayout();
            this.CountTab.SuspendLayout();
            this.htmlTab.SuspendLayout();
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
            this.SortTab.Size = new System.Drawing.Size(588, 495);
            this.SortTab.TabIndex = 0;
            this.SortTab.Text = "Sort";
            // 
            // matchCompareTab
            // 
            this.matchCompareTab.Controls.Add(this.compareControl1);
            this.matchCompareTab.Location = new System.Drawing.Point(4, 39);
            this.matchCompareTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matchCompareTab.Name = "matchCompareTab";
            this.matchCompareTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matchCompareTab.Size = new System.Drawing.Size(588, 495);
            this.matchCompareTab.TabIndex = 1;
            this.matchCompareTab.Text = "Compare";
            this.matchCompareTab.UseVisualStyleBackColor = true;
            // 
            // CountTab
            // 
            this.CountTab.Controls.Add(this.countControl1);
            this.CountTab.Location = new System.Drawing.Point(4, 39);
            this.CountTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CountTab.Name = "CountTab";
            this.CountTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CountTab.Size = new System.Drawing.Size(588, 495);
            this.CountTab.TabIndex = 2;
            this.CountTab.Text = "Count";
            this.CountTab.UseVisualStyleBackColor = true;
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
            // generateTextTab
            // 
            this.generateTextTab.Controls.Add(this.generateTableLayout);
            this.generateTextTab.Location = new System.Drawing.Point(4, 39);
            this.generateTextTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateTextTab.Name = "generateTextTab";
            this.generateTextTab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateTextTab.Size = new System.Drawing.Size(588, 495);
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
            this.generateTableLayout.Size = new System.Drawing.Size(584, 489);
            this.generateTableLayout.TabIndex = 0;
            // 
            // generateCopyLabel
            // 
            this.generateCopyLabel.AutoSize = true;
            this.generateCopyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateCopyLabel.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCopyLabel.ForeColor = System.Drawing.Color.Green;
            this.generateCopyLabel.Location = new System.Drawing.Point(520, 0);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(518, 57);
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
            this.generateSettingsTableLayout.Size = new System.Drawing.Size(518, 57);
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
            this.generateOutputTextbox.Size = new System.Drawing.Size(514, 426);
            this.generateOutputTextbox.TabIndex = 8;
            this.generateOutputTextbox.Text = "";
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
            // sortControl1
            // 
            this.sortControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortControl1.Location = new System.Drawing.Point(2, 3);
            this.sortControl1.Margin = new System.Windows.Forms.Padding(0);
            this.sortControl1.Name = "sortControl1";
            this.sortControl1.Size = new System.Drawing.Size(584, 489);
            this.sortControl1.TabIndex = 0;
            // 
            // compareControl1
            // 
            this.compareControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compareControl1.Location = new System.Drawing.Point(2, 3);
            this.compareControl1.Margin = new System.Windows.Forms.Padding(0);
            this.compareControl1.Name = "compareControl1";
            this.compareControl1.Size = new System.Drawing.Size(584, 489);
            this.compareControl1.TabIndex = 0;
            // 
            // countControl1
            // 
            this.countControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countControl1.Location = new System.Drawing.Point(2, 3);
            this.countControl1.Margin = new System.Windows.Forms.Padding(0);
            this.countControl1.Name = "countControl1";
            this.countControl1.Size = new System.Drawing.Size(584, 489);
            this.countControl1.TabIndex = 0;
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
            // htmlControl1
            // 
            this.htmlControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlControl1.Location = new System.Drawing.Point(2, 3);
            this.htmlControl1.Margin = new System.Windows.Forms.Padding(0);
            this.htmlControl1.Name = "htmlControl1";
            this.htmlControl1.Size = new System.Drawing.Size(684, 489);
            this.htmlControl1.TabIndex = 0;
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
        private System.Windows.Forms.ColorDialog htmlColorTagPicker;
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
        private NavigationMenu navigationMenu;
        private System.Windows.Forms.Timer FrameTimer;
        private SortControl sortControl1;
        private CompareControl compareControl1;
        private CountControl countControl1;
        private HTMLControl htmlControl1;
    }
}

