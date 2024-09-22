/*using System.Diagnostics;
using System.Runtime.InteropServices;
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
            var keysList = GetKeys(text);
            var nextWordList = GetNextWords(text);
            var modelDict = CreateDictionary(keysList, nextWordList);
            var result = LoadDictionary(keysList, modelDict);

            return result;
        }

        // получение списка ключей
        private static List<string> GetKeys(List<List<string>> text)
        {
            var keys = new List<string>();

            foreach (var Sentence in text) //проходимся по предложениям
            {
                for (int i = 0; i < Sentence.Count - 1; i++) // биграммы
                    keys.Add(Sentence[i]);

                for (int j = 0; j < Sentence.Count - 2; j++) // триграммы
                    keys.Add(Sentence[j] + " " + Sentence[j + 1]);
            }
            return keys;
        }

        // получение списка продолжений
        private static List<string> GetNextWords(List<List<string>> text)
        {
            var nextWordList = new List<string>();

            foreach (var Sentence in text) //проходимся по предложениям
            {
                for (int i = 1; i < Sentence.Count; i++) // биграммы
                    nextWordList.Add(Sentence[i]);

                for (int j = 2; j < Sentence.Count; j++) // триграммы
                    nextWordList.Add(Sentence[j]);
            }
            return nextWordList;
        }

        // группировка списков в словарь
        private static Dictionary<string, Dictionary<string, int>> 
            CreateDictionary(List<string> keysList, List<string> nextWordList)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < keysList.Count; i++)
            {
                if (!dict.ContainsKey(keysList[i]))
                    dict.Add(keysList[i], new Dictionary<string, int> { [nextWordList[i]] = 1 });
                else if (dict.ContainsKey(keysList[i]) && dict[keysList[i]].ContainsKey(nextWordList[i]))
                    dict[keysList[i]][nextWordList[i]]++;
                else if (dict.ContainsKey(keysList[i]))
                    dict[keysList[i]].Add(nextWordList[i], 1);
            }
            return dict;
        }

        // получение наименьшего лексиграфического слова
        static Dictionary<string, string> LoadDictionary(List<string> keysList, 
            Dictionary<string, Dictionary<string, int>> dict)
        {
            var result = new Dictionary<string, string>();

            foreach (var key in keysList)
            {
                int max = 0;

                foreach (var pair in dict[key].Keys)
                {
                    if (dict[key][pair] > max)
                    {
                        max = dict[key][pair];
                        result[key] = pair;
                    }

                    else if (dict[key][pair] == max)
                        if (string.CompareOrdinal(result[key], pair) > 0) { result[key] = pair; }
                }
            }
            return result; ;
        }

        public static string ContinuePhrase(Dictionary<string, string> nextWords, string phraseBeginning, int wordsCount)
        {
            var phraseList = SentencesParserTask.ParseSentences(phraseBeginning)[0];

            for (int i = 0; i < wordsCount; i++)
            {
                var count = phraseList.Count;
                var biGramm = phraseList[count - 1];
                var treeGramm = new string(" ");

                if (phraseList.Count > 1)
                    treeGramm = phraseList[count - 2] + ' ' + phraseList[count - 1];

                if (phraseList.Count > 1 && nextWords.ContainsKey(treeGramm))
                    phraseList.Add(nextWords[treeGramm]);
                else if (nextWords.ContainsKey(biGramm))
                    phraseList.Add(nextWords[biGramm]);
                else break;
            }           
            return string.Join(' ', phraseList);
        }

        public static void Main()
        {
            //var watch = new Stopwatch();
            //watch.Start();

            string text = File.ReadAllText("HarryPotterText.txt");
            var nextWords = GetMostFrequentNextWords(ParseSentences(text));

            Console.WriteLine("Введите начало фразы");
            var phraseBeginning = Console.ReadLine();
            Console.WriteLine(ContinuePhrase(nextWords, phraseBeginning, 10));

            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}*/