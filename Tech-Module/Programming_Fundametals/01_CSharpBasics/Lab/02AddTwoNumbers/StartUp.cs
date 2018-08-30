using System;

namespace _02AddTwoNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
        }
    }
}