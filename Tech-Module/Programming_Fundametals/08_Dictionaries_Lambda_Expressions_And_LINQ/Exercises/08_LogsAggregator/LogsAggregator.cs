namespace _08_LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var logsAggregatorDict = new Dictionary<string, Dictionary<string, long>>();
            var inputList = new List<string>();

            for (var lines = 1; lines <= n; lines++)
            {
                inputList = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var ipAdress = inputList[0];
                var name = inputList[1];
                var duration = long.Parse(inputList[2]);

                if (!logsAggregatorDict.ContainsKey(name))
                {
                    logsAggregatorDict.Add(name, new Dictionary<string, long>());
                }

                if (!logsAggregatorDict[name].ContainsKey(ipAdress))
                {
                    logsAggregatorDict[name].Add(ipAdress, 0);
                }

                logsAggregatorDict[name][ipAdress] += duration;
            }

            foreach (var keyValuePair in logsAggregatorDict.OrderBy(x => x.Key))
            {
                Console.Write($"{keyValuePair.Key}: {keyValuePair.Value.Values.Sum()} ");
                Console.Write("[");
                var counter = 0;

                foreach (var item in keyValuePair.Value.OrderBy(x => x.Key))
                {
                    counter++;
                    if (counter == keyValuePair.Value.Count)
                    {
                        Console.Write($"{item.Key}");
                    }
                    else
                    {
                        Console.Write($"{item.Key}, ");
                    }
                }
                Console.WriteLine("]");
            }
        }
    }
}