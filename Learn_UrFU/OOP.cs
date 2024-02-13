using System.Globalization;

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

    /*public static class StringExtensions
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
    }*/

    /*class Box
    {
        public int Content;
    }

    public class Program
    {
        static void Main()
        {
            var value = new Box { Content = 5 };
            var result = new Box[3];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = value;
                value.Content++;
             }
            // ?
        }
    }*/

    /*class Program
    { 
        public static void Main(string[] args) 
        { 
            foreach (var fileName in Directory.GetFiles("."))
                Console.WriteLine(fileName);
        }
    
    }*/

    /*public static class Program
    {
        public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
        {
            var result = new List<DirectoryInfo>();
            var strings = new List<string>();

            foreach (var file in files)
            {
                if (file.Extension == ".mp3" || file.Extension == ".wav")
                {
                    if (!strings.Contains(file.DirectoryName))
                    {
                        strings.Add(file.DirectoryName);
                        result.Add(file.Directory);
                    }     
                }                    
            }
            return result;
        }
    }*/

    /*public static class Program
    {
        public static void Main()
        {
            var filter = new SuperBeautyImageFilter();
            filter.ImageName = "Paris.jpg";
            filter.GaussianParameter = 0.4;
            filter.Run();
        }
    }

    public class SuperBeautyImageFilter
    {
        public string ImageName;
        public double GaussianParameter;
        public void Run()
        {
            Console.WriteLine("Processing {0} with parameter {1}",
                ImageName,
                GaussianParameter.ToString(CultureInfo.InvariantCulture));
            //do something useful
        }
    }*/
}
