/*namespace Learn_UrFU
{
    class Book : IComparable
    {
        public string Title;
        public int Theme;

        public int CompareTo(object obj)
        {
            var book = (Book)obj;

            if (Theme.CompareTo(book.Theme) == 0)
                return Title.CompareTo(book.Title);
            return Theme.CompareTo(book.Theme);
        }
    }

    class Interface
    {
        public static void Main()
        {
            Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(Min(new[] { '4', '2', '7' }));
        }

        public static object Min(Array args)
        {
            if (args.Length == 0) return null;

            var Min = args.GetValue(0);
            foreach (var arg in args)
            {
                var Arg = (IComparable)arg;
                if (Arg.CompareTo(Min) < 0) Min = Arg;
            }
            return Min;      
        }


        public static void Main()
        {
            Console.WriteLine(MiddleOfThree(2, 5, 4));
            Console.WriteLine(MiddleOfThree(3, 1, 2));
            Console.WriteLine(MiddleOfThree(3, 5, 9));
            Console.WriteLine(MiddleOfThree("B", "Z", "A"));
            Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));
        }

        static object MiddleOfThree(object a, object b, object c)
        {
            var A = (IComparable)a; var B = (IComparable)b; var C = (IComparable)c;

            if (A.CompareTo(B) + A.CompareTo(C) == 0 || A.CompareTo(C) + A.CompareTo(B) == 0)
                return A;
            else if (B.CompareTo(A) + B.CompareTo(C) == 0 || B.CompareTo(C) + B.CompareTo(A) == 0)
                return B;
            else return C;
        }
    }
}
*/