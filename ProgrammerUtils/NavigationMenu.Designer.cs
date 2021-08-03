
namespace ProgrammerUtils
{
    partial class NavigationMenu
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
            this.NavigationTopTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NavigationPicture = new System.Windows.Forms.Panel();
            this.NavigationTopButton = new System.Windows.Forms.Button();
            this.NavigationBreak = new System.Windows.Forms.Panel();
            this.NavigationTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.navigationHelpButton = new ProgrammerUtils.NavigationButton();
            this.navigationGenerateTextButton = new ProgrammerUtils.NavigationButton();
            this.navigationHTMLButton = new ProgrammerUtils.NavigationButton();
            this.navigationCountButton = new ProgrammerUtils.NavigationButton();
            this.navigationCompareButton = new ProgrammerUtils.NavigationButton();
            this.navigationSortButton = new ProgrammerUtils.NavigationButton();
            this.NavigationTopTableLayout.SuspendLayout();
            this.NavigationTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationTopTableLayout
            // 
            this.NavigationTopTableLayout.ColumnCount = 2;
            this.NavigationTopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationTopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavigationTopTableLayout.Controls.Add(this.NavigationPicture, 0, 0);
            this.NavigationTopTableLayout.Controls.Add(this.NavigationTopButton, 1, 0);
            this.NavigationTopTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationTopTableLayout.Location = new System.Drawing.Point(0, 0);
            this.NavigationTopTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.NavigationTopTableLayout.Name = "NavigationTopTableLayout";
            this.NavigationTopTableLayout.RowCount = 1;
            this.NavigationTopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationTopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.NavigationTopTableLayout.Size = new System.Drawing.Size(253, 100);
            this.NavigationTopTableLayout.TabIndex = 8;
            // 
            // NavigationPicture
            // 
            this.NavigationPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.NavigationPicture.BackgroundImage = global::ProgrammerUtils.Properties.Resources.logo;
            this.NavigationPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NavigationPicture.Location = new System.Drawing.Point(3, 3);
            this.NavigationPicture.Name = "NavigationPicture";
            this.NavigationPicture.Size = new System.Drawing.Size(194, 94);
            this.NavigationPicture.TabIndex = 3;
            // 
            // NavigationTopButton
            // 
            this.NavigationTopButton.BackColor = System.Drawing.Color.Transparent;
            this.NavigationTopButton.BackgroundImage = global::ProgrammerUtils.Properties.Resources.MenuButton1;
            this.NavigationTopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NavigationTopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NavigationTopButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationTopButton.FlatAppearance.BorderSize = 0;
            this.NavigationTopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NavigationTopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NavigationTopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavigationTopButton.ForeColor = System.Drawing.Color.Transparent;
            this.NavigationTopButton.Location = new System.Drawing.Point(203, 10);
            this.NavigationTopButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.NavigationTopButton.Name = "NavigationTopButton";
            this.NavigationTopButton.Size = new System.Drawing.Size(50, 27);
            this.NavigationTopButton.TabIndex = 4;
            this.NavigationTopButton.UseVisualStyleBackColor = false;
            this.NavigationTopButton.Click += new System.EventHandler(this.NavigationTopButton_Click);
            this.NavigationTopButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavigationTopButton_MouseDown);
            this.NavigationTopButton.MouseEnter += new System.EventHandler(this.NavigationTopButton_MouseEnter);
            this.NavigationTopButton.MouseLeave += new System.EventHandler(this.NavigationTopButton_MouseLeave);
            this.NavigationTopButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavigationTopButton_MouseUp);
            // 
            // NavigationBreak
            // 
            this.NavigationBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.NavigationBreak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationBreak.Location = new System.Drawing.Point(0, 350);
            this.NavigationBreak.Margin = new System.Windows.Forms.Padding(0);
            this.NavigationBreak.Name = "NavigationBreak";
            this.NavigationBreak.Size = new System.Drawing.Size(253, 1);
            this.NavigationBreak.TabIndex = 6;
            // 
            // NavigationTableLayout
            // 
            this.NavigationTableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.NavigationTableLayout.ColumnCount = 1;
            this.NavigationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationTableLayout.Controls.Add(this.navigationHelpButton, 0, 7);
            this.NavigationTableLayout.Controls.Add(this.navigationGenerateTextButton, 0, 5);
            this.NavigationTableLayout.Controls.Add(this.navigationHTMLButton, 0, 4);
            this.NavigationTableLayout.Controls.Add(this.navigationCountButton, 0, 3);
            this.NavigationTableLayout.Controls.Add(this.navigationCompareButton, 0, 2);
            this.NavigationTableLayout.Controls.Add(this.navigationSortButton, 0, 1);
            this.NavigationTableLayout.Controls.Add(this.NavigationBreak, 0, 6);
            this.NavigationTableLayout.Controls.Add(this.NavigationTopTableLayout, 0, 0);
            this.NavigationTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationTableLayout.Location = new System.Drawing.Point(0, 0);
            this.NavigationTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.NavigationTableLayout.Name = "NavigationTableLayout";
            this.NavigationTableLayout.RowCount = 9;
            this.NavigationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.NavigationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavigationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavigationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavigationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavigationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavigationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.NavigationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.NavigationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationTableLayout.Size = new System.Drawing.Size(253, 572);
            this.NavigationTableLayout.TabIndex = 3;
            // 
            // navigationHelpButton
            // 
            this.navigationHelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationHelpButton.ButtonClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.navigationHelpButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationHelpButton.ButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.navigationHelpButton.ButtonImage = global::ProgrammerUtils.Properties.Resources.question_mark;
            this.navigationHelpButton.ButtonText = "Help";
            this.navigationHelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationHelpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationHelpButton.Location = new System.Drawing.Point(0, 351);
            this.navigationHelpButton.Margin = new System.Windows.Forms.Padding(0);
            this.navigationHelpButton.Name = "navigationHelpButton";
            this.navigationHelpButton.Size = new System.Drawing.Size(253, 50);
            this.navigationHelpButton.TabIndex = 7;
            this.navigationHelpButton.OnButtonClicked += new ProgrammerUtils.NavigationButton.NavigationButtonClickedDelegate(this.NavigationHelpButton_OnButtonClicked);
            // 
            // navigationGenerateTextButton
            // 
            this.navigationGenerateTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationGenerateTextButton.ButtonClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.navigationGenerateTextButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationGenerateTextButton.ButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.navigationGenerateTextButton.ButtonImage = global::ProgrammerUtils.Properties.Resources.GenerateTextButton;
            this.navigationGenerateTextButton.ButtonText = "Generate Text";
            this.navigationGenerateTextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationGenerateTextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationGenerateTextButton.Location = new System.Drawing.Point(0, 300);
            this.navigationGenerateTextButton.Margin = new System.Windows.Forms.Padding(0);
            this.navigationGenerateTextButton.Name = "navigationGenerateTextButton";
            this.navigationGenerateTextButton.Size = new System.Drawing.Size(253, 50);
            this.navigationGenerateTextButton.TabIndex = 5;
            this.navigationGenerateTextButton.OnButtonClicked += new ProgrammerUtils.NavigationButton.NavigationButtonClickedDelegate(this.NavigationGenerateTextButton_OnButtonClicked);
            // 
            // navigationHTMLButton
            // 
            this.navigationHTMLButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationHTMLButton.ButtonClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.navigationHTMLButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationHTMLButton.ButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.navigationHTMLButton.ButtonImage = global::ProgrammerUtils.Properties.Resources.HtmlButton;
            this.navigationHTMLButton.ButtonText = "HTML:ify";
            this.navigationHTMLButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationHTMLButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationHTMLButton.Location = new System.Drawing.Point(0, 250);
            this.navigationHTMLButton.Margin = new System.Windows.Forms.Padding(0);
            this.navigationHTMLButton.Name = "navigationHTMLButton";
            this.navigationHTMLButton.Size = new System.Drawing.Size(253, 50);
            this.navigationHTMLButton.TabIndex = 4;
            this.navigationHTMLButton.OnButtonClicked += new ProgrammerUtils.NavigationButton.NavigationButtonClickedDelegate(this.NavigationHTMLButton_OnButtonClicked);
            // 
            // navigationCountButton
            // 
            this.navigationCountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationCountButton.ButtonClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.navigationCountButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationCountButton.ButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.navigationCountButton.ButtonImage = global::ProgrammerUtils.Properties.Resources.CountButton;
            this.navigationCountButton.ButtonText = "Count";
            this.navigationCountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationCountButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationCountButton.Location = new System.Drawing.Point(0, 200);
            this.navigationCountButton.Margin = new System.Windows.Forms.Padding(0);
            this.navigationCountButton.Name = "navigationCountButton";
            this.navigationCountButton.Size = new System.Drawing.Size(253, 50);
            this.navigationCountButton.TabIndex = 3;
            this.navigationCountButton.OnButtonClicked += new ProgrammerUtils.NavigationButton.NavigationButtonClickedDelegate(this.NavigationCountButton_OnButtonClicked);
            // 
            // navigationCompareButton
            // 
            this.navigationCompareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationCompareButton.ButtonClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.navigationCompareButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationCompareButton.ButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.navigationCompareButton.ButtonImage = global::ProgrammerUtils.Properties.Resources.CompareButton;
            this.navigationCompareButton.ButtonText = "Compare";
            this.navigationCompareButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationCompareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationCompareButton.Location = new System.Drawing.Point(0, 150);
            this.navigationCompareButton.Margin = new System.Windows.Forms.Padding(0);
            this.navigationCompareButton.Name = "navigationCompareButton";
            this.navigationCompareButton.Size = new System.Drawing.Size(253, 50);
            this.navigationCompareButton.TabIndex = 2;
            this.navigationCompareButton.OnButtonClicked += new ProgrammerUtils.NavigationButton.NavigationButtonClickedDelegate(this.NavigationCompareButton_OnButtonClicked);
            // 
            // navigationSortButton
            // 
            this.navigationSortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationSortButton.ButtonClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.navigationSortButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.navigationSortButton.ButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.navigationSortButton.ButtonImage = global::ProgrammerUtils.Properties.Resources.SortButton;
            this.navigationSortButton.ButtonText = "Sort";
            this.navigationSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navigationSortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationSortButton.Location = new System.Drawing.Point(0, 100);
            this.navigationSortButton.Margin = new System.Windows.Forms.Padding(0);
            this.navigationSortButton.Name = "navigationSortButton";
            this.navigationSortButton.Size = new System.Drawing.Size(253, 50);
            this.navigationSortButton.TabIndex = 1;
            this.navigationSortButton.OnButtonClicked += new ProgrammerUtils.NavigationButton.NavigationButtonClickedDelegate(this.NavigationSortButton_OnButtonClicked);
            // 
            // NavigationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NavigationTableLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NavigationMenu";
            this.Size = new System.Drawing.Size(253, 572);
            this.NavigationTopTableLayout.ResumeLayout(false);
            this.NavigationTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel NavigationTopTableLayout;
        private System.Windows.Forms.Panel NavigationPicture;
        private System.Windows.Forms.Button NavigationTopButton;
        private System.Windows.Forms.Panel NavigationBreak;
        private NavigationButton navigationSortButton;
        private NavigationButton navigationCompareButton;
        private NavigationButton navigationCountButton;
        private NavigationButton navigationHTMLButton;
        private NavigationButton navigationGenerateTextButton;
        private NavigationButton navigationHelpButton;
        private System.Windows.Forms.TableLayoutPanel NavigationTableLayout;
    }
}
