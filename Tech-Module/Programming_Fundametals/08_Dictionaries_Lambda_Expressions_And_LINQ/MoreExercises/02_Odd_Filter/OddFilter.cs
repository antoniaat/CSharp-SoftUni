namespace _02_Odd_Filter
{
    using System;
    using System.Linq;

    public class OddFilter
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (var i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0) continue;

                input.RemoveAt(i);
                i--;
            }

            var average = input.Sum() / input.Count;

            for (var i = 0; i < input.Count; i++)
            {
                if (input[i] > average)
                {
                    input[i] += 1;
                }
                else
                {
                    input[i] -= 1;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
