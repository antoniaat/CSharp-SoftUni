using System.Linq;
using System.Text;

namespace _05_KeyReplacer
{
    using System;
    using System.Text.RegularExpressions;

    public class KeyReplacer
    {
        public static void Main()
        {
            string pattern = @"\b([a-zA-Z]+)([|<\\])(.+)[|<\\]([a-zA-Z]+)\b";

            var keyString = Console.ReadLine();
            var textString = Console.ReadLine();

            var regex = Regex.Matches(keyString, pattern);

            var start = string.Empty;
            var end = string.Empty;

            foreach (Match matches in regex)
            {
                start = matches.Groups[1].ToString();
                end = matches.Groups[4].ToString();
            }

            string secondPattern = $@"{start}(?<word>.*?){end}";
            var secondRegex = Regex.Matches(textString, secondPattern);

            var result = new StringBuilder();

            foreach (Match matches in secondRegex)
            {
                result.Append(matches.Groups[1].Value);
            }

            Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
        }
    }
}
