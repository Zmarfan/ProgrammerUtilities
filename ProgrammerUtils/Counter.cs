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
        private readonly RichTextBox _inputTextbox;
        private readonly CountDetail _wordsCountDetail;
        private readonly CountDetail _uniqueWordsCountDetail;
        private readonly CountDetail _charactersCountDetail;
        private readonly CountDetail _sentencesCountDetail;
        private readonly CountDetail _paragraphsCountDetail;

        public Counter(
            RichTextBox inputTextbox,
            CountDetail wordsCountDetail,
            CountDetail uniqueWordsCountDetail,
            CountDetail charactersCountDetail,
            CountDetail sentencesCountDetail, 
            CountDetail paragraphsCountDetail
            )
        {
            _inputTextbox = inputTextbox;
            _wordsCountDetail = wordsCountDetail;
            _uniqueWordsCountDetail = uniqueWordsCountDetail;
            _charactersCountDetail = charactersCountDetail;
            _sentencesCountDetail = sentencesCountDetail;
            _paragraphsCountDetail = paragraphsCountDetail;
        }

        public void Execute()
        {
            string text = _inputTextbox.Text;
            List<string> allParagraphs = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string unpartitionedText = string.Join("", allParagraphs.ToArray());

            _paragraphsCountDetail._ValueText = allParagraphs.Count.ToString();
            _charactersCountDetail._ValueText = unpartitionedText.Length.ToString();

            List<string> allWords = unpartitionedText.Split(new string[] { " ", ", ", ",", ".", ". " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            _wordsCountDetail._ValueText = allWords.Count.ToString();


            string[] sentences = unpartitionedText.Split(new string[] { ". ", "." }, StringSplitOptions.RemoveEmptyEntries);
            _sentencesCountDetail._ValueText = sentences.Length.ToString();

            CalculateAllUniqueWords(allWords);
        }

        private void CalculateAllUniqueWords(List<string> allWords)
        {
        }
    }
}
