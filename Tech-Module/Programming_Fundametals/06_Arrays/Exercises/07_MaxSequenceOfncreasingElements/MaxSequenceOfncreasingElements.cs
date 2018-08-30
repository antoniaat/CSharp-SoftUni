namespace _07_MaxSequenceOfncreasingElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfncreasingElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var lenght = numbers.Length;

            MaxIncSequence(numbers, lenght);
        }

        public static void MaxIncSequence(int[] numbers, int lenght)
        {
            var cntCurrSeq = 0;
            var cntMaxSeq = 0;
            var startMaxSeq = 0;

            for (var i = 1; i < lenght; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    cntCurrSeq++;
                    var startCurrSeq = i - cntCurrSeq;

                    if (cntCurrSeq > cntMaxSeq)
                    {
                        cntMaxSeq = cntCurrSeq;
                        startMaxSeq = startCurrSeq;
                    }
                }
                else
                {
                    cntCurrSeq = 0;
                }
            }

            for (var iWrite = startMaxSeq; iWrite <= (startMaxSeq + cntMaxSeq); iWrite++)
            {
                Console.Write(numbers[iWrite] + " ");
            }

            Console.WriteLine();
        }
    }
}