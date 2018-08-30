namespace _08.Center_Point
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            var X1 = double.Parse(Console.ReadLine());
            var Y1 = double.Parse(Console.ReadLine());
            var X2 = double.Parse(Console.ReadLine());
            var Y2 = double.Parse(Console.ReadLine());

            var FirstPdoubleDistance = CalculateDistanceToZero(X1, Y1);
            var SecondPdoubleDistance = CalculateDistanceToZero(X2, Y2);

            if (FirstPdoubleDistance <= SecondPdoubleDistance)
            {
                Console.WriteLine($"({X1}, {Y1})");
            }
            else
            {
                Console.WriteLine($"({X2}, {Y2})");
            }
        }

        public static double CalculateDistanceToZero(double X, double Y)
        {
            var Distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return Distance;
        }
    }
}