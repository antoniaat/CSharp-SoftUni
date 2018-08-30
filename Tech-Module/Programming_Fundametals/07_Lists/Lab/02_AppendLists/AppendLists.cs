namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            var nums = new List<string>();

            var tokens = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToArray();

            foreach (var token in tokens)
            {
                var addNumber = token
                    .Split(' ')
                    .ToList();

                addNumber.RemoveAll(x => x == "");

                nums.AddRange(addNumber);
            }

            foreach (var number in nums)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
