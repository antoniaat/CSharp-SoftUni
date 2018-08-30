namespace _10_Pairs_by_Difference
{
    using System;
    using System.Linq;

    public class PairsByDifference
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var difference = int.Parse(Console.ReadLine());
            var count = 0;

            foreach (var num1 in numbers)
            {
                foreach (var num2 in numbers)
                {
                    if (num1 - num2 == difference)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}