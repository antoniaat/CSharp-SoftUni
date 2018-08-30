using System;

namespace _01X
{
    // Program, which prints an X figure with height n.
    public class Launcher
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var space = n - 2;
            PrintXFigure(n, space);
        }

        private static void PrintXFigure(int n, int space)
        {
            for (var i = 0; i < n / 2; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write(new string('x', 1));
                Console.Write(new string(' ', space));
                space -= 2;
                Console.Write(new string('x', 1));
                Console.WriteLine(new string(' ', i));
            }

            var secondSpace = (n - 2) / 2;
            Console.Write(new string(' ', n / 2));
            Console.Write(new string('x', 1));
            Console.WriteLine(new string(' ', n / 2 - 1));
            var middleSpace = 1;

            for (var i = 1; i <= n / 2; i++)
            {
                Console.Write(new string(' ', secondSpace));
                Console.Write(new string('x', 1));
                Console.Write(new string(' ', middleSpace));
                Console.Write(new string('x', 1));
                Console.WriteLine(new string(' ', secondSpace));
                secondSpace -= 1;
                middleSpace += 2;
            }
        }
    }
}