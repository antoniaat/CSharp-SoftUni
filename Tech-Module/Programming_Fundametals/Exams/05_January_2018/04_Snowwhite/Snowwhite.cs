namespace _04_Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Snowwhite
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var list = new List<Tuple<string, string, uint>>();

            while (input != "Once upon a time")
            {
                var inputLine = input
                    .Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var dwarfName = inputLine[0];
                var dwarfHatColor = inputLine[1];
                var dwarfPhysics = uint.Parse(inputLine[2]);
                list.Add(new Tuple<string, string, uint>(dwarfName, dwarfHatColor, dwarfPhysics));
                input = Console.ReadLine();
            }

            foreach (var kvp in list.ToList())
            {
                foreach (var kvp2 in list.ToList())
                {
                    if (kvp.Item1 != kvp2.Item1 || kvp.Item2 != kvp2.Item2 || Equals(kvp, kvp2)) continue;
                    var max = Math.Max(kvp.Item3, kvp2.Item3);
                    list.Add(new Tuple<string, string, uint>(kvp2.Item1, kvp2.Item2, max));
                    list.Remove(kvp);
                    list.Remove(kvp2);
                }
            }

            foreach (var kvp in list.OrderByDescending(x => x.Item3).ThenByDescending(x => list.Count(y => y.Item2 == x.Item2)))
            {
                Console.Write($"({kvp.Item2}) ");
                Console.WriteLine($"{kvp.Item1} <-> {kvp.Item3}");
            }
        }
    }
}
