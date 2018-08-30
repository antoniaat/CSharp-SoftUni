namespace _02_Manipulate_Array
{
    using System;
    using System.Linq;

    public class Manipulate_Array
    {
        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

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

                    array[index] = replaceString;
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
