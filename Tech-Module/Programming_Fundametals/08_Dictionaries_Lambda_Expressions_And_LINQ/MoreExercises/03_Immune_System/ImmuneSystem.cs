namespace _03_Immune_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ImmuneSystem
    {
        public static void Main()
        {
            var input = long.Parse(Console.ReadLine());
            var inputDouble = 0L;
            inputDouble = input;
            var immuneSystemHealth = 0L;
            immuneSystemHealth = inputDouble;
            var virus = Console.ReadLine().ToList(); ;
            var foughtVirusesDict = new Dictionary<string, long>();
            while (string.Join("", virus) != "end")
            {
                var virusTimeToDefeatSeconds = 0L;

                var virusStrenghtCalculated = virus.Aggregate(0, (current1, current) => current1 + current);
                virusStrenghtCalculated /= 3;

                virusTimeToDefeatSeconds = virusStrenghtCalculated * virus.Count();

                if (!foughtVirusesDict.ContainsKey(string.Join("", virus)))
                {
                    foughtVirusesDict[string.Join("", virus)] = virusTimeToDefeatSeconds;
                }
                else
                {
                    virusTimeToDefeatSeconds = foughtVirusesDict[string.Join("", virus)] / 3;
                }

                var seconds = virusTimeToDefeatSeconds % 60;
                var minutes = virusTimeToDefeatSeconds / 60;
                Convert.ToInt32(immuneSystemHealth);
                immuneSystemHealth -= virusTimeToDefeatSeconds;

                if (immuneSystemHealth > 0)
                {
                    Console.WriteLine($"Virus {string.Join("", virus)}: {virusStrenghtCalculated} => {virusTimeToDefeatSeconds} seconds" +
                                      $"\n{string.Join("", virus)} defeated in {minutes}m {seconds}s.\nRemaining health: {immuneSystemHealth}");

                    var percentCalculation = +immuneSystemHealth * 0.20;
                    immuneSystemHealth += (long)percentCalculation;
                    if (immuneSystemHealth > inputDouble)
                    {
                        immuneSystemHealth = inputDouble;
                    }
                }
                else
                {
                    Console.WriteLine($"Virus {string.Join("", virus)}: {virusStrenghtCalculated} => {virusTimeToDefeatSeconds} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                virus = Console.ReadLine().ToList();
            }
            Console.WriteLine($"Final Health: {immuneSystemHealth}");
        }
    }
}
