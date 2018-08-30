namespace Raindrops
{
    using System;
    using System.Linq;

    public class Raindrops
    {
        public static void Main()
        {
            var amountRegions = long.Parse(Console.ReadLine());
            var density = decimal.Parse(Console.ReadLine());
            decimal sum = 0;

            for (var i = 0; i < amountRegions; i++)
            {
                var currentRegion = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse)
                    .ToList();

                var raindropsCount = currentRegion[0];
                var squareMeters = currentRegion[1];

                var regionalCoefficient = raindropsCount / squareMeters;
                sum += regionalCoefficient;
            }

            try
            {
                var result = sum / density;
                Console.WriteLine($"{result:f3}");
            }
            catch (Exception)
            {
                Console.WriteLine($"{sum:f3}");
            }
        }
    }
}
