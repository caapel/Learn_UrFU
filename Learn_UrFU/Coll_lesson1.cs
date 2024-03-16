using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Learn_UrFU
{
    internal class Coll_lesson1
    {
        public static void Main()
        {
            string[] lines = new string[] {
                "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ", 
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                "если особенно упорно подойдешь к делу",
                "",
                "будет Трудно конечнО",
                "Код ведЬ не из простых",
                "очень ХОРОШИЙ код",
                "то у тебя все получится",
                "и я буДу Писать тЕбЕ еще",
                "",
                "чао"};

            Console.WriteLine(DecodeMessage(lines));
        }

        private static string DecodeMessage(string[] lines)
        {
            List<string> result = new List<string>();

            foreach (string line in lines) 
            {
                string[] words = line.Split(' ');

                foreach (string word in words)
                    if (!string.IsNullOrEmpty(word) && char.IsUpper(word[0]))
                        result.Insert(0, word);
            }
            return string.Join(' ', result);
        }
    }
}*/
