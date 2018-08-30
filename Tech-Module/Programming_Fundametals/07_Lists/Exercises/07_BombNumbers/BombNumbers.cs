namespace _07.BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            List<int> numberList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] specialNumbers = Console.ReadLine()
                .Split();

            int bombNumber = int.Parse(specialNumbers[0]);
            int power = int.Parse(specialNumbers[1]);

            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] == bombNumber)
                {
                    int left = Math.Max(i - power, 0);
                    int right = Math.Min(i + power, numberList.Count - 1);
                    int lenght = right - left + 1;
                    numberList.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(numberList.Sum());
        }
    }
}
