using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerUtils
{
    public class HtmlCenter
    {
        private readonly RichTextBox _mainInputTextbox;
        private readonly RichTextBox _mainOutputTextbox;

        public HtmlCenter(RichTextBox mainInputTextbox, RichTextBox mainOutputTextbox)
        {
            _mainInputTextbox = mainInputTextbox;
            _mainOutputTextbox = mainOutputTextbox;
        }

        public void ConvertTextToHTML()
        {
            string formattedString = _mainInputTextbox.Rtf;
            _mainOutputTextbox.Rtf = formattedString;
        }
    }
}
