using System;

namespace _01DebitCardNumber
{
    public class StartUp
    {
        public static void Main()
        {
            var one = int.Parse(Console.ReadLine());
            var two = int.Parse(Console.ReadLine());
            var three = int.Parse(Console.ReadLine());
            var four = int.Parse(Console.ReadLine());

            Console.WriteLine($"{one:D4} {two:D4} {three:D4} {four:D4}");
        }
    }
}