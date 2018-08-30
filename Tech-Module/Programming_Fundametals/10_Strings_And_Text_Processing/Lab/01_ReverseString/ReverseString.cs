using System;
using System.Linq;

namespace _01_ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var output = input
                .Reverse()
                .ToArray();

            foreach (var index in output)
            {
                Console.Write(index);
            }
            Console.WriteLine();
        }
    }
}
