using System;

namespace _13GameOfNumbers
{
    //program, which finds all possible combinations in the interval between two numbers. 
    //The program should also find the last combination, in which a number’s digits are equal to a given magical number.

    public class Launcher
    {
        public static int Combinations;
        public static int Sum;
        public static int FirstNumber;
        public static int SecondNumber;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            CalculateCombinations(n, m, magicNum);
            PrintCombinations(magicNum);
        }

        private static void CalculateCombinations(int n, int m, int magicNum)
        {
            for (var i = n; i <= m; i++)
            {
                for (var index = n; index <= m; index++)
                {
                    Sum = i + index;
                    Combinations++;
                    FirstNumber = i;
                    SecondNumber = index;

                    if (Sum == magicNum)
                        return;
                }
            }
        }

        private static void PrintCombinations(int magicNum)
        {
            Console.WriteLine(Sum == magicNum
                ? $"Number found! {SecondNumber} + {FirstNumber} = {magicNum}"
                : $"{Combinations} combinations - neither equals {magicNum}");
        }
    }
}
