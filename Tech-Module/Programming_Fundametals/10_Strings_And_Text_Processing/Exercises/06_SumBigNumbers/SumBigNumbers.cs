namespace _06_SumBigNumbers
{
    using System;
    using System.Numerics;

    public class SumBigNumbers
    {
        public static void Main()
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
