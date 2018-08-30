namespace _02.Hornet_Comm
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Collections.Generic;

    public class Hornet_Comm
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new String[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var privateMessageList = new List<KeyValuePair<string, string>>();

            var broadcast = new List<KeyValuePair<string, string>>();

            while (input[0] != "Hornet is Green")
            {
                var firstQuery = input[0];
                var secondQuery = input[1];

                var lettersAndDigits = Regex.IsMatch(secondQuery, @"^[a-zA-Z0-9]+$");

                if (firstQuery.Any(c => char.IsDigit(c)) == false && lettersAndDigits)
                {
                    secondQuery = SwithchCase(secondQuery);
                    broadcast.Add(new KeyValuePair<string, string>(firstQuery, secondQuery));
                }

                if (IsDigitsOnly(firstQuery) && lettersAndDigits)
                {
                    firstQuery = Reverse(firstQuery);
                    privateMessageList.Add(new KeyValuePair<string, string>(firstQuery, secondQuery));
                }

                input = Console.ReadLine()
                    .Split(new String[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            PrintResult(broadcast, privateMessageList);
        }

        public static bool IsDigitsOnly(string str)
        {
            foreach (char ch in str)
            {
                if (ch < '0' || ch > '9')
                    return false;
            }

            return true;
        }

        public static string Reverse(string reversedString)
        {
            char[] charArray = reversedString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string SwithchCase(string input)
        {
            var result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (Char.IsLetter(c))
                {
                    if (Char.IsUpper(c))
                    {
                        result += Char.ToLower(c);
                    }
                    else if (Char.IsLower(c))
                    {
                        result += Char.ToUpper(c);
                    }
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        public static void PrintResult(List<KeyValuePair<string, string>> broadcast,
            List<KeyValuePair<string, string>> privateMessageList)
        {
            Console.WriteLine("Broadcasts:");

            foreach (var keyValuePair in broadcast)
            {
                Console.WriteLine($"{keyValuePair.Value} -> {keyValuePair.Key}");
            }
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            foreach (var keyValuePair in privateMessageList)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
            if (privateMessageList.Count == 0)
            {
                Console.WriteLine("None");
            }
        }
    }
}
