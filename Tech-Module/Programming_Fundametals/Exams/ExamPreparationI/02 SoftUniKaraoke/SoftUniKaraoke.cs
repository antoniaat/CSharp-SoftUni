namespace _02_SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var songs = Console.ReadLine()
                .Split(',')
                .Select(s => s.Trim())
                .ToList();

            var performance = Console.ReadLine()
                .Split(',')
                .Select(s => s.Trim())
                .ToList();

            var awardsDict = new Dictionary<string, List<string>>();

            while (performance[0] != "dawn")
            {
                var participant = performance[0];
                var song = performance[1];
                var award = performance[2];

                if (participants.Contains(participant))
                {
                    if (songs.Contains(song))
                    {
                        if (!awardsDict.ContainsKey(participant))
                        {
                            awardsDict.Add(participant, new List<string>());
                        }
                        if (!awardsDict[participant].Contains(award))
                        {
                            awardsDict[participant].Add(award);
                        }
                    }
                }

                performance = Console.ReadLine()
                    .Split(',')
                    .Select(s => s.Trim())
                    .ToList();
            }

            var sortByAwards = awardsDict
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var name in sortByAwards)
            {
                Console.WriteLine($"{name.Key}: {name.Value.Count} awards");

                foreach (var kvp in name.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{kvp}");
                }
            }

            if (sortByAwards.Values.Count == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
