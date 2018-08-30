using System;

namespace _14MagicLetter
{
    // Program, which prints all 3-letter combinations, using only the letters from a given interval. 
    // You will also receive a third letter. Every combination, which contains this letter should not be printed
    public class Launcher
    {
        public static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char stopLetter = char.Parse(Console.ReadLine());

            PrintLetterCombinations(firstLetter, secondLetter, stopLetter);
        }

        private static void PrintLetterCombinations(char firstLetter, char secondLetter, char stopLetter)
        {
            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (!(i == stopLetter || j == stopLetter || k == stopLetter))
                        {
                            Console.Write(i.ToString() + j.ToString() + k.ToString() + " ");
                        }
                    }
                }
            }
        }
    }
}
