namespace Raincast
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Raincast
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var typePattern = @"^Type: (Normal|Warning|Danger)$";
            var sourcePattern = @"^Source: ([A-Za-z0-9]+)$";
            var forecastPattern = @"^Forecast: ([^.?!,]+)$";
            var raincastList = new List<string>();
            var validRaincast = string.Empty;
            var counter = 0;
            var type = string.Empty;
            var forecast = string.Empty;
            var source = string.Empty;

            var currentRaincast = "type";

            while (input != "Davai Emo")
            {
                if (currentRaincast  == "type")
                {
                    if (Regex.IsMatch(input, typePattern))
                    {
                        Regex regex = new Regex(typePattern);
                        Match match = regex.Match(input);
                        type = match.Groups[1].Value;
                        counter++;
                        currentRaincast  = "source";
                    }
                }

                else if (currentRaincast  == "source")
                {
                    if (Regex.IsMatch(input, sourcePattern))
                    {
                        Regex regex = new Regex(sourcePattern);
                        Match match = regex.Match(input);
                        source = match.Groups[1].Value;
                        counter++;
                        currentRaincast  = "forecast";
                    }
                }

                else if (currentRaincast  == "forecast")
                {
                    if (Regex.IsMatch(input, forecastPattern))
                    {
                        Regex regex = new Regex(forecastPattern);
                        Match match = regex.Match(input);
                        forecast = match.Groups[1].Value;
                        counter++;
                        currentRaincast  = "type";
                    }
                }

                if (counter == 3)
                {
                    validRaincast += $"({type}) {forecast} ~ {source}";
                    counter = 0;
                    raincastList.Add(validRaincast);
                    validRaincast = string.Empty;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", raincastList));
        }
    }
}