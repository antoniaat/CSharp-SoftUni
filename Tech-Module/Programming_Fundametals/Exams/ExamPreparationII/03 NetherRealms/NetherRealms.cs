namespace _03_NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var demonsDict = new SortedDictionary<string, Dictionary<decimal, decimal>>();

            foreach (var demon in demons)
            {
                var health = 0;

                if (!demonsDict.ContainsKey(demon))
                {
                    demonsDict.Add(demon, new Dictionary<decimal, decimal>());
                }

                var healtRegex = Regex.Matches(demon, @"([^0-9+-.*,\/])");

                foreach (Match matches in healtRegex)
                {
                    health += char.Parse(matches.ToString());
                }

                decimal damage = 0;

                var damageRegex = Regex.Matches(demon, @"(-*[0-9.]*[0-9])");

                foreach (Match matches in damageRegex)
                {
                    damage += decimal.Parse(matches.ToString());
                }

                if (demon.Contains("*"))
                {
                    var count = demon.Count(f => f == '*');

                    for (var j = 1; j <= count; j++)
                    {
                        damage = damage * 2;
                    }
                }

                if (demon.Contains("/"))
                {
                    var count = demon.Count(f => f == '/');

                    for (var j = 1; j <= count; j++)
                    {
                        damage = damage / 2;
                    }
                }

                demonsDict[demon].Add(health, damage);
            }

            PrintResult(demonsDict);
        }

        public static void PrintResult(SortedDictionary<string, Dictionary<decimal, decimal>> demonsDict)
        {
            foreach (var kvp in demonsDict)
            {
                Console.Write($"{kvp.Key} - ");

                foreach (var values in kvp.Value)
                {
                    Console.WriteLine($"{values.Key} health, {values.Value:f2} damage");
                }
            }
        }
    }
}