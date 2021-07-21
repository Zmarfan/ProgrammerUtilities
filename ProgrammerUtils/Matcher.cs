using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerUtils
{
    public class Matcher
    {
        public struct LCSChar
        {
            public char Character { get; private set; }
            public int S1Index { get; private set; }
            public int S2Index { get; private set; }

            public LCSChar(char character, int s1Index, int s2Index)
            {
                Character = character;
                S1Index = s1Index;
                S2Index = s2Index;
            }
        }

        public void DoMatch(
            RichTextBox introTextBox1, 
            RichTextBox introTextBox2, 
            RichTextBox finalTextBox1, 
            RichTextBox finalTextBox2,
            Label finalLabel1,
            Label finalLabel2,
            bool caseSensitive,
            bool removeExtraWhiteSpaces
            )
        {
            if (introTextBox1.Text.Length == 0 || introTextBox2.Text.Length == 0)
            {
                NoValidEntryData(finalLabel1, finalTextBox1);
                NoValidEntryData(finalLabel2, finalTextBox2);
                return;
            }

            if (introTextBox1.Text == introTextBox2.Text || (caseSensitive && introTextBox1.Text.ToLower() == introTextBox2.Text.ToLower()))
            {
                TextsMatch(finalLabel1, finalTextBox1);
                TextsMatch(finalLabel2, finalTextBox2);
                return;
            }

            string s1 = removeExtraWhiteSpaces ? RemoveExtraWhiteSpaces(introTextBox1.Text) : introTextBox1.Text;
            string s2 = removeExtraWhiteSpaces ? RemoveExtraWhiteSpaces(introTextBox2.Text) : introTextBox2.Text;

            List<LCSChar> lcsList = GetLargestCommonSubSequence(s1, s2, caseSensitive);

            HashSet<int> text1HashSet = new HashSet<int>(lcsList.Select(entry => entry.S1Index));
            HashSet<int> text2HashSet = new HashSet<int>(lcsList.Select(entry => entry.S2Index));

            ColorDifferencesInText(text1HashSet, finalTextBox1, finalLabel1, s1);
            ColorDifferencesInText(text2HashSet, finalTextBox2, finalLabel2, s2);
        }

        private string RemoveExtraWhiteSpaces(string text)
        {
            int whiteSpaceCounter = 0;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                whiteSpaceCounter = text[i] == ' ' ? whiteSpaceCounter + 1 : 0;

                if (whiteSpaceCounter > 1 || (i != text.Length - 1 && whiteSpaceCounter == 1 && text[i + 1] == '\n') || whiteSpaceCounter == 1 && (i == 0 || i == text.Length - 1))
                    text = text.Remove(i, 1);
            }

            return text;
        }

        private void NoValidEntryData(Label label, RichTextBox textBox)
        {
            textBox.Text = string.Empty;

            label.ForeColor = System.Drawing.Color.Blue;
            label.Text = "There is currently no text to compare with...";
        }

        private void TextsMatch(Label label, RichTextBox textBox)
        {
            textBox.Text = string.Empty;

            label.ForeColor = System.Drawing.Color.Green;
            label.Text = "The texts match!";
        }

        private void TextsDoNotMatch(Label label)
        {
            label.ForeColor = System.Drawing.Color.Red;
            label.Text = "The texts do not match!";
        }

        private List<LCSChar> GetLargestCommonSubSequence(string s1, string s2, bool caseSensitive)
        {
            if (caseSensitive)
            {
                s1 = s1.ToLower();
                s2 = s2.ToLower();
            }

            int s1Length = s1.Length;
            int s2Length = s2.Length;

            //Create table for largest common sub sequence 
            int[,] table = new int[s1Length + 1, s2Length + 1];
            for (int i = 0; i <= s1Length; i++)
            {
                for (int j = 0; j <= s2Length; j++)
                {
                    if (i == 0 || j == 0)
                        table[i, j] = 0;
                    else if (s1[i - 1] == s2[j - 1])
                        table[i, j] = table[i - 1, j - 1] + 1;
                    else
                        table[i, j] = Math.Max(table[i - 1, j], table[i, j - 1]);
                }
            }

            int index = table[s1Length, s2Length];
            int temp = index;

            LCSChar[] largestCommonSubSequence = new LCSChar[index];

            int ii = s1Length, jj = s2Length;
            while (ii > 0 && jj > 0)
            {
                if (s1[ii - 1] == s2[jj - 1])
                {
                    largestCommonSubSequence[index - 1] = new LCSChar(s1[ii - 1], ii, jj);

                    ii--;
                    jj--;
                    index--;
                }
                else if (table[ii - 1, jj] > table[ii, jj - 1])
                    ii--;
                else
                    jj--;
            }

            return largestCommonSubSequence.ToList();
        }

        private void ColorDifferencesInText(HashSet<int> lcsDictionary, RichTextBox finalTextBox, Label label, string text)
        {
            TextsDoNotMatch(label);

            finalTextBox.Text = text;

            for (int i = 0; i < finalTextBox.Text.Length + 1; i++)
            {
                int index = i == 0 ? i : i - 1;

                finalTextBox.SelectionStart = index;
                finalTextBox.SelectionLength = 1;

                if (!lcsDictionary.Contains(i))
                    SetTextAreaColors(finalTextBox, System.Drawing.Color.Red, System.Drawing.Color.Yellow);
                else
                    SetTextAreaColors(finalTextBox, System.Drawing.Color.FromArgb(255, 10, 13, 20), System.Drawing.Color.Transparent);
            }
        }

        private void SetTextAreaColors(RichTextBox textBox, System.Drawing.Color fontColor, System.Drawing.Color backColor)
        {
            textBox.SelectionColor = fontColor;
            textBox.SelectionBackColor = backColor;
        }
    }
}
