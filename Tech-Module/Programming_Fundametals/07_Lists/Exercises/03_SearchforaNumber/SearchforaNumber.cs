namespace _03.SearchforaNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SearchforaNumber
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var output = new List<int>();
            var firstNumber = arr[0];
                
            for (int i = 0; i < firstNumber; i++)
            {
                output.Add(nums[i]);
            }

            var secondNumber = arr[1];

            for (int i = 0; i < secondNumber; i++)
            {
                output.Remove(nums[i]);
            }

            if (output.Contains(arr[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
