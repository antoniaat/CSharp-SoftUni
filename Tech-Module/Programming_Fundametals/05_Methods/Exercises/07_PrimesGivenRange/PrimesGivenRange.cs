namespace _07.PrimesGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesGivenRange
    {
        public static void Main()
        {
            var from = int.Parse(Console.ReadLine());
            var to = int.Parse(Console.ReadLine());
            var primeIntegers = new List<int>();

            for (var i = from; i <= to; i++)
            {
                if (IsPrime(i))
                {
                    primeIntegers.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", primeIntegers));
        }

        public static bool IsPrime(int number)
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