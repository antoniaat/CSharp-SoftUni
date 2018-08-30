using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            List<string> bannedWordsList = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string text = Console.ReadLine();

            foreach (var word in bannedWordsList)
            {
                if (text.Contains(word))
                {
                    string replace = new string('*', word.Length);
                    text = text.Replace(word, replace);
                }
            }

            Console.WriteLine(text);
        }
    }
}
