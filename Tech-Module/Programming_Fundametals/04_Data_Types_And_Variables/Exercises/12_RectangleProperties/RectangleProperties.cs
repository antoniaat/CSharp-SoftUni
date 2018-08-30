using System;

namespace _12.Rectangle_Properties
{
    public class RectangleProperties
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + height);
            double area = width * height;
            double diagonal = width * width + height * height;
            diagonal = Math.Sqrt(diagonal);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}