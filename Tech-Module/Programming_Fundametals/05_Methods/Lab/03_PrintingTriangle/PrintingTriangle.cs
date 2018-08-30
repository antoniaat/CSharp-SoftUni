namespace _03.Printing_Triangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                PrintLine(1, i);
            }

            PrintLine(1, n);

            for (var i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }

        public static void PrintLine(int start, int end)
        {
            for (var i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}