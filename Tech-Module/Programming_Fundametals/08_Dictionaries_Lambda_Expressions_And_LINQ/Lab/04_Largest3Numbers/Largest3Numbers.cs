namespace _04.Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            if (nums.Count < 3)
            {
                nums = nums.OrderByDescending(num => num).ToList();
                Console.WriteLine(string.Join(", ", nums));
            }
            else
            {
                nums = nums.OrderByDescending(num => num).Take(3).ToList();
                Console.WriteLine(string.Join(", ", nums));
            }
        }
    }
}
