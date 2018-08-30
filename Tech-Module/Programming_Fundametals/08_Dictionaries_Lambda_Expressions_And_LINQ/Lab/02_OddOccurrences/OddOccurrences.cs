namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;

    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 0;
                }

                wordCount[word]++;
            }

            var result = new List<string>();

            foreach (var item in wordCount)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
