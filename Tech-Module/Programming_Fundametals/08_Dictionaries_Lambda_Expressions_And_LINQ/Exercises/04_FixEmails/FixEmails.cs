namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var dictionary = new Dictionary<string, string>();

            while (name != "stop")
            {
                var email = Console.ReadLine();

                dictionary[name] = email;

                var res = email.Substring(email.Length - 2, 2);

                if (res == "us" || res == "uk")
                {
                    dictionary.Remove(name);
                }

                name = Console.ReadLine();
            }

            foreach (var input in dictionary.Keys)
            {
                Console.WriteLine($"{input} -> {dictionary[input]}");
            }
        }
    }
}
