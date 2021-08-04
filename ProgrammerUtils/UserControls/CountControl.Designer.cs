
namespace ProgrammerUtils
{
    partial class CountControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.countTableLayout.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.countInputTableLayout.SuspendLayout();
            this.countTabs.SuspendLayout();
            this.countWordFrequencyTab.SuspendLayout();
            this.countWordDensityTab.SuspendLayout();
            this.countUniqueWordsTab.SuspendLayout();
            this.countInfoTableLayout.SuspendLayout();
            this.countInfoFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // countTableLayout
            // 
            this.countTableLayout.ColumnCount = 3;
            this.countTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.countTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.countTableLayout.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.countTableLayout.Controls.Add(this.countInputTableLayout, 0, 1);
            this.countTableLayout.Controls.Add(this.countTabs, 2, 1);
            this.countTableLayout.Controls.Add(this.countInfoTableLayout, 1, 1);
            this.countTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countTableLayout.Location = new System.Drawing.Point(0, 0);
            this.countTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.countTableLayout.Name = "countTableLayout";
            this.countTableLayout.RowCount = 2;
            this.countTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.countTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countTableLayout.Size = new System.Drawing.Size(677, 443);
            this.countTableLayout.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.countTableLayout.SetColumnSpan(this.tableLayoutPanel5, 3);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(677, 57);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // countClearButton
            // 
            this.countClearButton.BackColor = System.Drawing.Color.LightPink;
            this.countClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countClearButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countClearButton.Location = new System.Drawing.Point(569, 3);
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
            this.countSortModes.Size = new System.Drawing.Size(146, 24);
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
            this.countSortModeLabel.Size = new System.Drawing.Size(146, 28);
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
            this.countCaseSensitive.Location = new System.Drawing.Point(327, 3);
            this.countCaseSensitive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countCaseSensitive.Name = "countCaseSensitive";
            this.tableLayoutPanel5.SetRowSpan(this.countCaseSensitive, 2);
            this.countCaseSensitive.Size = new System.Drawing.Size(121, 51);
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
            this.countInputTableLayout.Size = new System.Drawing.Size(140, 386);
            this.countInputTableLayout.TabIndex = 3;
            // 
            // countInputTextbox
            // 
            this.countInputTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countInputTextbox.Location = new System.Drawing.Point(2, 3);
            this.countInputTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countInputTextbox.Name = "countInputTextbox";
            this.countInputTextbox.Size = new System.Drawing.Size(136, 324);
            this.countInputTextbox.TabIndex = 4;
            this.countInputTextbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.label2.Size = new System.Drawing.Size(136, 56);
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
            this.countTabs.Location = new System.Drawing.Point(404, 60);
            this.countTabs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.countTabs.Name = "countTabs";
            this.countTabs.SelectedIndex = 0;
            this.countTabs.Size = new System.Drawing.Size(271, 380);
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
            this.countWordFrequencyTab.Size = new System.Drawing.Size(263, 351);
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
            this.countWordFrequencyFlowLayoutPanel.Size = new System.Drawing.Size(259, 345);
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
            this.countWordDensityTab.Size = new System.Drawing.Size(263, 351);
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
            this.countWordDensityFlowLayoutPanel.Size = new System.Drawing.Size(259, 345);
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
            this.countUniqueWordsTab.Size = new System.Drawing.Size(263, 351);
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
            this.countUniqueWordsFlowLayoutPanel.Size = new System.Drawing.Size(259, 345);
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
            this.countInfoTableLayout.Location = new System.Drawing.Point(140, 57);
            this.countInfoTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.countInfoTableLayout.Name = "countInfoTableLayout";
            this.countInfoTableLayout.RowCount = 2;
            this.countInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.countInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countInfoTableLayout.Size = new System.Drawing.Size(262, 386);
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
            this.countInfoLabel.Size = new System.Drawing.Size(258, 38);
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
            this.countInfoFlowLayoutPanel.Size = new System.Drawing.Size(258, 342);
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
            // CountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.countTableLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CountControl";
            this.Size = new System.Drawing.Size(677, 443);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel countTableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button countClearButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.ComboBox countSortModes;
        private System.Windows.Forms.Label countSortModeLabel;
        private System.Windows.Forms.CheckBox countCaseSensitive;
        private System.Windows.Forms.TableLayoutPanel countInputTableLayout;
        private System.Windows.Forms.RichTextBox countInputTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl countTabs;
        private System.Windows.Forms.TabPage countWordFrequencyTab;
        private System.Windows.Forms.FlowLayoutPanel countWordFrequencyFlowLayoutPanel;
        private System.Windows.Forms.TabPage countWordDensityTab;
        private System.Windows.Forms.FlowLayoutPanel countWordDensityFlowLayoutPanel;
        private System.Windows.Forms.TabPage countUniqueWordsTab;
        private System.Windows.Forms.FlowLayoutPanel countUniqueWordsFlowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel countInfoTableLayout;
        private System.Windows.Forms.Label countInfoLabel;
        private System.Windows.Forms.FlowLayoutPanel countInfoFlowLayoutPanel;
        private CountDetail countDetailWords;
        private CountDetail countDetailUniqueWords;
        private CountDetail countDetailDifferentWords;
        private CountDetail countDetailCharacters;
        private CountDetail countDetailSentences;
        private CountDetail countDetailParagraphs;
    }
}
