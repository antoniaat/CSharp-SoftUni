namespace _06_ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class ValidUsernames
    {
        public static void Main()
        {
            var users = new List<string>();
            string[] input = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"^[A-Za-z][A-Za-z0-9_]{2,24}$";
            Regex regex = new Regex(pattern);

            foreach (var user in input)
            {
                if (regex.IsMatch(user))
                {
                    users.Add(user);
                }
            }

            int sumlength = 0;
            int maxSumLength = 0;
            int firstUserIndex = 0;

            for (int i = 0; i < users.Count - 1; i++)
            {
                sumlength = users[i].Length + users[i + 1].Length;
                if (sumlength > maxSumLength)
                {
                    maxSumLength = sumlength;
                    firstUserIndex = i;
                }
            }

            Console.WriteLine(users[firstUserIndex]);
            Console.WriteLine(users[firstUserIndex + 1]);
        }
    }
}
