using System;

namespace _07.ExchangeVariableValues
{
    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int temporaryVariableForA = a;
            int temporaryVariableForB = b;
            temporaryVariableForA = b;
            temporaryVariableForB = a;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {temporaryVariableForA}");
            Console.WriteLine($"b = {temporaryVariableForB}");
        }
    }
}