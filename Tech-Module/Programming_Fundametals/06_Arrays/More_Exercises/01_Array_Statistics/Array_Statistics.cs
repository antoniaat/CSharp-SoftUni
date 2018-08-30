using System.Linq;

namespace _01_Array_Statistics
{
    using System;

    public class Array_Statistics
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine($"Min = {MinNumber(array)}");
            Console.WriteLine($"Max = {MaxNumber(array)}");
            Console.WriteLine($"Sum = {SumArray(array)}");
            var average = SumArray(array) / array.Length;
            Console.WriteLine($"Average = {average}");
        }

        public static int MinNumber(int[] array)
        {
            var minNumber = array.Min();
            return minNumber;
        }

        public static int MaxNumber(int[] array)
        {
            var maxNumber = array.Max();
            return maxNumber;
        }

        public static double SumArray(int[] array)
        {
            var sum = array.Sum();
            return sum;
        }
    }
}
