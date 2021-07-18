using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerUtils
{
    public class Sort
    {
        static string[] SPLITTERS = new string[]
        {
            ", ",
            ",",
            "\n"
        };

        private bool _autoSort;

        public Sort(bool autoSort)
        {
            this._autoSort = autoSort;
        }

        public string SortString(string input)
        {
            List<string> splits = input.Split(SPLITTERS, StringSplitOptions.RemoveEmptyEntries).ToList();
            splits.Sort();
            string returnString = string.Empty;
            splits.ForEach(entry => returnString += entry + "\n");
            return returnString;
        }
    }
}
