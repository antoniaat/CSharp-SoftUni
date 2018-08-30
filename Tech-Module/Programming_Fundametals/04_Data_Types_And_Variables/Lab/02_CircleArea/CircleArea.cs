using System;

namespace _02.CircleArea
{
    public class CircleArea
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = r * r * Math.PI;
            Console.WriteLine($"{area:f12}");
        }
    }
}