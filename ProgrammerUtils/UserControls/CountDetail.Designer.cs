namespace ProgrammerUtils
{
    partial class CountDetail
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
            this.Panel = new System.Windows.Forms.Panel();
            this.BorderPanel = new ProgrammerUtils.BorderPanel();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.detailLabel = new System.Windows.Forms.Label();
            this.valueLabel = new ProgrammerUtils.RoundLabel();
            this.Panel.SuspendLayout();
            this.BorderPanel.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.BorderPanel);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Panel.Size = new System.Drawing.Size(247, 37);
            this.Panel.TabIndex = 0;
            // 
            // BorderPanel
            // 
            this.BorderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.BorderPanel.BorderWidth = 2;
            this.BorderPanel.Controls.Add(this.tableLayout);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderPanel.Location = new System.Drawing.Point(0, 2);
            this.BorderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Padding = new System.Windows.Forms.Padding(4);
            this.BorderPanel.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.BorderPanel.Size = new System.Drawing.Size(247, 33);
            this.BorderPanel.TabIndex = 1;
            // 
            // tableLayout
            // 
            this.tableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.detailLabel, 0, 0);
            this.tableLayout.Controls.Add(this.valueLabel, 1, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(4, 4);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayout.Size = new System.Drawing.Size(239, 25);
            this.tableLayout.TabIndex = 1;
            // 
            // detailLabel
            // 
            this.detailLabel.AutoEllipsis = true;
            this.detailLabel.AutoSize = true;
            this.detailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel.Location = new System.Drawing.Point(3, 0);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(113, 25);
            this.detailLabel.TabIndex = 0;
            this.detailLabel.Text = "DetailLabel:";
            this.detailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valueLabel
            // 
            this.valueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.valueLabel.AutoSize = true;
            this.valueLabel.CornerRadius = 20;
            this.valueLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.valueLabel.Location = new System.Drawing.Point(154, 2);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Padding = new System.Windows.Forms.Padding(3);
            this.valueLabel.RoundedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.valueLabel.Size = new System.Drawing.Size(75, 21);
            this.valueLabel.TabIndex = 1;
            this.valueLabel.Text = "ValueLabel";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.Panel);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CountDetail";
            this.Size = new System.Drawing.Size(247, 37);
            this.Panel.ResumeLayout(false);
            this.BorderPanel.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private BorderPanel BorderPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label detailLabel;
        private RoundLabel valueLabel;
    }
}
