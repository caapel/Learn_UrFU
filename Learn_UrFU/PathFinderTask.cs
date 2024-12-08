/*using System.Drawing;
using System.IO;

namespace Learn_UrFU
{
    class Program
    {
        static void Main()
        {
            var points = new Point[] { new(1, 1), new(0, 0), new(1, 0), new(0, 1) };
            //var points = new Point[] { new(1, 0), new(1, 1), new(0, 0) };

            var Strings = new List<string>();
            foreach (var i in PathFinderTask.FindBestCheckpointsOrder(points))
                Strings.Add(i.ToString());
            Console.WriteLine(string.Join(" ", Strings.ToArray())); //выводим лучший результат
        }
    }

    public static class PathFinderTask //самый быстрый способ перестановки (< 1 c)
    {
        public static int[] FindBestCheckpointsOrder(Point[] checkpoints)
        {
            double length = 0;
            var result = new int[checkpoints.Length];
            MakePermutations(new int[checkpoints.Length], 1, ref length, checkpoints, ref result);

            return result;
        }

        public static void MakePermutations(int[] permutation,
                                            int position,
                                            ref double minLength,
                                            Point[] checkpoints,
                                            ref int[] result)
        {
            // отсечение неоптимального пути
            if (minLength != 0 && PointExtensions.GetPathLength(checkpoints, permutation[..position]) >= minLength) return;

            if (position == permutation.Length && (PointExtensions.GetPathLength(checkpoints, permutation) < minLength || minLength == 0))
            {
                minLength = PointExtensions.GetPathLength(checkpoints, permutation);
                result = permutation.ToArray();
            }
            else
                for (int i = 0; i < permutation.Length; i++)
                    if (Array.IndexOf(permutation, i, 0, position) == -1)
                    {
                        permutation[position] = i;
                        MakePermutations(permutation, position + 1, ref minLength, checkpoints, ref result);
                    }
        }
    }

    public static class PointExtensions
    {
        public static double GetPathLength(this Point[] checkpoints, int[] order)
        {
            var prevPoint = checkpoints[order[0]];
            var len = 0.0;
            foreach (var checkpointIndex in order.Skip(1))
            {
                len += prevPoint.DistanceTo(checkpoints[checkpointIndex]);
                prevPoint = checkpoints[checkpointIndex];
            }
            return len;
        }


        public static double DistanceTo(this Point a, Point b)
        {
            var dx = a.X - b.X;
            var dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}*/
