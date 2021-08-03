
namespace ProgrammerUtils
{
    partial class HTMLControl
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
            this.htmlColorTagPicker = new System.Windows.Forms.ColorDialog();
            this.CopyTimer = new System.Windows.Forms.Timer(this.components);
            this.htmlColorHoverTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.htmlTableLayout.SuspendLayout();
            this.htmlSettingsTableLayout.SuspendLayout();
            this.htmlColorCustomTableLayout.SuspendLayout();
            this.htmlColorEntityTableLayout.SuspendLayout();
            this.htmlColorTagOptionTableLayout.SuspendLayout();
            this.htmlInputTableLayout.SuspendLayout();
            this.htmlInputTextSettingsTableLayout.SuspendLayout();
            this.htmlOutputTableLayout.SuspendLayout();
            this.htmlSideTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlTableLayout
            // 
            this.htmlTableLayout.ColumnCount = 3;
            this.htmlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.htmlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.htmlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.htmlTableLayout.Controls.Add(this.htmlSettingsTableLayout, 0, 0);
            this.htmlTableLayout.Controls.Add(this.htmlInputTableLayout, 0, 1);
            this.htmlTableLayout.Controls.Add(this.htmlOutputTableLayout, 1, 1);
            this.htmlTableLayout.Controls.Add(this.htmlSideTableLayout, 2, 1);
            this.htmlTableLayout.Controls.Add(this.htmlCopyLabel, 2, 0);
            this.htmlTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlTableLayout.Location = new System.Drawing.Point(0, 0);
            this.htmlTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.htmlTableLayout.Name = "htmlTableLayout";
            this.htmlTableLayout.RowCount = 2;
            this.htmlTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.htmlTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlTableLayout.Size = new System.Drawing.Size(757, 457);
            this.htmlTableLayout.TabIndex = 1;
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
            this.htmlSettingsTableLayout.Size = new System.Drawing.Size(690, 57);
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
            this.htmlInputTableLayout.Size = new System.Drawing.Size(345, 400);
            this.htmlInputTableLayout.TabIndex = 1;
            // 
            // htmlInputLabel
            // 
            this.htmlInputLabel.AutoSize = true;
            this.htmlInputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.htmlInputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.htmlInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlInputLabel.Location = new System.Drawing.Point(2, 362);
            this.htmlInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.htmlInputLabel.Name = "htmlInputLabel";
            this.htmlInputLabel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.htmlInputLabel.Size = new System.Drawing.Size(341, 38);
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
            this.htmlInputTextbox.Size = new System.Drawing.Size(341, 318);
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
            this.htmlInputTextSettingsTableLayout.Location = new System.Drawing.Point(2, 327);
            this.htmlInputTextSettingsTableLayout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.htmlInputTextSettingsTableLayout.Name = "htmlInputTextSettingsTableLayout";
            this.htmlInputTextSettingsTableLayout.RowCount = 1;
            this.htmlInputTextSettingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlInputTextSettingsTableLayout.Size = new System.Drawing.Size(341, 32);
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
            this.htmlLoweredButton.MaximumSize = new System.Drawing.Size(26, 26);
            this.htmlLoweredButton.MinimumSize = new System.Drawing.Size(26, 26);
            this.htmlLoweredButton.Name = "htmlLoweredButton";
            this.htmlLoweredButton.Size = new System.Drawing.Size(26, 26);
            this.htmlLoweredButton.TabIndex = 14;
            this.htmlLoweredButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlLoweredButton.UseVisualStyleBackColor = false;
            this.htmlLoweredButton.Click += new System.EventHandler(this.HtmlLoweredButton_CheckedChanged);
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
            this.htmlUnderscoreButton.MaximumSize = new System.Drawing.Size(26, 26);
            this.htmlUnderscoreButton.MinimumSize = new System.Drawing.Size(26, 26);
            this.htmlUnderscoreButton.Name = "htmlUnderscoreButton";
            this.htmlUnderscoreButton.Size = new System.Drawing.Size(26, 26);
            this.htmlUnderscoreButton.TabIndex = 10;
            this.htmlUnderscoreButton.Text = "U";
            this.htmlUnderscoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlUnderscoreButton.UseVisualStyleBackColor = false;
            this.htmlUnderscoreButton.Click += new System.EventHandler(this.HtmlUnderscoreButton_CheckedChanged);
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
            this.htmlStrikeThroughButton.MaximumSize = new System.Drawing.Size(26, 26);
            this.htmlStrikeThroughButton.MinimumSize = new System.Drawing.Size(26, 26);
            this.htmlStrikeThroughButton.Name = "htmlStrikeThroughButton";
            this.htmlStrikeThroughButton.Size = new System.Drawing.Size(26, 26);
            this.htmlStrikeThroughButton.TabIndex = 12;
            this.htmlStrikeThroughButton.Text = "S";
            this.htmlStrikeThroughButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlStrikeThroughButton.UseVisualStyleBackColor = false;
            this.htmlStrikeThroughButton.Click += new System.EventHandler(this.HtmlStrikeThroughButton_CheckedChanged);
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
            this.htmlItalicButton.MaximumSize = new System.Drawing.Size(26, 26);
            this.htmlItalicButton.MinimumSize = new System.Drawing.Size(26, 26);
            this.htmlItalicButton.Name = "htmlItalicButton";
            this.htmlItalicButton.Size = new System.Drawing.Size(26, 26);
            this.htmlItalicButton.TabIndex = 11;
            this.htmlItalicButton.Text = "I";
            this.htmlItalicButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlItalicButton.UseVisualStyleBackColor = false;
            this.htmlItalicButton.Click += new System.EventHandler(this.HtmlItalicButton_CheckedChanged);
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
            this.htmlBoldButton.MaximumSize = new System.Drawing.Size(26, 26);
            this.htmlBoldButton.MinimumSize = new System.Drawing.Size(26, 26);
            this.htmlBoldButton.Name = "htmlBoldButton";
            this.htmlBoldButton.Size = new System.Drawing.Size(26, 26);
            this.htmlBoldButton.TabIndex = 9;
            this.htmlBoldButton.Text = "B";
            this.htmlBoldButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlBoldButton.UseVisualStyleBackColor = false;
            this.htmlBoldButton.Click += new System.EventHandler(this.HtmlBoldButton_CheckedChanged);
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
            this.htmlRaisedButton.MaximumSize = new System.Drawing.Size(26, 26);
            this.htmlRaisedButton.MinimumSize = new System.Drawing.Size(26, 26);
            this.htmlRaisedButton.Name = "htmlRaisedButton";
            this.htmlRaisedButton.Size = new System.Drawing.Size(26, 26);
            this.htmlRaisedButton.TabIndex = 13;
            this.htmlRaisedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.htmlRaisedButton.UseVisualStyleBackColor = false;
            this.htmlRaisedButton.Click += new System.EventHandler(this.HtmlRaisedButton_CheckedChanged);
            // 
            // htmlOutputTableLayout
            // 
            this.htmlOutputTableLayout.ColumnCount = 1;
            this.htmlOutputTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlOutputTableLayout.Controls.Add(this.htmlOutputLabel, 0, 1);
            this.htmlOutputTableLayout.Controls.Add(this.htmlOutputTextbox, 0, 0);
            this.htmlOutputTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlOutputTableLayout.Location = new System.Drawing.Point(345, 57);
            this.htmlOutputTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.htmlOutputTableLayout.Name = "htmlOutputTableLayout";
            this.htmlOutputTableLayout.RowCount = 2;
            this.htmlOutputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlOutputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.htmlOutputTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.htmlOutputTableLayout.Size = new System.Drawing.Size(345, 400);
            this.htmlOutputTableLayout.TabIndex = 2;
            // 
            // htmlOutputLabel
            // 
            this.htmlOutputLabel.AutoSize = true;
            this.htmlOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.htmlOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.htmlOutputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlOutputLabel.Location = new System.Drawing.Point(2, 362);
            this.htmlOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.htmlOutputLabel.Name = "htmlOutputLabel";
            this.htmlOutputLabel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.htmlOutputLabel.Size = new System.Drawing.Size(341, 38);
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
            this.htmlOutputTextbox.Size = new System.Drawing.Size(341, 356);
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
            this.htmlSideTableLayout.Location = new System.Drawing.Point(690, 57);
            this.htmlSideTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.htmlSideTableLayout.Name = "htmlSideTableLayout";
            this.htmlSideTableLayout.RowCount = 4;
            this.htmlSideTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.htmlSideTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.htmlSideTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.htmlSideTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.htmlSideTableLayout.Size = new System.Drawing.Size(67, 400);
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
            this.htmlOpenAllTags.Size = new System.Drawing.Size(63, 60);
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
            this.htmlClearButton.Size = new System.Drawing.Size(63, 60);
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
            this.htmlCopyButton.Size = new System.Drawing.Size(63, 60);
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
            this.htmlCopyLabel.Location = new System.Drawing.Point(692, 0);
            this.htmlCopyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.htmlCopyLabel.Name = "htmlCopyLabel";
            this.htmlCopyLabel.Size = new System.Drawing.Size(63, 57);
            this.htmlCopyLabel.TabIndex = 4;
            this.htmlCopyLabel.Text = "Copied!";
            this.htmlCopyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // htmlColorTagPicker
            // 
            this.htmlColorTagPicker.FullOpen = true;
            this.htmlColorTagPicker.SolidColorOnly = true;
            // 
            // CopyTimer
            // 
            this.CopyTimer.Interval = 1500;
            this.CopyTimer.Tick += new System.EventHandler(this.CopyTimer_Tick);
            // 
            // htmlColorHoverTooltip
            // 
            this.htmlColorHoverTooltip.ToolTipTitle = "Color:";
            // 
            // HTMLControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.htmlTableLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HTMLControl";
            this.Size = new System.Drawing.Size(757, 457);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel htmlTableLayout;
        private System.Windows.Forms.TableLayoutPanel htmlSettingsTableLayout;
        private System.Windows.Forms.TableLayoutPanel htmlColorCustomTableLayout;
        private System.Windows.Forms.Button htmlChangeCustomColorButton;
        private System.Windows.Forms.Button htmlCustomColorRectangle;
        private System.Windows.Forms.CheckBox htmlColorCustomCheckbox;
        private System.Windows.Forms.TableLayoutPanel htmlColorEntityTableLayout;
        private System.Windows.Forms.Button htmlChangeEntityColorButton;
        private System.Windows.Forms.Button htmlEntityColorRectangle;
        private System.Windows.Forms.CheckBox htmlColorEntitiesCheckbox;
        private System.Windows.Forms.Button htmlButton;
        private System.Windows.Forms.CheckBox htmlColorTagsCheckbox;
        private System.Windows.Forms.TableLayoutPanel htmlColorTagOptionTableLayout;
        private System.Windows.Forms.Button htmlChooseColorButton;
        private System.Windows.Forms.Button htmlTagColorRectangle;
        private System.Windows.Forms.Button htmlCustomRulesButton;
        private System.Windows.Forms.TableLayoutPanel htmlInputTableLayout;
        private System.Windows.Forms.Label htmlInputLabel;
        private System.Windows.Forms.RichTextBox htmlInputTextbox;
        private System.Windows.Forms.TableLayoutPanel htmlInputTextSettingsTableLayout;
        private System.Windows.Forms.CheckBox htmlLoweredButton;
        private System.Windows.Forms.CheckBox htmlUnderscoreButton;
        private System.Windows.Forms.CheckBox htmlStrikeThroughButton;
        private System.Windows.Forms.CheckBox htmlItalicButton;
        private System.Windows.Forms.CheckBox htmlBoldButton;
        private System.Windows.Forms.CheckBox htmlRaisedButton;
        private System.Windows.Forms.TableLayoutPanel htmlOutputTableLayout;
        private System.Windows.Forms.Label htmlOutputLabel;
        private System.Windows.Forms.RichTextBox htmlOutputTextbox;
        private System.Windows.Forms.TableLayoutPanel htmlSideTableLayout;
        private System.Windows.Forms.Button htmlOpenAllTags;
        private System.Windows.Forms.Button htmlClearButton;
        private System.Windows.Forms.Button htmlCopyButton;
        private System.Windows.Forms.Label htmlCopyLabel;
        private System.Windows.Forms.ColorDialog htmlColorTagPicker;
        private System.Windows.Forms.Timer CopyTimer;
        private System.Windows.Forms.ToolTip htmlColorHoverTooltip;
    }
}
