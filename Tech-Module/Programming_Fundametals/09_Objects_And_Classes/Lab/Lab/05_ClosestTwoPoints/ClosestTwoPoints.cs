namespace _05.ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (var i = 0; i < n; i++)
            {
                var currentPointParts =
                    Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                points.Add(new Point
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1]
                });
            }

            var minDistanceSoFar = double.MaxValue;
            Point firstPointMax = null;
            Point secondPointMax = null;

            for (var i = 0; i < points.Count - 1; i++)
            {
                for (var j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];
                    var currentDistance =
                        CalculateDistance(
                            firstPoint, secondPoint);

                    if (!(currentDistance < minDistanceSoFar)) continue;
                    minDistanceSoFar = currentDistance;
                    firstPointMax = firstPoint;
                    secondPointMax = secondPoint;
                }
            }

            Console.WriteLine(minDistanceSoFar);
            Console.WriteLine($"({firstPointMax.X}, {firstPointMax.Y})");
            Console.WriteLine($"({secondPointMax.X}, {secondPointMax.Y})");
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var xDiff = Math.Pow((firstPoint.X - secondPoint.X), 2);
            var yDiff = Math.Pow((firstPoint.Y - secondPoint.Y), 2);
            var distance = Math.Sqrt(xDiff + yDiff);

            return distance;
        }
    }
}
