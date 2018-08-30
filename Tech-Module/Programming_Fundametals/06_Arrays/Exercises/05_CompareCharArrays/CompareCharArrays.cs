namespace _05_CompareCharArrays
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            var secondArray = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            if (secondArray.Length < firstArray.Length)
            {
                Console.WriteLine(secondArray);
                Console.WriteLine(firstArray);
            }
            else if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine(firstArray);
                Console.WriteLine(secondArray);
            }
            else
            {
                var smallerLenght = Math.Min(firstArray.Length, secondArray.Length);

                for (int i = 0; i < smallerLenght; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        Console.WriteLine(secondArray);
                        Console.WriteLine(secondArray);
                        break;
                    }
                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine(secondArray);
                        Console.WriteLine(firstArray);
                        break;
                    }
                    if (secondArray[i] > firstArray[i])
                    {
                        Console.WriteLine(firstArray);
                        Console.WriteLine(secondArray);
                        break;
                    }
                }
            }
        }
    }
}