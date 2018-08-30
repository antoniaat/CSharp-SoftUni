namespace _02_AnonymousThreat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AnonymousThreat
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var input = Console.ReadLine();

            while (input != "3:1")
            {
                var commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (commands[0] == "merge")
                {
                    MergeElements(commands, array);
                }
                else if (commands[0] == "divide")
                {
                    DivideElements(commands, array);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", array));
        }

        public static void DivideElements(List<string> commands, List<string> array)
        {
            var index = int.Parse(commands[1]);
            var partitions = int.Parse(commands[2]);

            var parts = new List<string>();

            if (array[index].Length % partitions == 0)
            {
                for (var i = 0; i < array[index].Length; i += array[index].Length / partitions)
                {
                    parts.Add(array[index].Substring(i, array[index].Length / partitions));
                }

                if (partitions != parts.Count)
                {
                    partitions--;
                    parts.Clear();
                    for (int i = 0; i < array[index].Length; i += partitions)
                    {
                        parts.Add(array[index].Substring(i, partitions));
                    }
                }
            }
            else
            {
                var lenght = array[index].Length;
                var splitLenght = lenght / partitions;
                partitions--;

                var currentParts = new StringBuilder();

                for (var i = 0; i < partitions; i += splitLenght)
                {
                    var currentPart = array[index].Substring(i, splitLenght);
                    parts.Add(currentPart);
                    currentParts.Append(currentPart);
                }

                var leftPart = array[index].Substring(currentParts.ToString().Length);
                parts.Add(leftPart);
            }

            array.RemoveAt(index);
            array.InsertRange(index, parts);
        }

        public static void MergeElements(List<string> commands, List<string> array)
        {
            var startIndex = int.Parse(commands[1]);
            var endIndex = int.Parse(commands[2]);
            var stringBuilder = new StringBuilder();

            if (startIndex < 0 || startIndex >= array.Count) startIndex = 0;
            if (endIndex < 0 || endIndex >= array.Count) endIndex = array.Count - 1;

            for (var i = startIndex; i <= endIndex; i++)
            {
                stringBuilder.Append(array[i]);
            }

            array.RemoveRange(startIndex, endIndex - startIndex + 1);
            array.Insert(startIndex, stringBuilder.ToString());
        }
    }
}