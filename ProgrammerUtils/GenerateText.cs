using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerUtils
{
    public class GenerateText
    {
        public enum ParagraphType
        {
            BLANK_ROW,
            INDENT,
            NO_PARAGRAPHS
        }

        private struct RandomTextEntry
        {
            public string Entry { get; private set; }
            public int Weight { get; private set; }

            public RandomTextEntry(string entry, int weight)
            {
                Entry = entry;
                Weight = weight;
            }
        }

        private static readonly List<RandomTextEntry> TEXT_ENTRIES = new List<RandomTextEntry>()
        {
            new RandomTextEntry("a", 124),
            new RandomTextEntry("ac", 123),
            new RandomTextEntry("accumsan", 49),
            new RandomTextEntry("ad", 4),
            new RandomTextEntry("adipiscing", 7),
            new RandomTextEntry("aenean", 40),
            new RandomTextEntry("aliquam", 77),
            new RandomTextEntry("aliquet", 38),
            new RandomTextEntry("amet", 127),
            new RandomTextEntry("ante", 67),
            new RandomTextEntry("aptent", 4),
            new RandomTextEntry("arcu", 53),
            new RandomTextEntry("at", 108),
            new RandomTextEntry("auctor", 37),
            new RandomTextEntry("augue", 57),
            new RandomTextEntry("bibendum", 48),
            new RandomTextEntry("blandit", 41),
            new RandomTextEntry("class", 4),
            new RandomTextEntry("commodo", 32),
            new RandomTextEntry("condimentum", 38),
            new RandomTextEntry("congue", 40),
            new RandomTextEntry("consectetur", 41),
            new RandomTextEntry("consequat", 49),
            new RandomTextEntry("conubia", 4),
            new RandomTextEntry("convallis", 46),
            new RandomTextEntry("cras", 37),
            new RandomTextEntry("cubilia", 4),
            new RandomTextEntry("Curabitur", 35),
            new RandomTextEntry("curae", 4),
            new RandomTextEntry("cursus", 46),
            new RandomTextEntry("dapibus", 37),
            new RandomTextEntry("diam", 56),
            new RandomTextEntry("dictum", 36),
            new RandomTextEntry("dictumst", 5),
            new RandomTextEntry("dignissim", 46),
            new RandomTextEntry("dis", 3),
            new RandomTextEntry("dolor", 76),
            new RandomTextEntry("donec", 63),
            new RandomTextEntry("dui", 75),
            new RandomTextEntry("Duis", 49),
            new RandomTextEntry("efficitur", 39),
            new RandomTextEntry("egestas", 55),
            new RandomTextEntry("eget", 111),
            new RandomTextEntry("eleifend", 48),
            new RandomTextEntry("elementum", 28),
            new RandomTextEntry("elit", 64),
            new RandomTextEntry("enim", 67),
            new RandomTextEntry("erat", 63),
            new RandomTextEntry("eros", 52),
            new RandomTextEntry("est", 66),
            new RandomTextEntry("et", 140),
            new RandomTextEntry("etiam", 49),
            new RandomTextEntry("eu", 112),
            new RandomTextEntry("euismod", 35),
            new RandomTextEntry("ex", 54),
            new RandomTextEntry("facilisi", 3),
            new RandomTextEntry("facilisis", 39),
            new RandomTextEntry("fames", 12),
            new RandomTextEntry("faucibus", 56),
            new RandomTextEntry("felis", 64),
            new RandomTextEntry("fermentum", 43),
            new RandomTextEntry("feugiat", 41),
            new RandomTextEntry("finibus", 44),
            new RandomTextEntry("fringilla", 53),
            new RandomTextEntry("fusce", 39),
            new RandomTextEntry("gravida", 43),
            new RandomTextEntry("habitant", 8),
            new RandomTextEntry("habitasse", 5),
            new RandomTextEntry("hac", 5),
            new RandomTextEntry("hendrerit", 32),
            new RandomTextEntry("himenaeos", 4),
            new RandomTextEntry("iaculis", 40),
            new RandomTextEntry("id", 104),
            new RandomTextEntry("imperdiet", 38),
            new RandomTextEntry("in", 145),
            new RandomTextEntry("inceptos", 4),
            new RandomTextEntry("integer", 37),
            new RandomTextEntry("interdum", 46),
            new RandomTextEntry("ipsum", 66),
            new RandomTextEntry("justo", 65),
            new RandomTextEntry("lacinia", 39),
            new RandomTextEntry("lacus", 48),
            new RandomTextEntry("laoreet", 38),
            new RandomTextEntry("lectus", 61),
            new RandomTextEntry("leo", 59),
            new RandomTextEntry("libero", 46),
            new RandomTextEntry("ligula", 50),
            new RandomTextEntry("litora", 4),
            new RandomTextEntry("lobortis", 38),
            new RandomTextEntry("lorem", 58),
            new RandomTextEntry("luctus", 45),
            new RandomTextEntry("maecenas", 38),
            new RandomTextEntry("magna", 52),
            new RandomTextEntry("magnis", 3),
            new RandomTextEntry("malesuada", 64),
            new RandomTextEntry("massa", 55),
            new RandomTextEntry("mattis", 45),
            new RandomTextEntry("mauris", 98),
            new RandomTextEntry("maximus", 42),
            new RandomTextEntry("metus", 44),
            new RandomTextEntry("mi", 72),
            new RandomTextEntry("molestie", 42),
            new RandomTextEntry("mollis", 61),
            new RandomTextEntry("montes", 3),
            new RandomTextEntry("morbi", 37),
            new RandomTextEntry("mus", 3),
            new RandomTextEntry("nam", 32),
            new RandomTextEntry("nascetur", 3),
            new RandomTextEntry("natoque", 3),
            new RandomTextEntry("nec", 119),
            new RandomTextEntry("neque", 64),
            new RandomTextEntry("netus", 8),
            new RandomTextEntry("nibh", 62),
            new RandomTextEntry("nisi", 48),
            new RandomTextEntry("nisl", 64),
            new RandomTextEntry("non", 113),
            new RandomTextEntry("nostra", 4),
            new RandomTextEntry("nulla", 97),
            new RandomTextEntry("nullam", 35),
            new RandomTextEntry("nunc", 104),
            new RandomTextEntry("odio", 60),
            new RandomTextEntry("orci", 50),
            new RandomTextEntry("ornare", 47),
            new RandomTextEntry("parturient", 3),
            new RandomTextEntry("pellentesque", 66),
            new RandomTextEntry("penatibus", 3),
            new RandomTextEntry("per", 8),
            new RandomTextEntry("pharetra", 56),
            new RandomTextEntry("phasellus", 31),
            new RandomTextEntry("placerat", 39),
            new RandomTextEntry("platea", 5),
            new RandomTextEntry("porta", 40),
            new RandomTextEntry("porttitor", 48),
            new RandomTextEntry("posuere", 43),
            new RandomTextEntry("potenti", 6),
            new RandomTextEntry("praesent", 33),
            new RandomTextEntry("pretium", 30),
            new RandomTextEntry("primis", 8),
            new RandomTextEntry("proin", 28),
            new RandomTextEntry("pulvinar", 42),
            new RandomTextEntry("purus", 59),
            new RandomTextEntry("quam", 52),
            new RandomTextEntry("quis", 109),
            new RandomTextEntry("quisque", 37),
            new RandomTextEntry("rhoncus", 43),
            new RandomTextEntry("ridiculus", 3),
            new RandomTextEntry("risus", 58),
            new RandomTextEntry("rutrum", 48),
            new RandomTextEntry("sagittis", 48),
            new RandomTextEntry("sapien", 48),
            new RandomTextEntry("scelerisque", 49),
            new RandomTextEntry("sed", 200),
            new RandomTextEntry("sem", 55),
            new RandomTextEntry("semper", 49),
            new RandomTextEntry("senectus", 8),
            new RandomTextEntry("sit", 127),
            new RandomTextEntry("sociosqu", 4),
            new RandomTextEntry("sodales", 47),
            new RandomTextEntry("sollicitudin", 42),
            new RandomTextEntry("suscipit", 34),
            new RandomTextEntry("suspendisse", 49),
            new RandomTextEntry("taciti", 4),
            new RandomTextEntry("tellus", 63),
            new RandomTextEntry("tempor", 44),
            new RandomTextEntry("tempus", 40),
            new RandomTextEntry("tincidunt", 82),
            new RandomTextEntry("torquent", 4),
            new RandomTextEntry("tortor", 36),
            new RandomTextEntry("tristique", 47),
            new RandomTextEntry("turpis", 52),
            new RandomTextEntry("ullamcorper", 44),
            new RandomTextEntry("ultrices", 44),
            new RandomTextEntry("ultricies", 42),
            new RandomTextEntry("urna", 70),
            new RandomTextEntry("ut", 149),
            new RandomTextEntry("varius", 50),
            new RandomTextEntry("vehicula", 47),
            new RandomTextEntry("vel", 116),
            new RandomTextEntry("velit", 65),
            new RandomTextEntry("venenatis", 44),
            new RandomTextEntry("vestibulum", 88),
            new RandomTextEntry("vitae", 125),
            new RandomTextEntry("vivamus", 39),
            new RandomTextEntry("viverra", 38),
            new RandomTextEntry("volutpat", 41),
            new RandomTextEntry("vulputate", 33),
        };
        //needs to be updated when adding more words and changing weights. Unnecessary to recalculate on release
        private static readonly int TOTAL_TEXT_ENTRIES_WEIGHT = 8972;
        private static readonly int MIN_PARAGRAPH_SENTENCES = 4;
        private static readonly int MAX_PARAGRAPH_SENTENCES = 10;
        private static readonly int MIN_WORDS_IN_SENTENCE = 3;
        private static readonly int MAX_WORDS_IN_SENTENCE = 35;
        private static readonly int MIN_WORDS_BETWEEN_COMMAS = 3;
        private static readonly int MAX_WORDS_BETWEEN_COMMAS = 20;

        private readonly RichTextBox _outputTextBox;
        private readonly NumericUpDown _generateSeedNumericUpDown;

        public GenerateText(RichTextBox outputTextBox, NumericUpDown generateSeedNumericUpDown)
        {
            _outputTextBox = outputTextBox;
            _generateSeedNumericUpDown = generateSeedNumericUpDown;
        }

        /// <param name="paragraphSize">Will be a value between 0 - 200 where 75 is considered baseline</param>
        public void GenerateRandomWords(int amountOfWords, ParagraphType paragraphType, bool useCustomSeed, int paragraphSize)
        {
            string generatedText = GenerateTextNow(amountOfWords, paragraphType, useCustomSeed, GetParagraphSizeOffset(paragraphSize));
            _outputTextBox.Text = generatedText;
        }

        /// <summary>
        /// Returns a offset value for amount of min and max sentences in a paragraph. 75 for paragraphsize is considered baseline
        /// </summary>
        /// <param name="paragraphSize"></param>
        /// <returns></returns>
        private int GetParagraphSizeOffset(int paragraphSize)
        {
            return (int)Math.Round(paragraphSize / 10 - 7.5f);
        }

        private string GenerateTextNow(int amountOfWords, ParagraphType paragraphType, bool useCustomSeed, int paragraphOffset)
        {
            Random seedRandom = new Random(Environment.TickCount);
            int seed = useCustomSeed ? (int)_generateSeedNumericUpDown.Value : seedRandom.Next(int.MinValue, int.MaxValue);
            Random random = new Random(seed);

            _generateSeedNumericUpDown.Value = seed;

            StringBuilder builder = new StringBuilder();

            int currentWordIndex = 0;
            while (currentWordIndex < amountOfWords)
            {
                int paragraphSentences = random.Next(Math.Max(1, MIN_PARAGRAPH_SENTENCES + paragraphOffset), Math.Max(1, MAX_PARAGRAPH_SENTENCES + paragraphOffset));
                for (int sentenceIndex = 0; sentenceIndex < paragraphSentences; sentenceIndex++)
                {
                    int wordsLeft = amountOfWords - currentWordIndex;

                    if (wordsLeft == 0)
                        break;

                    int sentenceLength = random.Next(Math.Min(wordsLeft, MIN_WORDS_IN_SENTENCE), Math.Min(wordsLeft, MAX_WORDS_IN_SENTENCE));
                    wordsLeft -= sentenceLength;

                    if (wordsLeft < MAX_WORDS_IN_SENTENCE)
                        sentenceLength += wordsLeft;

                    builder.Append(GenerateSentence(sentenceLength, ref random));
                    currentWordIndex += sentenceLength;
                }

                if (currentWordIndex < amountOfWords)
                    builder.Append(GetParagraphString(paragraphType));
            }

            return builder.ToString();
        }

        private string GetParagraphString(ParagraphType paragraphType)
        {
            switch (paragraphType)
            {
                case ParagraphType.BLANK_ROW: return "\n\n";
                case ParagraphType.INDENT: return "\n     ";
                case ParagraphType.NO_PARAGRAPHS: return string.Empty;
                default:
                    throw new Exception($"There exists no implementation for this paragraph type: {paragraphType}");
            }
        }

        private string GenerateSentence(int sentenceLength, ref Random random)
        {
            StringBuilder builder = new StringBuilder();
            int wordsUntilComma = random.Next(MIN_WORDS_BETWEEN_COMMAS, MAX_WORDS_BETWEEN_COMMAS);

            string lastWord = string.Empty;

            string firstWord = GetWeightedWord(ref random);
            builder.Append(firstWord.First().ToString().ToUpper() + firstWord.Substring(1));

            for (int wordIndex = 1; wordIndex < sentenceLength; wordIndex++)
            {
                if (wordsUntilComma-- == 0 && sentenceLength - wordIndex - 1 > MIN_WORDS_BETWEEN_COMMAS)
                {
                    builder.Append(",");
                    wordsUntilComma = random.Next(MIN_WORDS_BETWEEN_COMMAS, MAX_WORDS_BETWEEN_COMMAS);
                }

                builder.Append(" ");

                //No duplicates in a row
                string newWord = GetWeightedWord(ref random);
                while (lastWord == newWord)
                    newWord = GetWeightedWord(ref random);

                lastWord = newWord;

                builder.Append(lastWord);
            }

            builder.Append(". ");

            return builder.ToString();
        }

        private string GetWeightedWord(ref Random random)
        {
            int thisRandom = random.Next(0, TOTAL_TEXT_ENTRIES_WEIGHT);

            foreach (RandomTextEntry entry in TEXT_ENTRIES)
            {
                if (thisRandom < entry.Weight)
                    return entry.Entry;
                thisRandom -= entry.Weight;
            }

            throw new Exception("This code should never be reached. Wrong calculations with weights!");
        }
    }
}
