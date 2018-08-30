namespace _08.CondenseArraytoNumber
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CondenseArraytoNumber
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var currentInts = new List<int>();

            while (nums.Count > 1)
            {
                for (var i = 0; i < nums.Count - 1; i++)
                {
                    currentInts.Add(nums[i] + nums[i + 1]);
                }
                nums = currentInts;
                currentInts = new List<int>();
            }

            Console.WriteLine(nums[0]);
        }
    }
}
