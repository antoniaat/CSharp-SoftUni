using System;

namespace _14.IntegertoHexandBinary
{
    public class IntegertoHexandBinary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string secondNumber = Convert.ToString(number, 16);
            secondNumber = secondNumber.ToUpper();
            Console.WriteLine(secondNumber);
            string thirdNum = Convert.ToString(number, 2);
            Console.WriteLine(thirdNum);
        }
    }
}