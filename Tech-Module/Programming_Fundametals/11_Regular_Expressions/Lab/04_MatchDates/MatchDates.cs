namespace _04_MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchDates
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = Regex.Matches(input, @"(\d{2})(\/|-|\.)(([A-Z]{1}[a-z]{2})+\2(\d{4}))\b");

            foreach (Match m in result)
            {
                Console.Write($"Day: {m.Groups[1].Value}, ");
                Console.Write($"Month: {m.Groups[4].Value}, ");
                Console.WriteLine($"Year: {m.Groups[5].Value}");
            }
        }
    }
}