using LibExample;

namespace Learn_UrFU
{
    internal class testLearning
    {
        public static void Main(String[] args)
        { 
            double a = 1, b = -3, c = 2;

            var result = QuadraticEquation.Solve(a, b, c);
            Console.WriteLine(string.Format("{0}, {1}", result[0], result[1]));
        }
    }
}
