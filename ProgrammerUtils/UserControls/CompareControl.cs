using ProgrammerUtils.Scripts;
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
        readonly static Color NORMAL_ACTIVE_BUTTON_COLOR = Color.FromArgb(255, 43, 84, 134);
        readonly static Color NORMAL_NOT_ACTIVE_BUTTON_COLOR = Color.FromArgb(255, 73, 87, 103);

        Matcher _matcher;
        ImprovedTabs _tabs;

        public CompareControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            MatchCombinedShowModeDropdown.SelectedIndex = 0;

            _matcher = new Matcher(
                MatchLeftText1,
                MatchLeftText2,
                matchRightText1,
                matchRightText2,
                matchResultCombinedTextBox,
                matchRightText1Label,
                matchRightText2Label,
                matchResultCombinedLabel,
                matchResultCombinedTextBox.ForeColor,
                matchResultCombinedTextBox.BackColor
                );

            _tabs = new ImprovedTabs(new List<ImprovedTabs.TabPair>()
            {
                new ImprovedTabs.TabPair(SeparateButton, SeparateTableLayout),
                new ImprovedTabs.TabPair(CombinedButton, combinedTableLayout),
            }, BackColor, NORMAL_ACTIVE_BUTTON_COLOR);

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
            _matcher.DoMatch(!matchCaseSensitive.Checked, MatchRemoveExtraWhiteSpace.Checked, GetCombinedDisplayMode());
            Invalidate();
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

        private void MatchCombinedShowModeDropdown_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = new SolidBrush(MatchCombinedShowModeDropdown.ForeColor);
            e.DrawBackground();
            e.Graphics.DrawString(MatchCombinedShowModeDropdown.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void TabButton_Clicked(object sender, EventArgs e)
        {
            _tabs.TabClicked((Button)sender);
        }
    }
}
