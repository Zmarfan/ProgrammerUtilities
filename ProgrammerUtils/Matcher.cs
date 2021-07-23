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
        private enum CharacterType
        {
            COMBINED,
            TEXT1,
            TEXT2
        }

        private struct CombinedViewCharacter
        {
            public char Character { get; private set; }
            public CharacterType Type { get; private set; }

            public CombinedViewCharacter(char character, CharacterType type)
            {
                Character = character;
                Type = type;
            }
        }

        private struct LCSChar
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
            RichTextBox finalTextBox3,
            Label finalLabel1,
            Label finalLabel2,
            Label finalLabel3,
            bool caseSensitive,
            bool removeExtraWhiteSpaces
            )
        {
            if (introTextBox1.Text.Length == 0 || introTextBox2.Text.Length == 0)
            {
                NoValidEntryData(finalLabel1, finalTextBox1);
                NoValidEntryData(finalLabel2, finalTextBox2);
                NoValidEntryData(finalLabel3, finalTextBox3);
                return;
            }

            if (introTextBox1.Text == introTextBox2.Text || (caseSensitive && introTextBox1.Text.ToLower() == introTextBox2.Text.ToLower()))
            {
                TextsMatch(finalLabel1, finalTextBox1);
                TextsMatch(finalLabel2, finalTextBox2);
                TextsMatch(finalLabel3, finalTextBox3);
                return;
            }

            TextsDoNotMatch(finalLabel1);
            TextsDoNotMatch(finalLabel2);
            TextsDoNotMatch(finalLabel3);

            string s1 = removeExtraWhiteSpaces ? RemoveExtraWhiteSpaces(introTextBox1.Text) : introTextBox1.Text;
            string s2 = removeExtraWhiteSpaces ? RemoveExtraWhiteSpaces(introTextBox2.Text) : introTextBox2.Text;

            DoSeperateMatching(s1, s2, caseSensitive, finalTextBox1, finalTextBox2);
            DoCombinedMatching(s1, s2, caseSensitive, finalTextBox3);
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

        private void DoSeperateMatching(string s1, string s2, bool caseSensitive, RichTextBox finalTextBox1, RichTextBox finalTextBox2)
        {
            List<LCSChar> lcsList = GetLargestCommonSubSequence(s1, s2, caseSensitive);

            HashSet<int> text1HashSet = new HashSet<int>(lcsList.Select(entry => entry.S1Index));
            HashSet<int> text2HashSet = new HashSet<int>(lcsList.Select(entry => entry.S2Index));

            ColorDifferencesInTextSeperate(text1HashSet, finalTextBox1, s1);
            ColorDifferencesInTextSeperate(text2HashSet, finalTextBox2, s2);
        }

        private void DoCombinedMatching(string s1, string s2, bool caseSensitive, RichTextBox finalTextBox)
        {
            List<List<LCSChar>> lcsLists = new List<List<LCSChar>>();
            string[] s1Splits = s1.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] s2Splits = s2.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int numberOfRows = Math.Max(s1Splits.Length, s2Splits.Length);

            for (int i = 0; i < numberOfRows; i++)
            {
                string thisS1String = i < s1Splits.Length ? s1Splits[i] : string.Empty;
                string thisS2String = i < s2Splits.Length ? s2Splits[i] : string.Empty;
                lcsLists.Add(GetLargestCommonSubSequence(thisS1String, thisS2String, caseSensitive));
            }

            List<CombinedViewCharacter> finalText = new List<CombinedViewCharacter>();

            for (int i = 0; i < numberOfRows; i++)
            {
                string thisS1String = i < s1Splits.Length ? s1Splits[i] : string.Empty;
                string thisS2String = i < s2Splits.Length ? s2Splits[i] : string.Empty;

                //No differences
                if (lcsLists[i].Count == thisS1String.Length && lcsLists[i].Count == thisS2String.Length)
                {
                    for (int j = 0; j < thisS1String.Length; j++)
                    {
                        finalText.Add(new CombinedViewCharacter(thisS1String[j], CharacterType.COMBINED));
                    }
                }
                else
                {
                    for (int k = 0; k < thisS1String.Length; k++)
                    {
                        finalText.Add(new CombinedViewCharacter(thisS1String[k], CharacterType.TEXT1));
                    }
                    finalText.Add(new CombinedViewCharacter('\n', CharacterType.COMBINED));
                    for (int h = 0; h < thisS2String.Length; h++)
                    {
                        finalText.Add(new CombinedViewCharacter(thisS2String[h], CharacterType.TEXT2));
                    }
                }
                finalText.Add(new CombinedViewCharacter('\n', CharacterType.COMBINED));
            }

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < finalText.Count; i++)
                builder.Append(finalText[i].Character);

            finalTextBox.Text = builder.ToString();

            for (int i = 0; i < finalTextBox.Text.Length; i++)
            {
                finalTextBox.SelectionStart = i;
                finalTextBox.SelectionLength = 1;

                switch (finalText[i].Type)
                {
                    case CharacterType.COMBINED:
                        SetTextAreaColors(finalTextBox, System.Drawing.Color.FromArgb(255, 10, 13, 20), System.Drawing.Color.Transparent);
                        break;
                    case CharacterType.TEXT1:
                        SetTextAreaColors(finalTextBox, System.Drawing.Color.FromArgb(255, 10, 13, 20), System.Drawing.Color.Plum);
                        break;
                    case CharacterType.TEXT2:
                        SetTextAreaColors(finalTextBox, System.Drawing.Color.FromArgb(255, 10, 13, 20), System.Drawing.Color.PaleTurquoise);
                        break;
                    default:
                        throw new Exception($"No implementation for type: {finalText[i].Type}");
                }
            }
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

        private void ColorDifferencesInTextSeperate(HashSet<int> lcsHashSet, RichTextBox finalTextBox, string text)
        {
            finalTextBox.Text = text;

            for (int i = 0; i < finalTextBox.Text.Length + 1; i++)
            {
                int index = i == 0 ? i : i - 1;

                finalTextBox.SelectionStart = index;
                finalTextBox.SelectionLength = 1;

                if (!lcsHashSet.Contains(i))
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