using System.Collections.Generic;

namespace _03_Hornet_Assault
{
    using System;
    using System.Linq;

    public class Hornet_Assault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            var hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                long beehiveCount = beehives[i];
                long hornetPower = SumHornetsPower(hornets);
                beehives[i] -= hornetPower;

                if (beehiveCount >= hornetPower)
                {
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Any(bh => bh > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(bh => bh > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }

        public static long SumHornetsPower(List<long> hornets)
        {
            long sum = 0L;

            foreach (var hornet in hornets)
            {
                sum += hornet;
            }

            return sum;
        }
    }
}
