namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            for (var i = 0; i < nums.Count - 1; i++)
            {
                while (nums[i] == nums[i + 1])
                {
                    var sum = nums[i] * 2;
                    nums.Remove(nums[i]);
                    nums.Remove(nums[i]);
                    nums.Insert(i, sum);
                    i = 0;
                }
            }

            foreach (var number in nums)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
