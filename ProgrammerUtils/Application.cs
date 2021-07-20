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

        public Application()
        {
            InitializeComponent();
            Init(); 
        }

        private void Init()
        {
            SortExportDropdown.SelectedIndex = 0;
            _sorter = new Sort(AutoSortCheckbox.Checked, GetSortDisplayMode(), GetSortStyle(), Sort.TextStyles.NORMAL, Sort.TextPresentations.NORMAL);
            SetButtonStatus(SortButton, !AutoSortCheckbox.Checked);
            DoSort();
            SetChangeTextStyleButton();
            SetChangeTextPresentationButton();
            SortCopyNotice.Text = "";
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
        }

        private void SortTextChanged(object sender, EventArgs e)
        {
            if (_sorter.AutoSort)
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
            _sorter.SetAutoSort(AutoSortCheckbox.Checked);

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
            string enumString = ProgrammingConverter.GenerateEnumForLanguage(sortTextBoxLeft.Text, SortExportDropdown.Text, _sorter.SortStyle, _sorter.TextStyle);
            if (enumString.Length > 0)
                Clipboard.SetText(enumString);
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
