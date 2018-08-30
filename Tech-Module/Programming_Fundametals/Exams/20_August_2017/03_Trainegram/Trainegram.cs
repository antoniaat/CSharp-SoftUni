namespace _03_Trainegram
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Trainegram
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var validTrains = new List<string>();

            while (input != "Traincode!")
            {
                if (Regex.IsMatch(input, @"^(<\[[\D\W]*\]\.)(\.\[[\d\w]*\]\.)*$"))
                {
                    validTrains.Add(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", validTrains));
        }
    }
}
