/*using System.Collections;
using System.Drawing;

namespace Learn_UrFU
{
    class Program
    {
        public class Point
        {
            public double X;
            public double Y;

            public override string ToString()
            {
                return string.Format("{0} {1}", X, Y);
            }
        }

        public class ClockwiseComparer : IComparer
        {
            private double GetAngle(double x, double y)
            { 
                return -Math.Atan2(y, -x);
            }
            
            public int Compare(object x, object y)
            {
                var point1 = (Point)x;
                var point2 = (Point)y;

                return GetAngle(point1.X, point1.Y).CompareTo(GetAngle(point2.X, point2.Y));
            }
        }

        public static void Main()
        {
            var array = new[]
            {
                new Point { X = 1, Y = 0 },
                new Point { X = -1, Y = 0 },
                new Point { X = 0, Y = 1 },
                new Point { X = 0, Y = -1 },
                new Point { X = 0.01, Y = 1 }
            };
            
            Array.Sort(array, new ClockwiseComparer());

            foreach (Point e in array)
                Console.WriteLine(e);
        }
    }
}*/
