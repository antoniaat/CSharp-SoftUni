namespace _02_Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = long.Parse(Console.ReadLine());
            var ladyBugs = new int[fieldSize];

            var indexesWithLadyBugs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            for (var i = 0; i < indexesWithLadyBugs.Length; i++)
            {
                ladyBugs[indexesWithLadyBugs[i]] = 1;
            }

            var input = Console.ReadLine();

            while (input != "end")
            {
                var commands = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var index = int.Parse(commands[0]);
                var command = commands[1];
                var flyLenght = int.Parse(commands[2]);

                if (command == "left")
                {
                    LeftFlight(ladyBugs, index, Math.Abs(flyLenght));
                }
                else if (command == "right")
                {
                    RightFlight(ladyBugs, index, Math.Abs(flyLenght));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladyBugs));
        }

        public static void RightFlight(int[] ladyBugs, int index, int flyLenght)
        {
            var count = 0;
            if (index < 0 || index > ladyBugs.Length - 1)
            {
                return;
            }
           

            for (var i = 0; i < ladyBugs.Length; i++)
            {
                if (i == index)
                {
                    if (ladyBugs[i] == 0 && count == flyLenght)
                    {
                        ladyBugs[i] = 1;
                        return;
                    }
                    ladyBugs[i] = 0;
                    count++;
                }
            }
        }

        public static void LeftFlight(int[] ladyBugs, int index, int flyLenght)
        {
            var count = 0;
            if (index < 0 || index > ladyBugs.Length - 1)
            {
                return;
            }

            for (var i = 0; i < ladyBugs.Length; i++)
            {
                if (i == index)
                {
                    for (var j = index; j > 0; j--)
                    {
                        if (ladyBugs[j] == 0 && count == flyLenght)
                        {
                            ladyBugs[j] = 1;
                            return;
                        }
                        ladyBugs[index] = 0;
                        count++;
                    }
                }
            }
        }
    }
}