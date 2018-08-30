namespace _03.AMinerTask
{
    using System;
    using System.Collections.Generic;

    public class AMinerTask
    {
        public static void Main()
        {
            var resource = Console.ReadLine();

            var dictionary = new Dictionary<string, long>();

            while (resource != "stop")
            {
                var quantity = long.Parse(Console.ReadLine());

                if (dictionary.ContainsKey(resource))
                {
                    dictionary[resource] += quantity;
                }
                else
                {
                    dictionary[resource] = quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var input in dictionary.Keys)
            {
                Console.WriteLine($"{input} -> {dictionary[input]}");
            }
        }
    }
}
