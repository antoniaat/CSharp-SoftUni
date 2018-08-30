using System;

namespace _15.Fast_Prime_Checker
{
    public class FastPrimeChecker
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int primeNumber = 2; primeNumber <= num; primeNumber++)
            {
                bool isPrime = true;

                for (int division = 2; division <= Math.Sqrt(primeNumber); division++)
                {
                    if (primeNumber % division == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{primeNumber} -> {isPrime}");
            }
        }
    }
}