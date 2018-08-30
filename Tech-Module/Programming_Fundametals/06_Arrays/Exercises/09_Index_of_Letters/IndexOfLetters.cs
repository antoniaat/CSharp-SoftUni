namespace _09_Index_of_Letters
{
    using System;
    using System.Collections.Generic;

    public class IndexOfLetters
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .ToLower()
                .ToCharArray();

            var alphabet = new List<char>();

            for (var i = 'a'; i <= 'z'; i++)
            {
                alphabet.Add(i);
            }

            foreach (var letter in input)
            {
                for (var j = 0; j < alphabet.Count; j++)
                {
                    if (letter == alphabet[j])
                    {
                        Console.WriteLine($"{alphabet[j]} -> {j}");
                    }
                }
            }
        }
    }
}