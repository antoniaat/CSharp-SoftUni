namespace _04_Trainlands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Trainlands
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var allTrains = new Dictionary<string, Dictionary<string, int>>();

            while (input != "It's Training Men!")
            {
                if (input.Contains("->"))
                {
                    var inputLine = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                    if (inputLine.Length > 2)
                    {
                        CreateWagons(input, inputLine, allTrains);
                    }

                    else
                    {
                        AddExistingWagons(inputLine, allTrains);
                    }
                }

                else if (input.Contains("="))
                {
                    AddAndRemoveWagons(allTrains, input);
                }

                input = Console.ReadLine();
            }

            PrintTrains(allTrains);
        }

        public static void AddExistingWagons(string[] inputLine, Dictionary<string, Dictionary<string, int>> allTrains)
        {
            var trainName = inputLine[0];
            var otherTrainName = inputLine[1];

            if (allTrains.ContainsKey(trainName))
            {
                foreach (var kvp in allTrains[otherTrainName])
                {
                    allTrains[trainName].Add(kvp.Key, kvp.Value);
                }

                allTrains.Remove(otherTrainName);
            }

            else
            {
                allTrains.Add(trainName, new Dictionary<string, int>());
                foreach (var kvp in allTrains[otherTrainName])
                {
                    allTrains[trainName].Add(kvp.Key, kvp.Value);
                }
                allTrains.Remove(otherTrainName);
            }
        }

        public static void CreateWagons(string input, string[] inputLine, Dictionary<string, Dictionary<string, int>> allTrains)
        {
            inputLine = input.Split(new char[] { ' ', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
            var trainName = inputLine[0];
            var wagonName = inputLine[1];
            var wagonPower = int.Parse(inputLine[2]);

            if (!allTrains.ContainsKey(trainName))
            {
                allTrains.Add(trainName, new Dictionary<string, int>());
            }

            allTrains[trainName].Add(wagonName, wagonPower);
        }

        public static void AddAndRemoveWagons(Dictionary<string, Dictionary<string, int>> allTrains, string input)
        {
            var inputLine = input.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            var trainName = inputLine[0];
            var otherTrainName = inputLine[1];

            if (allTrains.ContainsKey(trainName))
            {
                allTrains[trainName].Clear();

                foreach (var kvp in allTrains[otherTrainName])
                {
                    allTrains[trainName].Add(kvp.Key, kvp.Value);
                }
            }

            else
            {
                allTrains.Add(trainName, new Dictionary<string, int>());
                foreach (var kvp in allTrains[otherTrainName])
                {
                    allTrains[trainName].Add(kvp.Key, kvp.Value);
                }
            }
        }

        public static void PrintTrains(Dictionary<string, Dictionary<string, int>> allTrains)
        {
            foreach (var kvp in allTrains.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Values.Count))
            {
                Console.WriteLine($"Train: {kvp.Key}");

                foreach (var dict in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{dict.Key} - {dict.Value}");
                }
            }
        }
    }
}
