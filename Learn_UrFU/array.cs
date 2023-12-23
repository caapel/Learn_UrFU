using System;

/*namespace Learn_UrFU
{
    class Array
    {
        public static void Main()
        {
            string[] XLabels = new string[31];
            for (int i = 1; i < 32; i++)
                XLabels[i - 1] = i.ToString();
        }


        public static void Main()
        {
            var testArray1 = GetPoweredArray(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2);
            var testArray2 = GetPoweredArray(new int[0], 1);
            var testArray3 = GetPoweredArray(new[] { 42 }, 0);
        }

        public static int[] GetPoweredArray(int[] arr, int power)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = (int)Math.Pow(arr[i], power);
            }
            return result;
        }


        public static void Main()
        {
            Console.WriteLine(CheckFirstElement(null));
            Console.WriteLine(CheckFirstElement(new int[0]));
            Console.WriteLine(CheckFirstElement(new[] { 1 }));
            Console.WriteLine(CheckFirstElement(new[] { 0 }));
        }

        public static bool CheckFirstElement(int[] array)
        {
            return array != null && array.Length != 0 && array[0] == 0;
        }

        enum Suits
        {
            Wands,
            Coins,
            Cups,
            Swords
        }

        public static void Main()
        {
            Console.WriteLine(GetSuit(Suits.Wands));
            Console.WriteLine(GetSuit(Suits.Coins));
            Console.WriteLine(GetSuit(Suits.Cups));
            Console.WriteLine(GetSuit(Suits.Swords));
        }

        private static string GetSuit(Suits suit)
        {
            return new [] { "жезлов", "монет", "кубков", "мечей" } [(int)suit];
        }

        // поиск массива в массиве
        public static int FindSubarrayStartIndex(int[] array, int[] subArray)
        {
            for (var i = 0; i < array.Length - subArray.Length + 1; i++)
                if (ContainsAtIndex(array, subArray, i))
                    return i;
            return -1;
        }

        private static bool ContainsAtIndex(int[] array, int[] subArray, int j)
        {
            for (int i = 0; i < subArray.Length; i++)
                if (array[i + j] != subArray[i]) 
                    return false;
            return true;
        }

        public static int GetElementCount(int[] items, int itemToCount)
        {
            int count = 0;
            
            foreach (int item in items) 
            { 
                if (item == itemToCount)
                    count++;
            }
            return count;
        }

        public static int MaxIndex(double[] array)
        {
            int index = 0;

            var max = double.MinValue;
            foreach (var item in array) 
                if (item > max) max = item;

            foreach (var item in array)
            {
                if (item == max)
                    return index;
                index++;
            }
            return -1;
        }

        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] result = new int[count];
            var j = 0;

            for (int i = 0; i < count; i++)
            {
                j += 2;
                result[i] = j;
            }

            return result;
        }
    }
}*/