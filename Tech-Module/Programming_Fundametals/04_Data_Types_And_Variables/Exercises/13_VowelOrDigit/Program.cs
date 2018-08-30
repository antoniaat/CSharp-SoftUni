using System;

namespace _13.Vowel_or_Digit
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();

            if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u" || input == "y")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                try
                {
                    int output = Int32.Parse(input);
                    Console.WriteLine("digit");
                }
                catch (Exception)
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}