namespace _05.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibrary
    {
        private static void Main()
        {
            var libraries = ReadLibraries();

            var dict = new Dictionary<string, decimal>();

            foreach (var lib in libraries)
            {
                if (!dict.ContainsKey(lib.Author))
                {
                    dict.Add(lib.Author, lib.Price);
                }
                else
                {
                    dict[lib.Author] += lib.Price;
                }
            }

            foreach (var kvp in dict.OrderByDescending(s => s.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }

        private static Library[] ReadLibraries()
        {
            var n = int.Parse(Console.ReadLine());

            var libraries = new Library[n];

            for (var i = 0; i < n; i++)
            {
                libraries[i] = ReadLibrary();
            }

            return libraries;
        }

        public static Library ReadLibrary()
        {
            var currentLibrary = Console.ReadLine().Split();

            return new Library()
            {
                Title = currentLibrary[0],
                Author = currentLibrary[1],
                Publisher = currentLibrary[2],
                ReleaseDate = DateTime.ParseExact(currentLibrary[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = int.Parse(currentLibrary[4]),
                Price = decimal.Parse(currentLibrary[5])
            };
        }
    }
}