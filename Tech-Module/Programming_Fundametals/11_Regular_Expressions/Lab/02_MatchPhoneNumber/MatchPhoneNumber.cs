namespace _02_MatchPhoneNumber
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var phones = Console.ReadLine();

            var matches = Regex.Matches(phones, @"\+359(\s|-)2\1\d{3}\1\d{4}\b");

            var matchedPhones = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}