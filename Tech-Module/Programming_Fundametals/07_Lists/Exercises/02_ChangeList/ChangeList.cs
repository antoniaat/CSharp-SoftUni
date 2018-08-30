namespace _02.ChangeList
{
    using System;
    using System.Linq;

    public class ChangeList
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var input = Console.ReadLine();

            while (input != "Odd" && input != "Even")
            {
                var command = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int i = 0; i < nums.Count; i++)
                {
                    if (command[0] == "Delete")
                    {
                        nums.Remove(int.Parse(command[1]));
                    }

                    else if (command[0] == "Insert")
                    {
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    }
                }

                input = Console.ReadLine();
            }
            
            if (input == "Odd")
            {
                foreach (var num in nums)
                {
                    if (num % 2 != 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }

            else if (input == "Even")
            {
                foreach (var num in nums)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
        }
    }
}
