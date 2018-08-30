namespace _09.MultiplyEvensbyOdds
{
    using System;

    public class MultiplyEvensbyOdds
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            var result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        public static int GetMultipleOfEvenAndOdds(int n)
        {
            var sumEvens = GetSumOfEvenDigits(n);
            var sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }

        public static int GetSumOfOddDigits(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                var lastDigit = n % 10;

                if (lastDigit % 2 != 0)
                    sum += lastDigit;

                n /= 10;
            }
            return sum;
        }

        public static int GetSumOfEvenDigits(int n)
        {
            var secondSum = 0;
            while (n > 0)
            {
                var lastDigit = n % 10;

                if (lastDigit % 2 == 0)
                    secondSum += lastDigit;

                n /= 10;
            }
            return secondSum;
        }
    }
}