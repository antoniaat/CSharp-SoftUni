namespace _03.CirclesIntersection
{
    using System;
    using System.Linq;

    public class CirclesIntersection
    {
        public static void Main()
        {
            var circle1Input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var circle2Input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var circle1Center = new Point(circle1Input[0], circle1Input[1]);
            var circle1Radius = circle1Input[2];

            var circle2Center = new Point(circle2Input[0], circle2Input[1]);
            var circle2Radius = circle2Input[2];

            var circle1 = new Circle(circle2Center, circle1Radius);
            var circle2 = new Circle(circle1Center, circle2Radius);

            var result = circle1.Intercepts(circle2) ? "Yes" : "No";
            Console.WriteLine(result);
        }
    }

    public class Point
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }

    public class Circle
    {
        public Circle(Point center, int radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public Point Center { get; set; }

        public int Radius { get; set; }

        public bool Intercepts(Circle other)
        {
            var a = (double)(other.Center.X - this.Center.X);
            var b = (double)(other.Center.Y - this.Center.Y);

            var distanceBetweenCenters = Math.Sqrt(a * a + b * b);
            return distanceBetweenCenters <= this.Radius + other.Radius;
        }
    }
}