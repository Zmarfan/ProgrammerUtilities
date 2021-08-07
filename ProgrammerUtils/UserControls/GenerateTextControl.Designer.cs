
namespace ProgrammerUtils
{
    partial class GenerateTextControl
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
            this.components = new System.ComponentModel.Container();
            this.generateTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sortLabel1BorderPanel = new ProgrammerUtils.BorderPanel();
            this.sortLabel1 = new System.Windows.Forms.Label();
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
            this.inputTextBorderPanel = new ProgrammerUtils.BorderPanel();
            this.generateOutputTextbox = new System.Windows.Forms.RichTextBox();
            this.CopyTimer = new System.Windows.Forms.Timer(this.components);
            this.generateTableLayout.SuspendLayout();
            this.sortLabel1BorderPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.generateSettingsTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateNumberOfWords)).BeginInit();
            this.generateSeedTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateParagraphSizeSlider)).BeginInit();
            this.inputTextBorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateTableLayout
            // 
            this.generateTableLayout.ColumnCount = 3;
            this.generateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generateTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.generateTableLayout.Controls.Add(this.sortLabel1BorderPanel, 0, 2);
            this.generateTableLayout.Controls.Add(this.generateCopyLabel, 1, 0);
            this.generateTableLayout.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.generateTableLayout.Controls.Add(this.generateSettingsTableLayout, 0, 0);
            this.generateTableLayout.Controls.Add(this.inputTextBorderPanel, 0, 1);
            this.generateTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateTableLayout.Location = new System.Drawing.Point(4, 4);
            this.generateTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.generateTableLayout.Name = "generateTableLayout";
            this.generateTableLayout.RowCount = 3;
            this.generateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.generateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generateTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.generateTableLayout.Size = new System.Drawing.Size(765, 434);
            this.generateTableLayout.TabIndex = 1;
            // 
            // sortLabel1BorderPanel
            // 
            this.sortLabel1BorderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.sortLabel1BorderPanel.BorderWidth = 2;
            this.generateTableLayout.SetColumnSpan(this.sortLabel1BorderPanel, 2);
            this.sortLabel1BorderPanel.Controls.Add(this.sortLabel1);
            this.sortLabel1BorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortLabel1BorderPanel.Location = new System.Drawing.Point(4, 393);
            this.sortLabel1BorderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sortLabel1BorderPanel.Name = "sortLabel1BorderPanel";
            this.sortLabel1BorderPanel.Padding = new System.Windows.Forms.Padding(4);
            this.sortLabel1BorderPanel.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.sortLabel1BorderPanel.Size = new System.Drawing.Size(704, 37);
            this.sortLabel1BorderPanel.TabIndex = 12;
            // 
            // sortLabel1
            // 
            this.sortLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.sortLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortLabel1.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLabel1.Location = new System.Drawing.Point(4, 4);
            this.sortLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sortLabel1.Name = "sortLabel1";
            this.sortLabel1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.sortLabel1.Size = new System.Drawing.Size(696, 29);
            this.sortLabel1.TabIndex = 4;
            this.sortLabel1.Text = "Generated Text.";
            this.sortLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateCopyLabel
            // 
            this.generateCopyLabel.AutoSize = true;
            this.generateCopyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateCopyLabel.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCopyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.generateCopyLabel.Location = new System.Drawing.Point(712, 0);
            this.generateCopyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.generateCopyLabel.Name = "generateCopyLabel";
            this.generateCopyLabel.Size = new System.Drawing.Size(53, 60);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(712, 60);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(53, 329);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // generateClearButton
            // 
            this.generateClearButton.AutoSize = true;
            this.generateClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.generateClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateClearButton.FlatAppearance.BorderSize = 0;
            this.generateClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateClearButton.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateClearButton.Location = new System.Drawing.Point(2, 54);
            this.generateClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateClearButton.Name = "generateClearButton";
            this.generateClearButton.Size = new System.Drawing.Size(49, 48);
            this.generateClearButton.TabIndex = 18;
            this.generateClearButton.Text = "Clear";
            this.generateClearButton.UseVisualStyleBackColor = false;
            this.generateClearButton.Click += new System.EventHandler(this.GenerateClearButton_Click);
            // 
            // generateCopyButton
            // 
            this.generateCopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(153)))), ((int)(((byte)(118)))));
            this.generateCopyButton.BackgroundImage = global::ProgrammerUtils.Properties.Resources.copy_image;
            this.generateCopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateCopyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateCopyButton.FlatAppearance.BorderSize = 0;
            this.generateCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCopyButton.Location = new System.Drawing.Point(2, 2);
            this.generateCopyButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateCopyButton.Name = "generateCopyButton";
            this.generateCopyButton.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.generateCopyButton.Size = new System.Drawing.Size(49, 48);
            this.generateCopyButton.TabIndex = 17;
            this.generateCopyButton.UseVisualStyleBackColor = false;
            this.generateCopyButton.Click += new System.EventHandler(this.GenerateCopyButton_Click);
            // 
            // generateSettingsTableLayout
            // 
            this.generateSettingsTableLayout.ColumnCount = 6;
            this.generateTableLayout.SetColumnSpan(this.generateSettingsTableLayout, 2);
            this.generateSettingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
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
            this.generateSettingsTableLayout.Location = new System.Drawing.Point(4, 5);
            this.generateSettingsTableLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generateSettingsTableLayout.Name = "generateSettingsTableLayout";
            this.generateSettingsTableLayout.RowCount = 2;
            this.generateSettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generateSettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generateSettingsTableLayout.Size = new System.Drawing.Size(704, 50);
            this.generateSettingsTableLayout.TabIndex = 7;
            // 
            // generateSeed
            // 
            this.generateSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.generateSeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateSeed.Enabled = false;
            this.generateSeed.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSeed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.generateSeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.generateSeed.Location = new System.Drawing.Point(408, 27);
            this.generateSeed.Margin = new System.Windows.Forms.Padding(2);
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
            this.generateSeed.Size = new System.Drawing.Size(109, 19);
            this.generateSeed.TabIndex = 5;
            // 
            // generateAmountOfWordsLabel
            // 
            this.generateAmountOfWordsLabel.AutoSize = true;
            this.generateAmountOfWordsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateAmountOfWordsLabel.Location = new System.Drawing.Point(133, 0);
            this.generateAmountOfWordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generateAmountOfWordsLabel.Name = "generateAmountOfWordsLabel";
            this.generateAmountOfWordsLabel.Size = new System.Drawing.Size(87, 25);
            this.generateAmountOfWordsLabel.TabIndex = 4;
            this.generateAmountOfWordsLabel.Text = "Amount of words";
            this.generateAmountOfWordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generateGenerateButton
            // 
            this.generateGenerateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.generateGenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateGenerateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateGenerateButton.FlatAppearance.BorderSize = 0;
            this.generateGenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateGenerateButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateGenerateButton.Location = new System.Drawing.Point(2, 2);
            this.generateGenerateButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateGenerateButton.Name = "generateGenerateButton";
            this.generateSettingsTableLayout.SetRowSpan(this.generateGenerateButton, 2);
            this.generateGenerateButton.Size = new System.Drawing.Size(127, 46);
            this.generateGenerateButton.TabIndex = 0;
            this.generateGenerateButton.Text = "Generate Text";
            this.generateGenerateButton.UseVisualStyleBackColor = false;
            this.generateGenerateButton.Click += new System.EventHandler(this.GenerateGenerateButton_Click);
            // 
            // generateParagraphType
            // 
            this.generateParagraphType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.generateParagraphType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateParagraphType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.generateParagraphType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generateParagraphType.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateParagraphType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.generateParagraphType.FormattingEnabled = true;
            this.generateParagraphType.Items.AddRange(new object[] {
            "Blank row",
            "Indent",
            "No paragraphs"});
            this.generateParagraphType.Location = new System.Drawing.Point(224, 27);
            this.generateParagraphType.Margin = new System.Windows.Forms.Padding(2);
            this.generateParagraphType.Name = "generateParagraphType";
            this.generateParagraphType.Size = new System.Drawing.Size(81, 20);
            this.generateParagraphType.TabIndex = 1;
            this.generateParagraphType.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.GenerateParagraphType_DrawItem);
            this.generateParagraphType.SelectedIndexChanged += new System.EventHandler(this.GenerateParagraphType_SelectedIndexChanged);
            // 
            // generateParagraphTypeLabel
            // 
            this.generateParagraphTypeLabel.AutoSize = true;
            this.generateParagraphTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateParagraphTypeLabel.Location = new System.Drawing.Point(224, 0);
            this.generateParagraphTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generateParagraphTypeLabel.Name = "generateParagraphTypeLabel";
            this.generateParagraphTypeLabel.Size = new System.Drawing.Size(81, 25);
            this.generateParagraphTypeLabel.TabIndex = 2;
            this.generateParagraphTypeLabel.Text = "Paragraph type";
            this.generateParagraphTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generateNumberOfWords
            // 
            this.generateNumberOfWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.generateNumberOfWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateNumberOfWords.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateNumberOfWords.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.generateNumberOfWords.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.generateNumberOfWords.Location = new System.Drawing.Point(133, 27);
            this.generateNumberOfWords.Margin = new System.Windows.Forms.Padding(2);
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
            this.generateNumberOfWords.Size = new System.Drawing.Size(87, 19);
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
            this.generateSeedTableLayout.Location = new System.Drawing.Point(406, 0);
            this.generateSeedTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.generateSeedTableLayout.Name = "generateSeedTableLayout";
            this.generateSeedTableLayout.RowCount = 1;
            this.generateSeedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generateSeedTableLayout.Size = new System.Drawing.Size(113, 25);
            this.generateSeedTableLayout.TabIndex = 7;
            // 
            // generateSeedLabel
            // 
            this.generateSeedLabel.AutoSize = true;
            this.generateSeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateSeedLabel.Location = new System.Drawing.Point(2, 0);
            this.generateSeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generateSeedLabel.Name = "generateSeedLabel";
            this.generateSeedLabel.Size = new System.Drawing.Size(32, 25);
            this.generateSeedLabel.TabIndex = 7;
            this.generateSeedLabel.Text = "Seed";
            this.generateSeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generateCustomSeed
            // 
            this.generateCustomSeed.AutoSize = true;
            this.generateCustomSeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateCustomSeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateCustomSeed.Location = new System.Drawing.Point(38, 2);
            this.generateCustomSeed.Margin = new System.Windows.Forms.Padding(2);
            this.generateCustomSeed.Name = "generateCustomSeed";
            this.generateCustomSeed.Size = new System.Drawing.Size(73, 21);
            this.generateCustomSeed.TabIndex = 8;
            this.generateCustomSeed.Text = "Custom Seed";
            this.generateCustomSeed.UseVisualStyleBackColor = true;
            this.generateCustomSeed.CheckedChanged += new System.EventHandler(this.GenerateCustomSeed_CheckedChanged);
            // 
            // generateParagraphSizeSlider
            // 
            this.generateParagraphSizeSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateParagraphSizeSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateParagraphSizeSlider.Location = new System.Drawing.Point(307, 25);
            this.generateParagraphSizeSlider.Margin = new System.Windows.Forms.Padding(0);
            this.generateParagraphSizeSlider.Maximum = 200;
            this.generateParagraphSizeSlider.Name = "generateParagraphSizeSlider";
            this.generateParagraphSizeSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.generateParagraphSizeSlider.Size = new System.Drawing.Size(99, 25);
            this.generateParagraphSizeSlider.TabIndex = 8;
            this.generateParagraphSizeSlider.TickFrequency = 75;
            this.generateParagraphSizeSlider.Value = 75;
            this.generateParagraphSizeSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GenerateParagraphSizeSlider_MouseUp);
            // 
            // generateParagraphSizeLabel
            // 
            this.generateParagraphSizeLabel.AutoSize = true;
            this.generateParagraphSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateParagraphSizeLabel.Location = new System.Drawing.Point(309, 0);
            this.generateParagraphSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generateParagraphSizeLabel.Name = "generateParagraphSizeLabel";
            this.generateParagraphSizeLabel.Size = new System.Drawing.Size(95, 25);
            this.generateParagraphSizeLabel.TabIndex = 9;
            this.generateParagraphSizeLabel.Text = "Paragraph sizes";
            this.generateParagraphSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputTextBorderPanel
            // 
            this.inputTextBorderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.inputTextBorderPanel.BorderWidth = 2;
            this.generateTableLayout.SetColumnSpan(this.inputTextBorderPanel, 2);
            this.inputTextBorderPanel.Controls.Add(this.generateOutputTextbox);
            this.inputTextBorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBorderPanel.Location = new System.Drawing.Point(4, 64);
            this.inputTextBorderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBorderPanel.Name = "inputTextBorderPanel";
            this.inputTextBorderPanel.Padding = new System.Windows.Forms.Padding(4);
            this.inputTextBorderPanel.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.inputTextBorderPanel.Size = new System.Drawing.Size(704, 321);
            this.inputTextBorderPanel.TabIndex = 11;
            // 
            // generateOutputTextbox
            // 
            this.generateOutputTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.generateOutputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generateOutputTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateOutputTextbox.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateOutputTextbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.generateOutputTextbox.Location = new System.Drawing.Point(4, 4);
            this.generateOutputTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.generateOutputTextbox.Name = "generateOutputTextbox";
            this.generateOutputTextbox.ReadOnly = true;
            this.generateOutputTextbox.Size = new System.Drawing.Size(696, 313);
            this.generateOutputTextbox.TabIndex = 9;
            this.generateOutputTextbox.Text = "";
            // 
            // CopyTimer
            // 
            this.CopyTimer.Interval = 1500;
            this.CopyTimer.Tick += new System.EventHandler(this.CopyTimer_Tick);
            // 
            // GenerateTextControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.generateTableLayout);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GenerateTextControl";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(773, 442);
            this.generateTableLayout.ResumeLayout(false);
            this.generateTableLayout.PerformLayout();
            this.sortLabel1BorderPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.generateSettingsTableLayout.ResumeLayout(false);
            this.generateSettingsTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateNumberOfWords)).EndInit();
            this.generateSeedTableLayout.ResumeLayout(false);
            this.generateSeedTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateParagraphSizeSlider)).EndInit();
            this.inputTextBorderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel generateTableLayout;
        private System.Windows.Forms.Label generateCopyLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button generateClearButton;
        private System.Windows.Forms.Button generateCopyButton;
        private System.Windows.Forms.TableLayoutPanel generateSettingsTableLayout;
        private System.Windows.Forms.NumericUpDown generateSeed;
        private System.Windows.Forms.Label generateAmountOfWordsLabel;
        private System.Windows.Forms.Button generateGenerateButton;
        private System.Windows.Forms.ComboBox generateParagraphType;
        private System.Windows.Forms.Label generateParagraphTypeLabel;
        private System.Windows.Forms.NumericUpDown generateNumberOfWords;
        private System.Windows.Forms.TableLayoutPanel generateSeedTableLayout;
        private System.Windows.Forms.Label generateSeedLabel;
        private System.Windows.Forms.CheckBox generateCustomSeed;
        private System.Windows.Forms.TrackBar generateParagraphSizeSlider;
        private System.Windows.Forms.Label generateParagraphSizeLabel;
        private System.Windows.Forms.Timer CopyTimer;
        private BorderPanel inputTextBorderPanel;
        private System.Windows.Forms.RichTextBox generateOutputTextbox;
        private BorderPanel sortLabel1BorderPanel;
        private System.Windows.Forms.Label sortLabel1;
    }
}
