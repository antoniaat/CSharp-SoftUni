namespace _03_PhoenixGrid
{
    using System;
    using System.Text.RegularExpressions;

    public class PhoenixGrid
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = (@"^([^\s_]{3}\.)+([^\s_]{3})*$");

            while (input != "ReadMe")
            {
                PrintResult(pattern, input);

                input = Console.ReadLine();
            }
        }

        public static void PrintResult(string pattern, string input)
        {
            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine(IsPalindrome(input) ? "YES" : "NO");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        public static bool IsPalindrome(string input)
        {
            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
