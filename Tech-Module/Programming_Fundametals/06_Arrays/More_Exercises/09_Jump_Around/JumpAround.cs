using System.Collections.Generic;

namespace _09_Jump_Around
{
    using System;
    using System.Linq;

    public class JumpAround
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            long maxIndex = array.Length - 1;

            long sum = 0;
            long index = 0;

            while (true)
            {
                sum += array[index];

                var nextIndex = index + array[index];

                if (nextIndex <= maxIndex)
                {
                    index = nextIndex;
                    continue;
                }

                nextIndex = index - array[index];
                if (nextIndex >= 0)
                {
                    index = nextIndex;
                    continue;
                }

                break;
            }

            Console.WriteLine(sum);
        }
    }
}
