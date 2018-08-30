namespace _04_Worms_World_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WormsWorldParty
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var worms = new Dictionary<string, Dictionary<string, long>>();

            while (input != "quit")
            {
                var inputLine = input
                    .Split(new char[] {'>', '-'}, StringSplitOptions.RemoveEmptyEntries);

                var wormName = inputLine[0].Trim();
                var teamName = inputLine[1].Trim();
                var wormScore = long.Parse(inputLine[2].Trim());
                var invalidLine = false;

                foreach (var kvp in worms.Values)
                {
                    if (kvp.ContainsKey(wormName))
                        invalidLine = true;
                }

                if (invalidLine == false)
                {
                    if (!worms.ContainsKey(teamName))
                    {
                        worms.Add(teamName, new Dictionary<string, long>());
                    }
                    worms[teamName].Add(wormName, wormScore);
                }

                input = Console.ReadLine();
            }

            PrintResult(worms);
        }

        public static void PrintResult(Dictionary<string, Dictionary<string, long>> worms)
        {
            var count = 1;

            foreach (var kvp in worms.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Sum() / x.Value.Values.Count))
            {
                Console.WriteLine($"{count}. Team: {kvp.Key} - {kvp.Value.Values.Sum()}");
                count++;
                foreach (var kvpValues in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{kvpValues.Key} : {kvpValues.Value}");
                }
            }
        }
    }
}