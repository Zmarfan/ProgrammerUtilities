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
    public partial class HTMLControl : UserControl
    {
        private HtmlCenter _html;
        private HtmlExtraSettings _htmlExtraSettingsWindow;

        public HTMLControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _html = new HtmlCenter(htmlInputTextbox, htmlOutputTextbox);

            DoHtml();
            htmlCopyLabel.Text = string.Empty;

            htmlTagColorRectangle.BackColorChanged += (s, e) => {
                htmlTagColorRectangle.FlatAppearance.MouseOverBackColor = htmlTagColorRectangle.BackColor;
                htmlTagColorRectangle.FlatAppearance.MouseDownBackColor = htmlTagColorRectangle.BackColor;
            };

            htmlEntityColorRectangle.BackColorChanged += (s, e) => {
                htmlEntityColorRectangle.FlatAppearance.MouseOverBackColor = htmlEntityColorRectangle.BackColor;
                htmlEntityColorRectangle.FlatAppearance.MouseDownBackColor = htmlEntityColorRectangle.BackColor;
            };

            htmlCustomColorRectangle.BackColorChanged += (s, e) => {
                htmlCustomColorRectangle.FlatAppearance.MouseOverBackColor = htmlCustomColorRectangle.BackColor;
                htmlCustomColorRectangle.FlatAppearance.MouseDownBackColor = htmlCustomColorRectangle.BackColor;
            };

            SetColorToolTip(htmlTagColorRectangle, htmlTagColorRectangle.BackColor);
            SetColorToolTip(htmlEntityColorRectangle, htmlEntityColorRectangle.BackColor);
            SetColorToolTip(htmlCustomColorRectangle, htmlCustomColorRectangle.BackColor);
        }

        #region HTML
        #region Helper Functions

        private void DoHtml()
        {
            _html.ConvertTextToHTML(
                htmlColorTagsCheckbox.Checked,
                htmlColorEntitiesCheckbox.Checked,
                htmlColorCustomCheckbox.Checked,
                htmlTagColorRectangle.BackColor,
                htmlEntityColorRectangle.BackColor,
                htmlCustomColorRectangle.BackColor
                );
        }

        private void ChangeHtmlRaiseLowerText(CheckBox checkBox, int offset)
        {
            Font newFont, oldFont;
            oldFont = htmlInputTextbox.SelectionFont;

            if (!checkBox.Checked)
            {
                newFont = new Font(oldFont.Name, 7.8f, oldFont.Style, oldFont.Unit);
                htmlInputTextbox.SelectionCharOffset = 0;
            }
            else
            {
                newFont = new Font(oldFont.Name, 5.8f, oldFont.Style, oldFont.Unit);
                htmlInputTextbox.SelectionCharOffset = offset;
            }

            htmlInputTextbox.SelectionFont = newFont;
            htmlInputTextbox.Focus();
        }

        private void ChangeColorForEntityOrTag(Button showColorButton)
        {
            if (htmlColorTagPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = htmlColorTagPicker.Color;
                SetColorToolTip(showColorButton, color);

                DoHtml();
            }
        }

        private void SetColorToolTip(Button showColorButton, Color color)
        {
            showColorButton.BackColor = color;
            htmlColorHoverTooltip.SetToolTip(showColorButton, $"R{color.R}G{color.G}B{color.B}");
        }

        #endregion
        #region Events

        private void HtmlButton_Click(object sender, EventArgs e)
        {
            DoHtml();
        }

        private void HtmlCustomRulesButton_Click(object sender, EventArgs e)
        {
            if (_htmlExtraSettingsWindow == null)
            {
                _htmlExtraSettingsWindow = new HtmlExtraSettings();
                _htmlExtraSettingsWindow.FormClosed += (s, ev) => { _htmlExtraSettingsWindow = null; };
                _htmlExtraSettingsWindow.Show();
            }
        }

        private void HTMLTextStyleButtonChange(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                checkBox.BackColor = Color.AliceBlue;
                checkBox.ForeColor = Color.Blue;
            }
            else
            {
                checkBox.BackColor = Color.Lavender;
                checkBox.ForeColor = Color.FromArgb(255, 10, 13, 20);
            }
        }

        private void HtmlBoldButton_CheckedChanged(object sender, EventArgs e)
        {
            Font newFont, oldFont;
            oldFont = htmlInputTextbox.SelectionFont;
            if (!htmlBoldButton.Checked)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            htmlInputTextbox.SelectionFont = newFont;
            htmlInputTextbox.Focus();
        }

        private void HtmlItalicButton_CheckedChanged(object sender, EventArgs e)
        {
            Font newFont, oldFont;
            oldFont = htmlInputTextbox.SelectionFont;
            if (!htmlItalicButton.Checked)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            htmlInputTextbox.SelectionFont = newFont;
            htmlInputTextbox.Focus();
        }

        private void HtmlStrikeThroughButton_CheckedChanged(object sender, EventArgs e)
        {
            Font newFont, oldFont;
            oldFont = htmlInputTextbox.SelectionFont;
            if (!htmlStrikeThroughButton.Checked)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Strikeout);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Strikeout);

            htmlInputTextbox.SelectionFont = newFont;
            htmlInputTextbox.Focus();
        }

        private void HtmlUnderscoreButton_CheckedChanged(object sender, EventArgs e)
        {
            Font newFont, oldFont;
            oldFont = htmlInputTextbox.SelectionFont;
            if (!htmlUnderscoreButton.Checked)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            htmlInputTextbox.SelectionFont = newFont;
            htmlInputTextbox.Focus();
        }

        private void HtmlRaisedButton_CheckedChanged(object sender, EventArgs e)
        {
            htmlLoweredButton.Checked = false;
            ChangeHtmlRaiseLowerText(htmlRaisedButton, HtmlCenter.RAISED_OFFSET);
        }

        private void HtmlLoweredButton_CheckedChanged(object sender, EventArgs e)
        {
            htmlRaisedButton.Checked = false;
            ChangeHtmlRaiseLowerText(htmlLoweredButton, HtmlCenter.LOWERED_OFFSET);
        }

        private void HtmlInputTextbox_SelectionChanged(object sender, EventArgs e)
        {
            if (htmlInputTextbox.SelectionLength == 0)
            {
                Font currentFont = htmlInputTextbox.SelectionFont;

                htmlBoldButton.Checked = currentFont.Bold;
                htmlItalicButton.Checked = currentFont.Italic;
                htmlUnderscoreButton.Checked = currentFont.Underline;
                htmlStrikeThroughButton.Checked = currentFont.Strikeout;
                htmlRaisedButton.Checked = htmlInputTextbox.SelectionCharOffset == HtmlCenter.RAISED_OFFSET;
                htmlLoweredButton.Checked = htmlInputTextbox.SelectionCharOffset == HtmlCenter.LOWERED_OFFSET;

                HTMLTextStyleButtonChange(htmlBoldButton, null);
                HTMLTextStyleButtonChange(htmlItalicButton, null);
                HTMLTextStyleButtonChange(htmlUnderscoreButton, null);
                HTMLTextStyleButtonChange(htmlStrikeThroughButton, null);
                HTMLTextStyleButtonChange(htmlRaisedButton, null);
                HTMLTextStyleButtonChange(htmlLoweredButton, null);
            }
        }

        private void HtmlChooseColorButton_Click(object sender, EventArgs e)
        {
            ChangeColorForEntityOrTag(htmlTagColorRectangle);
        }

        private void HtmlChangeEntityColorButton_Click(object sender, EventArgs e)
        {
            ChangeColorForEntityOrTag(htmlEntityColorRectangle);
        }

        private void HtmlChangeCustomColorButton_Click(object sender, EventArgs e)
        {
            ChangeColorForEntityOrTag(htmlCustomColorRectangle);
        }

        private void HtmlCopyButton_Click(object sender, EventArgs e)
        {
            Application.Copy(htmlCopyButton, htmlCopyLabel, CopyTimer);
            if (htmlOutputTextbox.Text.Length > 0)
                Clipboard.SetText(htmlOutputTextbox.Text);
        }

        private void HtmlClearButton_Click(object sender, EventArgs e)
        {
            htmlInputTextbox.Text = "";
            htmlOutputTextbox.Text = "";
        }

        private void HtmlOpenAllTags_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.html.am/reference/html-special-characters.cfm");
        }

        private void HtmlColorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            DoHtml();
        }

        private void CopyTimer_Tick(object sender, EventArgs e)
        {
            Application.CopyTimer_Tick(htmlCopyLabel, CopyTimer, htmlCopyButton);
        }

        #endregion
        #endregion

    }
}
