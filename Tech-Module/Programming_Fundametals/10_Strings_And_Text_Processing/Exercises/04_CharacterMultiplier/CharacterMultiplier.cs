namespace _04_CharacterMultiplier
{
    using System;
    using System.Linq;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var firstArray = input[0].ToCharArray();
            var secondArray = input[1].ToCharArray();
            var totalSum = 0;
            var longerArray = Math.Max(firstArray.Length, secondArray.Length);

            if (firstArray.Length != secondArray.Length)
            {
                for (int i = 0; i < longerArray; i++)
                {
                    longerArray = Math.Max(firstArray.Length, secondArray.Length);

                    if (firstArray.Length == 0 || secondArray.Length == 0)
                    {
                        if (firstArray.Length > secondArray.Length)
                        {
                            totalSum += firstArray[i];
                            continue;
                        }
                        else
                        {
                            totalSum += secondArray[i];
                            continue;
                        }
                    }

                    totalSum += firstArray[i] * secondArray[i];
                    firstArray = firstArray.Skip(1).ToArray();
                    secondArray = secondArray.Skip(1).ToArray();
                    i--;
                }
            }

            else
            {
                for (int i = 0; i < longerArray; i++)
                {
                    totalSum += firstArray[i] * secondArray[i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
