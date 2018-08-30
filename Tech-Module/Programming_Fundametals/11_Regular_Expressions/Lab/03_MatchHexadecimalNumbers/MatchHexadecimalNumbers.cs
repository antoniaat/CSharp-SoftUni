namespace _03_MatchHexadecimalNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            var numbersString = Console.ReadLine();

            var numbers = Regex.Matches(numbersString, @"(0x)?[A-F0-9]+\b")
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}