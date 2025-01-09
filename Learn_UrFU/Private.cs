using System.Globalization;

/*namespace Learn_UrFU
{
    public class Ratio
    {
        public readonly int Numerator; //числитель
        public readonly int Denominator; //знаменатель
        public readonly double Value; //значение дроби Numerator / Denominator

        public Ratio(int num, int den)
        {
            if (den == 0) { throw new ArgumentException(); }
            else if (den < 0) num *= -1;
            Denominator = den;
            Numerator = num;
            Value = (double)num / (double)den;
        }
    }

    public class Program
    {
        public static void Check(int num, int den)
        {
            var ratio = new Ratio(num, den);
            Console.WriteLine("{0}/{1} = {2}",
                ratio.Numerator, ratio.Denominator,
                ratio.Value.ToString(CultureInfo.InvariantCulture));
        }

        public static void Main()
        {
            Check(1, 2);
        }
    }
}*/