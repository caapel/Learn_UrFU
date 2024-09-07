/*using System.Diagnostics;
using System.Text;

namespace Learn_UrFU
{
    internal class Program
    {
        static void Main()
        {
            var watch = new Stopwatch();
            var builder = new StringBuilder();

            watch.Start();
            for (int i = 0; i < 100000; i++)
            {
                builder.Append(i.ToString());
                builder.Append(", ");
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            watch.Restart();
            watch.Start();
            var result = "";
            for (int i = 0; i < 100000; i++)
                result += i.ToString() + ", ";
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}*/

/*using System.Text;

namespace Learn_UrFU
{
    internal class Program
    {
        private static string ApplyCommands(string[] commands)
        {
            var StringBuild = new StringBuilder();
            foreach (var command in commands)
            {
                if (command.Split(' ')[0] == "push")
                    StringBuild.Append(command.Replace("push ", ""));
                if (command.Split(' ')[0] == "pop")
                {
                    var pop = int.Parse(command.Split(' ')[1]);
                    StringBuild.Remove(StringBuild.Length - pop, pop);
                }
            }
            return StringBuild.ToString();
        }

        static void Main()
        {
            string[] args = new string[] {
                "push Привет! Это снова я! Пока!",
                "pop 5",
                "push Как твои успехи? Плохо?",
                "push qwertyuiop",
                "push 1234567890",
                "pop 26"
            };

            Console.WriteLine(ApplyCommands(args));
        }
    }
}*/