namespace _04_HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetArmada
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var legionWithSoldiers = new Dictionary<string, Dictionary<string, long>>();
            var legionWithActivity = new Dictionary<string, long>();

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                long lastActivity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                if (!legionWithSoldiers.ContainsKey(legionName))
                {
                    legionWithSoldiers.Add(legionName, new Dictionary<string, long>());
                    legionWithActivity.Add(legionName, lastActivity);
                }

                if (legionWithSoldiers.ContainsKey(legionName))
                {
                    if (legionWithSoldiers[legionName].ContainsKey(soldierType))
                    {
                        legionWithSoldiers[legionName][soldierType] += soldierCount;
                    }
                    else
                    {
                        legionWithSoldiers[legionName].Add(soldierType, soldierCount);
                    }
                }

                if (legionWithActivity[legionName] < lastActivity)
                {
                    legionWithActivity[legionName] = lastActivity;
                }
            }

            PrintResult(legionWithSoldiers, legionWithActivity);
        }

        public static void PrintResult(Dictionary<string, Dictionary<string, long>> legionWithSoldiers, Dictionary<string, long> legionWithActivity)
        {
            var lastRow = Console.ReadLine();

            if (lastRow.Contains('\\'))
            {
                var tokens = lastRow.Split('\\');
                var lastActivity = long.Parse(tokens[0]);
                var soldierType = tokens[1];

                var legionsWithLowerActivity = legionWithSoldiers
                    .Where(x => legionWithActivity[x.Key] < lastActivity)
                    .Where(x => x.Value.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Value[soldierType])
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in legionsWithLowerActivity)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value[soldierType]}");
                }
            }

            else
            {
                var sortedLegions = legionWithSoldiers
                    .Where(x => x.Value.ContainsKey(lastRow))
                    .OrderByDescending(x => legionWithActivity[x.Key])
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var legions in sortedLegions)
                {
                    Console.WriteLine($"{legionWithActivity[legions.Key]} : {legions.Key}");
                }
            }
        }
    }
}
