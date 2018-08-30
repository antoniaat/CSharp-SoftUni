namespace _02_ConvertbaseNtobase10
{
    using System;
    using System.Numerics;

    public class ConvertbaseNtobase10
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long fromBase = long.Parse(input[0]);
            string number = input[1];

            BigInteger result = 0;

            int power = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                BigInteger num = BigInteger.Parse(number[i].ToString());
                result += BigInteger.Multiply(num, BigInteger.Pow(fromBase, power));
                power--;
            }

            Console.WriteLine(result);
        }
    }
}
