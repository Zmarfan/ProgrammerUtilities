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
        private Counter _counter;

        public CountControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            countSortModes.SelectedIndex = 0;

            _counter = new Counter(
                countWordFrequencyFlowLayoutPanel,
                countWordDensityFlowLayoutPanel,
                countUniqueWordsFlowLayoutPanel,
                countInputTextbox,
                countDetailWords,
                countDetailUniqueWords,
                countDetailDifferentWords,
                countDetailCharacters,
                countDetailSentences,
                countDetailParagraphs
                );
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
    }
}
