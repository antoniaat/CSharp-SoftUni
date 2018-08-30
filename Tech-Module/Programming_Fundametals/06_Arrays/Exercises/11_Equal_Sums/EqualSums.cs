using System.Linq;

namespace _11_Equal_Sums
{
    using System;

    public class EqualSums
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var count = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var leftSum = 0;
                var rightSum = 0;

                if (i == 0)
                {
                    leftSum = 0;

                    for (var j = 1; j < input.Length; j++)
                    {
                        rightSum += input[j];
                    }
                }
                else
                {
                    for (var j = 0; j < i; j++)
                    {
                        leftSum += input[j];
                    }

                    for (var k = i + 1; k < input.Length; k++)
                    {
                        rightSum += input[k];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}