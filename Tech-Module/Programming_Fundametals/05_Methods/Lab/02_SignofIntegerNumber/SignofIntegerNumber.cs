using System;

namespace _02.SignofIntegerNumber
{
    public class SignofIntegerNumber
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        private static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}