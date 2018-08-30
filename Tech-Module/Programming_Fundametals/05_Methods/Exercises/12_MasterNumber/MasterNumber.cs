namespace _12.MasterNumber
{
    using System;

    public class MasterNumber
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(int number)
        {
            string sNum = number.ToString();
            for (int i = 0; i < sNum.Length; i++)
                if (sNum[i] != sNum[sNum.Length - 1 - i]) return false;
            return true;
        }

        public static bool SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ContainsEvenDigit(int number)
        {
            string n = number.ToString();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}