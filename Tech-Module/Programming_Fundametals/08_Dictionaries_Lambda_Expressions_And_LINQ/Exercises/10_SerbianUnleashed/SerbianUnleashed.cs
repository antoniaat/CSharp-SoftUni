namespace _10_Serbian_Unleashed
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class SerbianUnleashed
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, Dictionary<string, int>>();

            while (input != "End")
            {
                var pattern = @"(\D+)\s@(\D+)\s(\d+)\s(\d+)";
                var regex = new Regex(pattern);
                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    var singer = match.Groups[1].ToString();
                    var venue = match.Groups[2].ToString();
                    var ticketsPrice = int.Parse(match.Groups[3].ToString());
                    var ticketsCount = int.Parse(match.Groups[4].ToString());

                    var singerLenght = singer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var venueLenght = venue.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    if ((singerLenght.Count > 0 && singerLenght.Count <= 3) && (venueLenght.Count > 0 && venueLenght.Count <= 3))
                    {
                        var money = ticketsCount * ticketsPrice;

                        if (!dict.ContainsKey(venue))
                        {
                            dict.Add(venue, new Dictionary<string, int>());
                            dict[venue].Add(singer, money);
                        }
                        else
                        {
                            if (!dict[venue].ContainsKey(singer))
                            {
                                dict[venue].Add(singer, money);
                            }
                            else
                            {
                                dict[venue][singer] += money;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var towns in dict)
            {
                Console.WriteLine($"{towns.Key}");

                foreach (var singers in towns.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singers.Key} -> {singers.Value}");
                }
            }
        }
    }
}
