/*using System.Numerics;

namespace ReadOnlyVector
{
    public class ReadOnlyVector
    {
        public readonly double X, Y;

        public ReadOnlyVector(double X, double Y)
        { 
            this.X = X;
            this.Y = Y;
        }

        public ReadOnlyVector Add(ReadOnlyVector other)
        {
            return new ReadOnlyVector(this.X + other.X, this.Y + other.Y);
        }

        public ReadOnlyVector WithY(double Y)
        {
            return new ReadOnlyVector(this.X, Y);
        }

        public ReadOnlyVector WithX(double X)
        {
            return new ReadOnlyVector(X, this.Y);
        }
    }

    class Program
    {
        public static void Main()
        { 
            var TestVector = new ReadOnlyVector(1, 2).WithX(3);
        }  
    }
}*/