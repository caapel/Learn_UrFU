namespace Learn_UrFU
{
    /*class SomeClass
    {
        public static int s = 1;
        public int d = 1;

        public void Run()
        {
            Console.Write(s + " " + d + " ");
            s++; d++;
        }

        public static void Main()
        {
            var object1 = new SomeClass();
            var object2 = new SomeClass();
            object1.Run();
            object2.Run();
            object1.Run();
        }
    }*/

    public static class StringExtensions
    { 
        public static int ToInt(this string value) 
        { 
            return Convert.ToInt32(value);
        }
    }

    class Program
    {
        public static void Main()
        {
            var arg1 = "100500";
            Console.Write(arg1.ToInt() + "42".ToInt()); // 100542
        }
    }
    
    
}
