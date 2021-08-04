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
    public partial class CountControl : UserControl
    {
        readonly static Color NORMAL_ACTIVE_BUTTON_COLOR = Color.FromArgb(255, 43, 84, 134);

        private Counter _counter;
        private ImprovedTabs _tabs;

        public CountControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            countSortModes.SelectedIndex = 0;

            _counter = new Counter(
                frequencyLayout,
                densityLayout,
                uniqueLayout,
                countInputTextbox,
                countDetailWords,
                countDetailUniqueWords,
                countDetailDifferentWords,
                countDetailCharacters,
                countDetailSentences,
                countDetailParagraphs
                );

            _tabs = new ImprovedTabs(new List<ImprovedTabs.TabPair>()
            {
                new ImprovedTabs.TabPair(FrequencyButton, frequencyLayout),
                new ImprovedTabs.TabPair(DensityButton, densityLayout),
                new ImprovedTabs.TabPair(UniqueButton, uniqueLayout)
            }, BackColor, NORMAL_ACTIVE_BUTTON_COLOR);
        }

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

        private void CountSortModes_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = new SolidBrush(countSortModes.ForeColor);
            e.DrawBackground();
            e.Graphics.DrawString(countSortModes.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void TabButton_Clicked(object sender, EventArgs e)
        {
            _tabs.TabClicked((Button)sender);
            Invalidate();
        }

        public void ClearData()
        {
            countInputTextbox.Text = string.Empty;
            DoCount();
        }
    }
}
