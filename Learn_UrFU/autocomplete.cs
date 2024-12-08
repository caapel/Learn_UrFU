using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_UrFU
{
    class autocomplete
    {
        static void Main()
        {
            var phrases = new List<string>() { "a", "ab", "c", "ce", "cab", "df" };
            var prefix = "";

            var result = GetCountByPrefix(phrases, prefix);

        }

        public static int GetCountByPrefix(IReadOnlyList<string> phrases, string prefix)
        {
            return RightBorderTask.GetRightBorderIndex(phrases, prefix, -1, phrases.Count) -
                   LeftBorderTask.GetLeftBorderIndex(phrases, prefix, -1, phrases.Count) - 1;
        }
    }

    public class RightBorderTask
    {
        public static int GetRightBorderIndex(IReadOnlyList<string> phrases, string prefix, int left, int right)
        {
            while (right != left + 1)
            {
                var median = left + (right - left) / 2;

                if (string.Compare(prefix, phrases[median], StringComparison.InvariantCultureIgnoreCase) >= 0)
                    left = median;
                else right = median;
            }

            while (right != phrases.Count && phrases[right].StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase))
                right++;

            return right;
        }
    }

    public class LeftBorderTask
    {
        public static int GetLeftBorderIndex(IReadOnlyList<string> phrases, string prefix, int left, int right)
        {
            if (left == right - 1) return left;
            var median = left + (right - left) / 2;

            if (string.Compare(prefix, phrases[median], StringComparison.InvariantCultureIgnoreCase) > 0)
                return GetLeftBorderIndex(phrases, prefix, median, right);
            return GetLeftBorderIndex(phrases, prefix, left, median);
        }
    }
}
