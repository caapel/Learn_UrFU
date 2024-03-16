/*namespace Learn_UrFU
{
    internal class Dict
    {
        static void Main()
        {
            var array = new[] { "A", "B", "AB", "B", "B" };
            var dictionary = new Dictionary<string, int>();

            foreach (var str in array)
            {
                if (!dictionary.ContainsKey(str))
                    dictionary[str] = 1;
                else
                    dictionary[str]++;
            }

            foreach (var pair in dictionary)
            { 
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }
        }
    }
}*/
