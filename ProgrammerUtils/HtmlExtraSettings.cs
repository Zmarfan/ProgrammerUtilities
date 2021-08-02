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
    public partial class HtmlExtraSettings : Form
    {
        public struct HtmlCustomSetting
        {
            public bool Active { get; set; }
            public char ReplaceChar { get; set; }
            public string ReplaceToString { get; set; }

            public HtmlCustomSetting(bool active, char replaceChar, string replaceToString)
            {
                Active = active;
                ReplaceChar = replaceChar;
                ReplaceToString = replaceToString;
            }
        }

        public readonly static string SAVE_FILE_NAME = "HtmlCustomSettings";

        private int _indexGiver = int.MinValue;
        private static readonly Color VALID_SAVE_COLOR = Color.FromArgb(255, 26, 153, 118);
        private static readonly Color INVALID_SAVE_COLOR = Color.FromArgb(255, 188, 52, 52);
        private readonly Dictionary<int, HtmlCustomRule> _allCustomRules = new Dictionary<int, HtmlCustomRule>();

        public HtmlExtraSettings()
        {
            InitializeComponent();

            SavingInfoLabel.Text = string.Empty;
            LoadCustomRulesInMemory();
        }

        private bool SaveCustomRulesToMemory()
        {
            displaySaveTimer.Stop();
            displaySaveTimer.Start();

            List<HtmlCustomSetting> data = GetAllCustomSettings();

            HashSet<char> replaceCharacters = new HashSet<char>();

            bool emptyEntries = false;
            bool duplicateEntries = false;

            foreach (HtmlCustomSetting setting in data)
            {
                if (setting.ReplaceChar == '\0' || setting.ReplaceToString == string.Empty)
                    emptyEntries = true;

                if (replaceCharacters.Contains(setting.ReplaceChar))
                    duplicateEntries = true;

                if (emptyEntries && duplicateEntries)
                    break;

                replaceCharacters.Add(setting.ReplaceChar);
            }

            if (!emptyEntries && !duplicateEntries)
            {
                if (SaveService.Save(SAVE_FILE_NAME, data))
                {
                    WriteToSaveLabel(VALID_SAVE_COLOR, "Saved successfully!");
                    return true;
                }
                
                WriteToSaveLabel(INVALID_SAVE_COLOR, "An error occurred while trying to save!");
            }
            else
            {
                StringBuilder errorMessage = new StringBuilder();

                if (emptyEntries)
                    errorMessage.Append("There exists custom rules with incomplete data!\n");
                if (duplicateEntries)
                    errorMessage.Append("There exists custom rules with duplicate data!\n");

                WriteToSaveLabel(INVALID_SAVE_COLOR, errorMessage.ToString());
            }

            return false;
        }

        private void LoadCustomRulesInMemory()
        {
            List<HtmlCustomSetting> data = (List<HtmlCustomSetting>)SaveService.Load(SAVE_FILE_NAME);

            if (data != null)
                data.ForEach(entry => SpawnHtmlCustomSetting(entry.Active, entry.ReplaceChar, entry.ReplaceToString));
        }

        private List<HtmlCustomSetting> GetAllCustomSettings()
        {
            return _allCustomRules
                .Values
                .ToList()
                .Select(entry => new HtmlCustomSetting(entry.Active, entry.ReplaceCharacter, entry.ReplacementString))
                .ToList();
        }

        private void SpawnHtmlCustomSetting(bool active = true, char initChar = '\0', string initString = "")
        {
            while (_allCustomRules.ContainsKey(_indexGiver))
                _indexGiver++;

            HtmlCustomRule newRule = new HtmlCustomRule() { Id = _indexGiver };
            newRule.OnDeleteButtonPressed += DeleteButtonPressed;
            newRule.Active = active;
            newRule.ReplaceCharacter = initChar;
            newRule.ReplacementString = initString;

            CustomSettingsFlowLayout.Controls.Add(newRule);
            _allCustomRules.Add(newRule.Id, newRule);
        }

        private void WriteToSaveLabel(Color color, string text)
        {
            SavingInfoLabel.ForeColor = color;
            SavingInfoLabel.Text = text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SpawnHtmlCustomSetting();
        }

        private void DeleteButtonPressed(int id)
        {
            CustomSettingsFlowLayout.Controls.Remove(_allCustomRules[id]);
            _allCustomRules.Remove(id);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCustomRulesToMemory();
        }

        private void DisplaySaveTimer_Tick(object sender, EventArgs e)
        {
            displaySaveTimer.Stop();
            WriteToSaveLabel(Color.Black, string.Empty);
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            if (SaveCustomRulesToMemory())
                Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
