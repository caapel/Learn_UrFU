/*namespace Learn_UrFU
{
    class Transport{}
    class Program
    {
        public static void Main()
        {
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };

            Print(Combine(ints, ints));
            Print(Combine(ints, ints, ints));
            Print(Combine(ints));
            Print(Combine());
            Print(Combine(strings, strings));
            Print(Combine(ints, strings));
        }

        static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
        }

        static Array Combine(params Array[] arrays)
        {
            if (arrays.Length == 0)
                return null;

            var elementType = arrays[0].GetType().GetElementType();
            
            foreach (var array in arrays)
                if (!array.GetType().GetElementType().Equals(elementType))
                    return null;

            int summaryLength = 0, i = 0;
            foreach (var array in arrays)
                summaryLength += array.Length;

            var result = Array.CreateInstance(elementType, summaryLength);

            foreach (var array in arrays)
                foreach (var element in array)
                    result.SetValue(element, i++);

            return result;
        }
    }
}*/