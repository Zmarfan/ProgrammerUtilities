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
    public partial class CompareControl : UserControl
    {
        readonly static Color NORMAL_ACTIVE_BUTTON_COLOR = Color.LightSteelBlue;
        readonly static Color NORMAL_NOT_ACTIVE_BUTTON_COLOR = Color.Gray;

        Matcher _matcher;

        public CompareControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            MatchCombinedShowModeDropdown.SelectedIndex = 0;

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
        }

        #region Match

        private void SetButtonStatus(Button button, bool status)
        {
            button.Enabled = status;
            button.BackColor = status ? NORMAL_ACTIVE_BUTTON_COLOR : NORMAL_NOT_ACTIVE_BUTTON_COLOR;
        }

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

    }
}
