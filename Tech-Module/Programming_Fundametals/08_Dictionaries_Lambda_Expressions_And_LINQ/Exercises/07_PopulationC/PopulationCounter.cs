namespace _07_PopulationC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var inputList = Console.ReadLine()
                .Split('|')
                .ToList();

            var populationDictionary = new Dictionary<string, Dictionary<string, long>>();

            while (inputList[0] != "report")
            {
                var city = inputList[0];
                var country = inputList[1];
                var population = long.Parse(inputList[2]);

                if (!populationDictionary.ContainsKey(country))
                {
                    populationDictionary.Add(country, new Dictionary<string, long>());

                }
                if (!populationDictionary[country].ContainsKey(city))
                {
                    populationDictionary[country].Add(city, 0);
                }

                populationDictionary[country][city] += population;

                inputList = Console.ReadLine()
                    .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            foreach (var keyValuePair in populationDictionary.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{keyValuePair.Key} (total population: {keyValuePair.Value.Values.Sum()})");

                foreach (var item in keyValuePair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{item.Key}: {item.Value}");
                }
            }
        }
    }
}
