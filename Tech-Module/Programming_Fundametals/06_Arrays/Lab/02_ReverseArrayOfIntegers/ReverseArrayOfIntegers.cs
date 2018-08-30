namespace _02.Reverse_Array_of_Integers
{
    using System;

    public class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (var i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (var i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
