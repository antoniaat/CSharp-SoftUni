namespace _06_Heists
{
    using System;
    using System.Linq;

    public class Heists
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var jewelsPrice = array[0];
            var goldPrice = array[1];

            var lootAndExpenses = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var totalExpenses = 0D;
            var totalEarnings = 0D;

            while (lootAndExpenses[0] != "Jail" && lootAndExpenses[1] != "Time")
            {
                var loot = lootAndExpenses[0];
                var heistExpenses = int.Parse(lootAndExpenses[1]);
                var jewelsCount = 0;
                var goldCount = 0;

                if (loot.Contains('%') || loot.Contains('$'))
                {
                    for (int i = 0; i < loot.Length; i++)
                    {
                        if (loot[i] == '%')
                        {
                            jewelsCount++;
                        }
                        if (loot[i] == '$')
                        {
                            goldCount++;
                        }
                    }

                    totalEarnings += (jewelsCount * jewelsPrice) + (goldCount * goldPrice);
                    totalExpenses += heistExpenses;
                }
                else
                {
                    totalExpenses += heistExpenses;
                }

                lootAndExpenses = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpenses}.");
            }
            else if (totalExpenses > totalEarnings)
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses- totalEarnings}.");
            }
        }
    }
}
