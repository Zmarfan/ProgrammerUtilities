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
    public partial class HtmlExtraSettings : Form
    {
        private int _indexGiver = int.MinValue;
        private Dictionary<int, HtmlCustomRule> _allCustomRules = new Dictionary<int, HtmlCustomRule>();

        public HtmlExtraSettings()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            while (_allCustomRules.ContainsKey(_indexGiver))
                _indexGiver++;

            HtmlCustomRule newRule = new HtmlCustomRule() { Id = _indexGiver };
            newRule.OnDeleteButtonPressed += DeleteButtonPressed;

            CustomSettingsFlowLayout.Controls.Add(newRule);
            _allCustomRules.Add(newRule.Id, newRule);
        }

        private void DeleteButtonPressed(int id)
        {
            CustomSettingsFlowLayout.Controls.Remove(_allCustomRules[id]);
            _allCustomRules.Remove(id);
        }
    }
}
