using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerUtils
{
    public class Counter
    {
        public enum SortMode
        {
            ALPHABETICAL,
            AMOUNT
        }

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

        public Counter(
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
            List<KeyValuePair<string, int>> sortedWords = differentWords.ToList();
            switch (sortMode)
            {
                case SortMode.ALPHABETICAL: sortedWords.Sort((entry1, entry2) => entry1.Key.CompareTo(entry2.Key)); break;
                case SortMode.AMOUNT: sortedWords.Sort((entry1, entry2) => entry2.Value.CompareTo(entry1.Value)); break;
                default: throw new Exception($"There exist no sortMode for {sortMode}");
            }

            WriteToFrequencyTextbox(totalAmountOfWords, sortedWords);
            WriteToDensityTextbox(sortedWords);
            WriteToUniqueTextbox(sortedWords, sortMode);
        }

        private void WriteToFrequencyTextbox(int totalAmountOfWords, List<KeyValuePair<string, int>> sortedWords)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < sortedWords.Count; i++)
            {
                builder.Append(sortedWords[i].Key);
                builder.Append(" - ");
                builder.Append((sortedWords[i].Value / (float)totalAmountOfWords * 100).ToString("0.00"));
                builder.Append("%");
                if (i != sortedWords.Count - 1)
                    builder.Append("\n");
            }
            _wordFrequencyTextbox.Text = builder.ToString();
        }

        private void WriteToDensityTextbox(List<KeyValuePair<string, int>> sortedWords)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < sortedWords.Count; i++)
            {
                builder.Append(sortedWords[i].Key);
                builder.Append(" - ");
                builder.Append("#");
                builder.Append(sortedWords[i].Value);
                if (i != sortedWords.Count - 1)
                    builder.Append("\n");
            }
            _wordDensityTextbox.Text = builder.ToString();
        }

        private void WriteToUniqueTextbox(List<KeyValuePair<string, int>> sortedWords, SortMode sortMode)
        {
            List<KeyValuePair<string, int>> uniqueWords = sortedWords.Where(e => e.Value == 1).ToList();
            if (sortMode != SortMode.ALPHABETICAL)
                uniqueWords.Sort((entry1, entry2) => entry1.Key.CompareTo(entry2.Key));

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < uniqueWords.Count; i++)
            {
                builder.Append(uniqueWords[i].Key);
                if (i != uniqueWords.Count - 1)
                    builder.Append("\n");
            }
            _uniqueWordsTextbox.Text = builder.ToString();
        }
    }
}
