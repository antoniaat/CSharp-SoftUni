using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> palindromes = new List<string>();

            foreach (var word in input)
            {
                var reverse = new string(word.Reverse().ToArray());

                if (word == reverse)
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();
            Console.WriteLine("{0}", string.Join(", ", palindromes.Distinct()));
        }
    }
}
