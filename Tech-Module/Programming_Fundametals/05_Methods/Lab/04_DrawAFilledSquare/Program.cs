namespace _4.Draw_a_Filled_Square
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            PrintMiddleRows(n);
            PrintHeaderRow(n);
        }

        public static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        public static void PrintMiddleRows(int n)
        {
            for (var j = 1; j <= n - 2; j++)
            {
                Console.Write('-');

                for (var i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}