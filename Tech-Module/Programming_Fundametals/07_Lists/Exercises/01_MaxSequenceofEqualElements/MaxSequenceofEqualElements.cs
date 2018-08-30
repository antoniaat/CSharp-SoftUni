namespace _01.MaxSequenceofEqualElements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MaxSequenceofEqualElements
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            PrintMaxSeqOfElements(nums);
        }

        public static void PrintMaxSeqOfElements(List<long> nums)
        {
            long count = 1;
            long maxCount = 0;
            long number = 0;

            for (var i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;

                    if (count <= maxCount) continue;

                    maxCount = count;
                    number = nums[i];
                }

                else
                {
                    count = 1;
                }
            }

            for (var i = 0; i < maxCount; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
