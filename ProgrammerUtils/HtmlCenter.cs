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

        private readonly RichTextBox _mainInputTextbox;
        private readonly RichTextBox _mainOutputTextbox;

        public HtmlCenter(RichTextBox mainInputTextbox, RichTextBox mainOutputTextbox)
        {
            _mainInputTextbox = mainInputTextbox;
            _mainOutputTextbox = mainOutputTextbox;
        }

        public void ConvertTextToHTML()
        {
            HtmlService service = new HtmlService();
            StringBuilder finalOutput = new StringBuilder();

            for (int i = 0; i < _mainInputTextbox.Text.Length; i++)
            {
                _mainInputTextbox.SelectionStart = i;
                _mainInputTextbox.SelectionLength = 1;

                SetTagEndings(ref service, ref finalOutput);
                SetTagStarts(ref service, ref finalOutput);

                //Add actual text entered
                finalOutput.Append(_mainInputTextbox.SelectedText);
            }

            finalOutput.Append(service.CloseAllTags());

            _mainOutputTextbox.Text = finalOutput.ToString();
        }

        private void SetTagEndings(ref HtmlService service, ref StringBuilder finalOutput)
        {
            if (!_mainInputTextbox.SelectionFont.Bold && service.IsTagActive(HtmlService.HtmlStyles.BOLD))
                finalOutput.Append(service.CloseTag(HtmlService.HtmlStyles.BOLD));

            if (!_mainInputTextbox.SelectionFont.Italic && service.IsTagActive(HtmlService.HtmlStyles.ITALICS))
                finalOutput.Append(service.CloseTag(HtmlService.HtmlStyles.ITALICS));

            if (!_mainInputTextbox.SelectionFont.Underline && service.IsTagActive(HtmlService.HtmlStyles.UNDERSCORE))
                finalOutput.Append(service.CloseTag(HtmlService.HtmlStyles.UNDERSCORE));

            if (!_mainInputTextbox.SelectionFont.Strikeout && service.IsTagActive(HtmlService.HtmlStyles.STRIKETHROUGH))
                finalOutput.Append(service.CloseTag(HtmlService.HtmlStyles.STRIKETHROUGH));

            if (_mainInputTextbox.SelectionCharOffset != RAISED_OFFSET && service.IsTagActive(HtmlService.HtmlStyles.RAISED))
                finalOutput.Append(service.CloseTag(HtmlService.HtmlStyles.RAISED));

            if (_mainInputTextbox.SelectionCharOffset != LOWERED_OFFSET && service.IsTagActive(HtmlService.HtmlStyles.LOWERED))
                finalOutput.Append(service.CloseTag(HtmlService.HtmlStyles.LOWERED));
        }

        private void SetTagStarts(ref HtmlService service, ref StringBuilder finalOutput)
        {
            if (_mainInputTextbox.SelectionFont.Bold && !service.IsTagActive(HtmlService.HtmlStyles.BOLD))
                finalOutput.Append(service.OpenTag(HtmlService.HtmlStyles.BOLD));

            if (_mainInputTextbox.SelectionFont.Italic && !service.IsTagActive(HtmlService.HtmlStyles.ITALICS))
                finalOutput.Append(service.OpenTag(HtmlService.HtmlStyles.ITALICS));

            if (_mainInputTextbox.SelectionFont.Underline && !service.IsTagActive(HtmlService.HtmlStyles.UNDERSCORE))
                finalOutput.Append(service.OpenTag(HtmlService.HtmlStyles.UNDERSCORE));

            if (_mainInputTextbox.SelectionFont.Strikeout && !service.IsTagActive(HtmlService.HtmlStyles.STRIKETHROUGH))
                finalOutput.Append(service.OpenTag(HtmlService.HtmlStyles.STRIKETHROUGH));

            if (_mainInputTextbox.SelectionCharOffset == RAISED_OFFSET && !service.IsTagActive(HtmlService.HtmlStyles.RAISED))
                finalOutput.Append(service.OpenTag(HtmlService.HtmlStyles.RAISED));

            if (_mainInputTextbox.SelectionCharOffset == LOWERED_OFFSET && !service.IsTagActive(HtmlService.HtmlStyles.LOWERED))
                finalOutput.Append(service.OpenTag(HtmlService.HtmlStyles.LOWERED));
        }

        private void CheckTextStyleStart(bool isTextStyle, string startTag, string endTag, ref bool styleActive, ref StringBuilder output)
        {
            if (!styleActive && isTextStyle)
            {
                styleActive = true;
                output.Append(startTag);
            }
        }
    }
}
