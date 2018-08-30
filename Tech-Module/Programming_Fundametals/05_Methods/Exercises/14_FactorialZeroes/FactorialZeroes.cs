namespace _14.FactorialZeroes
{
    using System;
    using System.Numerics;

    public class FactorialZeroes
    {
        public static void Main()
        {
            BigInteger factorial = 1;
            var n = int.Parse(Console.ReadLine());
            var timesZero = 0;

            for (var i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            while (factorial % 10 == 0)
            {
                timesZero++;
                factorial /= 10;
            }

            Console.WriteLine(timesZero);
        }
    }
}