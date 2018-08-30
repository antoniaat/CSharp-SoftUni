namespace _03_AnonymousVox
{
    using System;
    using System.Text.RegularExpressions;

    public class AnonymousVox
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex(@"([a-zA-Z]+)(.+)\1");
            var matches = regex.Matches(text);
            var placeholderIndex = 0;

            foreach (Match match in matches)
            {
                if (placeholderIndex >= placeholders.Length) break;

                text = ReplaceFirst(text, match.Groups[2].Value, placeholders[placeholderIndex++]);
            }

            Console.WriteLine(text);
        }

        static string ReplaceFirst(string text, string oldValue, string newValue)
        {
            var substringWithOldValue = text.Substring(0, text.IndexOf(oldValue) + oldValue.Length);
            var substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);

            return substringWithNewValue + text.Substring(substringWithOldValue.Length);
        }
    }
}