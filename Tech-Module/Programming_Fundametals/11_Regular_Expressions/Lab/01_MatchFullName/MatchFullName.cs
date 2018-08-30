namespace _01_MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var r = new Regex(@"\b([A-Z][a-z]+\s+[A-Z][a-z]+)\b");
            var m = r.Matches(input);

            foreach (Match match in m)
            {
                Console.Write("{0} ", match.Groups[0]);
            }
        }
    }
}