namespace Rainer
{
    using System;
    using System.Linq;

    public class Rainer
    {
        public static void Main()
        {
            var inputSeq = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var initialIndex = inputSeq.Last();
            var step = initialIndex;
            inputSeq.RemoveAt(inputSeq.Count - 1);
            var countSteps = 0;

            var originalValues = inputSeq.ToList();

            while (true)
            {
                for (var i = 0; i < inputSeq.Count; i++)
                {
                    inputSeq[i]--;
                }

                for (var i = 0; i < inputSeq.Count; i++)
                {
                    if (inputSeq[i] == 0)
                    {
                        if (i == step)
                        {
                            Console.WriteLine(string.Join(" ", inputSeq));
                            Console.WriteLine(countSteps);
                            return;
                        }
                    }
                }

                for (var i = 0; i < inputSeq.Count; i++)
                {
                    if (inputSeq[i] == 0)
                    {
                        if (i != step)
                        {
                            inputSeq[i] = originalValues[i];
                        }
                    }
                }

                step = int.Parse(Console.ReadLine());
                countSteps++;
            }
        }
    }
}
