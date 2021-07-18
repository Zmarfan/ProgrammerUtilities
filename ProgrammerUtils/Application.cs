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
        string testString = "Sverige, Danmark, Finland, Ryssland, Spanien, Tyskland, Polen, Egypten\nEstland\nIsland\nJapan";

        Sort _sorter;

        public Application()
        {
            InitializeComponent();
            _sorter = new Sort(AutoSortCheckbox.Checked, GetSortDisplayMode());
        }

        private void SetButtonStatus(Button button, bool status)
        {
            button.Enabled = status;
            button.BackColor = status ? Color.LightSteelBlue : Color.Gray;
        }

        #region Sort

        private Sort.SortDisplayMode GetSortDisplayMode()
        {
            if (sortSeperatorCommaRadio.Checked)
                return Sort.SortDisplayMode.COMMA;
            else if (sortSeperatorNewLineRadio.Checked)
                return Sort.SortDisplayMode.NEW_LINE;
            else
                throw new System.Exception("There exist too many radios for this setting!");
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string inputString = sortTextBoxLeft.Text;
            string outputString = _sorter.SortString(inputString);
            sortTextBoxRight.Text = outputString;
        }

        private void AutoSortCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SetButtonStatus(SortButton, !AutoSortCheckbox.Checked);
        }

        private void SortDisplayModeChange(object sender, EventArgs e)
        {
            _sorter.SetDisplayMode(GetSortDisplayMode());
        }

        #endregion
    }
}
