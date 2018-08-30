namespace _05.FibonacciNumbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            var n = Math.Abs(long.Parse(Console.ReadLine()));

            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(Fib(n));
            }
        }

        public static long Fib(long n)
        {
            var f1 = 0;
            var f2 = 1;
            var fibNum = 0;

            for (var i = 1; i <= n; i++)
            {
                fibNum = f1 + f2;
                f1 = f2;
                f2 = fibNum;
            }

            return fibNum;
        }
    }
}