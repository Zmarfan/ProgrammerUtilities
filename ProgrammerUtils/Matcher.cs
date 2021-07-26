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

        public enum CombinedDisplayMode
        {
            NEW_LINE,
            NEW_WORD,
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

        private struct LCSInObject
        {
            public object Data { get; private set; }
            public object UniqueID { get; private set; }

            public LCSInObject(object data, object uniqueID)
            {
                Data = data;
                UniqueID = uniqueID;
            }

            public override int GetHashCode()
            {
                return (Data.ToString() + UniqueID.ToString()).GetHashCode();
            }
        }

        private class LCSOutObject
        {
            public object Data { get; private set; }
            public int S1Index { get; private set; }
            public int S2Index { get; private set; }

            public LCSOutObject(object data, int s1Index, int s2Index)
            {
                Data = data;
                S1Index = s1Index;
                S2Index = s2Index;
            }
        }

        private static readonly string ADDED_NEW_LINE = "->\n";
        private static readonly string REMOVED_NEW_LINE = "<-\n";

        private readonly RichTextBox _introTextBox1;
        private readonly RichTextBox _introTextBox2;
        private readonly RichTextBox _finalTextBox1;
        private readonly RichTextBox _finalTextBox2;
        private readonly RichTextBox _finalTextBox3;
        private readonly Label _finalLabel1;
        private readonly Label _finalLabel2;
        private readonly Label _finalLabel3;

        public Matcher(
            RichTextBox introTextBox1,
            RichTextBox introTextBox2,
            RichTextBox finalTextBox1,
            RichTextBox finalTextBox2,
            RichTextBox finalTextBox3,
            Label finalLabel1,
            Label finalLabel2,
            Label finalLabel3
            )
        {
            _introTextBox1 = introTextBox1;
            _introTextBox2 = introTextBox2;
            _finalTextBox1 = finalTextBox1;
            _finalTextBox2 = finalTextBox2;
            _finalTextBox3 = finalTextBox3;
            _finalLabel1 = finalLabel1;
            _finalLabel2 = finalLabel2;
            _finalLabel3 = finalLabel3;
        }

        public void DoMatch(bool caseSensitive, bool removeExtraWhiteSpaces, CombinedDisplayMode displayMode)
        {
            if (_introTextBox1.Text.Length == 0 || _introTextBox2.Text.Length == 0)
            {
                NoValidEntryData(_finalLabel1, _finalTextBox1);
                NoValidEntryData(_finalLabel2, _finalTextBox2);
                NoValidEntryData(_finalLabel3, _finalTextBox3);
                return;
            }

            if (_introTextBox1.Text == _introTextBox2.Text || (caseSensitive && _introTextBox1.Text.ToLower() == _introTextBox2.Text.ToLower()))
            {
                TextsMatch(_finalLabel1, _finalTextBox1);
                TextsMatch(_finalLabel2, _finalTextBox2);
                TextsMatch(_finalLabel3, _finalTextBox3);
                return;
            }

            TextsDoNotMatch(_finalLabel1);
            TextsDoNotMatch(_finalLabel2);
            TextsDoNotMatch(_finalLabel3);

            string s1 = removeExtraWhiteSpaces ? RemoveExtraWhiteSpaces(_introTextBox1.Text) : _introTextBox1.Text;
            string s2 = removeExtraWhiteSpaces ? RemoveExtraWhiteSpaces(_introTextBox2.Text) : _introTextBox2.Text;

            if (caseSensitive)
            {
                s1 = s1.ToLower();
                s2 = s2.ToLower();
            }

            DoSeperateMatching(s1, s2, _finalTextBox1, _finalTextBox2);
            DoCombinedMatching(s1, s2, _finalTextBox3, displayMode);
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

        private void DoSeperateMatching(string s1, string s2, RichTextBox finalTextBox1, RichTextBox finalTextBox2)
        {
            LCSInObject[] s1Object = new LCSInObject[s1.Length];
            LCSInObject[] s2Object = new LCSInObject[s2.Length];

            for (int i = 0; i < s1.Length; i++)
                s1Object[i] = new LCSInObject(s1[i], string.Empty);
            for (int i = 0; i < s2.Length; i++)
                s2Object[i] = new LCSInObject(s2[i], string.Empty);

            List<LCSOutObject> lcsList = GetLargestCommonSubSequence(s1Object, s2Object);

            HashSet<int> text1HashSet = new HashSet<int>(lcsList.Select(entry => entry.S1Index));
            HashSet<int> text2HashSet = new HashSet<int>(lcsList.Select(entry => entry.S2Index));

            ColorDifferencesInTextSeperate(text1HashSet, finalTextBox1, s1);
            ColorDifferencesInTextSeperate(text2HashSet, finalTextBox2, s2);
        }

        private void DoCombinedMatching(string s1, string s2, RichTextBox finalTextBox, CombinedDisplayMode displayMode)
        {
            char splitChar = displayMode == CombinedDisplayMode.NEW_LINE ? '\n' : ' ';
            StringSplitOptions spitOption = displayMode == CombinedDisplayMode.NEW_LINE ? StringSplitOptions.None : StringSplitOptions.RemoveEmptyEntries;

            string[] s1Splits = s1.Split(new char[] { splitChar }, spitOption);
            string[] s2Splits = s2.Split(new char[] { splitChar }, spitOption);

            List<LCSOutObject> lcs = GetLargestCommonSubSequence(CreateLCSInArray(s1Splits), CreateLCSInArray(s2Splits));
            int numberOfRows = Math.Max(s1Splits.Length, s2Splits.Length);

            List<CombinedViewCharacter> finalText = new List<CombinedViewCharacter>();

            int currentLCSIndex = 0;
            int s1IndexCounter = 0;
            int s2IndexCounter = 0;

            bool s1DoneLoop = false;
            bool s2DoneLoop = false;

            while (!s1DoneLoop || !s2DoneLoop)
            {
                s1DoneLoop = s1IndexCounter >= s1Splits.Length;
                s2DoneLoop = s2IndexCounter >= s2Splits.Length;

                string thisS1String = !s1DoneLoop ? (s1Splits[s1IndexCounter] == string.Empty ? REMOVED_NEW_LINE : s1Splits[s1IndexCounter]) : string.Empty;
                string thisS2String = !s2DoneLoop ? (s2Splits[s2IndexCounter] == string.Empty ? ADDED_NEW_LINE : s2Splits[s2IndexCounter]) : string.Empty;

                LCSOutObject currentObj = currentLCSIndex < lcs.Count ? lcs[currentLCSIndex] : null;

                if (currentObj != null && currentObj.S1Index == s1IndexCounter + 1 && currentObj.S2Index == s2IndexCounter + 1)
                {
                    AddToFinalText(thisS2String == ADDED_NEW_LINE ? "\n" : thisS2String, CharacterType.COMBINED, splitChar, ref finalText);
                    currentLCSIndex++;
                    s1IndexCounter++;
                    s2IndexCounter++;
                }
                else if (!s1DoneLoop && (currentObj == null || currentObj.S1Index != s1IndexCounter + 1))
                {
                    AddToFinalText(thisS1String, CharacterType.TEXT1, splitChar, ref finalText);
                    s1IndexCounter++;
                }
                else if (!s2DoneLoop && (currentObj == null || currentObj.S2Index != s2IndexCounter + 1))
                {
                    AddToFinalText(thisS2String, CharacterType.TEXT2, splitChar, ref finalText);
                    s2IndexCounter++;
                }
            }

            PrintCombinedMatch(finalText, finalTextBox);
        }

        private LCSInObject[] CreateLCSInArray(string[] splits)
        {
            Dictionary<string, int> duplicateEntries = new Dictionary<string, int>();
            LCSInObject[] objects = new LCSInObject[splits.Length];

            for (int i = 0; i < objects.Length; i++)
            {
                int uniqueId = 0;

                if (duplicateEntries.ContainsKey(splits[i]))
                    uniqueId = duplicateEntries[splits[i]]++;
                else
                    duplicateEntries.Add(splits[i], 1);

                objects[i] = new LCSInObject(splits[i], uniqueId.ToString());
            }

            return objects;
        }

        private void AddToFinalText(string text, CharacterType type, char splitChar, ref List<CombinedViewCharacter> finalText)
        {
            finalText.AddRange(GetLineAsCombinedViewCharacters(text, type));
            if (text != string.Empty && text != ADDED_NEW_LINE && text != REMOVED_NEW_LINE && text != "\n")
                finalText.Add(new CombinedViewCharacter(splitChar, CharacterType.COMBINED));
        }

        private List<CombinedViewCharacter> GetLineAsCombinedViewCharacters(string text, CharacterType type)
        {
            List<CombinedViewCharacter> list = new List<CombinedViewCharacter>();
            for (int i = 0; i < text.Length; i++)
                list.Add(new CombinedViewCharacter(text[i], type));

            return list;
        }

        private void PrintCombinedMatch(List<CombinedViewCharacter> finalText, RichTextBox finalTextBox)
        {
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
                        SetTextAreaColors(finalTextBox, System.Drawing.Color.FromArgb(255, 10, 13, 20), System.Drawing.Color.Pink);
                        break;
                    case CharacterType.TEXT2:
                        SetTextAreaColors(finalTextBox, System.Drawing.Color.FromArgb(255, 10, 13, 20), System.Drawing.Color.PaleGreen);
                        break;
                    default:
                        throw new Exception($"No implementation for type: {finalText[i].Type}");
                }
            }
        }

        private List<LCSOutObject> GetLargestCommonSubSequence(LCSInObject[] s1, LCSInObject[] s2)
        {
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
                    else if (s1[i - 1].GetHashCode() == s2[j - 1].GetHashCode())
                        table[i, j] = table[i - 1, j - 1] + 1;
                    else
                        table[i, j] = Math.Max(table[i - 1, j], table[i, j - 1]);
                }
            }

            int index = table[s1Length, s2Length];
            int temp = index;

            LCSOutObject[] largestCommonSubSequence = new LCSOutObject[index];

            int ii = s1Length, jj = s2Length;
            while (ii > 0 && jj > 0)
            {
                if (s1[ii - 1].GetHashCode() == s2[jj - 1].GetHashCode())
                {
                    largestCommonSubSequence[index - 1] = new LCSOutObject(s1[ii - 1], ii, jj);

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