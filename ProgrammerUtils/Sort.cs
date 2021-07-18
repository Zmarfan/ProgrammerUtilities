using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerUtils
{
    public class Sort
    {
        public enum SortDisplayMode
        {
            COMMA,
            NEW_LINE
        }

        readonly static string[] SPLITTERS = new string[]
        {
            ", ",
            ",",
            "\n"
        };

        readonly static Dictionary<SortDisplayMode, string> SEPERATORS = new Dictionary<SortDisplayMode, string>()
        {
            { SortDisplayMode.COMMA, ", " },
            { SortDisplayMode.NEW_LINE, "\n" }
        };

        private bool _autoSort;
        private SortDisplayMode _displayMode;

        public Sort(bool autoSort, SortDisplayMode displayMode)
        {
            _autoSort = autoSort;
            _displayMode = displayMode;
        }

        public string SortString(string input)
        {
            List<string> splits = input.Split(SPLITTERS, StringSplitOptions.RemoveEmptyEntries).ToList();
            splits.Sort();
            string returnString = string.Empty;
            splits.ForEach(entry => returnString += entry + SEPERATORS[_displayMode]);
            return returnString;
        }

        public void SetDisplayMode(SortDisplayMode displayMode)
        {
            _displayMode = displayMode;
        }
    }
}
