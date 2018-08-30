namespace _08_Most_Frequent_Number
{
    using System;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray()
                .GroupBy(v => v);

            foreach (var group in input.OrderByDescending(x => x.Count()))
            {
                Console.WriteLine($"{group.Key}");
                break;
            }
        }
    }
}