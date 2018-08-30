namespace _01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var currentNumber in nums)
            {
                if (!counts.ContainsKey(currentNumber))
                {
                    counts[currentNumber] = 0;
                }

                counts[currentNumber]++;
            }

            foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }
        }
    }
}
