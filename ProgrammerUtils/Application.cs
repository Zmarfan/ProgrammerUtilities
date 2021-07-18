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
            _sorter = new Sort(AutoSortCheckbox.Checked);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            sortTextBoxLeft.Text = testString;
            string test = _sorter.SortString(testString);
            sortTextBoxRight.Text = test;
        }

        private void AutoSortCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SetButtonStatus(SortButton, !AutoSortCheckbox.Checked);
        }

        private void SetButtonStatus(Button button, bool status)
        {
            button.Enabled = status;
            button.BackColor = status ? Color.LightSteelBlue : Color.Gray;
        }
    }
}
