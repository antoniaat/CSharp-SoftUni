namespace _01_ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
            var input = Console.ReadLine();
            var result = Regex.Matches(input, pattern);

            foreach (Match emailMatch in result)
            {
                Console.WriteLine(emailMatch);
            }
        }
    }
}
