namespace _06_MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var count = 1;
            var maxSum = 1;
            var number = 0;

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxSum)
                {
                    maxSum = count;
                    number = list[i];
                }
            }

            for (int i = 0; i < maxSum; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}