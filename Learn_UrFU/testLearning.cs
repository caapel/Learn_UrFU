/*namespace Learn_UrFU
{
    class Program
    {
        static void AlternateCharCases(char[] word, int startIndex, List<string> result)
        {
            if (startIndex == word.Length)
            {
                result.Add(new string(word));
                return;
            }

            if (Char.IsLetter(word[startIndex]) && word[startIndex] != 223 && (word[startIndex] < 1425 || word[startIndex] > 1524))
            {
                word[startIndex] = Char.ToLower(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
                word[startIndex] = Char.ToUpper(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
            }
            else AlternateCharCases(word, startIndex + 1, result);
        }

        static void Main()
        {
             var result = new List<string>();
             AlternateCharCases("ⅲ ⅳ ⅷ".ToCharArray(), 0, result);
             foreach (string word in result)
                 Console.WriteLine(word);
        }
    }
}*/