using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerUtils
{
    public partial class SortControl : UserControl
    {
        readonly static Color NORMAL_ACTIVE_BUTTON_COLOR = Color.FromArgb(255, 43, 84, 134);
        readonly static Color NORMAL_NOT_ACTIVE_BUTTON_COLOR = Color.FromArgb(255, 73, 87, 103);
        readonly static Color COPY_BUTTON_COLOR = Color.FromArgb(255, 26, 153, 118);
        readonly static Color COPY_CLICKED_BUTTON_COLOR = Color.FromArgb(255, 26, 153, 70);

        Sort _sorter;

        public SortControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            SortExportDropdown.SelectedIndex = 0;

            _sorter = new Sort(GetSortDisplayMode(), GetSortStyle(), Sort.TextStyles.NORMAL, Sort.TextPresentations.NORMAL);
            SetButtonStatus(SortButton, !AutoSortCheckbox.Checked);
            DoSort();

            SortCopyNotice.Text = string.Empty;
            SetChangeTextStyleButton();
            SetChangeTextPresentationButton();
        }

        #region Sort
        #region Helper Functions

        private void Copy(Button button, Label label)
        {
            button.BackColor = COPY_CLICKED_BUTTON_COLOR;
            label.Text = "Copied!";
            copyTimer.Stop();
            copyTimer.Start();
        }

        private void SetButtonStatus(Button button, bool status)
        {
            button.Enabled = status;
            button.BackColor = status ? NORMAL_ACTIVE_BUTTON_COLOR : NORMAL_NOT_ACTIVE_BUTTON_COLOR;
        }

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

        private void CopyTimer_Tick(object sender, EventArgs e)
        {
            SortCopyButton.BackColor = COPY_BUTTON_COLOR;
            SortExportEnumButton.BackColor = COPY_BUTTON_COLOR;
            SortCopyNotice.Text = string.Empty;
            copyTimer.Stop();
        }
        #endregion

        #endregion
    }
}
