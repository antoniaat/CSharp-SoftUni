namespace _06.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            List<int> lineOfDigits = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            for (int i = 0; i < lineOfDigits.Count; i++)
            {
                int currentNumber = lineOfDigits[i];

                int reverse = int.Parse(currentNumber
                    .ToString()
                    .Reverse()
                    .Aggregate("", (s, c) => s + c));

                sum += reverse;
            }

            Console.WriteLine(sum);
        }
    }
}
