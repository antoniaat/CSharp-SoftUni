namespace _04_Grab_and_Go
{
    using System;
    using System.Linq;

    public class Grab_and_Go
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                ?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            var number = int.Parse(Console.ReadLine());

            if (array.Contains(number))
            {
                Console.WriteLine(GrabAndGo(array, number));
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }

        public static double GrabAndGo(int[] array, int number)
        {
            var sum = 0D;
            var count = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] != number || count != 0) continue;
                count++;

                for (var j = i + 1; j < array.Length; j++)
                {
                    sum += array[j];
                }
            }

            return sum;
        }
    }
}
