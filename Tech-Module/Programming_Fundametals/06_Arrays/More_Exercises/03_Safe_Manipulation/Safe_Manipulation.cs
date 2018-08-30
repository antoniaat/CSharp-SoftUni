namespace _03_Safe_Manipulation
{
    using System;
    using System.Linq;

    public class Safe_Manipulation
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "END")
            {
                if (command[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (command[0] == "Reverse")
                {
                    array = array.Reverse().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    var index = int.Parse(command[1]);
                    var replaceString = command[2];

                    try
                    {
                        array[index] = replaceString;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                        Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
