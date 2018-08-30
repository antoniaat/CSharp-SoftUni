namespace _03_Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    public class Regexmon
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            Regex bojoPattern = new Regex(@"([a-zA-Z]+-[a-zA-Z]+)");
            Regex didiPattern = new Regex(@"[^A-Za-z-\s]+");

            while (text != String.Empty)
            {
                if (didiPattern.IsMatch(text))
                {
                    MatchCollection collection = didiPattern.Matches(text);
                    Match firstMatch = collection[0];
                    Console.WriteLine(firstMatch.ToString());
                    text = text.Substring(text.IndexOf(firstMatch.ToString()));
                    text = text.Remove(text.IndexOf(firstMatch.ToString()), firstMatch.Length);
                }

                else
                {
                    break;
                }

                if (bojoPattern.IsMatch(text))
                {
                    MatchCollection collection = bojoPattern.Matches(text);
                    Match firstMatch = collection[0];
                    Console.WriteLine(firstMatch.ToString());
                    text = text.Substring(text.IndexOf(firstMatch.ToString()));
                    text = text.Remove(text.IndexOf(firstMatch.ToString()), firstMatch.Length);
                }

                else
                {
                    break;
                }
            }
        }
    }
}
