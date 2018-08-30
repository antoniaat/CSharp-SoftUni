namespace _06.PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            var n = Math.Abs(long.Parse(Console.ReadLine()));

            if (IsPrime(n))
            {
                Console.WriteLine(IsPrime(n));
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (var i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}