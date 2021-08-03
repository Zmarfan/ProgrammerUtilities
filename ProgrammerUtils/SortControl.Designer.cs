
namespace ProgrammerUtils
{
    partial class SortControl
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
            this.SortTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sortLabel2 = new System.Windows.Forms.Label();
            this.sortTextBoxLeft = new System.Windows.Forms.RichTextBox();
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
            this.SortCopyButton = new System.Windows.Forms.Button();
            this.SortClearButton = new System.Windows.Forms.Button();
            this.SortTextPresentationButton = new System.Windows.Forms.Button();
            this.SortChangeTextCapsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SortExportDropdown = new System.Windows.Forms.ComboBox();
            this.SortExportEnumButton = new System.Windows.Forms.Button();
            this.SortEnumOptionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SortEnumClassName = new System.Windows.Forms.TextBox();
            this.SortCopyNotice = new System.Windows.Forms.Label();
            this.sortSortedTabs = new System.Windows.Forms.TabControl();
            this.sortList = new System.Windows.Forms.TabPage();
            this.sortTextBoxRight = new System.Windows.Forms.RichTextBox();
            this.sortEnum = new System.Windows.Forms.TabPage();
            this.sortEnumTextBoxRight = new System.Windows.Forms.RichTextBox();
            this.copyTimer = new System.Windows.Forms.Timer(this.components);
            this.SortTableLayout.SuspendLayout();
            this.sortHeader.SuspendLayout();
            this.sortModeTableLayout.SuspendLayout();
            this.sortStyleTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SortEnumOptionTableLayout.SuspendLayout();
            this.sortSortedTabs.SuspendLayout();
            this.sortList.SuspendLayout();
            this.sortEnum.SuspendLayout();
            this.SuspendLayout();
            // 
            // SortTableLayout
            // 
            this.SortTableLayout.ColumnCount = 3;
            this.SortTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SortTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SortTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.SortTableLayout.Controls.Add(this.sortLabel2, 1, 3);
            this.SortTableLayout.Controls.Add(this.sortTextBoxLeft, 0, 1);
            this.SortTableLayout.Controls.Add(this.sortLabel1, 0, 3);
            this.SortTableLayout.Controls.Add(this.sortHeader, 0, 0);
            this.SortTableLayout.Controls.Add(this.tableLayoutPanel1, 2, 1);
            this.SortTableLayout.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.SortTableLayout.Controls.Add(this.SortCopyNotice, 2, 0);
            this.SortTableLayout.Controls.Add(this.sortSortedTabs, 1, 1);
            this.SortTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortTableLayout.ForeColor = System.Drawing.Color.Black;
            this.SortTableLayout.Location = new System.Drawing.Point(0, 0);
            this.SortTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SortTableLayout.Name = "SortTableLayout";
            this.SortTableLayout.RowCount = 4;
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.SortTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortTableLayout.Size = new System.Drawing.Size(770, 512);
            this.SortTableLayout.TabIndex = 1;
            // 
            // sortLabel2
            // 
            this.sortLabel2.AutoSize = true;
            this.sortLabel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sortLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortLabel2.Location = new System.Drawing.Point(353, 456);
            this.sortLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sortLabel2.Name = "sortLabel2";
            this.sortLabel2.Size = new System.Drawing.Size(347, 56);
            this.sortLabel2.TabIndex = 3;
            this.sortLabel2.Text = "Sorted items.";
            this.sortLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortTextBoxLeft
            // 
            this.sortTextBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortTextBoxLeft.Location = new System.Drawing.Point(2, 60);
            this.sortTextBoxLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortTextBoxLeft.Name = "sortTextBoxLeft";
            this.SortTableLayout.SetRowSpan(this.sortTextBoxLeft, 2);
            this.sortTextBoxLeft.Size = new System.Drawing.Size(347, 393);
            this.sortTextBoxLeft.TabIndex = 0;
            this.sortTextBoxLeft.Text = "";
            this.sortTextBoxLeft.TextChanged += new System.EventHandler(this.SortTextChanged);
            // 
            // sortLabel1
            // 
            this.sortLabel1.AutoSize = true;
            this.sortLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sortLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sortLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortLabel1.Location = new System.Drawing.Point(2, 456);
            this.sortLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sortLabel1.Name = "sortLabel1";
            this.sortLabel1.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.sortLabel1.Size = new System.Drawing.Size(347, 56);
            this.sortLabel1.TabIndex = 2;
            this.sortLabel1.Text = "Items to sort. Separate entries by commas or new lines!";
            this.sortLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortHeader
            // 
            this.sortHeader.ColumnCount = 4;
            this.SortTableLayout.SetColumnSpan(this.sortHeader, 2);
            this.sortHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.sortHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.sortHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 306F));
            this.sortHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.sortHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
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
            this.sortHeader.Size = new System.Drawing.Size(702, 57);
            this.sortHeader.TabIndex = 4;
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.Location = new System.Drawing.Point(2, 3);
            this.SortButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SortButton.Name = "SortButton";
            this.sortHeader.SetRowSpan(this.SortButton, 2);
            this.SortButton.Size = new System.Drawing.Size(171, 51);
            this.SortButton.TabIndex = 1;
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
            this.AutoSortCheckbox.Location = new System.Drawing.Point(177, 3);
            this.AutoSortCheckbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AutoSortCheckbox.Name = "AutoSortCheckbox";
            this.sortHeader.SetRowSpan(this.AutoSortCheckbox, 2);
            this.AutoSortCheckbox.Size = new System.Drawing.Size(89, 51);
            this.AutoSortCheckbox.TabIndex = 2;
            this.AutoSortCheckbox.Text = "Auto Sort";
            this.AutoSortCheckbox.UseVisualStyleBackColor = true;
            this.AutoSortCheckbox.Click += new System.EventHandler(this.AutoSortCheckbox_CheckedChanged);
            // 
            // sortModeTableLayout
            // 
            this.sortModeTableLayout.ColumnCount = 2;
            this.sortModeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sortModeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sortModeTableLayout.Controls.Add(this.sortAlphabeticlyRadio, 0, 0);
            this.sortModeTableLayout.Controls.Add(this.notSortAlphabeticlyRadio, 1, 0);
            this.sortModeTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortModeTableLayout.Location = new System.Drawing.Point(268, 0);
            this.sortModeTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.sortModeTableLayout.Name = "sortModeTableLayout";
            this.sortModeTableLayout.RowCount = 1;
            this.sortModeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sortModeTableLayout.Size = new System.Drawing.Size(306, 28);
            this.sortModeTableLayout.TabIndex = 4;
            // 
            // sortAlphabeticlyRadio
            // 
            this.sortAlphabeticlyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sortAlphabeticlyRadio.AutoSize = true;
            this.sortAlphabeticlyRadio.Checked = true;
            this.sortAlphabeticlyRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortAlphabeticlyRadio.Location = new System.Drawing.Point(2, 3);
            this.sortAlphabeticlyRadio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortAlphabeticlyRadio.Name = "sortAlphabeticlyRadio";
            this.sortAlphabeticlyRadio.Size = new System.Drawing.Size(116, 22);
            this.sortAlphabeticlyRadio.TabIndex = 3;
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
            this.notSortAlphabeticlyRadio.Location = new System.Drawing.Point(155, 3);
            this.notSortAlphabeticlyRadio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.notSortAlphabeticlyRadio.Name = "notSortAlphabeticlyRadio";
            this.notSortAlphabeticlyRadio.Size = new System.Drawing.Size(149, 22);
            this.notSortAlphabeticlyRadio.TabIndex = 5;
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
            this.sortStyleTableLayout.Location = new System.Drawing.Point(268, 28);
            this.sortStyleTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.sortStyleTableLayout.Name = "sortStyleTableLayout";
            this.sortStyleTableLayout.RowCount = 1;
            this.sortStyleTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sortStyleTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.sortStyleTableLayout.Size = new System.Drawing.Size(306, 29);
            this.sortStyleTableLayout.TabIndex = 5;
            // 
            // sortSeperatorCommaRadio
            // 
            this.sortSeperatorCommaRadio.AutoSize = true;
            this.sortSeperatorCommaRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortSeperatorCommaRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortSeperatorCommaRadio.Location = new System.Drawing.Point(2, 3);
            this.sortSeperatorCommaRadio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortSeperatorCommaRadio.Name = "sortSeperatorCommaRadio";
            this.sortSeperatorCommaRadio.Size = new System.Drawing.Size(149, 23);
            this.sortSeperatorCommaRadio.TabIndex = 4;
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
            this.sortSeperatorNewLineRadio.Location = new System.Drawing.Point(155, 3);
            this.sortSeperatorNewLineRadio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortSeperatorNewLineRadio.Name = "sortSeperatorNewLineRadio";
            this.sortSeperatorNewLineRadio.Size = new System.Drawing.Size(149, 23);
            this.sortSeperatorNewLineRadio.TabIndex = 6;
            this.sortSeperatorNewLineRadio.TabStop = true;
            this.sortSeperatorNewLineRadio.Text = "New line seperated";
            this.sortSeperatorNewLineRadio.UseVisualStyleBackColor = true;
            this.sortSeperatorNewLineRadio.CheckedChanged += new System.EventHandler(this.SortDisplayModeChange);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SortCopyButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SortClearButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SortTextPresentationButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SortChangeTextCapsButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(702, 57);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(68, 338);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // SortCopyButton
            // 
            this.SortCopyButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.SortCopyButton.BackgroundImage = global::ProgrammerUtils.Properties.Resources.copy_image;
            this.SortCopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SortCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortCopyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortCopyButton.Location = new System.Drawing.Point(2, 135);
            this.SortCopyButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SortCopyButton.Name = "SortCopyButton";
            this.SortCopyButton.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.SortCopyButton.Size = new System.Drawing.Size(64, 60);
            this.SortCopyButton.TabIndex = 9;
            this.SortCopyButton.UseVisualStyleBackColor = false;
            this.SortCopyButton.Click += new System.EventHandler(this.SortCopyButton_Click);
            // 
            // SortClearButton
            // 
            this.SortClearButton.AutoSize = true;
            this.SortClearButton.BackColor = System.Drawing.Color.LightPink;
            this.SortClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortClearButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortClearButton.Location = new System.Drawing.Point(2, 201);
            this.SortClearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SortClearButton.Name = "SortClearButton";
            this.SortClearButton.Size = new System.Drawing.Size(64, 60);
            this.SortClearButton.TabIndex = 10;
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
            this.SortTextPresentationButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortTextPresentationButton.Location = new System.Drawing.Point(2, 69);
            this.SortTextPresentationButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SortTextPresentationButton.Name = "SortTextPresentationButton";
            this.SortTextPresentationButton.Size = new System.Drawing.Size(64, 60);
            this.SortTextPresentationButton.TabIndex = 8;
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
            this.SortChangeTextCapsButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortChangeTextCapsButton.Location = new System.Drawing.Point(2, 3);
            this.SortChangeTextCapsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SortChangeTextCapsButton.Name = "SortChangeTextCapsButton";
            this.SortChangeTextCapsButton.Size = new System.Drawing.Size(64, 60);
            this.SortChangeTextCapsButton.TabIndex = 7;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(353, 398);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(347, 55);
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
            this.SortExportDropdown.Location = new System.Drawing.Point(2, 30);
            this.SortExportDropdown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SortExportDropdown.Name = "SortExportDropdown";
            this.SortExportDropdown.Size = new System.Drawing.Size(256, 24);
            this.SortExportDropdown.TabIndex = 12;
            this.SortExportDropdown.SelectedIndexChanged += new System.EventHandler(this.SortExportDropdown_SelectedIndexChanged);
            // 
            // SortExportEnumButton
            // 
            this.SortExportEnumButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.SortExportEnumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortExportEnumButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortExportEnumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortExportEnumButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortExportEnumButton.Location = new System.Drawing.Point(262, 3);
            this.SortExportEnumButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SortExportEnumButton.Name = "SortExportEnumButton";
            this.tableLayoutPanel2.SetRowSpan(this.SortExportEnumButton, 2);
            this.SortExportEnumButton.Size = new System.Drawing.Size(83, 49);
            this.SortExportEnumButton.TabIndex = 13;
            this.SortExportEnumButton.Text = "Copy as Enum";
            this.SortExportEnumButton.UseVisualStyleBackColor = false;
            this.SortExportEnumButton.Click += new System.EventHandler(this.SortExportEnumButton_Click);
            // 
            // SortEnumOptionTableLayout
            // 
            this.SortEnumOptionTableLayout.ColumnCount = 2;
            this.SortEnumOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.SortEnumOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SortEnumOptionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.SortEnumOptionTableLayout.Controls.Add(this.label1, 0, 0);
            this.SortEnumOptionTableLayout.Controls.Add(this.SortEnumClassName, 1, 0);
            this.SortEnumOptionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortEnumOptionTableLayout.Location = new System.Drawing.Point(0, 0);
            this.SortEnumOptionTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SortEnumOptionTableLayout.Name = "SortEnumOptionTableLayout";
            this.SortEnumOptionTableLayout.RowCount = 1;
            this.SortEnumOptionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SortEnumOptionTableLayout.Size = new System.Drawing.Size(260, 27);
            this.SortEnumOptionTableLayout.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SortEnumClassName
            // 
            this.SortEnumClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortEnumClassName.Location = new System.Drawing.Point(81, 3);
            this.SortEnumClassName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SortEnumClassName.MaxLength = 30;
            this.SortEnumClassName.Name = "SortEnumClassName";
            this.SortEnumClassName.Size = new System.Drawing.Size(177, 22);
            this.SortEnumClassName.TabIndex = 11;
            this.SortEnumClassName.TextChanged += new System.EventHandler(this.SortEnumClassName_TextChanged);
            // 
            // SortCopyNotice
            // 
            this.SortCopyNotice.AutoSize = true;
            this.SortCopyNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortCopyNotice.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortCopyNotice.ForeColor = System.Drawing.Color.Green;
            this.SortCopyNotice.Location = new System.Drawing.Point(704, 0);
            this.SortCopyNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SortCopyNotice.Name = "SortCopyNotice";
            this.SortCopyNotice.Size = new System.Drawing.Size(64, 57);
            this.SortCopyNotice.TabIndex = 7;
            this.SortCopyNotice.Text = "Copied!";
            this.SortCopyNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortSortedTabs
            // 
            this.sortSortedTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.sortSortedTabs.Controls.Add(this.sortList);
            this.sortSortedTabs.Controls.Add(this.sortEnum);
            this.sortSortedTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortSortedTabs.Location = new System.Drawing.Point(353, 60);
            this.sortSortedTabs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortSortedTabs.Name = "sortSortedTabs";
            this.sortSortedTabs.SelectedIndex = 0;
            this.sortSortedTabs.Size = new System.Drawing.Size(347, 332);
            this.sortSortedTabs.TabIndex = 8;
            // 
            // sortList
            // 
            this.sortList.Controls.Add(this.sortTextBoxRight);
            this.sortList.Location = new System.Drawing.Point(4, 28);
            this.sortList.Margin = new System.Windows.Forms.Padding(0);
            this.sortList.Name = "sortList";
            this.sortList.Size = new System.Drawing.Size(339, 300);
            this.sortList.TabIndex = 0;
            this.sortList.Text = "List";
            this.sortList.UseVisualStyleBackColor = true;
            // 
            // sortTextBoxRight
            // 
            this.sortTextBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortTextBoxRight.Location = new System.Drawing.Point(0, 0);
            this.sortTextBoxRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortTextBoxRight.Name = "sortTextBoxRight";
            this.sortTextBoxRight.ReadOnly = true;
            this.sortTextBoxRight.Size = new System.Drawing.Size(339, 300);
            this.sortTextBoxRight.TabIndex = 0;
            this.sortTextBoxRight.Text = "";
            // 
            // sortEnum
            // 
            this.sortEnum.Controls.Add(this.sortEnumTextBoxRight);
            this.sortEnum.Location = new System.Drawing.Point(4, 28);
            this.sortEnum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortEnum.Name = "sortEnum";
            this.sortEnum.Size = new System.Drawing.Size(339, 300);
            this.sortEnum.TabIndex = 1;
            this.sortEnum.Text = "Enum";
            this.sortEnum.UseVisualStyleBackColor = true;
            // 
            // sortEnumTextBoxRight
            // 
            this.sortEnumTextBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortEnumTextBoxRight.Location = new System.Drawing.Point(0, 0);
            this.sortEnumTextBoxRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortEnumTextBoxRight.Name = "sortEnumTextBoxRight";
            this.sortEnumTextBoxRight.ReadOnly = true;
            this.sortEnumTextBoxRight.Size = new System.Drawing.Size(339, 300);
            this.sortEnumTextBoxRight.TabIndex = 0;
            this.sortEnumTextBoxRight.Text = "";
            // 
            // copyTimer
            // 
            this.copyTimer.Interval = 1500;
            this.copyTimer.Tick += new System.EventHandler(this.CopyTimer_Tick);
            // 
            // SortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SortTableLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SortControl";
            this.Size = new System.Drawing.Size(770, 512);
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
            this.SortEnumOptionTableLayout.ResumeLayout(false);
            this.SortEnumOptionTableLayout.PerformLayout();
            this.sortSortedTabs.ResumeLayout(false);
            this.sortList.ResumeLayout(false);
            this.sortEnum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SortTableLayout;
        private System.Windows.Forms.Label sortLabel2;
        private System.Windows.Forms.RichTextBox sortTextBoxLeft;
        private System.Windows.Forms.Label sortLabel1;
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
        private System.Windows.Forms.Button SortCopyButton;
        private System.Windows.Forms.Button SortClearButton;
        private System.Windows.Forms.Button SortTextPresentationButton;
        private System.Windows.Forms.Button SortChangeTextCapsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox SortExportDropdown;
        private System.Windows.Forms.Button SortExportEnumButton;
        private System.Windows.Forms.TableLayoutPanel SortEnumOptionTableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SortEnumClassName;
        private System.Windows.Forms.Label SortCopyNotice;
        private System.Windows.Forms.TabControl sortSortedTabs;
        private System.Windows.Forms.TabPage sortList;
        private System.Windows.Forms.RichTextBox sortTextBoxRight;
        private System.Windows.Forms.TabPage sortEnum;
        private System.Windows.Forms.RichTextBox sortEnumTextBoxRight;
        private System.Windows.Forms.Timer copyTimer;
    }
}
