namespace _02.CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "end")
            {
                var commandName = input[0];

                try
                {
                    if (commandName == "reverse")
                    {
                        var index = int.Parse(input[2]);
                        var count = int.Parse(input[4]);

                        var reversedList = new List<string>();

                        for (int i = 0; i < count; i++)
                        {
                            reversedList.Add(array[index + i]);
                        }

                        reversedList.Reverse();
                        array.RemoveRange(index, count);
                        array.InsertRange(index, reversedList);
                    }

                    else if (commandName == "sort")
                    {
                        var index = int.Parse(input[2]);
                        var count = int.Parse(input[4]);

                        var sortedList = new List<string>();

                        for (int i = 0; i < count; i++)
                        {
                            sortedList.Add(array[index + i]);
                        }

                        sortedList.Sort();
                        array.RemoveRange(index, count);
                        array.InsertRange(index, sortedList);
                    }

                    else if (commandName == "rollLeft")
                    {
                        var count = int.Parse(input[1]);

                        for (int i = 0; i < count; i++)
                        {
                            var firstElement = array[0];

                            array.Remove(array[0]);
                            array.Add(firstElement);
                        }
                    }

                    else if (commandName == "rollRight")
                    {
                        var count = int.Parse(input[1]);

                        for (int i = 0; i < count; i++)
                        {
                            var lastElementIndex = array.Count - 1;
                            var lastElementValue = array[lastElementIndex];

                            array.Remove(array[lastElementIndex]);
                            array.Insert(0, lastElementValue);
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid input parameters.");
                }

                input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
