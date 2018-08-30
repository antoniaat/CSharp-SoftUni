namespace _04.NumsReversedOrder
{
    using System;

    public class NumsReversedOrder
    {
        public static void Main()
        {
            var number = Console.ReadLine();
            Console.WriteLine(ReversedOrder(number));
        }

        public static string ReversedOrder(string number)
        {
            var reversed = string.Empty;

            for (var j = number.Length - 1; j >= 0; j--)
            {
                reversed += number[j];
            }

            return reversed;
        }
    }
}