namespace _09.LongerLine
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            var line1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            var line2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            if (line1 >= line2)
            {
                var isFirstCloser = CloserPoint(x1, y1, x2, y2);
                if (isFirstCloser)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                var isFirstCloser = CloserPoint(x3, y3, x4, y4);
                if (isFirstCloser)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static bool CloserPoint(double x1, double y1, double x2, double y2)
        {
            var firstPointLine = Math.Sqrt(x1 * x1 + y1 * y1);
            var secondPointLine = Math.Sqrt(x2 * x2 + y2 * y2);
            bool isFirstCloser;

            if (firstPointLine <= secondPointLine)
            {
                isFirstCloser = true;
            }
            else
            {
                isFirstCloser = false;
            }
            return isFirstCloser;
        }
    }
}