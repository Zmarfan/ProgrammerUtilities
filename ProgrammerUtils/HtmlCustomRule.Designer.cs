namespace ProgrammerUtils
{
    partial class HtmlCustomRule
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
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.replacedTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.mainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.BackColor = System.Drawing.Color.Gainsboro;
            this.mainTableLayout.ColumnCount = 7;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.replacedTextbox, 4, 0);
            this.mainTableLayout.Controls.Add(this.label1, 1, 0);
            this.mainTableLayout.Controls.Add(this.replaceTextBox, 2, 0);
            this.mainTableLayout.Controls.Add(this.activeCheckbox, 0, 0);
            this.mainTableLayout.Controls.Add(this.label2, 3, 0);
            this.mainTableLayout.Controls.Add(this.removeButton, 5, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(386, 51);
            this.mainTableLayout.TabIndex = 0;
            // 
            // replacedTextbox
            // 
            this.replacedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.replacedTextbox.Location = new System.Drawing.Point(239, 14);
            this.replacedTextbox.Name = "replacedTextbox";
            this.replacedTextbox.Size = new System.Drawing.Size(94, 22);
            this.replacedTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(97, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Replace: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceTextBox.Location = new System.Drawing.Point(171, 14);
            this.replaceTextBox.MaxLength = 1;
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(24, 22);
            this.replaceTextBox.TabIndex = 2;
            // 
            // activeCheckbox
            // 
            this.activeCheckbox.AutoSize = true;
            this.activeCheckbox.BackColor = System.Drawing.SystemColors.GrayText;
            this.activeCheckbox.Checked = true;
            this.activeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activeCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeCheckbox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.activeCheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.activeCheckbox.Location = new System.Drawing.Point(8, 8);
            this.activeCheckbox.Margin = new System.Windows.Forms.Padding(8);
            this.activeCheckbox.Name = "activeCheckbox";
            this.activeCheckbox.Padding = new System.Windows.Forms.Padding(5);
            this.activeCheckbox.Size = new System.Drawing.Size(78, 35);
            this.activeCheckbox.TabIndex = 3;
            this.activeCheckbox.Text = "Active";
            this.activeCheckbox.UseVisualStyleBackColor = false;
            this.activeCheckbox.CheckedChanged += new System.EventHandler(this.ActiveCheckbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(201, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "with";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.removeButton.Location = new System.Drawing.Point(346, 10);
            this.removeButton.Margin = new System.Windows.Forms.Padding(10);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(31, 31);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "X";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.removeButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.removeButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // HtmlCustomRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mainTableLayout);
            this.Name = "HtmlCustomRule";
            this.Size = new System.Drawing.Size(386, 51);
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.TextBox replacedTextbox;
        private System.Windows.Forms.CheckBox activeCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeButton;
    }
}
