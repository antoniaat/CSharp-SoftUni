using System;

namespace _05.Special_Numbers
{
    public class SpecialNumbers
    {
        public static void Main()
        {
            var digit = int.Parse(Console.ReadLine());

            for (var num = 1; num <= digit; num++)
            {
                bool specialNumber;
                if (num < 10)
                {
                    if (num == 5 || num == 7)
                    {
                        specialNumber = true;
                        Console.WriteLine($"{num} -> {specialNumber}");
                    }
                    else
                    {
                        specialNumber = false;
                        Console.WriteLine($"{num} -> {specialNumber}");
                    }
                }
                else if (num >= 10 && num < 100)
                {
                    var lastDigit = num % 10;
                    var firstDigit = num / 10;
                    var sum = firstDigit + lastDigit;

                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        specialNumber = true;
                        Console.WriteLine($"{num} -> {specialNumber}");
                    }
                    else
                    {
                        specialNumber = false;
                        Console.WriteLine($"{num} -> {specialNumber}");
                    }
                }
            }
        }
    }
}