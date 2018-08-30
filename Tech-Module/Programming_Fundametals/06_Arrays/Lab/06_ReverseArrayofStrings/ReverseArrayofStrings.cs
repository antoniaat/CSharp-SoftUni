namespace _06.ReverseArrayofStrings
{
    using System;
    using System.Linq;

    public class ReverseArrayofStrings
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (var i = arr.Length - 1; i >= 0; i--)
            {
                var reverse = arr[i];
                Console.Write($"{reverse} ");
            }
        }
    }
}