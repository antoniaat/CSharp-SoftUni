namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibraryModification
    {
        public static void Main()
        {
            var libraries = ReadLibraries();
            var lastDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var dict = new Dictionary<string, DateTime>();

            foreach (var lib in libraries)
            {
                if (lib.ReleaseDate >= lastDate)
                {
                    if (!dict.ContainsKey(lib.Title))
                    {
                        dict.Add(lib.Title, lib.ReleaseDate);
                    }
                    else
                    {
                        dict[lib.Title] = lib.ReleaseDate;
                    }
                }
            }

            foreach (var kvp in dict.OrderBy(s => s.Value).ThenBy(a => a.Key))
            {
                var date = kvp.Value;
                var currentDate = String.Format("{0:dd.MM.yyyy}", date);

                Console.WriteLine($"{kvp.Key} -> {currentDate}");
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