using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var outputDictionary =
                new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                var ipAdress = input[1];
                var user = input[5];

                if (!outputDictionary.ContainsKey(user))
                {
                    outputDictionary.Add(user, new Dictionary<string, int>());
                }
                if (!outputDictionary[user].ContainsKey(ipAdress))
                {
                    outputDictionary[user].Add(ipAdress, 0);
                }

                outputDictionary[user][ipAdress]++;

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            foreach (var index in outputDictionary.OrderBy(x => x.Key))
            {
                var counter = 0;
                Console.WriteLine($"{index.Key}:");

                foreach (var item in index.Value)
                {
                    counter++;
                    if (counter == index.Value.Count)
                    {
                        Console.Write($"{item.Key} => {item.Value}.");
                    }

                    else
                    {
                        Console.Write($"{item.Key} => {item.Value}, ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
