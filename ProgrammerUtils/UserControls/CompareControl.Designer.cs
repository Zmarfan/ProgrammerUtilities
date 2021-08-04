
namespace ProgrammerUtils
{
    partial class CompareControl
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
            this.matchTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.matchLeftText2Label = new System.Windows.Forms.Label();
            this.MatchLeftText2 = new System.Windows.Forms.RichTextBox();
            this.MatchLeftText1 = new System.Windows.Forms.RichTextBox();
            this.matchLeftText1Label = new System.Windows.Forms.Label();
            this.matchSettingsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.matchMatchButton = new System.Windows.Forms.Button();
            this.matchAutoCompare = new System.Windows.Forms.CheckBox();
            this.matchCaseSensitive = new System.Windows.Forms.CheckBox();
            this.MatchRemoveExtraWhiteSpace = new System.Windows.Forms.CheckBox();
            this.matchClearButton = new System.Windows.Forms.Button();
            this.MatchCombinedShowModeDropdown = new System.Windows.Forms.ComboBox();
            this.matchCombineStateLabel = new System.Windows.Forms.Label();
            this.matchResultTab = new System.Windows.Forms.TabControl();
            this.matchResultTabSeperate = new System.Windows.Forms.TabPage();
            this.matcherSeperateTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.matchRightText2Label = new System.Windows.Forms.Label();
            this.matchRightText1Label = new System.Windows.Forms.Label();
            this.matchRightText2 = new System.Windows.Forms.RichTextBox();
            this.matchRightText1 = new System.Windows.Forms.RichTextBox();
            this.matchResultTabCombined = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.matchResultCombinedTextBox = new System.Windows.Forms.RichTextBox();
            this.matchResultTabCombinedLabel = new System.Windows.Forms.Label();
            this.matchTableLayout.SuspendLayout();
            this.matchSettingsTableLayout.SuspendLayout();
            this.matchResultTab.SuspendLayout();
            this.matchResultTabSeperate.SuspendLayout();
            this.matcherSeperateTableLayout.SuspendLayout();
            this.matchResultTabCombined.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // matchTableLayout
            // 
            this.matchTableLayout.ColumnCount = 2;
            this.matchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.matchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.matchTableLayout.Controls.Add(this.matchLeftText2Label, 0, 3);
            this.matchTableLayout.Controls.Add(this.MatchLeftText2, 0, 4);
            this.matchTableLayout.Controls.Add(this.MatchLeftText1, 0, 2);
            this.matchTableLayout.Controls.Add(this.matchLeftText1Label, 0, 1);
            this.matchTableLayout.Controls.Add(this.matchSettingsTableLayout, 0, 0);
            this.matchTableLayout.Controls.Add(this.matchResultTab, 1, 1);
            this.matchTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchTableLayout.Location = new System.Drawing.Point(0, 0);
            this.matchTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.matchTableLayout.Name = "matchTableLayout";
            this.matchTableLayout.RowCount = 5;
            this.matchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.matchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.matchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.matchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.matchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.matchTableLayout.Size = new System.Drawing.Size(564, 371);
            this.matchTableLayout.TabIndex = 1;
            // 
            // matchLeftText2Label
            // 
            this.matchLeftText2Label.AutoSize = true;
            this.matchLeftText2Label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.matchLeftText2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matchLeftText2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchLeftText2Label.ForeColor = System.Drawing.Color.DarkGreen;
            this.matchLeftText2Label.Location = new System.Drawing.Point(2, 208);
            this.matchLeftText2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matchLeftText2Label.Name = "matchLeftText2Label";
            this.matchLeftText2Label.Size = new System.Drawing.Size(278, 28);
            this.matchLeftText2Label.TabIndex = 3;
            this.matchLeftText2Label.Text = "Text two";
            this.matchLeftText2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MatchLeftText2
            // 
            this.MatchLeftText2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatchLeftText2.Location = new System.Drawing.Point(2, 238);
            this.MatchLeftText2.Margin = new System.Windows.Forms.Padding(2);
            this.MatchLeftText2.Name = "MatchLeftText2";
            this.MatchLeftText2.Size = new System.Drawing.Size(278, 131);
            this.MatchLeftText2.TabIndex = 1;
            this.MatchLeftText2.Text = "";
            this.MatchLeftText2.TextChanged += new System.EventHandler(this.MatchTextChanged);
            // 
            // MatchLeftText1
            // 
            this.MatchLeftText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatchLeftText1.Location = new System.Drawing.Point(2, 76);
            this.MatchLeftText1.Margin = new System.Windows.Forms.Padding(2);
            this.MatchLeftText1.Name = "MatchLeftText1";
            this.MatchLeftText1.Size = new System.Drawing.Size(278, 130);
            this.MatchLeftText1.TabIndex = 0;
            this.MatchLeftText1.Text = "";
            this.MatchLeftText1.TextChanged += new System.EventHandler(this.MatchTextChanged);
            // 
            // matchLeftText1Label
            // 
            this.matchLeftText1Label.AutoSize = true;
            this.matchLeftText1Label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.matchLeftText1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matchLeftText1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchLeftText1Label.ForeColor = System.Drawing.Color.Red;
            this.matchLeftText1Label.Location = new System.Drawing.Point(2, 46);
            this.matchLeftText1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matchLeftText1Label.Name = "matchLeftText1Label";
            this.matchLeftText1Label.Size = new System.Drawing.Size(278, 28);
            this.matchLeftText1Label.TabIndex = 2;
            this.matchLeftText1Label.Text = "Text one";
            this.matchLeftText1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchSettingsTableLayout
            // 
            this.matchSettingsTableLayout.ColumnCount = 6;
            this.matchTableLayout.SetColumnSpan(this.matchSettingsTableLayout, 2);
            this.matchSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.matchSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.matchSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.matchSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.matchSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.matchSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.matchSettingsTableLayout.Controls.Add(this.matchMatchButton, 0, 0);
            this.matchSettingsTableLayout.Controls.Add(this.matchAutoCompare, 1, 0);
            this.matchSettingsTableLayout.Controls.Add(this.matchCaseSensitive, 2, 0);
            this.matchSettingsTableLayout.Controls.Add(this.MatchRemoveExtraWhiteSpace, 2, 1);
            this.matchSettingsTableLayout.Controls.Add(this.matchClearButton, 5, 0);
            this.matchSettingsTableLayout.Controls.Add(this.MatchCombinedShowModeDropdown, 3, 1);
            this.matchSettingsTableLayout.Controls.Add(this.matchCombineStateLabel, 3, 0);
            this.matchSettingsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchSettingsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.matchSettingsTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.matchSettingsTableLayout.Name = "matchSettingsTableLayout";
            this.matchSettingsTableLayout.RowCount = 2;
            this.matchSettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.matchSettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.matchSettingsTableLayout.Size = new System.Drawing.Size(564, 46);
            this.matchSettingsTableLayout.TabIndex = 6;
            // 
            // matchMatchButton
            // 
            this.matchMatchButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.matchMatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matchMatchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchMatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matchMatchButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchMatchButton.Location = new System.Drawing.Point(2, 2);
            this.matchMatchButton.Margin = new System.Windows.Forms.Padding(2);
            this.matchMatchButton.Name = "matchMatchButton";
            this.matchSettingsTableLayout.SetRowSpan(this.matchMatchButton, 2);
            this.matchMatchButton.Size = new System.Drawing.Size(127, 42);
            this.matchMatchButton.TabIndex = 0;
            this.matchMatchButton.Text = "Compare";
            this.matchMatchButton.UseVisualStyleBackColor = false;
            this.matchMatchButton.Click += new System.EventHandler(this.MatchMatchButton_Click);
            // 
            // matchAutoCompare
            // 
            this.matchAutoCompare.AutoSize = true;
            this.matchAutoCompare.Checked = true;
            this.matchAutoCompare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.matchAutoCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matchAutoCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchAutoCompare.Location = new System.Drawing.Point(133, 2);
            this.matchAutoCompare.Margin = new System.Windows.Forms.Padding(2);
            this.matchAutoCompare.Name = "matchAutoCompare";
            this.matchSettingsTableLayout.SetRowSpan(this.matchAutoCompare, 2);
            this.matchAutoCompare.Size = new System.Drawing.Size(94, 42);
            this.matchAutoCompare.TabIndex = 1;
            this.matchAutoCompare.Text = "Auto Compare";
            this.matchAutoCompare.UseVisualStyleBackColor = true;
            this.matchAutoCompare.CheckedChanged += new System.EventHandler(this.MatchAutoCompare_CheckedChanged);
            // 
            // matchCaseSensitive
            // 
            this.matchCaseSensitive.AutoSize = true;
            this.matchCaseSensitive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matchCaseSensitive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchCaseSensitive.Location = new System.Drawing.Point(231, 2);
            this.matchCaseSensitive.Margin = new System.Windows.Forms.Padding(2);
            this.matchCaseSensitive.Name = "matchCaseSensitive";
            this.matchCaseSensitive.Size = new System.Drawing.Size(134, 19);
            this.matchCaseSensitive.TabIndex = 2;
            this.matchCaseSensitive.Text = "Case Sensitive";
            this.matchCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // MatchRemoveExtraWhiteSpace
            // 
            this.MatchRemoveExtraWhiteSpace.AutoSize = true;
            this.MatchRemoveExtraWhiteSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MatchRemoveExtraWhiteSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatchRemoveExtraWhiteSpace.Location = new System.Drawing.Point(231, 25);
            this.MatchRemoveExtraWhiteSpace.Margin = new System.Windows.Forms.Padding(2);
            this.MatchRemoveExtraWhiteSpace.Name = "MatchRemoveExtraWhiteSpace";
            this.MatchRemoveExtraWhiteSpace.Size = new System.Drawing.Size(134, 19);
            this.MatchRemoveExtraWhiteSpace.TabIndex = 3;
            this.MatchRemoveExtraWhiteSpace.Text = "Remove Extra Whitespaces";
            this.MatchRemoveExtraWhiteSpace.UseVisualStyleBackColor = true;
            // 
            // matchClearButton
            // 
            this.matchClearButton.BackColor = System.Drawing.Color.LightPink;
            this.matchClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matchClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matchClearButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchClearButton.Location = new System.Drawing.Point(484, 2);
            this.matchClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.matchClearButton.Name = "matchClearButton";
            this.matchSettingsTableLayout.SetRowSpan(this.matchClearButton, 2);
            this.matchClearButton.Size = new System.Drawing.Size(78, 42);
            this.matchClearButton.TabIndex = 4;
            this.matchClearButton.Text = "Clear";
            this.matchClearButton.UseVisualStyleBackColor = false;
            this.matchClearButton.Click += new System.EventHandler(this.MatchClearButton_Click);
            // 
            // MatchCombinedShowModeDropdown
            // 
            this.MatchCombinedShowModeDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatchCombinedShowModeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchCombinedShowModeDropdown.FormattingEnabled = true;
            this.MatchCombinedShowModeDropdown.Items.AddRange(new object[] {
            "Every line",
            "Every word"});
            this.MatchCombinedShowModeDropdown.Location = new System.Drawing.Point(369, 25);
            this.MatchCombinedShowModeDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.MatchCombinedShowModeDropdown.Name = "MatchCombinedShowModeDropdown";
            this.MatchCombinedShowModeDropdown.Size = new System.Drawing.Size(108, 21);
            this.MatchCombinedShowModeDropdown.TabIndex = 5;
            this.MatchCombinedShowModeDropdown.SelectedIndexChanged += new System.EventHandler(this.MatchCombinedShowModeDropdown_SelectedIndexChanged);
            // 
            // matchCombineStateLabel
            // 
            this.matchCombineStateLabel.AutoSize = true;
            this.matchCombineStateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchCombineStateLabel.Location = new System.Drawing.Point(369, 0);
            this.matchCombineStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matchCombineStateLabel.Name = "matchCombineStateLabel";
            this.matchCombineStateLabel.Size = new System.Drawing.Size(108, 23);
            this.matchCombineStateLabel.TabIndex = 6;
            this.matchCombineStateLabel.Text = "Compare mode";
            this.matchCombineStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matchResultTab
            // 
            this.matchResultTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.matchResultTab.Controls.Add(this.matchResultTabSeperate);
            this.matchResultTab.Controls.Add(this.matchResultTabCombined);
            this.matchResultTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchResultTab.Location = new System.Drawing.Point(282, 48);
            this.matchResultTab.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.matchResultTab.Name = "matchResultTab";
            this.matchTableLayout.SetRowSpan(this.matchResultTab, 4);
            this.matchResultTab.SelectedIndex = 0;
            this.matchResultTab.Size = new System.Drawing.Size(282, 323);
            this.matchResultTab.TabIndex = 7;
            // 
            // matchResultTabSeperate
            // 
            this.matchResultTabSeperate.Controls.Add(this.matcherSeperateTableLayout);
            this.matchResultTabSeperate.Location = new System.Drawing.Point(4, 25);
            this.matchResultTabSeperate.Margin = new System.Windows.Forms.Padding(0);
            this.matchResultTabSeperate.Name = "matchResultTabSeperate";
            this.matchResultTabSeperate.Size = new System.Drawing.Size(274, 294);
            this.matchResultTabSeperate.TabIndex = 0;
            this.matchResultTabSeperate.Text = "Separate";
            this.matchResultTabSeperate.UseVisualStyleBackColor = true;
            // 
            // matcherSeperateTableLayout
            // 
            this.matcherSeperateTableLayout.ColumnCount = 1;
            this.matcherSeperateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.matcherSeperateTableLayout.Controls.Add(this.matchRightText2Label, 0, 2);
            this.matcherSeperateTableLayout.Controls.Add(this.matchRightText1Label, 0, 0);
            this.matcherSeperateTableLayout.Controls.Add(this.matchRightText2, 0, 3);
            this.matcherSeperateTableLayout.Controls.Add(this.matchRightText1, 0, 1);
            this.matcherSeperateTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matcherSeperateTableLayout.Location = new System.Drawing.Point(0, 0);
            this.matcherSeperateTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.matcherSeperateTableLayout.Name = "matcherSeperateTableLayout";
            this.matcherSeperateTableLayout.RowCount = 4;
            this.matcherSeperateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.matcherSeperateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.matcherSeperateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.matcherSeperateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.matcherSeperateTableLayout.Size = new System.Drawing.Size(274, 294);
            this.matcherSeperateTableLayout.TabIndex = 0;
            // 
            // matchRightText2Label
            // 
            this.matchRightText2Label.AutoSize = true;
            this.matchRightText2Label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.matchRightText2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matchRightText2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchRightText2Label.Location = new System.Drawing.Point(2, 147);
            this.matchRightText2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matchRightText2Label.Name = "matchRightText2Label";
            this.matchRightText2Label.Size = new System.Drawing.Size(270, 28);
            this.matchRightText2Label.TabIndex = 12;
            this.matchRightText2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchRightText1Label
            // 
            this.matchRightText1Label.AutoSize = true;
            this.matchRightText1Label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.matchRightText1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matchRightText1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchRightText1Label.Location = new System.Drawing.Point(2, 0);
            this.matchRightText1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matchRightText1Label.Name = "matchRightText1Label";
            this.matchRightText1Label.Size = new System.Drawing.Size(270, 28);
            this.matchRightText1Label.TabIndex = 11;
            this.matchRightText1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchRightText2
            // 
            this.matchRightText2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchRightText2.Location = new System.Drawing.Point(2, 177);
            this.matchRightText2.Margin = new System.Windows.Forms.Padding(2);
            this.matchRightText2.Name = "matchRightText2";
            this.matchRightText2.ReadOnly = true;
            this.matchRightText2.Size = new System.Drawing.Size(270, 115);
            this.matchRightText2.TabIndex = 10;
            this.matchRightText2.Text = "";
            // 
            // matchRightText1
            // 
            this.matchRightText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchRightText1.Location = new System.Drawing.Point(2, 30);
            this.matchRightText1.Margin = new System.Windows.Forms.Padding(2);
            this.matchRightText1.Name = "matchRightText1";
            this.matchRightText1.ReadOnly = true;
            this.matchRightText1.Size = new System.Drawing.Size(270, 115);
            this.matchRightText1.TabIndex = 9;
            this.matchRightText1.Text = "";
            // 
            // matchResultTabCombined
            // 
            this.matchResultTabCombined.Controls.Add(this.tableLayoutPanel4);
            this.matchResultTabCombined.Location = new System.Drawing.Point(4, 25);
            this.matchResultTabCombined.Margin = new System.Windows.Forms.Padding(0);
            this.matchResultTabCombined.Name = "matchResultTabCombined";
            this.matchResultTabCombined.Size = new System.Drawing.Size(274, 294);
            this.matchResultTabCombined.TabIndex = 1;
            this.matchResultTabCombined.Text = "Combined";
            this.matchResultTabCombined.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel4.Controls.Add(this.matchResultCombinedTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.matchResultTabCombinedLabel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(274, 294);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // matchResultCombinedTextBox
            // 
            this.matchResultCombinedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchResultCombinedTextBox.Location = new System.Drawing.Point(2, 30);
            this.matchResultCombinedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.matchResultCombinedTextBox.Name = "matchResultCombinedTextBox";
            this.matchResultCombinedTextBox.ReadOnly = true;
            this.matchResultCombinedTextBox.Size = new System.Drawing.Size(270, 262);
            this.matchResultCombinedTextBox.TabIndex = 10;
            this.matchResultCombinedTextBox.Text = "";
            // 
            // matchResultTabCombinedLabel
            // 
            this.matchResultTabCombinedLabel.AutoSize = true;
            this.matchResultTabCombinedLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.matchResultTabCombinedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matchResultTabCombinedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchResultTabCombinedLabel.Location = new System.Drawing.Point(2, 0);
            this.matchResultTabCombinedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matchResultTabCombinedLabel.Name = "matchResultTabCombinedLabel";
            this.matchResultTabCombinedLabel.Size = new System.Drawing.Size(270, 28);
            this.matchResultTabCombinedLabel.TabIndex = 3;
            this.matchResultTabCombinedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompareControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.matchTableLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CompareControl";
            this.Size = new System.Drawing.Size(564, 371);
            this.matchTableLayout.ResumeLayout(false);
            this.matchTableLayout.PerformLayout();
            this.matchSettingsTableLayout.ResumeLayout(false);
            this.matchSettingsTableLayout.PerformLayout();
            this.matchResultTab.ResumeLayout(false);
            this.matchResultTabSeperate.ResumeLayout(false);
            this.matcherSeperateTableLayout.ResumeLayout(false);
            this.matcherSeperateTableLayout.PerformLayout();
            this.matchResultTabCombined.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel matchTableLayout;
        private System.Windows.Forms.Label matchLeftText2Label;
        private System.Windows.Forms.RichTextBox MatchLeftText2;
        private System.Windows.Forms.RichTextBox MatchLeftText1;
        private System.Windows.Forms.Label matchLeftText1Label;
        private System.Windows.Forms.TableLayoutPanel matchSettingsTableLayout;
        private System.Windows.Forms.Button matchMatchButton;
        private System.Windows.Forms.CheckBox matchAutoCompare;
        private System.Windows.Forms.CheckBox matchCaseSensitive;
        private System.Windows.Forms.CheckBox MatchRemoveExtraWhiteSpace;
        private System.Windows.Forms.Button matchClearButton;
        private System.Windows.Forms.ComboBox MatchCombinedShowModeDropdown;
        private System.Windows.Forms.Label matchCombineStateLabel;
        private System.Windows.Forms.TabControl matchResultTab;
        private System.Windows.Forms.TabPage matchResultTabSeperate;
        private System.Windows.Forms.TableLayoutPanel matcherSeperateTableLayout;
        private System.Windows.Forms.Label matchRightText2Label;
        private System.Windows.Forms.Label matchRightText1Label;
        private System.Windows.Forms.RichTextBox matchRightText2;
        private System.Windows.Forms.RichTextBox matchRightText1;
        private System.Windows.Forms.TabPage matchResultTabCombined;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RichTextBox matchResultCombinedTextBox;
        private System.Windows.Forms.Label matchResultTabCombinedLabel;
    }
}
