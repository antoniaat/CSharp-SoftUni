using System;

namespace _16.Comparing_floats
{
    public class ComparingFloats
    {
        public static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double biggerNumber = Math.Max(num1, num2);
            double smallerNumer = Math.Min(num1, num2);
            double difference = biggerNumber - smallerNumer;
            bool output = true;

            if (difference <= 0.000001)
                Console.WriteLine(output);
            else
                Console.WriteLine(!output);
        }
    }
}