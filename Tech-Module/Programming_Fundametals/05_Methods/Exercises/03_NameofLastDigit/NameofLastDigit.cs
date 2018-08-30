namespace _03.NameofLastDigit
{
    using System;

    public class NameofLastDigit
    {
        public static void Main()
        {
            var input = long.Parse(Console.ReadLine());
            Console.WriteLine(NameOfLastDigit(input));
        }

        public static string NameOfLastDigit(long input)
        {
            var lastNumber = input % 10;
            lastNumber = Math.Abs(lastNumber);
            var output = String.Empty;

            switch (lastNumber)
            {
                case 0:
                    output = "zero";
                    break;

                case 1:
                    output = "one";
                    break;

                case 2:
                    output = "two";
                    break;

                case 3:
                    output = "three";
                    break;

                case 4:
                    output = "four";
                    break;

                case 5:
                    output = "five";
                    break;

                case 6:
                    output = "six";
                    break;

                case 7:
                    output = "seven";
                    break;

                case 8:
                    output = "eight";
                    break;

                case 9:
                    output = "nine";
                    break;
            }

            return output;
        }
    }
}