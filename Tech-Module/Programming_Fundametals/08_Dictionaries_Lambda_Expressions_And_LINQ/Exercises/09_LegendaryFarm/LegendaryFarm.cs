namespace _09_LegendaryFarm
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LegendaryFarm
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var junkItems = new Dictionary<string, int>();
            var specialItems = new Dictionary<string, int>();

            var shards = 0;
            var fragments = 0;
            var motes = 0;

            specialItems.Add("motes", 0);
            specialItems.Add("fragments", 0);
            specialItems.Add("shards", 0);

            while (shards <= 250 || fragments <= 250 || motes <= 250)
            {
                for (var i = 0; i < input.Count - 1; i += 2)
                {
                    var quantity = int.Parse(input[i]);
                    var material = (input[i + 1]).ToLower();

                    if (material != "shards" && material != "motes" && material != "fragments")
                    {
                        AddingJunkItems(junkItems, material, quantity);
                    }

                    if (material == "motes")
                    {
                        specialItems[material] += quantity;
                        motes += quantity;

                        if (motes < 250) continue;

                        Console.WriteLine("Dragonwrath obtained!");
                        PrintResult(specialItems, junkItems, material);

                        return;
                    }
                    else if (material == "fragments")
                    {
                        specialItems[material] += quantity;
                        fragments += quantity;

                        if (fragments < 250) continue;

                        Console.WriteLine("Valanyr obtained!");
                        PrintResult(specialItems, junkItems, material);

                        return;
                    }
                    else if (material == "shards")
                    {
                        specialItems[material] += quantity;
                        shards += quantity;

                        if (shards < 250) continue;

                        Console.WriteLine("Shadowmourne obtained!");
                        PrintResult(specialItems, junkItems, material);

                        return;
                    }
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
        }

        public static void PrintResult(Dictionary<string, int> specialItems, Dictionary<string, int> junkItems, string material)
        {
            specialItems[material] -= 250;

            foreach (var item in specialItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static void AddingJunkItems(Dictionary<string, int> junkItems, string material, int quantity)
        {
            if (!junkItems.ContainsKey(material))
            {
                junkItems.Add(material, quantity);
            }
            else
            {
                junkItems[material] += quantity;
            }
        }
    }
}
