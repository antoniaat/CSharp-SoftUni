namespace _13.Factorial
{
    using System;
    using System.Numerics;

    public class Factorial
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

            Console.WriteLine(factorial);
        }
    }
}