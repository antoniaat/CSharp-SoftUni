namespace _09_ExtractMiddleElements
{
    using System;
    using System.Linq;

    public class ExtractMiddleElements
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (input.Length == 1)
            {
                Console.WriteLine(input[0]);
            }

            else if (input.Length % 2 == 0)
            {
                var firstNumber = input[input.Length / 2 - 1];
                var secondNumber = input[input.Length / 2];
                Console.WriteLine($"{{ {firstNumber}, {secondNumber} }}");
            }

            else
            {
                var firstNumber = input[input.Length / 2 - 1];
                var secondNumber = input[input.Length / 2];
                var thirdNumber = input[input.Length / 2 + 1];
                Console.WriteLine($"{{ {firstNumber}, {secondNumber}, {thirdNumber} }}");
            }
        }
    }
}
