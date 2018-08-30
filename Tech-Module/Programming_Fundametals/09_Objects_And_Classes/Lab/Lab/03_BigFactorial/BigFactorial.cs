namespace _03.BigFactorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            var n = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            BigInteger sum = 0;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
