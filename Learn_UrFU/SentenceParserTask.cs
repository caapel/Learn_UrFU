using System.Diagnostics;
using System.Text;

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

        // даёт массив всех символов в предложении, отличных от букв и знака "'"
        private static char[] GetSymbols(string sentence)
        {
            var chars = new List<char>();
            
            foreach (char c in sentence)
                if (!(char.IsLetter(c) || c == '\'')) chars.Add(c);

            return chars.ToArray();
        }

        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            var result = new Dictionary<string, string> ();
            var model = GetKeys(text); // получаем ключи для словаря

            foreach (var nGramm in model)
            {
                // ускоряем обработку для единичных продолжений
                if (nGramm.Value.Count == 1)
                {
                    foreach (var dict in nGramm.Value)
                        result[nGramm.Key] = dict.Key;
                    continue;
                }

                // определяем самое частотное продолжение
                //int max = nGramm.Value.Min(pair => pair.Value.);
                int max = 0;
                foreach (var dict in nGramm.Value)
                    if (dict.Value > max) max = dict.Value;

                // формируем список самых частотных продолжений
                var mostFrequentNextWords = new List<string>();
                foreach (var dict in nGramm.Value)
                    if (dict.Value == max) mostFrequentNextWords.Add(dict.Key);

                // добавляем в итоговый словарь самое частотное продолжение
                if (mostFrequentNextWords.Count == 1)
                    result[nGramm.Key] = mostFrequentNextWords[0];
                else
                    result[nGramm.Key] = GetMinLexigraphicWord(mostFrequentNextWords);
            }
            return result;
        }

        private static Dictionary<string, Dictionary<string, int>> GetKeys(List<List<string>> text)
        {
            var result = new Dictionary<string, Dictionary<string, int>>();

            foreach (var Sentence in text) //проходимся по предложениям
            {
                for (int i = 0; i < Sentence.Count - 1; i++) // проходимся по словам
                {
                    var keys = new List<string>();

                    // проходимся по всем вариантам N-грамм
                    for (int j = 0; j < (Sentence.Count - 1 - i >= 2? 2: 1); j++)
                    {
                        keys.Add(Sentence[i + j]);

                        string key = string.Join(' ', keys);
                        if (!result.ContainsKey(key))
                            result[key] = GetNextWords(text, keys.ToArray());
                    }
                }
            }
            return result;
        }

        // получение словаря продолжений для выбранного ключа в формате <продолжение>:<частота>
        private static Dictionary<string, int> GetNextWords(List<List<string>> text, string[] keys)
        {
            var result = new Dictionary<string, int>();

            foreach (var sentence in text)
            {
                if (keys.Length == 1)
                {
                    for (int i = 0; i < sentence.Count - 1; i++)
                        if (sentence[i] == keys[0])
                            result[sentence[i + 1]] = GetFrequency(text, keys, sentence[i + 1]);
                }
                else
                {
                    for (int i = 0; i < sentence.Count - 2; i++)
                        if (sentence[i] == keys[0] && sentence[i + 1] == keys[1])
                            result[sentence[i + 2]] = GetFrequency(text, keys, sentence[i + 2]);
                }
            }
            return result;
        }

        // получение частоты для выбранного продолжения по ключу
        private static int GetFrequency(List<List<string>> text, string[] keys, string nextWord)
        {
            int count = 0;

            foreach (var sentence in text)
            {
                if (keys.Length == 1)
                {
                    for (int i = 0; i < sentence.Count - 1; i++)
                        if (sentence[i] == keys[0] && sentence[i + 1] == nextWord)
                            count++;
                }
                else
                {
                    for (int i = 0; i < sentence.Count - 2; i++)
                        if (sentence[i] == keys[0] && sentence[i + 1] == keys[1] && sentence[i + 2] == nextWord)
                            count++;
                }                    
            }
            return count;
        }

        // получение наименьшего лексиграфического слова
        private static string GetMinLexigraphicWord(List<string> mostFrequentNextWords)
        {
            string MinLexigraphicWord = mostFrequentNextWords[0];

            for (int i = 0; i < mostFrequentNextWords.Count - 1; i++)
            {
                if (string.CompareOrdinal(MinLexigraphicWord, mostFrequentNextWords[i + 1]) > 0)
                    MinLexigraphicWord = mostFrequentNextWords[i + 1];
            }
            return MinLexigraphicWord;
        }

        public static void Main()
        {
            /*string text = "   For Jessica, who loves stories,\r\n   For Anne, who loved them too;\r\n   And for Di, who heard this one first.";
            ParseSentences("a b c d. b c d. e b c a d.");*/

            var watch = new Stopwatch();
            watch.Start();

            string text = File.ReadAllText("HarryPotterText.txt");

            GetMostFrequentNextWords(ParseSentences(text));

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            //GetMostFrequentNextWords(ParseSentences("a b c d. b c d. e b c a d."));
        }
    }
}