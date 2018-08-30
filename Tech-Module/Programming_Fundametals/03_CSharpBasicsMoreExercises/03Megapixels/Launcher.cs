using System;

namespace _03Megapixels
{
    // Program which with given an image resolution (width and height), calculates its megapixels
    public class Launcher
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            CalculateMegapixels(width, height);
        }

        private static void CalculateMegapixels(double width, double height)
        {
            var megapixels = (width * height) / 1000000;

            if (megapixels % 2 == 0)
            {
                megapixels = Math.Round(megapixels, 1);
                Console.WriteLine($"{width}x{height} => {megapixels}MP");
            }
            else
            {
                Console.WriteLine($"{width}x{height} => {megapixels:f1}MP");
            }
        }
    }
}