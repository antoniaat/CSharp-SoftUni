using System;

namespace _05CharacterStats
{
    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var leftHealth = maxHealth - currentHealth;
            var leftEnergy = maxEnergy - currentEnergy;

            PrintGraphics(name, currentHealth, leftHealth, currentEnergy, leftEnergy);
        }

        private static void PrintGraphics(string name, int currentHealth, int leftHealth, int currentEnergy, int leftEnergy)
        {
            Console.WriteLine($"Name: {name}");

            Console.Write("Health: ");
            Console.Write(new string('|', 1));
            Console.Write(new string('|', currentHealth));
            Console.Write(new string('.', leftHealth));
            Console.WriteLine(new string('|', 1));

            Console.Write("Energy: ");
            Console.Write(new string('|', 1));
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', leftEnergy));
            Console.WriteLine(new string('|', 1));
        }
    }
}