using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerUtils
{
    public class HtmlService
    {
        public enum HtmlStyles
        {
            BOLD,
            ITALICS,
            UNDERSCORE,
            STRIKETHROUGH,
            RAISED,
            LOWERED
        }

        class HtmlEntry
        {
            public bool Active { get; set; }
            public string OpenTag { get; private set; }
            public string CloseTag { get; private set; }

            public HtmlEntry(string openTag, string closeTag)
            {
                Active = false;
                OpenTag = openTag;
                CloseTag = closeTag;
            }
        }

        private static readonly string BOLD_START_TAG = "<b>";
        private static readonly string BOLD_END_TAG = "</b>";

        private static readonly string ITALICS_START_TAG = "<i>";
        private static readonly string ITALICS_END_TAG = "</i>";

        private static readonly string UNDER_SCORE_START_TAG = "<u>";
        private static readonly string UNDER_SCORE_END_TAG = "</u>";

        private static readonly string STRIKE_THROUGH_START_TAG = "<del>";
        private static readonly string STRIKE_THROUGH_END_TAG = "</del>";

        private static readonly string RAISED_START_TAG = "<sup>";
        private static readonly string RAISED_END_TAG = "</sup>";

        private static readonly string LOWERED_START_TAG = "<sub>";
        private static readonly string LOWERED_END_TAG = "</sub>";

        private readonly Dictionary<HtmlStyles, HtmlEntry> _allStyles = new Dictionary<HtmlStyles, HtmlEntry>()
            {
                { HtmlStyles.BOLD, new HtmlEntry(BOLD_START_TAG, BOLD_END_TAG) },
                { HtmlStyles.ITALICS, new HtmlEntry(ITALICS_START_TAG, ITALICS_END_TAG) },
                { HtmlStyles.UNDERSCORE, new HtmlEntry(UNDER_SCORE_START_TAG, UNDER_SCORE_END_TAG) },
                { HtmlStyles.STRIKETHROUGH, new HtmlEntry(STRIKE_THROUGH_START_TAG, STRIKE_THROUGH_END_TAG) },
                { HtmlStyles.RAISED, new HtmlEntry(RAISED_START_TAG, RAISED_END_TAG) },
                { HtmlStyles.LOWERED, new HtmlEntry(LOWERED_START_TAG, LOWERED_END_TAG) },
            };

        private readonly Stack<HtmlStyles> _activeTags = new Stack<HtmlStyles>();

        public bool IsTagActive(HtmlStyles style)
        {
            return _activeTags.Contains(style);
        }

        public string OpenTag(HtmlStyles style)
        {
            _activeTags.Push(style);
            _allStyles[style].Active = true;

            return _allStyles[style].OpenTag;
        }

        public string CloseTag(HtmlStyles style)
        {
            StringBuilder closingTags = new StringBuilder();

            while (_activeTags.Contains(style))
            {
                HtmlStyles closeStyle = _activeTags.Pop();
                closingTags.Append(_allStyles[closeStyle].CloseTag);
                _allStyles[closeStyle].Active = false;
            }

            return closingTags.ToString();
        }

        public string CloseAllTags()
        {
            StringBuilder closingTags = new StringBuilder();
            while (_activeTags.Count > 0)
                closingTags.Append(_allStyles[_activeTags.Pop()].CloseTag);

            return closingTags.ToString();
        }
    }
}
