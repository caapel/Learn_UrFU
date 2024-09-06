/*namespace Learn_UrFU
{
    internal class Dict_lesson1
    {
        static void Main()
        {
            var contacts = new List<string>
            {
                "Sasha:sasha1995@sasha.ru",
                "Sasha:alex99@mail.ru",
                "Sasha:shurik2020@google.com",
                "Robert:roker1995@sasha.ru",
                "Petr:kring99@mail.ru",
                "Robert:qwe2020@google.com"
            };

            var dictionary = OptimizeContacts(contacts);


            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }
        }

        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();
            
            foreach (var contact in contacts) 
            {
                string[] pair = contact.Split(':');
                string key;

                if (contact.IndexOf(":") <= 3)
                    key = pair[0];
                else
                    key = pair[0].Substring(0, 2);

                if (!dictionary.ContainsKey(key))
                    dictionary[key] = new List<string>();
                dictionary[key].Add(contact);
            }
            
            return dictionary;
        }
    }
}*/
