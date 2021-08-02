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
        GenerateText _generateText;
        Counter _counter;
        HtmlExtraSettings _htmlExtraSettingsWindow;
        HelpWindow _helpWindow;

        public Application()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            SortExportDropdown.SelectedIndex = 0;
            MatchCombinedShowModeDropdown.SelectedIndex = 0;
            generateParagraphType.SelectedIndex = 0;
            countSortModes.SelectedIndex = 0;

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

            _generateText = new GenerateText(generateOutputTextbox, generateSeed);

            _counter = new Counter(
                countWordFrequencyFlowLayoutPanel, 
                countWordDensityFlowLayoutPanel, 
                countUniqueWordsFlowLayoutPanel,
                countInputTextbox, 
                countDetailWords, 
                countDetailUniqueWords, 
                countDetailDifferentWords, 
                countDetailCharacters, 
                countDetailSentences, 
                countDetailParagraphs
                );

            SetChangeTextStyleButton();
            SetChangeTextPresentationButton();
            SortCopyNotice.Text = string.Empty;
            htmlCopyLabel.Text = string.Empty;
            generateCopyLabel.Text = string.Empty;

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
            Copy(SortCopyButton, SortCopyNotice);
            if (sortTextBoxRight.Text.Length > 0)
                Clipboard.SetText(sortTextBoxRight.Text);
        }

        private void SortExportEnumButton_Click(object sender, EventArgs e)
        {
            Copy(SortExportEnumButton, SortCopyNotice);
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
                case "Every line": return Matcher.CombinedDisplayMode.NEW_LINE;
                case "Every word": return Matcher.CombinedDisplayMode.NEW_WORD;
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
                showColorButton.BackColor = color;
                htmlColorHoverTooltip.SetToolTip(showColorButton, $"R{color.R}G{color.G}B{color.B}");

                DoHtml();
            }
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
            Copy(htmlCopyButton, htmlCopyLabel);
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

        #endregion
        #endregion

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
            generateSeedLabel.Enabled = enable;

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

        #endregion
        #endregion

        #region Count
        #region Helper Methods

        private void DoCount()
        {
            if (_counter != null)
                _counter.Execute(GetCurrentSortMode(), countCaseSensitive.Checked);
        }

        private Counter.SortMode GetCurrentSortMode()
        {
            switch (countSortModes.Text)
            {
                case ("Alphabetical"): return Counter.SortMode.ALPHABETICAL;
                case ("Value"): return Counter.SortMode.AMOUNT;
                default: throw new Exception($"There exists no implementation for the sortMode {countSortModes.Text}");
            }
        }

        #endregion
        #region Events

        private void CountButton_Click(object sender, EventArgs e)
        {
            DoCount();
        }

        private void CountClearButton_Click(object sender, EventArgs e)
        {
            countInputTextbox.Text = string.Empty;
            DoCount();
        }

        private void CountSortModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoCount();
        }

        private void CountCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            DoCount();
        }

        #endregion
        #endregion

        #region Copy Timer

        private void Copy(Button button, Label label)
        {
            button.BackColor = COPY_CLICKED_BUTTON_COLOR;
            label.Text = "Copied!";
            CopyTimer.Stop();
            CopyTimer.Start();
        }

        private void CopyTimer_Tick(object sender, EventArgs e)
        {
            SortCopyButton.BackColor = COPY_BUTTON_COLOR;
            htmlCopyButton.BackColor = COPY_BUTTON_COLOR;
            generateCopyButton.BackColor = COPY_BUTTON_COLOR;
            SortExportEnumButton.BackColor = COPY_BUTTON_COLOR;
            SortCopyNotice.Text = string.Empty;
            htmlCopyLabel.Text = string.Empty;
            generateCopyLabel.Text = string.Empty;
            CopyTimer.Stop();
        }
        #endregion

        #region Taskbar

        private void FileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpAbout_Click(object sender, EventArgs e)
        {
            _helpWindow = new HelpWindow();
            _helpWindow.ShowDialog();
        }

        private void HowToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Zmarfan/ProgrammerUtils");
        }

        #endregion
    }
}
