namespace _03_RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"([^0-9]+)([0-9]+)";
            StringBuilder output = new StringBuilder();
            var result = Regex.Matches(input, pattern);

            foreach (Match matches in result)
            {
                string word = matches.Groups[1].ToString().ToUpper();
                int number = int.Parse(matches.Groups[2].ToString());

                for (int i = 1; i <= number; i++)
                {
                    output.Append(word);
                }
            }

            var uniqueCount = output.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueCount}");
            Console.WriteLine(output.ToString());
        }
    }
}
