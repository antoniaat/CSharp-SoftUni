namespace RainAir
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RainAir
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, List<int>>();

            while (input != "I believe I can fly!")
            {
                var list = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var customerName = list[0];

                if (input.Contains("="))
                {
                    var customer2Name = list[2];
                    dict[customerName].Clear();
                    var copyValues = new List<int>(dict[customer2Name]);
                    dict[customerName].AddRange(copyValues);
                }
                else
                {
                    for (var l = 1; l < list.Count; l++)
                    {
                        var customerFlight1 = int.Parse(list[l]);

                        if (!dict.ContainsKey(customerName))
                        {
                            dict.Add(customerName, new List<int>());
                        }
                        dict[customerName].Add(customerFlight1);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in dict.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.Write($"#{kvp.Key} ::: ");
                Console.WriteLine(string.Join(", ", kvp.Value.OrderByDescending(x=>x).Reverse()));
            }
        }
    }
}
