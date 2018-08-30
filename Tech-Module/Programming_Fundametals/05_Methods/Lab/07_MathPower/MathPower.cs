namespace _07.Math_Power
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var raisedNumber = int.Parse(Console.ReadLine());
            var result = RaiseToPower(number, raisedNumber);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, int raisedNumber)
        {
            var result = 0d;
            result = Math.Pow(number, raisedNumber);
            return result;
        }
    }
}