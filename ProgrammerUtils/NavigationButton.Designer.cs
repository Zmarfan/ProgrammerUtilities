
namespace ProgrammerUtils
{
    partial class NavigationButton
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
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonLabel = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.Panel();
            this.MainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.ButtonLabel, 1, 0);
            this.MainTableLayout.Controls.Add(this.Picture, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 1;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(250, 50);
            this.MainTableLayout.TabIndex = 0;
            // 
            // ButtonLabel
            // 
            this.ButtonLabel.AutoSize = true;
            this.ButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.ButtonLabel.Location = new System.Drawing.Point(78, 0);
            this.ButtonLabel.Name = "ButtonLabel";
            this.ButtonLabel.Size = new System.Drawing.Size(169, 50);
            this.ButtonLabel.TabIndex = 0;
            this.ButtonLabel.Text = "Text";
            this.ButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Picture
            // 
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.Picture.Location = new System.Drawing.Point(15, 0);
            this.Picture.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(35, 50);
            this.Picture.TabIndex = 1;
            // 
            // NavigationButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.MainTableLayout);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NavigationButton";
            this.Size = new System.Drawing.Size(250, 50);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Label ButtonLabel;
        private System.Windows.Forms.Panel Picture;
    }
}
