namespace _02_RotateandSum
{
    using System;
    using System.Linq;

    public class RotateandSum
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var k = int.Parse(Console.ReadLine());

            var sumResult = new long[array.Count];

            for (var rotation = 0; rotation < k; rotation++)
            {
                array.Insert(0, array[array.Count - 1]);
                array.RemoveAt(array.Count - 1);

                for (var r = 0; r < array.Count; r++)
                {
                    sumResult[r] += array[r];
                }
            }

            Console.WriteLine(string.Join(" ", sumResult));
        }
    }
}