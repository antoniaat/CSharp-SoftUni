namespace _04.DistancebetweenPoints
{
    using System;
    using System.Linq;

    public class DistancebetweenPoints
    {
        public static void Main()
        {
            var firstPointParts = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var firstPoint = new Point()
            {
                x = firstPointParts[0],
                y = firstPointParts[1]
            };

            var secondPointParts = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var secondPoint = new Point()
            {
                x = secondPointParts[0],
                y = secondPointParts[1]
            };

            var result = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{result:f3}");
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var xDiff = Math.Pow((firstPoint.x - secondPoint.x), 2);
            var yDiff = Math.Pow((firstPoint.y - secondPoint.y),2);
            var distance = Math.Sqrt(xDiff + yDiff);

            return distance;
        }
    }
}
