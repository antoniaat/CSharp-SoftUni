using System;

namespace _01Greeting
{
    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}