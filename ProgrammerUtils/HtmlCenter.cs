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
        private struct HtmlBuilderCharacter
        {
            public char Character { get; private set; }
            public Color Color { get; private set; }

            public HtmlBuilderCharacter(char character, Color color)
            {
                Character = character;
                Color = color;
            }
        }

        public static readonly int RAISED_OFFSET = 7;
        public static readonly int LOWERED_OFFSET = -7;
        private static readonly Color DEFAULT_TEXT_COLOR = Color.FromArgb(255, 10, 13, 20);

        private readonly RichTextBox _mainInputTextbox;
        private readonly RichTextBox _mainOutputTextbox;

        public HtmlCenter(RichTextBox mainInputTextbox, RichTextBox mainOutputTextbox)
        {
            _mainInputTextbox = mainInputTextbox;
            _mainOutputTextbox = mainOutputTextbox;
        }

        public void ConvertTextToHTML(bool useSpecialTagColor, Color tagColor)
        {
            tagColor = useSpecialTagColor ? tagColor : DEFAULT_TEXT_COLOR;

            HtmlService service = new HtmlService();
            List<HtmlBuilderCharacter> finalOutput = new List<HtmlBuilderCharacter>();

            for (int i = 0; i < _mainInputTextbox.Text.Length; i++)
            {
                _mainInputTextbox.SelectionStart = i;
                _mainInputTextbox.SelectionLength = 1;

                SetTagEndings(tagColor, ref service, ref finalOutput);
                SetTagStarts(tagColor, ref service, ref finalOutput);

                //Add actual text entered
                finalOutput.AddRange(TextToHtmlCharacter(_mainInputTextbox.SelectedText, DEFAULT_TEXT_COLOR));
            }

            finalOutput.AddRange(TextToHtmlCharacter(service.CloseAllTags(), tagColor));

            SetFinalOutputText(finalOutput);
        }

        private void SetTagEndings(Color tagColor, ref HtmlService service, ref List<HtmlBuilderCharacter> finalOutput)
        {
            if (!_mainInputTextbox.SelectionFont.Bold && service.IsTagActive(HtmlService.HtmlStyles.BOLD))
                finalOutput.AddRange(TextToHtmlCharacter(service.CloseTag(HtmlService.HtmlStyles.BOLD), tagColor));

            if (!_mainInputTextbox.SelectionFont.Italic && service.IsTagActive(HtmlService.HtmlStyles.ITALICS))
                finalOutput.AddRange(TextToHtmlCharacter(service.CloseTag(HtmlService.HtmlStyles.ITALICS), tagColor));

            if (!_mainInputTextbox.SelectionFont.Underline && service.IsTagActive(HtmlService.HtmlStyles.UNDERSCORE))
                finalOutput.AddRange(TextToHtmlCharacter(service.CloseTag(HtmlService.HtmlStyles.UNDERSCORE), tagColor));

            if (!_mainInputTextbox.SelectionFont.Strikeout && service.IsTagActive(HtmlService.HtmlStyles.STRIKETHROUGH))
                finalOutput.AddRange(TextToHtmlCharacter(service.CloseTag(HtmlService.HtmlStyles.STRIKETHROUGH), tagColor));

            if (_mainInputTextbox.SelectionCharOffset != RAISED_OFFSET && service.IsTagActive(HtmlService.HtmlStyles.RAISED))
                finalOutput.AddRange(TextToHtmlCharacter(service.CloseTag(HtmlService.HtmlStyles.RAISED), tagColor));

            if (_mainInputTextbox.SelectionCharOffset != LOWERED_OFFSET && service.IsTagActive(HtmlService.HtmlStyles.LOWERED))
                finalOutput.AddRange(TextToHtmlCharacter(service.CloseTag(HtmlService.HtmlStyles.LOWERED), tagColor));
        }

        private void SetTagStarts(Color tagColor, ref HtmlService service, ref List<HtmlBuilderCharacter> finalOutput)
        {
            if (_mainInputTextbox.SelectionFont.Bold && !service.IsTagActive(HtmlService.HtmlStyles.BOLD))
                finalOutput.AddRange(TextToHtmlCharacter(service.OpenTag(HtmlService.HtmlStyles.BOLD), tagColor));

            if (_mainInputTextbox.SelectionFont.Italic && !service.IsTagActive(HtmlService.HtmlStyles.ITALICS))
                finalOutput.AddRange(TextToHtmlCharacter(service.OpenTag(HtmlService.HtmlStyles.ITALICS), tagColor));

            if (_mainInputTextbox.SelectionFont.Underline && !service.IsTagActive(HtmlService.HtmlStyles.UNDERSCORE))
                finalOutput.AddRange(TextToHtmlCharacter(service.OpenTag(HtmlService.HtmlStyles.UNDERSCORE), tagColor));

            if (_mainInputTextbox.SelectionFont.Strikeout && !service.IsTagActive(HtmlService.HtmlStyles.STRIKETHROUGH))
                finalOutput.AddRange(TextToHtmlCharacter(service.OpenTag(HtmlService.HtmlStyles.STRIKETHROUGH), tagColor));

            if (_mainInputTextbox.SelectionCharOffset == RAISED_OFFSET && !service.IsTagActive(HtmlService.HtmlStyles.RAISED))
                finalOutput.AddRange(TextToHtmlCharacter(service.OpenTag(HtmlService.HtmlStyles.RAISED), tagColor));

            if (_mainInputTextbox.SelectionCharOffset == LOWERED_OFFSET && !service.IsTagActive(HtmlService.HtmlStyles.LOWERED))
                finalOutput.AddRange(TextToHtmlCharacter(service.OpenTag(HtmlService.HtmlStyles.LOWERED), tagColor));
        }

        private List<HtmlBuilderCharacter> TextToHtmlCharacter(string text, Color color)
        {
            List<HtmlBuilderCharacter> list = new List<HtmlBuilderCharacter>();

            text.ToList().ForEach(character =>
            {
                list.Add(new HtmlBuilderCharacter(character, color));
            });

            return list;
        }

        private void SetFinalOutputText(List<HtmlBuilderCharacter> list)
        {
            _mainOutputTextbox.Text = new string(list.Select(entry => entry.Character).ToArray());

            for (int i = 0; i < _mainOutputTextbox.Text.Length; i++)
            {
                _mainOutputTextbox.SelectionStart = i;
                _mainOutputTextbox.SelectionLength = 1;
                _mainOutputTextbox.SelectionColor = list[i].Color;
            }
        }
    }
}
