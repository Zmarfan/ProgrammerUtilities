using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProgrammerUtils
{
    public partial class Application : Form
    {
        readonly static Color NORMAL_ACTIVE_BUTTON_COLOR = Color.LightSteelBlue;
        readonly static Color NORMAL_NOT_ACTIVE_BUTTON_COLOR = Color.Gray;
        readonly static Color COPY_BUTTON_COLOR = Color.LightGoldenrodYellow;
        readonly static Color COPY_CLICKED_BUTTON_COLOR = Color.LimeGreen;

        Sort _sorter;
        Matcher _matcher;
        HtmlCenter _html;

        public Application()
        {
            InitializeComponent();
            Init(); 
        }

        private void Init()
        {
            SortExportDropdown.SelectedIndex = 0;
            MatchCombinedShowModeDropdown.SelectedIndex = 0;

            _sorter = new Sort(GetSortDisplayMode(), GetSortStyle(), Sort.TextStyles.NORMAL, Sort.TextPresentations.NORMAL);
            SetButtonStatus(SortButton, !AutoSortCheckbox.Checked);
            DoSort();

            _matcher = new Matcher(MatchLeftText1,
                MatchLeftText2,
                matchRightText1,
                matchRightText2,
                matchResultCombinedTextBox,
                matchRightText1Label,
                matchRightText2Label,
                matchResultTabCombinedLabel
                );

            SetButtonStatus(matchMatchButton, !matchAutoCompare.Checked);
            DoMatch();    
            
            _html = new HtmlCenter(htmlInputTextbox, htmlOutputTextbox);

            DoHtml();

            SetChangeTextStyleButton();
            SetChangeTextPresentationButton();
            SortCopyNotice.Text = "";

            htmlTagColorRectangle.BackColorChanged += (s, e) => {
                htmlTagColorRectangle.FlatAppearance.MouseOverBackColor = htmlTagColorRectangle.BackColor;
                htmlTagColorRectangle.FlatAppearance.MouseDownBackColor = htmlTagColorRectangle.BackColor;
            };

            htmlEntityColorRectangle.BackColorChanged += (s, e) => {
                htmlEntityColorRectangle.FlatAppearance.MouseOverBackColor = htmlTagColorRectangle.BackColor;
                htmlEntityColorRectangle.FlatAppearance.MouseDownBackColor = htmlTagColorRectangle.BackColor;
            };
        }

        private void SetButtonStatus(Button button, bool status)
        {
            button.Enabled = status;
            button.BackColor = status ? NORMAL_ACTIVE_BUTTON_COLOR : NORMAL_NOT_ACTIVE_BUTTON_COLOR;
        }

        #region Sort
        #region Helper Functions
        private Sort.SortDisplayModes GetSortDisplayMode()
        {
            if (sortSeperatorCommaRadio.Checked)
                return Sort.SortDisplayModes.COMMA;
            else if (sortSeperatorNewLineRadio.Checked)
                return Sort.SortDisplayModes.NEW_LINE;
            else
                throw new System.Exception("There exist too many radios for this setting!");
        }

        private Sort.SortStyles GetSortStyle()
        {
            if (sortAlphabeticlyRadio.Checked)
                return Sort.SortStyles.ALPHABETICAL;
            else if (notSortAlphabeticlyRadio.Checked)
                return Sort.SortStyles.REVERSED;
            else
                throw new System.Exception("There exist too many radios for this setting!");
        }

        private void DoSort()
        {
            string outputString = _sorter.SortString(sortTextBoxLeft.Text);
            sortTextBoxRight.Text = outputString;

            DoEnumSort();
        }

        private void DoEnumSort()
        {
            if (_sorter != null)
            {
                string enumString = ProgrammingConverter.GenerateEnumForLanguage(sortTextBoxLeft.Text, SortExportDropdown.Text, _sorter.SortStyle, _sorter.TextStyle, SortEnumClassName.Text);
                sortEnumTextBoxRight.Text = enumString;
            }         
        }

        private void SortTextChanged(object sender, EventArgs e)
        {
            if (AutoSortCheckbox.Checked)
                DoSort();
        }

        private void SetChangeTextStyleButton()
        {
            //Text style show for the next in the enum list and not for itself.
            switch (_sorter.TextStyle)
            {
                case Sort.TextStyles.NORMAL: SortChangeTextCapsButton.Text = "ABC"; break;
                case Sort.TextStyles.ALL_CAPS: SortChangeTextCapsButton.Text = "abc"; break;
                case Sort.TextStyles.ALL_SMALL: SortChangeTextCapsButton.Text = "Abc"; break;
            }
        }

        private void SetChangeTextPresentationButton()
        {
            switch (_sorter.TextPresentation)
            {
                case Sort.TextPresentations.NORMAL: SortTextPresentationButton.Text = "A_B"; break;
                case Sort.TextPresentations.UNDERSCORE: SortTextPresentationButton.Text = "A B"; break;
            }
        }
        #endregion
        #region Events

        private void SortButton_Click(object sender, EventArgs e)
        {
            DoSort();
        }

        private void AutoSortCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SetButtonStatus(SortButton, !AutoSortCheckbox.Checked);

            DoSort();
        }

        private void SortDisplayModeChange(object sender, EventArgs e)
        {
            _sorter.SetDisplayMode(GetSortDisplayMode());
            DoSort();
        }

        private void SortStyleChanged(object sender, EventArgs e)
        {
            _sorter.SetSortStyle(GetSortStyle());
            DoSort();
        }

        private void SortClearButton_Click(object sender, EventArgs e)
        {
            sortTextBoxLeft.Text = string.Empty;
            sortTextBoxRight.Text = string.Empty;
        }

        private void SortChangeTextCapsButton_Click(object sender, EventArgs e)
        {
            _sorter.ChangeTextStyleToNext();
            SetChangeTextStyleButton();
            DoSort();
        }

        private void SortTextPresentationButton_Click(object sender, EventArgs e)
        {
            _sorter.ChangeTextPresentationToNext();
            SetChangeTextPresentationButton();
            DoSort();
        }

        private void SortCopyButton_Click(object sender, EventArgs e)
        {
            Copy(SortCopyButton);
            if (sortTextBoxRight.Text.Length > 0)
                Clipboard.SetText(sortTextBoxRight.Text);
        }

        private void SortExportEnumButton_Click(object sender, EventArgs e)
        {
            Copy(SortExportEnumButton);
            string enumString = ProgrammingConverter.GenerateEnumForLanguage(sortTextBoxLeft.Text, SortExportDropdown.Text, _sorter.SortStyle, _sorter.TextStyle, SortEnumClassName.Text);
            if (enumString.Length > 0)
                Clipboard.SetText(enumString);
        }

        private void SortExportDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoEnumSort();
        }

        private void SortEnumClassName_TextChanged(object sender, EventArgs e)
        {
            DoEnumSort();
        }
        #endregion
        #endregion

        #region Match

        private void DoMatch()
        {
            _matcher.DoMatch(matchCaseSensitive.Checked, MatchRemoveExtraWhiteSpace.Checked, GetCombinedDisplayMode());
        }

        private Matcher.CombinedDisplayMode GetCombinedDisplayMode()
        {
            string current = MatchCombinedShowModeDropdown.Text;
            switch (current)
            {
                case "Combined: Every line": return Matcher.CombinedDisplayMode.NEW_LINE;
                case "Combined: Every word": return Matcher.CombinedDisplayMode.NEW_WORD;
                default:
                    throw new Exception($"There exist no implementation for this enum type: {current}");
            }
        }

        #region Events

        private void MatchMatchButton_Click(object sender, EventArgs e)
        {
            DoMatch();
        }

        private void MatchAutoCompare_CheckedChanged(object sender, EventArgs e)
        {
            SetButtonStatus(matchMatchButton, !matchAutoCompare.Checked);
            if (matchAutoCompare.Checked)
                DoMatch();
        }

        private void MatchCheckboxChecked(object sender, EventArgs e)
        {
            if (matchAutoCompare.Checked)
                DoMatch();
        }

        private void MatchTextChanged(object sender, EventArgs e)
        {
            if (matchAutoCompare.Checked)
                DoMatch();
        }

        private void MatchClearButton_Click(object sender, EventArgs e)
        {
            MatchLeftText1.Text = string.Empty;
            MatchLeftText2.Text = string.Empty;

            DoMatch();
        }

        private void MatchCombinedShowModeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchAutoCompare.Checked && _matcher != null)
                DoMatch();
        }

        #endregion
        #endregion

        #region HTML
        #region Helper Functions

        private void DoHtml()
        {
            _html.ConvertTextToHTML(htmlColorTagsCheckbox.Checked, htmlColorEntitiesCheckbox.Checked, htmlTagColorRectangle.BackColor, htmlEntityColorRectangle.BackColor);
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

        #endregion
        #region Events

        private void HtmlButton_Click(object sender, EventArgs e)
        {
            DoHtml();
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
            htmlColorTagPicker.ShowDialog();
            htmlTagColorRectangle.BackColor = htmlColorTagPicker.Color;
        }

        private void HtmlChangeEntityColorButton_Click(object sender, EventArgs e)
        {
            htmlColorTagPicker.ShowDialog();
            htmlEntityColorRectangle.BackColor = htmlColorTagPicker.Color;
        }

        #endregion
        #endregion

        #region Copy Timer

        private void Copy(Button button)
        {
            button.BackColor = COPY_CLICKED_BUTTON_COLOR;
            SortCopyNotice.Text = "Copied!";
            CopyTimer.Stop();
            CopyTimer.Start();
        }

        private void CopyTimer_Tick(object sender, EventArgs e)
        {
            SortCopyButton.BackColor = COPY_BUTTON_COLOR;
            SortExportEnumButton.BackColor = COPY_BUTTON_COLOR;
            SortCopyNotice.Text = "";
            CopyTimer.Stop();
        }
        #endregion
    }
}
