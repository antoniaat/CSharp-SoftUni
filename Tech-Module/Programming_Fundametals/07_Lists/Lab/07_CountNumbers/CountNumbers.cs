namespace _07.CountNumbers
{
    using System;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Reverse()
                .ToList();

            var count = 1;

            for (var i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    Console.WriteLine($"{numbers[i]} -> {count}");
                    break;
                }

                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                
                else if (numbers[i] != numbers[i + 1])
                {
                    Console.WriteLine($"{numbers[i]} -> {count}");
                    count = 1;
                }
            }
        }
    }
}
