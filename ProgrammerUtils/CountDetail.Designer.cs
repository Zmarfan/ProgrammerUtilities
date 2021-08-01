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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.detailLabel = new System.Windows.Forms.Label();
            this.valueLabel = new ProgrammerUtils.RoundLabel();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.detailLabel, 0, 0);
            this.tableLayout.Controls.Add(this.valueLabel, 1, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayout.Size = new System.Drawing.Size(271, 37);
            this.tableLayout.TabIndex = 0;
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel.Location = new System.Drawing.Point(4, 1);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(128, 35);
            this.detailLabel.TabIndex = 0;
            this.detailLabel.Text = "DetailLabel:";
            this.detailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valueLabel
            // 
            this.valueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.valueLabel.AutoSize = true;
            this.valueLabel.CornerRadius = 20;
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.valueLabel.Location = new System.Drawing.Point(163, 7);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Padding = new System.Windows.Forms.Padding(3);
            this.valueLabel.RoundedBackColor = System.Drawing.Color.Gray;
            this.valueLabel.Size = new System.Drawing.Size(95, 23);
            this.valueLabel.TabIndex = 1;
            this.valueLabel.Text = "ValueLabel";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CountDetail";
            this.Size = new System.Drawing.Size(271, 37);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label detailLabel;
        private RoundLabel valueLabel;
    }
}
