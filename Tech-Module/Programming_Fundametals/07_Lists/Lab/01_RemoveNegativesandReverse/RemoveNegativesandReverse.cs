namespace _01.RemoveNegativesandReverse
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RemoveNegativesandReverse
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            PrintResult(nums);
        }

        public static void PrintResult(List<double> nums)
        {
            for (var i = 0; i < nums.Count - 1; i++)
            {
                while (i < nums.Count - 1)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        nums[i] = nums[i] + nums[i + 1];
                        nums.RemoveAt(i + 1);

                        if (i > 0)
                        {
                            i--;
                        }
                    }

                    else
                    {
                        i++;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
