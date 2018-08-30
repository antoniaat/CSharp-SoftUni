namespace _03_EnduranceRally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var zones = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            var checkpointIndexes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < drivers.Count; i++)
            {
                char driverFirstLetter = drivers[i].First();
                var startPower = (decimal)driverFirstLetter;

                for (int z = 0; z < zones.Count; z++)
                {
                    if (checkpointIndexes.Contains(z))
                    {
                        startPower += zones[z];
                    }
                    else
                    {
                        startPower -= zones[z];
                    }

                    if (startPower <= 0)
                    {
                        Console.WriteLine($"{drivers[i]} - reached {z}");
                        break;
                    }
                }

                if (startPower > 0)
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {startPower:f2}");
                }
            }
        }
    }
}
