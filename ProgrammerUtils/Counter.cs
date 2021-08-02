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

        private readonly FlowLayoutPanel _wordFrequencyParent;
        private readonly FlowLayoutPanel _wordDensityParent;

        private readonly RichTextBox _inputTextbox;
        private readonly CountDetail _wordsCountDetail;
        private readonly CountDetail _uniqueWordsCountDetail;
        private readonly CountDetail _differentWordsCountDetail;
        private readonly CountDetail _charactersCountDetail;
        private readonly CountDetail _sentencesCountDetail;
        private readonly CountDetail _paragraphsCountDetail;

        public Counter(
            FlowLayoutPanel wordFrequencyParent,
            FlowLayoutPanel wordDensityParent,
            RichTextBox inputTextbox,
            CountDetail wordsCountDetail,
            CountDetail uniqueWordsCountDetail,
            CountDetail differentWordsCountDetail,
            CountDetail charactersCountDetail,
            CountDetail sentencesCountDetail, 
            CountDetail paragraphsCountDetail
            )
        {
            _wordFrequencyParent = wordFrequencyParent;
            _wordDensityParent = wordDensityParent;
            _inputTextbox = inputTextbox;
            _wordsCountDetail = wordsCountDetail;
            _uniqueWordsCountDetail = uniqueWordsCountDetail;
            _differentWordsCountDetail = differentWordsCountDetail;
            _charactersCountDetail = charactersCountDetail;
            _sentencesCountDetail = sentencesCountDetail;
            _paragraphsCountDetail = paragraphsCountDetail;
        }

        public void Execute()
        {
            RemoveOldData();

            string text = _inputTextbox.Text;
            List<string> allParagraphs = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string unpartitionedText = string.Join("", allParagraphs.ToArray());

            _paragraphsCountDetail._ValueText = allParagraphs.Count.ToString();
            _charactersCountDetail._ValueText = unpartitionedText.Length.ToString();

            List<string> allWords = unpartitionedText.Split(new string[] { " ", ", ", ",", ". ", "." }, StringSplitOptions.RemoveEmptyEntries).ToList();
            _wordsCountDetail._ValueText = allWords.Count.ToString();


            string[] sentences = unpartitionedText.Split(new string[] { ". ", "." }, StringSplitOptions.RemoveEmptyEntries);
            _sentencesCountDetail._ValueText = sentences.Length.ToString();

            Dictionary<string, int> differentWords = CalculateWords(allWords);

            FillNewData(allWords.Count, differentWords, SortMode.AMOUNT);
        }

        private void RemoveOldData()
        {
            for (int i = _wordFrequencyParent.Controls.Count - 1; i >= 0; i--)
                _wordFrequencyParent.Controls.RemoveAt(i);

            for (int i = _wordDensityParent.Controls.Count - 1; i >= 0; i--)
                _wordDensityParent.Controls.RemoveAt(i);
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

            _uniqueWordsCountDetail._ValueText = differentWords.Where(entry => entry.Value == 1).Count().ToString();
            _differentWordsCountDetail._ValueText = differentWords.Count.ToString();

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
            

            foreach (KeyValuePair<string, int> entry in sortedWords)
                SpawnCountDetail(entry.Key, $"#{entry.Value.ToString()}", _wordDensityParent);

            foreach (KeyValuePair<string, int> entry in sortedWords)
                SpawnCountDetail(entry.Key, ((entry.Value / (float)totalAmountOfWords) * 100).ToString("0.00") + "%", _wordFrequencyParent);
        }

        private void SpawnCountDetail(string detailText, string valueText, FlowLayoutPanel parent)
        {
            CountDetail countDetail = new CountDetail
            {
                _DetailText = detailText,
                _ValueText = valueText
            };

            parent.Controls.Add(countDetail);
        }
    }
}
