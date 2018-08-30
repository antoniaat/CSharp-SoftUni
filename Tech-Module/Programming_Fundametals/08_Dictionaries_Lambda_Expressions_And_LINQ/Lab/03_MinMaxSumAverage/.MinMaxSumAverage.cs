namespace _03.Min_Max_Sum_Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<double>();

            for (int i = 1; i <= n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                list.Add(currentNumber);
            }

            var sum = list.Sum();
            var min = list.Min();
            var max = list.Max();
            var average = list.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
