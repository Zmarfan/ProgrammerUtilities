using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerUtils
{
    public partial class HtmlCustomRule : UserControl
    {
        public delegate void OnDeleteButtonPressedDelegate(int id);

        private static readonly Color ACTIVE_COLOR = Color.FromArgb(255, 27, 32, 41);
        private static readonly Color NOT_ACTIVE_COLOR = Color.FromArgb(255, 15, 18, 22);
        private static readonly Color ON_NOT_HOVER_COLOR = Color.White;
        private static readonly Color ON_HOVER_COLOR = Color.FromArgb(255, 27, 32, 41);

        public event OnDeleteButtonPressedDelegate OnDeleteButtonPressed;
        public int Id { get; set; }
        public bool Active
        {
            get
            {
                return activeCheckbox.Checked;
            }
            set
            {
                activeCheckbox.Checked = value;
            }
        }
        public char ReplaceCharacter
        {
            get
            {
                if (replaceTextBox.Text.Length == 0)
                    return '\0';
                return replaceTextBox.Text.ToCharArray()[0];
            }
            set
            {
                replaceTextBox.Text = value.ToString();
            }
        }
        public string ReplacementString
        {
            get
            {
                return replacedTextbox.Text;
            }
            set
            {
                replacedTextbox.Text = value;
            }
        }

        private void ChangeActiveState(bool active)
        {
            replaceTextBox.Enabled = active;
            replacedTextbox.Enabled = active;

            mainTableLayout.BackColor = active ? ACTIVE_COLOR : NOT_ACTIVE_COLOR;
        }

        public HtmlCustomRule()
        {
            InitializeComponent();
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            removeButton.ForeColor = ON_NOT_HOVER_COLOR;
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            removeButton.ForeColor = ON_HOVER_COLOR;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            OnDeleteButtonPressed?.Invoke(Id);
        }

        private void ActiveCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeActiveState(activeCheckbox.Checked);
        }
    }
}
