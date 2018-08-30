namespace _03_FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var n = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var middleNumbers = new List<int>();
            var leftNumbers = new List<int>();
            var rightNumbers = new List<int>();

            for (var i = 0; i < n.Count / 4; i++)
            {
                leftNumbers.Add(n[i]);
            }
            leftNumbers.Reverse();

            var leftAndRightNumbersCount = n.Count / 4;
            var middleNumbersCount = leftAndRightNumbersCount * 2;

            for (var i = leftAndRightNumbersCount; i < middleNumbersCount + leftAndRightNumbersCount; i++)
            {
                middleNumbers.Add(n[i]);
            }

            for (var i = middleNumbersCount + leftAndRightNumbersCount; i < n.Count; i++)
            {
                rightNumbers.Add(n[i]);
            }
            rightNumbers.Reverse();

            var leftAndRightNumbers = new List<int>();

            leftNumbers.ForEach(element => leftAndRightNumbers.Add(element));
            rightNumbers.ForEach(element => leftAndRightNumbers.Add(element));

            var sumResult = new List<int>();

            for (var i = 0; i < middleNumbersCount; i++)
            {
                sumResult.Add(leftAndRightNumbers[i] + middleNumbers[i]);
            }

            foreach (var num in sumResult)
            {
                Console.Write($"{num} ");
            }
        }
    }
}