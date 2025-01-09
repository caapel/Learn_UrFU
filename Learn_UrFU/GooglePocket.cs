using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_UrFU
{
    class GooglePocket
    {
        public static void Main()
        {
            List<int> result = new List<int>();
            string word = "f";
            
            string str = "F, f ff";
            int index = 0;

            for (int i = 0; i < 3; i++)
            {
                index = str.IndexOf(word, index);
                result.Add(index);
                index += word.Length;
            }
            var test = result;
        }
    }
}
