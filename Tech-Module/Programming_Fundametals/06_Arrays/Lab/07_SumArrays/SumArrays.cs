namespace _07.SumArrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var secondArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (arr.Length <= secondArray.Length)
            {
                for (var i = 0; i < secondArray.Length; i++)
                {
                    var maxArr = (arr[i % arr.Length] + secondArray[i % secondArray.Length]);

                    if (i >= secondArray.Length)
                    {
                        break;
                    }
                    Console.Write(maxArr + " ");
                }
            }

            else
            {
                for (var i = 0; i <= arr.Length; i++)
                {
                    var maxArr = (arr[i % arr.Length] + secondArray[i % secondArray.Length]);

                    if (i >= arr.Length)
                    {
                        break;
                    }
                    Console.Write(maxArr + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
