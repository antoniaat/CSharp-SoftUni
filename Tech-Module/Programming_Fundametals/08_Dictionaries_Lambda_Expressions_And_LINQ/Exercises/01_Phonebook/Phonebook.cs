namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split(' ');
                var command = tokens[0];

                if (command == "A")
                {
                    var newName = tokens[1];
                    var newPhone = tokens[2];
                    dictionary[newName] = newPhone;
                }

                if (command == "S")
                {
                    var name = tokens[1];

                    if (dictionary.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {dictionary[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
