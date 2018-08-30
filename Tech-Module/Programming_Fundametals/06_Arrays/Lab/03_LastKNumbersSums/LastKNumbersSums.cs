namespace _03.LastKNumbersSums
{
    using System;

    public class LastKNumbersSums
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var seq = new int[n];
            seq[0] = 1;

            for (var i = 1; i < n; i++)
            {
                var sum = 0;

                for (var prev = i - k; prev <= i-1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += seq[prev];
                    }
                    seq[i] = sum;
                }
            }

            for (var i = 0; i < n; i++)
            {
                Console.Write(seq[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
