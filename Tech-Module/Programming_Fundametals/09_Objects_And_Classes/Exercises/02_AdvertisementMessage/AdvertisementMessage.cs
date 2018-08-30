namespace _02.AdvertisementMessage
{
    using System;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            string[] phrases =
            {
                    "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."
                };

            string[] events =
            {
                    "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
                };

            string[] authors = {"Diana",
                    "Petya",
                    "Stella",
                    "Elena",
                    "Katya",
                    "Iva",
                    "Annie",
                    "Eva"
                };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var rnd = new Random();

            for (var i = 0; i < n; i++)
            {
                var randomIndexPhrases = phrases[rnd.Next(0, phrases.Length)];
                var randomIndexEvents = events[rnd.Next(0, events.Length)];
                var randomIndexAuthors = authors[rnd.Next(0, authors.Length)];
                var randomIndexCities = cities[rnd.Next(0, cities.Length)];

                Console.WriteLine($"{randomIndexPhrases} {randomIndexEvents} {randomIndexAuthors} {randomIndexCities}");
            }
        }
    }
}