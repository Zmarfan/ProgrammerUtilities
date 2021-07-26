using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProgrammerUtils
{
    public class HtmlCenter
    {
        public static readonly int RAISED_OFFSET = 7;
        public static readonly int LOWERED_OFFSET = -7;

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

        private readonly RichTextBox _mainInputTextbox;
        private readonly RichTextBox _mainOutputTextbox;

        public HtmlCenter(RichTextBox mainInputTextbox, RichTextBox mainOutputTextbox)
        {
            _mainInputTextbox = mainInputTextbox;
            _mainOutputTextbox = mainOutputTextbox;
        }

        public void ConvertTextToHTML()
        {
            bool bold, italics, underScore, strikeThrough, raised, lowered;
            bold = italics = underScore = strikeThrough = raised = lowered = false;
            StringBuilder finalOutput = new StringBuilder();

            for (int i = 0; i < _mainInputTextbox.Text.Length; i++)
            {
                _mainInputTextbox.SelectionStart = i;
                _mainInputTextbox.SelectionLength = 1;

                SetTagEndings(ref bold, ref italics, ref underScore, ref strikeThrough, ref raised, ref lowered, ref finalOutput);
                SetTagStarts(ref bold, ref italics, ref underScore, ref strikeThrough, ref raised, ref lowered, ref finalOutput);

                //Add actual text entered
                finalOutput.Append(_mainInputTextbox.SelectedText);
            }

            AddFinalEndTags(bold, italics, underScore, strikeThrough, raised, lowered, ref finalOutput);

            _mainOutputTextbox.Text = finalOutput.ToString();
        }

        private void SetTagEndings(ref bool bold, ref bool italics, ref bool underScore, ref bool strikeThrough, ref bool raised, ref bool lowered, ref StringBuilder finalOutput)
        {
            CheckTextStyleEnding(_mainInputTextbox.SelectionFont.Bold, BOLD_START_TAG, BOLD_END_TAG, ref bold, ref finalOutput);
            CheckTextStyleEnding(_mainInputTextbox.SelectionFont.Italic, ITALICS_START_TAG, ITALICS_END_TAG, ref italics, ref finalOutput);
            CheckTextStyleEnding(_mainInputTextbox.SelectionFont.Underline, UNDER_SCORE_START_TAG, UNDER_SCORE_END_TAG, ref underScore, ref finalOutput);
            CheckTextStyleEnding(_mainInputTextbox.SelectionFont.Strikeout, STRIKE_THROUGH_START_TAG, STRIKE_THROUGH_END_TAG, ref strikeThrough, ref finalOutput);
            CheckTextStyleEnding(_mainInputTextbox.SelectionCharOffset == RAISED_OFFSET, RAISED_START_TAG, RAISED_END_TAG, ref raised, ref finalOutput);
            CheckTextStyleEnding(_mainInputTextbox.SelectionCharOffset == LOWERED_OFFSET, LOWERED_START_TAG, LOWERED_END_TAG, ref lowered, ref finalOutput);
        }

        private void SetTagStarts(ref bool bold, ref bool italics, ref bool underScore, ref bool strikeThrough, ref bool raised, ref bool lowered, ref StringBuilder finalOutput)
        {
            CheckTextStyleStart(_mainInputTextbox.SelectionFont.Bold, BOLD_START_TAG, BOLD_END_TAG, ref bold, ref finalOutput);
            CheckTextStyleStart(_mainInputTextbox.SelectionFont.Italic, ITALICS_START_TAG, ITALICS_END_TAG, ref italics, ref finalOutput);
            CheckTextStyleStart(_mainInputTextbox.SelectionFont.Underline, UNDER_SCORE_START_TAG, UNDER_SCORE_END_TAG, ref underScore, ref finalOutput);
            CheckTextStyleStart(_mainInputTextbox.SelectionFont.Strikeout, STRIKE_THROUGH_START_TAG, STRIKE_THROUGH_END_TAG, ref strikeThrough, ref finalOutput);
            CheckTextStyleStart(_mainInputTextbox.SelectionCharOffset == RAISED_OFFSET, RAISED_START_TAG, RAISED_END_TAG, ref raised, ref finalOutput);
            CheckTextStyleStart(_mainInputTextbox.SelectionCharOffset == LOWERED_OFFSET, LOWERED_START_TAG, LOWERED_END_TAG, ref lowered, ref finalOutput);
        }

        private void CheckTextStyleEnding(bool isTextStyle, string startTag, string endTag, ref bool styleActive, ref StringBuilder output)
        {
            if (styleActive && !isTextStyle)
            {
                styleActive = false;
                output.Append(endTag);
            }
        }

        private void CheckTextStyleStart(bool isTextStyle, string startTag, string endTag, ref bool styleActive, ref StringBuilder output)
        {
            if (!styleActive && isTextStyle)
            {
                styleActive = true;
                output.Append(startTag);
            }
        }

        private void AddFinalEndTags(
            bool bold, 
            bool italics, 
            bool underScore, 
            bool strikeThrough, 
            bool raised, 
            bool lowered, 
            ref StringBuilder finalOutput
            )
        {
            if (bold)
                finalOutput.Append(BOLD_END_TAG);
            if (italics)
                finalOutput.Append(ITALICS_END_TAG);
            if (underScore)
                finalOutput.Append(UNDER_SCORE_END_TAG);
            if (strikeThrough)
                finalOutput.Append(STRIKE_THROUGH_END_TAG);
            if (raised)
                finalOutput.Append(RAISED_END_TAG);
            if (lowered)
                finalOutput.Append(LOWERED_END_TAG);
        }
    }
}
