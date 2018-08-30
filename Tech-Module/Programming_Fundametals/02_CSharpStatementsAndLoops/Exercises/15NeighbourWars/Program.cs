using System;

namespace _15NeighbourWars
{
    // Program, which calculates who would win the fight. 
    public class Program
    {
        private static int round;
        private static int goshoHealth = 100;
        private static int peshoHealth = 100;

        public static void Main()
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            StartFight(peshoDamage, goshoDamage);
        }

        private static void StartFight(int peshoDamage, int goshoDamage)
        {
            for (var i = 1; i <= 100; i++)
            {
                round++;

                // Gosho attacks with “Thunderous fist” on every even turn of the game
                if (i % 2 == 0)
                {
                    ThunderousFistAttack(peshoHealth, goshoDamage, goshoHealth);
                }

                // Pesho attacks with “Roundhouse kick” on every odd turn.
                else
                {
                    RoundhouseKickAttack(peshoDamage, peshoHealth, goshoHealth);
                }

                // On every third turn Pesho and Gosho restore 10 Health Points. 
                if (i % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }

        private static void RoundhouseKickAttack(int peshoDamage, int peshoHealth, int goshoHealth)
        {
            goshoHealth -= peshoDamage;

            if (peshoHealth <= 0 || goshoHealth <= 0)
            {
                if (peshoHealth > goshoHealth)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    return;
                }
                else if (goshoHealth > peshoHealth)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    return;
                }
            }

            Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
        }

        private static void ThunderousFistAttack(int peshoHealth, int goshoDamage, int goshoHealth)
        {
            peshoHealth -= goshoDamage;

            if (peshoHealth <= 0 || goshoHealth <= 0)
            {
                if (peshoHealth > goshoHealth)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    return;
                }

                else if (goshoHealth > peshoHealth)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    return;
                }
            }

            Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
        }
    }
}
