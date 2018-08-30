namespace _04.SplitbyWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitbyWordCasing
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ', ',' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowercaseWordsList = new List<string>();
            var mixedCaseWordsList = new List<string>();
            var uppercaseWordsList = new List<string>();

            foreach (var word in input)
            {
                if (word.All(char.IsUpper))
                {
                    uppercaseWordsList.Add(word);
                }

                else if (word.All(char.IsLower))
                {
                    lowercaseWordsList.Add(word);
                }

                else
                {
                    mixedCaseWordsList.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowercaseWordsList));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWordsList));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercaseWordsList));
        }
    }
}
