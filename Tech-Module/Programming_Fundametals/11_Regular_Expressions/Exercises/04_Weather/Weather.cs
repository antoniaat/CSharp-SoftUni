using System.Collections.Generic;
using System.Linq;

namespace _04_Weather
{
    using System;
    using System.Text.RegularExpressions;

    public class Weather
    {
        public static void Main()
        {
            string pattern = @"([A-Z]{2})([\d]+.\d+)([A-Za-z]+[|])";

            string input = Console.ReadLine();

            Dictionary<string, Dictionary<double, string>> weatherDictionary = new Dictionary<string, Dictionary<double, string>>();

            while (input != "end")
            {
                MatchCollection result = Regex.Matches(input, pattern);

                foreach (Match matches in result)
                {
                    var city = matches.Groups[1].ToString();
                    var temperature = double.Parse(matches.Groups[2].ToString());
                    var weather = matches.Groups[3].ToString().Replace("|", "");

                    if (!weatherDictionary.ContainsKey(city))
                    {
                        weatherDictionary.Add(matches.Groups[1].ToString(), new Dictionary<double, string>());
                        weatherDictionary[city].Add(temperature, weather);
                    }
                    if (weatherDictionary.ContainsKey(city))
                    {
                        weatherDictionary[city].Clear();
                        weatherDictionary[city].Add(temperature, weather);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var keyValuePair in weatherDictionary.OrderBy(x => x.Value.Keys.First()))
            {
                Console.Write($"{keyValuePair.Key} => ");

                foreach (var temp in keyValuePair.Value)
                {
                    Console.WriteLine($"{temp.Key:f2} => {temp.Value}");
                }
            }
        }
    }
}
