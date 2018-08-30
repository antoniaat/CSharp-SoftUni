namespace _08.GreaterofTwoValues
{
    using System;

    public class GreaterofTwoValues
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            if (input == "int")
            {
                var firstNumber = int.Parse(Console.ReadLine());
                var secondNumber = int.Parse(Console.ReadLine());
                var result = GetMax(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (input == "char")
            {
                var firstLetter = char.Parse(Console.ReadLine());
                var secondLetter = char.Parse(Console.ReadLine());
                var result = GetMax(firstLetter, secondLetter);
                Console.WriteLine(result);
            }
            else if (input == "string")
            {
                var firstLine = Console.ReadLine();
                var secondLine = Console.ReadLine();
                var result = GetMax(firstLine, secondLine);
                Console.WriteLine(result);
            }
        }

        public static int GetMax(int firstNumber, int secondNumber)
        {
            return firstNumber >= secondNumber ? firstNumber : secondNumber;
        }

        public static char GetMax(char firstLetter, char secondLetter)
        {
            if (firstLetter < secondLetter) return secondLetter;

            return firstLetter;
        }

        public static string GetMax(string firstLine, string secondLine)
        {
            if (firstLine.CompareTo(secondLine) < 0) return secondLine;

            return firstLine;
        }
    }
}