/*using System;

namespace Learn_UrFU
{
    class Program
    {
        public static void Main()
        {
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
        }

        private static void WriteBoard(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    if (j % 2 == i % 2)
                        Console.Write("#");
                    else
                        Console.Write(".");
                Console.Write("\n");
            }
            Console.WriteLine();
        }


        public static void Main()
        {
            WriteTextWithBorder("Hello world");
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }

        private static void WriteTextWithBorder(string text)
        {
            text = "| " + text + " |";
            
            int length = text.Length;

            for (int i = 0; i < 3; i++)
            {
                if (i != 1)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (j == 0 || j == length - 1)
                            Console.Write("+");
                        else
                            Console.Write("-");
                    }
                    Console.Write("\n");
                }
                else
                    Console.WriteLine(text);
            }               
        }


        public static void Main()
        {
            Console.WriteLine(RemoveStartSpaces("a"));
            Console.WriteLine(RemoveStartSpaces(" b"));
            Console.WriteLine(RemoveStartSpaces(" cd"));
            Console.WriteLine(RemoveStartSpaces(" efg"));
            Console.WriteLine(RemoveStartSpaces(" text"));
            Console.WriteLine(RemoveStartSpaces(" two words"));
            Console.WriteLine(RemoveStartSpaces("  two spaces"));
            Console.WriteLine(RemoveStartSpaces("	tabs"));
            Console.WriteLine(RemoveStartSpaces("		two	tabs"));
            Console.WriteLine(RemoveStartSpaces("                             many spaces"));
            Console.WriteLine(RemoveStartSpaces(" "));
            Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
        }

        public static string RemoveStartSpaces(string text)
        {
            while (true)
            {
                if (text == "" || !char.IsWhiteSpace(text[0])) break;
                text = text.Substring(1);
            }
            return text;
        }


        public static void Main()
        {
            Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
            Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(4));
        }

        private static int GetMinPowerOfTwoLargerThan(int number)
        {
            int result = 1;
            while (result <= number)
                result *= 2;
            return result;
        }
    }
}*/
