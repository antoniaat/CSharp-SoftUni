namespace _01_Resurrection
{
    using System;

    public class Resurrection
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var totalLenght = double.Parse(Console.ReadLine());
                var totalWidth = decimal.Parse(Console.ReadLine());
                var wingLength = decimal.Parse(Console.ReadLine());

                var powered = (decimal)(Math.Pow(totalLenght, 2));
                var totalYears = powered * (totalWidth + 2 * wingLength);
                Console.WriteLine($"{totalYears}");
            }
        }
    }
}
