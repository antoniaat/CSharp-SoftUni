using System;
using System.Linq;

namespace _03_Wormhole
{
    public class Wormhole
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var steps = 0;

            for (var i = 0; i < input.Count; i++)
            {
                steps++;
                if (input[i] == 0) continue;
                var newIndex = input[i];
                input[i] = 0;
                i = newIndex;
            }

            Console.WriteLine(steps);
        }
    }
}
