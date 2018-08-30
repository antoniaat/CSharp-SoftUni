namespace _02.RandomizeWords
{
    using System;

    public class RandomizeWords
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                var currentWord = words[pos1];
                var randomIndex = rnd.Next(0, words.Length);
                var tempWord = words[randomIndex];
                words[pos1] = tempWord;
                words[randomIndex] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
