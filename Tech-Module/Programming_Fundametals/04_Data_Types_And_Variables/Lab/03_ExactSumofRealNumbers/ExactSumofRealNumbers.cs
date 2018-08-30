using System;

namespace _03.ExactSumofRealNumbers
{
    public class ExactSumofRealNumbers
    {
        public static void Main()
        {
            var n = decimal.Parse(Console.ReadLine());
            decimal sum = 0;

            for (var i = 1; i <= n; i++)
            {
                var num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}