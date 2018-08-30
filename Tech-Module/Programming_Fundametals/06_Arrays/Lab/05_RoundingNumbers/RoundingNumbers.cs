namespace _05.RoundingNumbers
{
    using System;
    using System.Linq;

    public class RoundingNumbers
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} => ");
                arr[i] = Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine(arr[i]);
            }
        }
    }
}
