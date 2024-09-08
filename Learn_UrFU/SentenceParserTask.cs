using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Learn_UrFU
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();

            // разбиваем исходный текст на предложения
            var sentences = text.Split(new char[] { '.', '!', '?', ';', ':', '(', ')'} ).ToList();

            foreach (var sentence in sentences)
            {
                //разделяем предложения на слова, попутно переводя их в нижний регистр
                var words = sentence.ToLower().
                    Split(GetSymbols(sentence), StringSplitOptions.RemoveEmptyEntries).ToList();

                //переносим список слов предложения в список предложений
                if (words.Any())
                    sentencesList.Add(words);
            }

            return sentencesList;
        }

        //даёт массив всех символов в предложении, отличных от букв и знака "'"
        private static char[] GetSymbols(string sentence)
        {
            var chars = new List<char>();
            
            foreach (char c in sentence)
                if (!(char.IsLetter(c) || c == '\'')) chars.Add(c);

            return chars.ToArray();
        }

        public static void Main()
        {
            string text = "   For Jessica, who loves stories,\r\n   For Anne, who loved them too;\r\n   And for Di, who heard this one first.";
            ParseSentences("..");
        }
    }
}
