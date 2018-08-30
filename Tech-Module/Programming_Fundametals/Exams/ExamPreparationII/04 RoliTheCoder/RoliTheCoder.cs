namespace _04_RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class RoliTheCoder
    {
        public static void Main()
        {
            var events = new SortedDictionary<long, string>();

            var listWithParticapnts = new SortedDictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "Time for Code")
            {
                var idAndName = Regex.Matches(input, @"(^[0-9]+)\s*([#{1}\w]*)");
                var participantRegex = Regex.Matches(input, @"(@{1}[\w'-]*)+");

                foreach (Match matches in idAndName)
                {
                    var id = long.Parse(matches.Groups[1].ToString());
                    var eventName = matches.Groups[2].ToString();
                    eventName = eventName.Substring(1);

                    if (!events.ContainsKey(id))
                    {
                        events.Add(id, eventName);
                        listWithParticapnts.Add(eventName, new List<string>());
                    }

                    foreach (Match match in participantRegex)
                    {
                        if (listWithParticapnts.ContainsKey(eventName))
                        {
                            if (!listWithParticapnts[eventName].Contains(match.ToString()))
                            {
                                listWithParticapnts[eventName].Add(match.ToString());
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            PrintResult(listWithParticapnts);
        }

        public static void PrintResult(SortedDictionary<string, List<string>> listWithParticapnts)
        {
            foreach (var kvp in listWithParticapnts.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value.Count}");

                foreach (var participant in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}