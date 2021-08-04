using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerUtils
{
    public partial class GenerateTextControl : UserControl
    {
        readonly static Color COPY_BUTTON_COLOR = Color.FromArgb(255, 26, 153, 118);
        readonly static Color COPY_CLICKED_BUTTON_COLOR = Color.FromArgb(255, 26, 153, 70);

        GenerateText _generateText;

        public GenerateTextControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            generateParagraphType.SelectedIndex = 0;
            _generateText = new GenerateText(generateOutputTextbox, generateSeed);
            generateCopyLabel.Text = string.Empty;
        }

        #region Generate Text
        #region Helper Methods

        private void DoGenerateText(bool customSeed)
        {
            if (_generateText != null)
                _generateText.GenerateRandomWords((int)generateNumberOfWords.Value, GetParagraphType(), customSeed, generateParagraphSizeSlider.Value);
        }

        private GenerateText.ParagraphType GetParagraphType()
        {
            string current = generateParagraphType.Text;
            switch (current)
            {
                case ("Blank row"): return GenerateText.ParagraphType.BLANK_ROW;
                case ("Indent"): return GenerateText.ParagraphType.INDENT;
                case ("No paragraphs"): return GenerateText.ParagraphType.NO_PARAGRAPHS;
                default: throw new Exception($"There exist no implementation for this paragraph type: {current}");
            }
        }

        private void EnableSeed(bool enable)
        {
            generateSeed.Enabled = enable;
        }

        #endregion
        #region Events

        private void GenerateGenerateButton_Click(object sender, EventArgs e)
        {
            DoGenerateText(generateCustomSeed.Checked);
        }

        private void GenerateCopyButton_Click(object sender, EventArgs e)
        {
            Copy(generateCopyButton, generateCopyLabel);
            if (generateOutputTextbox.Text.Length > 0)
                Clipboard.SetText(generateOutputTextbox.Text);
        }

        private void GenerateClearButton_Click(object sender, EventArgs e)
        {
            generateOutputTextbox.Text = string.Empty;
        }

        private void GenerateCustomSeed_CheckedChanged(object sender, EventArgs e)
        {
            EnableSeed(generateCustomSeed.Checked);
        }

        private void GenerateParagraphType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoGenerateText(true);
        }

        private void GenerateParagraphSizeSlider_MouseUp(object sender, MouseEventArgs e)
        {
            DoGenerateText(true);
        }

        private void Copy(Button button, Label label)
        {
            button.BackColor = COPY_CLICKED_BUTTON_COLOR;
            label.Text = "Copied!";
            CopyTimer.Stop();
            CopyTimer.Start();
        }

        private void CopyTimer_Tick(object sender, EventArgs e)
        {
            generateCopyButton.BackColor = COPY_BUTTON_COLOR;
            generateCopyLabel.Text = string.Empty;
            CopyTimer.Stop();
        }

        #endregion

        #endregion

        private void GenerateParagraphType_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = new SolidBrush(generateParagraphType.ForeColor);
            e.DrawBackground();
            e.Graphics.DrawString(generateParagraphType.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}
