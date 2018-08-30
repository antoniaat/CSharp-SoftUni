using System;

namespace _08SMSTyping
{
    // Program, which emulates typing an SMS.
    public class Launcher
    {
        private static int firstDigit = 0;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= n; i++)
            {
                var digits = int.Parse(Console.ReadLine());

                CheckHowManyTimesNumberItsPressed(digits);

                FourDigitsLetters(digits);
            }
        }

        private static void FourDigitsLetters(int digits)
        {
            if (digits == 7777 || digits == 9999)
            {
                switch (digits)
                {
                    case 7777:
                        Console.Write("s");
                        break;

                    case 9999:
                        Console.Write("z");
                        break;
                }
            }
        }

        private static void CheckHowManyTimesNumberItsPressed(int digits)
        {
            if (digits / 10 < 1)
            {
                PressedOnceNumber(digits);
            }
            else if (digits / 10 > 0 && digits / 10 < 10)
            {
                PressedTwiceNumber(digits);
            }
            else if (digits / 10 > 10 && digits / 10 < 100)
            {
                PressedThreeTimesNumber(digits);
            }
        }

        private static void PressedThreeTimesNumber(int digits)
        {
            firstDigit = digits / 100;

            switch (firstDigit)
            {
                case 2:
                    Console.Write("c");
                    break;

                case 3:
                    Console.Write("f");
                    break;

                case 4:
                    Console.Write("i");
                    break;

                case 5:
                    Console.Write("l");
                    break;

                case 6:
                    Console.Write("o");
                    break;

                case 7:
                    Console.Write("r");
                    break;

                case 8:
                    Console.Write("v");
                    break;

                case 9:
                    Console.Write("y");
                    break;
            }
        }

        private static void PressedTwiceNumber(int digits)
        {
            firstDigit = digits / 10;

            switch (firstDigit)
            {
                case 2:
                    Console.Write("b");
                    break;

                case 3:
                    Console.Write("e");
                    break;

                case 4:
                    Console.Write("h");
                    break;

                case 5:
                    Console.Write("k");
                    break;

                case 6:
                    Console.Write("n");
                    break;

                case 7:
                    Console.Write("q");
                    break;

                case 8:
                    Console.Write("u");
                    break;

                case 9:
                    Console.Write("x");
                    break;
            }
        }

        private static void PressedOnceNumber(int digits)
        {
            firstDigit = digits;

            switch (firstDigit)
            {
                case 2:
                    Console.Write("a");
                    break;

                case 3:
                    Console.Write("d");
                    break;

                case 4:
                    Console.Write("g");
                    break;

                case 5:
                    Console.Write("j");
                    break;

                case 6:
                    Console.Write("m");
                    break;

                case 7:
                    Console.Write("p");
                    break;

                case 8:
                    Console.Write("t");
                    break;

                case 9:
                    Console.Write("w");
                    break;

                case 0:
                    Console.Write(" ");
                    break;
            }
        }
    }
}