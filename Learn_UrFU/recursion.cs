namespace Learn_UrFU
{
    class Recursion
    {
        public static void Main()
        {
            WriteReversed(new char[] { '1', '2', '3', '4', '5'});
        }
        
        public static void WriteReversed(char[] items, int startIndex = 0)
        {
            if (startIndex < items.Length)
            {
                WriteReversed(items, startIndex + 1);
                Console.Write(items[startIndex]);
            }
        }
    }
}
