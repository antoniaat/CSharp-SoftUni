using System;
using System.Text.RegularExpressions;

namespace _03_Snowflake
{
    public class Snowflake
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine();
            var secondLine = Console.ReadLine();
            var thirdLine = Console.ReadLine();
            var forthLine = Console.ReadLine();
            var fiftLine = Console.ReadLine();

            var surfaceRegex = new Regex(@"^([^A-Za-z1-9]+)$");
            var mantleRegex = new Regex(@"\b([0-9_]+)\b");
            var middleRegex = new Regex(@"^(([^a-zA-Z0-9]+)([0-9_]+)([a-zA-Z]+)([0-9_]+)([^a-zA-Z0-9]+))$");
            bool isValid = false;
            var coreLenght = 0;

            if (surfaceRegex.IsMatch(firstLine) && surfaceRegex.IsMatch(fiftLine))
            {
                if (mantleRegex.IsMatch(secondLine) && mantleRegex.IsMatch(forthLine))
                {
                    if (middleRegex.IsMatch(thirdLine))
                    {
                        isValid = true;

                        foreach (Match match in middleRegex.Matches(thirdLine))
                        {
                            coreLenght = match.Groups[4].Length;
                        }
                    }
                }
            }

            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(coreLenght);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
