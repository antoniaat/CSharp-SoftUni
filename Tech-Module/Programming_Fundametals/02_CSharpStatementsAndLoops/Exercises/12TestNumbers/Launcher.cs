using System;

namespace _12TestNumbers
{
    // Program, which finds all the possible combinations between two numbers – N and M
    public class Launcher
    {
        public static int Combinations;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var sum = CalculateSum(n, m, maxSum);
            PrintCombinations(sum, maxSum);
        }

        private static void PrintCombinations(double sum, int maxSum)
        {
            if (sum >= maxSum)
            {
                Console.WriteLine($"{Combinations} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }

            else if (sum < maxSum)
            {
                Console.WriteLine($"{Combinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }

        private static double CalculateSum(int n, int m, int maxSum)
        {
            var sum = 0.0;

            for (var i = n; i >= 1; i--)
            {
                for (var j = 1; j <= m; j++)
                {
                    double result = (i * j) * 3;
                    sum += result;
                    Combinations++;

                    if (sum >= maxSum)
                        return sum;
                }
            }

            return sum;
        }
    }
}
