/*using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Learn_UrFU
{
    internal class workFiles
    {
        static void Main()
        {
            Console.WriteLine(Encoding.UTF8.GetBytes("БЩФzw!").Length);
            //File.ReadAllLines(@"C:\doc.txt");

            string a = "dssd dasdas sads";
            var parts = a.Split(" ");

            char digit = '8';
            var order = (int)(digit - '0');
            Console.WriteLine(order);

            File.WriteAllText("text.txt", "Привет, мир!", System.Text.Encoding.UTF8);
            var bytes = File.ReadAllBytes("text.txt");

            Console.WriteLine(bytes.Length);
            foreach(var e in bytes)
                Console.Write((char)e);

            File.WriteAllText("text.txt", "Hello, world");
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(Path.Combine(Environment.CurrentDirectory, "text.txt"));
            File.WriteAllLines("text.txt", new string[]
            { 
                "Line1",
                "Line2"
            });
            Console.WriteLine(File.ReadAllLines("text.txt"));

            foreach (var fileName in Directory.GetFiles(".","Learn*"))
            { 
                Console.WriteLine(fileName);
            }
        }
    }
}*/
