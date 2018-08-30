namespace _04.TripleSum
{
    using System;
    using System.Linq;

    public class TripleSum
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    var sum = arr[i] + arr[j];

                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");
                        counter++;
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}