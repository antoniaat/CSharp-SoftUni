namespace _11.GeometryCalc
{
    using System;

    public class GeometryCalc
    {
        public static void Main()
        {
            var figureType = Console.ReadLine();

            switch (figureType)
            {
                case "triangle":
                {
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    var result = TriagnleArea(side, height);
                    Console.WriteLine($"{result:f2}");
                    break;
                }
                case "square":
                {
                    double side = double.Parse(Console.ReadLine());
                    var result = SquareArea(side);
                    Console.WriteLine($"{result:f2}");
                    break;
                }
                case "rectangle":
                {
                    double width = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    var result = RectangleArea(width, height);
                    Console.WriteLine($"{result:f2}");
                    break;
                }
                case "circle":
                {
                    double radius = double.Parse(Console.ReadLine());
                    var result = CircleArea(radius);
                    Console.WriteLine($"{result:f2}");
                    break;
                }
            }
        }

        public static double TriagnleArea(double side, double height)
        {
            var area = (side * height) / 2;
            return area;
        }

        public static double SquareArea(double side)
        {
            var area = side * side;
            return area;
        }

        public static double RectangleArea(double width, double height)
        {
            var area = width * height;
            return area;
        }

        public static double CircleArea(double radius)
        {
            var area = Math.PI * radius * radius;
            return area;
        }
    }
}