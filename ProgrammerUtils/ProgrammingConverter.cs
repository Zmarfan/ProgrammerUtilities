using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerUtils
{
    public class ProgrammingConverter
    {
        public enum ProgrammingLanguages
        {
            Java,
            CSharp,
            Typescript,
        }

        private static readonly string TAB = "       ";

        private static ProgrammingLanguages GetLanguageFromString(string language)
        {
            if (language == "C#")
                return ProgrammingLanguages.CSharp;

            return (ProgrammingLanguages)Enum.Parse(typeof(ProgrammingLanguages), language);
        }

        public static string GenerateEnumForLanguage(string enteredString, string languageString, Sort.SortStyles sortStyle, Sort.TextStyles textStyle)
        {
            Sort sorter = new Sort(true, Sort.SortDisplayModes.NEW_LINE, sortStyle, textStyle, Sort.TextPresentations.UNDERSCORE);
            string[] entries = sorter.SortString(enteredString).Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            ProgrammingLanguages language = GetLanguageFromString(languageString);

            switch (language)
            {
                case ProgrammingLanguages.Java: return GenerateJavaEnum(entries);
                case ProgrammingLanguages.CSharp: return GenerateCSharpEnum(entries); 
                case ProgrammingLanguages.Typescript: return GenerateTypescriptEnum(entries); 
            }
            return "";
        }

        private static string GenerateJavaEnum(string[] entries)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("public enum MyNewEnum {\n");
            for (int i = 0; i < entries.Length; i++)
            {
                builder.Append(TAB);
                builder.Append(entries[i]);
                builder.Append($"({i + 1})");
                if (i != entries.Length - 1)
                    builder.Append(",\n");
                else
                    builder.Append(";\n\n");
            }
            builder.Append($"{TAB}private final long mId;\n\n");
            builder.Append($"{TAB}private MyNewEnum(long id) {"{"}\n{TAB}{TAB}mId = id;\n{TAB}{"}"}\n\n");

            builder.Append($"{TAB}public long getId() {"{"}\n{TAB}{TAB}return mId;\n{TAB}{"}"}\n");

            builder.Append("}");
            return builder.ToString();
        }

        private static string GenerateCSharpEnum(string[] entries)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("public enum MyNewEnum\n{\n");
            entries.ToList().ForEach(entry =>
            {
                builder.Append(TAB);
                builder.Append(entry);
                builder.Append(",\n");
            });
            builder.Append("}");
            return builder.ToString();
        }

        private static string GenerateTypescriptEnum(string[] entries)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("export enum MyNewEnum {\n");
            for (int i = 0; i < entries.Length; i++)
            {
                builder.Append(TAB);
                builder.Append(entries[i]);
                builder.Append($" = {i + 1},\n");
            }
            builder.Append("}");
            return builder.ToString();
        }
    }
}
