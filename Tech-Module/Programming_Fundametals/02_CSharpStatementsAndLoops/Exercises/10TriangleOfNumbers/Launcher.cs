using System;

namespace _10TriangleOfNumbers
{
    public class Launcher
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            DrawTriangle(n);
        }

        private static void DrawTriangle(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                for (var rows = 1; rows <= i; rows++)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine();
            }
        }
    }
}
