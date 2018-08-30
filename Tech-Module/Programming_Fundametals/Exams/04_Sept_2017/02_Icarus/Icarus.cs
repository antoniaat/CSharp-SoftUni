namespace _02_Icarus
{
    using System;
    using System.Linq;

    public class Icarus
    {
        public static void Main()
        {
            var seq = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToList();

            var startPosition = int.Parse(Console.ReadLine());
            var initialDamage = 1;

            var input = Console.ReadLine();

            var currentIndex = startPosition;

            while (input != "Supernova")
            {
                var command = input.Split(' ');
                var direcion = command[0];
                var steps = int.Parse(command[1]);

                if (direcion == "left")
                {
                    for (var i = 0; i < steps; i++)
                    {
                        currentIndex--;

                        if (currentIndex == -1)
                        {
                            currentIndex = seq.Count - 1;
                            initialDamage++;
                        }

                        seq[currentIndex] -= initialDamage;
                    }
                }
                else if (direcion == "right")
                {
                    for (var i = 0; i < steps; i++)
                    {
                        currentIndex++;

                        if (currentIndex > seq.Count -1)
                        {
                            currentIndex = 0;
                            initialDamage++;
                        }

                        seq[currentIndex] -= initialDamage;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", seq));
        }
    }
}
