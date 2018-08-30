namespace _01_LargestCommonEnd
{
    using System;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            var firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var leftCount = FindMaxCommonItems(firstArr, secondArr);
            Array.Reverse(firstArr);
            secondArr = secondArr.Reverse().ToArray();
            var rightCount = FindMaxCommonItems(firstArr, secondArr);

            Console.WriteLine($"{Math.Max(leftCount, rightCount)}");
        }

        public static int FindMaxCommonItems(string[] firstArr, string[] secondArr)
        {
            var lenght = Math.Min(firstArr.Length, secondArr.Length);
            var count = 0;

            for (var i = 0; i < lenght; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}