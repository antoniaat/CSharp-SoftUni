using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_AnonymousCache
{
    public class AnonymousCache
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictDataSets = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                if (input != null && input.Contains("->"))
                {
                    AddingDataKeyAndDataSize(input, dictDataSets, cache);
                }
                else
                {
                    AddNewDataSet(input, dictDataSets, cache);
                }

                input = Console.ReadLine();
            }

            PrintResult(dictDataSets);
        }

        public static void AddNewDataSet(string input, Dictionary<string, Dictionary<string, long>> dictDataSets,
            Dictionary<string, Dictionary<string, long>> cache)
        {
            var dataSet = input.Trim();
            dictDataSets.Add(dataSet, new Dictionary<string, long>());

            if (!cache.ContainsKey(dataSet)) return;
            foreach (var kvp in cache[dataSet])
            {
                dictDataSets[dataSet].Add(kvp.Key, kvp.Value);
            }
        }

        public static void AddingDataKeyAndDataSize(string input,
            Dictionary<string, Dictionary<string, long>> dictDataSets, Dictionary<string, Dictionary<string, long>> cache)
        {
            var inputLine = input.Split(new[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);
            var dataKey = inputLine[0];
            var dataSize = long.Parse(inputLine[1]);
            var dataSet = inputLine[2];

            if (dictDataSets.ContainsKey(dataSet))
            {
                dictDataSets[dataSet].Add(dataKey, dataSize);
            }
            else
            {
                if (!cache.ContainsKey(dataSet))
                {
                    cache.Add(dataSet, new Dictionary<string, long>());
                }
                cache[dataSet].Add(dataKey, dataSize);
            }
        }

        public static void PrintResult(Dictionary<string, Dictionary<string, long>> dictDataSets)
        {
            foreach (var kvp in dictDataSets.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {kvp.Key}, Total Size: {kvp.Value.Values.Sum()}");
                foreach (var users in kvp.Value)
                {
                    Console.WriteLine($"$.{users.Key}");
                }
                break;
            }
        }
    }
}