
namespace ProgrammerUtils.UserControls
{
    partial class ColorConvertControl
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
            this.settingsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.matchMatchButton = new System.Windows.Forms.Button();
            this.matchAutoCompare = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.leftTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.borderPanel7 = new ProgrammerUtils.BorderPanel();
            this.hwbTextbox = new System.Windows.Forms.TextBox();
            this.borderPanel6 = new ProgrammerUtils.BorderPanel();
            this.hslTextbox = new System.Windows.Forms.TextBox();
            this.borderPanel5 = new ProgrammerUtils.BorderPanel();
            this.hexTextbox = new System.Windows.Forms.TextBox();
            this.borderPanel4 = new ProgrammerUtils.BorderPanel();
            this.rgbTextbox = new System.Windows.Forms.TextBox();
            this.borderPanel3 = new ProgrammerUtils.BorderPanel();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.borderPanel2 = new ProgrammerUtils.BorderPanel();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.inputDescriptionLabel = new System.Windows.Forms.Label();
            this.borderPanel1 = new ProgrammerUtils.BorderPanel();
            this.inputLabel = new System.Windows.Forms.Label();
            this.roundLabel1 = new ProgrammerUtils.RoundLabel();
            this.rgbLabel = new ProgrammerUtils.RoundLabel();
            this.hexLabel = new ProgrammerUtils.RoundLabel();
            this.hslLabel = new ProgrammerUtils.RoundLabel();
            this.hwbLabel = new ProgrammerUtils.RoundLabel();
            this.mainTableLayout.SuspendLayout();
            this.settingsTableLayout.SuspendLayout();
            this.leftTableLayout.SuspendLayout();
            this.borderPanel7.SuspendLayout();
            this.borderPanel6.SuspendLayout();
            this.borderPanel5.SuspendLayout();
            this.borderPanel4.SuspendLayout();
            this.borderPanel3.SuspendLayout();
            this.borderPanel2.SuspendLayout();
            this.borderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.Controls.Add(this.settingsTableLayout, 0, 0);
            this.mainTableLayout.Controls.Add(this.leftTableLayout, 0, 1);
            this.mainTableLayout.Controls.Add(this.borderPanel1, 0, 2);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(4, 4);
            this.mainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayout.Size = new System.Drawing.Size(778, 452);
            this.mainTableLayout.TabIndex = 2;
            // 
            // settingsTableLayout
            // 
            this.settingsTableLayout.ColumnCount = 6;
            this.mainTableLayout.SetColumnSpan(this.settingsTableLayout, 2);
            this.settingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.settingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.settingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.settingsTableLayout.Controls.Add(this.matchMatchButton, 0, 0);
            this.settingsTableLayout.Controls.Add(this.matchAutoCompare, 1, 0);
            this.settingsTableLayout.Controls.Add(this.clearButton, 5, 0);
            this.settingsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTableLayout.Location = new System.Drawing.Point(4, 5);
            this.settingsTableLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsTableLayout.Name = "settingsTableLayout";
            this.settingsTableLayout.RowCount = 2;
            this.settingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsTableLayout.Size = new System.Drawing.Size(770, 50);
            this.settingsTableLayout.TabIndex = 6;
            // 
            // matchMatchButton
            // 
            this.matchMatchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.matchMatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matchMatchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchMatchButton.FlatAppearance.BorderSize = 0;
            this.matchMatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matchMatchButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchMatchButton.Location = new System.Drawing.Point(2, 2);
            this.matchMatchButton.Margin = new System.Windows.Forms.Padding(2);
            this.matchMatchButton.Name = "matchMatchButton";
            this.settingsTableLayout.SetRowSpan(this.matchMatchButton, 2);
            this.matchMatchButton.Size = new System.Drawing.Size(127, 46);
            this.matchMatchButton.TabIndex = 0;
            this.matchMatchButton.Text = "Convert";
            this.matchMatchButton.UseVisualStyleBackColor = false;
            // 
            // matchAutoCompare
            // 
            this.matchAutoCompare.AutoSize = true;
            this.matchAutoCompare.Checked = true;
            this.matchAutoCompare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.matchAutoCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matchAutoCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchAutoCompare.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchAutoCompare.Location = new System.Drawing.Point(133, 2);
            this.matchAutoCompare.Margin = new System.Windows.Forms.Padding(2);
            this.matchAutoCompare.Name = "matchAutoCompare";
            this.settingsTableLayout.SetRowSpan(this.matchAutoCompare, 2);
            this.matchAutoCompare.Size = new System.Drawing.Size(90, 46);
            this.matchAutoCompare.TabIndex = 1;
            this.matchAutoCompare.Text = "Auto Convert";
            this.matchAutoCompare.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(690, 2);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.settingsTableLayout.SetRowSpan(this.clearButton, 2);
            this.clearButton.Size = new System.Drawing.Size(78, 46);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // leftTableLayout
            // 
            this.leftTableLayout.ColumnCount = 2;
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftTableLayout.Controls.Add(this.hwbLabel, 0, 6);
            this.leftTableLayout.Controls.Add(this.hslLabel, 0, 5);
            this.leftTableLayout.Controls.Add(this.hexLabel, 0, 4);
            this.leftTableLayout.Controls.Add(this.rgbLabel, 0, 3);
            this.leftTableLayout.Controls.Add(this.borderPanel7, 1, 6);
            this.leftTableLayout.Controls.Add(this.borderPanel6, 1, 5);
            this.leftTableLayout.Controls.Add(this.borderPanel5, 1, 4);
            this.leftTableLayout.Controls.Add(this.borderPanel4, 1, 3);
            this.leftTableLayout.Controls.Add(this.borderPanel3, 1, 2);
            this.leftTableLayout.Controls.Add(this.borderPanel2, 0, 1);
            this.leftTableLayout.Controls.Add(this.inputDescriptionLabel, 0, 0);
            this.leftTableLayout.Controls.Add(this.roundLabel1, 0, 2);
            this.leftTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTableLayout.Location = new System.Drawing.Point(0, 60);
            this.leftTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.leftTableLayout.Name = "leftTableLayout";
            this.leftTableLayout.RowCount = 8;
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftTableLayout.Size = new System.Drawing.Size(389, 340);
            this.leftTableLayout.TabIndex = 7;
            // 
            // borderPanel7
            // 
            this.borderPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.borderPanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.borderPanel7.BorderWidth = 2;
            this.borderPanel7.Controls.Add(this.hwbTextbox);
            this.borderPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel7.Location = new System.Drawing.Point(104, 219);
            this.borderPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.borderPanel7.Name = "borderPanel7";
            this.borderPanel7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.borderPanel7.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel7.Size = new System.Drawing.Size(281, 27);
            this.borderPanel7.TabIndex = 15;
            // 
            // hwbTextbox
            // 
            this.hwbTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.hwbTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hwbTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hwbTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwbTextbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hwbTextbox.Location = new System.Drawing.Point(4, 6);
            this.hwbTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.hwbTextbox.Name = "hwbTextbox";
            this.hwbTextbox.Size = new System.Drawing.Size(273, 15);
            this.hwbTextbox.TabIndex = 0;
            // 
            // borderPanel6
            // 
            this.borderPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.borderPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.borderPanel6.BorderWidth = 2;
            this.borderPanel6.Controls.Add(this.hslTextbox);
            this.borderPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel6.Location = new System.Drawing.Point(104, 184);
            this.borderPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.borderPanel6.Name = "borderPanel6";
            this.borderPanel6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.borderPanel6.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel6.Size = new System.Drawing.Size(281, 27);
            this.borderPanel6.TabIndex = 14;
            // 
            // hslTextbox
            // 
            this.hslTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.hslTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hslTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hslTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hslTextbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hslTextbox.Location = new System.Drawing.Point(4, 6);
            this.hslTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.hslTextbox.Name = "hslTextbox";
            this.hslTextbox.Size = new System.Drawing.Size(273, 15);
            this.hslTextbox.TabIndex = 0;
            // 
            // borderPanel5
            // 
            this.borderPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.borderPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.borderPanel5.BorderWidth = 2;
            this.borderPanel5.Controls.Add(this.hexTextbox);
            this.borderPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel5.Location = new System.Drawing.Point(104, 149);
            this.borderPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.borderPanel5.Name = "borderPanel5";
            this.borderPanel5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.borderPanel5.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel5.Size = new System.Drawing.Size(281, 27);
            this.borderPanel5.TabIndex = 13;
            // 
            // hexTextbox
            // 
            this.hexTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.hexTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hexTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hexTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexTextbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hexTextbox.Location = new System.Drawing.Point(4, 6);
            this.hexTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.hexTextbox.Name = "hexTextbox";
            this.hexTextbox.Size = new System.Drawing.Size(273, 15);
            this.hexTextbox.TabIndex = 0;
            // 
            // borderPanel4
            // 
            this.borderPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.borderPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.borderPanel4.BorderWidth = 2;
            this.borderPanel4.Controls.Add(this.rgbTextbox);
            this.borderPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel4.Location = new System.Drawing.Point(104, 114);
            this.borderPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.borderPanel4.Name = "borderPanel4";
            this.borderPanel4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.borderPanel4.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel4.Size = new System.Drawing.Size(281, 27);
            this.borderPanel4.TabIndex = 12;
            // 
            // rgbTextbox
            // 
            this.rgbTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.rgbTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rgbTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgbTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbTextbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rgbTextbox.Location = new System.Drawing.Point(4, 6);
            this.rgbTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.rgbTextbox.Name = "rgbTextbox";
            this.rgbTextbox.Size = new System.Drawing.Size(273, 15);
            this.rgbTextbox.TabIndex = 0;
            // 
            // borderPanel3
            // 
            this.borderPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.borderPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.borderPanel3.BorderWidth = 2;
            this.borderPanel3.Controls.Add(this.nameTextbox);
            this.borderPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel3.Location = new System.Drawing.Point(104, 79);
            this.borderPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.borderPanel3.Name = "borderPanel3";
            this.borderPanel3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.borderPanel3.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel3.Size = new System.Drawing.Size(281, 27);
            this.borderPanel3.TabIndex = 11;
            // 
            // nameTextbox
            // 
            this.nameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.nameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameTextbox.Location = new System.Drawing.Point(4, 6);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(273, 15);
            this.nameTextbox.TabIndex = 0;
            // 
            // borderPanel2
            // 
            this.borderPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.borderPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.borderPanel2.BorderWidth = 2;
            this.leftTableLayout.SetColumnSpan(this.borderPanel2, 2);
            this.borderPanel2.Controls.Add(this.inputTextbox);
            this.borderPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel2.Location = new System.Drawing.Point(4, 39);
            this.borderPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.borderPanel2.Name = "borderPanel2";
            this.borderPanel2.Padding = new System.Windows.Forms.Padding(10, 4, 4, 8);
            this.borderPanel2.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel2.Size = new System.Drawing.Size(381, 32);
            this.borderPanel2.TabIndex = 9;
            // 
            // inputTextbox
            // 
            this.inputTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.inputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inputTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inputTextbox.Location = new System.Drawing.Point(10, 9);
            this.inputTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(367, 15);
            this.inputTextbox.TabIndex = 0;
            this.inputTextbox.Text = "rgb(50,30,100)";
            // 
            // inputDescriptionLabel
            // 
            this.inputDescriptionLabel.AutoSize = true;
            this.leftTableLayout.SetColumnSpan(this.inputDescriptionLabel, 2);
            this.inputDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDescriptionLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDescriptionLabel.Location = new System.Drawing.Point(3, 0);
            this.inputDescriptionLabel.Name = "inputDescriptionLabel";
            this.inputDescriptionLabel.Size = new System.Drawing.Size(383, 35);
            this.inputDescriptionLabel.TabIndex = 10;
            this.inputDescriptionLabel.Text = "css name, rgb, hex, hsl, hwb:";
            this.inputDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // borderPanel1
            // 
            this.borderPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.borderPanel1.BorderWidth = 2;
            this.borderPanel1.Controls.Add(this.inputLabel);
            this.borderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel1.Location = new System.Drawing.Point(4, 404);
            this.borderPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.borderPanel1.PanelBorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel1.Size = new System.Drawing.Size(381, 44);
            this.borderPanel1.TabIndex = 8;
            // 
            // inputLabel
            // 
            this.inputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputLabel.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(4, 4);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(373, 36);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Enter a color!";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundLabel1
            // 
            this.roundLabel1.AutoSize = true;
            this.roundLabel1.CornerRadius = 15;
            this.roundLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundLabel1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel1.Location = new System.Drawing.Point(5, 80);
            this.roundLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.roundLabel1.Name = "roundLabel1";
            this.roundLabel1.RoundedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.roundLabel1.Size = new System.Drawing.Size(90, 25);
            this.roundLabel1.TabIndex = 16;
            this.roundLabel1.Text = "Name:";
            this.roundLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.CornerRadius = 15;
            this.rgbLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgbLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbLabel.Location = new System.Drawing.Point(5, 115);
            this.rgbLabel.Margin = new System.Windows.Forms.Padding(5);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.RoundedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.rgbLabel.Size = new System.Drawing.Size(90, 25);
            this.rgbLabel.TabIndex = 17;
            this.rgbLabel.Text = "Rgb:";
            this.rgbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.CornerRadius = 15;
            this.hexLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexLabel.Location = new System.Drawing.Point(5, 150);
            this.hexLabel.Margin = new System.Windows.Forms.Padding(5);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.RoundedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hexLabel.Size = new System.Drawing.Size(90, 25);
            this.hexLabel.TabIndex = 18;
            this.hexLabel.Text = "Hex:";
            this.hexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hslLabel
            // 
            this.hslLabel.AutoSize = true;
            this.hslLabel.CornerRadius = 15;
            this.hslLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hslLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hslLabel.Location = new System.Drawing.Point(5, 185);
            this.hslLabel.Margin = new System.Windows.Forms.Padding(5);
            this.hslLabel.Name = "hslLabel";
            this.hslLabel.RoundedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hslLabel.Size = new System.Drawing.Size(90, 25);
            this.hslLabel.TabIndex = 19;
            this.hslLabel.Text = "Hsl:";
            this.hslLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hwbLabel
            // 
            this.hwbLabel.AutoSize = true;
            this.hwbLabel.CornerRadius = 15;
            this.hwbLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hwbLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwbLabel.Location = new System.Drawing.Point(5, 220);
            this.hwbLabel.Margin = new System.Windows.Forms.Padding(5);
            this.hwbLabel.Name = "hwbLabel";
            this.hwbLabel.RoundedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.hwbLabel.Size = new System.Drawing.Size(90, 25);
            this.hwbLabel.TabIndex = 20;
            this.hwbLabel.Text = "Hwb:";
            this.hwbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ColorConvertControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.mainTableLayout);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ColorConvertControl";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(786, 460);
            this.mainTableLayout.ResumeLayout(false);
            this.settingsTableLayout.ResumeLayout(false);
            this.settingsTableLayout.PerformLayout();
            this.leftTableLayout.ResumeLayout(false);
            this.leftTableLayout.PerformLayout();
            this.borderPanel7.ResumeLayout(false);
            this.borderPanel7.PerformLayout();
            this.borderPanel6.ResumeLayout(false);
            this.borderPanel6.PerformLayout();
            this.borderPanel5.ResumeLayout(false);
            this.borderPanel5.PerformLayout();
            this.borderPanel4.ResumeLayout(false);
            this.borderPanel4.PerformLayout();
            this.borderPanel3.ResumeLayout(false);
            this.borderPanel3.PerformLayout();
            this.borderPanel2.ResumeLayout(false);
            this.borderPanel2.PerformLayout();
            this.borderPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TableLayoutPanel settingsTableLayout;
        private System.Windows.Forms.Button matchMatchButton;
        private System.Windows.Forms.CheckBox matchAutoCompare;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TableLayoutPanel leftTableLayout;
        private BorderPanel borderPanel1;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputTextbox;
        private BorderPanel borderPanel2;
        private System.Windows.Forms.Label inputDescriptionLabel;
        private BorderPanel borderPanel7;
        private System.Windows.Forms.TextBox hwbTextbox;
        private BorderPanel borderPanel6;
        private System.Windows.Forms.TextBox hslTextbox;
        private BorderPanel borderPanel5;
        private System.Windows.Forms.TextBox hexTextbox;
        private BorderPanel borderPanel4;
        private System.Windows.Forms.TextBox rgbTextbox;
        private BorderPanel borderPanel3;
        private System.Windows.Forms.TextBox nameTextbox;
        private RoundLabel roundLabel1;
        private RoundLabel hwbLabel;
        private RoundLabel hslLabel;
        private RoundLabel hexLabel;
        private RoundLabel rgbLabel;
    }
}
