namespace _01_Wormtest
{
    using System;

    public class Wormtest
    {
        public static void Main()
        {
            var wormLenght = long.Parse(Console.ReadLine());
            var wormWidth = decimal.Parse(Console.ReadLine());
            wormLenght *= 100;
            var remainder = wormLenght % wormWidth;

            if (remainder != 0)
            {
                var percentage = wormLenght / wormWidth * 100;
                Console.WriteLine($"{percentage:F2}%");
            }
            else
            {
                var product = wormLenght * wormWidth;
                Console.WriteLine($"{product:F2}");
            }
        }
    }
}