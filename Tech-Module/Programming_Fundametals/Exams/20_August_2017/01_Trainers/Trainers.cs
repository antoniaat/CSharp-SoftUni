namespace _01_Trainers
{
    using System;

    public class Trainers
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var bestTeam = string.Empty;
            var bestTotalSum = 0M;

            for (var i = 0; i < n; i++)
            {
                var distance = long.Parse(Console.ReadLine());
                var cargo = decimal.Parse(Console.ReadLine());
                var team = Console.ReadLine();

                var participantEarnedMoney = (cargo * 1000 * 1.5M) - (0.7M * distance * 1600 * 2.5M);

                if (participantEarnedMoney <= bestTotalSum) continue;

                bestTotalSum = participantEarnedMoney;
                bestTeam = team;
            }

            Console.WriteLine($"The {bestTeam} Trainers win with ${bestTotalSum:f3}.");
        }
    }
}
