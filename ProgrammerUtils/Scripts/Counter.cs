using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProgrammerUtils
{
    public class Counter
    {
        public struct RichTextBoxCharacter
        {
            public char Character { get; set; }
            public FontStyle FontStyle { get; set; }
            public Color Color { get; set; }
            public RichTextBoxCharacter(char character, FontStyle fontStyle, Color color)
            {
                Character = character;
                FontStyle = fontStyle;
                Color = color;
            }
        }

        public enum SortMode
        {
            ALPHABETICAL,
            AMOUNT
        }

        private static readonly int MAX_AMOUNT_OF_DIFFERENT_WORDS_TO_STYLE = 350;

        private readonly RichTextBox _wordFrequencyTextbox;
        private readonly RichTextBox _wordDensityTextbox;
        private readonly RichTextBox _uniqueWordsTextbox;

        private readonly RichTextBox _inputTextbox;
        private readonly CountDetail _wordsCountDetail;
        private readonly CountDetail _uniqueWordsCountDetail;
        private readonly CountDetail _differentWordsCountDetail;
        private readonly CountDetail _charactersCountDetail;
        private readonly CountDetail _sentencesCountDetail;
        private readonly CountDetail _paragraphsCountDetail;

        private readonly Font _standardFont;
        private readonly Color _defaultTextColor;
        private readonly Color _importantTextColor = Color.FromArgb(255, 152, 196, 58);

        public Counter(
            Color foreColor,
            RichTextBox wordFrequencyTextbox,
            RichTextBox wordDensityTextbox,
            RichTextBox uniqueWordsFlowLayoutTextbox,
            RichTextBox inputTextbox,
            CountDetail wordsCountDetail,
            CountDetail uniqueWordsCountDetail,
            CountDetail differentWordsCountDetail,
            CountDetail charactersCountDetail,
            CountDetail sentencesCountDetail, 
            CountDetail paragraphsCountDetail
            )
        {
            _defaultTextColor = foreColor;

            _wordFrequencyTextbox = wordFrequencyTextbox;
            _wordDensityTextbox = wordDensityTextbox;
            _uniqueWordsTextbox = uniqueWordsFlowLayoutTextbox;
            _inputTextbox = inputTextbox;
            _wordsCountDetail = wordsCountDetail;
            _uniqueWordsCountDetail = uniqueWordsCountDetail;
            _differentWordsCountDetail = differentWordsCountDetail;
            _charactersCountDetail = charactersCountDetail;
            _sentencesCountDetail = sentencesCountDetail;
            _paragraphsCountDetail = paragraphsCountDetail;

            _standardFont = _wordFrequencyTextbox.Font;
        }

        public void Execute(SortMode sortMode, bool caseSensitive)
        {
            RemoveOldData();

            string text = _inputTextbox.Text;

            if (!caseSensitive)
                text = text.ToLower();

            List<string> allParagraphs = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int allCharacters = string.Join("", allParagraphs.ToArray()).Length;
            string workText = text.Replace('\n', ' ');

            _paragraphsCountDetail.ValueText = allParagraphs.Count.ToString();
            _charactersCountDetail.ValueText = allCharacters.ToString();

            List<string> allWords = workText.Split(new string[] { " ", ", ", ",", ". ", "." }, StringSplitOptions.RemoveEmptyEntries).ToList();
            _wordsCountDetail.ValueText = allWords.Count.ToString();


            string[] sentences = workText.Split(new string[] { ". ", "." }, StringSplitOptions.RemoveEmptyEntries);
            _sentencesCountDetail.ValueText = sentences.Length.ToString();

            Dictionary<string, int> differentWords = CalculateWords(allWords);

            FillNewData(allWords.Count, differentWords, sortMode);
        }

        private void RemoveOldData()
        {
            _wordFrequencyTextbox.Text = string.Empty;
            _wordDensityTextbox.Text = string.Empty;
            _uniqueWordsTextbox.Text = string.Empty;
        }

        private Dictionary<string, int> CalculateWords(List<string> allWords)
        {
            Dictionary<string, int> differentWords = new Dictionary<string, int>();

            allWords.ForEach(word =>
            {
                if (!differentWords.ContainsKey(word))
                    differentWords.Add(word, 1);
                else
                    differentWords[word]++;
            });

            _uniqueWordsCountDetail.ValueText = differentWords.Where(entry => entry.Value == 1).Count().ToString();
            _differentWordsCountDetail.ValueText = differentWords.Count.ToString();

            return differentWords;
        }

        private void FillNewData(int totalAmountOfWords, Dictionary<string, int> differentWords, SortMode sortMode)
        {
            bool shouldStyle = differentWords.Count < MAX_AMOUNT_OF_DIFFERENT_WORDS_TO_STYLE;

            List<KeyValuePair<string, int>> sortedWords = differentWords.ToList();
            switch (sortMode)
            {
                case SortMode.ALPHABETICAL: sortedWords.Sort((entry1, entry2) => entry1.Key.CompareTo(entry2.Key)); break;
                case SortMode.AMOUNT: sortedWords.Sort((entry1, entry2) => entry2.Value.CompareTo(entry1.Value)); break;
                default: throw new Exception($"There exist no sortMode for {sortMode}");
            }

            WriteToFrequencyTextbox(totalAmountOfWords, sortedWords, shouldStyle);
            WriteToDensityTextbox(sortedWords, shouldStyle);
            WriteToUniqueTextbox(sortedWords, sortMode, shouldStyle);
        }

        private void WriteToFrequencyTextbox(int totalAmountOfWords, List<KeyValuePair<string, int>> sortedWords, bool shouldStyle)
        {
            List<RichTextBoxCharacter> builder = new List<RichTextBoxCharacter>();

            for (int i = 0; i < sortedWords.Count; i++)
            {
                builder.AddRange(CreateRichText(sortedWords[i].Key, _importantTextColor, FontStyle.Bold));
                builder.AddRange(CreateRichText(": ", _defaultTextColor, FontStyle.Regular));
                builder.AddRange(CreateRichText((sortedWords[i].Value / (float)totalAmountOfWords * 100).ToString("0.00"), _defaultTextColor, FontStyle.Regular));
                builder.AddRange(CreateRichText("%", _defaultTextColor, FontStyle.Regular));
                if (i != sortedWords.Count - 1)
                    builder.AddRange(CreateRichText("\n", _defaultTextColor, FontStyle.Regular));
            }
            if (shouldStyle)
                SetRichTextBoxText(builder, _wordFrequencyTextbox);
            else
                _wordFrequencyTextbox.Text = new string(builder.Select(character => character.Character).ToArray());
        }

        private void WriteToDensityTextbox(List<KeyValuePair<string, int>> sortedWords, bool shouldStyle)
        {
            List<RichTextBoxCharacter> builder = new List<RichTextBoxCharacter>();

            for (int i = 0; i < sortedWords.Count; i++)
            {
                builder.AddRange(CreateRichText(sortedWords[i].Key, _importantTextColor, FontStyle.Bold));
                builder.AddRange(CreateRichText(": ", _defaultTextColor, FontStyle.Regular));
                builder.AddRange(CreateRichText(sortedWords[i].Value.ToString(), _defaultTextColor, FontStyle.Regular));
                if (i != sortedWords.Count - 1)
                    builder.AddRange(CreateRichText("\n", _defaultTextColor, FontStyle.Regular));
            }
            if(shouldStyle)
                SetRichTextBoxText(builder, _wordDensityTextbox);
            else
                _wordDensityTextbox.Text = new string(builder.Select(character => character.Character).ToArray());
        }

        private void WriteToUniqueTextbox(List<KeyValuePair<string, int>> sortedWords, SortMode sortMode, bool shouldStyle)
        {
            List<KeyValuePair<string, int>> uniqueWords = sortedWords.Where(e => e.Value == 1).ToList();
            if (sortMode != SortMode.ALPHABETICAL)
                uniqueWords.Sort((entry1, entry2) => entry1.Key.CompareTo(entry2.Key));

            List<RichTextBoxCharacter> builder = new List<RichTextBoxCharacter>();

            for (int i = 0; i < uniqueWords.Count; i++)
            {
                builder.AddRange(CreateRichText(uniqueWords[i].Key, _importantTextColor, FontStyle.Bold));
                if (i != uniqueWords.Count - 1)
                    builder.AddRange(CreateRichText("\n", _defaultTextColor, FontStyle.Regular));
            }

            if (shouldStyle)
                SetRichTextBoxText(builder, _uniqueWordsTextbox);
            else
                _uniqueWordsTextbox.Text = new string(builder.Select(character => character.Character).ToArray());
        }

        private List<RichTextBoxCharacter> CreateRichText(string text, Color color, FontStyle fontStyle = FontStyle.Regular)
        {
            return text.Select(character => new RichTextBoxCharacter(character, fontStyle, color)).ToList();
        }

        private void SetRichTextBoxText(List<RichTextBoxCharacter> list, RichTextBox textBox)
        {
            textBox.Text = new string(list.Select(character => character.Character).ToArray());

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                textBox.SelectionStart = i;
                textBox.SelectionLength = 1;

                textBox.SelectionFont = AppendFontStyle(_standardFont, list[i].FontStyle);
                textBox.SelectionColor = list[i].Color;
            }
        }

        private Font AppendFontStyle(Font oldFont, FontStyle fontStyle)
        {
            return new Font(oldFont, oldFont.Style | fontStyle);
        }
    }
}
