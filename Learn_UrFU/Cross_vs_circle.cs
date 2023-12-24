/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Learn_UrFU
{
    internal class Cross_vs_circle
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }

        public static void Main()
        {
            Run("XXX OO. ...");
            Run("OXO XO. .XO");
            Run("OXO XOX OX.");
            Run("XOX OXO OXO");
            Run("... ... ...");
            Run("XXX OOO ...");
            Run("XOO XOO XX.");
            Run(".O. XO. XOX");
        }

        private static void Run(string description)
        {
            Console.WriteLine(description.Replace(" ", Environment.NewLine));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        private static Mark[,] CreateFromString(string str)
        {
            var field = str.Split(' ');
            var ans = new Mark[3, 3];
            for (int x = 0; x < field.Length; x++)
                for (var y = 0; y < field.Length; y++)
                    ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
            return ans;
        }

        public static GameResult GetGameResult(Mark[,] field)
        {
            if (GetMark(field) == Mark.Circle) { return GameResult.CircleWin; }
            else if (GetMark(field) == Mark.Cross) { return GameResult.CrossWin; }
            else { return GameResult.Draw; }
        }

        private static Mark GetMark(Mark[,] field)
        {
            if (IsEqual(field[0, 0], field[1, 1], field[2, 2]) ||
                IsEqual(field[0, 2], field[1, 1], field[2, 0]))
                return field[1, 1]; //проверка по диагоналям

            if (IsDoubleWin(field))
                return Mark.Empty;

            for (int i = 0; i < 3; i++)
            {
                if (IsEqual(field[i, 0], field[i, 1], field[i, 2]) && field[i, 0] != Mark.Empty)
                    return field[i, 0]; //проверка по горизонтали
                if (IsEqual(field[0, i], field[1, i], field[2, i]) && field[0, i] != Mark.Empty)
                    return field[0, i]; //проверка по вертикали
            }

            return Mark.Empty;
        }
        
        private static bool IsEqual(Mark a, Mark b, Mark c)
        {
            return a == b && b == c;
        }

        private static bool IsDoubleWin(Mark[,] field)
        { 
            bool flag = false;
            for (int i = 0; i < 3; i++)
            {
                if (IsEqual(field[i, 0], field[i, 1], field[i, 2]) && flag && field[i, 0] != Mark.Empty)
                    return true;
                if (IsEqual(field[i, 0], field[i, 1], field[i, 2]))
                    flag = true;

                if (IsEqual(field[0, i], field[1, i], field[2, i]) && flag && field[0, i] != Mark.Empty)
                    return true;
                if (IsEqual(field[0, i], field[1, i], field[2, i]))
                    flag = true;
            }
            return false;
        }
    }
}*/
