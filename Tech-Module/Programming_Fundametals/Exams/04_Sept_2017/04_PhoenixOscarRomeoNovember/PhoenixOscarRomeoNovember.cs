using System;
using System.Collections.Generic;
using System.Linq;

public class PhoenixOscarRomeoNovember
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var allCreatures = new Dictionary<string, List<string>>();

        AddCreatures(allCreatures, input);
        RemoveCreatures(allCreatures);
        PrintCreatures(allCreatures);
    }

    public static void PrintCreatures(Dictionary<string, List<string>> allCreatures)
    {
        foreach (var kvp in allCreatures.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value.Count}");
        }
    }

    public static void RemoveCreatures(Dictionary<string, List<string>> allCreatures)
    {
        foreach (var kvp in allCreatures)
        {
            foreach (var lists in kvp.Value.ToList())
            {
                if (!allCreatures.ContainsKey(lists)) continue;
                if (!allCreatures[lists].Contains(kvp.Key)) continue;

                allCreatures[kvp.Key].Remove(lists);
                allCreatures[lists].Remove(kvp.Key);
            }
        }
    }

    public static void AddCreatures(Dictionary<string, List<string>> allCreatures, string input)
    {
        while (input != "Blaze it!")
        {
            var splitInput = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            var creature = splitInput[0];
            var squadMate = splitInput[1];

            if (creature != squadMate)
            {
                if (!allCreatures.ContainsKey(creature))
                {
                    allCreatures.Add(creature, new List<string>());
                }

                if (!allCreatures[creature].Contains(squadMate))
                {
                    allCreatures[creature].Add(squadMate);
                }
            }

            input = Console.ReadLine();
        }
    }
}
