namespace _02_ExtractSentencesbyKeyword
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentencesbyKeyword
    {
        public static void Main()
        {
            var keyword = Console.ReadLine();
            var input = Console.ReadLine();
            string pattern = $@"\b[A-Za-z\s0-9-,]+{keyword}\s[A-Za-z\s0-9-,]+";

            var result = Regex.Matches(input, pattern);

            foreach (Match m in result)
            {
                Console.WriteLine(m);
            }
        }
    }
}
