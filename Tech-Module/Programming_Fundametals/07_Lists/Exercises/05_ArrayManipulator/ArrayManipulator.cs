namespace _05.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var lineOfDigits = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var lineOfCommands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (lineOfCommands[0] != "print")
            {
                switch (lineOfCommands[0])
                {
                    case "add":
                        lineOfDigits = AddComand(lineOfDigits, lineOfCommands);
                        break;
                    case "addMany":
                        lineOfDigits = AddManyComand(lineOfDigits, lineOfCommands);
                        break;
                    case "contains":
                        ContainsComand(lineOfDigits, lineOfCommands);
                        break;
                    case "remove":
                        lineOfDigits = RemoveComand(lineOfDigits, lineOfCommands);
                        break;
                    case "shift":
                        lineOfDigits = ShiftComand(lineOfDigits, lineOfCommands);
                        break;
                    case "sumPairs":
                        lineOfDigits = SumPairsComand(lineOfDigits, lineOfCommands);
                        break;
                }

                lineOfCommands = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            Console.Write("[");
            Console.Write(string.Join(", ", lineOfDigits));
            Console.WriteLine("]");
        }

        public static List<long> AddComand(List<long> lineOfDigits, List<string> lineOfCommands)
        {
            var index = int.Parse(lineOfCommands[1]);
            var element = long.Parse(lineOfCommands[2]);

            lineOfDigits.Insert(index, element);

            return lineOfDigits;
        }

        public static List<long> AddManyComand(List<long> lineOfDigits, List<string> lineOfCommands)
        {
            var index = int.Parse(lineOfCommands[1]);
            var addNumbers = new List<long>();

            for (var i = 2; i < lineOfCommands.Count; i++)
            {
                var element = long.Parse(lineOfCommands[i]);
                addNumbers.Add(element);
            }

            lineOfDigits.InsertRange(index, addNumbers);

            return lineOfDigits;
        }

        public static void ContainsComand(List<long> lineOfDigits, List<string> lineOfCommands)
        {
            var element = long.Parse(lineOfCommands[1]);
            var count = 0;

            for (var i = 0; i < lineOfDigits.Count; i++)
            {
                if (lineOfDigits[i] != element) continue;

                Console.WriteLine(i);
                count++;
                break;
            }

            if (count == 0)
            {
                Console.WriteLine("-1");
            }
        }

        public static List<long> RemoveComand(List<long> lineOfDigits, List<string> lineOfCommands)
        {
            var index = int.Parse(lineOfCommands[1]);
            lineOfDigits.RemoveAt(index);

            return lineOfDigits;
        }

        public static List<long> ShiftComand(List<long> lineOfDigits, List<string> lineOfCommands)
        {
            var positions = long.Parse(lineOfCommands[1]);

            for (var i = 0; i < positions; i++)
            {
                var firstNum = lineOfDigits[0];
                lineOfDigits.RemoveAt(0);
                lineOfDigits.Add(firstNum);
            }

            return lineOfDigits;
        }

        public static List<long> SumPairsComand(List<long> lineOfDigits, List<string> lineOfCommands)
        {
            if (lineOfDigits.Count % 2 == 0)
            {
                for (var i = 0; i < lineOfDigits.Count; i++)
                {
                    var sum = lineOfDigits[i] + lineOfDigits[i + 1];
                    lineOfDigits.RemoveAt(i);
                    lineOfDigits.RemoveAt(i);
                    lineOfDigits.Insert(i, sum);
                }
            }

            else
            {
                for (var i = 0; i < lineOfDigits.Count - 1; i++)
                {
                    var sum = lineOfDigits[i] + lineOfDigits[i + 1];
                    lineOfDigits.RemoveAt(i);
                    lineOfDigits.RemoveAt(i);
                    lineOfDigits.Insert(i, sum);
                }
            }

            return lineOfDigits;
        }
    }
}
