using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerUtils
{
    public class Sort
    {
        public enum SortDisplayModes
        {
            COMMA,
            NEW_LINE
        }

        public enum SortStyles
        {
            ALPHABETICAL,
            REVERSED
        }

        public enum TextStyles
        {
            NORMAL,
            ALL_CAPS,
            ALL_SMALL,
        }

        readonly static string[] SPLITTERS = new string[]
        {
            ", ",
            ",",
            "\n"
        };

        readonly static Dictionary<SortDisplayModes, string> SEPERATORS = new Dictionary<SortDisplayModes, string>()
        {
            { SortDisplayModes.COMMA, ", " },
            { SortDisplayModes.NEW_LINE, "\n" }
        };

        public bool AutoSort { get; private set; }
        public SortDisplayModes DisplayMode { get; private set; }
        public SortStyles SortStyle { get; private set; }
        public TextStyles TextStyle { get; private set; }

        public Sort(bool autoSort, SortDisplayModes displayMode, SortStyles sortStyle, TextStyles textStyle)
        {
            AutoSort = autoSort;
            DisplayMode = displayMode;
            SortStyle = sortStyle;
            TextStyle = textStyle;
        }

        public string SortString(string input)
        {
            List<string> splits = input.Split(SPLITTERS, StringSplitOptions.RemoveEmptyEntries).ToList();
            splits.Sort();
            string returnString = string.Empty;
            if (SortStyle == SortStyles.REVERSED)
                splits.Reverse();
            splits.ForEach(entry => returnString += entry + SEPERATORS[DisplayMode]);

            if (TextStyle == TextStyles.ALL_CAPS)
                returnString = returnString.ToUpper();
            else if (TextStyle == TextStyles.ALL_SMALL)
                returnString = returnString.ToLower();

            return returnString;
        }

        public void SetAutoSort(bool doAutoSort)
        {
            AutoSort = doAutoSort;
        }

        public void SetDisplayMode(SortDisplayModes displayMode)
        {
            DisplayMode = displayMode;
        }

        public void SetSortStyle(SortStyles sortStyle)
        {
            SortStyle = sortStyle;
        }

        public void ChangeTextStyleToNext()
        {
            TextStyle = (TextStyles)(((int)TextStyle + 1) % Enum.GetValues(typeof(TextStyles)).Length);
        }
    }
}
